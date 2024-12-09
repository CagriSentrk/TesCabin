using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using BCrypt.Net;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp1
{
    public class DatabaseHelper
    {
        private string portnumber = "COM7";
        private System.Windows.Forms.TableLayoutPanel errortablelayout;
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
        // Gelen son verideki belirli değerleri al
        // Gelen son verideki belirli değerleri al ve TextBox'ta göster

        //ReservedMessage=1 için
        public void DisplayLatestSystemInformation(TextBox instantBatteryVoltageTextBox, TextBox cardTemperatureTextBox, TextBox systemTypeTextBox)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT instant_battery_voltage, card_temperature, system_type FROM public.motor_control_data WHERE port_info = 'COM6' ORDER BY id DESC LIMIT 1", conn)) // port_info koşulu eklendi
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double instantBatteryVoltage = reader.GetDouble(0); // double type
                            double cardTemperature = reader.GetDouble(1);       // double type
                            bool systemType = reader.GetBoolean(2);             // bool type

                            // Verileri TextBox'lara gösterme
                            if (instantBatteryVoltageTextBox.InvokeRequired)
                            {
                                instantBatteryVoltageTextBox.Invoke(new Action(() =>
                                {
                                    instantBatteryVoltageTextBox.Text = instantBatteryVoltage.ToString();
                                }));
                            }
                            else
                            {
                                instantBatteryVoltageTextBox.Text = instantBatteryVoltage.ToString();
                            }

                            if (cardTemperatureTextBox.InvokeRequired)
                            {
                                cardTemperatureTextBox.Invoke(new Action(() =>
                                {
                                    cardTemperatureTextBox.Text = cardTemperature.ToString();
                                }));
                            }
                            else
                            {
                                cardTemperatureTextBox.Text = cardTemperature.ToString();
                            }

                            if (systemTypeTextBox.InvokeRequired)
                            {
                                systemTypeTextBox.Invoke(new Action(() =>
                                {
                                    systemTypeTextBox.Text = systemType.ToString();
                                }));
                            }
                            else
                            {
                                systemTypeTextBox.Text = systemType.ToString();
                            }
                        }
                        else
                        {
                            // Eğer veri yoksa
                            if (instantBatteryVoltageTextBox.InvokeRequired)
                            {
                                instantBatteryVoltageTextBox.Invoke(new Action(() => instantBatteryVoltageTextBox.Text = "Veritabanında herhangi bir veri bulunamadı."));
                            }
                            else
                            {
                                instantBatteryVoltageTextBox.Text = "Veritabanında herhangi bir veri bulunamadı.";
                            }
                        }
                    }
                }
            }
        }



      
        public void DisplayLatestSystemInformationForCOM5(TextBox instantBatteryVoltageTextBox, TextBox cardTemperatureTextBox, TextBox systemTypeTextBox)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT instant_battery_voltage, card_temperature, system_type FROM public.motor_control_data WHERE port_info = 'COM5' ORDER BY id DESC LIMIT 1", conn)) // port_info 'COM5' koşulu eklendi
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            double instantBatteryVoltage = reader.GetDouble(0); // double type
                            double cardTemperature = reader.GetDouble(1);       // double type
                            bool systemType = reader.GetBoolean(2);             // bool type

                            // Verileri TextBox'lara gösterme
                            if (instantBatteryVoltageTextBox.InvokeRequired)
                            {
                                instantBatteryVoltageTextBox.Invoke(new Action(() =>
                                {
                                    instantBatteryVoltageTextBox.Text = instantBatteryVoltage.ToString();
                                }));
                            }
                            else
                            {
                                instantBatteryVoltageTextBox.Text = instantBatteryVoltage.ToString();
                            }

                            if (cardTemperatureTextBox.InvokeRequired)
                            {
                                cardTemperatureTextBox.Invoke(new Action(() =>
                                {
                                    cardTemperatureTextBox.Text = cardTemperature.ToString();
                                }));
                            }
                            else
                            {
                                cardTemperatureTextBox.Text = cardTemperature.ToString();
                            }

                            if (systemTypeTextBox.InvokeRequired)
                            {
                                systemTypeTextBox.Invoke(new Action(() =>
                                {
                                    systemTypeTextBox.Text = systemType.ToString();
                                }));
                            }
                            else
                            {
                                systemTypeTextBox.Text = systemType.ToString();
                            }
                        }
                        else
                        {
                            // Eğer veri yoksa
                            if (instantBatteryVoltageTextBox.InvokeRequired)
                            {
                                instantBatteryVoltageTextBox.Invoke(new Action(() => instantBatteryVoltageTextBox.Text = "Veritabanında herhangi bir veri bulunamadı."));
                            }
                            else
                            {
                                instantBatteryVoltageTextBox.Text = "Veritabanında herhangi bir veri bulunamadı.";
                            }
                        }
                    }
                }
            }
        }


        // current_control_prm_r_40,current_control_prm_l_40,current_control_prm_bw_40,position_control_prm_kp_40_position_control_prm_ki_40_position_control_prm_kd_40

        //ReservedMessage=6
        public void DisplayLatestControlParameter(TextBox currentControlPrmR40TextBox, TextBox currentControlPrmL40TextBox, TextBox currentControlPrmBW40TextBox,
 TextBox positionControlPrmKp40TextBox, TextBox positionControlPrmKi40TextBox, TextBox positionControlPrmKd40TextBox)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT current_control_prm_r_40, current_control_prm_l_40, current_control_prm_bw_40, " +
                                                  "position_control_prm_kp_40, position_control_prm_ki_40, position_control_prm_kd_40 " +
                                                  "FROM public.motor_control_data " +
                                                  "WHERE port_info = 'COM6' " + // port_info 'COM6' koşulu eklendi
                                                  "ORDER BY id DESC LIMIT 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Parametreleri al
                            double currentControlPrmR40 = reader.GetDouble(0);  // double type
                            double currentControlPrmL40 = reader.GetDouble(1);  // double type
                            double currentControlPrmBW40 = reader.GetDouble(2); // double type
                            double positionControlPrmKp40 = reader.GetDouble(3); // double type
                            double positionControlPrmKi40 = reader.GetDouble(4); // double type
                            double positionControlPrmKd40 = reader.GetDouble(5); // double type

                            // TextBox'ları güncelleme
                            UpdateTextBoxcontrolparameter(currentControlPrmR40TextBox, currentControlPrmR40);
                            UpdateTextBoxcontrolparameter(currentControlPrmL40TextBox, currentControlPrmL40);
                            UpdateTextBoxcontrolparameter(currentControlPrmBW40TextBox, currentControlPrmBW40);
                            UpdateTextBoxcontrolparameter(positionControlPrmKp40TextBox, positionControlPrmKp40);
                            UpdateTextBoxcontrolparameter(positionControlPrmKi40TextBox, positionControlPrmKi40);
                            UpdateTextBoxcontrolparameter(positionControlPrmKd40TextBox, positionControlPrmKd40);
                        }
                        else
                        {
                            // Veri yoksa uygun mesaj göster
                            if (currentControlPrmR40TextBox.InvokeRequired)
                            {
                                currentControlPrmR40TextBox.Invoke(new Action(() => currentControlPrmR40TextBox.Text = "Veritabanında herhangi bir veri bulunamadı."));
                            }
                            else
                            {
                                currentControlPrmR40TextBox.Text = "Veritabanında herhangi bir veri bulunamadı.";
                            }
                        }
                    }
                }
            }
        }

        public void DisplayLatestControlParameterForCOM5(TextBox currentControlPrmR40TextBox, TextBox currentControlPrmL40TextBox, TextBox currentControlPrmBW40TextBox,
TextBox positionControlPrmKp40TextBox, TextBox positionControlPrmKi40TextBox, TextBox positionControlPrmKd40TextBox)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT current_control_prm_r_40, current_control_prm_l_40, current_control_prm_bw_40, " +
                                                  "position_control_prm_kp_40, position_control_prm_ki_40, position_control_prm_kd_40 " +
                                                  "FROM public.motor_control_data " +
                                                  "WHERE port_info = 'COM5' " + // port_info 'COM5' koşulu eklendi
                                                  "ORDER BY id DESC LIMIT 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Parametreleri al
                            double currentControlPrmR40 = reader.GetDouble(0);  // double type
                            double currentControlPrmL40 = reader.GetDouble(1);  // double type
                            double currentControlPrmBW40 = reader.GetDouble(2); // double type
                            double positionControlPrmKp40 = reader.GetDouble(3); // double type
                            double positionControlPrmKi40 = reader.GetDouble(4); // double type
                            double positionControlPrmKd40 = reader.GetDouble(5); // double type

                            // TextBox'ları güncelleme
                            UpdateTextBoxcontrolparameter(currentControlPrmR40TextBox, currentControlPrmR40);
                            UpdateTextBoxcontrolparameter(currentControlPrmL40TextBox, currentControlPrmL40);
                            UpdateTextBoxcontrolparameter(currentControlPrmBW40TextBox, currentControlPrmBW40);
                            UpdateTextBoxcontrolparameter(positionControlPrmKp40TextBox, positionControlPrmKp40);
                            UpdateTextBoxcontrolparameter(positionControlPrmKi40TextBox, positionControlPrmKi40);
                            UpdateTextBoxcontrolparameter(positionControlPrmKd40TextBox, positionControlPrmKd40);
                        }
                        else
                        {
                            // Veri yoksa uygun mesaj göster
                            if (currentControlPrmR40TextBox.InvokeRequired)
                            {
                                currentControlPrmR40TextBox.Invoke(new Action(() => currentControlPrmR40TextBox.Text = "Veritabanında herhangi bir veri bulunamadı."));
                            }
                            else
                            {
                                currentControlPrmR40TextBox.Text = "Veritabanında herhangi bir veri bulunamadı.";
                            }
                        }
                    }
                }
            }
        }

        private void UpdateTextBoxcontrolparameter(TextBox textBox, double value)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() =>
                {
                    textBox.Text = value.ToString();
                }));
            }
            else
            {
                textBox.Text = value.ToString();
            }
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
        public void DisplayLatestDegAndCurrent(
    TextBox fin1PositionReferenceDegTextBox,
    TextBox fin2PositionReferenceDegTextBox,
    TextBox fin1CurrentReferenceDegTextBox,
    TextBox fin2CurrentReferenceDegTextBox)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT " +
                                                    "fin1_position_reference_deg, " +
                                                    "fin2_position_reference_deg, " +
                                                    "fin1_current_reference_deg, " +
                                                    "fin2_current_reference_deg " +
                                                    "FROM public.motor_control_data " +
                                                    "WHERE port_info = 'COM6' " +
                                                    "ORDER BY id DESC LIMIT 1", conn)) // "COM6" değerine sahip son kaydı almak için koşul eklendi
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Verileri al
                            double fin1PositionReferenceDeg = reader.GetDouble(0);  // deg tipi double olduğu için GetDouble kullanıyoruz
                            double fin2PositionReferenceDeg = reader.GetDouble(1);  // deg tipi double olduğu için GetDouble kullanıyoruz
                            double fin1CurrentReferenceDeg = reader.GetDouble(2);  // deg tipi double olduğu için GetDouble kullanıyoruz
                            double fin2CurrentReferenceDeg = reader.GetDouble(3);  // deg tipi double olduğu için GetDouble kullanıyoruz

                            // TextBox'ları güncelle
                            UpdateTextBoxWithData(fin1PositionReferenceDegTextBox, fin1PositionReferenceDeg);
                            UpdateTextBoxWithData(fin2PositionReferenceDegTextBox, fin2PositionReferenceDeg);
                            UpdateTextBoxWithData(fin1CurrentReferenceDegTextBox, fin1CurrentReferenceDeg);
                            UpdateTextBoxWithData(fin2CurrentReferenceDegTextBox, fin2CurrentReferenceDeg);
                        }
                        else
                        {
                            // Veri yoksa uygun mesaj göster
                            if (fin1PositionReferenceDegTextBox.InvokeRequired)
                            {
                                fin1PositionReferenceDegTextBox.Invoke(new Action(() =>
                                    fin1PositionReferenceDegTextBox.Text = "Veritabanında uygun veri bulunamadı."));
                            }
                            else
                            {
                                fin1PositionReferenceDegTextBox.Text = "Veritabanında uygun veri bulunamadı.";
                            }
                        }
                    }
                }
            }
        }
        //    public void DisplayLatestDegAndCurrentForCOM5(
        //TextBox fin1PositionReferenceDegTextBox,
        //TextBox fin2PositionReferenceDegTextBox,
        //TextBox fin1CurrentReferenceDegTextBox,
        //TextBox fin2CurrentReferenceDegTextBox)
        //    {
        //        using (var conn = new NpgsqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            using (var cmd = new NpgsqlCommand("SELECT " +
        //                                                "fin1_position_reference_deg, " +
        //                                                "fin2_position_reference_deg, " +
        //                                                "fin1_current_reference_deg, " +
        //                                                "fin2_current_reference_deg " +
        //                                                "FROM public.motor_control_data " +
        //                                                "WHERE port_info = 'COM5' " +
        //                                                "ORDER BY id DESC LIMIT 1", conn)) // "COM5" değerine sahip son kaydı almak için koşul eklendi
        //            {
        //                using (var reader = cmd.ExecuteReader())
        //                {
        //                    if (reader.Read())
        //                    {
        //                        // Verileri al
        //                        double fin1PositionReferenceDeg = reader.GetDouble(0);  // deg tipi double olduğu için GetDouble kullanıyoruz
        //                        double fin2PositionReferenceDeg = reader.GetDouble(1);  // deg tipi double olduğu için GetDouble kullanıyoruz
        //                        double fin1CurrentReferenceDeg = reader.GetDouble(2);  // deg tipi double olduğu için GetDouble kullanıyoruz
        //                        double fin2CurrentReferenceDeg = reader.GetDouble(3);  // deg tipi double olduğu için GetDouble kullanıyoruz

        //                        // TextBox'ları güncelle
        //                        UpdateTextBoxWithData(fin1PositionReferenceDegTextBox, fin1PositionReferenceDeg);
        //                        UpdateTextBoxWithData(fin2PositionReferenceDegTextBox, fin2PositionReferenceDeg);
        //                        UpdateTextBoxWithData(fin1CurrentReferenceDegTextBox, fin1CurrentReferenceDeg);
        //                        UpdateTextBoxWithData(fin2CurrentReferenceDegTextBox, fin2CurrentReferenceDeg);
        //                    }
        //                    else
        //                    {
        //                        // Veri yoksa uygun mesaj göster
        //                        if (fin1PositionReferenceDegTextBox.InvokeRequired)
        //                        {
        //                            fin1PositionReferenceDegTextBox.Invoke(new Action(() =>
        //                                fin1PositionReferenceDegTextBox.Text = "Veritabanında uygun veri bulunamadı."));
        //                        }
        //                        else
        //                        {
        //                            fin1PositionReferenceDegTextBox.Text = "Veritabanında uygun veri bulunamadı.";
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }

        public void DisplayLatestDegAndCurrentForCOM5(
    TextBox fin1PositionReferenceDegTextBox,
    TextBox fin2PositionReferenceDegTextBox,
    TextBox fin1CurrentReferenceDegTextBox,
    TextBox fin2CurrentReferenceDegTextBox,
    double fin1PositionReferenceDeg, // Form1'den gelen değer
    double fin2PositionReferenceDeg, // Form1'den gelen değer
    double fin1CurrentReferenceDeg,  // Form1'den gelen değer
    double fin2CurrentReferenceDeg  // Form1'den gelen değer
)
        {
            // TextBox'ları güncelle
            UpdateTextBoxWithData(fin1PositionReferenceDegTextBox, fin1PositionReferenceDeg);
            UpdateTextBoxWithData(fin2PositionReferenceDegTextBox, fin2PositionReferenceDeg);
            UpdateTextBoxWithData(fin1CurrentReferenceDegTextBox, fin1CurrentReferenceDeg);
            UpdateTextBoxWithData(fin2CurrentReferenceDegTextBox, fin2CurrentReferenceDeg);
        }






        private void UpdateTextBoxWithData(TextBox textBox, double value)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action(() =>
                {
                    textBox.Text = value.ToString();
                }));
            }
            else
            {
                textBox.Text = value.ToString();
            }
        }

        public void DisplayLatestDegAndCurrentindicator(
        TextBox fin1PositionReferenceDegTextBox,
        TextBox fin2PositionReferenceDegTextBox,
        TrackBar angleTrackBar, // Motor 1 için TrackBar
        TrackBar angleTrackBar2) // Motor 2 için TrackBar
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT " +
                                                   "fin1_position_reference_deg, " +
                                                   "fin2_position_reference_deg " +
                                                   "FROM public.motor_control_data " +
                                                   "WHERE port_info = 'COM6' " + // port_info koşulu eklendi
                                                   "ORDER BY id DESC LIMIT 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Verileri al
                            double fin1PositionReferenceDeg = reader.GetDouble(0);  // deg tipi double olduğu için GetDouble kullanıyoruz
                            double fin2PositionReferenceDeg = reader.GetDouble(1);  // deg tipi double olduğu için GetDouble kullanıyoruz

                            // TextBox'ları güncelle
                            UpdateTextBoxWithData(fin1PositionReferenceDegTextBox, fin1PositionReferenceDeg);
                            UpdateTextBoxWithData(fin2PositionReferenceDegTextBox, fin2PositionReferenceDeg);

                            // İbreyi güncelle (angleTrackBar'ın değerini, alınan 'deg' değerine göre ayarlıyoruz)
                            int fin1Value = (int)fin1PositionReferenceDeg;
                            int fin2Value = (int)fin2PositionReferenceDeg;

                            // Değerlerin sınırları kontrol ediliyor
                            if (fin1Value < angleTrackBar.Minimum) fin1Value = angleTrackBar.Minimum;
                            if (fin1Value > angleTrackBar.Maximum) fin1Value = angleTrackBar.Maximum;
                            if (fin2Value < angleTrackBar2.Minimum) fin2Value = angleTrackBar2.Minimum;
                            if (fin2Value > angleTrackBar2.Maximum) fin2Value = angleTrackBar2.Maximum;

                            angleTrackBar.Value = fin1Value; // Motor 1 için fin1PositionReferenceDeg
                            angleTrackBar2.Value = fin2Value; // Motor 2 için fin2PositionReferenceDeg

                            angleTrackBar.Invalidate();
                            angleTrackBar2.Invalidate();
                        }
                        else
                        {
                            // Veri yoksa uygun mesaj göster
                            if (fin1PositionReferenceDegTextBox.InvokeRequired)
                            {
                                fin1PositionReferenceDegTextBox.Invoke(new Action(() =>
                                    fin1PositionReferenceDegTextBox.Text = "Veritabanında herhangi bir veri bulunamadı."));
                            }
                            else
                            {
                                fin1PositionReferenceDegTextBox.Text = "Veritabanında herhangi bir veri bulunamadı.";
                            }
                        }
                    }
                }
            }
        }
        public void DisplayLatestDegAndCurrentindicatorForCOM5(
TextBox fin1PositionReferenceDegTextBox,
TextBox fin2PositionReferenceDegTextBox,
TrackBar angleTrackBar3, // Motor 1 için TrackBar (COM5)
TrackBar angleTrackBar4) // Motor 2 için TrackBar (COM5)
        {
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT " +
                                                   "fin1_position_reference_deg, " +
                                                   "fin2_position_reference_deg " +
                                                   "FROM public.motor_control_data " +
                                                   "WHERE port_info = 'COM5' " + // port_info koşulu eklendi
                                                   "ORDER BY id DESC LIMIT 1", conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Verileri al
                            double fin1PositionReferenceDeg = reader.GetDouble(0);  // deg tipi double olduğu için GetDouble kullanıyoruz
                            double fin2PositionReferenceDeg = reader.GetDouble(1);  // deg tipi double olduğu için GetDouble kullanıyoruz

                            // TextBox'ları güncelle
                            UpdateTextBoxWithData(fin1PositionReferenceDegTextBox, fin1PositionReferenceDeg);
                            UpdateTextBoxWithData(fin2PositionReferenceDegTextBox, fin2PositionReferenceDeg);

                            // İbreyi güncelle (angleTrackBar'ın değerini, alınan 'deg' değerine göre ayarlıyoruz)
                            int fin1Value = (int)fin1PositionReferenceDeg;
                            int fin2Value = (int)fin2PositionReferenceDeg;

                            // Değerlerin sınırları kontrol ediliyor
                            if (fin1Value < angleTrackBar3.Minimum) fin1Value = angleTrackBar3.Minimum;
                            if (fin1Value > angleTrackBar3.Maximum) fin1Value = angleTrackBar3.Maximum;
                            if (fin2Value < angleTrackBar4.Minimum) fin2Value = angleTrackBar4.Minimum;
                            if (fin2Value > angleTrackBar4.Maximum) fin2Value = angleTrackBar4.Maximum;

                            angleTrackBar3.Value = fin1Value; // Motor 1 için fin1PositionReferenceDeg
                            angleTrackBar4.Value = fin2Value; // Motor 2 için fin2PositionReferenceDeg

                            angleTrackBar3.Invalidate();
                            angleTrackBar4.Invalidate();
                        }
                        else
                        {
                            // Veri yoksa uygun mesaj göster
                            if (fin1PositionReferenceDegTextBox.InvokeRequired)
                            {
                                fin1PositionReferenceDegTextBox.Invoke(new Action(() =>
                                    fin1PositionReferenceDegTextBox.Text = "Veritabanında herhangi bir veri bulunamadı."));
                            }
                            else
                            {
                                fin1PositionReferenceDegTextBox.Text = "Veritabanında herhangi bir veri bulunamadı.";
                            }
                        }
                    }
                }
            }
        }



        public List<(DateTime createdAt, int fin1MotorHallState, int fin2MotorHallState)> GetFilteredDataHallStateForCOM6(DateTime filterDate)
        {
            var result = new List<(DateTime, int, int)>();
            using (var conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT createdat, fin1_motor_hall_state, fin2_motor_hall_state " +
                                                  "FROM public.motor_control_data " +
                                                  "WHERE port_info = 'COM6' AND createdat > @filterDate " +
                                                  "ORDER BY createdat ASC", conn))
                {
                    cmd.Parameters.AddWithValue("@filterDate", filterDate);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime createdAt = reader.GetDateTime(0);
                            int fin1MotorHallState = reader.GetInt32(1);
                            int fin2MotorHallState = reader.GetInt32(2);
                            result.Add((createdAt, fin1MotorHallState, fin2MotorHallState));
                        }
                    }
                }
            }
            return result;
        }


