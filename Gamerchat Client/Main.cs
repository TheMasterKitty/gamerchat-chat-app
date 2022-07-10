using System.DirectoryServices.AccountManagement;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SchoolBypass_PRO
{
    public partial class Main : Form
    {
        IPEndPoint connection;
        Socket connector;
        int clientNumber = -1;
        CancellationTokenSource token = new();
        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            DoubleBuffered = true;
        }
        public static IPAddress GetIP()
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

        private async void Connect()
        {
            try
            {
                chatItems.Items.Clear();
                string connectionCode = Microsoft.VisualBasic.Interaction.InputBox("What is your connection code?", "SchoolBypass PRO", "");
                string roomCode = Microsoft.VisualBasic.Interaction.InputBox("What is your room code?", "SchoolBypass PRO", "");
                label3.Text = "CONNECTION: " + connectionCode + "+ROOM: " + roomCode;
                connection = new IPEndPoint(IPAddress.Parse(String.Join(".", GetIP().ToString().Split(".")[..2]) + "." + connectionCode), int.Parse(roomCode));
                connector = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                connector.Connect(connection);
                await Task.Run(RecieveMsg, token.Token);
                panel1.Visible = true;
                button1.Enabled = false;
            }
            catch
            {
                DialogResult dialog = MessageBox.Show("Server Not Found!", "SchoolBypass PRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                if (dialog == DialogResult.Retry)
                {
                    sendBtn.Enabled = true;
                    sendText.Enabled = true;
                    privateMsg.Enabled = true;
                    privateMsgReciever.Enabled = true;
                    button1_Click(null, null);
                }
            }
        }

        private async void RecieveMsg()
        {
            while (true)
            {
                try
                {
                    byte[] buffer = new byte[8192];
                    connector.Receive(buffer);
                    string recieved = Encoding.ASCII.GetString(buffer);
                    if (recieved.StartsWith("maxcap"))
                    {
                        MessageBox.Show("The maximum capacity of the server (256 connections) has been reached.\nPlease try again in a few minutes.", "SchoolBypass PRO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        token.Cancel();
                        connector.Disconnect(true);
                        panel1.Visible = false;
                        button1.Enabled = true;

                    }
                    else if (recieved.StartsWith("locked"))
                    {
                        MessageBox.Show("The server you are trying to connect to is locked. Please ask the owner to unlock it.", "SchoolBypass PRO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        token.Cancel();
                        connector.Disconnect(true);
                        panel1.Visible = false;
                        button1.Enabled = true;
                    }
                    else if (recieved.StartsWith("alreadyin"))
                    {
                        MessageBox.Show("You are already inside of this server. Leave first to join back.", "SchoolBypass PRO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        Application.Exit();
                    }
                    else if (recieved.StartsWith("ban"))
                    {
                        if (recieved.Contains(":view"))
                        {
                            MessageBox.Show("You have been banned from this server. For now, you may view the server.", "SchoolBypass PRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            sendBtn.Enabled = false;
                            sendText.Enabled = false;
                            privateMsg.Enabled = false;
                            privateMsgReciever.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("You have been banned from this server.", "SchoolBypass PRO", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                            token.Cancel();
                            connector.Disconnect(true);
                            panel1.Visible = false;
                            button1.Enabled = true;
                        }
                    }
                    else if (recieved.StartsWith("unban"))
                    {
                        MessageBox.Show("You have been unbanned from this server.", "SchoolBypass PRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        sendBtn.Enabled = true;
                        sendText.Enabled = true;
                        privateMsg.Enabled = true;
                        privateMsgReciever.Enabled = true;
                    }
                    else if (recieved.StartsWith("people:"))
                    {
                        privateMsgReciever.Items.Clear();
                        foreach (string s in recieved.Replace("people:", "").Split(","))
                        {
                            if (!string.IsNullOrWhiteSpace(s) && !isOnlyRepeating(s))
                            {
                                privateMsgReciever.Items.Add(s);
                            }
                        }
                    }
                    else if (recieved.StartsWith("info:"))
                    {
                        clientNumber = int.Parse(recieved.Split(":")[1]);
                        label2.Text = String.Join(":", recieved.Split(":")[2..]);
                        connector.Send(Encoding.ASCII.GetBytes("connect:" + clientNumber.ToString() + ":" + UserPrincipal.Current.DisplayName + ":" + GetIP().ToString()));
                    }
                    else if (recieved.StartsWith("roomname:"))
                    {
                        label2.Text = String.Join(":", recieved.Split(":")[1..]);
                    }
                    else if (recieved.StartsWith("chat:"))
                    {
                        string recievedChat = recieved[5..];
                        int remaining = recievedChat.Split("@/newline/@").Length;
                        foreach (string str in string.Join("", recievedChat.Split(":")[1..]).Split("@/newline/@"))
                        {
                            chatItems.Items.Add(recievedChat.Split(":")[0] + ":" + (remaining == recievedChat.Split("@/newline/@").Length ? "" : " ") + str + (remaining > 1 ? Environment.NewLine : ""));
                            remaining--;
                        }
                    }
                    else if (recieved.StartsWith("shutdown"))
                    {
                        connector.Disconnect(true);
                        MessageBox.Show("You have been disconnected from the room due to the room closing.", "SchoolBypass PRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        panel1.Visible = false;
                    }
                    if (!connector.Connected)
                    {
                        break;
                    }
                }
                catch
                {
                    if (!connector.Connected)
                    {
                        break;
                    }
                }
                await Task.Delay(200);
            }
            button1.Enabled = true;
            if (panel1.Visible)
            {
                DialogResult dialog = MessageBox.Show("Disconnected... Reconnect?", "SchoolBypass PRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dialog == DialogResult.Yes)
                {
                    Connect();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        private bool isOnlyRepeating(string input)
        {
            char last = (Char)0;
            bool set = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (!set)
                {
                    last = input[i];
                    set = true;
                }
                else if (last != input[i])
                {
                    return false;
                }
            }
            return true;
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Size = new Size(758, 664);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(sendText.Text) && connector != null && connector.Connected)
            {
                if (privateMsg.Checked)
                {
                    if (privateMsgReciever.SelectedIndex != -1)
                    {
                        connector.Send(Encoding.ASCII.GetBytes("pmsg:" + privateMsgReciever.GetItemText(privateMsgReciever.SelectedItem) + ":" + clientNumber + ":" + sendText.Text.ReplaceLineEndings("@/newline/@")));
                        string recievedChat = "TO: " + privateMsgReciever.GetItemText(privateMsgReciever.SelectedItem) + ": " + sendText.Text.ReplaceLineEndings("@/newline/@");
                        int remaining = recievedChat.Split("@/newline/@").Length;
                        foreach (string str in string.Join("", recievedChat.Split(":")[1..]).Split("@/newline/@"))
                        {
                            chatItems.Items.Add("TO:" + recievedChat.Split(":")[1] + ":" + (remaining == recievedChat.Split("@/newline/@").Length ? "" : " ") + str + (remaining > 1 ? Environment.NewLine : ""));
                            remaining--;
                        }
                    }
                }
                else
                {
                    connector.Send(Encoding.ASCII.GetBytes("msg:" + clientNumber + ":" + sendText.Text.ReplaceLineEndings("@/newline/@")));
                }
                sendText.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            token.Cancel();
            connector.Disconnect(true);
            panel1.Visible = false;
            button1.Enabled = true;
        }
    }
}