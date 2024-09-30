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
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(29, 31);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Location = new System.Drawing.Point(166, 32);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPort.TabIndex = 1;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // textBoxReceiveData
            // 
            this.textBoxReceiveData.Location = new System.Drawing.Point(29, 108);
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceiveData.TabIndex = 2;
            // 
            // SendText
            // 
            this.SendText.Location = new System.Drawing.Point(724, 107);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(68, 23);
            this.SendText.TabIndex = 3;
            this.SendText.Text = "SEND";
            this.SendText.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.SendText.UseVisualStyleBackColor = true;
            this.SendText.Click += new System.EventHandler(this.SendText_Click);
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.Location = new System.Drawing.Point(274, 80);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(420, 78);
            this.textBoxSendData.TabIndex = 4;
            // 
            // listBoxReceivedData
            // 
            this.listBoxReceivedData.FormattingEnabled = true;
            this.listBoxReceivedData.ItemHeight = 16;
            this.listBoxReceivedData.Location = new System.Drawing.Point(29, 398);
            this.listBoxReceivedData.Name = "listBoxReceivedData";
            this.listBoxReceivedData.Size = new System.Drawing.Size(1053, 52);
            this.listBoxReceivedData.TabIndex = 5;
            // 
            // SelectedProtocol
            // 
            this.SelectedProtocol.FormattingEnabled = true;
            this.SelectedProtocol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SelectedProtocol.Location = new System.Drawing.Point(274, 32);
            this.SelectedProtocol.Name = "SelectedProtocol";
            this.SelectedProtocol.Size = new System.Drawing.Size(241, 24);
            this.SelectedProtocol.TabIndex = 6;
            this.SelectedProtocol.SelectedIndexChanged += new System.EventHandler(this.SelectedProtocol_SelectedIndexChanged);
            // 
            // listViewMessages
            // 
            this.listViewMessages.HideSelection = false;
            this.listViewMessages.Location = new System.Drawing.Point(29, 472);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(1053, 243);
            this.listViewMessages.TabIndex = 7;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1518, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.menu2ToolStripMenuItem.Text = "Menu2";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.menu1ToolStripMenuItem.Text = "Menu1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1518, 782);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.SelectedProtocol);
            this.Controls.Add(this.listBoxReceivedData);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.textBoxReceiveData);
            this.Controls.Add(this.buttonOpenPort);
            this.Controls.Add(this.comboBoxPorts);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
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
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
    }
}
