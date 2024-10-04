﻿using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxProtocol1; // Protokol 1 için grup kutusu
        private System.Windows.Forms.GroupBox groupBoxProtocol2;
        private System.Windows.Forms.Button personelButton;
        private System.Windows.Forms.Button adminButton;
        private PictureBox logoPictureBox;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.groupBoxProtocol1 = new System.Windows.Forms.GroupBox();
            this.groupBoxProtocol2 = new System.Windows.Forms.GroupBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.personelButton = new System.Windows.Forms.Button();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxPorts.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(50, 125);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(367, 126);
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
            this.textBoxReceiveData.Location = new System.Drawing.Point(32, 208);
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceiveData.TabIndex = 2;
            // 
            // SendText
            // 
            this.SendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendText.ForeColor = System.Drawing.Color.White;
            this.SendText.Location = new System.Drawing.Point(583, 209);
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
            this.textBoxSendData.Location = new System.Drawing.Point(205, 270);
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
            this.listBoxReceivedData.Location = new System.Drawing.Point(17, 296);
            this.listBoxReceivedData.Name = "listBoxReceivedData";
            this.listBoxReceivedData.Size = new System.Drawing.Size(95, 52);
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
            this.SelectedProtocol.Location = new System.Drawing.Point(292, 209);
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
            this.listViewMessages.Location = new System.Drawing.Point(32, 370);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(780, 243);
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
            this.menuStrip1.Size = new System.Drawing.Size(1783, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(14, 20);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(14, 20);
            // 
            // protokol3ToolStripMenuItem
            // 
            this.protokol3ToolStripMenuItem.Name = "protokol3ToolStripMenuItem";
            this.protokol3ToolStripMenuItem.Size = new System.Drawing.Size(14, 20);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(226, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Protokol 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(1362, 164);
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
            this.comboBoxPorts2.Location = new System.Drawing.Point(1062, 208);
            this.comboBoxPorts2.Name = "comboBoxPorts2";
            this.comboBoxPorts2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts2.TabIndex = 10;
            // 
            // buttonOpenPort2
            // 
            this.buttonOpenPort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenPort2.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort2.Location = new System.Drawing.Point(1256, 210);
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
            this.textBoxReceiveData2.Location = new System.Drawing.Point(1063, 250);
            this.textBoxReceiveData2.Name = "textBoxReceiveData2";
            this.textBoxReceiveData2.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceiveData2.TabIndex = 12;
            // 
            // SendText2
            // 
            this.SendText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendText2.ForeColor = System.Drawing.Color.White;
            this.SendText2.Location = new System.Drawing.Point(1637, 210);
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
            this.textBoxSendData2.Location = new System.Drawing.Point(1063, 296);
            this.textBoxSendData2.Multiline = true;
            this.textBoxSendData2.Name = "textBoxSendData2";
            this.textBoxSendData2.Size = new System.Drawing.Size(120, 34);
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
            this.SelectedProtocol2.Location = new System.Drawing.Point(1353, 210);
            this.SelectedProtocol2.Name = "SelectedProtocol2";
            this.SelectedProtocol2.Size = new System.Drawing.Size(241, 24);
            this.SelectedProtocol2.TabIndex = 15;
            this.SelectedProtocol2.SelectedIndexChanged += new System.EventHandler(this.SelectedProtocol_SelectedIndexChanged2);
            // 
            // textBoxCrcResults2
            // 
            this.textBoxCrcResults2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxCrcResults2.ForeColor = System.Drawing.Color.White;
            this.textBoxCrcResults2.Location = new System.Drawing.Point(41, 629);
            this.textBoxCrcResults2.Multiline = true;
            this.textBoxCrcResults2.Name = "textBoxCrcResults2";
            this.textBoxCrcResults2.Size = new System.Drawing.Size(740, 243);
            this.textBoxCrcResults2.TabIndex = 16;
            // 
            // textBoxCrcResults
            // 
            this.textBoxCrcResults.Location = new System.Drawing.Point(0, 0);
            this.textBoxCrcResults.Name = "textBoxCrcResults";
            this.textBoxCrcResults.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrcResults.TabIndex = 0;
            // 
            // groupBoxProtocol1
            // 
            this.groupBoxProtocol1.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxProtocol1.Location = new System.Drawing.Point(30, 50);
            this.groupBoxProtocol1.Name = "groupBoxProtocol1";
            this.groupBoxProtocol1.Size = new System.Drawing.Size(700, 400);
            this.groupBoxProtocol1.TabIndex = 0;
            this.groupBoxProtocol1.TabStop = false;
            this.groupBoxProtocol1.Text = "Protokol 1";
            // 
            // groupBoxProtocol2
            // 
            this.groupBoxProtocol2.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxProtocol2.Location = new System.Drawing.Point(800, 50);
            this.groupBoxProtocol2.Name = "groupBoxProtocol2";
            this.groupBoxProtocol2.Size = new System.Drawing.Size(700, 400);
            this.groupBoxProtocol2.TabIndex = 0;
            this.groupBoxProtocol2.TabStop = false;
            this.groupBoxProtocol2.Text = "Protokol 2";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(0, 0);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 0;
            // 
            // personelButton
            // 
            this.personelButton.Location = new System.Drawing.Point(0, 0);
            this.personelButton.Name = "personelButton";
            this.personelButton.Size = new System.Drawing.Size(75, 23);
            this.personelButton.TabIndex = 0;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("logoPictureBox.Image")));
            this.logoPictureBox.Location = new System.Drawing.Point(1517, 41);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(254, 79);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 0;
            this.logoPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1783, 906);
            this.Controls.Add(this.logoPictureBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
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