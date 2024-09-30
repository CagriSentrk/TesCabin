using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Protokol1 seçildiğinde Form1'i aç
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Mevcut formu gizle (İsteğe bağlı)
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Protokol2 seçildiğinde Form2'yi aç
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide(); // Mevcut formu gizle (İsteğe bağlı)
        }
    }
}
