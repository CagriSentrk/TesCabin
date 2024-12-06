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
using System.IO;
using OfficeOpenXml;
using System.Drawing.Drawing2D;
// Kaldırılacak olan import
using System.Windows.Forms.VisualStyles;
using System.Diagnostics;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private DatabaseHelper dbHelper = new DatabaseHelper();
        bool isMotor1Enabled; // 2. byte'ın 1. biti
        bool isMotor2Enabled; // 2. byte'ın 2. biti
        bool isFin1Opened; // 2. byte'ın 3. biti
        bool isFin2Opened; // 2. byte'ın 4. biti
        uint ReservedMessageNoStatus; // 2. byte'ın 4-7. biti
        string portInfo;


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
        bool isSolenoid1Open;
        bool isSolenoid2Open;
        double TotalConsumedPower;
        float Motor1Currents3PhasesA;
        float Motor1Currents3PhasesB;
        float Motor1Currents3PhasesC;
        float Motor2Currents3PhasesA;
        float Motor2Currents3PhasesB;
        float Motor2Currents3PhasesC;
        float BackEMFVoltage3PhaseMotor1A;
        float BackEMFVoltage3PhaseMotor1B;
        float BackEMFVoltage3PhaseMotor1C;
        float Motor1Currents3PhasesA_Status3;
        float Motor1Currents3PhasesB_Status3;
        float Motor1Currents3PhasesC_Status3;
        float BackEMFVoltage3PhaseMotor2A;
        float BackEMFVoltage3PhaseMotor2B;
        float BackEMFVoltage3PhaseMotor2C;
        float Motor2Currents3PhasesA_Status4;
        float Motor2Currents3PhasesB_Status4;
        float Motor2Currents3PhasesC_Status4;
        bool isPos2PosSysAnalysisActivated;
        float TachometerMotor1;
        float TachometerMotor2;
        float LoopCommandMotor1;
        float LoopCommandMotor2;
        public float CurrentControlPrm_R_40;
        public float CurrentControlPrm_L_40;
        public float CurrentControlPrm_BW_40;
        public float PositionControlPrm_Kp_40;
        public float PositionControlPrm_Ki_40;
        public float PositionControlPrm_Kd_40;
        float InstantFrequency;
        ushort TimePassed;
        ushort SystemAnalysisMotorId; // 40 bbyte protokolde
        float StartFrequency;
        float FinishFrequency;
        bool isCurrent2CurrentSysAnalysisActivated;
        float SfraMagnitudeVectorDb;
        float SfraPhaseVectorDeg;
        float SfraFrequencyVectorHz;
        short SfraObj_FreqIndex;
        ushort TipToMdcMessage_SystemAnalysisMotorNo;
        bool SystemType; // 37. byte'ın 1. biti
        bool ReceivedAutopilotMsgError; // 37. byte'ın 2. biti
        bool Fin1OpenSwitchState; // 37. byte'ın 3. biti
        bool Fin2OpenSwitchState; // 37. byte'ın 4. biti
        bool Fin1CloseSwitchState; // 37. byte'ın 5. biti
        bool Fin2CloseSwitchState; // 37. byte'ın 6. biti
        bool MotorDriveMethod; // 37. byte'ın 7. biti
        bool ReservedBits; // 37. byte'ın 8. biti
        int counter;
        private bool isProcessing = false;
        private bool isProcessing2 = false;
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
        private List<DataGridViewRow> allRows = new List<DataGridViewRow>(); // Tüm satırları saklamak için liste
        private int pageSize = 5; // Her sayfada kaç veri gösterilecek
        private int currentPage = 1; // Şu anki sayfa numarası


        private string role;
        private SerialPort serialport = new SerialPort();
        private SerialPort serialport2 = new SerialPort();
        private SerialPort serialport3 = new SerialPort();

        private List<byte> receivedDataBuffer = new List<byte>();
        private List<byte> receivedDataBuffer2 = new List<byte>();
        private List<byte> receivedDataBufferControl = new List<byte>();
        private List<byte> receivedDataBufferControl2 = new List<byte>();
        private System.Timers.Timer dataReceiveTimer;
        private const int messageLength = 40;
        private const int messageLenght2 = 20;// Mesaj uzunluğu
        private const byte headerByte = 0x1D; // Mesajın başlangıç baytı
        private const byte headerByteD5 = 0xD5; // Mesajın başlangıç baytı
        byte[] fullMessage = new byte[4000];
        byte[] fullMessage3 = new byte[4000];
        byte[] fullMessage2 = new byte[21];

        public Form1(string role)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            this.role = role;
            InitializeComponent();
            GetAvailablePorts();
            GetAvailablePorts2();
            GetAvailablePorts3();


            sendTimer.Enabled = false;
            sendTimer2.Enabled = false;
            // Zamanlayıcıyı ayarlayalım
            dataReceiveTimer = new System.Timers.Timer(100); // 10 ms
            dataReceiveTimer.AutoReset = false;
            dataReceiveTimer.Elapsed += DataReceiveTimer_Elapsed;

            // TrackBar ayarları
            angleTrackBar.Minimum = -15;
            angleTrackBar.Maximum = 15;
            angleTrackBar.ValueChanged += angleTrackBar_ValueChanged;
            angleTrackBar2.ValueChanged += angleTrackBar2_ValueChanged;

            // TrackBar'ların dikey yapılması
            angleTrackBar.Orientation = Orientation.Vertical;
            angleTrackBar2.Orientation = Orientation.Vertical;

            var databaseHelper = new DatabaseHelper();
            databaseHelper.DisplayErrorsFromDatabase(errortablelayout);
        }


        private void DataReceiveTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // 10 ms geçti, buffer'ı temizleyip hata mesajı gösteriyoruz
            receivedDataBuffer.Clear();
            receivedDataBuffer2.Clear();

            Invoke(new Action(() =>
            {
                MessageBox.Show("10 ms'lik kesinti tespit edildi!");
            }));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dashboard.Visible = true;  // Başlangıç paneli açık
            ErrorPanel.Visible = false; // Hatalar paneli gizli

            // dataGridView1'e başlıklar ekleyelim
            dataGridView1.ColumnCount = 2; // 2 sütun var
            dataGridView1.Columns[0].Name = "Mesaj";
            dataGridView1.Columns[1].Name = "Zaman";

            // DataGridView başlıklarının stilini ayarlama
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30);
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 45);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.angleTrackBar.ValueChanged += (s, args) => gaugePictureBox.Invalidate();
            this.angleTrackBar2.ValueChanged += (s, args) => gaugePictureBox2.Invalidate();
            this.angleTrackBar3.ValueChanged += (s, args) => gaugePictureBox3.Invalidate();
            this.angleTrackBar4.ValueChanged += (s, args) => gaugePictureBox4.Invalidate();
            this.gaugePictureBox.Paint += (s, args) => gaugePictureBox_Paint(s, args, angleTrackBar);
            this.gaugePictureBox2.Paint += (s, args) => gaugePictureBox_Paint(s, args, angleTrackBar2);
            this.gaugePictureBox3.Paint += (s, args) => gaugePictureBox_Paint(s, args, angleTrackBar3);
            this.gaugePictureBox4.Paint += (s, args) => gaugePictureBox_Paint(s, args, angleTrackBar4);

            this.errortablelayout.Controls.Add(new Label()
            {
                Text = "MOTOR - 1",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                ForeColor = Color.White, // Beyaz yazı rengi
                BackColor = Color.FromArgb(64, 79, 86), // Koyu gri tonlarında arka plan
                Dock = DockStyle.Fill,
                Margin = new Padding(0), // Kenar boşluklarını sıfırlayın
                Padding = new Padding(0) // İç boşlukları sıfırlayın
            }, 0, 0);

            this.errortablelayout.Controls.Add(new Label()
            {
                Text = "MOTOR - 2",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(64, 79, 86),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Padding = new Padding(0)
            }, 1, 0);

            this.errortablelayout.Controls.Add(new Label()
            {
                Text = "MOTOR - 3",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(64, 79, 86),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Padding = new Padding(0)
            }, 2, 0);

            this.errortablelayout.Controls.Add(new Label()
            {
                Text = "MOTOR - 4",
                TextAlign = System.Drawing.ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Color.FromArgb(64, 79, 86),
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                Padding = new Padding(0)
            }, 3, 0);





        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialport.IsOpen)
            {
                serialport.Close();

            }
            if (serialport2.IsOpen)
            {
                serialport2.Close();

            }
            if (serialport3.IsOpen)
            {
                serialport3.Close();

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
                portInfo = comboBoxPorts.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Hiçbir port bulunamadı.");
            }
        }
        private void GetAvailablePorts3()
        {
            comboBoxPorts3.Items.Clear(); // Mevcut öğeleri temizle
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBoxPorts3.Items.Add(port); // Portları ekle
            }

            if (comboBoxPorts3.Items.Count > 0)
            {
                comboBoxPorts3.SelectedIndex = 0; // İlk portu seç
                portInfo = comboBoxPorts3.SelectedItem.ToString();
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
                    if (serialport.IsOpen)
                    {
                        // Veri işleme ve gönderme işlemlerini durdur
                        isProcessing = false;
                        sendTimer.Stop();
                        isSending = false;

                        // DataReceived olayını kaldır
                        serialport.DataReceived -= CombinedDataReceivedHandler;

                        // Portu kapatmadan önce tamponları temizle
                        serialport.DiscardInBuffer();
                        serialport.DiscardOutBuffer();

                        // Portu kapat
                        Task.Run(() =>
                        {
                            try
                            {
                                serialport.Close();
                            }
                            catch (Exception ex)
                            {
                                Invoke(new Action(() =>
                                {
                                    MessageBox.Show($"Port kapatılırken hata oluştu: {ex.Message}");
                                }));
                            }
                        });

                        buttonOpenPort.Text = "Portu Aç";
                    }
                    else
                    {
                        // Seri portu aç
                        serialport.PortName = comboBoxPorts.SelectedItem.ToString();
                        serialport.BaudRate = 2187500;
                        serialport.Parity = Parity.None;
                        serialport.StopBits = StopBits.One;
                        serialport.DataBits = 8;
                        serialport.Handshake = Handshake.None;
                        serialport.ReadBufferSize = 20000;

                        // Veri işleme bayrağını etkinleştir
                        isProcessing = true;

                        serialport.DataReceived += CombinedDataReceivedHandler;
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


        private void buttonOpenPort_Click3(object sender, EventArgs e)
        {
            if (role == "admin")
            {

                try
                {
                    // Eğer aynı port 2. SerialPort'ta açıksa, önce o portu kapat
                    //if (serialport2.IsOpen && serialport2.PortName == comboBoxPorts.SelectedItem.ToString())
                    //{
                    //    serialport2.Close();
                    //    buttonOpenPort2.Text = "Portu Aç";
                    //}

                    if (serialport3.IsOpen)
                    {
                        sendTimer2.Stop();
                        isSending2 = false;
                        // Portu kapatmadan önce olay işleyicisini kaldır ve tampon belleği temizle
                        serialport3.DataReceived -= CombinedDataReceivedHandler2;
                        serialport3.DiscardInBuffer();
                        serialport3.DiscardOutBuffer();

                        Task.Run(() =>
                        {
                            try
                            {
                                serialport3.Close();
                            }
                            catch (Exception ex)
                            {
                                Invoke(new Action(() =>
                                {
                                    MessageBox.Show($"Port kapatılırken hata oluştu: {ex.Message}");
                                }));
                            }
                        }); 

                        buttonOpenPort3.Text = "Portu Aç";
                    }
                    else
                    {

                        serialport3.PortName = comboBoxPorts3.SelectedItem.ToString();
                        serialport3.BaudRate = 2187500;
                        serialport3.Parity = Parity.None;
                        serialport3.StopBits = StopBits.One;
                        serialport3.DataBits = 8;
                        serialport3.Handshake = Handshake.None;
                        serialport3.ReadBufferSize = 20000;

                        serialport3.DataReceived += new SerialDataReceivedEventHandler(CombinedDataReceivedHandler2);
                        serialport3.Open();
                        buttonOpenPort3.Text = "Portu Kapat";
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



        //8000 byte'lık paket halinde gönder.(ortalama) Eğer 21 byte'ın katıysa 21 21 bölerek işlem yapsın. 40 byte'ın katıysa 40 40 bölerek yapsın.

        private Queue<byte[]> processedPackets21 = new Queue<byte[]>(); // 21 byte'lık protokol paketleri için
        private Queue<byte[]> processedPackets40 = new Queue<byte[]>(); // 40 byte'lık protokol paketleri için
        private System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
        int bytesToRead;
        int bytesToRead2;

        int result = 0;
        int littledata = 0;
        public void CombinedDataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (!isProcessing) return;

            try
            {

                bytesToRead = serialport.BytesToRead; //sayımız

                // Hassas zaman ölçümü için Stopwatch kullanımı

                if (bytesToRead > 0)
                {
                    byte[] incomingData = new byte[bytesToRead];

                    serialport.Read(incomingData, 0, bytesToRead);

                    receivedDataBufferControl.AddRange(incomingData);
                    Array.Clear(incomingData, 0, incomingData.Length);

                    if (receivedDataBufferControl.Count > 60000)
                    {
                        receivedDataBufferControl.Clear();
                    }
                    if (bytesToRead < 40)
                    {

                        littledata = 1;
                    }
                    else
                    {
                        littledata = 0;
                    }

                    stopwatch.Stop();



                    if (result == 0 && littledata == 0)
                    {
                        //  stopwatch = System.Diagnostics.Stopwatch.StartNew();
                        result = 1;
                        lock (receivedDataBuffer)
                        {
                            receivedDataBuffer.AddRange(receivedDataBufferControl);
                            receivedDataBufferControl.Clear();

                        }

                        ProcessBuffer();
                        lock (receivedDataBuffer)
                        {
                            receivedDataBuffer.Clear();

                        }
                        result = 0;

                    }
                    // Veri okuma işlemi

                    // double elapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds; // Milisaniye
                    // double elapsedMicroseconds = stopwatch.Elapsed.TotalMilliseconds * 1000; // Mikrosaniye


                    // string message = $"b: {bytesToRead}\n" +
                    //                  $"Tm: {elapsedMicroseconds} µs\n";
                    //Invoke(new Action(() =>
                    // {

                    //     timetextbox.Text = message;
                    // }));
                }

            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message + " " + receivedDataBuffer.Count);
                }));
            }
        }
        private void ProcessBuffer()
        {
            lock (receivedDataBuffer)
            {



                for (int i = 0; i < receivedDataBuffer.Count; i++)
                {

                    if (receivedDataBuffer[i] == 0x1D)
                    {





                        if (i + 40 <= receivedDataBuffer.Count)
                        {
                            byte[] packet40 = receivedDataBuffer.Skip(i).Take(40).ToArray();
                            ProcessProtocol40(packet40);
                        }


                        // İşlenen paketi sıraya koy
                        // processedPackets40.Enqueue(packet40);


                        // İşlenen bayt sayısını artır


                        i += 39;


                        //if (i >= 3958)
                        //{

                        //}


                    }


                }




            }

            // İşlem sırasındaki protokolleri ayır
            //ProcessPackets();
        }
        private void ProcessProtocol40(byte[] packet)
        {
            try
            {
                if (ValidateChecksum(packet))
                {
                    //Invoke(new Action(() =>
                    //{
                    //    string messageHex = BitConverter.ToString(packet).Replace("-", " ");
                    //    string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");

                    //    // Protokol 1 için DataGridView'e veri ekleyelim
                    //    dataGridView1.Rows.Add(messageHex, timeStamp);

                    //    if (dataGridView1.Rows.Count > 0)
                    //    {
                    //        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    //    }
                    //}));

                    ProcessMotorControls(packet);
                }
                else
                {

                    //Invoke(new Action(() =>
                    //{
                    //    mesajtext.Text = "cserror";

                    //    //MessageBox.Show("40 byte Checksum hatası!");
                    //}));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    //MessageBox.Show("40 byte protokol işleminde hata oluştu: " + ex.Message);
                }));
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

            // Checksum hesaplama: (0x100 - toplam) & 0xFF
            byte calculatedChecksum = (byte)((0x100 - (sum & 0xFF)) & 0xFF);

            // Mesajın son baytı (message[message.Length - 1]) alınan checksum
            byte receivedChecksum = message[message.Length - 1];

            // Checksum doğrulama
            return calculatedChecksum == receivedChecksum;
        }
        int updatecounter = 0;
        int dbcounter = 0;
        private void ProcessMotorControls(byte[] data)
        {
            updatecounter++;
            dbcounter++;
            if (data.Length < 3) return; // En az 3 byte olmalı

            // 2. byte'ın bitlerini kontrol et
            isMotor1Enabled = (data[1] & 0b00000001) != 0; // 2. byte'ın 1. biti
            isMotor2Enabled = (data[1] & 0b00000010) != 0; // 2. byte'ın 2. biti
            isFin1Opened = (data[1] & 0b00000100) != 0; // 2. byte'ın 3. biti
            isFin2Opened = (data[1] & 0b00001000) != 0; // 2. byte'ın 4. biti
            ReservedMessageNoStatus = (uint)((data[1] & 0b11110000) >> 4);// 2. byte'ın 4-7. bitlerini al ve 4 bit sağa kaydırarak değeri belirle
            ReservedMessageNoStatus = 1;
            // 2. byte'ın 4-7. biti

            // 3. byte'ın bitlerini kontrol et
            Fin1MotorHallState = (data[2] & 0b00000111); // 3. byte'ın 0-2. 3 biti
            Fin2MotorHallState = (data[2] & 0b00111000); // 3. byte'ın 3-5. 3 biti
            ActualDriveMode = (data[2] & 0b11000000); // 3. byte'ın 6-7. 2 biti
             
            Fin2_HallSensorSUpplyError = (data[3] & 0b00000001) != 0; // 4. byte'ın 1. biti                        
            Fin1_HallSensorSUpplyError = (data[3] & 0b00000010) != 0; // 4. byte'ın 2. biti                             <<<<<hata1

            Fin2_HallSensorStateError = (data[3] & 0b00000100) != 0; // 4. byte'ın 3. biti                             <<<<<hata2
            Fin1_HallSensorStateError = (data[3] & 0b00001000) != 0; // 4. byte'ın 4. biti


            Fin2_MotorLeakageCurrentError = (data[3] & 0b00010000) != 0; // 4. byte'ın 5. biti
            Fin1_MotorLeakageCurrentError = (data[3] & 0b00100000) != 0; // 4. byte'ın 6. biti                        <<<<<hata3

            Fin2_MotorOverCurrentError = (data[3] & 0b01000000) != 0; // 4. byte'ın 7. biti
            Fin1_MotorOverCurrentError = (data[3] & 0b10000000) != 0; // 4. byte'ın 8. biti                           <<<<<hata4

            Fin2_SolenoidError = (data[4] & 0b00000001) != 0; // 5. byte'ın 1. biti
            Fin1_SolenoidError = (data[4] & 0b00000010) != 0; // 5. byte'ın 2. biti                                   <<<<<hata5


            SupplyVoltageError = (data[4] & 0b00000100) != 0; // 5. byte'ın 3. biti                                    <<<<<hata6

            TemperatureSensorError = (data[4] & 0b00001000) != 0; // 5. byte'ın 4. biti                                    <<<<<hata7

            Fin2_MotorDriverICErrorByCPLD = (data[4] & 0b00010000) != 0; // 5. byte'ın 5. biti
            Fin1_MotorDriverICErrorByCPLD = (data[4] & 0b00100000) != 0; // 5. byte'ın 6. biti                              <<<<<hata8

            Fin2_EncoderSupplyErrorByCPLD = (data[4] & 0b01000000) != 0; // 5. byte'ın 7. biti
            Fin1_EncoderSupplyErrorByCPLD = (data[4] & 0b10000000) != 0; // 5. byte'ın 8. biti                                 <<<<<hata9

            Fin2_MotorTemperatureErrorByCPLD = (data[5] & 0b00000001) != 0; // 6. byte'ın 1. biti
            Fin1_MotorTemperatureErrorByCPLD = (data[5] & 0b00000010) != 0; // 6. byte'ın 2. biti                             <<<<<hata10


            Fin2_MotorDriverTemperatureErrorByCPLD = (data[5] & 0b00000100) != 0; // 6. byte'ın 3. biti
            Fin1_MotorDriverTemperatureErrorByCPLD = (data[5] & 0b00001000) != 0; // 6. byte'ın 4. biti                         <<<<<hata11

            Omkk_DspAdc_1_5VoltError = (data[5] & 0b00010000) != 0; // 6. byte'ın 5. biti                                        <<<<<hata12
             
            Omkk_3_3VoltErrorByCPLD = (data[5] & 0b00100000) != 0; // 6. byte'ın 6. biti                                          <<<<<hata13

            Omkk_5VoltErrorByCPLD = (data[5] & 0b01000000) != 0; // 6. byte'ın 7. biti                                         <<<<<hata14
                                                                 // 
            Omkk_12VoltErrorByCPLD = (data[5] & 0b10000000) != 0; // 6. byte'ın 8. biti                                         <<<<<hata15

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

           
                if (Motor1positiontext != null)
                {
                    Motor1positiontext.Text = Fin1PositionReferenceDeg.ToString("F2");
                    motorkonumotomatictext.Text = Fin1PositionReferenceDeg.ToString("F2");
                }

                if (motor2positiontext != null)
                {
                    motor2positiontext.Text = Fin2PositionReferenceDeg.ToString("F2");
                    motor2konumotomatictext.Text = Fin2PositionReferenceDeg.ToString("F2");
                }

                if (motor1currenttext != null)
                {
                    motor1currenttext.Text = Fin1CurrentReferenceDeg.ToString("F2");
                    motorakimotomatictext.Text = Fin1CurrentReferenceDeg.ToString("F2");
                }

                if (motor2currenttext != null)
                {
                    motor2currenttext.Text = Fin2CurrentReferenceDeg.ToString("F2");
                    motorakim2otomatictext.Text = Fin2CurrentReferenceDeg.ToString("F2");
                }
           

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

            if (ReservedMessageNoStatus == 0)
            {
                // DspSoftwareVersion ve ilgili diğer değerleri al
                DspSoftwareVersion = (ushort)((data[26] << 8) | data[25]); // MSB << 8 | LSB
                CpldVersion = (ushort)((data[28] << 8) | data[27]); // MSB << 8 | LSB
                ExecutionTimeOfTheCurrentLoop = (ushort)((data[30] << 8) | data[29]); // MSB << 8 | LSB
                ExecutionTimeOfThePositionLoop = (ushort)((data[32] << 8) | data[31]); // MSB << 8 | LSB
                ExecutionTimeOfTheLowFrequencyTask = (ushort)((data[34] << 8) | data[33]); // MSB << 8 | LSB
            }
            else if (ReservedMessageNoStatus == 1)
            {



                // InstantBatteryVoltage ve ilgili diğer değerleri al
                InstantBatteryVoltage = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                MeanBatteryVoltage = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                CardTemperature = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                isSolenoid1Open = ((data[31] & 0b00000001) != 0); // 31. byte'ın 1. biti
                isSolenoid2Open = ((data[33] & 0b00000010) != 0); // 33. byte'ın 2. biti
                TotalConsumedPower = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
                if (InstantBatteryVoltage != null)
                {
                    MSK1batteryvoltage.Text = InstantBatteryVoltage.ToString("F2");
                }
                if (CardTemperature != null)
                {
                    msk1cardtemp.Text = CardTemperature.ToString("F2");
                }




            }
            else if (ReservedMessageNoStatus == 2)
            {
                // Motor1Currents3Phases ve Motor2Currents3Phases değerlerini al
                Motor1Currents3PhasesA = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                Motor1Currents3PhasesB = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                Motor1Currents3PhasesC = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                Motor2Currents3PhasesA = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                Motor2Currents3PhasesB = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                Motor2Currents3PhasesC = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }
            else if (ReservedMessageNoStatus == 3)
            {
                // BackEMFVoltage3PhaseMotor1 ve Motor1Currents3Phases değerlerini al
                BackEMFVoltage3PhaseMotor1A = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                BackEMFVoltage3PhaseMotor1B = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                BackEMFVoltage3PhaseMotor1C = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                Motor1Currents3PhasesA_Status3 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                Motor1Currents3PhasesB_Status3 = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                Motor1Currents3PhasesC_Status3 = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }


            else if (ReservedMessageNoStatus == 4)
            {
                BackEMFVoltage3PhaseMotor2A = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0);
                BackEMFVoltage3PhaseMotor2B = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0);
                BackEMFVoltage3PhaseMotor2C = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0);
                Motor2Currents3PhasesA_Status4 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0);
                Motor2Currents3PhasesB_Status4 = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0);
                Motor2Currents3PhasesC_Status4 = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0);
            }
            else if (ReservedMessageNoStatus == 5)
            {
                isPos2PosSysAnalysisActivated = (data[25] & 0b00000001) != 0; // 25. byte'ın 1. biti (bool)
                InstantFrequency = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                TimePassed = (ushort)((data[30] << 8) | data[29]); // 29-30 UINT16
                SystemAnalysisMotorId = (ushort)((data[32] << 8) | data[31]); // 31-32 UINT16
                StartFrequency = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                FinishFrequency = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }
            else if (ReservedMessageNoStatus == 6)
            {
                // Tachometer ve LoopCommand bilgilerini al
                TachometerMotor1 = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                TachometerMotor2 = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                LoopCommandMotor1 = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                LoopCommandMotor2 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT

                // ReservedByte4 ve ReservedByte5 kullanılmıyor, boş geçilir
            }
            else if (ReservedMessageNoStatus == 7)
            {
                // CurrentControlPrm ve PositionControlPrm bilgilerini al
                CurrentControlPrm_R_40 = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                CurrentControlPrm_L_40 = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                CurrentControlPrm_BW_40 = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                PositionControlPrm_Kp_40 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                PositionControlPrm_Ki_40 = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                PositionControlPrm_Kd_40 = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }
            else if (ReservedMessageNoStatus == 8)
            {
                // isCurrent2CurrentSysAnalysisActivated ve ilgili diğer değerleri al
                isCurrent2CurrentSysAnalysisActivated = ((data[25] & 0b00000001) != 0); // 25. byte'ın 1. biti
                SfraMagnitudeVectorDb = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                SfraPhaseVectorDeg = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                SfraFrequencyVectorHz = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                SfraObj_FreqIndex = BitConverter.ToInt16(new byte[] { data[33], data[34] }, 0); // 33-34 INT16
                TipToMdcMessage_SystemAnalysisMotorNo = BitConverter.ToUInt16(new byte[] { data[35], data[36] }, 0); // 35-36 UINT16
            }


            SystemType = (data[37] & 0b00000001) != 0; // 37. byte'ın 1. biti
            if (SystemType != false)
            {
                msk1systemtyp.Text = SystemType.ToString();
            }



            ReceivedAutopilotMsgError = (data[37] & 0b00000010) != 0; // 37. byte'ın 2. biti
            Fin1OpenSwitchState = (data[37] & 0b00000100) != 0; // 37. byte'ın 3. biti
            Fin2OpenSwitchState = (data[37] & 0b00001000) != 0; // 37. byte'ın 4. biti
            Fin1CloseSwitchState = (data[37] & 0b00010000) != 0; // 37. byte'ın 5. biti
            Fin2CloseSwitchState = (data[37] & 0b00100000) != 0; // 37. byte'ın 6. biti
            MotorDriveMethod = (data[37] & 0b01000000) != 0; // 37. byte'ın 7. biti
            ReservedBits = (data[37] & 0b10000000) != 0; // 37. byte'ın 8. biti

            counter = data[38];
            DisplayLatestDegAndCurrentindicator(
           textBoxPositionmotor1,  // Motor-1'in pozisyonu
           textBoxPositionmotor2,  // Motor-2'nin pozisyonu
           angleTrackBar, // Motor-1 için TrackBar
           angleTrackBar2  // Motor-2 için TrackBar
       );
            if (serialport.IsOpen)
            {

            if (dbcounter > 10000)
            {
                _ = Task.Run(async () =>
                {
                    while (serialport.IsOpen) // Seri port açık olduğu sürece çalış
                    { 
                    await dbHelper.InsertMotorControlData(
                   isMotor1Enabled,
       isMotor2Enabled,
       isFin1Opened,
       isFin2Opened,
       ReservedMessageNoStatus,
       Fin1MotorHallState,
       Fin2MotorHallState,
       ActualDriveMode,
       Fin2_HallSensorSUpplyError,
       Fin1_HallSensorSUpplyError,
       Fin2_HallSensorStateError,
       Fin1_HallSensorStateError,
       Fin2_MotorLeakageCurrentError,
       Fin1_MotorLeakageCurrentError,
       Fin2_MotorOverCurrentError,
       Fin1_MotorOverCurrentError,
       Fin2_SolenoidError,
       Fin1_SolenoidError,
       SupplyVoltageError,
       TemperatureSensorError,
       Fin2_MotorDriverICErrorByCPLD,
       Fin1_MotorDriverICErrorByCPLD,
       Fin2_EncoderSupplyErrorByCPLD,
       Fin1_EncoderSupplyErrorByCPLD,
       Fin2_MotorTemperatureErrorByCPLD,
       Fin1_MotorTemperatureErrorByCPLD,
       Fin2_MotorDriverTemperatureErrorByCPLD,
       Fin1_MotorDriverTemperatureErrorByCPLD,
       Omkk_DspAdc_1_5VoltError,
       Omkk_3_3VoltErrorByCPLD,
       Omkk_5VoltErrorByCPLD,
       Omkk_12VoltErrorByCPLD,
       Fin1PositionFeedbackRaw,
       Fin1PositionFeedbackDeg,
       Fin2PositionFeedbackRaw,
       Fin2PositionFeedbackDeg,
       Fin1PositionReferenceRaw,
       Fin1PositionReferenceDeg,
       Fin2PositionReferenceRaw,
       Fin2PositionReferenceDeg,
       Fin1CurrentReferenceRaw,
       Fin1CurrentReferenceDeg,
       Fin2CurrentReferenceRaw,
       Fin2CurrentReferenceDeg,
       Fin1CurrentFeedbackRaw,
       Fin1CurrentFeedbackDeg,
       Fin2CurrentFeedbackRaw,
       Fin2CurrentFeedbackDeg,
       fin1AppliedPWM,
       fin2AppliedPWM,
       DspSoftwareVersion,
       CpldVersion,
       ExecutionTimeOfTheCurrentLoop,
       ExecutionTimeOfThePositionLoop,
       ExecutionTimeOfTheLowFrequencyTask,
       InstantBatteryVoltageRaw,
       InstantBatteryVoltage,
       MeanBatteryVoltageRaw,
       MeanBatteryVoltage,
       CardTemperature,
       isSolenoid1Open,
       isSolenoid2Open,
       TotalConsumedPower,
       Motor1Currents3PhasesA,
       Motor1Currents3PhasesB,
       Motor1Currents3PhasesC,
       Motor2Currents3PhasesA,
       Motor2Currents3PhasesB,
       Motor2Currents3PhasesC,
       BackEMFVoltage3PhaseMotor1A,
       BackEMFVoltage3PhaseMotor1B,
       BackEMFVoltage3PhaseMotor1C,
       Motor1Currents3PhasesA_Status3,
       Motor1Currents3PhasesB_Status3,
       Motor1Currents3PhasesC_Status3,
       BackEMFVoltage3PhaseMotor2A,
       BackEMFVoltage3PhaseMotor2B,
       BackEMFVoltage3PhaseMotor2C,
       Motor2Currents3PhasesA_Status4,
       Motor2Currents3PhasesB_Status4,
       Motor2Currents3PhasesC_Status4,
       isPos2PosSysAnalysisActivated,
       TachometerMotor1,
       TachometerMotor2,
       LoopCommandMotor1,
       LoopCommandMotor2,
       CurrentControlPrm_R_40,
       CurrentControlPrm_L_40,
       CurrentControlPrm_BW_40,
       PositionControlPrm_Kp_40,
       PositionControlPrm_Ki_40,
       PositionControlPrm_Kd_40,
       InstantFrequency,
       TimePassed,
       SystemAnalysisMotorId,
       StartFrequency,
       FinishFrequency,
       isCurrent2CurrentSysAnalysisActivated,
       SfraMagnitudeVectorDb,
       SfraPhaseVectorDeg,
       SfraFrequencyVectorHz,
       SfraObj_FreqIndex,
       TipToMdcMessage_SystemAnalysisMotorNo,
       SystemType,
       ReceivedAutopilotMsgError,
       Fin1OpenSwitchState,
       Fin2OpenSwitchState,
       Fin1CloseSwitchState,
       Fin2CloseSwitchState,
       MotorDriveMethod,
       ReservedBits,
       counter, portInfo

        );
                    }
                });
                dbcounter = 0;

            }
            

            }
        }




        public void CombinedDataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {

                bytesToRead2 = serialport3.BytesToRead; //sayımız

                // Hassas zaman ölçümü için Stopwatch kullanımı

                if (bytesToRead2 > 0)
                {
                    byte[] incomingData = new byte[bytesToRead2];

                    serialport3.Read(incomingData, 0, bytesToRead2);

                    receivedDataBufferControl2.AddRange(incomingData);
                    Array.Clear(incomingData, 0, incomingData.Length);

                    if (receivedDataBufferControl2.Count > 60000)
                    {
                        receivedDataBufferControl2.Clear();
                    }
                    if (bytesToRead2 < 40)
                    {

                        littledata = 1;
                    }
                    else
                    {
                        littledata = 0;
                    }

                    stopwatch.Stop();



                    if (result == 0 && littledata == 0)
                    {
                        //  stopwatch = System.Diagnostics.Stopwatch.StartNew();
                        result = 1;
                        lock (receivedDataBuffer2)
                        {
                            receivedDataBuffer2.AddRange(receivedDataBufferControl2);
                            receivedDataBufferControl2.Clear();

                        }

                        ProcessBuffer2();
                        lock (receivedDataBuffer2)
                        {
                            receivedDataBuffer2.Clear();

                        }
                        result = 0;
                    }
                    // Veri okuma işlemi

                    // double elapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds; // Milisaniye
                    // double elapsedMicroseconds = stopwatch.Elapsed.TotalMilliseconds * 1000; // Mikrosaniye


                    // string message = $"b: {bytesToRead}\n" +
                    //                  $"Tm: {elapsedMicroseconds} µs\n";
                    //Invoke(new Action(() =>
                    // {

                    //     timetextbox.Text = message;
                    // }));
                }

            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message + " " + receivedDataBuffer.Count);
                }));
            }
        }
        private void ProcessBuffer2()
        {
            lock (receivedDataBuffer2)
            {



                for (int i = 0; i < receivedDataBuffer2.Count; i++)
                {

                    if (receivedDataBuffer2[i] == 0x1D)
                    {





                        if (i + 40 <= receivedDataBuffer2.Count)
                        {
                            byte[] packet40 = receivedDataBuffer2.Skip(i).Take(40).ToArray();
                            ProcessProtocol40_2(packet40);
                        }


                        // İşlenen paketi sıraya koy
                        // processedPackets40.Enqueue(packet40);


                        // İşlenen bayt sayısını artır


                        i += 39;


                        //if (i >= 3958)
                        //{

                        //}


                    }


                }




            }

            // İşlem sırasındaki protokolleri ayır
            //ProcessPackets();
        }
        private void ProcessProtocol40_2(byte[] packet)
        {
            try
            {
                if (ValidateChecksum2(packet))
                {
                    //Invoke(new Action(() =>
                    //{
                    //    string messageHex = BitConverter.ToString(packet).Replace("-", " ");
                    //    string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");

                    //    // Protokol 1 için DataGridView'e veri ekleyelim
                    //    dataGridView1.Rows.Add(messageHex, timeStamp);

                    //    if (dataGridView1.Rows.Count > 0)
                    //    {
                    //        dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                    //    }
                    //}));

                    ProcessMotorControls2(packet);
                }
                else
                {

                    //Invoke(new Action(() =>
                    //{
                    //    mesajtext.Text = "cserror";

                    //    //MessageBox.Show("40 byte Checksum hatası!");
                    //}));
                }
            }
            catch (Exception ex)
            {
                //Invoke(new Action(() =>
                //{
                //    //MessageBox.Show("40 byte protokol işleminde hata oluştu: " + ex.Message);
                //}));
            }
        }
        private bool ValidateChecksum2(byte[] message)
        {
            if (message.Length != messageLength)
                return false;

            // Checksum hesaplaması (son bayt checksum olduğu için dahil etmiyoruz)
            int sum = 0;
            for (int i = 0; i < message.Length - 1; i++)
            {
                sum += message[i];
            }

            // Checksum hesaplama: (0x100 - toplam) & 0xFF
            byte calculatedChecksum = (byte)((0x100 - (sum & 0xFF)) & 0xFF);

            // Mesajın son baytı (message[message.Length - 1]) alınan checksum
            byte receivedChecksum = message[message.Length - 1];

            // Checksum doğrulama
            return calculatedChecksum == receivedChecksum;
        }
        private int updateCounter2 = 0;
        private int dbcounter2 = 0;
        private void ProcessMotorControls2(byte[] data)
        {
            updateCounter2++;
            dbcounter2++;
            if (data.Length < 3) return; // En az 3 byte olmalı

            // 2. byte'ın bitlerini kontrol et
            isMotor1Enabled = (data[1] & 0b00000001) != 0; // 2. byte'ın 1. biti
            isMotor2Enabled = (data[1] & 0b00000010) != 0; // 2. byte'ın 2. biti
            isFin1Opened = (data[1] & 0b00000100) != 0; // 2. byte'ın 3. biti
            isFin2Opened = (data[1] & 0b00001000) != 0; // 2. byte'ın 4. biti
            ReservedMessageNoStatus = (uint)((data[1] & 0b11110000) >> 4);// 2. byte'ın 4-7. bitlerini al ve 4 bit sağa kaydırarak değeri belirle
            ReservedMessageNoStatus = 1;
            // 2. byte'ın 4-7. biti

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
            if (updateCounter2 >= 1000)
            {
                if (Motor3positiontext != null)
                {
                    Motor3positiontext.Text = Fin1PositionReferenceDeg.ToString("F2");
                    motor3konumotomatictext.Text = Fin1PositionReferenceDeg.ToString("F2");
                }

                if (Motor4positiontext != null)
                {
                    Motor4positiontext.Text = Fin2PositionReferenceDeg.ToString("F2");
                    motor4konumotomatictext.Text = Fin2PositionReferenceDeg.ToString("F2");
                }

                if (motor3currenttext != null)
                {
                    motor3currenttext.Text = Fin1CurrentReferenceDeg.ToString("F2");
                    motor3akimotomatictext.Text = Fin1CurrentReferenceDeg.ToString("F2");
                }

                if (motor4currenttext != null)
                {
                    motor4currenttext.Text = Fin2CurrentReferenceDeg.ToString("F2");
                    motorakim4otomatictext.Text = Fin2CurrentReferenceDeg.ToString("F2");
                }
                updateCounter2 = 0;
            }


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

            if (ReservedMessageNoStatus == 0)
            {
                // DspSoftwareVersion ve ilgili diğer değerleri al
                DspSoftwareVersion = (ushort)((data[26] << 8) | data[25]); // MSB << 8 | LSB
                CpldVersion = (ushort)((data[28] << 8) | data[27]); // MSB << 8 | LSB
                ExecutionTimeOfTheCurrentLoop = (ushort)((data[30] << 8) | data[29]); // MSB << 8 | LSB
                ExecutionTimeOfThePositionLoop = (ushort)((data[32] << 8) | data[31]); // MSB << 8 | LSB
                ExecutionTimeOfTheLowFrequencyTask = (ushort)((data[34] << 8) | data[33]); // MSB << 8 | LSB
            }
            else if (ReservedMessageNoStatus == 1)
            {
                // InstantBatteryVoltage ve ilgili diğer değerleri al
                InstantBatteryVoltage = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                MeanBatteryVoltage = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                CardTemperature = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                isSolenoid1Open = ((data[31] & 0b00000001) != 0); // 31. byte'ın 1. biti
                isSolenoid2Open = ((data[33] & 0b00000010) != 0); // 33. byte'ın 2. biti
                TotalConsumedPower = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT

                if (InstantBatteryVoltage != null)
                {
                    MSK2batteryvoltage.Text = InstantBatteryVoltage.ToString("F2");
                }
                if (CardTemperature != null)
                {
                    msk2cardtemp.Text = CardTemperature.ToString("F2");
                }
            }
            else if (ReservedMessageNoStatus == 2)
            {
                // Motor1Currents3Phases ve Motor2Currents3Phases değerlerini al
                Motor1Currents3PhasesA = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                Motor1Currents3PhasesB = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                Motor1Currents3PhasesC = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                Motor2Currents3PhasesA = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                Motor2Currents3PhasesB = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                Motor2Currents3PhasesC = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }
            else if (ReservedMessageNoStatus == 3)
            {
                // BackEMFVoltage3PhaseMotor1 ve Motor1Currents3Phases değerlerini al
                BackEMFVoltage3PhaseMotor1A = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                BackEMFVoltage3PhaseMotor1B = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                BackEMFVoltage3PhaseMotor1C = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                Motor1Currents3PhasesA_Status3 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                Motor1Currents3PhasesB_Status3 = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                Motor1Currents3PhasesC_Status3 = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }


            else if (ReservedMessageNoStatus == 4)
            {
                BackEMFVoltage3PhaseMotor2A = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0);
                BackEMFVoltage3PhaseMotor2B = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0);
                BackEMFVoltage3PhaseMotor2C = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0);
                Motor2Currents3PhasesA_Status4 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0);
                Motor2Currents3PhasesB_Status4 = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0);
                Motor2Currents3PhasesC_Status4 = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0);
            }
            else if (ReservedMessageNoStatus == 5)
            {
                isPos2PosSysAnalysisActivated = (data[25] & 0b00000001) != 0; // 25. byte'ın 1. biti (bool)
                InstantFrequency = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                TimePassed = (ushort)((data[30] << 8) | data[29]); // 29-30 UINT16
                SystemAnalysisMotorId = (ushort)((data[32] << 8) | data[31]); // 31-32 UINT16
                StartFrequency = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                FinishFrequency = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }
            else if (ReservedMessageNoStatus == 6)
            {
                // Tachometer ve LoopCommand bilgilerini al
                TachometerMotor1 = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                TachometerMotor2 = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                LoopCommandMotor1 = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                LoopCommandMotor2 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT

                // ReservedByte4 ve ReservedByte5 kullanılmıyor, boş geçilir
            }
            else if (ReservedMessageNoStatus == 7)
            {
                // CurrentControlPrm ve PositionControlPrm bilgilerini al
                CurrentControlPrm_R_40 = BitConverter.ToSingle(new byte[] { data[25], data[26], 0, 0 }, 0); // 25-26 FLOAT
                CurrentControlPrm_L_40 = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                CurrentControlPrm_BW_40 = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                PositionControlPrm_Kp_40 = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                PositionControlPrm_Ki_40 = BitConverter.ToSingle(new byte[] { data[33], data[34], 0, 0 }, 0); // 33-34 FLOAT
                PositionControlPrm_Kd_40 = BitConverter.ToSingle(new byte[] { data[35], data[36], 0, 0 }, 0); // 35-36 FLOAT
            }
            else if (ReservedMessageNoStatus == 8)
            {
                // isCurrent2CurrentSysAnalysisActivated ve ilgili diğer değerleri al
                isCurrent2CurrentSysAnalysisActivated = ((data[25] & 0b00000001) != 0); // 25. byte'ın 1. biti
                SfraMagnitudeVectorDb = BitConverter.ToSingle(new byte[] { data[27], data[28], 0, 0 }, 0); // 27-28 FLOAT
                SfraPhaseVectorDeg = BitConverter.ToSingle(new byte[] { data[29], data[30], 0, 0 }, 0); // 29-30 FLOAT
                SfraFrequencyVectorHz = BitConverter.ToSingle(new byte[] { data[31], data[32], 0, 0 }, 0); // 31-32 FLOAT
                SfraObj_FreqIndex = BitConverter.ToInt16(new byte[] { data[33], data[34] }, 0); // 33-34 INT16
                TipToMdcMessage_SystemAnalysisMotorNo = BitConverter.ToUInt16(new byte[] { data[35], data[36] }, 0); // 35-36 UINT16
            }


            SystemType = (data[37] & 0b00000001) != 0; // 37. byte'ın 1. biti
            if (SystemType != null)
            {
                msk1systemtyp.Text = SystemType.ToString();
            }
            ReceivedAutopilotMsgError = (data[37] & 0b00000010) != 0; // 37. byte'ın 2. biti
            Fin1OpenSwitchState = (data[37] & 0b00000100) != 0; // 37. byte'ın 3. biti
            Fin2OpenSwitchState = (data[37] & 0b00001000) != 0; // 37. byte'ın 4. biti
            Fin1CloseSwitchState = (data[37] & 0b00010000) != 0; // 37. byte'ın 5. biti
            Fin2CloseSwitchState = (data[37] & 0b00100000) != 0; // 37. byte'ın 6. biti
            MotorDriveMethod = (data[37] & 0b01000000) != 0; // 37. byte'ın 7. biti
            ReservedBits = (data[37] & 0b10000000) != 0; // 37. byte'ın 8. biti

            counter = data[38];



            DisplayLatestDegAndCurrentindicator2(
         textBoxPositionmotor3,  // Motor-1'in pozisyonu
         textBoxPositionmotor4,  // Motor-2'nin pozisyonu
         angleTrackBar3, // Motor-1 için TrackBar
         angleTrackBar4  // Motor-2 için TrackBar
     );

            if (serialport3.IsOpen)
            {

                if (dbcounter2 > 10000)
                {
                    _ = Task.Run(async () =>
                    {
                        while (serialport3.IsOpen) // Seri port açık olduğu sürece çalış
                        {
                            await dbHelper.InsertMotorControlData(
                           isMotor1Enabled,
               isMotor2Enabled,
               isFin1Opened,
               isFin2Opened,
               ReservedMessageNoStatus,
               Fin1MotorHallState,
               Fin2MotorHallState,
               ActualDriveMode,
               Fin2_HallSensorSUpplyError,
               Fin1_HallSensorSUpplyError,
               Fin2_HallSensorStateError,
               Fin1_HallSensorStateError,
               Fin2_MotorLeakageCurrentError,
               Fin1_MotorLeakageCurrentError,
               Fin2_MotorOverCurrentError,
               Fin1_MotorOverCurrentError,
               Fin2_SolenoidError,
               Fin1_SolenoidError,
               SupplyVoltageError,
               TemperatureSensorError,
               Fin2_MotorDriverICErrorByCPLD,
               Fin1_MotorDriverICErrorByCPLD,
               Fin2_EncoderSupplyErrorByCPLD,
               Fin1_EncoderSupplyErrorByCPLD,
               Fin2_MotorTemperatureErrorByCPLD,
               Fin1_MotorTemperatureErrorByCPLD,
               Fin2_MotorDriverTemperatureErrorByCPLD,
               Fin1_MotorDriverTemperatureErrorByCPLD,
               Omkk_DspAdc_1_5VoltError,
               Omkk_3_3VoltErrorByCPLD,
               Omkk_5VoltErrorByCPLD,
               Omkk_12VoltErrorByCPLD,
               Fin1PositionFeedbackRaw,
               Fin1PositionFeedbackDeg,
               Fin2PositionFeedbackRaw,
               Fin2PositionFeedbackDeg,
               Fin1PositionReferenceRaw,
               Fin1PositionReferenceDeg,
               Fin2PositionReferenceRaw,
               Fin2PositionReferenceDeg,
               Fin1CurrentReferenceRaw,
               Fin1CurrentReferenceDeg,
               Fin2CurrentReferenceRaw,
               Fin2CurrentReferenceDeg,
               Fin1CurrentFeedbackRaw,
               Fin1CurrentFeedbackDeg,
               Fin2CurrentFeedbackRaw,
               Fin2CurrentFeedbackDeg,
               fin1AppliedPWM,
               fin2AppliedPWM,
               DspSoftwareVersion,
               CpldVersion,
               ExecutionTimeOfTheCurrentLoop,
               ExecutionTimeOfThePositionLoop,
               ExecutionTimeOfTheLowFrequencyTask,
               InstantBatteryVoltageRaw,
               InstantBatteryVoltage,
               MeanBatteryVoltageRaw,
               MeanBatteryVoltage,
               CardTemperature,
               isSolenoid1Open,
               isSolenoid2Open,
               TotalConsumedPower,
               Motor1Currents3PhasesA,
               Motor1Currents3PhasesB,
               Motor1Currents3PhasesC,
               Motor2Currents3PhasesA,
               Motor2Currents3PhasesB,
               Motor2Currents3PhasesC,
               BackEMFVoltage3PhaseMotor1A,
               BackEMFVoltage3PhaseMotor1B,
               BackEMFVoltage3PhaseMotor1C,
               Motor1Currents3PhasesA_Status3,
               Motor1Currents3PhasesB_Status3,
               Motor1Currents3PhasesC_Status3,
               BackEMFVoltage3PhaseMotor2A,
               BackEMFVoltage3PhaseMotor2B,
               BackEMFVoltage3PhaseMotor2C,
               Motor2Currents3PhasesA_Status4,
               Motor2Currents3PhasesB_Status4,
               Motor2Currents3PhasesC_Status4,
               isPos2PosSysAnalysisActivated,
               TachometerMotor1,
               TachometerMotor2,
               LoopCommandMotor1,
               LoopCommandMotor2,
               CurrentControlPrm_R_40,
               CurrentControlPrm_L_40,
               CurrentControlPrm_BW_40,
               PositionControlPrm_Kp_40,
               PositionControlPrm_Ki_40,
               PositionControlPrm_Kd_40,
               InstantFrequency,
               TimePassed,
               SystemAnalysisMotorId,
               StartFrequency,
               FinishFrequency,
               isCurrent2CurrentSysAnalysisActivated,
               SfraMagnitudeVectorDb,
               SfraPhaseVectorDeg,
               SfraFrequencyVectorHz,
               SfraObj_FreqIndex,
               TipToMdcMessage_SystemAnalysisMotorNo,
               SystemType,
               ReceivedAutopilotMsgError,
               Fin1OpenSwitchState,
               Fin2OpenSwitchState,
               Fin1CloseSwitchState,
               Fin2CloseSwitchState,
               MotorDriveMethod,
               ReservedBits,
               counter, portInfo

                );
                        }
                    });
                    dbcounter2 = 0;

                }


            }


        }




        private void ProcessPackets()
        {
            // 21 byte'lık protokolü işle
            while (processedPackets21.Count > 0)
            {
                byte[] packet = processedPackets21.Dequeue();
                ProcessProtocol21(packet);
            }

            // 40 byte'lık protokolü işle
            while (processedPackets40.Count > 0)
            {
                byte[] packet = processedPackets40.Dequeue();
                ProcessProtocol40(packet);
            }
        }

        private void ProcessProtocol21(byte[] packet)
        {
            try
            {
                byte[] dataBytes = packet.Take(20).ToArray();
                byte receivedChecksum = packet[20];
                byte calculatedChecksum = (byte)((0x100 - dataBytes.Sum(byteValue => byteValue) & 0xFF) & 0xFF);

                if (receivedChecksum == calculatedChecksum)
                {
                    Invoke(new Action(() =>
                    {
                        string dataHex = BitConverter.ToString(packet).Replace("-", " ");
                        string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");

                        // DataGridView'e veri ekle
                        dataGridViewCrcResults.Rows.Add(dataHex, calculatedChecksum.ToString("X2"), dataHex, receivedChecksum.ToString("X2"), timeStamp);
                    }));
                }
                else
                {
                    Invoke(new Action(() =>
                    {
                        string dataHex = BitConverter.ToString(packet).Replace("-", " ");
                        string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");

                        dataGridViewCrcResults.Rows.Add("N/A", "N/A", dataHex, receivedChecksum.ToString("X2"), timeStamp);
                    }));
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {

                    //MessageBox.Show("21 byte protokol işleminde hata oluştu: " + ex.Message);
                }));
            }
        }






        //public async void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        //{
        //    try
        //    {
        //        int bytesToRead = serialport.BytesToRead;
        //        byte[] incomingData = new byte[bytesToRead];
        //        serialport.Read(incomingData, 0, bytesToRead);

        //        foreach (byte b in incomingData)
        //        {
        //            if (receivedDataBuffer.Count == 0)
        //            {
        //                // Başlık baytını bekliyoruz
        //                if (b == headerByte)
        //                {
        //                    receivedDataBuffer.Add(b);

        //                    // Zamanlayıcıyı başlat
        //                    dataReceiveTimer.Stop();
        //                    dataReceiveTimer.Start();
        //                }
        //                // Başlık baytı değilse yok say
        //            }
        //            else
        //            {
        //                // Mesaj toplamaya devam ediyoruz
        //                receivedDataBuffer.Add(b);

        //                // Zamanlayıcıyı sıfırla
        //                dataReceiveTimer.Stop();
        //                dataReceiveTimer.Start();

        //                if (receivedDataBuffer.Count == messageLength)
        //                {
        //                    // Mesaj tamamlandı
        //                    dataReceiveTimer.Stop();

        //                    // Checksum kontrolü yap (await ile bekliyoruz)
        //                    bool isChecksumValid = await ValidateChecksumAsync(receivedDataBuffer.ToArray());

        //                    if (isChecksumValid)
        //                    {
        //                        if ((receivedDataBuffer.Count > 0) && (receivedDataBuffer[0] == headerByte))
        //                        {
        //                            await ProcessMotorControlsAsync(receivedDataBuffer.ToArray());

        //                            // Gelen veriyi DataGridView1'e ekle
        //                            Invoke(new Action(() =>
        //                            {
        //                                string sentData = "Gönderilen Veri Yok"; // Eğer gönderilen veri varsa burada güncelleyebilirsiniz
        //                                string sentCrc = "Gönderilen CRC Yok";  // Eğer gönderilen CRC varsa burada güncelleyebilirsiniz
        //                                string receivedData = BitConverter.ToString(receivedDataBuffer.ToArray()).Replace("-", " ");
        //                                string receivedCrc = "CRC Alınan";  // Eğer hesaplanan CRC varsa burada göster
        //                                string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");

        //                                // DataGridView1'e veri ekleme
        //                                dataGridView1.Rows.Add(sentData, sentCrc, receivedData, receivedCrc, timeStamp);
        //                            }));
        //                        }
        //                    }
        //                    else
        //                    {
        //                        // Checksum hatası
        //                        Invoke(new Action(() =>
        //                        {
        //                            MessageBox.Show("Checksum hatası!");
        //                        }));
        //                    }

        //                    // Buffer'ı temizle
        //                    receivedDataBuffer.Clear();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Invoke(new Action(() =>
        //        {
        //            MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message);
        //        }));
        //    }
        //}

        public byte[] CreateRandomPacketEmpty()
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
            if (isCurrentControllerChangeValid == 0)
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
            else if (systemAnalysisMode == 1)
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

            for (int i = 1; i < 19; i++)
            {
                byteList[i] = 0x00; // Her baytı sıfır yap
            }
            // 19. Bayt: Sabit header (0x3A)
            byteList.Add(0x3A);

            // CheckSum hesapla (tüm baytların toplamı & 0xFF)
            byte checkSum = (byte)((0x100 - (byteList.Sum(b => b) & 0xFF)) & 0xFF);
            byteList.Add(checkSum);

            //string byteListString = string.Join(" ", byteList.Select(b => b.ToString("X2")));

            // textBox'a yazdırıyoruz
            // textBoxSendData.Text = "array"+byteListString;
            // Sonuç olarak 20 baytlık veri döndürülür (CRC eklenmeyecek)
            return byteList.ToArray();
        }
        private System.Windows.Forms.Timer sendTimer = new Timer();  // Timer'ı tanımlıyoruz
        private System.Windows.Forms.Timer sendTimer2 = new Timer();  // Timer'ı tanımlıyoruz

        private bool isSending = false;
        private bool isSending2 = false;

        private void SendText_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialport.IsOpen)
                {
                    // Protokol seçimini her zaman kontrol et
                    if (SelectedProtocol.SelectedItem != null)
                    {
                        string selectedProtocol = SelectedProtocol.SelectedItem.ToString();
                        string dataToSend = textBoxSendData.Text;

                        // Eğer textbox'ta veri varsa gönderme işlemini yap
                        if (!string.IsNullOrWhiteSpace(dataToSend))
                        {
                            // Protokole göre gönderilecek mesajı her seferinde güncelle
                            if (selectedProtocol == "1")
                            {
                                // Eğer protokol 1 seçildiyse, veri göndermeye başla


                                // Timer'ı başlat ve 10ms aralıkla sürekli gönder
                                StartSendingMessage();
                                // serialport.Write(fullMessage, 0, fullMessage.Length);
                                //MessageBox.Show("Protokol 1 seçildi, fullMessage gönderildi.");
                            }
                            else if (selectedProtocol == "2")
                            {
                                // Eğer protokol 2 seçildiyse, CreateRandomPacket ile fullMessage2'yi oluştur
                                fullMessage2 = CreateRandomPacket(); // Burada fullMessage2'yi dolduruyoruz
                                serialport.Write(fullMessage2, 0, fullMessage2.Length);
                                //MessageBox.Show("Protokol 2 seçildi, fullMessage2 gönderildi.");

                            }
                            else if (selectedProtocol == "3")
                            {
                                fullMessage2 = CreateRandomPacketEmpty();
                                serialport.Write(fullMessage2, 0, fullMessage2.Length);
                            }
                            else
                            {
                                MessageBox.Show("Geçersiz protokol seçildi.");
                                return;
                            }

                            // Gönderilen veriyi temizle
                            // textBoxSendData.Clear();
                        }
                        else
                        {
                            //       MessageBox.Show("Gönderilecek veri boş olamaz.");
                        }
                    }
                    else
                    {
                        //     MessageBox.Show("Lütfen önce bir protokol seçin.");
                    }
                }
                else
                {
                    //   MessageBox.Show("Önce seri portu açın.");
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Veri gönderilirken hata oluştu: " + ex.Message);
            }
        }
        private void SendText_Click3(object sender, EventArgs e)
        {
            try
            {
                if (serialport3.IsOpen)
                {
                    // Protokol seçimini her zaman kontrol et
                    if (SelectedProtocol3.SelectedItem != null)
                    {
                        string selectedProtocol = SelectedProtocol3.SelectedItem.ToString();
                        string dataToSend = textBoxSendData.Text;

                        // Eğer textbox'ta veri varsa gönderme işlemini yap
                        if (!string.IsNullOrWhiteSpace(dataToSend))
                        {
                            // Protokole göre gönderilecek mesajı her seferinde güncelle
                            if (selectedProtocol == "1")
                            {
                                // Eğer protokol 1 seçildiyse, veri göndermeye başla


                                // Timer'ı başlat ve 10ms aralıkla sürekli gönder
                                StartSendingMessage3();
                                // serialport.Write(fullMessage, 0, fullMessage.Length);
                                //MessageBox.Show("Protokol 1 seçildi, fullMessage gönderildi.");
                            }
                            else if (selectedProtocol == "2")
                            {
                                // Eğer protokol 2 seçildiyse, CreateRandomPacket ile fullMessage2'yi oluştur
                                fullMessage2 = CreateRandomPacket(); // Burada fullMessage2'yi dolduruyoruz
                                serialport.Write(fullMessage2, 0, fullMessage2.Length);
                                //MessageBox.Show("Protokol 2 seçildi, fullMessage2 gönderildi.");

                            }
                            else if (selectedProtocol == "3")
                            {
                                fullMessage2 = CreateRandomPacketEmpty();
                                serialport3.Write(fullMessage2, 0, fullMessage2.Length);
                            }
                            else
                            {
                                // MessageBox.Show("Geçersiz protokol seçildi.");
                                return;
                            }

                            // Gönderilen veriyi temizle
                            // textBoxSendData.Clear();
                        }
                        else
                        {
                            //  MessageBox.Show("Gönderilecek veri boş olamaz.");
                        }
                    }
                    else
                    {
                        //  MessageBox.Show("Lütfen önce bir protokol seçin.");
                    }
                }
                else
                {
                    //  MessageBox.Show("Önce seri portu açın.");
                }
            }
            catch (Exception ex)
            {
                //  MessageBox.Show("Veri gönderilirken hata oluştu: " + ex.Message);
            }
        }
        private void StartSendingMessage()
        {

            // Timer'ı kontrol et
            if (!sendTimer.Enabled)
            {

                sendTimer.Interval = 20;  // 10 ms aralıkla çalışacak
                sendTimer.Tick += SendTimer_Tick;
            }

            if (!isSending)
            {
                isSending = true;
                sendTimer.Start();  // Timer'ı başlat
            }
        }
        private void StartSendingMessage3()
        {
            // Timer'ı kontrol et
            if (!sendTimer2.Enabled)
            {
                sendTimer2.Interval = 20; // 20 ms aralık
                sendTimer2.Tick += SendTimer_Tick3;
            }


            if (!isSending2)
            {
                isSending2 = true;
                sendTimer2.Start();  // Timer'ı başlat
            }
        }

        private void SendTimer_Tick(object sender, EventArgs e)
        {
            if (serialport.IsOpen && fullMessage != null)
            {
                serialport.Write(fullMessage, 0, fullMessage.Length);
                // Veriyi gönderdikçe burada ekranda bir işlem de yapabilirsiniz (örneğin, loglama veya mesaj gösterme).

                // Eğer belirli bir süre sonra durdurmak istiyorsanız, örneğin 5 saniye sonra durdurabilirsiniz.
                // Bu örnekte timer'ı durdurma mantığını ekleyebilirsiniz.
                // sendTimer.Stop();
                // isSending = false;
            }
        }
        private void SendTimer_Tick3(object sender, EventArgs e)
        {
            if (serialport3.IsOpen && fullMessage3 != null)
            {
                serialport3.Write(fullMessage3, 0, fullMessage.Length);
                // Veriyi gönderdikçe burada ekranda bir işlem de yapabilirsiniz (örneğin, loglama veya mesaj gösterme).

                // Eğer belirli bir süre sonra durdurmak istiyorsanız, örneğin 5 saniye sonra durdurabilirsiniz.
                // Bu örnekte timer'ı durdurma mantığını ekleyebilirsiniz.
                // sendTimer.Stop();
                // isSending = false;
            }
        }
        private void GenerateAndDisplayData()
        {
            byte header = 0x1D; //başlık değeri 
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
            checksum = (byte)((0x100 - (sum & 0xFF)) & 0xFF);

            // Tüm mesajı birleştirme

            fullMessage[0] = header;
            fullMessage[39] = checksum;
            Array.Copy(dataBytes, 0, fullMessage, 1, dataBytes.Length);

            for (int i = 40; i < 4000; i++)
            {
                fullMessage[i] = fullMessage[i - 40];
            }

            // Mesajı görüntülemek için hex string'e çevirme
            string hexString = BitConverter.ToString(fullMessage).Replace("-", " ");
            textBoxSendData.Text = hexString;
        }
        private void GenerateAndDisplayData2()
        {
            byte header = 0x1D; //başlık değeri 
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
            checksum = (byte)((0x100 - (sum & 0xFF)) & 0xFF);

            // Tüm mesajı birleştirme

            fullMessage3[0] = header;
            fullMessage3[39] = checksum;
            Array.Copy(dataBytes, 0, fullMessage3, 1, dataBytes.Length);

            for (int i = 40; i < 4000; i++)
            {
                fullMessage3[i] = fullMessage3[i - 40];
            }

            // Mesajı görüntülemek için hex string'e çevirme
            string hexString = BitConverter.ToString(fullMessage3).Replace("-", " ");
            textBoxSendData.Text = hexString;
        }

        private void SelectedProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Buffer'ı temizle, önceki veriler karışmasın
            receivedDataBuffer.Clear();

            // Protokole göre işlem yap
            if (SelectedProtocol.SelectedItem.ToString() == "1")
            {
                GenerateAndDisplayData();
            }
            else if (SelectedProtocol.SelectedItem.ToString() == "2")
            {
                GenerateAndDisplayRandomPacket(); // Rastgele veri oluşturup USB'ye gönderilecek şekilde sendbox'a yazdır
            }
            else if (SelectedProtocol.SelectedItem.ToString() == "3")
            {
                GenerateAndDisplayRandomPacketEmpty();
            }
            else
            {
                MessageBox.Show("Geçersiz protokol seçildi.");
            }
        }
        private void SelectedProtocol_SelectedIndexChanged3(object sender, EventArgs e)
        {
            // Buffer'ı temizle, önceki veriler karışmasın
            receivedDataBuffer.Clear();

            // Protokole göre işlem yap
            if (SelectedProtocol3.SelectedItem.ToString() == "1")
            {
                GenerateAndDisplayData2();
            }
            else if (SelectedProtocol3.SelectedItem.ToString() == "2")
            {
                GenerateAndDisplayRandomPacket(); // Rastgele veri oluşturup USB'ye gönderilecek şekilde sendbox'a yazdır
            }
            else if (SelectedProtocol3.SelectedItem.ToString() == "3")
            {
                GenerateAndDisplayRandomPacketEmpty();
            }
            else
            {
                MessageBox.Show("Geçersiz protokol seçildi.");
            }
        }
        private void Dashboardbutton1_Click(object sender, EventArgs e)
        {
            Dashboard.Visible = true;  // Başlangıç panelini göster
            ErrorPanel.Visible = false;
            Parametre.Visible = false;// Hatalar panelini gizle
            PanelManuelTest.Visible = false;
            otopanel.Visible = false;
            PanelHomepage.Visible = false;

        }

        // Hatalar butonuna tıklandığında panel2 gösterilecek, panel1 gizlenecek
        private void ErrorPanelbutton_Click(object sender, EventArgs e)
        {
            ErrorPanel.Visible = true;  // Hatalar panelini göster
            Dashboard.Visible = false;
            Parametre.Visible = false;// Başlangıç panelini gizle
            PanelManuelTest.Visible = false;
            otopanel.Visible = false;
            PanelHomepage.Visible = false;


        }

        private void ManueltestButtonClick(object sender, EventArgs e)
        {

            PanelManuelTest.Visible = true;
            ErrorPanel.Visible = false;  // Hatalar panelini göster
            Dashboard.Visible = false;
            Parametre.Visible = false;// Başlangıç panelini gizle
            otopanel.Visible = false;

            // dbHelper.DisplayLatestDegAndCurrent(Motor1positiontext, motor2positiontext, motor1currenttext, motor2currenttext);
            // dbHelper.DisplayLatestDegAndCurrentForCOM5(Motor3positiontext, Motor4positiontext, motor3currenttext, motor4currenttext);

       

            // dbHelper.DisplayLatestDegAndCurrentindicatorForCOM5(
            //    textBoxPositionmotor3,  // Motor-1'in pozisyonu
            //    textBoxPositionmotor4,  // Motor-2'nin pozisyonu
            //    angleTrackBar3, // Motor-1 için TrackBar
            //    angleTrackBar4  // Motor-2 için TrackBar
            //);
            double fin1PositionReferenceDeg = Fin1PositionReferenceDeg;
            double fin2PositionReferenceDeg = Fin2PositionReferenceDeg;
            double fin1CurrentReferenceDeg = Fin1CurrentReferenceDeg;
            double fin2CurrentReferenceDeg = Fin2CurrentReferenceDeg;

            // dbHelper.DisplayLatestDegAndCurrentForCOM5 metodunu çağırıyoruz
            //dbHelper.DisplayLatestDegAndCurrentForCOM5(
            //    Motor3positiontext, // Motor-1'in pozisyonu (fin1)
            //    Motor4positiontext, // Motor-2'nin pozisyonu (fin2)
            //    motor3currenttext,  // Motor-1'in akım değeri (fin1)
            //    motor4currenttext,  // Motor-2'nin akım değeri (fin2)
            //    fin1PositionReferenceDeg, // Form1'den alınan motor verisi
            //    fin2PositionReferenceDeg, // Form1'den alınan motor verisi
            //    fin1CurrentReferenceDeg,  // Form1'den alınan motor verisi
            //    fin2CurrentReferenceDeg   // Form1'den alınan motor verisi
            //);


        }


        private void Parameterbutton_Click(object sender, EventArgs e)
        {
            ErrorPanel.Visible = false;  // Hatalar panelini göster
            Dashboard.Visible = false;
            Parametre.Visible = true;// Başlangıç panelini gizle
            PanelManuelTest.Visible = false;
            otopanel.Visible = false;
            PanelHomepage.Visible = false;
            // TextBox kontrollerini geç
            //  dbHelper.DisplayLatestSystemInformation(MSK1batteryvoltage, msk1cardtemp, msk1systemtyp);
            // dbHelper.DisplayLatestSystemInformationForCOM5(MSK2batteryvoltage, msk2cardtemp, msk2systemtyp);



        }
        private void OtomaticTestButton_Click(object sender, EventArgs e)
        {
            PanelManuelTest.Visible = false;
            ErrorPanel.Visible = false;  // Hatalar panelini göster
            Dashboard.Visible = false;
            Parametre.Visible = false;// Başlangıç panelini gizle
            otopanel.Visible = true;
            PanelHomepage.Visible = false;
            //dbHelper.DisplayLatestDegAndCurrent(motorkonumotomatictext, motor2konumotomatictext, motorakimotomatictext, motorakim2otomatictext);
            //dbHelper.DisplayLatestDegAndCurrentForCOM5(motor3konumotomatictext, motor4konumotomatictext, motor3akimotomatictext, motorakim4otomatictext);
        }
        private void HomePageButton_Click(object sender, EventArgs e)
        {
            PanelManuelTest.Visible = false;
            ErrorPanel.Visible = false;  // Hatalar panelini göster
            Dashboard.Visible = false;
            Parametre.Visible = false;// Başlangıç panelini gizle
            otopanel.Visible = false;
            PanelHomepage.Visible = true;
        }

        // Çıkış butonuna tıklandığında uygulamadan çıkış yapılacak
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();  // Uygulamadan çıkış
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
        private void GenerateAndDisplayRandomPacketEmpty()
        {
            // Rastgele paket oluşturma
            byte[] randomPacket = CreateRandomPacketEmpty();

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
            if (isCurrentControllerChangeValid == 0)
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
            else if (systemAnalysisMode == 1)
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
            byte checkSum = (byte)((0x100 - (byteList.Sum(b => b) & 0xFF)) & 0xFF);
            byteList.Add(checkSum);

            // Sonuç olarak 20 baytlık veri döndürülür (CRC eklenmeyecek)
            return byteList.ToArray();
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
        // Veri alındığında çağrılır
        public void DataReceivedHandler2(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                while (serialport2.BytesToRead > 0)
                {
                    int bytesToRead = serialport2.BytesToRead;
                    byte[] incomingData = new byte[bytesToRead];
                    serialport2.Read(incomingData, 0, bytesToRead);

                    // Gelen veriyi buffer'a ekleyin
                    receivedDataBuffer.AddRange(incomingData);

                    // Eğer gelen veri boyutu, gönderilen veri boyutuna eşitse
                    //sentPacketSize
                    if (receivedDataBuffer.Count == sentPacketSize)
                    {
                        byte[] completePacket = receivedDataBuffer.ToArray();

                        // CRC kontrolü
                        ushort receivedCRC = BitConverter.ToUInt16(completePacket, completePacket.Length - 2); // CRC son 2 byte
                        ushort calculatedCRC = CalculateModbusCRC(completePacket.Take(completePacket.Length - 2).ToArray());

                        if (receivedCRC == calculatedCRC)
                        {
                            // CRC geçerli, veriyi işleyelim ve dataGridViewCrcResults'a yazdıralım
                            Invoke(new Action(() =>
                            {
                                string dataHex = BitConverter.ToString(completePacket).Replace("-", " ");

                                // Gönderilen veri ve CRC bilgilerini dataGridViewCrcResults'e ekleyelim
                                dataGridViewCrcResults.Rows.Add(
                                    dataHex,                        // Gönderilen Veri
                                    $"{calculatedCRC:X4}",           // Hesaplanan CRC (Gönderilen CRC)
                                    dataHex,                        // Alınan Veri
                                    $"{receivedCRC:X4}",             // Alınan CRC
                                              1               // Zaman damgası
                                );
                            }));
                        }
                        else
                        {
                            // CRC hatası varsa sadece listBoxReceivedData'ya yazalım
                            Invoke(new Action(() =>
                            {
                                string dataHex = BitConverter.ToString(completePacket).Replace("-", " ");
                                //listBoxReceivedData.Items.Add($"CRC Hatası! Alınan Veri: {dataHex}, Hesaplanan CRC: {calculatedCRC:X4}, Alınan CRC: {receivedCRC:X4}");

                                // Hata DataGridView'e ekleniyor
                                string protocol = SelectedProtocol2.SelectedItem?.ToString() ?? "Bilinmiyor";
                                string timeStamp = DateTime.Now.ToString("HH:mm:ss");
                                //dataGridViewReceivedData.Rows.Add(timeStamp, protocol, $"CRC Hatası! Alınan Veri: {dataHex}, Hesaplanan CRC: {calculatedCRC:X4}, Alınan CRC: {receivedCRC:X4}");
                            }));
                        }

                        // Gelen veri işlendikten sonra buffer'ı temizleyin
                        receivedDataBuffer.Clear();
                    }
                    else if (receivedDataBuffer.Count > sentPacketSize)
                    {
                        // Gelen veri, gönderilen veriden daha büyükse hata olabilir
                        Invoke(new Action(() =>
                        {
                            string dataHex = BitConverter.ToString(receivedDataBuffer.ToArray()).Replace("-", " ");
                            // listBoxReceivedData.Items.Add($"Fazla Veri Alındı: {dataHex}");

                            // Fazla veri hatasını DataGridView'e ekleyelim
                            string protocol = SelectedProtocol2.SelectedItem?.ToString() ?? "Bilinmiyor";
                            string timeStamp = DateTime.Now.ToString("HH:mm:ss");
                            //dataGridViewReceivedData.Rows.Add(timeStamp, protocol, $"Fazla Veri Alındı: {dataHex}");
                        }));

                        // Fazla veri alındığında buffer'ı temizleyin
                        receivedDataBuffer.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Veri alınırken hata oluştu: " + ex.Message);

                    // Hata durumunda da listBoxReceivedData'ya hata mesajını yazın
                    //listBoxReceivedData.Items.Add($"Veri alınırken hata oluştu: {ex.Message}");

                    // Hata DataGridView'e ekleniyor
                    string protocol = SelectedProtocol2.SelectedItem?.ToString() ?? "Bilinmiyor";
                    string timeStamp = DateTime.Now.ToString("HH:mm:ss");
                    //dataGridViewReceivedData.Rows.Add(timeStamp, protocol, $"Veri alınırken hata oluştu: {ex.Message}");
                }));

                // Herhangi bir hata olduğunda da buffer'ı temizleyin
                receivedDataBuffer.Clear();
            }
        }




        private int sentPacketSize;
        // Veri gönderirken buffer'ın sıfırlanması:
        private void SendText_Click2(object sender, EventArgs e)
        {
            try
            {
                if (serialport2.IsOpen)
                {
                    // Kullanıcının textbox'tan girdiği hex veriyi al
                    string dataToSend = textBoxSendData.Text;

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

                    // Gönderilen veriyi kaydet
                    sentPacketSize = dataBytes.Length; // Gönderilen verinin boyutu

                    // Veriyi seri port üzerinden gönder
                    serialport2.Write(dataBytes, 0, dataBytes.Length);

                    // Gönderilen veriyi logla
                    string dataHex = BitConverter.ToString(dataBytes).Replace("-", " ");
                    Invoke(new Action(() =>
                    {
                        //textBoxCrcResults2.AppendText($"Gönderilen Veri: {dataHex}\r\n");
                    }));

                    textBoxSendData.Clear(); // Gönderilen veriyi temizle
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

        private void buttonOpenPort2_Click(object sender, EventArgs e)
        {
            if (role == "admin")
            {

                try
                {
                    // Eğer aynı port 2. SerialPort'ta açıksa, önce o portu kapat
                    if (serialport.IsOpen && serialport.PortName == comboBoxPorts.SelectedItem.ToString())
                    {
                        serialport.Close();
                        buttonOpenPort2.Text = "Portu Aç";
                    }

                    if (serialport2.IsOpen)
                    {
                        serialport.Close();
                        buttonOpenPort.Text = "Portu Aç";
                    }
                    else
                    {
                        serialport.PortName = comboBoxPorts.SelectedItem.ToString();
                        serialport.BaudRate = 2187500;
                        serialport.Parity = Parity.None;
                        serialport.StopBits = StopBits.One;
                        serialport.DataBits = 8;
                        serialport.Handshake = Handshake.None;
                        serialport.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler2);
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
        // Modbus CRC16 hesaplama fonksiyonu
        public ushort CalculateModbusCRC(byte[] data)
        {
            ushort crc = 0xFFFF;

            for (int pos = 0; pos < data.Length; pos++)
            {
                crc ^= data[pos];

                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            return crc;
        }

        private byte[] CreateModbusWritePacket(byte slaveId, ushort registerAddress, ushort value)
        {
            List<byte> packet = new List<byte>();

            // Slave ID (1 byte)
            packet.Add(slaveId);

            // Function Code (06 - Write Single Register)
            packet.Add(0x06);

            // Register Address (2 bytes - big-endian)
            packet.Add((byte)(registerAddress >> 8)); // High byte
            packet.Add((byte)(registerAddress & 0xFF)); // Low byte

            // Register Value (2 bytes - big-endian)
            packet.Add((byte)(value >> 8)); // High byte
            packet.Add((byte)(value & 0xFF)); // Low byte

            // CRC16 Hesaplama (2 bytes - low byte önce, high byte sonra)
            ushort crc = CalculateModbusCRC(packet.ToArray());
            packet.Add((byte)(crc & 0xFF)); // Low byte
            packet.Add((byte)(crc >> 8)); // High byte

            return packet.ToArray();
        }

        private byte[] CreateModbusReadPacket(byte slaveId, ushort startingAddress, ushort numberOfRegisters)
        {
            List<byte> packet = new List<byte>();

            // Slave ID (1 byte)
            packet.Add(slaveId);

            // Function Code (03 - Read Holding Registers)
            packet.Add(0x03);

            // Starting Address (2 bytes - big-endian)
            packet.Add((byte)(startingAddress >> 8)); // High byte
            packet.Add((byte)(startingAddress & 0xFF)); // Low byte

            // Number of Registers to Read (2 bytes - big-endian)
            packet.Add((byte)(numberOfRegisters >> 8)); // High byte
            packet.Add((byte)(numberOfRegisters & 0xFF)); // Low byte

            // CRC16 Hesaplama (2 bytes - low byte önce, high byte sonra)
            ushort crc = CalculateModbusCRC(packet.ToArray());
            packet.Add((byte)(crc & 0xFF)); // Low byte
            packet.Add((byte)(crc >> 8)); // High byte

            return packet.ToArray();
        }
        // Modbus formatında rastgele veri oluşturan fonksiyon
        private void GenerateAndDisplayRandomModbusPacket()
        {
            // Rastgele bir Modbus write (06) ya da read (03) paketi oluşturabiliriz
            Random random = new Random();

            byte slaveId = (byte)random.Next(1, 255); // 1-255 arasında rastgele bir slave ID
            ushort startingAddress = (ushort)random.Next(0, 65535); // Rastgele register adresi
            ushort numberOfRegisters = (ushort)random.Next(1, 125); // Rastgele bir register sayısı (1-125 arası)

            // Modbus okuma paketi (03) ya da yazma paketi (06) olabilir
            byte[] randomPacket;
            if (random.Next(0, 2) == 0) // %50 ihtimalle okuma paketi
            {
                randomPacket = CreateModbusReadPacket(slaveId, startingAddress, numberOfRegisters);
            }
            else // %50 ihtimalle yazma paketi
            {
                ushort valueToWrite = (ushort)random.Next(0, 65535); // Rastgele bir değer yazılacak
                randomPacket = CreateModbusWritePacket(slaveId, startingAddress, valueToWrite);
            }

            // Oluşturulan rastgele veriyi hex string'e çevirme
            string hexString = BitConverter.ToString(randomPacket).Replace("-", " ");

            // Rastgele veriyi sendbox'a yazdırma
            textBoxSendData.Text = hexString; // Rastgele veriyi USB'ye göndermek için ekrana yazdır
        }


        // Rastgele veri üretilip gösterme işlemi
        private void SelectedProtocol_SelectedIndexChanged2(object sender, EventArgs e)
        {
            if (SelectedProtocol2.SelectedItem.ToString() == "2")
            {
                GenerateAndDisplayRandomModbusPacket(); // Rastgele Modbus verisi oluşturup sendbox'a yazdır
            }
            else
            {
                MessageBox.Show("Geçersiz protokol seçildi.");
            }
        }
        private void buttonSaveTxt_Click(object sender, EventArgs e)
        {
            // txt dosyasına kaydetmek için SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text File|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        // Başlıkları yaz
                        file.WriteLine("Gönderilen Veri\tGönderilen CRC\tAlınan Veri\tAlınan CRC\tZaman");

                        // DataGridView'deki her satırı yaz
                        foreach (DataGridViewRow row in dataGridViewCrcResults.Rows)
                        {
                            // Her hücredeki veriyi oku ve satıra yaz
                            var cells = row.Cells;
                            string line = $"{cells[0].Value}\t{cells[1].Value}\t{cells[2].Value}\t{cells[3].Value}\t{cells[4].Value}";
                            file.WriteLine(line);
                        }
                    }
                    MessageBox.Show("Veriler başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void buttonSaveExcel_Click(object sender, EventArgs e)
        {
            // textBoxCrcResults2'daki veriyi Excel dosyasına kaydet
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel File|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial; // Lisans ayarını yapın

                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("CRC Results");

                        // Başlıkları ekleyin
                        worksheet.Cells[1, 1].Value = "Gönderilen Veri";
                        worksheet.Cells[1, 2].Value = "Gönderilen CRC";
                        worksheet.Cells[1, 3].Value = "Alınan Veri";
                        worksheet.Cells[1, 4].Value = "Alınan CRC";
                        worksheet.Cells[1, 5].Value = "Zaman";

                        // DataGridView'deki verileri işleyip hücrelere yazın
                        for (int i = 0; i < dataGridViewCrcResults.Rows.Count - 1; i++) // Son satır boş olabilir, kontrol ediyoruz
                        {
                            worksheet.Cells[i + 2, 1].Value = dataGridViewCrcResults.Rows[i].Cells[0].Value?.ToString(); // Gönderilen Veri
                            worksheet.Cells[i + 2, 2].Value = dataGridViewCrcResults.Rows[i].Cells[1].Value?.ToString(); // Gönderilen CRC
                            worksheet.Cells[i + 2, 3].Value = dataGridViewCrcResults.Rows[i].Cells[2].Value?.ToString(); // Alınan Veri
                            worksheet.Cells[i + 2, 4].Value = dataGridViewCrcResults.Rows[i].Cells[3].Value?.ToString(); // Alınan CRC
                            worksheet.Cells[i + 2, 5].Value = dataGridViewCrcResults.Rows[i].Cells[4].Value?.ToString(); // Zaman
                        }

                        // Dosyayı kaydet
                        package.SaveAs(new FileInfo(saveFileDialog.FileName));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Excel dosyası kaydedilirken hata oluştu: {ex.Message}");
                }
            }
        }
        private void angleTrackBar_ValueChanged(object sender, EventArgs e)
        {
            // Sınır kontrolü
            if (angleTrackBar.Value < angleTrackBar.Minimum)
            {
                angleTrackBar.Value = angleTrackBar.Minimum;
            }
            else if (angleTrackBar.Value > angleTrackBar.Maximum)
            {
                angleTrackBar.Value = angleTrackBar.Maximum;
            }

            // Motor 1 için TrackBar değeri güncelleniyor ve TextBox'a yazılıyor
            gaugePictureBox.Invalidate(); // Göstergede yenileme
            textBoxPositionmotor1.Text = angleTrackBar.Value.ToString(); // Motor 1 TextBox'ını güncelle
        }
        public void DisplayLatestDegAndCurrentindicator(
    System.Windows.Forms.TextBox fin1PositionReferenceDegTextBox,
    System.Windows.Forms.TextBox fin2PositionReferenceDegTextBox,
    System.Windows.Forms.TrackBar angleTrackBar, // Motor 1 için TrackBar
    System.Windows.Forms.TrackBar angleTrackBar2) // Motor 2 için TrackBar
        {
            // TextBox'ları güncelle
            UpdateTextBoxWithData(fin1PositionReferenceDegTextBox, Fin1PositionReferenceDeg);
            UpdateTextBoxWithData(fin2PositionReferenceDegTextBox, Fin2PositionReferenceDeg);

            // İbreyi güncelle (angleTrackBar'ın değerini, alınan 'deg' değerine göre ayarlıyoruz)
            int fin1Value = (int)Fin1PositionReferenceDeg;
            int fin2Value = (int)Fin2PositionReferenceDeg;

            // Değerlerin sınırları kontrol ediliyor
            if (fin1Value < angleTrackBar.Minimum) fin1Value = angleTrackBar.Minimum;
            if (fin1Value > angleTrackBar.Maximum) fin1Value = angleTrackBar.Maximum;
            if (fin2Value < angleTrackBar2.Minimum) fin2Value = angleTrackBar2.Minimum;
            if (fin2Value > angleTrackBar2.Maximum) fin2Value = angleTrackBar2.Maximum;

            angleTrackBar.Value = fin1Value; // Motor 1 için Fin1PositionReferenceDeg
            angleTrackBar2.Value = fin2Value; // Motor 2 için Fin2PositionReferenceDeg

            angleTrackBar.Invalidate();
            angleTrackBar2.Invalidate();
        }

        private void UpdateTextBoxWithData(System.Windows.Forms.TextBox textBox, double value)
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


        public void DisplayLatestDegAndCurrentindicator2(
   System.Windows.Forms.TextBox fin3PositionReferenceDegTextBox,
   System.Windows.Forms.TextBox fin4PositionReferenceDegTextBox,
   System.Windows.Forms.TrackBar angleTrackBar3, // Motor 1 için TrackBar
   System.Windows.Forms.TrackBar angleTrackBar4) // Motor 2 için TrackBar
        {
            // TextBox'ları güncelle
            UpdateTextBoxWithData2(fin3PositionReferenceDegTextBox, Fin1PositionReferenceDeg);
            UpdateTextBoxWithData2(fin4PositionReferenceDegTextBox, Fin2PositionReferenceDeg);

            // İbreyi güncelle (angleTrackBar'ın değerini, alınan 'deg' değerine göre ayarlıyoruz)
            int fin1Value = (int)Fin1PositionReferenceDeg;
            int fin2Value = (int)Fin2PositionReferenceDeg;

            // Değerlerin sınırları kontrol ediliyor
            if (fin1Value < angleTrackBar3.Minimum) fin1Value = angleTrackBar3.Minimum;
            if (fin1Value > angleTrackBar3.Maximum) fin1Value = angleTrackBar3.Maximum;
            if (fin2Value < angleTrackBar4.Minimum) fin2Value = angleTrackBar4.Minimum;
            if (fin2Value > angleTrackBar4.Maximum) fin2Value = angleTrackBar4.Maximum;

            angleTrackBar3.Value = fin1Value; // Motor 1 için Fin1PositionReferenceDeg
            angleTrackBar4.Value = fin2Value; // Motor 2 için Fin2PositionReferenceDeg

            angleTrackBar3.Invalidate();
            angleTrackBar4.Invalidate();
        }

        private void UpdateTextBoxWithData2(System.Windows.Forms.TextBox textBox, double value)
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


        private void angleTrackBar2_ValueChanged(object sender, EventArgs e)
        {
            // Sınır kontrolü
            if (angleTrackBar2.Value < angleTrackBar2.Minimum)
            {
                angleTrackBar2.Value = angleTrackBar2.Minimum;
            }
            else if (angleTrackBar2.Value > angleTrackBar2.Maximum)
            {
                angleTrackBar2.Value = angleTrackBar2.Maximum;
            }

            // Motor 2 için TrackBar değeri güncelleniyor ve TextBox'a yazılıyor
            gaugePictureBox2.Invalidate(); // Göstergede yenileme
            textBoxPositionmotor2.Text = angleTrackBar2.Value.ToString(); // Motor 2 TextBox'ını güncelle
        }



        private void gaugePictureBox_Paint(object sender, PaintEventArgs e, System.Windows.Forms.TrackBar trackBar)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int centerX = gaugePictureBox.Width / 2;
            int centerY = gaugePictureBox.Height / 2;
            int radius = Math.Min(centerX, centerY) - 20;

            // Gösterge çerçevesi (yatay olarak -15 solda, 15 sağda olacak şekilde)
            using (LinearGradientBrush arcBrush = new LinearGradientBrush(
                new Rectangle(centerX - radius, centerY - radius, radius * 2, radius * 2),
                Color.LightSkyBlue, Color.SteelBlue, LinearGradientMode.Horizontal))
            using (Pen arcPen = new Pen(arcBrush, 12))
            {
                g.DrawArc(arcPen, centerX - radius, centerY - radius, radius * 2, radius * 2, 180, 180);
            }

            // Değer çizgileri ve etiketler için döngü
            for (int i = -15; i <= 15; i++)
            {
                float angle = 180 + ((i + 15) * 180f / 30f); // -15'ten 15'e doğru açı hesaplama
                double radian = angle * Math.PI / 180;

                int tickStartX = centerX + (int)((radius - 12) * Math.Cos(radian));
                int tickStartY = centerY + (int)((radius - 12) * Math.Sin(radian));
                int tickEndX = centerX + (int)(radius * Math.Cos(radian));
                int tickEndY = centerY + (int)(radius * Math.Sin(radian));

                // Çizgi (Tick) çizimi (daha ince ve zarif)
                using (Pen tickPen = new Pen(Color.Gray, i % 5 == 0 ? 3 : 1))
                {
                    g.DrawLine(tickPen, tickStartX, tickStartY, tickEndX, tickEndY);
                }

                // Önemli değerleri göstermek için etiketler
                if (i % 5 == 0)
                {
                    int labelX = centerX + (int)((radius - 25) * Math.Cos(radian));
                    int labelY = centerY + (int)((radius - 25) * Math.Sin(radian));

                    using (Font font = new Font("Arial", 9, FontStyle.Bold))
                    using (SolidBrush textBrush = new SolidBrush(Color.DarkSlateGray))
                    {
                        g.DrawString(i.ToString(), font, textBrush, labelX - 10, labelY - 10);
                    }
                }
            }

            // İbre çizimi
            float needleAngle = 180 + ((trackBar.Value + 15) * 180f / 30f); // İbre açı hesaplama (-15'ten 15'e kadar)
            double needleRadian = needleAngle * Math.PI / 180;
            int needleLength = radius - 30;

            int needleX = centerX + (int)(needleLength * Math.Cos(needleRadian));
            int needleY = centerY + (int)(needleLength * Math.Sin(needleRadian));

            using (Pen needlePen = new Pen(Color.DeepSkyBlue, 5))
            {
                needlePen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                needlePen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
                g.DrawLine(needlePen, centerX, centerY, needleX, needleY);
            }

            // İbre merkezinde modern bir daire
            using (SolidBrush centerBrush = new SolidBrush(Color.SteelBlue))
            {
                g.FillEllipse(centerBrush, centerX - 7, centerY - 7, 14, 14);
            }

            // Açı değerini gösteren modern metin
            using (Font font = new Font("Arial", 11, FontStyle.Bold))
            using (SolidBrush textBrush = new SolidBrush(Color.DarkSlateGray))
            {
                string angleText = $"{trackBar.Value}°";
                g.DrawString(angleText, font, textBrush, centerX - 20, centerY + radius - 30);
            }

            // "KONUM (DEG)" metni için modern font
            using (Font font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic))
            using (SolidBrush textBrush = new SolidBrush(Color.DarkSlateGray))
            {
                string positionText = "KONUM (DEG)";
                g.DrawString(positionText, font, textBrush, centerX - 50, centerY + radius + 30);
            }
        }




        private void MskQueryButton_Click(object sender, EventArgs e)
        {
            dbHelper.DisplayLatestControlParameter(
Msk1KP, Mk1KI, MSK1KD, MSK1AkimKp, MSK1AkimKI, MSK1AkimKD);

        }

        private void Msk2QueryButton_Click(object sender, EventArgs e)
        {
            dbHelper.DisplayLatestControlParameterForCOM5(
Msk2KP, Mk2KI, MSK2KD, MSK2AkimKp, MSK2AkimKI, MSK2AkimKD);
        }
        private FormGraph graphForm;


        private void ManuelTestCommandButton_Click(object sender, EventArgs e)
        {
            TimeZoneInfo istanbulTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Turkey Standard Time");
            DateTime filterDate = TimeZoneInfo.ConvertTime(DateTime.Now, istanbulTimeZone);

            // Assuming dbHelper is already instantiated
            var filteredData = dbHelper.GetFilteredDataHallStateForCOM6(filterDate);

            // Instantiate FormGraph
            graphForm = new FormGraph(filteredData);
            graphForm.FormClosed += (s, args) => graphForm = null; // Reset the reference when the form is closed

            // Show modern message box
            MessageBox.Show("Komut başarıyla gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }




        private void Motor1ManuelGraphButton_Click_1(object sender, EventArgs e)
        {
            if (graphForm != null)
            {
                // Show the graph only if it has been created
                graphForm.Show();
            }
            else
            {
                MessageBox.Show("Lütfen önce Manuel Test Komutunu çalıştırın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



    }
}