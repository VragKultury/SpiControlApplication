using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SPI_Control;

namespace SPI_Control
{
    public partial class MainForm : Form
    {
        public static CommunicationManager comm = new CommunicationManager();
        string transType = string.Empty;
        public static int cnt1;

        public static int TimeDelay = 250;
        public static bool Timer_edit = false;
        public static bool MainSend_Tick = false;
        public static ushort MainSend_cnt;

        public static bool PortStatus;
        public static bool SerialTimer;
        public static bool SerialChanged;

        public static string PortName;
        public static string PortBaudRate;
        public static string PortParity;
        public static string PortDataBits;
        public static string PortStopBits;

        public static ushort MainSend_flag;
        public static string TestMessage;
        public static string[] msgSelectedFields = new string[10];

        public static MessageManager msgManager = new MessageManager();
        
        public static DateTime Timer1_on_Time = new DateTime();
        public static DateTime Timer1_off_Time = new DateTime();

        public enum SEND_TYPE { SET_TYPE, DATA_TYPE };

        public ushort Code_Settings;
        public ushort Code_Data;

        bool SPI_FirstBit;
        bool SPI_ClockPolarity;
        bool SPI_ClockPhase;
        ushort SPI_DataSize;
        ushort SPI_BaudRate;

        bool Data_Source;
        bool Data_Binary;
        string Data_String;
        int Data_Console;

        public MainForm()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            SetControlState();
            SetDefaults();
            TimersInit();
            TextBox_initMain();
            SPI_Settings_Text_edit();
        }

        #region Defaults Configuration
        /// <summary>
        /// Defaults Configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void SetDefaults()
        {
            PortBaudRate = "115200";
            Code_Settings = 0xA1;
            Code_Data = 0xB1;
            SPI_DataSize_scroll.Value = SPI_DataSize;
            SPI_FirstBit_MSB_radio.Checked = SPI_FirstBit;
            SPI_FirstBit_LSB_radio.Checked = !SPI_FirstBit;
            SPI_ClockPolarity_LOW_radio.Checked = SPI_ClockPolarity;
            SPI_ClockPolarity_HIGH_radio.Checked = !SPI_ClockPolarity;
            SPI_ClockPhase_1_radio.Checked = SPI_ClockPhase;
            SPI_ClockPhase_2_radio.Checked = !SPI_ClockPhase;
            SPI_BaudRate_combo.SelectedIndex = SPI_BaudRate;
            SPI_DataSize_text.Text = "Data Size: " + SPI_DataSize_scroll.Value.ToString() + " bits";
            Data_Display_Bin_radio.Checked = Data_Binary;
            Data_Display_Hex_radio.Checked = !Data_Binary;
            Data_Console_Field_rich.Text = Data_String;
            Data_Source_Console_radio.Checked = Data_Source;
            Data_Source_File_radio.Checked = !Data_Source;

        }

        private void SetControlState()
        {
            cmdSend_button.Enabled = false;
            MainForm.comm.DisplayWindow = this.WriteSerialBox;

            SPI_FirstBit = Properties.Settings.Default.SPI_FirstBit;
            SPI_ClockPolarity = Properties.Settings.Default.SPI_ClockPolarity;
            SPI_ClockPhase = Properties.Settings.Default.SPI_ClockPhase;
            SPI_DataSize = Properties.Settings.Default.SPI_DataSize;
            SPI_BaudRate = Properties.Settings.Default.SPI_BaudRate;
            Data_Source = Properties.Settings.Default.Data_Source;
            Data_Binary = Properties.Settings.Default.Data_Binary;
            Data_String = Properties.Settings.Default.Data_String;
        }