//        public void DisplayErrorsFromDatabase(TableLayoutPanel errortablelayout)
//        {
//            using (var conn = new NpgsqlConnection(connectionString))
//            {
//                conn.Open();
//                using (var cmd = new NpgsqlCommand("SELECT " +
//                                                    "fin2_hall_sensor_supply_error, " +
//                                                    "fin1_hall_sensor_supply_error, " +
//                                                    "fin2_hall_sensor_state_error, " +
//                                                    "fin1_hall_sensor_state_error, " +
//                                                    "fin2_motor_leakage_current_error, " +
//                                                    "fin1_motor_leakage_current_error, " +
//                                                    "fin2_motor_over_current_error, " +
//                                                    "fin1_motor_over_current_error, " +
//                                                    "fin2_solenoid_error, " +
//                                                    "fin1_solenoid_error, " +
//                                                    "supply_voltage_error, " +
//                                                    "temperature_sensor_error, " +
//                                                    "fin2_motor_driver_ic_error_by_cpld, " +
//                                                    "fin1_motor_driver_ic_error_by_cpld, " +
//                                                    "fin2_encoder_supply_error_by_cpld, " +
//                                                    "fin1_encoder_supply_error_by_cpld, " +
//                                                    "fin2_motor_temperature_error_by_cpld, " +
//                                                    "fin1_motor_temperature_error_by_cpld, " +
//                                                    "fin2_motor_driver_temperature_error_by_cpld, " +
//                                                    "fin1_motor_driver_temperature_error_by_cpld, " +
//                                                    "omkk_dsp_adc_1_5volt_error, " +
//                                                    "omkk_3_3volt_error_by_cpld, " +
//                                                    "omkk_5volt_error_by_cpld, " +
//                                                    "omkk_12volt_error_by_cpld " +
//                                                    "FROM public.motor_control_data " +
//                                                    "ORDER BY id DESC LIMIT 1", conn))
//                {
//                    using (var reader = cmd.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {

