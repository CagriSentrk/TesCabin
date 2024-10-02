using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            DatabaseHelper dbHelper = new DatabaseHelper();
           
        }

        // Butona tıklandığında giriş kontrolü yapılacak
        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text.Trim();
            string enteredPassword = textBox2.Text;

            DatabaseHelper dbHelper = new DatabaseHelper();
            var (success, role) = dbHelper.ValidateUserByCredentials(enteredUsername, enteredPassword);

            if (success)
            {
                if (role == "admin")
                {
                    Form1 adminForm = new Form1(role);
                    adminForm.Show();
                    this.Hide();
                }
                else if (role == "personel")
                {
                    Form1 personelForm = new Form1(role);
                    personelForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

   
    }
