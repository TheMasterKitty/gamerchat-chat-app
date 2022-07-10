namespace SchoolBypass_PRO
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.privateMsg = new System.Windows.Forms.CheckBox();
            this.privateMsgReciever = new System.Windows.Forms.ComboBox();
            this.sendText = new System.Windows.Forms.RichTextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.chatItems = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "CHAT CONNECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.LightBlue;
            this.button4.Location = new System.Drawing.Point(641, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 30);
            this.button4.TabIndex = 3;
            this.button4.Text = "EXIT";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(212, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "You Are Disconnected";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.privateMsg);
            this.panel1.Controls.Add(this.privateMsgReciever);
            this.panel1.Controls.Add(this.sendText);
            this.panel1.Controls.Add(this.sendBtn);
            this.panel1.Controls.Add(this.chatItems);
            this.panel1.Location = new System.Drawing.Point(12, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 565);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(291, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Codes";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Myanmar Text", 8.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.Location = new System.Drawing.Point(603, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 25);
            this.button5.TabIndex = 7;
            this.button5.Text = "DISCONNECT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Room";
            // 
            // privateMsg
            // 
            this.privateMsg.AutoSize = true;
            this.privateMsg.ForeColor = System.Drawing.Color.White;
            this.privateMsg.Location = new System.Drawing.Point(566, 483);
            this.privateMsg.Name = "privateMsg";
            this.privateMsg.Size = new System.Drawing.Size(138, 24);
            this.privateMsg.TabIndex = 5;
            this.privateMsg.Text = "Private Message";
            this.privateMsg.UseVisualStyleBackColor = true;
            // 
            // privateMsgReciever
            // 
            this.privateMsgReciever.BackColor = System.Drawing.Color.DarkTurquoise;
            this.privateMsgReciever.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.privateMsgReciever.ForeColor = System.Drawing.Color.Black;
            this.privateMsgReciever.FormattingEnabled = true;
            this.privateMsgReciever.Items.AddRange(new object[] {
            "abc"});
            this.privateMsgReciever.Location = new System.Drawing.Point(556, 449);
            this.privateMsgReciever.Name = "privateMsgReciever";
            this.privateMsgReciever.Size = new System.Drawing.Size(151, 28);
            this.privateMsgReciever.TabIndex = 4;
            // 
            // sendText
            // 
            this.sendText.BackColor = System.Drawing.Color.LightGray;
            this.sendText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendText.Location = new System.Drawing.Point(4, 449);
            this.sendText.Name = "sendText";
            this.sendText.Size = new System.Drawing.Size(546, 107);
            this.sendText.TabIndex = 3;
            this.sendText.Text = "";
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendBtn.ForeColor = System.Drawing.Color.PeachPuff;
            this.sendBtn.Location = new System.Drawing.Point(556, 517);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(157, 39);
            this.sendBtn.TabIndex = 2;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // chatItems
            // 
            this.chatItems.BackColor = System.Drawing.Color.CadetBlue;
            this.chatItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chatItems.ForeColor = System.Drawing.Color.White;
            this.chatItems.FormattingEnabled = true;
            this.chatItems.HorizontalScrollbar = true;
            this.chatItems.ItemHeight = 23;
            this.chatItems.Location = new System.Drawing.Point(4, 26);
            this.chatItems.Name = "chatItems";
            this.chatItems.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.chatItems.Size = new System.Drawing.Size(709, 414);
            this.chatItems.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(740, 617);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "GamerChat Client";
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button4;
        private Label label1;
        private Panel panel1;
        private ListBox chatItems;
        private Button sendBtn;
        private RichTextBox sendText;
        private CheckBox privateMsg;
        private ComboBox privateMsgReciever;
        private Label label2;
        private Button button5;
        private Label label3;
    }
}