//                            // Her hatayı tek tek kontrol edip, true olanları işliyoruz
//                            CheckAndDisplayError(reader.GetBoolean(0), "Fin2 Hall Sensor Supply Error", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(1), "Fin1 Hall Sensor Supply Error", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(2), "Fin2 Hall Sensor State Error", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(3), "Fin1 Hall Sensor State Error", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(4), "Fin2 Motor Leakage Current Error", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(5), "Fin1 Motor Leakage Current Error", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(6), "Fin2 Motor Over Current Error", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(7), "Fin1 Motor Over Current Error", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(8), "Fin2 Solenoid Error", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(9), "Fin1 Solenoid Error", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(10), "Supply Voltage Error", -1, errortablelayout); // Genel hata, motorlarla doğrudan bağlantılı değil
//                            CheckAndDisplayError(reader.GetBoolean(11), "Temperature Sensor Error", -1, errortablelayout); // Genel hata
//                            CheckAndDisplayError(reader.GetBoolean(12), "Fin2 Motor Driver IC Error By CPLD", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(13), "Fin1 Motor Driver IC Error By CPLD", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(14), "Fin2 Encoder Supply Error By CPLD", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(15), "Fin1 Encoder Supply Error By CPLD", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(16), "Fin2 Motor Temperature Error By CPLD", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(17), "Fin1 Motor Temperature Error By CPLD", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(18), "Fin2 Motor Driver Temperature Error By CPLD", 1, errortablelayout); // Motor-2
//                            CheckAndDisplayError(reader.GetBoolean(19), "Fin1 Motor Driver Temperature Error By CPLD", 0, errortablelayout); // Motor-1
//                            CheckAndDisplayError(reader.GetBoolean(20), "OMKK DSP ADC 1.5 Volt Error", -1, errortablelayout); // Genel hata
//                            CheckAndDisplayError(reader.GetBoolean(21), "OMKK 3.3 Volt Error By CPLD", -1, errortablelayout); // Genel hata
//                            CheckAndDisplayError(reader.GetBoolean(22), "OMKK 5 Volt Error By CPLD", -1, errortablelayout); // Genel hata
//                            CheckAndDisplayError(reader.GetBoolean(23), "OMKK 12 Volt Error By CPLD", -1, errortablelayout); // Genel hata

