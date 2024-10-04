using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        bool isMotor1Enabled; // 2. byte'ın 1. biti
        bool isMotor2Enabled; // 2. byte'ın 2. biti
        bool isFin1Opened; // 2. byte'ın 3. biti
        bool isFin2Opened; // 2. byte'ın 4. biti
        bool ReservedMessageNoStatus; // 2. byte'ın 4-7. biti


        // 3. byte'ın bitlerini kontrol et
        int Fin1MotorHallState; // 3. byte'ın 0-2. 3 biti
        int Fin2MotorHallState; // 3. byte'ın 3-5. 3 biti
        int ActualDriveMode; // 3. byte'ın 6-7. 2 biti

        bool Fin2_HallSensorSUpplyError; // 4. byte'ın 1. biti
        bool Fin1_HallSensorSUpplyError; // 4. byte'ın 2. biti
        bool Fin2_HallSensorStateError; // 4. byte'ın 3. biti
        bool Fin1_HallSensorStateError; // 4. byte'ın 4. biti
        bool Fin2_MotorLeakageCurrentError; // 4. byte'ın 5. biti
        bool Fin1_MotorLeakageCurrentError; // 4. byte'ın 6. biti
        bool Fin2_MotorOverCurrentError; // 4. byte'ın 7. biti
        bool Fin1_MotorOverCurrentError; // 4. byte'ın 8. biti


        bool Fin2_SolenoidError; // 4. byte'ın 1. biti
        bool Fin1_SolenoidError; // 4. byte'ın 2. biti
        bool SupplyVoltageError; // 4. byte'ın 3. biti
        bool TemperatureSensorError; // 4. byte'ın 4. biti
        bool Fin2_MotorDriverICErrorByCPLD; // 4. byte'ın 5. biti
        bool Fin1_MotorDriverICErrorByCPLD; // 4. byte'ın 6. biti
        bool Fin2_EncoderSupplyErrorByCPLD; // 4. byte'ın 7. biti
        bool Fin1_EncoderSupplyErrorByCPLD; // 4. byte'ın 8. biti


        bool Fin2_MotorTemperatureErrorByCPLD; // 4. byte'ın 1. biti
        bool Fin1_MotorTemperatureErrorByCPLD; // 4. byte'ın 2. biti
        bool Fin2_MotorDriverTemperatureErrorByCPLD; // 4. byte'ın 3. biti
        bool Fin1_MotorDriverTemperatureErrorByCPLD; // 4. byte'ın 4. biti
        bool Omkk_DspAdc_1_5VoltError; // 4. byte'ın 5. biti
        bool Omkk_3_3VoltErrorByCPLD; // 4. byte'ın 6. biti
        bool Omkk_5VoltErrorByCPLD; // 4. byte'ın 7. biti
        bool Omkk_12VoltErrorByCPLD; // 4. byte'ın 8. biti

        ushort Fin1PositionFeedbackRaw;
        double Fin1PositionFeedbackDeg;
        ushort Fin2PositionFeedbackRaw;
        double Fin2PositionFeedbackDeg;
        ushort Fin1PositionReferenceRaw;
        double Fin1PositionReferenceDeg;

        ushort Fin2PositionReferenceRaw;
        double Fin2PositionReferenceDeg;

        ushort Fin1CurrentReferenceRaw;
        double Fin1CurrentReferenceDeg;
        ushort Fin2CurrentReferenceRaw;
        double Fin2CurrentReferenceDeg;

        ushort Fin1CurrentFeedbackRaw;
        double Fin1CurrentFeedbackDeg;
        ushort Fin2CurrentFeedbackRaw;
        double Fin2CurrentFeedbackDeg;

        double fin1AppliedPWM;
        double fin2AppliedPWM;

        int DspSoftwareVersion;
        int CpldVersion;
        int ExecutionTimeOfTheCurrentLoop;
        int ExecutionTimeOfThePositionLoop;
        int ExecutionTimeOfTheLowFrequencyTask;


        ushort InstantBatteryVoltageRaw;
        double InstantBatteryVoltage;
        ushort MeanBatteryVoltageRaw;
        double MeanBatteryVoltage;

        double CardTemperature;
        double isSolenoid1Open;
        double isSolenoid2Open;
        double TotalConsumedPower;



        bool SystemType; // 37. byte'ın 1. biti
        bool ReceivedAutopilotMsgError; // 37. byte'ın 2. biti
        bool Fin1OpenSwitchState; // 37. byte'ın 3. biti
        bool Fin2OpenSwitchState; // 37. byte'ın 4. biti
        bool Fin1CloseSwitchState; // 37. byte'ın 5. biti
        bool Fin2CloseSwitchState; // 37. byte'ın 6. biti
        bool MotorDriveMethod; // 37. byte'ın 7. biti
        bool ReservedBits; // 37. byte'ın 8. biti



        //PROTOKOL 2 
        private Random random = new Random();

        // Verilerin tutulduğu yapı
        public byte Header1 = 0xD5;
        public byte ReservedMessageNumberCommand;
        public byte SystemAnalysisMotorNo;
        public byte IsCurrentControllerChangeCommandValid;
        public byte IsPosControllerChangeCommandValid;
        public byte DriveModeCommand;
        public byte IsFin1MotorEnableCommandActivated;
        public byte IsFin2MotorEnableCommandActivated;
        public byte IsSolenoid1OpenCommandActivated;
        public byte IsSolenoid2OpenCommandActivated;
        public byte SystemAnalysisModeCommand;
        public float SentFin1Command;
        public float SentFin2Command;
        public float PosSysAnalysisStartFrequencyCommand;
        public float PosSysAnalysisFinishFrequencyCommand;
        public float PosSysAnalysisStartAmplitudeCommand;
        public float PosSysAnalysisFinishAmplitudeCommand;
        public ushort PosSysAnalysisTestDurationCommand;
        public float CurrentControlPrm_R;
        public float CurrentControlPrm_L;
        public float CurrentControlPrm_BW;
        public float PositionControlPrm_Kp;
        public float PositionControlPrm_Ki;
        public float PositionControlPrm_Kd;
        public byte Header2 = 0x3A;
        public byte CheckSum;



        int counter;
        private string role;
        private SerialPort serialport = new SerialPort();
        private SerialPort serialport2 = new SerialPort();


        private List<byte> receivedDataBuffer = new List<byte>();
        private System.Timers.Timer dataReceiveTimer;
        private const int messageLength = 40;
        private const int messageLenght2 = 20;// Mesaj uzunluğu
        private const byte headerByte = 0x1D; // Mesajın başlangıç baytı
        private const byte headerByteD5 = 0xD5; // Mesajın başlangıç baytı
        byte[] fullMessage = new byte[40];
        byte[] fullMessage2 = new byte[21];


        public Form1(string role)
        {
            this.role = role;
            InitializeComponent();
            GetAvailablePorts();
            GetAvailablePorts2();

            // Zamanlayıcıyı ayarlayalım
            dataReceiveTimer = new System.Timers.Timer(100); // 10 ms
            dataReceiveTimer.AutoReset = false;
            dataReceiveTimer.Elapsed += DataReceiveTimer_Elapsed;
        }

        private void DataReceiveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // 10 ms geçti, buffer'ı temizleyip hata mesajı gösteriyoruz
            receivedDataBuffer.Clear();

            Invoke(new Action(() =>
            {
                MessageBox.Show("10 ms'lik kesinti tespit edildi!");
            }));


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listViewMessages.View = View.Details;
            listViewMessages.Columns.Add("Mesaj", 650, HorizontalAlignment.Left);
            listViewMessages.Columns.Add("Zaman", 100, HorizontalAlignment.Left);



        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialport.IsOpen)
            {
                serialport.Close();
            }
        }
        private void GetAvailablePorts()
        {
            comboBoxPorts.Items.Clear(); // Mevcut öğeleri temizle
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(port); // Portları ekle
            }

            if (comboBoxPorts.Items.Count > 0)
            {
                comboBoxPorts.SelectedIndex = 0; // İlk portu seç
            }
            else
            {
                MessageBox.Show("Hiçbir port bulunamadı.");
            }
        }


        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            if (role == "admin")
            {


                try
                {
                    // Eğer aynı port 2. SerialPort'ta açıksa, önce o portu kapat
                    if (serialport2.IsOpen && serialport2.PortName == comboBoxPorts.SelectedItem.ToString())
                    {
                        serialport2.Close();
                        buttonOpenPort2.Text = "Portu Aç";
                    }

                    if (serialport.IsOpen)
                    {
                        serialport.Close();
                        buttonOpenPort.Text = "Portu Aç";
                    }
                    else
                    {
                        serialport.PortName = comboBoxPorts.SelectedItem.ToString();
                        serialport.BaudRate = 9600;
                        serialport.Parity = Parity.None;
                        serialport.StopBits = StopBits.One;
                        serialport.DataBits = 8;
                        serialport.Handshake = Handshake.None;
                        serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                        serialport.Open();
                        buttonOpenPort.Text = "Portu Kapat";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Yetkiniz yeterli değil");
            }
        }


        private bool ValidateChecksum(byte[] message)
        {
            if (message.Length != messageLength)
                return false;

            // Checksum hesaplaması (son bayt checksum olduğu için dahil etmiyoruz)
            int sum = 0;
            for (int i = 0; i < message.Length - 1; i++)
            {
                sum += message[i];
            }
            byte calculatedChecksum = (byte)(sum & 0xFF);

            // Mesajın son baytı (message[39]) alınan checksum
            byte receivedChecksum = message[message.Length - 1];

            return calculatedChecksum == receivedChecksum;
        }

   

        private double ConvertRawToDegrees(ushort rawValue, int betweens)
        {
            // Ham değer 0 - 65535 aralığında
            // Derece aralığı: -25 ile +25 derece arası
            // Önce ham değeri 0 - 1 aralığına normalleştir
            double normalized = rawValue / 65535.0;
            double degrees;
            if (betweens == 25)
                // Ardından -25 ile +25 derece aralığına ölçeklendir
                degrees = (normalized * 50.0) - 25.0;
            else if (betweens == 50)
                degrees = (normalized * 100.0) - 50.0;
            else
                degrees = 0;

            return degrees;
        }

        private void ProcessMotorControls(byte[] data)
        {
            if (data.Length < 3) return; // En az 3 byte olmalı

            // 2. byte'ın bitlerini kontrol et
            isMotor1Enabled = (data[1] & 0b00000001) != 0; // 2. byte'ın 1. biti
            isMotor2Enabled = (data[1] & 0b00000010) != 0; // 2. byte'ın 2. biti
            isFin1Opened = (data[1] & 0b00000100) != 0; // 2. byte'ın 3. biti
            isFin2Opened = (data[1] & 0b00001000) != 0; // 2. byte'ın 4. biti
            ReservedMessageNoStatus = (data[1] & 0b11110000) != 0; // 2. byte'ın 4-7. biti


            // 3. byte'ın bitlerini kontrol et
            Fin1MotorHallState = (data[2] & 0b00000111); // 3. byte'ın 0-2. 3 biti
            Fin2MotorHallState = (data[2] & 0b00111000); // 3. byte'ın 3-5. 3 biti
            ActualDriveMode = (data[2] & 0b11000000); // 3. byte'ın 6-7. 2 biti

            Fin2_HallSensorSUpplyError = (data[3] & 0b00000001) != 0; // 4. byte'ın 1. biti
            Fin1_HallSensorSUpplyError = (data[3] & 0b00000010) != 0; // 4. byte'ın 2. biti
            Fin2_HallSensorStateError = (data[3] & 0b00000100) != 0; // 4. byte'ın 3. biti
            Fin1_HallSensorStateError = (data[3] & 0b00001000) != 0; // 4. byte'ın 4. biti
            Fin2_MotorLeakageCurrentError = (data[3] & 0b00010000) != 0; // 4. byte'ın 5. biti
            Fin1_MotorLeakageCurrentError = (data[3] & 0b00100000) != 0; // 4. byte'ın 6. biti
            Fin2_MotorOverCurrentError = (data[3] & 0b01000000) != 0; // 4. byte'ın 7. biti
            Fin1_MotorOverCurrentError = (data[3] & 0b10000000) != 0; // 4. byte'ın 8. biti


            Fin2_SolenoidError = (data[4] & 0b00000001) != 0; // 5. byte'ın 1. biti
            Fin1_SolenoidError = (data[4] & 0b00000010) != 0; // 5. byte'ın 2. biti
            SupplyVoltageError = (data[4] & 0b00000100) != 0; // 5. byte'ın 3. biti
            TemperatureSensorError = (data[4] & 0b00001000) != 0; // 5. byte'ın 4. biti
            Fin2_MotorDriverICErrorByCPLD = (data[4] & 0b00010000) != 0; // 5. byte'ın 5. biti
            Fin1_MotorDriverICErrorByCPLD = (data[4] & 0b00100000) != 0; // 5. byte'ın 6. biti
            Fin2_EncoderSupplyErrorByCPLD = (data[4] & 0b01000000) != 0; // 5. byte'ın 7. biti
            Fin1_EncoderSupplyErrorByCPLD = (data[4] & 0b10000000) != 0; // 5. byte'ın 8. biti


            Fin2_MotorTemperatureErrorByCPLD = (data[5] & 0b00000001) != 0; // 6. byte'ın 1. biti
            Fin1_MotorTemperatureErrorByCPLD = (data[5] & 0b00000010) != 0; // 6. byte'ın 2. biti
            Fin2_MotorDriverTemperatureErrorByCPLD = (data[5] & 0b00000100) != 0; // 6. byte'ın 3. biti
            Fin1_MotorDriverTemperatureErrorByCPLD = (data[5] & 0b00001000) != 0; // 6. byte'ın 4. biti
            Omkk_DspAdc_1_5VoltError = (data[5] & 0b00010000) != 0; // 6. byte'ın 5. biti
            Omkk_3_3VoltErrorByCPLD = (data[5] & 0b00100000) != 0; // 6. byte'ın 6. biti
            Omkk_5VoltErrorByCPLD = (data[5] & 0b01000000) != 0; // 6. byte'ın 7. biti
            Omkk_12VoltErrorByCPLD = (data[5] & 0b10000000) != 0; // 6. byte'ın 8. biti


            Fin1PositionFeedbackRaw = (ushort)((data[7] << 8) | data[6]); // MSB << 8 | LSB
            Fin1PositionFeedbackDeg = ConvertRawToDegrees(Fin1PositionFeedbackRaw, 25);

            Fin2PositionFeedbackRaw = (ushort)((data[9] << 8) | data[8]); // MSB << 8 | LSB
            Fin2PositionFeedbackDeg = ConvertRawToDegrees(Fin2PositionFeedbackRaw, 25);

            Fin1PositionReferenceRaw = (ushort)((data[11] << 8) | data[10]); // MSB << 8 | LSB
            Fin1PositionReferenceDeg = ConvertRawToDegrees(Fin1PositionReferenceRaw, 25);

            Fin2PositionReferenceRaw = (ushort)((data[13] << 8) | data[12]); // MSB << 8 | LSB
            Fin2PositionReferenceDeg = ConvertRawToDegrees(Fin2PositionReferenceRaw, 25);

            Fin1CurrentReferenceRaw = (ushort)((data[15] << 8) | data[14]); // MSB << 8 | LSB
            Fin1CurrentReferenceDeg = ConvertRawToDegrees(Fin1CurrentReferenceRaw, 50);

            Fin2CurrentReferenceRaw = (ushort)((data[17] << 8) | data[16]); // MSB << 8 | LSB
            Fin2CurrentReferenceDeg = ConvertRawToDegrees(Fin2CurrentReferenceRaw, 50);

            Fin1CurrentFeedbackRaw = (ushort)((data[19] << 8) | data[18]); // MSB << 8 | LSB
            Fin1CurrentFeedbackDeg = ConvertRawToDegrees(Fin1CurrentFeedbackRaw, 50);

            Fin2CurrentFeedbackRaw = (ushort)((data[21] << 8) | data[20]); // MSB << 8 | LSB
            Fin2CurrentFeedbackDeg = ConvertRawToDegrees(Fin2CurrentFeedbackRaw, 50);

            // Fin1 Applied PWM 
            //Değer Aralığı : ±100  , Byte 23 ile birleştirilir Float değer 12 bitlik veri aralığına yazılır.
            int fin1MSB = data[22] & 0x0F; // Bayt 22'nin bit 0-3
            int fin1LSB = data[23];        // Bayt 23
            int fin1RawValue = (fin1MSB << 8) | fin1LSB; // 12 bitlik değer 
            // İşaret uzatma (Fin1)
            if ((fin1RawValue & 0x800) != 0) // Eğer bit 11 (işaret biti) 1 ise
            {
                fin1RawValue |= unchecked((int)0xFFFFF000); // Üstteki 20 biti 1 yaparak 32 bit işaretli değere dönüştür
            }

            // Fin2 Applied PWM
            //Değer Aralığı : ±100 , Byte 24 ile birleştirilir Float değer 12 bitlik veri aralığına yazılır
            int fin2MSB = (data[22] & 0xF0) >> 4; // Bayt 22'nin bit 4-7
            int fin2LSB = data[24];               // Bayt 24
            int fin2RawValue = (fin2MSB << 8) | fin2LSB; // 12 bitlik değer

            // İşaret uzatma (Fin2)
            if ((fin2RawValue & 0x800) != 0) // Eğer bit 11 (işaret biti) 1 ise
            {
                fin2RawValue |= unchecked((int)0xFFFFF000); // Üstteki 20 biti 1 yaparak 32 bit işaretli değere dönüştür
            }

            // Değerleri ±100 aralığına ölçeklendir
            double fin1AppliedPWM = (fin1RawValue / 2047.0) * 100.0;
            double fin2AppliedPWM = (fin2RawValue / 2047.0) * 100.0;



            DspSoftwareVersion = (ushort)((data[26] << 8) | data[25]); // MSB << 8 | LSB
            CpldVersion = (ushort)((data[28] << 8) | data[27]); // MSB << 8 | LSB
            ExecutionTimeOfTheCurrentLoop = (ushort)((data[30] << 8) | data[29]); // MSB << 8 | LSB
            ExecutionTimeOfThePositionLoop = (ushort)((data[32] << 8) | data[31]); // MSB << 8 | LSB
            ExecutionTimeOfTheLowFrequencyTask = (ushort)((data[34] << 8) | data[33]); // MSB << 8 | LSB



            InstantBatteryVoltageRaw = (ushort)((data[36] << 8) | data[35]); // MSB << 8 | LSB
            InstantBatteryVoltage = ConvertRawToDegrees(InstantBatteryVoltageRaw, 50);

            MeanBatteryVoltageRaw = (ushort)((data[36] << 8) | data[35]); // MSB << 8 | LSB
            MeanBatteryVoltage = ConvertRawToDegrees(MeanBatteryVoltageRaw, 50);
            CardTemperature = (ushort)((data[36] << 8) | data[35]); // MSB << 8 | LSB

            isSolenoid1Open = (ushort)((data[36] << 8) | data[35]); // MSB << 8 | LSB

            isSolenoid1Open = (ushort)((data[36] << 8) | data[35]); // MSB << 8 | LSB

            TotalConsumedPower = (ushort)((data[36] << 8) | data[35]); // MSB << 8 | LSB

            SystemType = (data[37] & 0b00000001) != 0; // 37. byte'ın 1. biti
            ReceivedAutopilotMsgError = (data[37] & 0b00000010) != 0; // 37. byte'ın 2. biti
            Fin1OpenSwitchState = (data[37] & 0b00000100) != 0; // 37. byte'ın 3. biti
            Fin2OpenSwitchState = (data[37] & 0b00001000) != 0; // 37. byte'ın 4. biti
            Fin1CloseSwitchState = (data[37] & 0b00010000) != 0; // 37. byte'ın 5. biti
            Fin2CloseSwitchState = (data[37] & 0b00100000) != 0; // 37. byte'ın 6. biti
            MotorDriveMethod = (data[37] & 0b01000000) != 0; // 37. byte'ın 7. biti
            ReservedBits = (data[37] & 0b10000000) != 0; // 37. byte'ın 8. biti

            counter = data[38];
            // Motor durumlarını güncelle veya göster
            /*Invoke(new Action(() =>
            {
                string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");
                // GUI elemanlarınızı burada güncelleyin
                listViewMessages.Items.Add(new ListViewItem(new[] {
                $"Motor 1 Enabled: {motor1Enabled}"+
                $"Motor 2 Enabled: {motor2Enabled}"+
                $"Motor Hall State: {motorHallState}",timeStamp }));
                listViewMessages.EnsureVisible(listViewMessages.Items.Count - 1);

            }));*/
        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                int bytesToRead = serialport.BytesToRead;
                byte[] incomingData = new byte[bytesToRead];
                serialport.Read(incomingData, 0, bytesToRead);


                foreach (byte b in incomingData)
                {
                    if (receivedDataBuffer.Count == 0)
                    {
                        // Başlık baytını bekliyoruz
                        if (b == headerByte)
                        {
                            receivedDataBuffer.Add(b);

                            // Zamanlayıcıyı başlat
                            dataReceiveTimer.Stop();
                            dataReceiveTimer.Start();
                        }
                        // Başlık baytı değilse yok say
                    }
                    else
                    {
                        // Mesaj toplamaya devam ediyoruz
                        receivedDataBuffer.Add(b);

                        // Zamanlayıcıyı sıfırla
                        dataReceiveTimer.Stop();
                        dataReceiveTimer.Start();

                        if (receivedDataBuffer.Count == messageLength)
                        {
                            // Mesaj tamamlandı
                            dataReceiveTimer.Stop();

                            // Checksum kontrolü yap
                            if (ValidateChecksum(receivedDataBuffer.ToArray()))
                            {
                                if ((receivedDataBuffer.Count > 0) && (receivedDataBuffer[0] == headerByte))
                                {
                                    ProcessMotorControls(receivedDataBuffer.ToArray());


                                    // Mesajı ListView'e ekle
                                    Invoke(new Action(() =>
                                    {
                                        string messageHex = BitConverter.ToString(receivedDataBuffer.ToArray()).Replace("-", " ");
                                        string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");

                                        ListViewItem item = new ListViewItem(new[] { messageHex, timeStamp });
                                        listViewMessages.Items.Add(item);
                                        listViewMessages.EnsureVisible(listViewMessages.Items.Count - 1);

                                    }));
                                }
                                else
                                    // Checksum hatası
                                    Invoke(new Action(() =>
                                    {
                                        MessageBox.Show("Checksum hatası!");
                                    }));
                            }
                            else
                            {
                                // Checksum hatası
                                Invoke(new Action(() =>
                                {
                                    MessageBox.Show("Checksum hatası!");
                                }));
                            }

                            // Buffer'ı temizle
                            receivedDataBuffer.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message);
                }));
            }

        }

        private void SendText_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialport.IsOpen)
                {
                    string dataToSend = textBoxSendData.Text;


                    serialport.Write(fullMessage, 0, fullMessage.Count());

                    textBoxSendData.Clear();
                }
                else
                {
                    MessageBox.Show("Önce seri portu açın.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri gönderilirken hata oluştu: " + ex.Message);
            }
        }

        private void GenerateAndDisplayData()
        {
            byte header = 0x1D; // Örnek bir başlık değeri (istediğiniz bir değer olabilir)
            byte[] dataBytes = new byte[38];
            byte checksum;

            // 38 baytlık rastgele veri oluşturma
            Random rnd = new Random();
            rnd.NextBytes(dataBytes);

            // Checksum hesaplama (header ve dataBytes toplamı & 0xFF)
            int sum = header;
            foreach (byte b in dataBytes)
            {
                sum += b;
            }
            checksum = (byte)(sum & 0xFF);

            // Tüm mesajı birleştirme

            fullMessage[0] = header;
            Array.Copy(dataBytes, 0, fullMessage, 1, dataBytes.Length);
            fullMessage[39] = checksum;


            // Mesajı görüntülemek için hex string'e çevirme
            string hexString = BitConverter.ToString(fullMessage).Replace("-", " ");
            textBoxSendData.Text = hexString;
        }

        private void SelectedProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedProtocol.SelectedItem.ToString() == "1")
            {
                GenerateAndDisplayData();
            }
            else if (SelectedProtocol.SelectedItem.ToString() == "2")
            {
                GenerateAndDisplayRandomPacket(); // Rastgele veri oluşturup USB'ye gönderilecek şekilde sendbox'a yazdır
            }
            else
            {
                MessageBox.Show("Geçersiz protokol seçildi.");
            }
            
        }
    
       

        ////// PROTOKOL2 //////////
        private void GetAvailablePorts2()
        {
            comboBoxPorts2.Items.Clear(); // Mevcut öğeleri temizle
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBoxPorts2.Items.Add(port); // Portları ekle
            }

            if (comboBoxPorts2.Items.Count > 0)
            {
                comboBoxPorts2.SelectedIndex = 0; // İlk portu seç
            }
            else
            {
                MessageBox.Show("Hiçbir port bulunamadı.");
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialport2.IsOpen)
            {
                serialport.Close();
            }
        }
        private void buttonOpenPort_Click2(object sender, EventArgs e)
        {
            try
            {
                // Eğer aynı port 1. SerialPort'ta açıksa, önce o portu kapat
                if (serialport.IsOpen && serialport.PortName == comboBoxPorts2.SelectedItem.ToString())
                {
                    serialport.Close();
                    buttonOpenPort.Text = "Portu Aç";
                }

                if (serialport2.IsOpen)
                {
                    serialport2.Close();
                    buttonOpenPort2.Text = "Portu Aç";
                }
                else
                {
                    serialport2.PortName = comboBoxPorts2.SelectedItem.ToString();
                    serialport2.BaudRate = 2187500;
                    serialport2.Parity = Parity.None;
                    serialport2.StopBits = StopBits.One;
                    serialport2.DataBits = 8;
                    serialport2.Handshake = Handshake.None;
                    serialport2.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
                    serialport2.Open();
                    buttonOpenPort2.Text = "Portu Kapat";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        // Veri alındığında çağrılır
        public void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Gelen veri miktarını oku
                int bytesToRead = serialport.BytesToRead;
                byte[] incomingData = new byte[bytesToRead];
                serialport.Read(incomingData, 0, bytesToRead);

                // Gelen veriyi işleyelim
                foreach (byte b in incomingData)
                {
                    // Eğer buffer boşsa, başlık baytını bekliyoruz
                    if (receivedDataBuffer.Count == 0)
                    {
                        if (b == headerByteD5)  // Başlık doğruysa veriyi toplamaya başla
                        {
                            receivedDataBuffer.Add(b);
                        }
                    }
                    else
                    {
                        // Mesajın geri kalanını toplamaya devam ediyoruz
                        receivedDataBuffer.Add(b);

                        // Mesajın tamamını aldık mı?
                        if (receivedDataBuffer.Count == 21)  // Mesajın beklenen uzunluğu (21 byte)
                        {
                            // CheckSum kontrolü (son 1 bayt checksum olduğu için hariç tutulur)
                            if (ValidateChecksum2(receivedDataBuffer.ToArray()))
                            {
                                // Paket geçerli, burada paket işleme kodları
                                // Veriyi ListView'e ekle
                                Invoke(new Action(() =>
                                {
                                    string dataHex = BitConverter.ToString(receivedDataBuffer.ToArray()).Replace("-", " ");
                                    string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");
                                    ListViewItem item = new ListViewItem(new[] { dataHex, timeStamp });
                                    listViewMessages.Items.Add(item);
                                    listViewMessages.EnsureVisible(listViewMessages.Items.Count - 1);
                                }));
                            }
                            else
                            {
                                // Checksum hatası
                                Invoke(new Action(() =>
                                {
                                    string dataHex = BitConverter.ToString(receivedDataBuffer.ToArray()).Replace("-", " ");
                                    textBoxCrcResults2.AppendText($"CheckSum Hatası! Alınan Veri: {dataHex}\r\n");
                                }));
                            }

                            // Mesajı işledikten sonra buffer'ı temizle
                            receivedDataBuffer.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Hata durumunda mesaj göster
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message);
                }));
            }
        }





        private void SendText_Click2(object sender, EventArgs e)
        {
            try
            {
                if (serialport2.IsOpen)
                {
                    // textBoxSendData'dan veriyi alıp seri port üzerinden gönder
                    string dataToSend = textBoxSendData2.Text;

                    // Boş veya geçersiz veri kontrolü
                    if (string.IsNullOrWhiteSpace(dataToSend))
                    {
                        MessageBox.Show("Gönderilecek veri boş olamaz.");
                        return;
                    }

                    // Veriyi byte dizisine dönüştürme (her byte'ı hex string olarak göndermek)
                    byte[] dataBytes = dataToSend
                        .Split(' ')  // Hex değerler boşlukla ayrıldığı için böl
                        .Where(hex => !string.IsNullOrWhiteSpace(hex)) // Boş parçaları çıkar
                        .Select(hex => Convert.ToByte(hex, 16)) // Her hex string'i byte'a çevir
                        .ToArray();

                    // CheckSum hesapla (CRC kaldırıldı, sadece CheckSum ile devam ediyoruz)
                    byte checkSum = (byte)(dataBytes.Sum(b => b) & 0xFF); // Toplamı alıp & 0xFF yapıyoruz

                    // CheckSum'u byte dizisine ekle
                    byte[] packetWithCheckSum = dataBytes.Concat(new byte[] { checkSum }).ToArray(); // CheckSum ekle

                    // Gönderilen veriyi ve hesaplanan CheckSum'u logla
                    string dataHex = BitConverter.ToString(packetWithCheckSum).Replace("-", " ");
                    Invoke(new Action(() =>
                    {
                        textBoxCrcResults2.AppendText($"Gönderilen Veri: {dataHex}\r\n");
                        textBoxCrcResults2.AppendText($" Gönderilen CheckSum Hesaplaması için veri: {BitConverter.ToString(dataBytes).Replace("-", " ")}\r\n");
                        textBoxCrcResults2.AppendText($"Gönderilen Hesaplanan CheckSum: {checkSum:X2}\r\n");
                    }));

                    // Veriyi seri port üzerinden gönder
                    serialport2.Write(packetWithCheckSum, 0, packetWithCheckSum.Length); // CheckSum eklenmiş veriyi gönder

                    textBoxSendData2.Clear(); // Gönderilen veriyi temizle
                }
                else
                {
                    MessageBox.Show("Önce seri portu açın.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri gönderilirken hata oluştu: {ex.Message}");
            }
        }

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>
        {
            Header1,
            (byte)((ReservedMessageNumberCommand & 0x0F) | (SystemAnalysisMotorNo << 4) | (IsCurrentControllerChangeCommandValid << 6) | (IsPosControllerChangeCommandValid << 7)),
            (byte)((DriveModeCommand & 0x03) | (IsFin1MotorEnableCommandActivated << 2) | (IsFin2MotorEnableCommandActivated << 3) | (IsSolenoid1OpenCommandActivated << 4) | (IsSolenoid2OpenCommandActivated << 5) | (SystemAnalysisModeCommand << 6))
        };

            // SystemAnalysisModeCommand'e göre veri ekleme
            if (SystemAnalysisModeCommand == 0)
            {
                byteList.AddRange(BitConverter.GetBytes(SentFin1Command));
                byteList.AddRange(BitConverter.GetBytes(SentFin2Command));
            }
            else if (SystemAnalysisModeCommand == 2)
            {
                byteList.AddRange(BitConverter.GetBytes(PosSysAnalysisStartFrequencyCommand));
                byteList.AddRange(BitConverter.GetBytes(PosSysAnalysisFinishFrequencyCommand));
                byteList.AddRange(BitConverter.GetBytes(PosSysAnalysisStartAmplitudeCommand));
                byteList.AddRange(BitConverter.GetBytes(PosSysAnalysisFinishAmplitudeCommand));
                byteList.AddRange(BitConverter.GetBytes(PosSysAnalysisTestDurationCommand));
            }

            // Ek değişkenler
            if (IsCurrentControllerChangeCommandValid == 1)
            {
                byteList.AddRange(BitConverter.GetBytes(CurrentControlPrm_R));
                byteList.AddRange(BitConverter.GetBytes(CurrentControlPrm_L));
                byteList.AddRange(BitConverter.GetBytes(CurrentControlPrm_BW));
            }
            else if (IsPosControllerChangeCommandValid == 1)
            {
                byteList.AddRange(BitConverter.GetBytes(PositionControlPrm_Kp));
                byteList.AddRange(BitConverter.GetBytes(PositionControlPrm_Ki));
                byteList.AddRange(BitConverter.GetBytes(PositionControlPrm_Kd));
            }

            // Header2 ekle
            byteList.Add(Header2);

            // Checksum hesapla
            CheckSum = (byte)(byteList.Sum(b => b) & 0xFF);
            byteList.Add(CheckSum);

            return byteList.ToArray();
        }
        private void GenerateAndDisplayRandomPacket()
        {
            // Rastgele paket oluşturma
            byte[] randomPacket = CreateRandomPacket();

            // Oluşturulan rastgele veriyi hex string'e çevirme
            string hexString = BitConverter.ToString(randomPacket).Replace("-", " ");

            // Rastgele veriyi sendbox'a yazdırma
            textBoxSendData.Text = hexString; // Rastgele veriyi USB'ye göndermek için ekrana yazdır
        }
    
        // Rastgele paket oluşturan fonksiyon
        public byte[] CreateRandomPacket()
        {
            Random random = new Random();
            List<byte> byteList = new List<byte>();

            // 0. Bayt: Başlık (0xD5)
            byteList.Add(0xD5);

            // 1. Bayt: ReservedMessageNumberCommand (0-3), SystemAnalysisMotorNo (4-5), IsCurrentControllerChangeCommandValid (6), IsPosControllerChangeCommandValid (7)
            byte reservedMessageNumber = (byte)(random.Next(0, 16)); // 0-15
            byte systemAnalysisMotorNo = (byte)(random.Next(0, 4)); // 0-3
            byte isCurrentControllerChangeValid = (byte)(random.Next(0, 2)); // 0 veya 1
            byte isPosControllerChangeValid = (byte)(random.Next(0, 2)); // 0 veya 1

            // Ensure they are not both 1
            if (isCurrentControllerChangeValid == 1)
            {
                isPosControllerChangeValid = 0;
            }
            if(isCurrentControllerChangeValid == 0)
            {
                isPosControllerChangeValid = 1;
            }

            byte byte1 = (byte)(reservedMessageNumber | (systemAnalysisMotorNo << 4) | (isCurrentControllerChangeValid << 6) | (isPosControllerChangeValid << 7));
            byteList.Add(byte1);

            // 2. Bayt: DriveModeCommand (0-1), IsFin1MotorEnableCommandActivated (2), IsFin2MotorEnableCommandActivated (3), IsSolenoid1OpenCommandActivated (4), IsSolenoid2OpenCommandActivated (5), SystemAnalysisModeCommand (6-7)
            byte driveModeCommand = (byte)(random.Next(0, 4)); // 0-3
            byte isFin1MotorEnabled = (byte)(random.Next(0, 2)); // 0 veya 1
            byte isFin2MotorEnabled = (byte)(random.Next(0, 2)); // 0 veya 1
            byte isSolenoid1Open = (byte)(random.Next(0, 2)); // 0 veya 1
            byte isSolenoid2Open = (byte)(random.Next(0, 2)); // 0 veya 1
            byte systemAnalysisMode = (byte)(random.Next(0, 3)); // 0-2

            byte byte2 = (byte)(driveModeCommand | (isFin1MotorEnabled << 2) | (isFin2MotorEnabled << 3) | (isSolenoid1Open << 4) | (isSolenoid2Open << 5) | (systemAnalysisMode << 6));
            byteList.Add(byte2);

            // 3. - 12. Baytlar: SystemAnalysisModeCommand'e göre farklı veri ekleme
            if (systemAnalysisMode == 0) // None
            {
                // SystemAnalysisModeCommand == 0: SentFin1Command ve SentFin2Command (sadece ilk 4 bayt kullan)
                byteList.Add((byte)(random.Next(0, 256)));  // SentFin1Command_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // SentFin1Command_Byte1
                byteList.Add((byte)(random.Next(0, 256)));  // SentFin1Command_Byte2
                byteList.Add((byte)(random.Next(0, 256)));  // SentFin1Command_MSB

                byteList.Add((byte)(random.Next(0, 256)));  // SentFin2Command_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // SentFin2Command_Byte1
                byteList.Add((byte)(random.Next(0, 256)));  // SentFin2Command_Byte2
                byteList.Add((byte)(random.Next(0, 256)));  // SentFin2Command_MSB
                byteList.Add(0x00);
                byteList.Add(0x00);
            }
            else if(systemAnalysisMode == 1)
            {
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartFrequencyCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartFrequencyCommand_MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishFrequencyCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishFrequencyCommand_MSB

                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartAmplitudeCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartAmplitudeCommand_MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishAmplitudeCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishAmplitudeCommand_MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisTestDurationCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisTestDurationCommand_MSB
            }
            else if (systemAnalysisMode == 2) // Position2Position
            {
                // SystemAnalysisModeCommand == 2: Pozisyon analiz parametreleri
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartFrequencyCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartFrequencyCommand_MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishFrequencyCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishFrequencyCommand_MSB

                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartAmplitudeCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisStartAmplitudeCommand_MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishAmplitudeCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisFinishAmplitudeCommand_MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisTestDurationCommand_LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PosSysAnalysisTestDurationCommand_MSB
            }
          

            // 13. - 18. Baytlar: IsCurrentControllerChangeCommandValid ve IsPosControllerChangeCommandValid'e göre veri ekleme
            if (isCurrentControllerChangeValid == 1) // IsCurrentControllerChangeCommandValid == 1
            {
                byteList.Add((byte)(random.Next(0, 256)));  // CurrentControlPrm_R LSB
                byteList.Add((byte)(random.Next(0, 256)));  // CurrentControlPrm_R MSB
                byteList.Add((byte)(random.Next(0, 256)));  // CurrentControlPrm_L LSB
                byteList.Add((byte)(random.Next(0, 256)));  // CurrentControlPrm_L MSB
                byteList.Add((byte)(random.Next(0, 256)));  // CurrentControlPrm_BW LSB
                byteList.Add((byte)(random.Next(0, 256)));  // CurrentControlPrm_BW MSB
            }
            else if (isPosControllerChangeValid == 1) // IsPosControllerChangeCommandValid == 1
            {
                byteList.Add((byte)(random.Next(0, 256)));  // PositionControlPrm_Kp LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PositionControlPrm_Kp MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PositionControlPrm_Ki LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PositionControlPrm_Ki MSB
                byteList.Add((byte)(random.Next(0, 256)));  // PositionControlPrm_Kd LSB
                byteList.Add((byte)(random.Next(0, 256)));  // PositionControlPrm_Kd MSB
            }

           

            // 19. Bayt: Sabit header (0x3A)
            byteList.Add(0x3A);

            // CheckSum hesapla (tüm baytların toplamı & 0xFF)
            byte checkSum = (byte)(byteList.Sum(b => b) & 0xFF);
            byteList.Add(checkSum);

            // Sonuç olarak 20 baytlık veri döndürülür (CRC eklenmeyecek)
            return byteList.ToArray();
        }


        private bool ValidateChecksum2(byte[] message)
        {
            if (message.Length != messageLenght2)
                return false;

            // Checksum hesaplaması (son bayt checksum olduğu için dahil etmiyoruz)
            int sum = 0;
            for (int i = 0; i < message.Length - 1; i++)
            {
                sum += message[i];
            }
            byte calculatedChecksum = (byte)(sum & 0xFF);

            // Mesajın son baytı alınan checksum
            byte receivedChecksum = message[message.Length - 1];

            return calculatedChecksum == receivedChecksum;
        }



        // Rastgele veri üretilip gösterme işlemi
        private void SelectedProtocol_SelectedIndexChanged2(object sender, EventArgs e)
        {
           
             if (SelectedProtocol2.SelectedItem.ToString() == "2")
            {
                GenerateAndDisplayRandomPacket(); // Rastgele veri oluşturup USB'ye gönderilecek şekilde sendbox'a yazdır
            }
            else
            {
                MessageBox.Show("Geçersiz protokol seçildi.");
            }
        }


        public void SendRandomPacket()
        {
            if (serialport2.IsOpen)
            {
                byte[] packet = CreateRandomPacket();
                serialport2.Write(packet, 0, packet.Length);
                MessageBox.Show("Rastgele veri gönderildi.");
            }
            else
            {
                MessageBox.Show("Lütfen seri portu açın.");
            }
        }

       
    }
}
