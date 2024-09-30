namespace WindowsFormsApp1
{
    partial class Form2
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewMessages = new System.Windows.Forms.ListView();
            this.SelectedProtocol = new System.Windows.Forms.ComboBox();
            this.listBoxReceivedData = new System.Windows.Forms.ListBox();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.textBoxReceiveData = new System.Windows.Forms.TextBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewMessages
            // 
            this.listViewMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listViewMessages.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listViewMessages.ForeColor = System.Drawing.Color.White;
            this.listViewMessages.HideSelection = false;
            this.listViewMessages.Location = new System.Drawing.Point(29, 478);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(1053, 243);
            this.listViewMessages.TabIndex = 16;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;
            // 
            // SelectedProtocol
            // 
            this.SelectedProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.SelectedProtocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectedProtocol.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SelectedProtocol.ForeColor = System.Drawing.Color.White;
            this.SelectedProtocol.FormattingEnabled = true;
            this.SelectedProtocol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SelectedProtocol.Location = new System.Drawing.Point(274, 85);
            this.SelectedProtocol.Name = "SelectedProtocol";
            this.SelectedProtocol.Size = new System.Drawing.Size(241, 31);
            this.SelectedProtocol.TabIndex = 15;
            // 
            // listBoxReceivedData
            // 
            this.listBoxReceivedData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.listBoxReceivedData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.listBoxReceivedData.ForeColor = System.Drawing.Color.White;
            this.listBoxReceivedData.FormattingEnabled = true;
            this.listBoxReceivedData.ItemHeight = 23;
            this.listBoxReceivedData.Location = new System.Drawing.Point(29, 391);
            this.listBoxReceivedData.Name = "listBoxReceivedData";
            this.listBoxReceivedData.Size = new System.Drawing.Size(1053, 50);
            this.listBoxReceivedData.TabIndex = 14;
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxSendData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSendData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxSendData.ForeColor = System.Drawing.Color.White;
            this.textBoxSendData.Location = new System.Drawing.Point(274, 144);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(420, 78);
            this.textBoxSendData.TabIndex = 13;
            // 
            // textBoxReceiveData
            // 
            this.textBoxReceiveData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.textBoxReceiveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReceiveData.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxReceiveData.ForeColor = System.Drawing.Color.White;
            this.textBoxReceiveData.Location = new System.Drawing.Point(21, 183);
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.Size = new System.Drawing.Size(150, 30);
            this.textBoxReceiveData.TabIndex = 11;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.comboBoxPorts.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxPorts.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 85);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 31);
            this.comboBoxPorts.TabIndex = 9;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1521, 31);
            this.menuStrip1.TabIndex = 17;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 27);
            this.toolStripMenuItem1.Text = "Protokol1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(97, 27);
            this.toolStripMenuItem2.Text = "Protokol2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(544, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "SEND";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(143, 90);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPort.TabIndex = 19;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1521, 791);
            this.Controls.Add(this.buttonOpenPort);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.SelectedProtocol);
            this.Controls.Add(this.listBoxReceivedData);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.textBoxReceiveData);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewMessages;
        private System.Windows.Forms.ComboBox SelectedProtocol;
        private System.Windows.Forms.ListBox listBoxReceivedData;
        private System.Windows.Forms.TextBox textBoxSendData;
        private System.Windows.Forms.TextBox textBoxReceiveData;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonOpenPort;
    }
}