//                        }
//                        else
//                        {
//                            // Veri yoksa uygun bir mesaj göster
//                            DisplayNoDataMessage(errortablelayout);
//                        }
//                    }
//                }
//            }
//        }

//        private void CheckAndDisplayError(bool errorCondition, string errorMessage, int motorIndex, TableLayoutPanel errortablelayout)
//        {
//            if (errorCondition)
//            {
//                DisplayError(errorMessage, motorIndex, errortablelayout);
//            }
//        }

//      private int motor1RowCount = 1; // Motor-1 için başlangıç satır sayısı
//private int motor2RowCount = 1; // Motor-2 için başlangıç satır sayısı
//private int generalErrorRowCount = 1; // Genel hatalar için başlangıç satır sayısı

//        private readonly Dictionary<string, Color> errorColors = new Dictionary<string, Color>()
//{
//    { "Fin1 Hall Sensor State Error", Color.Red },
//    { "Fin1 Motor Leakage Current Error", Color.Orange },
//    { "Fin1 Motor Over Current Error", Color.Gold },
//    { "Fin1 Solenoid Error", Color.Green },
//    { "Fin2 Hall Sensor State Error", Color.Blue },
//    { "Fin2 Solenoid Error", Color.Purple },
//    { "Supply Voltage Error", Color.Brown },
//    { "Temperature Sensor Error", Color.DarkRed },
//    { "OMKK DSP ADC 1.5 Volt Error", Color.DarkOrange },
//    { "OMKK 3.3 Volt Error By CPLD", Color.DarkGreen },
//    { "OMKK 5 Volt Error By CPLD", Color.DarkBlue },
//    { "OMKK 12 Volt Error By CPLD", Color.Magenta }
//    // Diğer hatalarınız için de renkler tanımlayabilirsiniz
//};

