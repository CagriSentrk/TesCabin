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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();

            // Form Ayarları
            this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48); // Koyu gri arka plan
            this.ForeColor = System.Drawing.Color.White; // Beyaz metin rengi
            this.ClientSize = new System.Drawing.Size(1518, 782);
            this.Text = "Modern Form";
            this.StartPosition = FormStartPosition.CenterScreen;

            // MenuStrip
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.menuStrip1.ForeColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripMenuItem1,
                this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1518, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";

            // ToolStripMenuItem1 (Protokol1)
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem1.Text = "Protokol1";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);

            // ToolStripMenuItem2 (Protokol2)
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(87, 24);
            this.toolStripMenuItem2.Text = "Protokol2";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);

            // ComboBox Ports
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.comboBoxPorts.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(12, 95);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 0;

            // Button OpenPort
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(50, 205, 50);
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(166, 96);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenPort.TabIndex = 1;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);

            // TextBox ReceiveData
            this.textBoxReceiveData.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.textBoxReceiveData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxReceiveData.ForeColor = System.Drawing.Color.White;
            this.textBoxReceiveData.Location = new System.Drawing.Point(29, 195);
            this.textBoxReceiveData.Name = "textBoxReceiveData";
            this.textBoxReceiveData.Size = new System.Drawing.Size(100, 22);
            this.textBoxReceiveData.TabIndex = 2;

            // Button SendText
            this.SendText.BackColor = System.Drawing.Color.FromArgb(70, 130, 180);
            this.SendText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendText.ForeColor = System.Drawing.Color.White;
            this.SendText.Location = new System.Drawing.Point(587, 97);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(68, 23);
            this.SendText.TabIndex = 3;
            this.SendText.Text = "SEND";
            this.SendText.UseVisualStyleBackColor = true;
            this.SendText.Click += new System.EventHandler(this.SendText_Click);

            // TextBox SendData
            this.textBoxSendData.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.textBoxSendData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSendData.ForeColor = System.Drawing.Color.White;
            this.textBoxSendData.Location = new System.Drawing.Point(274, 157);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(420, 78);
            this.textBoxSendData.TabIndex = 4;

            // ListBox ReceivedData
            this.listBoxReceivedData.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.listBoxReceivedData.ForeColor = System.Drawing.Color.White;
            this.listBoxReceivedData.FormattingEnabled = true;
            this.listBoxReceivedData.ItemHeight = 16;
            this.listBoxReceivedData.Location = new System.Drawing.Point(29, 398);
            this.listBoxReceivedData.Name = "listBoxReceivedData";
            this.listBoxReceivedData.Size = new System.Drawing.Size(1053, 52);
            this.listBoxReceivedData.TabIndex = 5;

            // ComboBox SelectedProtocol
            this.SelectedProtocol.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
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

            // ListView Messages
            this.listViewMessages.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
            this.listViewMessages.ForeColor = System.Drawing.Color.White;
            this.listViewMessages.HideSelection = false;
            this.listViewMessages.Location = new System.Drawing.Point(29, 472);
            this.listViewMessages.Name = "listViewMessages";
            this.listViewMessages.Size = new System.Drawing.Size(1053, 243);
            this.listViewMessages.TabIndex = 7;
            this.listViewMessages.UseCompatibleStateImageBehavior = false;

            // Form1 Ayarları
            this.Controls.Add(this.listViewMessages);
            this.Controls.Add(this.SelectedProtocol);
            this.Controls.Add(this.listBoxReceivedData);
            this.Controls.Add(this.textBoxSendData);
            this.Controls.Add(this.SendText);
            this.Controls.Add(this.textBoxReceiveData);
            this.Controls.Add(this.buttonOpenPort);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.menuStrip1);
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
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}