        private void SPI_Settings_Text_edit()
        {
            this.SPI_Settings_text.Text = "SPI Settings:" + Environment.NewLine;
            this.SPI_Settings_text.Text += "     " + ((SPI_FirstBit) ? "MSB" : "LSB") + " Format" + Environment.NewLine;
            this.SPI_Settings_text.Text += "     " + "Clock Polarity: " + ((SPI_ClockPolarity) ? "Low;" : "High") + Environment.NewLine;
            this.SPI_Settings_text.Text += "     " + "Clock Phase: " + ((SPI_ClockPhase) ? "1" : "2") + " Edge" + Environment.NewLine;
            this.SPI_Settings_text.Text += "     " + "Data Size: " + SPI_DataSize + " Bits;" + Environment.NewLine;
            int _BaudRate = 8000000 / Int32.Parse(SPI_BaudRate_combo.Text);
            if (_BaudRate >= 1000000)
            {
                double _val = _BaudRate / 1000000;
                this.SPI_Settings_text.Text += "     " + "SPI Baud Rate is " + (_val).ToString("G1") + " MBits/s";
            }
            else
            {
                double _val = (double)_BaudRate / 1000;
                this.SPI_Settings_text.Text += "     " + "SPI Baud Rate is " + (_val).ToString("G") + " KBits/s";
            }
        }