//        private void DisplayError(string errorMessage, int motorIndex, TableLayoutPanel errortablelayout)
//        {
//            // Sabit renk tanımlaması: Eğer hata mesajı belirli bir renge sahipse kullan, yoksa varsayılan siyah rengi kullan
//            Color errorColor = errorColors.ContainsKey(errorMessage) ? errorColors[errorMessage] : Color.Black;

//            // Hata etiketi oluştur
//            Label errorLabel = new Label()
//            {
//                Text = errorMessage,
//                TextAlign = System.Drawing.ContentAlignment.MiddleLeft,
//                Font = new Font("Segoe UI", 12F, FontStyle.Bold), // Daha modern font ve boyut
//                ForeColor = Color.FromArgb(50, 50, 50), // Sabit yazı rengi, örneğin koyu gri tonları
//                AutoSize = true,
//                Padding = new Padding(10, 5, 10, 5) // Daha fazla boşluk ve padding
//            };

//            // PictureBox kullanarak yuvarlak gösterim
//            PictureBox circleIndicator = new PictureBox()
//            {
//                Width = 20,
//                Height = 20,
//                BackColor = Color.Transparent
//            };

//            // Yuvarlak çizim için PictureBox'ın Paint eventini kullan
//            circleIndicator.Paint += (s, e) =>
//            {
//                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; // Pürüzsüzleştirme
//                using (Brush brush = new SolidBrush(errorColor))
//                {
//                    e.Graphics.FillEllipse(brush, 0, 0, circleIndicator.Width, circleIndicator.Height); // Pürüzsüz yuvarlak çizim
//                }
//            };

//            // FlowLayoutPanel kullanarak renkli yuvarlak ve hatayı yan yana yerleştirme
//            FlowLayoutPanel errorPanel = new FlowLayoutPanel()
//            {
//                AutoSize = true,
//                FlowDirection = FlowDirection.LeftToRight,
//                Padding = new Padding(0),
//                Margin = new Padding(0)
//            };
//            errorPanel.Controls.Add(circleIndicator);
//            errorPanel.Controls.Add(errorLabel);

//            if (motorIndex == 0)
//            {
//                // Motor-1 altında göster
//                errortablelayout.Controls.Add(errorPanel, 0, motor1RowCount);
//                motor1RowCount++;
//            }
//            else if (motorIndex == 1)
//            {
//                // Motor-2 altında göster
//                errortablelayout.Controls.Add(errorPanel, 1, motor2RowCount);
//                motor2RowCount++;
//            }
//            else
//            {
//                // Genel hatalar için özel bir sütuna ekleyebilirsiniz (örneğin, 2. sütun)
//                errortablelayout.Controls.Add(errorPanel, 2, generalErrorRowCount);
//                generalErrorRowCount++;
//            }
//        }

//        private void DisplayNoDataMessage(TableLayoutPanel errortablelayout)
//        {
//            Label noDataLabel = new Label()
//            {
//                Text = "Veritabanında herhangi bir hata verisi bulunamadı.",
//                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
//                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Italic),
//                ForeColor = Color.Gray,
//                Dock = DockStyle.Fill,
//                AutoSize = true
//            };

