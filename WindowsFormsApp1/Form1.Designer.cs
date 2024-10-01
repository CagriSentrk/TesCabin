using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.textBoxReceiveData = new System.Windows.Forms.TextBox();
            this.SendText = new System.Windows.Forms.Button();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.listBoxReceivedData = new System.Windows.Forms.ListBox();
            this.SelectedProtocol = new System.Windows.Forms.ComboBox();
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panelProtocol1 = new System.Windows.Forms.Panel();
            this.panelProtocol2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panelProtocol1.SuspendLayout();
            this.panelProtocol2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxPorts.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(34, 57);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(180, 58);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(75, 33);
            this.buttonOpenPort.TabIndex = 1;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // textBoxReceiveData
            // 
            this.textBoxReceiveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxReceiveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReceiveData.ForeColor = System.Drawing.Color.White;
            this.textBoxReceiveData.Location = new System.Drawing.Point(41, 168);
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceiveData.TabIndex = 2;
            // 
            // SendText
            // 
            this.SendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendText.ForeColor = System.Drawing.Color.White;
            this.SendText.Location = new System.Drawing.Point(592, 66);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(68, 23);
            this.SendText.TabIndex = 3;
            this.SendText.Text = "SEND";
            this.SendText.UseVisualStyleBackColor = true;
            this.SendText.Click += new System.EventHandler(this.SendText_Click);
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxSendData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSendData.ForeColor = System.Drawing.Color.White;
            this.textBoxSendData.Location = new System.Drawing.Point(276, 113);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(420, 86);
            this.textBoxSendData.TabIndex = 4;
            // 
            // listBoxReceivedData
            // 
            this.listBoxReceivedData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBoxReceivedData.ForeColor = System.Drawing.Color.White;
            this.listBoxReceivedData.FormattingEnabled = true;
            this.listBoxReceivedData.ItemHeight = 16;
            this.listBoxReceivedData.Location = new System.Drawing.Point(139, 243);
            this.listBoxReceivedData.Name = "listBoxReceivedData";
            this.listBoxReceivedData.Size = new System.Drawing.Size(832, 52);
            this.listBoxReceivedData.TabIndex = 5;
            // 
            // SelectedProtocol
            // 
            this.SelectedProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SelectedProtocol.ForeColor = System.Drawing.Color.White;
            this.SelectedProtocol.FormattingEnabled = true;
            this.SelectedProtocol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SelectedProtocol.Location = new System.Drawing.Point(308, 64);
            this.SelectedProtocol.Name = "SelectedProtocol";
            this.SelectedProtocol.Size = new System.Drawing.Size(241, 24);
            this.SelectedProtocol.TabIndex = 6;
            this.SelectedProtocol.SelectedIndexChanged += new System.EventHandler(this.SelectedProtocol_SelectedIndexChanged);
            // 
            // listViewMessages
            // 
            this.listViewMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listViewMessages.ForeColor = System.Drawing.Color.White;
            this.listViewMessages.HideSelection = false;
            this.listViewMessages.Location = new System.Drawing.Point(77, 327);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(1053, 243);
            this.listViewMessages.TabIndex = 7;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1898, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem1.Text = "Protokol1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem2.Text = "Protokol2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // panelProtocol1
            // 
            this.panelProtocol1.BackColor = System.Drawing.Color.LightGray;
            this.panelProtocol1.Controls.Add(this.SelectedProtocol);
            this.panelProtocol1.Controls.Add(this.comboBoxPorts);
            this.panelProtocol1.Controls.Add(this.buttonOpenPort);
            this.panelProtocol1.Controls.Add(this.listViewMessages);
            this.panelProtocol1.Controls.Add(this.SendText);
            this.panelProtocol1.Controls.Add(this.textBoxSendData);
            this.panelProtocol1.Controls.Add(this.listBoxReceivedData);
            this.panelProtocol1.Location = new System.Drawing.Point(0, 31);
            this.panelProtocol1.Name = "panelProtocol1";
            this.panelProtocol1.Size = new System.Drawing.Size(1527, 760);
            this.panelProtocol1.TabIndex = 1;
            // 
            // panelProtocol2
            // 
            this.panelProtocol2.BackColor = System.Drawing.Color.LightBlue;
            this.panelProtocol2.Controls.Add(this.textBoxReceiveData);
            this.panelProtocol2.Controls.Add(this.textBox2);
            this.panelProtocol2.Controls.Add(this.listView1);
            this.panelProtocol2.Controls.Add(this.listBox1);
            this.panelProtocol2.Controls.Add(this.comboBox3);
            this.panelProtocol2.Controls.Add(this.comboBox1);
            this.panelProtocol2.Controls.Add(this.comboBox2);
            this.panelProtocol2.Controls.Add(this.button1);
            this.panelProtocol2.Controls.Add(this.button2);
            this.panelProtocol2.Controls.Add(this.textBox1);
            this.panelProtocol2.Location = new System.Drawing.Point(12, 40);
            this.panelProtocol2.Name = "panelProtocol2";
            this.panelProtocol2.Size = new System.Drawing.Size(1518, 1155);
            this.panelProtocol2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(-75, -24);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(10, 22);
            this.textBox2.TabIndex = 14;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 360);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1309, 121);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(428, 138);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(191, 52);
            this.listBox1.TabIndex = 15;
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(41, 78);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 24);
            this.comboBox3.TabIndex = 13;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.comboBox1.Location = new System.Drawing.Point(407, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(-137, 139);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(215, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(683, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "SEND";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(296, 243);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(420, 78);
            this.textBox1.TabIndex = 11;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1518, 782);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelProtocol2);
            this.Controls.Add(this.panelProtocol1);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelProtocol1.ResumeLayout(false);
            this.panelProtocol1.PerformLayout();
            this.panelProtocol2.ResumeLayout(false);
            this.panelProtocol2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelProtocol1;
        private System.Windows.Forms.Panel panelProtocol2;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonOpenPort;

        private System.Windows.Forms.TextBox textBoxReceiveData;
        private System.Windows.Forms.Button SendText;
        private System.Windows.Forms.TextBox textBoxSendData;
        private System.Windows.Forms.ListBox listBoxReceivedData;
        private System.Windows.Forms.ComboBox SelectedProtocol;
        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private TextBox textBox2;
        private ListView listView1;
        private ListBox listBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
    }
}
