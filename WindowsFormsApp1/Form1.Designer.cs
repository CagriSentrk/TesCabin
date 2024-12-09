using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox groupBoxProtocol1; // Protokol 1 için grup kutusu
        private System.Windows.Forms.GroupBox groupBoxProtocol2;
        private System.Windows.Forms.Button personelButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.TrackBar angleTrackBar2;
        private System.Windows.Forms.PictureBox gaugePictureBox2;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPositionmotor1;
        private System.Windows.Forms.Panel radioPanel;

        private System.Windows.Forms.TableLayoutPanel errortablelayout;

        private RadioButton hata1RadioButton;
        private RadioButton hata2RadioButton;
        private RadioButton hata3RadioButton;
        private RadioButton hata4RadioButton;
        private RadioButton hata5RadioButton;
        private RadioButton hata6RadioButton;
        private RadioButton hata7RadioButton;
        private RadioButton hata8RadioButton;
        private RadioButton hata9RadioButton;
        private RadioButton hata10RadioButton;
        private RadioButton hata11RadioButton;
        private RadioButton hata12RadioButton;
        private RadioButton hata13RadioButton;
        private RadioButton hata14RadioButton;
        private RadioButton hata15RadioButton;



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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.textBoxCrcResults = new System.Windows.Forms.TextBox();
            this.groupBoxProtocol1 = new System.Windows.Forms.GroupBox();
            this.groupBoxProtocol2 = new System.Windows.Forms.GroupBox();
            this.adminButton = new System.Windows.Forms.Button();
            this.personelButton = new System.Windows.Forms.Button();
            this.Dashboard = new System.Windows.Forms.Panel();
            this.SendText3 = new System.Windows.Forms.Button();
            this.SelectedProtocol3 = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort3 = new System.Windows.Forms.Button();
            this.timetextbox = new System.Windows.Forms.TextBox();
            this.mesajtext = new System.Windows.Forms.TextBox();
            this.SendText2 = new System.Windows.Forms.Button();
            this.buttonOpenPort2 = new System.Windows.Forms.Button();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.SelectedProtocol = new System.Windows.Forms.ComboBox();
            this.SendText = new System.Windows.Forms.Button();
            this.textBoxSendData = new System.Windows.Forms.TextBox();
            this.SelectedProtocol2 = new System.Windows.Forms.ComboBox();
            this.ErrorPanel = new System.Windows.Forms.Panel();
            this.DataGridErrormotor1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn65 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorstatuspaneltitle = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.MSK2paneltitle = new System.Windows.Forms.Panel();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.MSK1paneltitle = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridViewTextBoxColumn60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn61 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn63 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn64 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn56 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn57 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn58 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn46 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn47 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn48 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn49 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn50 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn51 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn52 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProtocol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnErrorMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelManuelTest = new System.Windows.Forms.Panel();
            this.Motor4DegParametertext = new System.Windows.Forms.TextBox();
            this.Motor3DegParametertext = new System.Windows.Forms.TextBox();
            this.Motor2DegParametertext = new System.Windows.Forms.TextBox();
            this.Motor1DegParametertext = new System.Windows.Forms.TextBox();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.button34 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.textBoxPositionmotor4 = new System.Windows.Forms.TextBox();
            this.textBoxPositionmotor3 = new System.Windows.Forms.TextBox();
            this.textBoxPositionmotor2 = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.textBoxPositionmotor1 = new System.Windows.Forms.TextBox();
            this.button28 = new System.Windows.Forms.Button();
            this.angleTrackBar4 = new System.Windows.Forms.TrackBar();
            this.gaugePictureBox4 = new System.Windows.Forms.PictureBox();
            this.angleTrackBar3 = new System.Windows.Forms.TrackBar();
            this.gaugePictureBox3 = new System.Windows.Forms.PictureBox();
            this.angleTrackBar2 = new System.Windows.Forms.TrackBar();
            this.angleTrackBar = new System.Windows.Forms.TrackBar();
            this.gaugePictureBox2 = new System.Windows.Forms.PictureBox();
            this.gaugePictureBox = new System.Windows.Forms.PictureBox();
            this.label59 = new System.Windows.Forms.Label();
            this.ManuelTestMotor = new System.Windows.Forms.Panel();
            this.motor4konum = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.motor3konum = new System.Windows.Forms.Label();
            this.motor3akim = new System.Windows.Forms.Label();
            this.motor4currenttext = new System.Windows.Forms.TextBox();
            this.motor3currenttext = new System.Windows.Forms.TextBox();
            this.Motor4positiontext = new System.Windows.Forms.TextBox();
            this.Motor3positiontext = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.Motor1ManuelGraphButton = new System.Windows.Forms.Button();
            this.label60 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox46 = new System.Windows.Forms.TextBox();
            this.textBox45 = new System.Windows.Forms.TextBox();
            this.textBox44 = new System.Windows.Forms.TextBox();
            this.textBox43 = new System.Windows.Forms.TextBox();
            this.ManuelTestCommandButton = new System.Windows.Forms.Button();
            this.motor2konum = new System.Windows.Forms.Label();
            this.motor2akim = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.motor1akim = new System.Windows.Forms.Label();
            this.textBox42 = new System.Windows.Forms.TextBox();
            this.textBox41 = new System.Windows.Forms.TextBox();
            this.motor2currenttext = new System.Windows.Forms.TextBox();
            this.motor1currenttext = new System.Windows.Forms.TextBox();
            this.motor2positiontext = new System.Windows.Forms.TextBox();
            this.Motor1positiontext = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Motor4Enabledbutton = new System.Windows.Forms.RadioButton();
            this.Motor2Enabledbutton = new System.Windows.Forms.RadioButton();
            this.Motor3Enabledbutton = new System.Windows.Forms.RadioButton();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.Motor1Enabledbutton = new System.Windows.Forms.RadioButton();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.navbar = new System.Windows.Forms.Panel();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.textBox66 = new System.Windows.Forms.TextBox();
            this.OtomaticTestButton = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ErrorPanelButton = new System.Windows.Forms.Button();
            this.ParametreButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.KP2 = new System.Windows.Forms.TextBox();
            this.KP3 = new System.Windows.Forms.TextBox();
            this.msk1label = new System.Windows.Forms.Label();
            this.Msk1panel = new System.Windows.Forms.Panel();
            this.MSK1AkimKD = new System.Windows.Forms.TextBox();
            this.MSK1AkimKI = new System.Windows.Forms.TextBox();
            this.MSK1AkimKp = new System.Windows.Forms.TextBox();
            this.MSK1KD = new System.Windows.Forms.TextBox();
            this.Mk1KI = new System.Windows.Forms.TextBox();
            this.Msk1KP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.PositionControlParameter = new System.Windows.Forms.TextBox();
            this.Mskchange2Button = new System.Windows.Forms.Button();
            this.MskQueryButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Otomatictestpanel = new System.Windows.Forms.Panel();
            this.textBox49 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox69 = new System.Windows.Forms.TextBox();
            this.msk1systemtyp = new System.Windows.Forms.TextBox();
            this.msk1cardtemp = new System.Windows.Forms.TextBox();
            this.MSK1batteryvoltage = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.Parametre = new System.Windows.Forms.Panel();
            this.textBox51 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox73 = new System.Windows.Forms.TextBox();
            this.msk2systemtyp = new System.Windows.Forms.TextBox();
            this.msk2cardtemp = new System.Windows.Forms.TextBox();
            this.MSK2batteryvoltage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.MSK2AkimKD = new System.Windows.Forms.TextBox();
            this.MSK2AkimKI = new System.Windows.Forms.TextBox();
            this.MSK2AkimKp = new System.Windows.Forms.TextBox();
            this.MSK2KD = new System.Windows.Forms.TextBox();
            this.Mk2KI = new System.Windows.Forms.TextBox();
            this.Msk2KP = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.button16 = new System.Windows.Forms.Button();
            this.label31 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button23 = new System.Windows.Forms.Button();
            this.Msk2QueryButton = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblWarning = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.textBox50 = new System.Windows.Forms.TextBox();
            this.textBox53 = new System.Windows.Forms.TextBox();
            this.label74 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.textBox54 = new System.Windows.Forms.TextBox();
            this.textBox55 = new System.Windows.Forms.TextBox();
            this.motorakim4otomatictext = new System.Windows.Forms.TextBox();
            this.motorakim2otomatictext = new System.Windows.Forms.TextBox();
            this.motor3akimotomatictext = new System.Windows.Forms.TextBox();
            this.motorakimotomatictext = new System.Windows.Forms.TextBox();
            this.motor4konumotomatictext = new System.Windows.Forms.TextBox();
            this.motor2konumotomatictext = new System.Windows.Forms.TextBox();
            this.motor3konumotomatictext = new System.Windows.Forms.TextBox();
            this.motorkonumotomatictext = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.radioButton7 = new System.Windows.Forms.RadioButton();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.radioButton8 = new System.Windows.Forms.RadioButton();
            this.textBox65 = new System.Windows.Forms.TextBox();
            this.lblFlowDescription = new System.Windows.Forms.Label();
            this.otomatictestchoise = new System.Windows.Forms.Panel();
            this.txtEncoderLimit = new System.Windows.Forms.TextBox();
            this.btnApplyHighCurrent = new System.Windows.Forms.Button();
            this.chkHighCurrent = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblEncoder = new System.Windows.Forms.Label();
            this.txtCurrentLimit = new System.Windows.Forms.TextBox();
            this.lblCurrent = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.lblTester = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtTester = new System.Windows.Forms.TextBox();
            this.cmbTest = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.otopanel = new System.Windows.Forms.Panel();
            this.label78 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn37 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn39 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn40 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn45 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanelHomepage = new System.Windows.Forms.Panel();
            this.label83 = new System.Windows.Forms.Label();
            this.msk2packetpanel = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.comboBox13 = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.comboBox14 = new System.Windows.Forms.ComboBox();
            this.radioPanel2 = new System.Windows.Forms.Panel();
            this.label82 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.msk1packetpanel = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.systemanalysismode = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.comboBox12 = new System.Windows.Forms.ComboBox();
            this.radioPanel = new System.Windows.Forms.Panel();
            this.comboBoxPorts3 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxPorts2 = new System.Windows.Forms.ComboBox();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.groupBoxCrcResults = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonSaveExcel = new System.Windows.Forms.Button();
            this.buttonSaveTxt = new System.Windows.Forms.Button();
            this.dataGridViewCrcResults = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGriderrormotor2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn66 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridErrormotor1)).BeginInit();
            this.errorstatuspaneltitle.SuspendLayout();
            this.MSK2paneltitle.SuspendLayout();
            this.MSK1paneltitle.SuspendLayout();
            this.PanelManuelTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox)).BeginInit();
            this.ManuelTestMotor.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.navbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.Msk1panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Parametre.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.otomatictestchoise.SuspendLayout();
            this.otopanel.SuspendLayout();
            this.PanelHomepage.SuspendLayout();
            this.msk2packetpanel.SuspendLayout();
            this.msk1packetpanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxCrcResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrcResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriderrormotor2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCrcResults
            // 
            this.textBoxCrcResults.Location = new System.Drawing.Point(0, 0);
            this.textBoxCrcResults.Name = "textBoxCrcResults";
            this.textBoxCrcResults.Size = new System.Drawing.Size(100, 22);
            this.textBoxCrcResults.TabIndex = 0;
            // 
            // groupBoxProtocol1
            // 
            this.groupBoxProtocol1.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxProtocol1.Location = new System.Drawing.Point(30, 50);
            this.groupBoxProtocol1.Name = "groupBoxProtocol1";
            this.groupBoxProtocol1.Size = new System.Drawing.Size(700, 400);
            this.groupBoxProtocol1.TabIndex = 0;
            this.groupBoxProtocol1.TabStop = false;
            this.groupBoxProtocol1.Text = "Protokol 1";
            // 
            // groupBoxProtocol2
            // 
            this.groupBoxProtocol2.ForeColor = System.Drawing.Color.Lime;
            this.groupBoxProtocol2.Location = new System.Drawing.Point(800, 50);
            this.groupBoxProtocol2.Name = "groupBoxProtocol2";
            this.groupBoxProtocol2.Size = new System.Drawing.Size(700, 400);
            this.groupBoxProtocol2.TabIndex = 0;
            this.groupBoxProtocol2.TabStop = false;
            this.groupBoxProtocol2.Text = "Protokol 2";
            // 
            // adminButton
            // 
            this.adminButton.Location = new System.Drawing.Point(0, 0);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(75, 23);
            this.adminButton.TabIndex = 0;
            // 
            // personelButton
            // 
            this.personelButton.Location = new System.Drawing.Point(0, 0);
            this.personelButton.Name = "personelButton";
            this.personelButton.Size = new System.Drawing.Size(75, 23);
            this.personelButton.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Dashboard.Location = new System.Drawing.Point(239, 3);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(1788, 1034);
            this.Dashboard.TabIndex = 19;
            // 
            // SendText3
            // 
            this.SendText3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendText3.ForeColor = System.Drawing.Color.White;
            this.SendText3.Location = new System.Drawing.Point(836, 52);
            this.SendText3.Name = "SendText3";
            this.SendText3.Size = new System.Drawing.Size(68, 23);
            this.SendText3.TabIndex = 25;
            this.SendText3.Text = "SEND";
            this.SendText3.UseVisualStyleBackColor = true;
            this.SendText3.Click += new System.EventHandler(this.SendText_Click3);
            // 
            // SelectedProtocol3
            // 
            this.SelectedProtocol3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SelectedProtocol3.ForeColor = System.Drawing.Color.White;
            this.SelectedProtocol3.FormattingEnabled = true;
            this.SelectedProtocol3.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SelectedProtocol3.Location = new System.Drawing.Point(570, 54);
            this.SelectedProtocol3.Name = "SelectedProtocol3";
            this.SelectedProtocol3.Size = new System.Drawing.Size(241, 24);
            this.SelectedProtocol3.TabIndex = 24;
            this.SelectedProtocol3.SelectedIndexChanged += new System.EventHandler(this.SelectedProtocol_SelectedIndexChanged3);
            // 
            // buttonOpenPort3
            // 
            this.buttonOpenPort3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenPort3.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort3.Location = new System.Drawing.Point(468, 54);
            this.buttonOpenPort3.Name = "buttonOpenPort3";
            this.buttonOpenPort3.Size = new System.Drawing.Size(75, 28);
            this.buttonOpenPort3.TabIndex = 23;
            this.buttonOpenPort3.Text = "Open";
            this.buttonOpenPort3.UseVisualStyleBackColor = true;
            this.buttonOpenPort3.Click += new System.EventHandler(this.buttonOpenPort_Click3);
            // 
            // timetextbox
            // 
            this.timetextbox.Location = new System.Drawing.Point(256, 243);
            this.timetextbox.Name = "timetextbox";
            this.timetextbox.Size = new System.Drawing.Size(226, 22);
            this.timetextbox.TabIndex = 21;
            // 
            // mesajtext
            // 
            this.mesajtext.Location = new System.Drawing.Point(256, 275);
            this.mesajtext.Name = "mesajtext";
            this.mesajtext.Size = new System.Drawing.Size(226, 22);
            this.mesajtext.TabIndex = 20;
            // 
            // SendText2
            // 
            this.SendText2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendText2.ForeColor = System.Drawing.Color.White;
            this.SendText2.Location = new System.Drawing.Point(836, 88);
            this.SendText2.Name = "SendText2";
            this.SendText2.Size = new System.Drawing.Size(68, 23);
            this.SendText2.TabIndex = 13;
            this.SendText2.Text = "SEND";
            this.SendText2.UseVisualStyleBackColor = true;
            this.SendText2.Click += new System.EventHandler(this.SendText_Click2);
            // 
            // buttonOpenPort2
            // 
            this.buttonOpenPort2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenPort2.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort2.Location = new System.Drawing.Point(467, 89);
            this.buttonOpenPort2.Name = "buttonOpenPort2";
            this.buttonOpenPort2.Size = new System.Drawing.Size(75, 28);
            this.buttonOpenPort2.TabIndex = 11;
            this.buttonOpenPort2.Text = "Open";
            this.buttonOpenPort2.UseVisualStyleBackColor = true;
            this.buttonOpenPort2.Click += new System.EventHandler(this.buttonOpenPort_Click2);
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(205)))), ((int)(((byte)(50)))));
            this.buttonOpenPort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOpenPort.ForeColor = System.Drawing.Color.White;
            this.buttonOpenPort.Location = new System.Drawing.Point(468, 21);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(75, 27);
            this.buttonOpenPort.TabIndex = 1;
            this.buttonOpenPort.Text = "Open";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // SelectedProtocol
            // 
            this.SelectedProtocol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SelectedProtocol.ForeColor = System.Drawing.Color.White;
            this.SelectedProtocol.FormattingEnabled = true;
            this.SelectedProtocol.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SelectedProtocol.Location = new System.Drawing.Point(570, 21);
            this.SelectedProtocol.Name = "SelectedProtocol";
            this.SelectedProtocol.Size = new System.Drawing.Size(241, 24);
            this.SelectedProtocol.TabIndex = 6;
            this.SelectedProtocol.SelectedIndexChanged += new System.EventHandler(this.SelectedProtocol_SelectedIndexChanged);
            // 
            // SendText
            // 
            this.SendText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(130)))), ((int)(((byte)(180)))));
            this.SendText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendText.ForeColor = System.Drawing.Color.White;
            this.SendText.Location = new System.Drawing.Point(836, 23);
            this.SendText.Name = "SendText";
            this.SendText.Size = new System.Drawing.Size(68, 23);
            this.SendText.TabIndex = 3;
            this.SendText.Text = "SEND";
            this.SendText.UseVisualStyleBackColor = true;
            this.SendText.Click += new System.EventHandler(this.SendText_Click);
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxSendData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSendData.ForeColor = System.Drawing.Color.White;
            this.textBoxSendData.Location = new System.Drawing.Point(330, 165);
            this.textBoxSendData.Multiline = true;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.Size = new System.Drawing.Size(548, 65);
            this.textBoxSendData.TabIndex = 4;
            // 
            // SelectedProtocol2
            // 
            this.SelectedProtocol2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SelectedProtocol2.ForeColor = System.Drawing.Color.White;
            this.SelectedProtocol2.FormattingEnabled = true;
            this.SelectedProtocol2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.SelectedProtocol2.Location = new System.Drawing.Point(570, 89);
            this.SelectedProtocol2.Name = "SelectedProtocol2";
            this.SelectedProtocol2.Size = new System.Drawing.Size(241, 24);
            this.SelectedProtocol2.TabIndex = 15;
            this.SelectedProtocol2.SelectedIndexChanged += new System.EventHandler(this.SelectedProtocol_SelectedIndexChanged2);
            // 
            // ErrorPanel
            // 
            this.ErrorPanel.BackColor = System.Drawing.Color.White;
            this.ErrorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ErrorPanel.Controls.Add(this.DataGriderrormotor2);
            this.ErrorPanel.Controls.Add(this.DataGridErrormotor1);
            this.ErrorPanel.Controls.Add(this.errorstatuspaneltitle);
            this.ErrorPanel.Controls.Add(this.MSK2paneltitle);
            this.ErrorPanel.Controls.Add(this.MSK1paneltitle);
            this.ErrorPanel.Location = new System.Drawing.Point(239, 0);
            this.ErrorPanel.Name = "ErrorPanel";
            this.ErrorPanel.Size = new System.Drawing.Size(1788, 1037);
            this.ErrorPanel.TabIndex = 20;
            // 
            // DataGridErrormotor1
            // 
            this.DataGridErrormotor1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridErrormotor1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DataGridErrormotor1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridErrormotor1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            this.DataGridErrormotor1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridErrormotor1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridErrormotor1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn65});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridErrormotor1.DefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridErrormotor1.EnableHeadersVisualStyles = false;
            this.DataGridErrormotor1.GridColor = System.Drawing.Color.Gray;
            this.DataGridErrormotor1.Location = new System.Drawing.Point(-1, 132);
            this.DataGridErrormotor1.Name = "DataGridErrormotor1";
            this.DataGridErrormotor1.RowHeadersWidth = 30;
            this.DataGridErrormotor1.RowTemplate.Height = 35;
            this.DataGridErrormotor1.Size = new System.Drawing.Size(407, 780);
            this.DataGridErrormotor1.TabIndex = 24;
            // 
            // dataGridViewTextBoxColumn65
            // 
            this.dataGridViewTextBoxColumn65.HeaderText = "Motor-1";
            this.dataGridViewTextBoxColumn65.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn65.Name = "dataGridViewTextBoxColumn65";
            // 
            // errorstatuspaneltitle
            // 
            this.errorstatuspaneltitle.BackColor = System.Drawing.Color.Transparent;
            this.errorstatuspaneltitle.Controls.Add(this.richTextBox3);
            this.errorstatuspaneltitle.Location = new System.Drawing.Point(19, 13);
            this.errorstatuspaneltitle.Margin = new System.Windows.Forms.Padding(5);
            this.errorstatuspaneltitle.Name = "errorstatuspaneltitle";
            this.errorstatuspaneltitle.Padding = new System.Windows.Forms.Padding(10);
            this.errorstatuspaneltitle.Size = new System.Drawing.Size(1756, 42);
            this.errorstatuspaneltitle.TabIndex = 0;
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.White;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox3.ForeColor = System.Drawing.Color.Black;
            this.richTextBox3.Location = new System.Drawing.Point(705, 5);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(253, 34);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "HATA DURUMLARI";
            // 
            // MSK2paneltitle
            // 
            this.MSK2paneltitle.BackColor = System.Drawing.Color.Transparent;
            this.MSK2paneltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MSK2paneltitle.Controls.Add(this.richTextBox2);
            this.MSK2paneltitle.Location = new System.Drawing.Point(808, 74);
            this.MSK2paneltitle.Margin = new System.Windows.Forms.Padding(5);
            this.MSK2paneltitle.Name = "MSK2paneltitle";
            this.MSK2paneltitle.Padding = new System.Windows.Forms.Padding(10);
            this.MSK2paneltitle.Size = new System.Drawing.Size(655, 60);
            this.MSK2paneltitle.TabIndex = 22;
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.White;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox2.Location = new System.Drawing.Point(325, 24);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(172, 31);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "MSK-2";
            // 
            // MSK1paneltitle
            // 
            this.MSK1paneltitle.BackColor = System.Drawing.Color.Transparent;
            this.MSK1paneltitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MSK1paneltitle.Controls.Add(this.richTextBox1);
            this.MSK1paneltitle.Location = new System.Drawing.Point(1, 74);
            this.MSK1paneltitle.Margin = new System.Windows.Forms.Padding(5);
            this.MSK1paneltitle.Name = "MSK1paneltitle";
            this.MSK1paneltitle.Padding = new System.Windows.Forms.Padding(10);
            this.MSK1paneltitle.Size = new System.Drawing.Size(805, 60);
            this.MSK1paneltitle.TabIndex = 23;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.richTextBox1.Location = new System.Drawing.Point(363, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 33);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "MSK-1";
            // 
            // dataGridViewTextBoxColumn60
            // 
            this.dataGridViewTextBoxColumn60.HeaderText = "Gönderilen Veri";
            this.dataGridViewTextBoxColumn60.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn60.Name = "dataGridViewTextBoxColumn60";
            this.dataGridViewTextBoxColumn60.Width = 125;
            // 
            // dataGridViewTextBoxColumn61
            // 
            this.dataGridViewTextBoxColumn61.HeaderText = "Gönderilen CRC";
            this.dataGridViewTextBoxColumn61.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn61.Name = "dataGridViewTextBoxColumn61";
            this.dataGridViewTextBoxColumn61.Width = 125;
            // 
            // dataGridViewTextBoxColumn62
            // 
            this.dataGridViewTextBoxColumn62.HeaderText = "Alınan Veri";
            this.dataGridViewTextBoxColumn62.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn62.Name = "dataGridViewTextBoxColumn62";
            this.dataGridViewTextBoxColumn62.Width = 125;
            // 
            // dataGridViewTextBoxColumn63
            // 
            this.dataGridViewTextBoxColumn63.HeaderText = "Alınan CRC";
            this.dataGridViewTextBoxColumn63.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn63.Name = "dataGridViewTextBoxColumn63";
            this.dataGridViewTextBoxColumn63.Width = 125;
            // 
            // dataGridViewTextBoxColumn64
            // 
            this.dataGridViewTextBoxColumn64.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn64.HeaderText = "Zaman";
            this.dataGridViewTextBoxColumn64.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn64.Name = "dataGridViewTextBoxColumn64";
            // 
            // dataGridViewTextBoxColumn53
            // 
            this.dataGridViewTextBoxColumn53.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
            this.dataGridViewTextBoxColumn53.Width = 125;
            // 
            // dataGridViewTextBoxColumn54
            // 
            this.dataGridViewTextBoxColumn54.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
            this.dataGridViewTextBoxColumn54.Width = 125;
            // 
            // dataGridViewTextBoxColumn55
            // 
            this.dataGridViewTextBoxColumn55.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
            this.dataGridViewTextBoxColumn55.Width = 125;
            // 
            // dataGridViewTextBoxColumn56
            // 
            this.dataGridViewTextBoxColumn56.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn56.Name = "dataGridViewTextBoxColumn56";
            this.dataGridViewTextBoxColumn56.Width = 125;
            // 
            // dataGridViewTextBoxColumn57
            // 
            this.dataGridViewTextBoxColumn57.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn57.Name = "dataGridViewTextBoxColumn57";
            this.dataGridViewTextBoxColumn57.Width = 125;
            // 
            // dataGridViewTextBoxColumn58
            // 
            this.dataGridViewTextBoxColumn58.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn58.Name = "dataGridViewTextBoxColumn58";
            this.dataGridViewTextBoxColumn58.Width = 125;
            // 
            // dataGridViewTextBoxColumn59
            // 
            this.dataGridViewTextBoxColumn59.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn59.Name = "dataGridViewTextBoxColumn59";
            this.dataGridViewTextBoxColumn59.Width = 125;
            // 
            // dataGridViewTextBoxColumn46
            // 
            this.dataGridViewTextBoxColumn46.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn46.Name = "dataGridViewTextBoxColumn46";
            this.dataGridViewTextBoxColumn46.Width = 125;
            // 
            // dataGridViewTextBoxColumn47
            // 
            this.dataGridViewTextBoxColumn47.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn47.Name = "dataGridViewTextBoxColumn47";
            this.dataGridViewTextBoxColumn47.Width = 125;
            // 
            // dataGridViewTextBoxColumn48
            // 
            this.dataGridViewTextBoxColumn48.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn48.Name = "dataGridViewTextBoxColumn48";
            this.dataGridViewTextBoxColumn48.Width = 125;
            // 
            // dataGridViewTextBoxColumn49
            // 
            this.dataGridViewTextBoxColumn49.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn49.Name = "dataGridViewTextBoxColumn49";
            this.dataGridViewTextBoxColumn49.Width = 125;
            // 
            // dataGridViewTextBoxColumn50
            // 
            this.dataGridViewTextBoxColumn50.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn50.Name = "dataGridViewTextBoxColumn50";
            this.dataGridViewTextBoxColumn50.Width = 125;
            // 
            // dataGridViewTextBoxColumn51
            // 
            this.dataGridViewTextBoxColumn51.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn51.Name = "dataGridViewTextBoxColumn51";
            this.dataGridViewTextBoxColumn51.Width = 125;
            // 
            // dataGridViewTextBoxColumn52
            // 
            this.dataGridViewTextBoxColumn52.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn52.Name = "dataGridViewTextBoxColumn52";
            this.dataGridViewTextBoxColumn52.Width = 125;
            // 
            // ColumnTime
            // 
            this.ColumnTime.MinimumWidth = 6;
            this.ColumnTime.Name = "ColumnTime";
            this.ColumnTime.Width = 125;
            // 
            // ColumnProtocol
            // 
            this.ColumnProtocol.MinimumWidth = 6;
            this.ColumnProtocol.Name = "ColumnProtocol";
            this.ColumnProtocol.Width = 125;
            // 
            // ColumnErrorMessage
            // 
            this.ColumnErrorMessage.MinimumWidth = 6;
            this.ColumnErrorMessage.Name = "ColumnErrorMessage";
            this.ColumnErrorMessage.Width = 125;
            // 
            // PanelManuelTest
            // 
            this.PanelManuelTest.BackColor = System.Drawing.Color.White;
            this.PanelManuelTest.Controls.Add(this.Motor4DegParametertext);
            this.PanelManuelTest.Controls.Add(this.Motor3DegParametertext);
            this.PanelManuelTest.Controls.Add(this.Motor2DegParametertext);
            this.PanelManuelTest.Controls.Add(this.Motor1DegParametertext);
            this.PanelManuelTest.Controls.Add(this.textBox36);
            this.PanelManuelTest.Controls.Add(this.textBox35);
            this.PanelManuelTest.Controls.Add(this.textBox34);
            this.PanelManuelTest.Controls.Add(this.textBox33);
            this.PanelManuelTest.Controls.Add(this.button34);
            this.PanelManuelTest.Controls.Add(this.button32);
            this.PanelManuelTest.Controls.Add(this.button31);
            this.PanelManuelTest.Controls.Add(this.button30);
            this.PanelManuelTest.Controls.Add(this.label63);
            this.PanelManuelTest.Controls.Add(this.textBoxPositionmotor4);
            this.PanelManuelTest.Controls.Add(this.textBoxPositionmotor3);
            this.PanelManuelTest.Controls.Add(this.textBoxPositionmotor2);
            this.PanelManuelTest.Controls.Add(this.label62);
            this.PanelManuelTest.Controls.Add(this.label54);
            this.PanelManuelTest.Controls.Add(this.labelPosition);
            this.PanelManuelTest.Controls.Add(this.textBoxPositionmotor1);
            this.PanelManuelTest.Controls.Add(this.button28);
            this.PanelManuelTest.Controls.Add(this.angleTrackBar4);
            this.PanelManuelTest.Controls.Add(this.gaugePictureBox4);
            this.PanelManuelTest.Controls.Add(this.angleTrackBar3);
            this.PanelManuelTest.Controls.Add(this.gaugePictureBox3);
            this.PanelManuelTest.Controls.Add(this.angleTrackBar2);
            this.PanelManuelTest.Controls.Add(this.angleTrackBar);
            this.PanelManuelTest.Controls.Add(this.gaugePictureBox2);
            this.PanelManuelTest.Controls.Add(this.gaugePictureBox);
            this.PanelManuelTest.Controls.Add(this.label59);
            this.PanelManuelTest.Controls.Add(this.ManuelTestMotor);
            this.PanelManuelTest.Location = new System.Drawing.Point(3, 0);
            this.PanelManuelTest.Name = "PanelManuelTest";
            this.PanelManuelTest.Size = new System.Drawing.Size(2027, 1037);
            this.PanelManuelTest.TabIndex = 22;
            this.PanelManuelTest.Visible = false;
            // 
            // Motor4DegParametertext
            // 
            this.Motor4DegParametertext.Location = new System.Drawing.Point(1461, 390);
            this.Motor4DegParametertext.Name = "Motor4DegParametertext";
            this.Motor4DegParametertext.Size = new System.Drawing.Size(64, 22);
            this.Motor4DegParametertext.TabIndex = 51;
            // 
            // Motor3DegParametertext
            // 
            this.Motor3DegParametertext.Location = new System.Drawing.Point(972, 390);
            this.Motor3DegParametertext.Name = "Motor3DegParametertext";
            this.Motor3DegParametertext.Size = new System.Drawing.Size(64, 22);
            this.Motor3DegParametertext.TabIndex = 50;
            // 
            // Motor2DegParametertext
            // 
            this.Motor2DegParametertext.Location = new System.Drawing.Point(1461, 12);
            this.Motor2DegParametertext.Name = "Motor2DegParametertext";
            this.Motor2DegParametertext.Size = new System.Drawing.Size(64, 22);
            this.Motor2DegParametertext.TabIndex = 49;
            // 
            // Motor1DegParametertext
            // 
            this.Motor1DegParametertext.Location = new System.Drawing.Point(961, 15);
            this.Motor1DegParametertext.Name = "Motor1DegParametertext";
            this.Motor1DegParametertext.Size = new System.Drawing.Size(64, 22);
            this.Motor1DegParametertext.TabIndex = 48;
            // 
            // textBox36
            // 
            this.textBox36.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox36.Location = new System.Drawing.Point(1602, 388);
            this.textBox36.Name = "textBox36";
            this.textBox36.Size = new System.Drawing.Size(163, 20);
            this.textBox36.TabIndex = 47;
            this.textBox36.Text = "MOTOR-4";
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox35
            // 
            this.textBox35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox35.Location = new System.Drawing.Point(1152, 388);
            this.textBox35.Name = "textBox35";
            this.textBox35.Size = new System.Drawing.Size(163, 20);
            this.textBox35.TabIndex = 46;
            this.textBox35.Text = "MOTOR-3";
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox34
            // 
            this.textBox34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox34.Location = new System.Drawing.Point(1656, 12);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(163, 20);
            this.textBox34.TabIndex = 45;
            this.textBox34.Text = "MOTOR-2";
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox33
            // 
            this.textBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox33.Location = new System.Drawing.Point(1154, 10);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(163, 20);
            this.textBox33.TabIndex = 44;
            this.textBox33.Text = "MOTOR-1";
            this.textBox33.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button34
            // 
            this.button34.BackColor = System.Drawing.Color.DodgerBlue;
            this.button34.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button34.FlatAppearance.BorderSize = 0;
            this.button34.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button34.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button34.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button34.ForeColor = System.Drawing.Color.White;
            this.button34.Location = new System.Drawing.Point(1667, 793);
            this.button34.Name = "button34";
            this.button34.Size = new System.Drawing.Size(152, 36);
            this.button34.TabIndex = 43;
            this.button34.Text = "Motor-4 Grafik";
            this.button34.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.DodgerBlue;
            this.button32.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button32.ForeColor = System.Drawing.Color.White;
            this.button32.Location = new System.Drawing.Point(1489, 796);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(151, 35);
            this.button32.TabIndex = 41;
            this.button32.Text = "Motor-3 Grafik";
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.DodgerBlue;
            this.button31.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button31.ForeColor = System.Drawing.Color.White;
            this.button31.Location = new System.Drawing.Point(1309, 796);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(162, 35);
            this.button31.TabIndex = 40;
            this.button31.Text = "Motor-2 Grafik";
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(0, 0);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(75, 23);
            this.button30.TabIndex = 39;
            this.button30.Text = "button30";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // label63
            // 
            this.label63.BackColor = System.Drawing.Color.Black;
            this.label63.ForeColor = System.Drawing.Color.White;
            this.label63.Location = new System.Drawing.Point(1694, 599);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(68, 20);
            this.label63.TabIndex = 38;
            this.label63.Text = "Konum (DEG)";
            // 
            // textBoxPositionmotor4
            // 
            this.textBoxPositionmotor4.Location = new System.Drawing.Point(1697, 626);
            this.textBoxPositionmotor4.Name = "textBoxPositionmotor4";
            this.textBoxPositionmotor4.Size = new System.Drawing.Size(60, 22);
            this.textBoxPositionmotor4.TabIndex = 37;
            // 
            // textBoxPositionmotor3
            // 
            this.textBoxPositionmotor3.Location = new System.Drawing.Point(1206, 633);
            this.textBoxPositionmotor3.Name = "textBoxPositionmotor3";
            this.textBoxPositionmotor3.Size = new System.Drawing.Size(60, 22);
            this.textBoxPositionmotor3.TabIndex = 36;
            // 
            // textBoxPositionmotor2
            // 
            this.textBoxPositionmotor2.Location = new System.Drawing.Point(1705, 263);
            this.textBoxPositionmotor2.Name = "textBoxPositionmotor2";
            this.textBoxPositionmotor2.Size = new System.Drawing.Size(60, 22);
            this.textBoxPositionmotor2.TabIndex = 35;
            // 
            // label62
            // 
            this.label62.BackColor = System.Drawing.Color.Black;
            this.label62.ForeColor = System.Drawing.Color.White;
            this.label62.Location = new System.Drawing.Point(1702, 236);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(68, 20);
            this.label62.TabIndex = 34;
            this.label62.Text = "Konum (DEG)";
            // 
            // label54
            // 
            this.label54.BackColor = System.Drawing.Color.Black;
            this.label54.ForeColor = System.Drawing.Color.White;
            this.label54.Location = new System.Drawing.Point(1203, 603);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(68, 20);
            this.label54.TabIndex = 33;
            this.label54.Text = "Konum (DEG)";
            // 
            // labelPosition
            // 
            this.labelPosition.BackColor = System.Drawing.Color.Black;
            this.labelPosition.ForeColor = System.Drawing.Color.White;
            this.labelPosition.Location = new System.Drawing.Point(1203, 236);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(68, 20);
            this.labelPosition.TabIndex = 0;
            this.labelPosition.Text = "Konum (DEG)";
            // 
            // textBoxPositionmotor1
            // 
            this.textBoxPositionmotor1.Location = new System.Drawing.Point(1206, 270);
            this.textBoxPositionmotor1.Name = "textBoxPositionmotor1";
            this.textBoxPositionmotor1.Size = new System.Drawing.Size(60, 22);
            this.textBoxPositionmotor1.TabIndex = 1;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(0, 0);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(75, 23);
            this.button28.TabIndex = 31;
            this.button28.Text = "button28";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // angleTrackBar4
            // 
            this.angleTrackBar4.Location = new System.Drawing.Point(1477, 412);
            this.angleTrackBar4.Maximum = 15;
            this.angleTrackBar4.Minimum = -15;
            this.angleTrackBar4.Name = "angleTrackBar4";
            this.angleTrackBar4.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.angleTrackBar4.Size = new System.Drawing.Size(56, 335);
            this.angleTrackBar4.TabIndex = 29;
            // 
            // gaugePictureBox4
            // 
            this.gaugePictureBox4.Location = new System.Drawing.Point(1544, 416);
            this.gaugePictureBox4.Name = "gaugePictureBox4";
            this.gaugePictureBox4.Size = new System.Drawing.Size(372, 331);
            this.gaugePictureBox4.TabIndex = 30;
            this.gaugePictureBox4.TabStop = false;
            // 
            // angleTrackBar3
            // 
            this.angleTrackBar3.Location = new System.Drawing.Point(981, 418);
            this.angleTrackBar3.Maximum = 15;
            this.angleTrackBar3.Minimum = -15;
            this.angleTrackBar3.Name = "angleTrackBar3";
            this.angleTrackBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.angleTrackBar3.Size = new System.Drawing.Size(56, 329);
            this.angleTrackBar3.TabIndex = 27;
            // 
            // gaugePictureBox3
            // 
            this.gaugePictureBox3.Location = new System.Drawing.Point(1052, 417);
            this.gaugePictureBox3.Name = "gaugePictureBox3";
            this.gaugePictureBox3.Size = new System.Drawing.Size(386, 326);
            this.gaugePictureBox3.TabIndex = 28;
            this.gaugePictureBox3.TabStop = false;
            // 
            // angleTrackBar2
            // 
            this.angleTrackBar2.Location = new System.Drawing.Point(1477, 38);
            this.angleTrackBar2.Maximum = 15;
            this.angleTrackBar2.Minimum = -15;
            this.angleTrackBar2.Name = "angleTrackBar2";
            this.angleTrackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.angleTrackBar2.Size = new System.Drawing.Size(56, 334);
            this.angleTrackBar2.TabIndex = 25;
            // 
            // angleTrackBar
            // 
            this.angleTrackBar.Location = new System.Drawing.Point(981, 33);
            this.angleTrackBar.Maximum = 15;
            this.angleTrackBar.Minimum = -15;
            this.angleTrackBar.Name = "angleTrackBar";
            this.angleTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.angleTrackBar.Size = new System.Drawing.Size(56, 335);
            this.angleTrackBar.TabIndex = 24;
            // 
            // gaugePictureBox2
            // 
            this.gaugePictureBox2.Location = new System.Drawing.Point(1544, 38);
            this.gaugePictureBox2.Name = "gaugePictureBox2";
            this.gaugePictureBox2.Size = new System.Drawing.Size(372, 331);
            this.gaugePictureBox2.TabIndex = 26;
            this.gaugePictureBox2.TabStop = false;
            // 
            // gaugePictureBox
            // 
            this.gaugePictureBox.Location = new System.Drawing.Point(1051, 36);
            this.gaugePictureBox.Name = "gaugePictureBox";
            this.gaugePictureBox.Size = new System.Drawing.Size(387, 331);
            this.gaugePictureBox.TabIndex = 23;
            this.gaugePictureBox.TabStop = false;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Location = new System.Drawing.Point(0, 0);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(51, 16);
            this.label59.TabIndex = 22;
            this.label59.Text = "label59";
            // 
            // ManuelTestMotor
            // 
            this.ManuelTestMotor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ManuelTestMotor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManuelTestMotor.Controls.Add(this.motor4konum);
            this.ManuelTestMotor.Controls.Add(this.label81);
            this.ManuelTestMotor.Controls.Add(this.motor3konum);
            this.ManuelTestMotor.Controls.Add(this.motor3akim);
            this.ManuelTestMotor.Controls.Add(this.motor4currenttext);
            this.ManuelTestMotor.Controls.Add(this.motor3currenttext);
            this.ManuelTestMotor.Controls.Add(this.Motor4positiontext);
            this.ManuelTestMotor.Controls.Add(this.Motor3positiontext);
            this.ManuelTestMotor.Controls.Add(this.label61);
            this.ManuelTestMotor.Controls.Add(this.Motor1ManuelGraphButton);
            this.ManuelTestMotor.Controls.Add(this.label60);
            this.ManuelTestMotor.Controls.Add(this.label58);
            this.ManuelTestMotor.Controls.Add(this.label57);
            this.ManuelTestMotor.Controls.Add(this.label56);
            this.ManuelTestMotor.Controls.Add(this.label55);
            this.ManuelTestMotor.Controls.Add(this.textBox46);
            this.ManuelTestMotor.Controls.Add(this.textBox45);
            this.ManuelTestMotor.Controls.Add(this.textBox44);
            this.ManuelTestMotor.Controls.Add(this.textBox43);
            this.ManuelTestMotor.Controls.Add(this.ManuelTestCommandButton);
            this.ManuelTestMotor.Controls.Add(this.motor2konum);
            this.ManuelTestMotor.Controls.Add(this.motor2akim);
            this.ManuelTestMotor.Controls.Add(this.label49);
            this.ManuelTestMotor.Controls.Add(this.motor1akim);
            this.ManuelTestMotor.Controls.Add(this.textBox42);
            this.ManuelTestMotor.Controls.Add(this.textBox41);
            this.ManuelTestMotor.Controls.Add(this.motor2currenttext);
            this.ManuelTestMotor.Controls.Add(this.motor1currenttext);
            this.ManuelTestMotor.Controls.Add(this.motor2positiontext);
            this.ManuelTestMotor.Controls.Add(this.Motor1positiontext);
            this.ManuelTestMotor.Controls.Add(this.tableLayoutPanel2);
            this.ManuelTestMotor.Location = new System.Drawing.Point(292, 9);
            this.ManuelTestMotor.Name = "ManuelTestMotor";
            this.ManuelTestMotor.Size = new System.Drawing.Size(616, 954);
            this.ManuelTestMotor.TabIndex = 21;
            // 
            // motor4konum
            // 
            this.motor4konum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motor4konum.AutoSize = true;
            this.motor4konum.ForeColor = System.Drawing.Color.Black;
            this.motor4konum.Location = new System.Drawing.Point(303, 407);
            this.motor4konum.Name = "motor4konum";
            this.motor4konum.Size = new System.Drawing.Size(123, 16);
            this.motor4konum.TabIndex = 55;
            this.motor4konum.Text = "MOTOR- 4 KONUM";
            // 
            // label81
            // 
            this.label81.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label81.AutoSize = true;
            this.label81.ForeColor = System.Drawing.Color.Black;
            this.label81.Location = new System.Drawing.Point(303, 501);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(105, 16);
            this.label81.TabIndex = 54;
            this.label81.Text = "MOTOR- 4 AKIM";
            // 
            // motor3konum
            // 
            this.motor3konum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motor3konum.AutoSize = true;
            this.motor3konum.ForeColor = System.Drawing.Color.Black;
            this.motor3konum.Location = new System.Drawing.Point(303, 358);
            this.motor3konum.Name = "motor3konum";
            this.motor3konum.Size = new System.Drawing.Size(123, 16);
            this.motor3konum.TabIndex = 53;
            this.motor3konum.Text = "MOTOR- 3 KONUM";
            // 
            // motor3akim
            // 
            this.motor3akim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motor3akim.AutoSize = true;
            this.motor3akim.ForeColor = System.Drawing.Color.Black;
            this.motor3akim.Location = new System.Drawing.Point(303, 458);
            this.motor3akim.Name = "motor3akim";
            this.motor3akim.Size = new System.Drawing.Size(105, 16);
            this.motor3akim.TabIndex = 48;
            this.motor3akim.Text = "MOTOR- 3 AKİM";
            // 
            // motor4currenttext
            // 
            this.motor4currenttext.Location = new System.Drawing.Point(448, 496);
            this.motor4currenttext.Name = "motor4currenttext";
            this.motor4currenttext.Size = new System.Drawing.Size(42, 22);
            this.motor4currenttext.TabIndex = 52;
            // 
            // motor3currenttext
            // 
            this.motor3currenttext.Location = new System.Drawing.Point(447, 451);
            this.motor3currenttext.Name = "motor3currenttext";
            this.motor3currenttext.Size = new System.Drawing.Size(41, 22);
            this.motor3currenttext.TabIndex = 51;
            // 
            // Motor4positiontext
            // 
            this.Motor4positiontext.Location = new System.Drawing.Point(447, 401);
            this.Motor4positiontext.Name = "Motor4positiontext";
            this.Motor4positiontext.Size = new System.Drawing.Size(42, 22);
            this.Motor4positiontext.TabIndex = 50;
            // 
            // Motor3positiontext
            // 
            this.Motor3positiontext.Location = new System.Drawing.Point(448, 354);
            this.Motor3positiontext.Name = "Motor3positiontext";
            this.Motor3positiontext.Size = new System.Drawing.Size(42, 22);
            this.Motor3positiontext.TabIndex = 49;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.ForeColor = System.Drawing.Color.Black;
            this.label61.Location = new System.Drawing.Point(156, 808);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(129, 16);
            this.label61.TabIndex = 24;
            this.label61.Text = "BESLEME GERİLİMİ";
            // 
            // Motor1ManuelGraphButton
            // 
            this.Motor1ManuelGraphButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.Motor1ManuelGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Motor1ManuelGraphButton.FlatAppearance.BorderSize = 0;
            this.Motor1ManuelGraphButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.Motor1ManuelGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Motor1ManuelGraphButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.Motor1ManuelGraphButton.ForeColor = System.Drawing.Color.White;
            this.Motor1ManuelGraphButton.Location = new System.Drawing.Point(406, 732);
            this.Motor1ManuelGraphButton.Name = "Motor1ManuelGraphButton";
            this.Motor1ManuelGraphButton.Size = new System.Drawing.Size(151, 35);
            this.Motor1ManuelGraphButton.TabIndex = 42;
            this.Motor1ManuelGraphButton.Text = "Motor-1 Grafik";
            this.Motor1ManuelGraphButton.UseVisualStyleBackColor = false;
            this.Motor1ManuelGraphButton.Click += new System.EventHandler(this.Motor1ManuelGraphButton_Click_1);
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.ForeColor = System.Drawing.Color.Black;
            this.label60.Location = new System.Drawing.Point(156, 773);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(110, 16);
            this.label60.TabIndex = 23;
            this.label60.Text = "SİSTEM ZAMANI";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.ForeColor = System.Drawing.Color.Black;
            this.label58.Location = new System.Drawing.Point(314, 616);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(108, 16);
            this.label58.TabIndex = 47;
            this.label58.Text = "MOTOR-1 HATA";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.ForeColor = System.Drawing.Color.Black;
            this.label57.Location = new System.Drawing.Point(314, 574);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(108, 16);
            this.label57.TabIndex = 46;
            this.label57.Text = "MOTOR-1 HATA";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(102, 619);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(108, 16);
            this.label56.TabIndex = 45;
            this.label56.Text = "MOTOR-1 HATA";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(102, 574);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(108, 16);
            this.label55.TabIndex = 22;
            this.label55.Text = "MOTOR-1 HATA";
            // 
            // textBox46
            // 
            this.textBox46.BackColor = System.Drawing.Color.Red;
            this.textBox46.Location = new System.Drawing.Point(452, 610);
            this.textBox46.Name = "textBox46";
            this.textBox46.Size = new System.Drawing.Size(51, 22);
            this.textBox46.TabIndex = 43;
            // 
            // textBox45
            // 
            this.textBox45.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox45.Location = new System.Drawing.Point(452, 570);
            this.textBox45.Name = "textBox45";
            this.textBox45.Size = new System.Drawing.Size(51, 22);
            this.textBox45.TabIndex = 42;
            // 
            // textBox44
            // 
            this.textBox44.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox44.Location = new System.Drawing.Point(244, 613);
            this.textBox44.Name = "textBox44";
            this.textBox44.Size = new System.Drawing.Size(51, 22);
            this.textBox44.TabIndex = 41;
            // 
            // textBox43
            // 
            this.textBox43.BackColor = System.Drawing.Color.Chartreuse;
            this.textBox43.Location = new System.Drawing.Point(244, 572);
            this.textBox43.Name = "textBox43";
            this.textBox43.Size = new System.Drawing.Size(51, 22);
            this.textBox43.TabIndex = 40;
            // 
            // ManuelTestCommandButton
            // 
            this.ManuelTestCommandButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.ManuelTestCommandButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ManuelTestCommandButton.FlatAppearance.BorderSize = 0;
            this.ManuelTestCommandButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.ManuelTestCommandButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ManuelTestCommandButton.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.ManuelTestCommandButton.ForeColor = System.Drawing.Color.White;
            this.ManuelTestCommandButton.Location = new System.Drawing.Point(425, 788);
            this.ManuelTestCommandButton.Name = "ManuelTestCommandButton";
            this.ManuelTestCommandButton.Size = new System.Drawing.Size(160, 60);
            this.ManuelTestCommandButton.TabIndex = 32;
            this.ManuelTestCommandButton.Text = "Komut Gönder";
            this.ManuelTestCommandButton.UseVisualStyleBackColor = false;
            this.ManuelTestCommandButton.Click += new System.EventHandler(this.ManuelTestCommandButton_Click);
            // 
            // motor2konum
            // 
            this.motor2konum.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motor2konum.AutoSize = true;
            this.motor2konum.ForeColor = System.Drawing.Color.Black;
            this.motor2konum.Location = new System.Drawing.Point(94, 408);
            this.motor2konum.Name = "motor2konum";
            this.motor2konum.Size = new System.Drawing.Size(123, 16);
            this.motor2konum.TabIndex = 39;
            this.motor2konum.Text = "MOTOR- 2 KONUM";
            // 
            // motor2akim
            // 
            this.motor2akim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motor2akim.AutoSize = true;
            this.motor2akim.ForeColor = System.Drawing.Color.Black;
            this.motor2akim.Location = new System.Drawing.Point(94, 502);
            this.motor2akim.Name = "motor2akim";
            this.motor2akim.Size = new System.Drawing.Size(105, 16);
            this.motor2akim.TabIndex = 36;
            this.motor2akim.Text = "MOTOR- 2 AKIM";
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label49.AutoSize = true;
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(94, 359);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(123, 16);
            this.label49.TabIndex = 35;
            this.label49.Text = "MOTOR- 1 KONUM";
            // 
            // motor1akim
            // 
            this.motor1akim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motor1akim.AutoSize = true;
            this.motor1akim.ForeColor = System.Drawing.Color.Black;
            this.motor1akim.Location = new System.Drawing.Point(94, 459);
            this.motor1akim.Name = "motor1akim";
            this.motor1akim.Size = new System.Drawing.Size(105, 16);
            this.motor1akim.TabIndex = 22;
            this.motor1akim.Text = "MOTOR- 1 AKIM";
            // 
            // textBox42
            // 
            this.textBox42.Location = new System.Drawing.Point(291, 805);
            this.textBox42.Name = "textBox42";
            this.textBox42.Size = new System.Drawing.Size(106, 22);
            this.textBox42.TabIndex = 32;
            // 
            // textBox41
            // 
            this.textBox41.Location = new System.Drawing.Point(291, 767);
            this.textBox41.Name = "textBox41";
            this.textBox41.Size = new System.Drawing.Size(106, 22);
            this.textBox41.TabIndex = 31;
            // 
            // motor2currenttext
            // 
            this.motor2currenttext.Location = new System.Drawing.Point(239, 497);
            this.motor2currenttext.Name = "motor2currenttext";
            this.motor2currenttext.Size = new System.Drawing.Size(42, 22);
            this.motor2currenttext.TabIndex = 29;
            // 
            // motor1currenttext
            // 
            this.motor1currenttext.Location = new System.Drawing.Point(238, 452);
            this.motor1currenttext.Name = "motor1currenttext";
            this.motor1currenttext.Size = new System.Drawing.Size(41, 22);
            this.motor1currenttext.TabIndex = 27;
            // 
            // motor2positiontext
            // 
            this.motor2positiontext.Location = new System.Drawing.Point(238, 402);
            this.motor2positiontext.Name = "motor2positiontext";
            this.motor2positiontext.Size = new System.Drawing.Size(42, 22);
            this.motor2positiontext.TabIndex = 25;
            // 
            // Motor1positiontext
            // 
            this.Motor1positiontext.Location = new System.Drawing.Point(239, 355);
            this.Motor1positiontext.Name = "Motor1positiontext";
            this.Motor1positiontext.Size = new System.Drawing.Size(42, 22);
            this.Motor1positiontext.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.Motor4Enabledbutton, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Motor2Enabledbutton, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Motor3Enabledbutton, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox32, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.Motor1Enabledbutton, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox31, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 19);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(598, 262);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // Motor4Enabledbutton
            // 
            this.Motor4Enabledbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Motor4Enabledbutton.AutoCheck = false;
            this.Motor4Enabledbutton.AutoSize = true;
            this.Motor4Enabledbutton.Location = new System.Drawing.Point(403, 218);
            this.Motor4Enabledbutton.Name = "Motor4Enabledbutton";
            this.Motor4Enabledbutton.Size = new System.Drawing.Size(89, 20);
            this.Motor4Enabledbutton.TabIndex = 25;
            this.Motor4Enabledbutton.TabStop = true;
            this.Motor4Enabledbutton.Text = "MOTOR-4";
            this.Motor4Enabledbutton.UseVisualStyleBackColor = true;
            this.Motor4Enabledbutton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // Motor2Enabledbutton
            // 
            this.Motor2Enabledbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Motor2Enabledbutton.AutoCheck = false;
            this.Motor2Enabledbutton.AutoSize = true;
            this.Motor2Enabledbutton.Location = new System.Drawing.Point(105, 218);
            this.Motor2Enabledbutton.Name = "Motor2Enabledbutton";
            this.Motor2Enabledbutton.Size = new System.Drawing.Size(89, 20);
            this.Motor2Enabledbutton.TabIndex = 25;
            this.Motor2Enabledbutton.TabStop = true;
            this.Motor2Enabledbutton.Text = "MOTOR-2";
            this.Motor2Enabledbutton.UseVisualStyleBackColor = true;
            this.Motor2Enabledbutton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // Motor3Enabledbutton
            // 
            this.Motor3Enabledbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Motor3Enabledbutton.AutoCheck = false;
            this.Motor3Enabledbutton.AutoSize = true;
            this.Motor3Enabledbutton.Location = new System.Drawing.Point(403, 136);
            this.Motor3Enabledbutton.Name = "Motor3Enabledbutton";
            this.Motor3Enabledbutton.Size = new System.Drawing.Size(89, 20);
            this.Motor3Enabledbutton.TabIndex = 24;
            this.Motor3Enabledbutton.TabStop = true;
            this.Motor3Enabledbutton.Text = "MOTOR-3";
            this.Motor3Enabledbutton.UseVisualStyleBackColor = true;
            this.Motor3Enabledbutton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // textBox32
            // 
            this.textBox32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.textBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox32.Location = new System.Drawing.Point(387, 37);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(122, 23);
            this.textBox32.TabIndex = 1;
            this.textBox32.Text = "MSK-2";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Motor1Enabledbutton
            // 
            this.Motor1Enabledbutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Motor1Enabledbutton.AutoCheck = false;
            this.Motor1Enabledbutton.AutoSize = true;
            this.Motor1Enabledbutton.Location = new System.Drawing.Point(105, 136);
            this.Motor1Enabledbutton.Name = "Motor1Enabledbutton";
            this.Motor1Enabledbutton.Size = new System.Drawing.Size(89, 20);
            this.Motor1Enabledbutton.TabIndex = 23;
            this.Motor1Enabledbutton.TabStop = true;
            this.Motor1Enabledbutton.Text = "MOTOR-1";
            this.Motor1Enabledbutton.UseVisualStyleBackColor = true;
            this.Motor1Enabledbutton.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // textBox31
            // 
            this.textBox31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox31.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.textBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox31.Location = new System.Drawing.Point(86, 37);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(126, 23);
            this.textBox31.TabIndex = 0;
            this.textBox31.Text = "MSK-1";
            this.textBox31.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // navbar
            // 
            this.navbar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.navbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.navbar.Controls.Add(this.HomePageButton);
            this.navbar.Controls.Add(this.textBox66);
            this.navbar.Controls.Add(this.OtomaticTestButton);
            this.navbar.Controls.Add(this.button26);
            this.navbar.Controls.Add(this.ExitButton);
            this.navbar.Controls.Add(this.ErrorPanelButton);
            this.navbar.Controls.Add(this.ParametreButton);
            this.navbar.Controls.Add(this.pictureBox);
            this.navbar.Controls.Add(this.DashboardButton);
            this.navbar.Controls.Add(this.pictureBox5);
            this.navbar.ForeColor = System.Drawing.Color.White;
            this.navbar.Location = new System.Drawing.Point(0, 0);
            this.navbar.Name = "navbar";
            this.navbar.Size = new System.Drawing.Size(241, 1037);
            this.navbar.TabIndex = 18;
            // 
            // HomePageButton
            // 
            this.HomePageButton.BackColor = System.Drawing.Color.Transparent;
            this.HomePageButton.FlatAppearance.BorderSize = 0;
            this.HomePageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.HomePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HomePageButton.ForeColor = System.Drawing.Color.Black;
            this.HomePageButton.Image = ((System.Drawing.Image)(resources.GetObject("HomePageButton.Image")));
            this.HomePageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomePageButton.Location = new System.Drawing.Point(27, 112);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.HomePageButton.Size = new System.Drawing.Size(205, 62);
            this.HomePageButton.TabIndex = 29;
            this.HomePageButton.Text = "Başlangıç";
            this.HomePageButton.UseVisualStyleBackColor = false;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // textBox66
            // 
            this.textBox66.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox66.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox66.ForeColor = System.Drawing.Color.Black;
            this.textBox66.Location = new System.Drawing.Point(70, 990);
            this.textBox66.Name = "textBox66";
            this.textBox66.Size = new System.Drawing.Size(100, 15);
            this.textBox66.TabIndex = 27;
            this.textBox66.Text = "v.1.0.0";
            // 
            // OtomaticTestButton
            // 
            this.OtomaticTestButton.BackColor = System.Drawing.Color.Transparent;
            this.OtomaticTestButton.FlatAppearance.BorderSize = 0;
            this.OtomaticTestButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.OtomaticTestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OtomaticTestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OtomaticTestButton.ForeColor = System.Drawing.Color.Black;
            this.OtomaticTestButton.Image = ((System.Drawing.Image)(resources.GetObject("OtomaticTestButton.Image")));
            this.OtomaticTestButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OtomaticTestButton.Location = new System.Drawing.Point(32, 244);
            this.OtomaticTestButton.Name = "OtomaticTestButton";
            this.OtomaticTestButton.Size = new System.Drawing.Size(200, 65);
            this.OtomaticTestButton.TabIndex = 26;
            this.OtomaticTestButton.Text = " Otomatik Test";
            this.OtomaticTestButton.UseVisualStyleBackColor = false;
            this.OtomaticTestButton.Click += new System.EventHandler(this.OtomaticTestButton_Click);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.Transparent;
            this.button26.FlatAppearance.BorderSize = 0;
            this.button26.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button26.ForeColor = System.Drawing.Color.Black;
            this.button26.Image = ((System.Drawing.Image)(resources.GetObject("button26.Image")));
            this.button26.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button26.Location = new System.Drawing.Point(33, 336);
            this.button26.Name = "button26";
            this.button26.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button26.Size = new System.Drawing.Size(202, 51);
            this.button26.TabIndex = 25;
            this.button26.Text = " Manuel Test";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.ManueltestButtonClick);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExitButton.ForeColor = System.Drawing.Color.Black;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitButton.Location = new System.Drawing.Point(33, 548);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitButton.Size = new System.Drawing.Size(206, 59);
            this.ExitButton.TabIndex = 24;
            this.ExitButton.Text = "Çıkış";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.Exitbutton_Click);
            // 
            // ErrorPanelButton
            // 
            this.ErrorPanelButton.BackColor = System.Drawing.Color.Transparent;
            this.ErrorPanelButton.FlatAppearance.BorderSize = 0;
            this.ErrorPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.ErrorPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ErrorPanelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ErrorPanelButton.ForeColor = System.Drawing.Color.Black;
            this.ErrorPanelButton.Image = ((System.Drawing.Image)(resources.GetObject("ErrorPanelButton.Image")));
            this.ErrorPanelButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ErrorPanelButton.Location = new System.Drawing.Point(33, 397);
            this.ErrorPanelButton.Name = "ErrorPanelButton";
            this.ErrorPanelButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ErrorPanelButton.Size = new System.Drawing.Size(204, 60);
            this.ErrorPanelButton.TabIndex = 23;
            this.ErrorPanelButton.Text = "Hatalar";
            this.ErrorPanelButton.UseVisualStyleBackColor = false;
            this.ErrorPanelButton.Click += new System.EventHandler(this.ErrorPanelbutton_Click);
            // 
            // ParametreButton
            // 
            this.ParametreButton.BackColor = System.Drawing.Color.Transparent;
            this.ParametreButton.FlatAppearance.BorderSize = 0;
            this.ParametreButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ParametreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ParametreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ParametreButton.ForeColor = System.Drawing.Color.Black;
            this.ParametreButton.Image = ((System.Drawing.Image)(resources.GetObject("ParametreButton.Image")));
            this.ParametreButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ParametreButton.Location = new System.Drawing.Point(33, 468);
            this.ParametreButton.Name = "ParametreButton";
            this.ParametreButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ParametreButton.Size = new System.Drawing.Size(208, 60);
            this.ParametreButton.TabIndex = 22;
            this.ParametreButton.Text = " Parametre Değişim";
            this.ParametreButton.UseVisualStyleBackColor = false;
            this.ParametreButton.Click += new System.EventHandler(this.Parameterbutton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::WindowsFormsApp1.Properties.Resources.Kanatcik;
            this.pictureBox.Location = new System.Drawing.Point(3, 14);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(229, 83);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 28;
            this.pictureBox.TabStop = false;
            // 
            // DashboardButton
            // 
            this.DashboardButton.BackColor = System.Drawing.Color.Transparent;
            this.DashboardButton.FlatAppearance.BorderSize = 0;
            this.DashboardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(97)))), ((int)(((byte)(141)))));
            this.DashboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashboardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DashboardButton.ForeColor = System.Drawing.Color.Black;
            this.DashboardButton.Image = ((System.Drawing.Image)(resources.GetObject("DashboardButton.Image")));
            this.DashboardButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DashboardButton.Location = new System.Drawing.Point(27, 176);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DashboardButton.Size = new System.Drawing.Size(205, 62);
            this.DashboardButton.TabIndex = 21;
            this.DashboardButton.Text = "Test";
            this.DashboardButton.UseVisualStyleBackColor = false;
            this.DashboardButton.Click += new System.EventHandler(this.Dashboardbutton1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(4, 908);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(232, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // KP2
            // 
            this.KP2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KP2.Location = new System.Drawing.Point(52, 85);
            this.KP2.Name = "KP2";
            this.KP2.Size = new System.Drawing.Size(151, 22);
            this.KP2.TabIndex = 10;
            // 
            // KP3
            // 
            this.KP3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.KP3.Location = new System.Drawing.Point(52, 125);
            this.KP3.Name = "KP3";
            this.KP3.Size = new System.Drawing.Size(151, 22);
            this.KP3.TabIndex = 11;
            // 
            // msk1label
            // 
            this.msk1label.AutoSize = true;
            this.msk1label.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.msk1label.ForeColor = System.Drawing.Color.DodgerBlue;
            this.msk1label.Location = new System.Drawing.Point(219, -1);
            this.msk1label.Name = "msk1label";
            this.msk1label.Size = new System.Drawing.Size(132, 42);
            this.msk1label.TabIndex = 7;
            this.msk1label.Text = "MSK-1";
            // 
            // Msk1panel
            // 
            this.Msk1panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Msk1panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Msk1panel.Controls.Add(this.MSK1AkimKD);
            this.Msk1panel.Controls.Add(this.MSK1AkimKI);
            this.Msk1panel.Controls.Add(this.MSK1AkimKp);
            this.Msk1panel.Controls.Add(this.MSK1KD);
            this.Msk1panel.Controls.Add(this.Mk1KI);
            this.Msk1panel.Controls.Add(this.Msk1KP);
            this.Msk1panel.Controls.Add(this.label14);
            this.Msk1panel.Controls.Add(this.label15);
            this.Msk1panel.Controls.Add(this.label16);
            this.Msk1panel.Controls.Add(this.button11);
            this.Msk1panel.Controls.Add(this.msk1label);
            this.Msk1panel.Controls.Add(this.label17);
            this.Msk1panel.Controls.Add(this.label18);
            this.Msk1panel.Controls.Add(this.label19);
            this.Msk1panel.Controls.Add(this.textBox15);
            this.Msk1panel.Controls.Add(this.PositionControlParameter);
            this.Msk1panel.Controls.Add(this.Mskchange2Button);
            this.Msk1panel.Controls.Add(this.MskQueryButton);
            this.Msk1panel.Controls.Add(this.label8);
            this.Msk1panel.Controls.Add(this.label9);
            this.Msk1panel.Controls.Add(this.label10);
            this.Msk1panel.Controls.Add(this.textBox9);
            this.Msk1panel.Controls.Add(this.textBox10);
            this.Msk1panel.Controls.Add(this.textBox11);
            this.Msk1panel.Controls.Add(this.label4);
            this.Msk1panel.Controls.Add(this.label3);
            this.Msk1panel.Controls.Add(this.label2);
            this.Msk1panel.Controls.Add(this.textBox3);
            this.Msk1panel.Controls.Add(this.textBox4);
            this.Msk1panel.Controls.Add(this.textBox5);
            this.Msk1panel.Location = new System.Drawing.Point(436, 75);
            this.Msk1panel.Name = "Msk1panel";
            this.Msk1panel.Size = new System.Drawing.Size(571, 423);
            this.Msk1panel.TabIndex = 15;
            // 
            // MSK1AkimKD
            // 
            this.MSK1AkimKD.Location = new System.Drawing.Point(380, 248);
            this.MSK1AkimKD.Name = "MSK1AkimKD";
            this.MSK1AkimKD.Size = new System.Drawing.Size(180, 22);
            this.MSK1AkimKD.TabIndex = 57;
            // 
            // MSK1AkimKI
            // 
            this.MSK1AkimKI.Location = new System.Drawing.Point(380, 184);
            this.MSK1AkimKI.Name = "MSK1AkimKI";
            this.MSK1AkimKI.Size = new System.Drawing.Size(180, 22);
            this.MSK1AkimKI.TabIndex = 56;
            // 
            // MSK1AkimKp
            // 
            this.MSK1AkimKp.Location = new System.Drawing.Point(380, 109);
            this.MSK1AkimKp.Name = "MSK1AkimKp";
            this.MSK1AkimKp.Size = new System.Drawing.Size(180, 22);
            this.MSK1AkimKp.TabIndex = 55;
            // 
            // MSK1KD
            // 
            this.MSK1KD.Location = new System.Drawing.Point(65, 255);
            this.MSK1KD.Name = "MSK1KD";
            this.MSK1KD.Size = new System.Drawing.Size(180, 22);
            this.MSK1KD.TabIndex = 54;
            // 
            // Mk1KI
            // 
            this.Mk1KI.Location = new System.Drawing.Point(65, 191);
            this.Mk1KI.Name = "Mk1KI";
            this.Mk1KI.Size = new System.Drawing.Size(180, 22);
            this.Mk1KI.TabIndex = 53;
            // 
            // Msk1KP
            // 
            this.Msk1KP.Location = new System.Drawing.Point(65, 117);
            this.Msk1KP.Name = "Msk1KP";
            this.Msk1KP.Size = new System.Drawing.Size(180, 22);
            this.Msk1KP.TabIndex = 52;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(15, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "KD";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(15, 191);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 16);
            this.label15.TabIndex = 49;
            this.label15.Text = "KI";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(15, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 16);
            this.label16.TabIndex = 47;
            this.label16.Text = "KP";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(69, 291);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(143, 38);
            this.button11.TabIndex = 48;
            this.button11.Text = "Değiştir";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(346, 253);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 16);
            this.label17.TabIndex = 22;
            this.label17.Text = "KD";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(346, 186);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 16);
            this.label18.TabIndex = 21;
            this.label18.Text = "KI";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(346, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 16);
            this.label19.TabIndex = 20;
            this.label19.Text = "KP";
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.White;
            this.textBox15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox15.ForeColor = System.Drawing.Color.Black;
            this.textBox15.Location = new System.Drawing.Point(310, 49);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(258, 30);
            this.textBox15.TabIndex = 41;
            this.textBox15.Text = "Akım Kontrolcü Parametreleri";
            // 
            // PositionControlParameter
            // 
            this.PositionControlParameter.BackColor = System.Drawing.Color.White;
            this.PositionControlParameter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PositionControlParameter.ForeColor = System.Drawing.Color.Black;
            this.PositionControlParameter.Location = new System.Drawing.Point(13, 49);
            this.PositionControlParameter.Name = "PositionControlParameter";
            this.PositionControlParameter.Size = new System.Drawing.Size(277, 30);
            this.PositionControlParameter.TabIndex = 20;
            this.PositionControlParameter.Text = "Pozisyon Kontrolcü Parametreleri";
            // 
            // Mskchange2Button
            // 
            this.Mskchange2Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.Mskchange2Button.FlatAppearance.BorderSize = 0;
            this.Mskchange2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Mskchange2Button.ForeColor = System.Drawing.Color.White;
            this.Mskchange2Button.Location = new System.Drawing.Point(400, 286);
            this.Mskchange2Button.Name = "Mskchange2Button";
            this.Mskchange2Button.Size = new System.Drawing.Size(143, 38);
            this.Mskchange2Button.TabIndex = 20;
            this.Mskchange2Button.Text = "Değiştir";
            this.Mskchange2Button.UseVisualStyleBackColor = false;
            // 
            // MskQueryButton
            // 
            this.MskQueryButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.MskQueryButton.FlatAppearance.BorderSize = 0;
            this.MskQueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MskQueryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.MskQueryButton.ForeColor = System.Drawing.Color.White;
            this.MskQueryButton.Location = new System.Drawing.Point(400, 374);
            this.MskQueryButton.Name = "MskQueryButton";
            this.MskQueryButton.Size = new System.Drawing.Size(143, 41);
            this.MskQueryButton.TabIndex = 20;
            this.MskQueryButton.Text = "Sorgula";
            this.MskQueryButton.UseVisualStyleBackColor = false;
            this.MskQueryButton.Click += new System.EventHandler(this.MskQueryButton_Click);
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(-1, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(-1, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(-1, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 23);
            this.label10.TabIndex = 25;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox9.ForeColor = System.Drawing.Color.White;
            this.textBox9.Location = new System.Drawing.Point(-1, 37);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 22);
            this.textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox10.ForeColor = System.Drawing.Color.White;
            this.textBox10.Location = new System.Drawing.Point(-1, 37);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 22);
            this.textBox10.TabIndex = 27;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox11.ForeColor = System.Drawing.Color.White;
            this.textBox11.Location = new System.Drawing.Point(-1, 37);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 22);
            this.textBox11.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(-1, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-1, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 31;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(-1, 37);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 32;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(-1, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 33;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(-1, 37);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 34;
            // 
            // Otomatictestpanel
            // 
            this.Otomatictestpanel.Location = new System.Drawing.Point(0, 0);
            this.Otomatictestpanel.Name = "Otomatictestpanel";
            this.Otomatictestpanel.Size = new System.Drawing.Size(200, 100);
            this.Otomatictestpanel.TabIndex = 48;
            // 
            // textBox49
            // 
            this.textBox49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox49.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox49.ForeColor = System.Drawing.Color.GreenYellow;
            this.textBox49.Location = new System.Drawing.Point(731, 571);
            this.textBox49.Name = "textBox49";
            this.textBox49.Size = new System.Drawing.Size(156, 22);
            this.textBox49.TabIndex = 5;
            this.textBox49.Text = "Yazılım v1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(619, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(8, 8);
            this.panel2.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textBox69);
            this.panel3.Controls.Add(this.msk1systemtyp);
            this.panel3.Controls.Add(this.msk1cardtemp);
            this.panel3.Controls.Add(this.MSK1batteryvoltage);
            this.panel3.Controls.Add(this.label29);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label32);
            this.panel3.Controls.Add(this.label33);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.textBox20);
            this.panel3.Controls.Add(this.textBox21);
            this.panel3.Controls.Add(this.textBox22);
            this.panel3.Controls.Add(this.label35);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.label37);
            this.panel3.Controls.Add(this.textBox23);
            this.panel3.Controls.Add(this.textBox24);
            this.panel3.Controls.Add(this.textBox25);
            this.panel3.Location = new System.Drawing.Point(435, 511);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 405);
            this.panel3.TabIndex = 46;
            // 
            // textBox69
            // 
            this.textBox69.BackColor = System.Drawing.Color.LightGray;
            this.textBox69.Location = new System.Drawing.Point(227, 337);
            this.textBox69.Name = "textBox69";
            this.textBox69.Size = new System.Drawing.Size(180, 22);
            this.textBox69.TabIndex = 54;
            // 
            // msk1systemtyp
            // 
            this.msk1systemtyp.BackColor = System.Drawing.Color.LightGray;
            this.msk1systemtyp.Location = new System.Drawing.Point(227, 243);
            this.msk1systemtyp.Name = "msk1systemtyp";
            this.msk1systemtyp.ReadOnly = true;
            this.msk1systemtyp.Size = new System.Drawing.Size(180, 22);
            this.msk1systemtyp.TabIndex = 53;
            // 
            // msk1cardtemp
            // 
            this.msk1cardtemp.BackColor = System.Drawing.Color.LightGray;
            this.msk1cardtemp.Location = new System.Drawing.Point(227, 141);
            this.msk1cardtemp.Name = "msk1cardtemp";
            this.msk1cardtemp.Size = new System.Drawing.Size(180, 22);
            this.msk1cardtemp.TabIndex = 52;
            // 
            // MSK1batteryvoltage
            // 
            this.MSK1batteryvoltage.BackColor = System.Drawing.Color.LightGray;
            this.MSK1batteryvoltage.Location = new System.Drawing.Point(227, 43);
            this.MSK1batteryvoltage.Name = "MSK1batteryvoltage";
            this.MSK1batteryvoltage.Size = new System.Drawing.Size(180, 22);
            this.MSK1batteryvoltage.TabIndex = 51;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label29.ForeColor = System.Drawing.Color.Black;
            this.label29.Location = new System.Drawing.Point(11, 337);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(153, 20);
            this.label29.TabIndex = 50;
            this.label29.Text = "Hatalı Mesaj Sayısı";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label28.ForeColor = System.Drawing.Color.Black;
            this.label28.Location = new System.Drawing.Point(20, 141);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(107, 20);
            this.label28.TabIndex = 49;
            this.label28.Text = "Kart Sıcaklığı";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(21, 245);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 20);
            this.label27.TabIndex = 48;
            this.label27.Text = "Sistem Tip";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(20, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(159, 20);
            this.label26.TabIndex = 47;
            this.label26.Text = "Anlık Batarya Voltajı";
            // 
            // label32
            // 
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(0, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(100, 23);
            this.label32.TabIndex = 23;
            // 
            // label33
            // 
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(100, 23);
            this.label33.TabIndex = 24;
            // 
            // label34
            // 
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(0, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(100, 23);
            this.label34.TabIndex = 25;
            // 
            // textBox20
            // 
            this.textBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox20.ForeColor = System.Drawing.Color.White;
            this.textBox20.Location = new System.Drawing.Point(0, 0);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(100, 22);
            this.textBox20.TabIndex = 26;
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox21.ForeColor = System.Drawing.Color.White;
            this.textBox21.Location = new System.Drawing.Point(0, 0);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(100, 22);
            this.textBox21.TabIndex = 27;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox22.ForeColor = System.Drawing.Color.White;
            this.textBox22.Location = new System.Drawing.Point(0, 0);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(100, 22);
            this.textBox22.TabIndex = 28;
            // 
            // label35
            // 
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(0, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(100, 23);
            this.label35.TabIndex = 29;
            // 
            // label36
            // 
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(0, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(100, 23);
            this.label36.TabIndex = 30;
            // 
            // label37
            // 
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(100, 23);
            this.label37.TabIndex = 31;
            // 
            // textBox23
            // 
            this.textBox23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox23.ForeColor = System.Drawing.Color.White;
            this.textBox23.Location = new System.Drawing.Point(0, 0);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(100, 22);
            this.textBox23.TabIndex = 32;
            // 
            // textBox24
            // 
            this.textBox24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox24.ForeColor = System.Drawing.Color.White;
            this.textBox24.Location = new System.Drawing.Point(0, 0);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(100, 22);
            this.textBox24.TabIndex = 33;
            // 
            // textBox25
            // 
            this.textBox25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox25.ForeColor = System.Drawing.Color.White;
            this.textBox25.Location = new System.Drawing.Point(0, 0);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(100, 22);
            this.textBox25.TabIndex = 34;
            // 
            // Parametre
            // 
            this.Parametre.BackColor = System.Drawing.Color.White;
            this.Parametre.Controls.Add(this.textBox51);
            this.Parametre.Controls.Add(this.panel1);
            this.Parametre.Controls.Add(this.panel4);
            this.Parametre.Controls.Add(this.panel6);
            this.Parametre.Controls.Add(this.panel2);
            this.Parametre.Controls.Add(this.button1);
            this.Parametre.Controls.Add(this.label1);
            this.Parametre.Controls.Add(this.Msk1panel);
            this.Parametre.Controls.Add(this.Otomatictestpanel);
            this.Parametre.Controls.Add(this.panel3);
            this.Parametre.Location = new System.Drawing.Point(-29, 0);
            this.Parametre.Name = "Parametre";
            this.Parametre.Size = new System.Drawing.Size(2059, 1037);
            this.Parametre.TabIndex = 19;
            this.Parametre.Visible = false;
            // 
            // textBox51
            // 
            this.textBox51.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox51.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox51.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox51.ForeColor = System.Drawing.Color.DarkBlue;
            this.textBox51.Location = new System.Drawing.Point(274, 3);
            this.textBox51.Name = "textBox51";
            this.textBox51.Size = new System.Drawing.Size(1782, 43);
            this.textBox51.TabIndex = 52;
            this.textBox51.Text = "Akım Kontrolcü Parametreleri";
            this.textBox51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox73);
            this.panel1.Controls.Add(this.msk2systemtyp);
            this.panel1.Controls.Add(this.msk2cardtemp);
            this.panel1.Controls.Add(this.MSK2batteryvoltage);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.textBox6);
            this.panel1.Controls.Add(this.textBox7);
            this.panel1.Controls.Add(this.textBox8);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.textBox12);
            this.panel1.Controls.Add(this.textBox13);
            this.panel1.Controls.Add(this.textBox14);
            this.panel1.Location = new System.Drawing.Point(1128, 511);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 405);
            this.panel1.TabIndex = 51;
            // 
            // textBox73
            // 
            this.textBox73.BackColor = System.Drawing.Color.LightGray;
            this.textBox73.Location = new System.Drawing.Point(264, 334);
            this.textBox73.Name = "textBox73";
            this.textBox73.Size = new System.Drawing.Size(180, 22);
            this.textBox73.TabIndex = 55;
            // 
            // msk2systemtyp
            // 
            this.msk2systemtyp.BackColor = System.Drawing.Color.LightGray;
            this.msk2systemtyp.Location = new System.Drawing.Point(264, 243);
            this.msk2systemtyp.Name = "msk2systemtyp";
            this.msk2systemtyp.Size = new System.Drawing.Size(180, 22);
            this.msk2systemtyp.TabIndex = 54;
            // 
            // msk2cardtemp
            // 
            this.msk2cardtemp.BackColor = System.Drawing.Color.LightGray;
            this.msk2cardtemp.Location = new System.Drawing.Point(264, 139);
            this.msk2cardtemp.Name = "msk2cardtemp";
            this.msk2cardtemp.Size = new System.Drawing.Size(180, 22);
            this.msk2cardtemp.TabIndex = 53;
            // 
            // MSK2batteryvoltage
            // 
            this.MSK2batteryvoltage.BackColor = System.Drawing.Color.LightGray;
            this.MSK2batteryvoltage.Location = new System.Drawing.Point(264, 42);
            this.MSK2batteryvoltage.Name = "MSK2batteryvoltage";
            this.MSK2batteryvoltage.Size = new System.Drawing.Size(180, 22);
            this.MSK2batteryvoltage.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "Hatalı Mesaj Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(20, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Kart Sıcaklığı";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 48;
            this.label7.Text = "Sistem Tip";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 20);
            this.label11.TabIndex = 47;
            this.label11.Text = "Anlık Batarya Voltajı";
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 23);
            this.label12.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 23);
            this.label20.TabIndex = 25;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 26;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 27;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox8.ForeColor = System.Drawing.Color.White;
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 22);
            this.textBox8.TabIndex = 28;
            // 
            // label21
            // 
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 29;
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 23);
            this.label22.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 23);
            this.label23.TabIndex = 31;
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox12.ForeColor = System.Drawing.Color.White;
            this.textBox12.Location = new System.Drawing.Point(0, 0);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 22);
            this.textBox12.TabIndex = 32;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox13.ForeColor = System.Drawing.Color.White;
            this.textBox13.Location = new System.Drawing.Point(0, 0);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 22);
            this.textBox13.TabIndex = 33;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox14.ForeColor = System.Drawing.Color.White;
            this.textBox14.Location = new System.Drawing.Point(0, 0);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 22);
            this.textBox14.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1284, 505);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 8);
            this.panel4.TabIndex = 50;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.MSK2AkimKD);
            this.panel6.Controls.Add(this.MSK2AkimKI);
            this.panel6.Controls.Add(this.MSK2AkimKp);
            this.panel6.Controls.Add(this.MSK2KD);
            this.panel6.Controls.Add(this.Mk2KI);
            this.panel6.Controls.Add(this.Msk2KP);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Controls.Add(this.label30);
            this.panel6.Controls.Add(this.button16);
            this.panel6.Controls.Add(this.label31);
            this.panel6.Controls.Add(this.label38);
            this.panel6.Controls.Add(this.label39);
            this.panel6.Controls.Add(this.label40);
            this.panel6.Controls.Add(this.textBox16);
            this.panel6.Controls.Add(this.textBox17);
            this.panel6.Controls.Add(this.button23);
            this.panel6.Controls.Add(this.Msk2QueryButton);
            this.panel6.Controls.Add(this.label41);
            this.panel6.Controls.Add(this.label42);
            this.panel6.Controls.Add(this.label43);
            this.panel6.Controls.Add(this.textBox18);
            this.panel6.Controls.Add(this.textBox19);
            this.panel6.Controls.Add(this.textBox26);
            this.panel6.Controls.Add(this.label44);
            this.panel6.Controls.Add(this.label45);
            this.panel6.Controls.Add(this.label79);
            this.panel6.Controls.Add(this.textBox27);
            this.panel6.Controls.Add(this.textBox28);
            this.panel6.Controls.Add(this.textBox29);
            this.panel6.Location = new System.Drawing.Point(1126, 73);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(571, 423);
            this.panel6.TabIndex = 49;
            // 
            // MSK2AkimKD
            // 
            this.MSK2AkimKD.Location = new System.Drawing.Point(386, 249);
            this.MSK2AkimKD.Name = "MSK2AkimKD";
            this.MSK2AkimKD.Size = new System.Drawing.Size(180, 22);
            this.MSK2AkimKD.TabIndex = 57;
            // 
            // MSK2AkimKI
            // 
            this.MSK2AkimKI.Location = new System.Drawing.Point(386, 182);
            this.MSK2AkimKI.Name = "MSK2AkimKI";
            this.MSK2AkimKI.Size = new System.Drawing.Size(180, 22);
            this.MSK2AkimKI.TabIndex = 56;
            // 
            // MSK2AkimKp
            // 
            this.MSK2AkimKp.Location = new System.Drawing.Point(386, 112);
            this.MSK2AkimKp.Name = "MSK2AkimKp";
            this.MSK2AkimKp.Size = new System.Drawing.Size(180, 22);
            this.MSK2AkimKp.TabIndex = 55;
            // 
            // MSK2KD
            // 
            this.MSK2KD.Location = new System.Drawing.Point(69, 254);
            this.MSK2KD.Name = "MSK2KD";
            this.MSK2KD.Size = new System.Drawing.Size(180, 22);
            this.MSK2KD.TabIndex = 54;
            // 
            // Mk2KI
            // 
            this.Mk2KI.Location = new System.Drawing.Point(69, 188);
            this.Mk2KI.Name = "Mk2KI";
            this.Mk2KI.Size = new System.Drawing.Size(180, 22);
            this.Mk2KI.TabIndex = 53;
            // 
            // Msk2KP
            // 
            this.Msk2KP.Location = new System.Drawing.Point(69, 117);
            this.Msk2KP.Name = "Msk2KP";
            this.Msk2KP.Size = new System.Drawing.Size(180, 22);
            this.Msk2KP.TabIndex = 52;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(15, 258);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(25, 16);
            this.label24.TabIndex = 50;
            this.label24.Text = "KD";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(15, 191);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 16);
            this.label25.TabIndex = 49;
            this.label25.Text = "KI";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.ForeColor = System.Drawing.Color.Black;
            this.label30.Location = new System.Drawing.Point(15, 120);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(24, 16);
            this.label30.TabIndex = 47;
            this.label30.Text = "KP";
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ForeColor = System.Drawing.Color.White;
            this.button16.Location = new System.Drawing.Point(69, 291);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(143, 38);
            this.button16.TabIndex = 48;
            this.button16.Text = "Değiştir";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label31.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label31.Location = new System.Drawing.Point(219, -1);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(132, 42);
            this.label31.TabIndex = 7;
            this.label31.Text = "MSK-2";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.ForeColor = System.Drawing.Color.Black;
            this.label38.Location = new System.Drawing.Point(346, 253);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(25, 16);
            this.label38.TabIndex = 22;
            this.label38.Text = "KD";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.ForeColor = System.Drawing.Color.Black;
            this.label39.Location = new System.Drawing.Point(346, 186);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(18, 16);
            this.label39.TabIndex = 21;
            this.label39.Text = "KI";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.ForeColor = System.Drawing.Color.Black;
            this.label40.Location = new System.Drawing.Point(346, 115);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(24, 16);
            this.label40.TabIndex = 20;
            this.label40.Text = "KP";
            // 
            // textBox16
            // 
            this.textBox16.BackColor = System.Drawing.Color.White;
            this.textBox16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox16.ForeColor = System.Drawing.Color.Black;
            this.textBox16.Location = new System.Drawing.Point(310, 49);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(258, 30);
            this.textBox16.TabIndex = 41;
            this.textBox16.Text = "Akım Kontrolcü Parametreleri";
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.White;
            this.textBox17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox17.ForeColor = System.Drawing.Color.Black;
            this.textBox17.Location = new System.Drawing.Point(13, 49);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(277, 30);
            this.textBox17.TabIndex = 20;
            this.textBox17.Text = "Pozisyon Kontrolcü Parametreleri";
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(179)))), ((int)(((byte)(113)))));
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.ForeColor = System.Drawing.Color.White;
            this.button23.Location = new System.Drawing.Point(400, 286);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(143, 38);
            this.button23.TabIndex = 20;
            this.button23.Text = "Değiştir";
            this.button23.UseVisualStyleBackColor = false;
            // 
            // Msk2QueryButton
            // 
            this.Msk2QueryButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.Msk2QueryButton.FlatAppearance.BorderSize = 0;
            this.Msk2QueryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Msk2QueryButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Msk2QueryButton.ForeColor = System.Drawing.Color.White;
            this.Msk2QueryButton.Location = new System.Drawing.Point(400, 374);
            this.Msk2QueryButton.Name = "Msk2QueryButton";
            this.Msk2QueryButton.Size = new System.Drawing.Size(143, 41);
            this.Msk2QueryButton.TabIndex = 20;
            this.Msk2QueryButton.Text = "Sorgula";
            this.Msk2QueryButton.UseVisualStyleBackColor = false;
            this.Msk2QueryButton.Click += new System.EventHandler(this.Msk2QueryButton_Click);
            // 
            // label41
            // 
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(-1, 37);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(100, 23);
            this.label41.TabIndex = 23;
            // 
            // label42
            // 
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(-1, 37);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(100, 23);
            this.label42.TabIndex = 24;
            // 
            // label43
            // 
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(-1, 37);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(100, 23);
            this.label43.TabIndex = 25;
            // 
            // textBox18
            // 
            this.textBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox18.ForeColor = System.Drawing.Color.White;
            this.textBox18.Location = new System.Drawing.Point(-1, 37);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 22);
            this.textBox18.TabIndex = 26;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox19.ForeColor = System.Drawing.Color.White;
            this.textBox19.Location = new System.Drawing.Point(-1, 37);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 22);
            this.textBox19.TabIndex = 27;
            // 
            // textBox26
            // 
            this.textBox26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox26.ForeColor = System.Drawing.Color.White;
            this.textBox26.Location = new System.Drawing.Point(-1, 37);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(100, 22);
            this.textBox26.TabIndex = 28;
            // 
            // label44
            // 
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(-1, 37);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(100, 23);
            this.label44.TabIndex = 29;
            // 
            // label45
            // 
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(-1, 37);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(100, 23);
            this.label45.TabIndex = 30;
            // 
            // label79
            // 
            this.label79.ForeColor = System.Drawing.Color.White;
            this.label79.Location = new System.Drawing.Point(-1, 37);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(100, 23);
            this.label79.TabIndex = 31;
            // 
            // textBox27
            // 
            this.textBox27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox27.ForeColor = System.Drawing.Color.White;
            this.textBox27.Location = new System.Drawing.Point(-1, 37);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(100, 22);
            this.textBox27.TabIndex = 32;
            // 
            // textBox28
            // 
            this.textBox28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox28.ForeColor = System.Drawing.Color.White;
            this.textBox28.Location = new System.Drawing.Point(-1, 37);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(100, 22);
            this.textBox28.TabIndex = 33;
            // 
            // textBox29
            // 
            this.textBox29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.textBox29.ForeColor = System.Drawing.Color.White;
            this.textBox29.Location = new System.Drawing.Point(-1, 37);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(100, 22);
            this.textBox29.TabIndex = 34;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 0;
            // 
            // lblWarning
            // 
            this.lblWarning.Location = new System.Drawing.Point(0, 0);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(100, 23);
            this.lblWarning.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.textBox2);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label70);
            this.panel5.Controls.Add(this.label71);
            this.panel5.Controls.Add(this.label72);
            this.panel5.Controls.Add(this.label73);
            this.panel5.Controls.Add(this.label64);
            this.panel5.Controls.Add(this.label65);
            this.panel5.Controls.Add(this.label66);
            this.panel5.Controls.Add(this.label67);
            this.panel5.Controls.Add(this.label68);
            this.panel5.Controls.Add(this.label69);
            this.panel5.Controls.Add(this.textBox50);
            this.panel5.Controls.Add(this.textBox53);
            this.panel5.Controls.Add(this.label74);
            this.panel5.Controls.Add(this.label75);
            this.panel5.Controls.Add(this.label76);
            this.panel5.Controls.Add(this.label77);
            this.panel5.Controls.Add(this.textBox54);
            this.panel5.Controls.Add(this.textBox55);
            this.panel5.Controls.Add(this.motorakim4otomatictext);
            this.panel5.Controls.Add(this.motorakim2otomatictext);
            this.panel5.Controls.Add(this.motor3akimotomatictext);
            this.panel5.Controls.Add(this.motorakimotomatictext);
            this.panel5.Controls.Add(this.motor4konumotomatictext);
            this.panel5.Controls.Add(this.motor2konumotomatictext);
            this.panel5.Controls.Add(this.motor3konumotomatictext);
            this.panel5.Controls.Add(this.motorkonumotomatictext);
            this.panel5.Controls.Add(this.tableLayoutPanel1);
            this.panel5.Location = new System.Drawing.Point(61, 76);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(553, 837);
            this.panel5.TabIndex = 22;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(131, 627);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 22);
            this.textBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(312, 581);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 22);
            this.textBox1.TabIndex = 52;
            // 
            // label70
            // 
            this.label70.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label70.ForeColor = System.Drawing.Color.Black;
            this.label70.Location = new System.Drawing.Point(3, 487);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(121, 18);
            this.label70.TabIndex = 51;
            this.label70.Text = "MOTOR- 2 AKIM";
            // 
            // label71
            // 
            this.label71.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label71.ForeColor = System.Drawing.Color.Black;
            this.label71.Location = new System.Drawing.Point(3, 445);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(121, 18);
            this.label71.TabIndex = 50;
            this.label71.Text = "MOTOR- 1 AKIM";
            // 
            // label72
            // 
            this.label72.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label72.ForeColor = System.Drawing.Color.Black;
            this.label72.Location = new System.Drawing.Point(2, 407);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(143, 18);
            this.label72.TabIndex = 49;
            this.label72.Text = "MOTOR- 2 KONUM";
            // 
            // label73
            // 
            this.label73.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label73.ForeColor = System.Drawing.Color.Black;
            this.label73.Location = new System.Drawing.Point(1, 366);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(143, 18);
            this.label73.TabIndex = 48;
            this.label73.Text = "MOTOR- 1 KONUM";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.ForeColor = System.Drawing.Color.Black;
            this.label64.Location = new System.Drawing.Point(14, 784);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(129, 16);
            this.label64.TabIndex = 24;
            this.label64.Text = "BESLEME GERİLİMİ";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.ForeColor = System.Drawing.Color.Black;
            this.label65.Location = new System.Drawing.Point(14, 749);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(110, 16);
            this.label65.TabIndex = 23;
            this.label65.Text = "SİSTEM ZAMANI";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label66.ForeColor = System.Drawing.Color.Black;
            this.label66.Location = new System.Drawing.Point(195, 626);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(107, 20);
            this.label66.TabIndex = 47;
            this.label66.Text = "Motor 4 Hata";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label67.ForeColor = System.Drawing.Color.Black;
            this.label67.Location = new System.Drawing.Point(194, 580);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(107, 20);
            this.label67.TabIndex = 46;
            this.label67.Text = "Motor 3 Hata";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label68.ForeColor = System.Drawing.Color.Black;
            this.label68.Location = new System.Drawing.Point(15, 626);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(107, 20);
            this.label68.TabIndex = 45;
            this.label68.Text = "Motor 2 Hata";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label69.ForeColor = System.Drawing.Color.Black;
            this.label69.Location = new System.Drawing.Point(15, 580);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(107, 20);
            this.label69.TabIndex = 22;
            this.label69.Text = "Motor 1 Hata";
            // 
            // textBox50
            // 
            this.textBox50.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox50.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox50.Location = new System.Drawing.Point(312, 624);
            this.textBox50.Name = "textBox50";
            this.textBox50.Size = new System.Drawing.Size(51, 22);
            this.textBox50.TabIndex = 43;
            // 
            // textBox53
            // 
            this.textBox53.BackColor = System.Drawing.Color.DarkCyan;
            this.textBox53.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox53.Location = new System.Drawing.Point(131, 581);
            this.textBox53.Name = "textBox53";
            this.textBox53.Size = new System.Drawing.Size(51, 22);
            this.textBox53.TabIndex = 40;
            // 
            // label74
            // 
            this.label74.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label74.ForeColor = System.Drawing.Color.Black;
            this.label74.Location = new System.Drawing.Point(232, 487);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(121, 18);
            this.label74.TabIndex = 35;
            this.label74.Text = "MOTOR- 4 AKIM";
            // 
            // label75
            // 
            this.label75.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label75.ForeColor = System.Drawing.Color.Black;
            this.label75.Location = new System.Drawing.Point(232, 448);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(121, 18);
            this.label75.TabIndex = 34;
            this.label75.Text = "MOTOR- 3 AKIM";
            // 
            // label76
            // 
            this.label76.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label76.ForeColor = System.Drawing.Color.Black;
            this.label76.Location = new System.Drawing.Point(232, 407);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(143, 18);
            this.label76.TabIndex = 33;
            this.label76.Text = "MOTOR- 4 KONUM";
            // 
            // label77
            // 
            this.label77.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label77.ForeColor = System.Drawing.Color.Black;
            this.label77.Location = new System.Drawing.Point(232, 366);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(143, 18);
            this.label77.TabIndex = 22;
            this.label77.Text = "MOTOR- 3 KONUM";
            // 
            // textBox54
            // 
            this.textBox54.Location = new System.Drawing.Point(149, 781);
            this.textBox54.Name = "textBox54";
            this.textBox54.Size = new System.Drawing.Size(199, 22);
            this.textBox54.TabIndex = 32;
            // 
            // textBox55
            // 
            this.textBox55.Location = new System.Drawing.Point(149, 743);
            this.textBox55.Name = "textBox55";
            this.textBox55.Size = new System.Drawing.Size(199, 22);
            this.textBox55.TabIndex = 31;
            // 
            // motorakim4otomatictext
            // 
            this.motorakim4otomatictext.Location = new System.Drawing.Point(384, 483);
            this.motorakim4otomatictext.Name = "motorakim4otomatictext";
            this.motorakim4otomatictext.Size = new System.Drawing.Size(52, 22);
            this.motorakim4otomatictext.TabIndex = 30;
            // 
            // motorakim2otomatictext
            // 
            this.motorakim2otomatictext.Location = new System.Drawing.Point(151, 483);
            this.motorakim2otomatictext.Name = "motorakim2otomatictext";
            this.motorakim2otomatictext.Size = new System.Drawing.Size(50, 22);
            this.motorakim2otomatictext.TabIndex = 29;
            // 
            // motor3akimotomatictext
            // 
            this.motor3akimotomatictext.Location = new System.Drawing.Point(383, 444);
            this.motor3akimotomatictext.Name = "motor3akimotomatictext";
            this.motor3akimotomatictext.Size = new System.Drawing.Size(52, 22);
            this.motor3akimotomatictext.TabIndex = 28;
            // 
            // motorakimotomatictext
            // 
            this.motorakimotomatictext.Location = new System.Drawing.Point(151, 444);
            this.motorakimotomatictext.Name = "motorakimotomatictext";
            this.motorakimotomatictext.Size = new System.Drawing.Size(50, 22);
            this.motorakimotomatictext.TabIndex = 27;
            // 
            // motor4konumotomatictext
            // 
            this.motor4konumotomatictext.Location = new System.Drawing.Point(383, 403);
            this.motor4konumotomatictext.Name = "motor4konumotomatictext";
            this.motor4konumotomatictext.Size = new System.Drawing.Size(52, 22);
            this.motor4konumotomatictext.TabIndex = 26;
            // 
            // motor2konumotomatictext
            // 
            this.motor2konumotomatictext.Location = new System.Drawing.Point(151, 403);
            this.motor2konumotomatictext.Name = "motor2konumotomatictext";
            this.motor2konumotomatictext.Size = new System.Drawing.Size(50, 22);
            this.motor2konumotomatictext.TabIndex = 25;
            // 
            // motor3konumotomatictext
            // 
            this.motor3konumotomatictext.Location = new System.Drawing.Point(383, 362);
            this.motor3konumotomatictext.Name = "motor3konumotomatictext";
            this.motor3konumotomatictext.Size = new System.Drawing.Size(53, 22);
            this.motor3konumotomatictext.TabIndex = 24;
            // 
            // motorkonumotomatictext
            // 
            this.motorkonumotomatictext.Location = new System.Drawing.Point(151, 362);
            this.motorkonumotomatictext.Name = "motorkonumotomatictext";
            this.motorkonumotomatictext.Size = new System.Drawing.Size(50, 22);
            this.motorkonumotomatictext.TabIndex = 23;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButton5, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.radioButton7, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox64, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButton8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox65, 0, 0);
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Wheat;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(37, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(479, 296);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // radioButton5
            // 
            this.radioButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton5.AutoCheck = false;
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.Black;
            this.radioButton5.Location = new System.Drawing.Point(314, 252);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(89, 20);
            this.radioButton5.TabIndex = 25;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "MOTOR-4";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton6.AutoCheck = false;
            this.radioButton6.AutoSize = true;
            this.radioButton6.ForeColor = System.Drawing.Color.Black;
            this.radioButton6.Location = new System.Drawing.Point(75, 252);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(89, 20);
            this.radioButton6.TabIndex = 25;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "MOTOR-2";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // radioButton7
            // 
            this.radioButton7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton7.AutoCheck = false;
            this.radioButton7.AutoSize = true;
            this.radioButton7.ForeColor = System.Drawing.Color.Black;
            this.radioButton7.Location = new System.Drawing.Point(314, 161);
            this.radioButton7.Name = "radioButton7";
            this.radioButton7.Size = new System.Drawing.Size(89, 20);
            this.radioButton7.TabIndex = 24;
            this.radioButton7.TabStop = true;
            this.radioButton7.Text = "MOTOR-3";
            this.radioButton7.UseVisualStyleBackColor = true;
            this.radioButton7.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // textBox64
            // 
            this.textBox64.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox64.BackColor = System.Drawing.Color.White;
            this.textBox64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox64.Location = new System.Drawing.Point(298, 49);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(122, 16);
            this.textBox64.TabIndex = 1;
            this.textBox64.Text = "MSK-2";
            this.textBox64.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton8
            // 
            this.radioButton8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButton8.AutoCheck = false;
            this.radioButton8.AutoSize = true;
            this.radioButton8.ForeColor = System.Drawing.Color.Black;
            this.radioButton8.Location = new System.Drawing.Point(75, 161);
            this.radioButton8.Name = "radioButton8";
            this.radioButton8.Size = new System.Drawing.Size(89, 20);
            this.radioButton8.TabIndex = 23;
            this.radioButton8.TabStop = true;
            this.radioButton8.Text = "MOTOR-1";
            this.radioButton8.UseVisualStyleBackColor = true;
            this.radioButton8.Click += new System.EventHandler(this.RadioButton_Click);
            // 
            // textBox65
            // 
            this.textBox65.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox65.BackColor = System.Drawing.Color.White;
            this.textBox65.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox65.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox65.Location = new System.Drawing.Point(57, 49);
            this.textBox65.Name = "textBox65";
            this.textBox65.Size = new System.Drawing.Size(126, 16);
            this.textBox65.TabIndex = 0;
            this.textBox65.Text = "MSK-1";
            this.textBox65.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFlowDescription
            // 
            this.lblFlowDescription.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblFlowDescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFlowDescription.Location = new System.Drawing.Point(1326, 87);
            this.lblFlowDescription.Name = "lblFlowDescription";
            this.lblFlowDescription.Size = new System.Drawing.Size(313, 810);
            this.lblFlowDescription.TabIndex = 22;
            this.lblFlowDescription.Text = resources.GetString("lblFlowDescription.Text");
            this.lblFlowDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // otomatictestchoise
            // 
            this.otomatictestchoise.BackColor = System.Drawing.Color.White;
            this.otomatictestchoise.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.otomatictestchoise.Controls.Add(this.txtEncoderLimit);
            this.otomatictestchoise.Controls.Add(this.btnApplyHighCurrent);
            this.otomatictestchoise.Controls.Add(this.chkHighCurrent);
            this.otomatictestchoise.Controls.Add(this.btnUpdate);
            this.otomatictestchoise.Controls.Add(this.lblEncoder);
            this.otomatictestchoise.Controls.Add(this.txtCurrentLimit);
            this.otomatictestchoise.Controls.Add(this.lblCurrent);
            this.otomatictestchoise.Controls.Add(this.btnStop);
            this.otomatictestchoise.Controls.Add(this.lblProduct);
            this.otomatictestchoise.Controls.Add(this.btnStart);
            this.otomatictestchoise.Controls.Add(this.txtProduct);
            this.otomatictestchoise.Controls.Add(this.lblTester);
            this.otomatictestchoise.Controls.Add(this.lblTest);
            this.otomatictestchoise.Controls.Add(this.txtTester);
            this.otomatictestchoise.Controls.Add(this.cmbTest);
            this.otomatictestchoise.Location = new System.Drawing.Point(776, 76);
            this.otomatictestchoise.Name = "otomatictestchoise";
            this.otomatictestchoise.Size = new System.Drawing.Size(426, 833);
            this.otomatictestchoise.TabIndex = 23;
            // 
            // txtEncoderLimit
            // 
            this.txtEncoderLimit.Location = new System.Drawing.Point(188, 440);
            this.txtEncoderLimit.Name = "txtEncoderLimit";
            this.txtEncoderLimit.Size = new System.Drawing.Size(150, 22);
            this.txtEncoderLimit.TabIndex = 18;
            // 
            // btnApplyHighCurrent
            // 
            this.btnApplyHighCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(62)))), ((int)(((byte)(74)))));
            this.btnApplyHighCurrent.Location = new System.Drawing.Point(47, 691);
            this.btnApplyHighCurrent.Name = "btnApplyHighCurrent";
            this.btnApplyHighCurrent.Size = new System.Drawing.Size(315, 82);
            this.btnApplyHighCurrent.TabIndex = 21;
            this.btnApplyHighCurrent.Text = "KİLİTLEME YÜKSEK AKIM UYGULA";
            this.btnApplyHighCurrent.UseVisualStyleBackColor = false;
            // 
            // chkHighCurrent
            // 
            this.chkHighCurrent.ForeColor = System.Drawing.Color.Black;
            this.chkHighCurrent.Location = new System.Drawing.Point(212, 609);
            this.chkHighCurrent.Name = "chkHighCurrent";
            this.chkHighCurrent.Size = new System.Drawing.Size(151, 24);
            this.chkHighCurrent.TabIndex = 20;
            this.chkHighCurrent.Text = "YÜKSEK AKIM";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Tomato;
            this.btnUpdate.Location = new System.Drawing.Point(240, 513);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 70);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // lblEncoder
            // 
            this.lblEncoder.ForeColor = System.Drawing.Color.Black;
            this.lblEncoder.Location = new System.Drawing.Point(42, 444);
            this.lblEncoder.Name = "lblEncoder";
            this.lblEncoder.Size = new System.Drawing.Size(159, 45);
            this.lblEncoder.TabIndex = 17;
            this.lblEncoder.Text = "ENKODER AŞIM LİMİTİ";
            // 
            // txtCurrentLimit
            // 
            this.txtCurrentLimit.Location = new System.Drawing.Point(188, 407);
            this.txtCurrentLimit.Name = "txtCurrentLimit";
            this.txtCurrentLimit.Size = new System.Drawing.Size(150, 22);
            this.txtCurrentLimit.TabIndex = 16;
            // 
            // lblCurrent
            // 
            this.lblCurrent.ForeColor = System.Drawing.Color.Black;
            this.lblCurrent.Location = new System.Drawing.Point(82, 407);
            this.lblCurrent.Name = "lblCurrent";
            this.lblCurrent.Size = new System.Drawing.Size(100, 23);
            this.lblCurrent.TabIndex = 15;
            this.lblCurrent.Text = "AKIM LİMİTİ";
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnStop.Location = new System.Drawing.Point(225, 289);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(122, 48);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "DURDUR";
            this.btnStop.UseVisualStyleBackColor = false;
            // 
            // lblProduct
            // 
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(35, 56);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(100, 23);
            this.lblProduct.TabIndex = 7;
            this.lblProduct.Text = "ÜRÜN";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkGreen;
            this.btnStart.Location = new System.Drawing.Point(86, 289);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(127, 48);
            this.btnStart.TabIndex = 13;
            this.btnStart.Text = "BAŞLA";
            this.btnStart.UseVisualStyleBackColor = false;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(154, 56);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(150, 22);
            this.txtProduct.TabIndex = 8;
            // 
            // lblTester
            // 
            this.lblTester.ForeColor = System.Drawing.Color.Black;
            this.lblTester.Location = new System.Drawing.Point(35, 123);
            this.lblTester.Name = "lblTester";
            this.lblTester.Size = new System.Drawing.Size(100, 23);
            this.lblTester.TabIndex = 9;
            this.lblTester.Text = "TEST EDEN";
            // 
            // lblTest
            // 
            this.lblTest.ForeColor = System.Drawing.Color.Black;
            this.lblTest.Location = new System.Drawing.Point(35, 188);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(100, 23);
            this.lblTest.TabIndex = 11;
            this.lblTest.Text = "TEST";
            // 
            // txtTester
            // 
            this.txtTester.Location = new System.Drawing.Point(159, 120);
            this.txtTester.Name = "txtTester";
            this.txtTester.Size = new System.Drawing.Size(150, 22);
            this.txtTester.TabIndex = 10;
            // 
            // cmbTest
            // 
            this.cmbTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTest.Items.AddRange(new object[] {
            "Test-1",
            "Test-2",
            "Test-3"});
            this.cmbTest.Location = new System.Drawing.Point(159, 184);
            this.cmbTest.Name = "cmbTest";
            this.cmbTest.Size = new System.Drawing.Size(150, 24);
            this.cmbTest.TabIndex = 22;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHeader.ForeColor = System.Drawing.Color.LightSlateGray;
            this.lblHeader.Location = new System.Drawing.Point(775, 48);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(408, 23);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "OTOMATİK TEST SEÇİMİ";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DarkGreen;
            this.progressBar1.Location = new System.Drawing.Point(1326, 66);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(313, 16);
            this.progressBar1.Step = 50;
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Value = 50;
            // 
            // otopanel
            // 
            this.otopanel.BackColor = System.Drawing.Color.White;
            this.otopanel.Controls.Add(this.label78);
            this.otopanel.Controls.Add(this.lblHeader);
            this.otopanel.Controls.Add(this.progressBar1);
            this.otopanel.Controls.Add(this.otomatictestchoise);
            this.otopanel.Controls.Add(this.panel5);
            this.otopanel.Controls.Add(this.lblFlowDescription);
            this.otopanel.Location = new System.Drawing.Point(239, 0);
            this.otopanel.Name = "otopanel";
            this.otopanel.Size = new System.Drawing.Size(1791, 1034);
            this.otopanel.TabIndex = 50;
            this.otopanel.Visible = false;
            // 
            // label78
            // 
            this.label78.BackColor = System.Drawing.Color.Transparent;
            this.label78.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label78.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label78.Location = new System.Drawing.Point(57, 48);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(408, 23);
            this.label78.TabIndex = 25;
            this.label78.Text = "Motor Aktif Etme";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Motor";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "MSK-1";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "MSK-2";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "MSK-3";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "MSK-4";
            this.dataGridViewTextBoxColumn15.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Motor";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "MSK-1";
            this.dataGridViewTextBoxColumn17.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 125;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "MSK-2";
            this.dataGridViewTextBoxColumn18.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 125;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.HeaderText = "MSK-3";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 125;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.HeaderText = "MSK-4";
            this.dataGridViewTextBoxColumn20.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            this.dataGridViewTextBoxColumn20.Width = 125;
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.HeaderText = "Motor";
            this.dataGridViewTextBoxColumn21.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            this.dataGridViewTextBoxColumn21.Width = 125;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "MSK-1";
            this.dataGridViewTextBoxColumn22.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 125;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.HeaderText = "MSK-2";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 125;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.HeaderText = "MSK-3";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 125;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.HeaderText = "MSK-4";
            this.dataGridViewTextBoxColumn25.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 125;
            // 
            // dataGridViewTextBoxColumn26
            // 
            this.dataGridViewTextBoxColumn26.HeaderText = "Motor";
            this.dataGridViewTextBoxColumn26.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
            this.dataGridViewTextBoxColumn26.Width = 125;
            // 
            // dataGridViewTextBoxColumn27
            // 
            this.dataGridViewTextBoxColumn27.HeaderText = "MSK-1";
            this.dataGridViewTextBoxColumn27.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn27.Name = "dataGridViewTextBoxColumn27";
            this.dataGridViewTextBoxColumn27.Width = 125;
            // 
            // dataGridViewTextBoxColumn28
            // 
            this.dataGridViewTextBoxColumn28.HeaderText = "MSK-2";
            this.dataGridViewTextBoxColumn28.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn28.Name = "dataGridViewTextBoxColumn28";
            this.dataGridViewTextBoxColumn28.Width = 125;
            // 
            // dataGridViewTextBoxColumn29
            // 
            this.dataGridViewTextBoxColumn29.HeaderText = "MSK-3";
            this.dataGridViewTextBoxColumn29.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn29.Name = "dataGridViewTextBoxColumn29";
            this.dataGridViewTextBoxColumn29.Width = 125;
            // 
            // dataGridViewTextBoxColumn30
            // 
            this.dataGridViewTextBoxColumn30.HeaderText = "MSK-4";
            this.dataGridViewTextBoxColumn30.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn30.Name = "dataGridViewTextBoxColumn30";
            this.dataGridViewTextBoxColumn30.Width = 125;
            // 
            // dataGridViewTextBoxColumn31
            // 
            this.dataGridViewTextBoxColumn31.HeaderText = "Motor";
            this.dataGridViewTextBoxColumn31.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
            this.dataGridViewTextBoxColumn31.Width = 125;
            // 
            // dataGridViewTextBoxColumn32
            // 
            this.dataGridViewTextBoxColumn32.HeaderText = "MSK-1";
            this.dataGridViewTextBoxColumn32.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
            this.dataGridViewTextBoxColumn32.Width = 125;
            // 
            // dataGridViewTextBoxColumn33
            // 
            this.dataGridViewTextBoxColumn33.HeaderText = "MSK-2";
            this.dataGridViewTextBoxColumn33.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
            this.dataGridViewTextBoxColumn33.Width = 125;
            // 
            // dataGridViewTextBoxColumn34
            // 
            this.dataGridViewTextBoxColumn34.HeaderText = "MSK-3";
            this.dataGridViewTextBoxColumn34.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
            this.dataGridViewTextBoxColumn34.Width = 125;
            // 
            // dataGridViewTextBoxColumn35
            // 
            this.dataGridViewTextBoxColumn35.HeaderText = "MSK-4";
            this.dataGridViewTextBoxColumn35.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
            this.dataGridViewTextBoxColumn35.Width = 125;
            // 
            // dataGridViewTextBoxColumn36
            // 
            this.dataGridViewTextBoxColumn36.HeaderText = "Motor";
            this.dataGridViewTextBoxColumn36.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
            this.dataGridViewTextBoxColumn36.Width = 125;
            // 
            // dataGridViewTextBoxColumn37
            // 
            this.dataGridViewTextBoxColumn37.HeaderText = "MSK-1";
            this.dataGridViewTextBoxColumn37.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn37.Name = "dataGridViewTextBoxColumn37";
            this.dataGridViewTextBoxColumn37.Width = 125;
            // 
            // dataGridViewTextBoxColumn38
            // 
            this.dataGridViewTextBoxColumn38.HeaderText = "MSK-2";
            this.dataGridViewTextBoxColumn38.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
            this.dataGridViewTextBoxColumn38.Width = 125;
            // 
            // dataGridViewTextBoxColumn39
            // 
            this.dataGridViewTextBoxColumn39.HeaderText = "MSK-3";
            this.dataGridViewTextBoxColumn39.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn39.Name = "dataGridViewTextBoxColumn39";
            this.dataGridViewTextBoxColumn39.Width = 125;
            // 
            // dataGridViewTextBoxColumn40
            // 
            this.dataGridViewTextBoxColumn40.HeaderText = "MSK-4";
            this.dataGridViewTextBoxColumn40.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn40.Name = "dataGridViewTextBoxColumn40";
            this.dataGridViewTextBoxColumn40.Width = 125;
            // 
            // dataGridViewTextBoxColumn41
            // 
            this.dataGridViewTextBoxColumn41.HeaderText = "Motor";
            this.dataGridViewTextBoxColumn41.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
            this.dataGridViewTextBoxColumn41.Width = 125;
            // 
            // dataGridViewTextBoxColumn42
            // 
            this.dataGridViewTextBoxColumn42.HeaderText = "MSK-1";
            this.dataGridViewTextBoxColumn42.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
            this.dataGridViewTextBoxColumn42.Width = 125;
            // 
            // dataGridViewTextBoxColumn43
            // 
            this.dataGridViewTextBoxColumn43.HeaderText = "MSK-2";
            this.dataGridViewTextBoxColumn43.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
            this.dataGridViewTextBoxColumn43.Width = 125;
            // 
            // dataGridViewTextBoxColumn44
            // 
            this.dataGridViewTextBoxColumn44.HeaderText = "MSK-3";
            this.dataGridViewTextBoxColumn44.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
            this.dataGridViewTextBoxColumn44.Width = 125;
            // 
            // dataGridViewTextBoxColumn45
            // 
            this.dataGridViewTextBoxColumn45.HeaderText = "MSK-4";
            this.dataGridViewTextBoxColumn45.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn45.Name = "dataGridViewTextBoxColumn45";
            this.dataGridViewTextBoxColumn45.Width = 125;
            // 
            // PanelHomepage
            // 
            this.PanelHomepage.BackColor = System.Drawing.Color.White;
            this.PanelHomepage.Controls.Add(this.label83);
            this.PanelHomepage.Controls.Add(this.msk2packetpanel);
            this.PanelHomepage.Controls.Add(this.label82);
            this.PanelHomepage.Controls.Add(this.label80);
            this.PanelHomepage.Controls.Add(this.label52);
            this.PanelHomepage.Controls.Add(this.label53);
            this.PanelHomepage.Controls.Add(this.msk1packetpanel);
            this.PanelHomepage.Controls.Add(this.SendText3);
            this.PanelHomepage.Controls.Add(this.SelectedProtocol3);
            this.PanelHomepage.Controls.Add(this.buttonOpenPort3);
            this.PanelHomepage.Controls.Add(this.comboBoxPorts3);
            this.PanelHomepage.Controls.Add(this.timetextbox);
            this.PanelHomepage.Controls.Add(this.mesajtext);
            this.PanelHomepage.Controls.Add(this.groupBox1);
            this.PanelHomepage.Controls.Add(this.SendText2);
            this.PanelHomepage.Controls.Add(this.comboBoxPorts2);
            this.PanelHomepage.Controls.Add(this.buttonOpenPort2);
            this.PanelHomepage.Controls.Add(this.comboBoxPorts);
            this.PanelHomepage.Controls.Add(this.buttonOpenPort);
            this.PanelHomepage.Controls.Add(this.SelectedProtocol);
            this.PanelHomepage.Controls.Add(this.SendText);
            this.PanelHomepage.Controls.Add(this.textBoxSendData);
            this.PanelHomepage.Controls.Add(this.SelectedProtocol2);
            this.PanelHomepage.Controls.Add(this.groupBoxCrcResults);
            this.PanelHomepage.Location = new System.Drawing.Point(3, 0);
            this.PanelHomepage.Name = "PanelHomepage";
            this.PanelHomepage.Size = new System.Drawing.Size(1931, 1023);
            this.PanelHomepage.TabIndex = 26;
            // 
            // label83
            // 
            this.label83.BackColor = System.Drawing.Color.Transparent;
            this.label83.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label83.ForeColor = System.Drawing.Color.Black;
            this.label83.Location = new System.Drawing.Point(1539, 48);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(290, 23);
            this.label83.TabIndex = 36;
            this.label83.Text = "VERİ ALIMI PAKETİ - MSK - 2";
            // 
            // msk2packetpanel
            // 
            this.msk2packetpanel.BackColor = System.Drawing.Color.White;
            this.msk2packetpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk2packetpanel.Controls.Add(this.label50);
            this.msk2packetpanel.Controls.Add(this.comboBox13);
            this.msk2packetpanel.Controls.Add(this.label51);
            this.msk2packetpanel.Controls.Add(this.comboBox14);
            this.msk2packetpanel.Controls.Add(this.radioPanel2);
            this.msk2packetpanel.Location = new System.Drawing.Point(1481, 79);
            this.msk2packetpanel.Name = "msk2packetpanel";
            this.msk2packetpanel.Size = new System.Drawing.Size(410, 833);
            this.msk2packetpanel.TabIndex = 35;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Location = new System.Drawing.Point(138, 450);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(150, 28);
            this.label50.TabIndex = 23;
            this.label50.Text = "SİSTEM ANALİZ MODU";
            // 
            // comboBox13
            // 
            this.comboBox13.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox13.Items.AddRange(new object[] {
            "Seçenek-1",
            "Seçenek-2",
            "Seçenek-3",
            "Test-1",
            "Test-2",
            "Test-3"});
            this.comboBox13.Location = new System.Drawing.Point(132, 495);
            this.comboBox13.Name = "comboBox13";
            this.comboBox13.Size = new System.Drawing.Size(150, 24);
            this.comboBox13.TabIndex = 24;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label51.ForeColor = System.Drawing.Color.Black;
            this.label51.Location = new System.Drawing.Point(162, 550);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(100, 23);
            this.label51.TabIndex = 25;
            this.label51.Text = "SÜRÜŞ MODU";
            // 
            // comboBox14
            // 
            this.comboBox14.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox14.Items.AddRange(new object[] {
            "Test-1",
            "Test-2",
            "Test-3"});
            this.comboBox14.Location = new System.Drawing.Point(132, 590);
            this.comboBox14.Name = "comboBox14";
            this.comboBox14.Size = new System.Drawing.Size(150, 24);
            this.comboBox14.TabIndex = 26;
            // 
            // radioPanel2
            // 
            this.radioPanel2.Location = new System.Drawing.Point(10, 50);
            this.radioPanel2.Name = "radioPanel2";
            this.radioPanel2.Size = new System.Drawing.Size(400, 300);
            this.radioPanel2.TabIndex = 27;
            // 
            // label82
            // 
            this.label82.ForeColor = System.Drawing.Color.Black;
            this.label82.Location = new System.Drawing.Point(244, 94);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(74, 22);
            this.label82.TabIndex = 34;
            this.label82.Text = "P.Supply";
            // 
            // label80
            // 
            this.label80.ForeColor = System.Drawing.Color.Black;
            this.label80.Location = new System.Drawing.Point(244, 54);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(74, 22);
            this.label80.TabIndex = 33;
            this.label80.Text = "Motor-2";
            // 
            // label52
            // 
            this.label52.ForeColor = System.Drawing.Color.Black;
            this.label52.Location = new System.Drawing.Point(244, 24);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(74, 22);
            this.label52.TabIndex = 32;
            this.label52.Text = "Motor-1";
            // 
            // label53
            // 
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label53.ForeColor = System.Drawing.Color.Black;
            this.label53.Location = new System.Drawing.Point(1126, 47);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(290, 23);
            this.label53.TabIndex = 30;
            this.label53.Text = "VERİ ALIMI PAKETİ - MSK - 1";
            // 
            // msk1packetpanel
            // 
            this.msk1packetpanel.BackColor = System.Drawing.Color.White;
            this.msk1packetpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.msk1packetpanel.Controls.Add(this.label47);
            this.msk1packetpanel.Controls.Add(this.systemanalysismode);
            this.msk1packetpanel.Controls.Add(this.label48);
            this.msk1packetpanel.Controls.Add(this.comboBox12);
            this.msk1packetpanel.Controls.Add(this.radioPanel);
            this.msk1packetpanel.Location = new System.Drawing.Point(1046, 80);
            this.msk1packetpanel.Name = "msk1packetpanel";
            this.msk1packetpanel.Size = new System.Drawing.Size(413, 833);
            this.msk1packetpanel.TabIndex = 31;
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label47.ForeColor = System.Drawing.Color.Black;
            this.label47.Location = new System.Drawing.Point(138, 450);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(150, 28);
            this.label47.TabIndex = 23;
            this.label47.Text = "SİSTEM ANALİZ MODU";
            // 
            // systemanalysismode
            // 
            this.systemanalysismode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.systemanalysismode.Items.AddRange(new object[] {
            "0-None",
            "1-Current2Current",
            "2-Position2Position"});
            this.systemanalysismode.Location = new System.Drawing.Point(132, 495);
            this.systemanalysismode.Name = "systemanalysismode";
            this.systemanalysismode.Size = new System.Drawing.Size(150, 24);
            this.systemanalysismode.TabIndex = 24;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label48.ForeColor = System.Drawing.Color.Black;
            this.label48.Location = new System.Drawing.Point(162, 550);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(100, 23);
            this.label48.TabIndex = 25;
            this.label48.Text = "SÜRÜŞ MODU";
            // 
            // comboBox12
            // 
            this.comboBox12.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox12.Items.AddRange(new object[] {
            "0: None",
            "1: Position",
            "2: Current",
            "3: PWM"});
            this.comboBox12.Location = new System.Drawing.Point(132, 590);
            this.comboBox12.Name = "comboBox12";
            this.comboBox12.Size = new System.Drawing.Size(150, 24);
            this.comboBox12.TabIndex = 26;
            // 
            // radioPanel
            // 
            this.radioPanel.Location = new System.Drawing.Point(10, 50);
            this.radioPanel.Name = "radioPanel";
            this.radioPanel.Size = new System.Drawing.Size(400, 300);
            this.radioPanel.TabIndex = 27;
            // 
            // comboBoxPorts3
            // 
            this.comboBoxPorts3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxPorts3.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts3.FormattingEnabled = true;
            this.comboBoxPorts3.Location = new System.Drawing.Point(324, 54);
            this.comboBoxPorts3.Name = "comboBoxPorts3";
            this.comboBoxPorts3.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts3.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBox1.Controls.Add(this.comboBox3);
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(256, 726);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 251);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CRC Sonuçları";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox3.ForeColor = System.Drawing.Color.White;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(1, 24);
            this.comboBox3.TabIndex = 21;
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox4.ForeColor = System.Drawing.Color.White;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(3, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(1, 24);
            this.comboBox4.TabIndex = 20;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(725, 295);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(120, 35);
            this.button5.TabIndex = 19;
            this.button5.Text = "Excel Kaydet";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(490, 295);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 35);
            this.button6.TabIndex = 18;
            this.button6.Text = "TXT Kaydet";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gray;
            this.dataGridView1.Location = new System.Drawing.Point(13, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.Size = new System.Drawing.Size(750, 213);
            this.dataGridView1.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Gönderilen Veri";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Gönderilen CRC";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Alınan Veri";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Alınan CRC";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn10.HeaderText = "Zaman";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // comboBoxPorts2
            // 
            this.comboBoxPorts2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxPorts2.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts2.FormattingEnabled = true;
            this.comboBoxPorts2.Location = new System.Drawing.Point(324, 91);
            this.comboBoxPorts2.Name = "comboBoxPorts2";
            this.comboBoxPorts2.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts2.TabIndex = 10;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBoxPorts.ForeColor = System.Drawing.Color.White;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(324, 23);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // groupBoxCrcResults
            // 
            this.groupBoxCrcResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.groupBoxCrcResults.Controls.Add(this.comboBox2);
            this.groupBoxCrcResults.Controls.Add(this.comboBox1);
            this.groupBoxCrcResults.Controls.Add(this.buttonSaveExcel);
            this.groupBoxCrcResults.Controls.Add(this.buttonSaveTxt);
            this.groupBoxCrcResults.Controls.Add(this.dataGridViewCrcResults);
            this.groupBoxCrcResults.ForeColor = System.Drawing.Color.White;
            this.groupBoxCrcResults.Location = new System.Drawing.Point(256, 387);
            this.groupBoxCrcResults.Name = "groupBoxCrcResults";
            this.groupBoxCrcResults.Size = new System.Drawing.Size(769, 306);
            this.groupBoxCrcResults.TabIndex = 17;
            this.groupBoxCrcResults.TabStop = false;
            this.groupBoxCrcResults.Text = "CRC Sonuçları";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox2.ForeColor = System.Drawing.Color.White;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(1, 24);
            this.comboBox2.TabIndex = 21;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.comboBox1.ForeColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(1, 24);
            this.comboBox1.TabIndex = 20;
            // 
            // buttonSaveExcel
            // 
            this.buttonSaveExcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.buttonSaveExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveExcel.ForeColor = System.Drawing.Color.White;
            this.buttonSaveExcel.Location = new System.Drawing.Point(602, 271);
            this.buttonSaveExcel.Name = "buttonSaveExcel";
            this.buttonSaveExcel.Size = new System.Drawing.Size(120, 29);
            this.buttonSaveExcel.TabIndex = 19;
            this.buttonSaveExcel.Text = "Excel Kaydet";
            this.buttonSaveExcel.UseVisualStyleBackColor = false;
            this.buttonSaveExcel.Click += new System.EventHandler(this.buttonSaveExcel_Click);
            // 
            // buttonSaveTxt
            // 
            this.buttonSaveTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.buttonSaveTxt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveTxt.ForeColor = System.Drawing.Color.White;
            this.buttonSaveTxt.Location = new System.Drawing.Point(427, 268);
            this.buttonSaveTxt.Name = "buttonSaveTxt";
            this.buttonSaveTxt.Size = new System.Drawing.Size(120, 32);
            this.buttonSaveTxt.TabIndex = 18;
            this.buttonSaveTxt.Text = "TXT Kaydet";
            this.buttonSaveTxt.UseVisualStyleBackColor = false;
            this.buttonSaveTxt.Click += new System.EventHandler(this.buttonSaveTxt_Click);
            // 
            // dataGridViewCrcResults
            // 
            this.dataGridViewCrcResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCrcResults.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dataGridViewCrcResults.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewCrcResults.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            this.dataGridViewCrcResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCrcResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCrcResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCrcResults.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewCrcResults.EnableHeadersVisualStyles = false;
            this.dataGridViewCrcResults.GridColor = System.Drawing.Color.Gray;
            this.dataGridViewCrcResults.Location = new System.Drawing.Point(3, 33);
            this.dataGridViewCrcResults.Name = "dataGridViewCrcResults";
            this.dataGridViewCrcResults.RowHeadersWidth = 30;
            this.dataGridViewCrcResults.RowTemplate.Height = 35;
            this.dataGridViewCrcResults.Size = new System.Drawing.Size(747, 232);
            this.dataGridViewCrcResults.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Gönderilen Veri";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Gönderilen CRC";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Alınan Veri";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Alınan CRC";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Zaman";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // DataGriderrormotor2
            // 
            this.DataGriderrormotor2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGriderrormotor2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DataGriderrormotor2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGriderrormotor2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.DataGriderrormotor2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGriderrormotor2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGriderrormotor2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn66});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGriderrormotor2.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGriderrormotor2.EnableHeadersVisualStyles = false;
            this.DataGriderrormotor2.GridColor = System.Drawing.Color.Gray;
            this.DataGriderrormotor2.Location = new System.Drawing.Point(419, 132);
            this.DataGriderrormotor2.Name = "DataGriderrormotor2";
            this.DataGriderrormotor2.RowHeadersWidth = 30;
            this.DataGriderrormotor2.RowTemplate.Height = 35;
            this.DataGriderrormotor2.Size = new System.Drawing.Size(386, 779);
            this.DataGriderrormotor2.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn66
            // 
            this.dataGridViewTextBoxColumn66.HeaderText = "Motor-2";
            this.dataGridViewTextBoxColumn66.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn66.Name = "dataGridViewTextBoxColumn66";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1924, 1037);
            this.Controls.Add(this.navbar);
            this.Controls.Add(this.ErrorPanel);
            this.Controls.Add(this.Parametre);
            this.Controls.Add(this.PanelHomepage);
            this.Controls.Add(this.otopanel);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.PanelManuelTest);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ErrorPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridErrormotor1)).EndInit();
            this.errorstatuspaneltitle.ResumeLayout(false);
            this.MSK2paneltitle.ResumeLayout(false);
            this.MSK1paneltitle.ResumeLayout(false);
            this.PanelManuelTest.ResumeLayout(false);
            this.PanelManuelTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angleTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gaugePictureBox)).EndInit();
            this.ManuelTestMotor.ResumeLayout(false);
            this.ManuelTestMotor.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.navbar.ResumeLayout(false);
            this.navbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.Msk1panel.ResumeLayout(false);
            this.Msk1panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Parametre.ResumeLayout(false);
            this.Parametre.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.otomatictestchoise.ResumeLayout(false);
            this.otomatictestchoise.PerformLayout();
            this.otopanel.ResumeLayout(false);
            this.PanelHomepage.ResumeLayout(false);
            this.PanelHomepage.PerformLayout();
            this.msk2packetpanel.ResumeLayout(false);
            this.msk1packetpanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxCrcResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCrcResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGriderrormotor2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCrcResults;

        private Panel Dashboard;
        private Panel ErrorPanel;

        private Panel navbar;
        private Button ExitButton;
        private Button ErrorPanelButton;
        private Button ParametreButton;
        private Button DashboardButton;
        private DataGridViewTextBoxColumn ColumnTime;
        private DataGridViewTextBoxColumn ColumnProtocol;
        private DataGridViewTextBoxColumn ColumnErrorMessage;
        private TextBox KP2;
        private TextBox KP3;
        private Button OtomaticTestButton;
        private Button button26;
        private Panel PanelManuelTest;
        private Panel ManuelTestMotor;
        private TextBox textBox32;
        private TextBox textBox31;
        private RadioButton Motor3Enabledbutton;
        private RadioButton Motor1Enabledbutton;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton Motor4Enabledbutton;
        private RadioButton Motor2Enabledbutton;
        private Label motor1akim;
        private TextBox textBox42;
        private TextBox textBox41;
        private TextBox motor2currenttext;
        private TextBox motor1currenttext;
        private TextBox motor2positiontext;
        private TextBox Motor1positiontext;
        private Label label49;
        private Label label55;
        private TextBox textBox46;
        private TextBox textBox45;
        private TextBox textBox44;
        private TextBox textBox43;
        private Label motor2konum;
        private Label motor2akim;
        private Label label58;
        private Label label57;
        private Label label56;
        private Label label60;
        private Label label59;
        private Label label61;
        private PictureBox gaugePictureBox;
        private TrackBar angleTrackBar;
        private TrackBar angleTrackBar3;
        private PictureBox gaugePictureBox3;
        private TrackBar angleTrackBar4;
        private PictureBox gaugePictureBox4;
        private Button ManuelTestCommandButton;
        private Button button28;
        private Label label63;
        private TextBox textBoxPositionmotor4;
        private TextBox textBoxPositionmotor3;
        private TextBox textBoxPositionmotor2;
        private Label label62;
        private Label label54;
        private Button button34;
        private Button Motor1ManuelGraphButton;
        private Button button32;
        private Button button31;
        private Button button30;
        private Label msk1label;
        private Panel Msk1panel;
        private Label label17;
        private Label label18;
        private Label label19;
        private TextBox textBox15;
        private TextBox PositionControlParameter;
        private Button Mskchange2Button;
        private Button MskQueryButton;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Panel Otomatictestpanel;
        private TextBox textBox49;
        private Label label1;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Label label29;
        private Label label28;
        private Label label27;
        private Label label26;
        private Label label32;
        private Label label33;
        private Label label34;
        private TextBox textBox20;
        private TextBox textBox21;
        private TextBox textBox22;
        private Label label35;
        private Label label36;
        private Label label37;
        private TextBox textBox23;
        private TextBox textBox24;
        private TextBox textBox25;
        private Panel Parametre;
        private PictureBox pictureBox5;
        private ProgressBar progressBar;
        private Label lblWarning;
        private TextBox textBox66;
        private Panel panel5;
        private Label label64;
        private Label label65;
        private Label label66;
        private Label label67;
        private Label label68;
        private Label label69;
        private TextBox textBox50;
        private TextBox textBox53;
        private Label label74;
        private Label label75;
        private Label label76;
        private Label label77;
        private TextBox textBox54;
        private TextBox textBox55;
        private TextBox motorakim4otomatictext;
        private TextBox motorakim2otomatictext;
        private TextBox motor3akimotomatictext;
        private TextBox motorakimotomatictext;
        private TextBox motor4konumotomatictext;
        private TextBox motor2konumotomatictext;
        private TextBox motor3konumotomatictext;
        private TextBox motorkonumotomatictext;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton7;
        private TextBox textBox64;
        private RadioButton radioButton8;
        private TextBox textBox65;
        private Label lblFlowDescription;
        private Panel otomatictestchoise;
        private TextBox txtEncoderLimit;
        private Button btnApplyHighCurrent;
        private CheckBox chkHighCurrent;
        private Button btnUpdate;
        private Label lblEncoder;
        private TextBox txtCurrentLimit;
        private Label lblCurrent;
        private Button btnStop;
        private Label lblProduct;
        private Button btnStart;
        private TextBox txtProduct;
        private Label lblTester;
        private Label lblTest;
        private TextBox txtTester;
        private ComboBox cmbTest;
        private Label lblHeader;
        private ProgressBar progressBar1;
        private Panel otopanel;
        private Label label78;
        private Label label70;
        private Label label71;
        private Label label72;
        private Label label73;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button11;
        private TextBox textBox51;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label20;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label21;
        private Label label22;
        private Label label23;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Panel panel4;
        private Panel panel6;
        private Label label24;
        private Label label25;
        private Label label30;
        private Button button16;
        private Label label31;
        private Label label38;
        private Label label39;
        private Label label40;
        private TextBox textBox16;
        private TextBox textBox17;
        private Button button23;
        private Button Msk2QueryButton;
        private Label label41;
        private Label label42;
        private Label label43;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox26;
        private Label label44;
        private Label label45;
        private Label label79;
        private TextBox textBox27;
        private TextBox textBox28;
        private TextBox textBox29;
        private PictureBox pictureBox;
        private TextBox MSK1AkimKD;
        private TextBox MSK1AkimKI;
        private TextBox MSK1AkimKp;
        private TextBox MSK1KD;
        private TextBox Mk1KI;
        private TextBox Msk1KP;
        private TextBox textBox69;
        private TextBox msk1systemtyp;
        private TextBox msk1cardtemp;
        private TextBox MSK1batteryvoltage;
        private TextBox textBox73;
        private TextBox msk2systemtyp;
        private TextBox msk2cardtemp;
        private TextBox MSK2batteryvoltage;
        private TextBox MSK2AkimKD;
        private TextBox MSK2AkimKI;
        private TextBox MSK2AkimKp;
        private TextBox MSK2KD;
        private TextBox Mk2KI;
        private TextBox Msk2KP;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn27;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn28;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn29;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn30;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn37;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn39;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn40;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn45;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn46;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn47;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn48;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn49;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn50;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn51;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn52;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn56;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn57;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn58;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn59;
        private Panel MSK2paneltitle;
        private Panel MSK1paneltitle;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Panel errorstatuspaneltitle;
        private RichTextBox richTextBox3;
        private Label motor4konum;
        private Label label81;
        private Label motor3konum;
        private Label motor3akim;
        private TextBox motor4currenttext;
        private TextBox motor3currenttext;
        private TextBox Motor4positiontext;
        private TextBox Motor3positiontext;
        private TextBox textBox33;
        private TextBox textBox34;
        private TextBox textBox36;
        private TextBox textBox35;
        private TextBox Motor4DegParametertext;
        private TextBox Motor3DegParametertext;
        private TextBox Motor2DegParametertext;
        private TextBox Motor1DegParametertext;
        private Panel PanelHomepage;
        private Button HomePageButton;
        private Label label53;
        private TextBox mesajtext;
        private TextBox timetextbox;
        private Panel msk1packetpanel;
        private Label label48;
        private ComboBox comboBox12;
        private Label label47;
        private ComboBox systemanalysismode;
        private Label label52;
        private Label label80;
        private Label label82;
        private Panel msk2packetpanel;
        private Label label50;
        private ComboBox comboBox13;
        private Label label51;
        private ComboBox comboBox14;
        private Panel radioPanel2;
        private Label label83;
        private Button SendText3;
        private ComboBox SelectedProtocol3;
        private Button buttonOpenPort3;
        private Button SendText2;
        private Button buttonOpenPort2;
        private Button buttonOpenPort;
        private ComboBox SelectedProtocol;
        private Button SendText;
        private TextBox textBoxSendData;
        private ComboBox SelectedProtocol2;
        private ComboBox comboBoxPorts3;
        private ComboBox comboBoxPorts2;
        private ComboBox comboBoxPorts;
        private GroupBox groupBox1;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button button5;
        private Button button6;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private GroupBox groupBoxCrcResults;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button buttonSaveExcel;
        private Button buttonSaveTxt;
        private DataGridView dataGridViewCrcResults;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridView DataGridErrormotor1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn60;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn61;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn62;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn63;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn64;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn65;
        private DataGridView DataGriderrormotor2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn66;
    }



}