        private void TextBox_initMain()
        {
            this.SerialStatus_label.Text = "Статус: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? ("Открыт") : (("Закрыт"));
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Имя порта: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.PortName) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Скорость: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.BaudRate) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Parity: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.Parity) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Stop Bits: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.StopBits) : ("-");
            this.SerialStatus_label.Text += Environment.NewLine;
            this.SerialStatus_label.Text += "Data Bits: ";
            this.SerialStatus_label.Text += (MainForm.PortStatus) ? (MainForm.comm.DataBits) : ("-");
        }
        #endregion


        #region Timers Configuration
        /// <summary>
        /// Timers Configuration
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        public void TimersInit()
        {
            Timer mainFormTimer1 = new Timer();
            mainFormTimer1.Interval = 1000;
            mainFormTimer1.Start();
            mainFormTimer1.Tick += new EventHandler(timer1_Tick);

            Timer mainFormTimer2 = new Timer();
            mainFormTimer2.Interval = TimeDelay;
            mainFormTimer2.Start();
            mainFormTimer2.Tick += new EventHandler(timer2_Tick);

            Timer1_on_Time = DateTime.Now;
            Timer1_off_Time = Timer1_on_Time.AddHours(4);
        }

        public void TimersRecall()
        {
            Timer mainFormTimer2 = new Timer();
            mainFormTimer2.Interval = TimeDelay;
            mainFormTimer2.Start();
            mainFormTimer2.Tick -= new EventHandler(timer2_Tick);

            Timer1_on_Time = DateTime.Now;
            Timer1_off_Time = Timer1_on_Time.AddHours(4);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer1_on_Time = Timer1_on_Time.AddSeconds(1);
            if (Timer_edit == true)
            {
                TimersRecall();
                Timer_edit = false;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (MainSend_Tick == true)
            {
                MainSend_cnt++;
            }
            if (SerialChanged) TextBox_initMain();
            SerialChanged = false;

            if (MainSend_flag != 0)
            {
                ushort _c = (ushort)(MainSend_flag & 0x7);
                MainSend_flag = 0;
            }
        }
        #endregion


        private void COM_button_click(object sender, EventArgs e)
        {
            ComPortForm comPortForm = new ComPortForm();
            comPortForm.ShowInTaskbar = false;
            comPortForm.StartPosition = FormStartPosition.CenterScreen;
            comPortForm.ShowDialog(this);
        }

        public string Pack_Format(MainForm.SEND_TYPE _format)
        {
            int _word;

            if (_format == MainForm.SEND_TYPE.SET_TYPE)
            {
                int _FirstBit = !SPI_FirstBit ? 1 : 0;
                int _ClockPol = !SPI_ClockPolarity ? 1 : 0;
                int _ClockPhase = !SPI_ClockPhase ? 1 : 0;
                _word = _FirstBit + (_ClockPol << 1) + (_ClockPhase << 2) + ((SPI_DataSize - 1) << 3) + (SPI_BaudRate << 7);
                return (Convert.ToString(Code_Settings, 16) + Convert.ToString(_word, 16).PadLeft(4, '0'));
            }

            else
            {
                return (Convert.ToString(Code_Data, 16) + Data_String);
            }
        }

        private void MainSend_Click(object sender, EventArgs e)
        {
            if (MainForm.PortStatus)
            {
                MainForm.comm.DisplayWindow = this.WriteSerialBox;
                MainSend_Func(MainForm.SEND_TYPE.SET_TYPE);
                MainSend_Func(MainForm.SEND_TYPE.DATA_TYPE);
                //MainSend_cnt = 0;
                //MainSend_Tick = true;
            }
        }

        public void MainSend_Func(MainForm.SEND_TYPE _type)
        {
            if (MainForm.PortStatus)
            {
                MainForm.comm.DisplayWindow = this.WriteSerialBox;
                this.WriteSerialBox.Text += ((_type == SEND_TYPE.SET_TYPE) ? "Settings " : "Data ") + "Packet: 0x";
                comm.WriteData(Pack_Format(_type));
                this.WriteSerialBox.Text += Environment.NewLine;
                if (_type == SEND_TYPE.DATA_TYPE)
                    this.WriteSerialBox.Text += "Transmittion Complete" + Environment.NewLine + Environment.NewLine;
            }
        }

        private void SPI_DataSize_scroll_Scroll(object sender, ScrollEventArgs e)
        {
            SPI_DataSize = (ushort)SPI_DataSize_scroll.Value;
            Properties.Settings.Default.SPI_DataSize = SPI_DataSize;
            Properties.Settings.Default.Save();
            SPI_DataSize_text.Text = "Data Size: " + SPI_DataSize_scroll.Value.ToString() + " bits";
            SPI_Settings_Text_edit();
        }

        private void SPI_FirstBit_MSB_radio_CheckedChanged(object sender, EventArgs e)
        {
            SPI_FirstBit = SPI_FirstBit_MSB_radio.Checked;
            Properties.Settings.Default.SPI_FirstBit = SPI_FirstBit;
            Properties.Settings.Default.Save();
            SPI_Settings_Text_edit();
        }

        private void SPI_ClockPolarity_LOW_radio_CheckedChanged(object sender, EventArgs e)
        {
            SPI_ClockPolarity = SPI_ClockPolarity_LOW_radio.Checked;
            Properties.Settings.Default.SPI_ClockPolarity = SPI_ClockPolarity;
            Properties.Settings.Default.Save();
            SPI_Settings_Text_edit();
        }

        private void SPI_ClockPhase_1_radio_CheckedChanged(object sender, EventArgs e)
        {
            SPI_ClockPhase = SPI_ClockPhase_1_radio.Checked;
            Properties.Settings.Default.SPI_ClockPhase = SPI_ClockPhase;
            Properties.Settings.Default.Save();
            SPI_Settings_Text_edit();
        }

        private void SPI_BaudRate_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPI_BaudRate = (ushort)SPI_BaudRate_combo.SelectedIndex;
            Properties.Settings.Default.SPI_BaudRate = SPI_BaudRate;
            Properties.Settings.Default.Save();
            SPI_Settings_Text_edit();
        }

        private void Data_Display_Hex_radio_CheckedChanged(object sender, EventArgs e)
        {
            Data_Binary = Data_Display_Hex_radio.Checked;
            Properties.Settings.Default.Data_Binary = Data_Binary;
            Properties.Settings.Default.Save();
        }

        private void Data_Address_Field_rich_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Data_Binary)
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 50) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
            else
            {
                if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar <= 64 || e.KeyChar >= 71) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void Data_Source_Console_radio_CheckedChanged(object sender, EventArgs e)
        {
            Data_Source = Data_Source_Console_radio.Checked;
            Properties.Settings.Default.Data_Source = Data_Source;
            Properties.Settings.Default.Save();

        }

        private void Data_Console_Field()
        {
            int _len = Data_Console_Field_rich.Text.Length;
            if (_len == 4)
            {
                Data_Console_Field_rich.Select(0, _len);
                {
                    Data_Console = Convert.ToInt32(Data_Console_Field_rich.SelectedText, 16);
                    Data_Monitor_Field_rich.Text = "0x" + (Convert.ToString(Data_Console, 16)).PadLeft(4, '0') + Environment.NewLine;
                }
            Data_Console_Field_rich.SelectionStart = Data_Console_Field_rich.Text.Length;
            }
        }

        private void Data_Console_Field_rich_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Data_Monitor_Field_rich.Text = "0x" + (Convert.ToString(Data_Console, 16)).PadLeft(4, '0');
            }
        }

        #region Relay On Button Click
        /// <summary>
        /// Relay On Button Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        #endregion
    }
}