//            errortablelayout.Controls.Add(noDataLabel, 0, errortablelayout.RowCount);
//            errortablelayout.RowCount++;
//        }



        public async Task InsertMotorControlData(
 bool isMotor1Enabled,
 bool isMotor2Enabled,
 bool isFin1Opened,
 bool isFin2Opened,
 uint reservedMessageNoStatus,
 int fin1MotorHallState,
 int fin2MotorHallState,
 int actualDriveMode,
 bool fin2HallSensorSupplyError,
 bool fin1HallSensorSupplyError,
 bool fin2HallSensorStateError,
 bool fin1HallSensorStateError,
 bool fin2MotorLeakageCurrentError,
 bool fin1MotorLeakageCurrentError,
 bool fin2MotorOverCurrentError,
 bool fin1MotorOverCurrentError,
 bool fin2SolenoidError,
 bool fin1SolenoidError,
 bool supplyVoltageError,
 bool temperatureSensorError,
 bool fin2MotorDriverIcErrorByCpld,
 bool fin1MotorDriverIcErrorByCpld,
 bool fin2EncoderSupplyErrorByCpld,
 bool fin1EncoderSupplyErrorByCpld,
 bool fin2MotorTemperatureErrorByCpld,
 bool fin1MotorTemperatureErrorByCpld,
 bool fin2MotorDriverTemperatureErrorByCpld,
 bool fin1MotorDriverTemperatureErrorByCpld,
 bool omkkDspAdc1_5VoltError,
 bool omkk3_3VoltErrorByCpld,
 bool omkk5VoltErrorByCpld,
 bool omkk12VoltErrorByCpld,
 ushort fin1PositionFeedbackRaw,
 double fin1PositionFeedbackDeg,
 ushort fin2PositionFeedbackRaw,
 double fin2PositionFeedbackDeg,
 ushort fin1PositionReferenceRaw,
 double fin1PositionReferenceDeg,
 ushort fin2PositionReferenceRaw,
 double fin2PositionReferenceDeg,
 ushort fin1CurrentReferenceRaw,
 double fin1CurrentReferenceDeg,
 ushort fin2CurrentReferenceRaw,
 double fin2CurrentReferenceDeg,
 ushort fin1CurrentFeedbackRaw,
 double fin1CurrentFeedbackDeg,
 ushort fin2CurrentFeedbackRaw,
 double fin2CurrentFeedbackDeg,
 double fin1AppliedPWM,
 double fin2AppliedPWM,
 int dspSoftwareVersion,
 int cpldVersion,
 int executionTimeOfTheCurrentLoop,
 int executionTimeOfThePositionLoop,
 int executionTimeOfTheLowFrequencyTask,
 ushort instantBatteryVoltageRaw,
 double instantBatteryVoltage,
 ushort meanBatteryVoltageRaw,
 double meanBatteryVoltage,
 double cardTemperature,
 bool isSolenoid1Open,
 bool isSolenoid2Open,
 double totalConsumedPower,
 float motor1Currents3PhasesA,
 float motor1Currents3PhasesB,
 float motor1Currents3PhasesC,
 float motor2Currents3PhasesA,
 float motor2Currents3PhasesB,
 float motor2Currents3PhasesC,
 float backEMFVoltage3PhaseMotor1A,
 float backEMFVoltage3PhaseMotor1B,
 float backEMFVoltage3PhaseMotor1C,
 float motor1Currents3PhasesA_Status3,
 float motor1Currents3PhasesB_Status3,
 float motor1Currents3PhasesC_Status3,
 float backEMFVoltage3PhaseMotor2A,
 float backEMFVoltage3PhaseMotor2B,
 float backEMFVoltage3PhaseMotor2C,
 float motor2Currents3PhasesA_Status4,
 float motor2Currents3PhasesB_Status4,
 float motor2Currents3PhasesC_Status4,
 bool isPos2PosSysAnalysisActivated,
 float tachometerMotor1,
 float tachometerMotor2,
 float loopCommandMotor1,
 float loopCommandMotor2,
 float currentControlPrm_R_40,
 float currentControlPrm_L_40,
 float currentControlPrm_BW_40,
 float positionControlPrm_Kp_40,
 float positionControlPrm_Ki_40,
 float positionControlPrm_Kd_40,
 float instantFrequency,
 ushort timePassed,
 ushort systemAnalysisMotorId,
 float startFrequency,
 float finishFrequency,
 bool isCurrent2CurrentSysAnalysisActivated,
 float sfraMagnitudeVectorDb,
 float sfraPhaseVectorDeg,
 float sfraFrequencyVectorHz,
 short sfraObj_FreqIndex,
 ushort tipToMdcMessage_SystemAnalysisMotorNo,
 bool systemType,
 bool receivedAutopilotMsgError,
 bool fin1OpenSwitchState,
 bool fin2OpenSwitchState,
 bool fin1CloseSwitchState,
 bool fin2CloseSwitchState,
 bool motorDriveMethod,
 bool reservedBits,
 int counter, 
 string portInfo



)
    {
        using (var conn = new NpgsqlConnection(connectionString))
        {
                await conn.OpenAsync(); // Bağlantıyı asenkron aç
                using (var cmd = new NpgsqlCommand("INSERT INTO public.motor_control_data (is_motor1_enabled, is_motor2_enabled, is_fin1_opened, is_fin2_opened, reserved_message_no_status, fin1_motor_hall_state, fin2_motor_hall_state, actual_drive_mode, fin2_hall_sensor_supply_error, fin1_hall_sensor_supply_error, fin2_hall_sensor_state_error, fin1_hall_sensor_state_error, fin2_motor_leakage_current_error, fin1_motor_leakage_current_error, fin2_motor_over_current_error, fin1_motor_over_current_error, fin2_solenoid_error, fin1_solenoid_error, supply_voltage_error, temperature_sensor_error, fin2_motor_driver_ic_error_by_cpld, fin1_motor_driver_ic_error_by_cpld, fin2_encoder_supply_error_by_cpld, fin1_encoder_supply_error_by_cpld, fin2_motor_temperature_error_by_cpld, fin1_motor_temperature_error_by_cpld, fin2_motor_driver_temperature_error_by_cpld, fin1_motor_driver_temperature_error_by_cpld, omkk_dsp_adc_1_5volt_error, omkk_3_3volt_error_by_cpld, omkk_5volt_error_by_cpld, omkk_12volt_error_by_cpld, fin1_position_feedback_raw, fin1_position_feedback_deg, fin2_position_feedback_raw, fin2_position_feedback_deg, fin1_position_reference_raw, fin1_position_reference_deg, fin2_position_reference_raw, fin2_position_reference_deg, fin1_current_reference_raw, fin1_current_reference_deg, fin2_current_reference_raw, fin2_current_reference_deg, fin1_current_feedback_raw, fin1_current_feedback_deg, fin2_current_feedback_raw, fin2_current_feedback_deg, fin1_applied_pwm, fin2_applied_pwm, dsp_software_version, cpld_version, execution_time_of_the_current_loop, execution_time_of_the_position_loop, execution_time_of_the_low_frequency_task, instant_battery_voltage_raw, instant_battery_voltage, mean_battery_voltage_raw, mean_battery_voltage, card_temperature, is_solenoid1_open, is_solenoid2_open, total_consumed_power, system_type, received_autopilot_msg_error, fin1_open_switch_state, fin2_open_switch_state, fin1_close_switch_state, fin2_close_switch_state, motor_drive_method, reserved_bits, counter, motor1_currents3phases_a, motor1_currents3phases_b, motor1_currents3phases_c, motor2_currents3phases_a, motor2_currents3phases_b, motor2_currents3phases_c, back_emf_voltage_3phase_motor1_a, back_emf_voltage_3phase_motor1_b, back_emf_voltage_3phase_motor1_c, motor1_currents3phases_a_status3, motor1_currents3phases_b_status3, motor1_currents3phases_c_status3, back_emf_voltage_3phase_motor2_a, back_emf_voltage_3phase_motor2_b, back_emf_voltage_3phase_motor2_c, motor2_currents3phases_a_status4, motor2_currents3phases_b_status4, motor2_currents3phases_c_status4, is_pos2pos_sys_analysis_activated, tachometer_motor1, tachometer_motor2, loop_command_motor1, loop_command_motor2, current_control_prm_r_40, current_control_prm_l_40, current_control_prm_bw_40, position_control_prm_kp_40, position_control_prm_ki_40, position_control_prm_kd_40, instant_frequency, time_passed, system_analysis_motor_id, start_frequency, finish_frequency, is_current2_current_sys_analysis_activated, sfra_magnitude_vector_db, sfra_phase_vector_deg, sfra_frequency_vector_hz, sfra_obj_freq_index, tip_to_mdc_message_system_analysis_motor_no, port_info, createdAt) VALUES (@is_motor1_enabled, @is_motor2_enabled, @is_fin1_opened, @is_fin2_opened, @reserved_message_no_status, @fin1_motor_hall_state, @fin2_motor_hall_state, @actual_drive_mode, @fin2_hall_sensor_supply_error, @fin1_hall_sensor_supply_error, @fin2_hall_sensor_state_error, @fin1_hall_sensor_state_error, @fin2_motor_leakage_current_error, @fin1_motor_leakage_current_error, @fin2_motor_over_current_error, @fin1_motor_over_current_error, @fin2_solenoid_error, @fin1_solenoid_error, @supply_voltage_error, @temperature_sensor_error, @fin2_motor_driver_ic_error_by_cpld, @fin1_motor_driver_ic_error_by_cpld, @fin2_encoder_supply_error_by_cpld, @fin1_encoder_supply_error_by_cpld, @fin2_motor_temperature_error_by_cpld, @fin1_motor_temperature_error_by_cpld, @fin2_motor_driver_temperature_error_by_cpld, @fin1_motor_driver_temperature_error_by_cpld, @omkk_dsp_adc_1_5volt_error, @omkk_3_3volt_error_by_cpld, @omkk_5volt_error_by_cpld, @omkk_12volt_error_by_cpld, @fin1_position_feedback_raw, @fin1_position_feedback_deg, @fin2_position_feedback_raw, @fin2_position_feedback_deg, @fin1_position_reference_raw, @fin1_position_reference_deg, @fin2_position_reference_raw, @fin2_position_reference_deg, @fin1_current_reference_raw, @fin1_current_reference_deg, @fin2_current_reference_raw, @fin2_current_reference_deg, @fin1_current_feedback_raw, @fin1_current_feedback_deg, @fin2_current_feedback_raw, @fin2_current_feedback_deg, @fin1_applied_pwm, @fin2_applied_pwm, @dsp_software_version, @cpld_version, @execution_time_of_the_current_loop, @execution_time_of_the_position_loop, @execution_time_of_the_low_frequency_task, @instant_battery_voltage_raw, @instant_battery_voltage, @mean_battery_voltage_raw, @mean_battery_voltage, @card_temperature, @is_solenoid1_open, @is_solenoid2_open, @total_consumed_power, @system_type, @received_autopilot_msg_error, @fin1_open_switch_state, @fin2_open_switch_state, @fin1_close_switch_state, @fin2_close_switch_state, @motor_drive_method, @reserved_bits, @counter, @motor1_currents3phases_a, @motor1_currents3phases_b, @motor1_currents3phases_c, @motor2_currents3phases_a, @motor2_currents3phases_b, @motor2_currents3phases_c, @back_emf_voltage_3phase_motor1_a, @back_emf_voltage_3phase_motor1_b, @back_emf_voltage_3phase_motor1_c, @motor1_currents3phases_a_status3, @motor1_currents3phases_b_status3, @motor1_currents3phases_c_status3, @back_emf_voltage_3phase_motor2_a, @back_emf_voltage_3phase_motor2_b, @back_emf_voltage_3phase_motor2_c, @motor2_currents3phases_a_status4, @motor2_currents3phases_b_status4, @motor2_currents3phases_c_status4, @is_pos2pos_sys_analysis_activated, @tachometer_motor1, @tachometer_motor2, @loop_command_motor1, @loop_command_motor2, @current_control_prm_r_40, @current_control_prm_l_40, @current_control_prm_bw_40, @position_control_prm_kp_40, @position_control_prm_ki_40, @position_control_prm_kd_40, @instant_frequency, @time_passed, @system_analysis_motor_id, @start_frequency, @finish_frequency, @is_current2_current_sys_analysis_activated, @sfra_magnitude_vector_db, @sfra_phase_vector_deg, @sfra_frequency_vector_hz, @sfra_obj_freq_index, @tip_to_mdc_message_system_analysis_motor_no, @port_info, @createdAt)", conn))
                {
                    cmd.Parameters.AddWithValue("@is_motor1_enabled", isMotor1Enabled);
                cmd.Parameters.AddWithValue("@is_motor2_enabled", isMotor2Enabled);
                cmd.Parameters.AddWithValue("@is_fin1_opened", isFin1Opened);
                cmd.Parameters.AddWithValue("@is_fin2_opened", isFin2Opened);
                cmd.Parameters.AddWithValue("@reserved_message_no_status", (long)reservedMessageNoStatus); // UInt32 -> long
                cmd.Parameters.AddWithValue("@fin1_motor_hall_state", fin1MotorHallState);
                cmd.Parameters.AddWithValue("@fin2_motor_hall_state", fin2MotorHallState);
                cmd.Parameters.AddWithValue("@actual_drive_mode", actualDriveMode);
                cmd.Parameters.AddWithValue("@fin2_hall_sensor_supply_error", fin2HallSensorSupplyError);
                cmd.Parameters.AddWithValue("@fin1_hall_sensor_supply_error", fin1HallSensorSupplyError);
                cmd.Parameters.AddWithValue("@fin2_hall_sensor_state_error", fin2HallSensorStateError);
                cmd.Parameters.AddWithValue("@fin1_hall_sensor_state_error", fin1HallSensorStateError);
                cmd.Parameters.AddWithValue("@fin2_motor_leakage_current_error", fin2MotorLeakageCurrentError);
                cmd.Parameters.AddWithValue("@fin1_motor_leakage_current_error", fin1MotorLeakageCurrentError);
                cmd.Parameters.AddWithValue("@fin2_motor_over_current_error", fin2MotorOverCurrentError);
                cmd.Parameters.AddWithValue("@fin1_motor_over_current_error", fin1MotorOverCurrentError);
                cmd.Parameters.AddWithValue("@fin2_solenoid_error", fin2SolenoidError);
                cmd.Parameters.AddWithValue("@fin1_solenoid_error", fin1SolenoidError);
                cmd.Parameters.AddWithValue("@supply_voltage_error", supplyVoltageError);
                cmd.Parameters.AddWithValue("@temperature_sensor_error", temperatureSensorError);
                cmd.Parameters.AddWithValue("@fin2_motor_driver_ic_error_by_cpld", fin2MotorDriverIcErrorByCpld);
                cmd.Parameters.AddWithValue("@fin1_motor_driver_ic_error_by_cpld", fin1MotorDriverIcErrorByCpld);
                cmd.Parameters.AddWithValue("@fin2_encoder_supply_error_by_cpld", fin2EncoderSupplyErrorByCpld);
                cmd.Parameters.AddWithValue("@fin1_encoder_supply_error_by_cpld", fin1EncoderSupplyErrorByCpld);
                cmd.Parameters.AddWithValue("@fin2_motor_temperature_error_by_cpld", fin2MotorTemperatureErrorByCpld);
                cmd.Parameters.AddWithValue("@fin1_motor_temperature_error_by_cpld", fin1MotorTemperatureErrorByCpld);
                cmd.Parameters.AddWithValue("@fin2_motor_driver_temperature_error_by_cpld", fin2MotorDriverTemperatureErrorByCpld);
                cmd.Parameters.AddWithValue("@fin1_motor_driver_temperature_error_by_cpld", fin1MotorDriverTemperatureErrorByCpld);
                cmd.Parameters.AddWithValue("@omkk_dsp_adc_1_5volt_error", omkkDspAdc1_5VoltError);
                cmd.Parameters.AddWithValue("@omkk_3_3volt_error_by_cpld", omkk3_3VoltErrorByCpld);
                cmd.Parameters.AddWithValue("@omkk_5volt_error_by_cpld", omkk5VoltErrorByCpld);
                cmd.Parameters.AddWithValue("@omkk_12volt_error_by_cpld", omkk12VoltErrorByCpld);
                cmd.Parameters.AddWithValue("@fin1_position_feedback_raw", (int)fin1PositionFeedbackRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin1_position_feedback_deg", fin1PositionFeedbackDeg);
                cmd.Parameters.AddWithValue("@fin2_position_feedback_raw", (int)fin2PositionFeedbackRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin2_position_feedback_deg", fin2PositionFeedbackDeg);
                cmd.Parameters.AddWithValue("@fin1_position_reference_raw", (int)fin1PositionReferenceRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin1_position_reference_deg", fin1PositionReferenceDeg);
                cmd.Parameters.AddWithValue("@fin2_position_reference_raw", (int)fin2PositionReferenceRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin2_position_reference_deg", fin2PositionReferenceDeg);
                cmd.Parameters.AddWithValue("@fin1_current_reference_raw", (int)fin1CurrentReferenceRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin1_current_reference_deg", fin1CurrentReferenceDeg);
                cmd.Parameters.AddWithValue("@fin2_current_reference_raw", (int)fin2CurrentReferenceRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin2_current_reference_deg", fin2CurrentReferenceDeg);
                cmd.Parameters.AddWithValue("@fin1_current_feedback_raw", (int)fin1CurrentFeedbackRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin1_current_feedback_deg", fin1CurrentFeedbackDeg);
                cmd.Parameters.AddWithValue("@fin2_current_feedback_raw", (int)fin2CurrentFeedbackRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@fin2_current_feedback_deg", fin2CurrentFeedbackDeg);
                cmd.Parameters.AddWithValue("@fin1_applied_pwm", fin1AppliedPWM);
                cmd.Parameters.AddWithValue("@fin2_applied_pwm", fin2AppliedPWM);
                cmd.Parameters.AddWithValue("@dsp_software_version", dspSoftwareVersion);
                cmd.Parameters.AddWithValue("@cpld_version", cpldVersion);
                cmd.Parameters.AddWithValue("@execution_time_of_the_current_loop", executionTimeOfTheCurrentLoop);
                cmd.Parameters.AddWithValue("@execution_time_of_the_position_loop", executionTimeOfThePositionLoop);
                cmd.Parameters.AddWithValue("@execution_time_of_the_low_frequency_task", executionTimeOfTheLowFrequencyTask);
                cmd.Parameters.AddWithValue("@instant_battery_voltage_raw", (int)instantBatteryVoltageRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@instant_battery_voltage", instantBatteryVoltage);
                cmd.Parameters.AddWithValue("@mean_battery_voltage_raw", (int)meanBatteryVoltageRaw); // ushort -> int
                cmd.Parameters.AddWithValue("@mean_battery_voltage", meanBatteryVoltage);
                cmd.Parameters.AddWithValue("@card_temperature", cardTemperature);
                cmd.Parameters.AddWithValue("@is_solenoid1_open", isSolenoid1Open);
                cmd.Parameters.AddWithValue("@is_solenoid2_open", isSolenoid2Open);
                cmd.Parameters.AddWithValue("@total_consumed_power", totalConsumedPower);
                cmd.Parameters.AddWithValue("@system_type", systemType);
                cmd.Parameters.AddWithValue("@received_autopilot_msg_error", receivedAutopilotMsgError);
                cmd.Parameters.AddWithValue("@fin1_open_switch_state", fin1OpenSwitchState);
                cmd.Parameters.AddWithValue("@fin2_open_switch_state", fin2OpenSwitchState);
                cmd.Parameters.AddWithValue("@fin1_close_switch_state", fin1CloseSwitchState);
                cmd.Parameters.AddWithValue("@fin2_close_switch_state", fin2CloseSwitchState);
                cmd.Parameters.AddWithValue("@motor_drive_method", motorDriveMethod);
                cmd.Parameters.AddWithValue("@reserved_bits", reservedBits);
                cmd.Parameters.AddWithValue("@counter", counter);
                cmd.Parameters.AddWithValue("@motor1_currents3phases_a", motor1Currents3PhasesA);
                cmd.Parameters.AddWithValue("@motor1_currents3phases_b", motor1Currents3PhasesB);
                cmd.Parameters.AddWithValue("@motor1_currents3phases_c", motor1Currents3PhasesC);
                cmd.Parameters.AddWithValue("@motor2_currents3phases_a", motor2Currents3PhasesA);
                cmd.Parameters.AddWithValue("@motor2_currents3phases_b", motor2Currents3PhasesB);
                cmd.Parameters.AddWithValue("@motor2_currents3phases_c", motor2Currents3PhasesC);
                cmd.Parameters.AddWithValue("@back_emf_voltage_3phase_motor1_a", backEMFVoltage3PhaseMotor1A);
                cmd.Parameters.AddWithValue("@back_emf_voltage_3phase_motor1_b", backEMFVoltage3PhaseMotor1B);
                cmd.Parameters.AddWithValue("@back_emf_voltage_3phase_motor1_c", backEMFVoltage3PhaseMotor1C);
                cmd.Parameters.AddWithValue("@motor1_currents3phases_a_status3", motor1Currents3PhasesA_Status3);
                cmd.Parameters.AddWithValue("@motor1_currents3phases_b_status3", motor1Currents3PhasesB_Status3);
                cmd.Parameters.AddWithValue("@motor1_currents3phases_c_status3", motor1Currents3PhasesC_Status3);
                cmd.Parameters.AddWithValue("@back_emf_voltage_3phase_motor2_a", backEMFVoltage3PhaseMotor2A);
                cmd.Parameters.AddWithValue("@back_emf_voltage_3phase_motor2_b", backEMFVoltage3PhaseMotor2B);
                cmd.Parameters.AddWithValue("@back_emf_voltage_3phase_motor2_c", backEMFVoltage3PhaseMotor2C);
                cmd.Parameters.AddWithValue("@motor2_currents3phases_a_status4", motor2Currents3PhasesA_Status4);
                cmd.Parameters.AddWithValue("@motor2_currents3phases_b_status4", motor2Currents3PhasesB_Status4);
                cmd.Parameters.AddWithValue("@motor2_currents3phases_c_status4", motor2Currents3PhasesC_Status4);
                cmd.Parameters.AddWithValue("@is_pos2pos_sys_analysis_activated", isPos2PosSysAnalysisActivated);
                cmd.Parameters.AddWithValue("@tachometer_motor1", tachometerMotor1);
                cmd.Parameters.AddWithValue("@tachometer_motor2", tachometerMotor2);
                cmd.Parameters.AddWithValue("@loop_command_motor1", loopCommandMotor1);
                cmd.Parameters.AddWithValue("@loop_command_motor2", loopCommandMotor2);
                cmd.Parameters.AddWithValue("@current_control_prm_r_40", currentControlPrm_R_40);
                cmd.Parameters.AddWithValue("@current_control_prm_l_40", currentControlPrm_L_40);
                cmd.Parameters.AddWithValue("@current_control_prm_bw_40", currentControlPrm_BW_40);
                cmd.Parameters.AddWithValue("@position_control_prm_kp_40", positionControlPrm_Kp_40);
                cmd.Parameters.AddWithValue("@position_control_prm_ki_40", positionControlPrm_Ki_40);
                cmd.Parameters.AddWithValue("@position_control_prm_kd_40", positionControlPrm_Kd_40);
                cmd.Parameters.AddWithValue("@instant_frequency", instantFrequency);
                cmd.Parameters.AddWithValue("@time_passed", (int)timePassed); // ushort -> int
                cmd.Parameters.AddWithValue("@system_analysis_motor_id", (int)systemAnalysisMotorId); // ushort -> int
                cmd.Parameters.AddWithValue("@start_frequency", startFrequency);
                cmd.Parameters.AddWithValue("@finish_frequency", finishFrequency);
                cmd.Parameters.AddWithValue("@is_current2_current_sys_analysis_activated", isCurrent2CurrentSysAnalysisActivated);
                cmd.Parameters.AddWithValue("@sfra_magnitude_vector_db", sfraMagnitudeVectorDb);
                cmd.Parameters.AddWithValue("@sfra_phase_vector_deg", sfraPhaseVectorDeg);
                cmd.Parameters.AddWithValue("@sfra_frequency_vector_hz", sfraFrequencyVectorHz);
                cmd.Parameters.AddWithValue("@sfra_obj_freq_index", sfraObj_FreqIndex);
                cmd.Parameters.AddWithValue("@tip_to_mdc_message_system_analysis_motor_no", (int)tipToMdcMessage_SystemAnalysisMotorNo); // ushort -> int
                   
                    cmd.Parameters.AddWithValue("@port_info", (string)portInfo);
                    TimeZoneInfo istanbulTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
                    DateTime createdAt = TimeZoneInfo.ConvertTime(DateTime.Now, istanbulTimeZone);
                    cmd.Parameters.AddWithValue("@createdAt", createdAt); // Istanbul saatine göre UTC+3

                    await cmd.ExecuteNonQueryAsync();



                }

            }

    }




}

}
