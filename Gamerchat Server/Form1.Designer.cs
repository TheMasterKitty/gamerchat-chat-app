namespace MasterControl_HQ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Headers", System.Windows.Forms.HorizontalAlignment.Center);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.bannedListView = new System.Windows.Forms.ListView();
            this.nameBanned = new System.Windows.Forms.ColumnHeader();
            this.ipBanned = new System.Windows.Forms.ColumnHeader();
            this.savedBanned = new System.Windows.Forms.ColumnHeader();
            this.viewBanned = new System.Windows.Forms.ColumnHeader();
            this.fileBanned = new System.Windows.Forms.ColumnHeader();
            this.connectionListView = new System.Windows.Forms.ListView();
            this.nameConnections = new System.Windows.Forms.ColumnHeader();
            this.ipConnections = new System.Windows.Forms.ColumnHeader();
            this.clientIdConnections = new System.Windows.Forms.ColumnHeader();
            this.mutedConnections = new System.Windows.Forms.ColumnHeader();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button18 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button17 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(896, 639);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.TabStop = false;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(888, 603);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat Text";
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(823, 566);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(62, 29);
            this.button8.TabIndex = 2;
            this.button8.Text = "Send";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.Location = new System.Drawing.Point(8, 568);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(809, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.WordWrap = false;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.CadetBlue;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(8, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(872, 552);
            this.listBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.button16);
            this.tabPage2.Controls.Add(this.button15);
            this.tabPage2.Controls.Add(this.button14);
            this.tabPage2.Controls.Add(this.button13);
            this.tabPage2.Controls.Add(this.bannedListView);
            this.tabPage2.Controls.Add(this.connectionListView);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button12);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(888, 603);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Connections";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(537, 17);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "Unmute";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Green;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(568, 312);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(150, 29);
            this.button16.TabIndex = 13;
            this.button16.Text = "Undo Selected Bans";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Red;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Location = new System.Drawing.Point(166, 312);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(150, 29);
            this.button15.TabIndex = 12;
            this.button15.Text = "Save Selected Bans";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Green;
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.Location = new System.Drawing.Point(626, 14);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(148, 29);
            this.button14.TabIndex = 11;
            this.button14.Text = "Mute Selected";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Red;
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.ForeColor = System.Drawing.Color.White;
            this.button13.Location = new System.Drawing.Point(166, 14);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(150, 29);
            this.button13.TabIndex = 10;
            this.button13.Text = "Ban Selected";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // bannedListView
            // 
            this.bannedListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.bannedListView.BackColor = System.Drawing.Color.Gray;
            this.bannedListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bannedListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameBanned,
            this.ipBanned,
            this.savedBanned,
            this.viewBanned,
            this.fileBanned});
            this.bannedListView.ForeColor = System.Drawing.Color.White;
            this.bannedListView.FullRowSelect = true;
            this.bannedListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.bannedListView.HideSelection = true;
            this.bannedListView.LabelWrap = false;
            this.bannedListView.Location = new System.Drawing.Point(12, 353);
            this.bannedListView.Name = "bannedListView";
            this.bannedListView.ShowGroups = false;
            this.bannedListView.Size = new System.Drawing.Size(870, 242);
            this.bannedListView.TabIndex = 9;
            this.bannedListView.UseCompatibleStateImageBehavior = false;
            this.bannedListView.View = System.Windows.Forms.View.Details;
            // 
            // nameBanned
            // 
            this.nameBanned.Text = "Name";
            this.nameBanned.Width = 225;
            // 
            // ipBanned
            // 
            this.ipBanned.Text = "IP Address";
            this.ipBanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipBanned.Width = 200;
            // 
            // savedBanned
            // 
            this.savedBanned.Text = "Ban Saved";
            this.savedBanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.savedBanned.Width = 100;
            // 
            // viewBanned
            // 
            this.viewBanned.Text = "Allowed to View";
            this.viewBanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.viewBanned.Width = 130;
            // 
            // fileBanned
            // 
            this.fileBanned.Text = "Banned From File";
            this.fileBanned.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fileBanned.Width = 215;
            // 
            // connectionListView
            // 
            this.connectionListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.connectionListView.BackColor = System.Drawing.Color.Gray;
            this.connectionListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.connectionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameConnections,
            this.ipConnections,
            this.clientIdConnections,
            this.mutedConnections});
            this.connectionListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connectionListView.ForeColor = System.Drawing.Color.White;
            this.connectionListView.FullRowSelect = true;
            listViewGroup1.Header = "Headers";
            listViewGroup1.HeaderAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            listViewGroup1.Name = "listViewGroup1";
            this.connectionListView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.connectionListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.connectionListView.HideSelection = true;
            this.connectionListView.LabelWrap = false;
            this.connectionListView.Location = new System.Drawing.Point(10, 49);
            this.connectionListView.Name = "connectionListView";
            this.connectionListView.ShowGroups = false;
            this.connectionListView.Size = new System.Drawing.Size(870, 253);
            this.connectionListView.TabIndex = 8;
            this.connectionListView.UseCompatibleStateImageBehavior = false;
            this.connectionListView.View = System.Windows.Forms.View.Details;
            // 
            // nameConnections
            // 
            this.nameConnections.Text = "Name";
            this.nameConnections.Width = 300;
            // 
            // ipConnections
            // 
            this.ipConnections.Text = "IP Addresses";
            this.ipConnections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ipConnections.Width = 250;
            // 
            // clientIdConnections
            // 
            this.clientIdConnections.Text = "Client Id (Temporary)";
            this.clientIdConnections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clientIdConnections.Width = 195;
            // 
            // mutedConnections
            // 
            this.mutedConnections.Text = "Muted";
            this.mutedConnections.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mutedConnections.Width = 125;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Green;
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(780, 14);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(100, 29);
            this.button11.TabIndex = 7;
            this.button11.Text = "Mute All";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(10, 14);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(150, 29);
            this.button12.TabIndex = 6;
            this.button12.Text = "Ban All";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Green;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(724, 312);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(150, 29);
            this.button10.TabIndex = 5;
            this.button10.Text = "Undo All Bans";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Red;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(10, 312);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(150, 29);
            this.button9.TabIndex = 4;
            this.button9.Text = "Save All Bans";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(383, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "BANNED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(357, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONNECTED";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.button18);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.button7);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 32);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(888, 603);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Server Options";
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button18.ForeColor = System.Drawing.Color.DarkRed;
            this.button18.Location = new System.Drawing.Point(635, 86);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(245, 35);
            this.button18.TabIndex = 10;
            this.button18.Text = "Set Room Name";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(635, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(245, 27);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "New Room";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.Gray;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button17.ForeColor = System.Drawing.Color.White;
            this.button17.Location = new System.Drawing.Point(8, 32);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(109, 68);
            this.button17.TabIndex = 8;
            this.button17.Text = "LOCK ROOM";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.SteelBlue;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button7.FlatAppearance.BorderSize = 2;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button7.Location = new System.Drawing.Point(387, 486);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 34);
            this.button7.TabIndex = 7;
            this.button7.Text = "GENEREATE";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(385, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Room Code:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(400, 406);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 35);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button6.FlatAppearance.BorderSize = 2;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(400, 326);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(88, 35);
            this.button6.TabIndex = 4;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(400, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 35);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(400, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 35);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(400, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 35);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(827, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.StartServer);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(302, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(523, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "CODES";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(896, 639);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "GamerChat Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private Button button6;
        private Label label1;
        private Button button7;
        private ListBox listBox1;
        private Button button8;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private ListView bannedListView;
        private ListView connectionListView;
        private ColumnHeader nameBanned;
        private ColumnHeader ipBanned;
        private ColumnHeader savedBanned;
        private ColumnHeader viewBanned;
        private ColumnHeader fileBanned;
        private ColumnHeader nameConnections;
        private ColumnHeader ipConnections;
        private ColumnHeader clientIdConnections;
        private ColumnHeader mutedConnections;
        private Label label4;
        private Button button14;
        private Button button13;
        private Button button15;
        private Button button16;
        private CheckBox checkBox1;
        private Button button17;
        private TextBox textBox2;
        private Button button18;
    }
}