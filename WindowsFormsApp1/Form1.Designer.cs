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
            this.protokol3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPorts2 = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort2 = new System.Windows.Forms.Button();
            this.textBoxReceiveData2 = new System.Windows.Forms.TextBox();
            this.SendText2 = new System.Windows.Forms.Button();
            this.textBoxSendData2 = new System.Windows.Forms.TextBox();
            this.SelectedProtocol2 = new System.Windows.Forms.ComboBox();
            this.textBoxCrcResults2 = new System.Windows.Forms.TextBox();
            this.textBoxCrcResults = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxPorts.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 95);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(166, 96);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(75, 23);
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
            this.textBoxReceiveData.Location = new System.Drawing.Point(29, 195);
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceiveData.TabIndex = 2;
            // 
            // SendText
            // 
            this.SendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendText.ForeColor = System.Drawing.Color.White;
            this.SendText.Location = new System.Drawing.Point(587, 97);
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
            this.textBoxSendData.Location = new System.Drawing.Point(274, 157);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(420, 78);
            this.textBoxSendData.TabIndex = 4;
            // 
            // listBoxReceivedData
            // 
            this.listBoxReceivedData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBoxReceivedData.ForeColor = System.Drawing.Color.White;
            this.listBoxReceivedData.FormattingEnabled = true;
            this.listBoxReceivedData.ItemHeight = 16;
            this.listBoxReceivedData.Location = new System.Drawing.Point(29, 307);
            this.listBoxReceivedData.Name = "listBoxReceivedData";
            this.listBoxReceivedData.Size = new System.Drawing.Size(961, 52);
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
            this.SelectedProtocol.Location = new System.Drawing.Point(274, 96);
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
            this.listViewMessages.Location = new System.Drawing.Point(29, 399);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(961, 243);
            this.listViewMessages.TabIndex = 7;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.protokol3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1783, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem1.Text = "Protokol1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem2.Text = "Protokol2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // protokol3ToolStripMenuItem
            // 
            this.protokol3ToolStripMenuItem.Name = "protokol3ToolStripMenuItem";
            this.protokol3ToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(224, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Protokol 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1435, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Protokol 2";
            // 
            // comboBoxPorts2
            // 
            this.comboBoxPorts2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxPorts2.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts2.FormattingEnabled = true;
            this.comboBoxPorts2.Location = new System.Drawing.Point(1114, 137);
            this.comboBoxPorts2.Name = "comboBoxPorts2";
            this.comboBoxPorts2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts2.TabIndex = 10;
            // 
            // buttonOpenPort2
            // 
            this.buttonOpenPort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPort2.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort2.Location = new System.Drawing.Point(1269, 137);
            this.buttonOpenPort2.Name = "buttonOpenPort2";
            this.buttonOpenPort2.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPort2.TabIndex = 11;
            this.buttonOpenPort2.Text = "Open2";
            this.buttonOpenPort2.UseVisualStyleBackColor = true;
            this.buttonOpenPort2.Click += new System.EventHandler(this.buttonOpenPort_Click2);
            // 
            // textBoxReceiveData2
            // 
            this.textBoxReceiveData2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxReceiveData2.ForeColor = System.Drawing.Color.White;
            this.textBoxReceiveData2.Location = new System.Drawing.Point(974, 194);
            this.textBoxReceiveData2.Name = "textBoxReceiveData2";
            this.textBoxReceiveData2.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceiveData2.TabIndex = 12;
            // 
            // SendText2
            // 
            this.SendText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendText2.ForeColor = System.Drawing.Color.White;
            this.SendText2.Location = new System.Drawing.Point(1610, 137);
            this.SendText2.Name = "SendText2";
            this.SendText2.Size = new System.Drawing.Size(75, 23);
            this.SendText2.TabIndex = 13;
            this.SendText2.Text = "SEND2";
            this.SendText2.UseVisualStyleBackColor = true;
            this.SendText2.Click += new System.EventHandler(this.SendText_Click2);
            // 
            // textBoxSendData2
            // 
            this.textBoxSendData2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxSendData2.ForeColor = System.Drawing.Color.White;
            this.textBoxSendData2.Location = new System.Drawing.Point(1114, 281);
            this.textBoxSendData2.Multiline = true;
            this.textBoxSendData2.Name = "textBoxSendData2";
            this.textBoxSendData2.Size = new System.Drawing.Size(571, 78);
            this.textBoxSendData2.TabIndex = 14;
            // 
            // SelectedProtocol2
            // 
            this.SelectedProtocol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SelectedProtocol2.ForeColor = System.Drawing.Color.White;
            this.SelectedProtocol2.FormattingEnabled = true;
            this.SelectedProtocol2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SelectedProtocol2.Location = new System.Drawing.Point(1350, 136);
            this.SelectedProtocol2.Name = "SelectedProtocol2";
            this.SelectedProtocol2.Size = new System.Drawing.Size(241, 24);
            this.SelectedProtocol2.TabIndex = 15;
            this.SelectedProtocol2.SelectedIndexChanged += new System.EventHandler(this.SelectedProtocol_SelectedIndexChanged2);
            // 
            // textBoxCrcResults2
            // 
            this.textBoxCrcResults2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxCrcResults2.ForeColor = System.Drawing.Color.White;
            this.textBoxCrcResults2.Location = new System.Drawing.Point(1063, 390);
            this.textBoxCrcResults2.Multiline = true;
            this.textBoxCrcResults2.Name = "textBoxCrcResults2";
            this.textBoxCrcResults2.Size = new System.Drawing.Size(667, 252);
            this.textBoxCrcResults2.TabIndex = 16;
            // 
            // textBoxCrcResults
            // 
            this.textBoxCrcResults.Location = new System.Drawing.Point(0, 0);
            this.textBoxCrcResults.Name = "textBoxCrcResults";
            this.textBoxCrcResults.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrcResults.TabIndex = 0;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1783, 906);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.SelectedProtocol);
            this.Controls.Add(this.listBoxReceivedData);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.textBoxReceiveData);
            this.Controls.Add(this.buttonOpenPort);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.comboBoxPorts2);
            this.Controls.Add(this.buttonOpenPort2);
            this.Controls.Add(this.textBoxReceiveData2);
            this.Controls.Add(this.SendText2);
            this.Controls.Add(this.textBoxSendData2);
            this.Controls.Add(this.SelectedProtocol2);
            this.Controls.Add(this.textBoxCrcResults2);
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private ToolStripMenuItem protokol3ToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxPorts2;
        private System.Windows.Forms.TextBox textBoxCrcResults;
        private System.Windows.Forms.Button buttonOpenPort2;
        private System.Windows.Forms.TextBox textBoxReceiveData2;
        private System.Windows.Forms.Button SendText2;
        private System.Windows.Forms.TextBox textBoxSendData2;
        private System.Windows.Forms.ComboBox SelectedProtocol2;
        private System.Windows.Forms.TextBox textBoxCrcResults2;
        private Label label1;
        private Label label2;
    }
}
