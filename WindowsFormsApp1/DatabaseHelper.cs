using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using BCrypt.Net;

namespace WindowsFormsApp1
{
    public class DatabaseHelper
    {
        private string connectionString = "Host=localhost;Port=5434;Username=postgres;Password=senturk06;Database=SerialPortDb";

        // Kullanıcıyı veritabanında kontrol et
        public (bool success, string role) ValidateUserByCredentials(string username, string password)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT \"password_hash\", \"role\" FROM public.\"users\" WHERE \"username\" = @username", conn))
                {
                    //admin  //admin123
                    //personel  //personel123
                    cmd.Parameters.AddWithValue("username", username);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader.GetString(0);
                            string role = reader.GetString(1);

                            // Şifre doğrulama (hash karşılaştırma)
                            if (BCrypt.Net.BCrypt.Verify(password, storedHash))
                            {
                                return (true, role);
                            }
                        }
                    }
                }
            }

            return (false, null);
        }

        // Yeni bir kullanıcı ekle
        public void AddUser(string username, string password, string role)
        {
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password);

            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("INSERT INTO public.\"users\" (\"username\", \"password_hash\", \"role\") VALUES (@username, @password_hash, @role)", conn))
                { 
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password_hash", passwordHash);
                    cmd.Parameters.AddWithValue("role", role);
                    cmd.ExecuteNonQuery();
                }


            }
        }
    }

}
