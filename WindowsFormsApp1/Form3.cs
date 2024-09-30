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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        // Butona tıklandığında giriş kontrolü yapılacak
        private void button1_Click(object sender, EventArgs e)
        {
            string username = "admin"; // Doğru kullanıcı adı
            string password = "12345"; // Doğru şifre

            // Kullanıcının girdiği şifreyi sadece rakamlar ve harfler kalsın diye temizle
            string enteredPassword = new string(textBox2.Text.Where(c => char.IsLetterOrDigit(c)).ToArray());

            // Kullanıcı adı ve temizlenmiş şifreyi kontrol et
            if (textBox1.Text.Trim() == username && enteredPassword == password)
            {
                // Giriş başarılı, Form1'i aç
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide(); // Form3'ü gizle
            }
            else
            {
                // Giriş başarısız, hata mesajı göster
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
