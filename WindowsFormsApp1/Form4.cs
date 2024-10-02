using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        SerialPort serialport = new SerialPort();
        private List<byte> receivedDataBuffer = new List<byte>();

        public Form4()
        {
            InitializeComponent();
            GetAvailablePorts();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
           
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialport.IsOpen)
            {
                serialport.Close();
            }
        }

        private void GetAvailablePorts()
        {
            foreach (string port in SerialPort.GetPortNames())
            {
                comboBoxPorts.Items.Add(port);
            }

            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;
        }

        private void buttonOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialport.IsOpen)
                {
                    serialport.Close();
                    buttonOpenPort.Text = "Portu Aç";
                }
                else
                {
                    serialport.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialport.BaudRate = 9600; // Modbus RTU için yaygın baudrate
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

        // Modbus RTU sorgu mesajı oluşturma


        private ushort CalculateCRC(byte[] data, int length)
        {
            ushort crc = 0xFFFF;  // Başlangıç CRC değeri her seferinde sıfırlanır

            // CRC hesaplama öncesi veriyi logla
            string dataHex = BitConverter.ToString(data, 0, length).Replace("-", " ");

            // TextBox erişimini Invoke ile yapalım
            Invoke(new Action(() =>
            {
                textBoxCrcResults.AppendText($"CRC Hesaplaması için veri: {dataHex}\r\n");
            }));

            for (int pos = 0; pos < length; pos++)
            {
                crc ^= (ushort)data[pos]; // CRC ile baytı XOR'la

                for (int i = 8; i != 0; i--)
                {
                    if ((crc & 0x0001) != 0)
                    {
                        crc >>= 1;
                        crc ^= 0xA001;  // CRC-16 için kullanılan polinom
                    }
                    else
                    {
                        crc >>= 1;
                    }
                }
            }

            // Hesaplanan CRC'yi logla
            Invoke(new Action(() =>
            {
                textBoxCrcResults.AppendText($"Hesaplanan CRC: {crc:X4}\r\n");
            }));

            return crc;  // Hesaplanan CRC değerini döndür
        }


        // Veri alındığında çağrılır
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Veri miktarını oku
                int bytesToRead = serialport.BytesToRead;
                byte[] incomingData = new byte[bytesToRead];
                serialport.Read(incomingData, 0, bytesToRead);

                // Gelen veriyi buffer'a ekleyelim
                receivedDataBuffer.AddRange(incomingData);

                // Beklenen veri uzunluğu en az 7 byte (Modbus yanıtı)
                if (receivedDataBuffer.Count >= 7)
                {
                    // Tam veri geldi mi?
                    if (receivedDataBuffer.Count >= 7) // Örneğin: 7 byte
                    {
                        // Alınan veriyi işleyelim
                        ProcessModbusResponse(receivedDataBuffer.ToArray());

                        // Veri işlendiği için buffer'ı temizleyelim
                        receivedDataBuffer.Clear();
                    }
                    else
                    {
                        // Eksik veri var, bir sonraki alımı bekleyelim
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show($"Veri alınırken hata oluştu: {ex.Message}");
                }));
            }
        }

        private void ProcessModbusResponse(byte[] response)
        {
            // Yanıt en az 7 byte uzunluğunda olmalıdır (Modbus + CRC)
            if (response.Length < 7)
            {
                MessageBox.Show("Eksik yanıt verisi alındı!");
                return;
            }

            // Yanıt verisini logla
            string responseHex = BitConverter.ToString(response).Replace("-", " ");
            Invoke(new Action(() =>
            {
                textBoxCrcResults.AppendText($"Alınan Yanıt: {responseHex}\r\n");
            }));

            // Son iki byte CRC olduğu için, onlardan önceki kısmın CRC'sini hesaplayalım
            ushort crc = CalculateCRC(response, response.Length - 2);

            // CRC kontrolü yap (Little-endian olduğundan son iki byte'ı ters şekilde birleştiriyoruz)
            ushort receivedCrc = (ushort)((response[response.Length - 2]) | (response[response.Length - 1] << 8));

            // CRC'yi input kutusuna yazdıralım
            Invoke(new Action(() =>
            {
                textBoxCrcResults.AppendText($"Beklenen CRC: {crc:X4}, Alınan CRC: {receivedCrc:X4}\r\n");
            }));

            if (crc != receivedCrc)
            {
                Invoke(new Action(() =>
                {
                    MessageBox.Show($"CRC Hatası! Beklenen CRC: {crc:X4}, Alınan CRC: {receivedCrc:X4}");
                }));
                return;
            }

            // Modbus yanıtını işleme
            string messageHex = BitConverter.ToString(response).Replace("-", " ");
            string timeStamp = DateTime.Now.ToString("HH:mm:ss.fff");

            Invoke(new Action(() =>
            {
                ListViewItem item = new ListViewItem(new[] { messageHex, timeStamp });
               
            }));
        }


        private byte[] CreateModbusRequest(byte slaveAddress, byte functionCode, ushort startAddress, ushort numberOfPoints)
        {
            byte[] request = new byte[6];  // CRC için 2 byte daha eklenmeyecek

            request[0] = slaveAddress;               // Slave adresi
            request[1] = functionCode;               // Fonksiyon kodu (03: Register okuma)
            request[2] = (byte)(startAddress >> 8);  // Başlangıç adresi (MSB)
            request[3] = (byte)(startAddress & 0xFF); // Başlangıç adresi (LSB)
            request[4] = (byte)(numberOfPoints >> 8); // Okunacak register sayısı (MSB)
            request[5] = (byte)(numberOfPoints & 0xFF); // Okunacak register sayısı (LSB)

            return request;  // CRC eklenmeden döndürülüyor
        }
        // Gönderilecek veriyi oluşturup ekrana yazdıran fonksiyon
       
        // SelectedProtocol değiştiğinde işlemleri yapma
        private void SelectedProtocol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedProtocol.SelectedItem.ToString() == "1")
            {
                GenerateAndDisplayModbusRequest(); // Modbus isteğini input kutusuna yazdır
            }
            else
            {
                // Diğer seçenekler için işlemler buraya eklenebilir
            }
        }

        // Gönderme işlemi
        private void GenerateAndDisplayModbusRequest()
        {
            // Modbus isteği için test verileri
            byte slaveAddress = 0x01;          // Örneğin 1 numaralı slave
            byte functionCode = 0x03;          // 03: Holding Register okuma fonksiyonu
            ushort startAddress = 0x0000;      // Başlangıç adresi (register 0)
            ushort numberOfPoints = 0x0002;    // Okunacak register sayısı (2)

            // Modbus isteğini oluştur
            byte[] modbusRequest = CreateModbusRequest(slaveAddress, functionCode, startAddress, numberOfPoints);

            // Mesajı görüntülemek için hex string'e çevirme
            string hexString = BitConverter.ToString(modbusRequest).Replace("-", " ");
            textBoxSendData.Text = hexString; // Veriyi input kutusuna yazdır
        }

        private void SendText_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialport.IsOpen)
                {
                    // textBoxSendData'dan veriyi alıp seri port üzerinden gönder
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

                    // CRC'yi sadece burada hesapla ve byte dizisine ekle
                    ushort crc = CalculateCRC(dataBytes, dataBytes.Length); // CRC'yi hesapla
                    byte[] crcBytes = new byte[] { (byte)(crc & 0xFF), (byte)(crc >> 8) };  // Little Endian sıralamasına göre ekle

                    // CRC'yi dataBytes'e ekle
                    byte[] modbusRequestWithCRC = dataBytes.Concat(crcBytes).ToArray(); // CRC'yi ekle

                    // Gönderilen veriyi ve hesaplanan CRC'yi logla
                    string dataHex = BitConverter.ToString(modbusRequestWithCRC).Replace("-", " ");
                    Invoke(new Action(() =>
                    {
                        textBoxCrcResults.AppendText($"Gönderilen Veri: {dataHex}\r\n");
                        textBoxCrcResults.AppendText($"CRC Hesaplaması için veri: {BitConverter.ToString(dataBytes).Replace("-", " ")}\r\n");
                        textBoxCrcResults.AppendText($"Hesaplanan CRC: {crc:X4}\r\n");
                    }));

                    // Veriyi seri port üzerinden gönder
                    serialport.Write(modbusRequestWithCRC, 0, modbusRequestWithCRC.Length); // CRC eklenmiş veriyi gönder

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


        private void LoadFormInPanel(Form form, Panel panel)
        {
            form.TopLevel = false;  // Form'un pencere olarak değil, bir kontrol olarak davranmasını sağla
            form.FormBorderStyle = FormBorderStyle.None;  // Form çerçevesini kaldır
            form.Dock = DockStyle.Fill;  // Formu panelin tamamını kaplayacak şekilde ayarla
            panel.Controls.Clear();  // Paneldeki eski içerikleri temizle
            panel.Controls.Add(form);  // Formu panele ekle
            form.Show();  // Formu göster
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

            // Protokol1 seçildiğinde Form1'i aç
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide(); // Mevcut formu gizle (İsteğe bağlı)
            serialport.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // Protokol2 seçildiğinde Form2'yi aç
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide(); // Mevcut formu gizle (İsteğe bağlı)
        }

    }
}


