using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace MasterControl_HQ
{
    public partial class Form1 : Form
    {
        Socket[] connections = new Socket[64];
        string[] connectionNames = new string[65];
        string[] connectionIPs = new string[64];
        string[] bannedNames = new string[64];
        string[] bannedNamesView = new string[64];
        string[] mutedIPs = new string[64];
        string roomName = "New Room";
        CancellationTokenSource cancellation = new CancellationTokenSource();
        bool started = false;
        int nextOpen = 0;
        int port;
        IPEndPoint serverEndPoint;
        Socket master;
        bool running = true;
        private bool CheckAvailableServerPort(int port)
        {
            bool isAvailable = true;
            IPGlobalProperties ipGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] objEndPoints = ipGlobalProperties.GetActiveTcpListeners();
            foreach (IPEndPoint endpoint in objEndPoints)
            {
                if (endpoint.Port == port)
                {
                    isAvailable = false;
                    break;
                }
            }
            return isAvailable;
        }
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DoubleBuffered = true;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("bans.txt"))
            {
                File.Create("bans.txt");
            }
            connectionNames[64] = "Owner";
            button7_Click(null, null);
            button2_Click(null, null);
        }
        private async void RecieveMessage()
        {
            while (running)
            {
                foreach (Socket socket in connections)
                {
                    try
                    {
                        if (socket != null)
                        {
                            byte[] buffer = new byte[8192];
                            socket.Receive(buffer);
                            string recieved = Encoding.ASCII.GetString(buffer);
                            if (recieved.StartsWith("StartServer:"))
                            {
                                string[] parts = recieved.Split(":")[1..];
                                string ipv6 = "";
                                foreach (string part in parts[2..])
                                {
                                    ipv6 += part + ":";
                                }
                                ipv6 = ipv6.TrimEnd(':');
                                if (!connectionIPs.Contains(ipv6) && !bannedNames.Contains(parts[1]))
                                {
                                    int clientNumber = int.Parse(parts[0]);
                                    connectionNames[clientNumber] = parts[1];
                                    connectionIPs[clientNumber] = ipv6;
                                    connectionListView.Items.Add(new ListViewItem(new String[] { parts[1], ipv6, clientNumber.ToString(), mutedIPs.Contains(ipv6).ToString() }));
                                }
                                else if (connectionIPs.Contains(ipv6) && !bannedNames.Contains(parts[1]))
                                {
                                    socket.Send(Encoding.ASCII.GetBytes("alreadyin"));
                                    connections[int.Parse(recieved.Split(":")[1])] = null;
                                    connectionIPs[int.Parse(recieved.Split(":")[1])] = null;
                                    connectionNames[int.Parse(recieved.Split(":")[1])] = null;
                                }
                                else if (bannedNames.Contains(parts[1]))
                                {
                                    socket.Send(Encoding.ASCII.GetBytes("ban" + (bannedNamesView.Contains(parts[1]) ? ":view" : "")));
                                    connections[int.Parse(recieved.Split(":")[1])] = null;
                                    connectionIPs[int.Parse(recieved.Split(":")[1])] = null;
                                    connectionNames[int.Parse(recieved.Split(":")[1])] = null;
                                }
                            }
                            else if (recieved.StartsWith("msg:"))
                            {
                                if (mutedIPs.Contains(connectionIPs[Array.IndexOf(connections, socket)]))
                                {
                                    socket.Send(Encoding.ASCII.GetBytes("chat:You are muted and therefore cannot public send messages."));
                                }
                                else
                                {
                                    string message = connectionNames[int.Parse(recieved.Split(":")[1])] + ": " + recieved.Split(":")[2];
                                    int remaining = message.Split("@/newline/@").Length;
                                    foreach (string str in string.Join("", message.Split(":")[1..]).Split("@/newline/@"))
                                    {
                                        listBox1.Items.Add(message.Split(":")[0] + ":" + (remaining == message.Split("@/newline/@").Length ? "" : " ") + str + (remaining > 1 ? Environment.NewLine : ""));
                                        remaining--;
                                    }
                                    foreach (Socket s in connections)
                                    {
                                        if (s != null)
                                        {
                                            s.Send(Encoding.ASCII.GetBytes("chat:" + message));
                                        }
                                    }
                                }
                            }
                            else if (recieved.StartsWith("pmsg:"))
                            {
                                string message = "FROM: " + connectionNames[int.Parse(recieved.Split(":")[2])] + ": " + recieved.Split(":")[3];
                                int index = Array.IndexOf(connectionNames, recieved.Split(":")[1]);
                                if (index == 64)
                                {
                                    int remaining = message.Split("@/newline/@").Length;
                                    foreach (string str in string.Join("", message.Split(":")[2..]).Split("@/newline/@"))
                                    {
                                        listBox1.Items.Add(message.Split(":")[0] + ":" + message.Split(":")[1] + ":" + (remaining == message.Split("@/newline/@").Length ? "" : " ") + str + (remaining > 1 ? Environment.NewLine : ""));
                                        remaining--;
                                    }
                                }
                                else
                                {
                                    connections[index].Send(Encoding.ASCII.GetBytes(message));
                                }
                            }
                        }
                    }
                    catch { }
                }
                await Task.Delay(25);
            }
        }
        private async void ClearExtra()
        {
            while (running)
            {
                int on = 0;
                foreach (Socket socket in connections)
                {
                    if (socket == null || !socket.Connected)
                    {
                        string ip = connectionIPs[on];
                        connections[on] = null;
                        connectionIPs[on] = null;
                        connectionNames[on] = null;
                        bannedNames[on] = null;
                        bannedNamesView[on] = null;
                        mutedIPs[on] = null;
                        if (ip != null)
                        {
                            foreach (ListViewItem row in connectionListView.Items)
                            {
                                if (row.SubItems[1].Text.Contains(ip))
                                {
                                    row.Remove();
                                }
                            }
                        }
                    }
                    on++;
                }
                await Task.Delay(50);
            }
        }
        private async void AcceptConnection()
        {
            try
            {
                master.Listen();
                while (running)
                {
                    try
                    {
                        Socket client = master.Accept();
                        string send = "";
                        if (nextOpen == -1)
                        {
                            int current = 0;
                            foreach (Socket connection in connections)
                            {
                                if (connection == null)
                                {
                                    nextOpen = current;
                                    break;
                                }
                                current++;
                            }
                        }
                        if (nextOpen == -1)
                        {
                            client.Send(Encoding.ASCII.GetBytes("maxcap"));
                        }
                        else if (button17.Text.StartsWith("UNLOCK"))
                        {
                            client.Send(Encoding.ASCII.GetBytes("locked"));
                        }
                        else
                        {
                            connections[nextOpen] = client;
                            client.Send(Encoding.ASCII.GetBytes("info:" + nextOpen.ToString() + ":" + roomName));
                            foreach (string s in connectionNames)
                            {
                                if (!string.IsNullOrWhiteSpace(s))
                                {
                                    send += s + ",";
                                }
                            }
                            int current2 = 0;
                            await Task.Delay(200);
                            foreach (Socket socket in connections)
                            {
                                try
                                {
                                    if (socket != null)
                                    {
                                        socket.Send(Encoding.ASCII.GetBytes("people:" + send.Replace(connectionNames[current2] + ",", "")));
                                    }
                                    current2++;
                                }
                                catch { }
                            }
                            if (nextOpen + 1 == connections.Length)
                            {
                                int current = 0;
                                bool found = false;
                                foreach (Socket connection in connections)
                                {
                                    if (connection == null)
                                    {
                                        nextOpen = current;
                                        found = true;
                                        break;
                                    }
                                    current++;
                                }
                                if (!found)
                                {
                                    nextOpen = -1;
                                }
                            }
                            else if (connections[nextOpen + 1] == null)
                            {
                                nextOpen++;
                            }
                            else
                            {
                                int current = 0;
                                bool found = false;
                                foreach (Socket connection in connections)
                                {
                                    if (connection == null)
                                    {
                                        nextOpen = current;
                                        found = true;
                                        break;
                                    }
                                    current++;
                                }
                                if (!found)
                                {
                                    nextOpen = -1;
                                }
                            }
                        }
                    }
                    catch { }
                    await Task.Delay(200);
                }
            }
            catch { }
        }

        public IPAddress GetIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            return null;
        }
        private async void StartServer(object sender, EventArgs e)
        {
            if (started)
            {
                if (MessageBox.Show("Are you sure you would like to stop the server? This will kick everyone out.", "MasterControl HQ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    cancellation.Cancel();
                    int connectionOn = 0;
                    foreach (Socket s in connections)
                    {
                        if (s != null)
                        {
                            try
                            {
                                s.Send(Encoding.ASCII.GetBytes("shutdown"));
                            }
                            catch { }
                            await Task.Delay(20);
                            s.Shutdown(SocketShutdown.Both);
                            connections[connectionOn] = null;
                            connectionNames[connectionOn] = null;
                            connectionIPs[connectionOn] = null;
                        }
                        connectionOn++;
                    }
                    started = false;
                    master = null;
                    serverEndPoint = null;
                    label4.Text = "CODES";
                    button1.Text = "Start";
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button7_Click(null, null);
                    button2_Click(null, null);
                    listBox1.Items.Clear();
                }
            }
            else
            {
                try
                {
                    cancellation = new CancellationTokenSource();
                    serverEndPoint = new IPEndPoint(IPAddress.Any, port);
                    master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    master.Bind(serverEndPoint);
                    button1.Text = "Stop";
                    started = true;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    await Task.Run(() => {
                        label4.Text = "CONNECTION CODE: " + GetIP().ToString().Split(".")[3] + " +   ROOM CODE: " + port.ToString();
                        MessageBox.Show("Server Successfully Started. CONNECTION CODE: " + GetIP().ToString().Split(".")[3] + " & ROOM CODE: " + port.ToString(), "MasterControl HQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    });
                    await Task.Run(AcceptConnection, cancellation.Token);
                    await Task.Run(RecieveMessage, cancellation.Token);
                    await Task.Run(ClearExtra, cancellation.Token);
                    try
                    {
                        foreach (string s in File.ReadAllLines("bans.txt"))
                        {
                            if (!string.IsNullOrWhiteSpace(s))
                            {
                                bannedListView.Items.Add(new ListViewItem(new string[] { s.Split(":")[0], "Unkown", "True", s.Split(":")[1], "True" }));
                            }
                        }
                    }
                    catch (Exception) { }
                }
                catch (Exception ex)
                {
                    running = false;
                    MessageBox.Show("Error while starting sever.\n" + ex.ToString(), "MasterControl HQ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int confirmed = 0;
            int[] ports = new int[5];
            while (confirmed < 5)
            {
                try
                {
                    int testPort = rnd.Next(1024, 65535);
                    if (CheckAvailableServerPort(testPort))
                    {
                        ports[confirmed] = testPort;
                        confirmed++;
                    }
                }
                catch { }
            }
            button2.Text = ports[0].ToString();
            button3.Text = ports[1].ToString();
            button4.Text = ports[2].ToString();
            button5.Text = ports[3].ToString();
            button6.Text = ports[4].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            port = int.Parse(button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            port = int.Parse(button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = false;
            button5.Enabled = true;
            button6.Enabled = true;
            port = int.Parse(button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;
            button6.Enabled = true;
            port = int.Parse(button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            port = int.Parse(button6.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string message = "[BROADCAST] " + textBox1.Text;
            listBox1.Items.Add(message);
            foreach (Socket s in connections)
            {
                if (s != null)
                {
                    s.Send(Encoding.ASCII.GetBytes("chat:" + message));
                }
            }
            textBox1.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button8_Click(null, null);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to " + (checkBox1.Checked ? "unmute" : "mute") + " everyone on this server?", "MasterControl HQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int on = 0;
                foreach (Socket s in connections)
                {
                    if (s != null)
                    {
                        mutedIPs[on] = checkBox1.Checked ? null : connectionIPs[on];
                    }
                    on++;
                }
                foreach (ListViewItem item in connectionListView.Items)
                {
                    item.SubItems[3].Text = checkBox1.Checked ? "False" : "True";
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you would like to ban everyone on this server?", "MasterControl HQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool allowView = MessageBox.Show("Should they be able to view this server?", "MasterControl HQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                int on = 0;
                foreach (Socket s in connections)
                {
                    if (s != null)
                    {
                        bannedNames[on] = connectionNames[on];
                        bannedListView.Items.Add(new ListViewItem(new String[] { connectionNames[on], connectionIPs[on], "False", allowView.ToString(), "False" }));
                        if (allowView)
                        {
                            bannedNamesView[on] = connectionNames[on];
                            s.Send(Encoding.ASCII.GetBytes("ban:view"));
                        }
                        else
                        {
                            s.Send(Encoding.ASCII.GetBytes("ban"));
                        }
                    }
                    on++;
                }
                connectionListView.Items.Clear();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (connectionListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You can't ban 0 people.", "MasterControl HQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure you would like to ban " + connectionListView.SelectedItems.Count + (connectionListView.SelectedItems.Count > 1 ? " people?" : " person?"), "MasterControl HQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool allowView = MessageBox.Show("Should they be able to view this server?", "MasterControl HQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                for (int on = 0; on < connectionListView.SelectedItems.Count; on++)
                {
                    int index = Array.IndexOf(connectionIPs, connectionListView.SelectedItems[on].SubItems[1].Text);
                    bannedListView.Items.Add(new ListViewItem(new String[] { connectionListView.SelectedItems[on].SubItems[0].Text, connectionListView.SelectedItems[on].SubItems[1].Text, "False", allowView.ToString(), "False"}));
                    connectionListView.Items.Remove(connectionListView.SelectedItems[on]);
                    bannedNames[index] = connectionNames[index];
                    if (allowView)
                    {
                        bannedNamesView[on] = connectionNames[on];
                        connections[index].Send(Encoding.ASCII.GetBytes("ban:view"));
                    }
                    else
                    {
                        connections[index].Send(Encoding.ASCII.GetBytes("ban"));
                    }
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (connectionListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You can't " + (checkBox1.Checked ? "unmute" : "mute") + " 0 people.", "MasterControl HQ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Are you sure you would like to " + (checkBox1.Checked ? "unmute " : "mute ") + connectionListView.SelectedItems.Count + (connectionListView.SelectedItems.Count > 1 ? " people?" : " person?"), "MasterControl HQ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int on = 0; on < connectionListView.SelectedItems.Count; on++)
                {
                    int index = Array.IndexOf(connectionIPs, connectionListView.SelectedItems[on].SubItems[1].Text);
                    mutedIPs[index] = checkBox1.Checked ? null : connectionIPs[index];
                    connectionListView.SelectedItems[on].SubItems[3].Text = (checkBox1.Checked ? "False" : "True");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (string s in bannedNames)
            {
                if (s != null && !File.ReadAllText("bans.txt").Contains(s))
                {
                    File.AppendAllText("bans.txt", s + (bannedNamesView.Contains(s) ? ":True" : ":False") + Environment.NewLine);
                }
            }
            foreach (ListViewItem row in bannedListView.Items)
            {
                row.SubItems[2].Text = "True";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            for (int on = 0; on < bannedListView.SelectedItems.Count; on++)
            {
                if (!File.ReadAllText("bans.txt").Contains(bannedListView.SelectedItems[on].SubItems[0].Text))
                {
                    File.AppendAllText("bans.txt", bannedListView.SelectedItems[on].SubItems[0].Text + (bannedNamesView.Contains(bannedListView.SelectedItems[on].SubItems[0].Text) ? ":True" : ":False") + Environment.NewLine);
                }
                bannedListView.SelectedItems[on].SubItems[2].Text = "True";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int on = 0; on < bannedListView.SelectedItems.Count; on++)
            {
                int index = Array.IndexOf(bannedNames, bannedListView.SelectedItems[on].SubItems[0].Text);
                bannedNames[index] = null;
                bannedNamesView[index] = null;
                bannedListView.Items.Remove(bannedListView.SelectedItems[on]);
                string fileText = "";
                foreach (string line in File.ReadAllLines("bans.txt"))
                {
                    if (line != bannedListView.SelectedItems[on].SubItems[0].Text)
                    {
                        fileText += line + Environment.NewLine;
                    }
                }
                File.WriteAllText("bans.txt", fileText);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int on = 0;
            foreach (Socket s in connections)
            {
                if (bannedNames.Contains(connectionNames[on]) && s != null)
                {
                    s.Send(Encoding.ASCII.GetBytes("unban"));
                }
            }
            bannedNames = new string[64];
            bannedNamesView = new string[64];
            File.WriteAllText("bans.txt", "");
            bannedListView.Items.Clear();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            e.Cancel = e.TabPageIndex == 1 && master == null;
            if (e.Cancel)
            {
                MessageBox.Show("Start the server to access connections.", "MasterControl HQ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            roomName = textBox2.Text;
            foreach (Socket s in connections)
            {
                if (s != null)
                {
                    s.Send(Encoding.ASCII.GetBytes("roomname:" + roomName));
                }
            }
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Size = new Size(914, 686);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (button17.Text.StartsWith("LOCK"))
            {
                button17.Text = "UNLOCK ROOM";
            }
            else
            {
                button17.Text = "LOCK ROOM";
            }
        }
    }
}