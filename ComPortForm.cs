using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SPI_Control;

namespace SPI_Control
{
    public partial class ComPortForm : Form
    {
        public static string PortComName;
        public static string PortBaudRate;
        public static string PortParity;
        public static string PortDataBits;
        public static string PortStopBits;

        public ComPortForm()
        {
            InitializeComponent();
        }

        private void ComPortForm_Load(object sender, EventArgs e)
        {
            LoadValues();
            SetDefaults();
            SetControlState();
            TextBox_init();
        }

        /// <summary>
        /// methos to load our serial
        /// port option values
        /// </summary>
        void LoadValues()
        {
            MainForm.comm.SetPortNameValues(cboPortComboBox);
            MainForm.comm.SetParityValues(cboParityComboBox);
            MainForm.comm.SetStopBitValues(cboStopComboBox);
        }

        private void SetDefaults()
        {
            cboPortComboBox.SelectedIndex = 0x0;
            cboBaudComboBox.SelectedText = MainForm.PortBaudRate;
            cboParityComboBox.SelectedIndex = 0;
            cboStopComboBox.SelectedIndex = 1;
            cboDataComboBox.SelectedIndex = 1;

            PortComName = cboPortComboBox.Text;
            PortBaudRate = cboBaudComboBox.Text;
            PortParity = cboParityComboBox.Text;
            PortDataBits = cboDataComboBox.Text;
            PortStopBits = cboStopComboBox.Text;
        }

        /// <summary>
        /// method to set the state of controls
        /// when the form first loads
        /// </summary>
        private void SetControlState()
        {
            OpenPort_button.Enabled = !(MainForm.PortStatus);
            ClosePort_button.Enabled = (MainForm.PortStatus);
            TestMessage_button.Enabled = (MainForm.PortStatus);
            ((MainForm)this.Owner).cmdSend_button.Enabled = !(MainForm.PortStatus);
        }

        private void TextBox_init()
        {
            this.Status_textBox.Text = "Статус: ";
            this.Status_textBox.Text += (MainForm.PortStatus) ? ("Открыт") : (("Закрыт"));
            this.Status_textBox.Text += Environment.NewLine;
            this.Status_textBox.Text += "Имя порта: ";
            this.Status_textBox.Text += (MainForm.PortStatus) ? (MainForm.comm.PortName) : ("-");
            this.Status_textBox.Text += Environment.NewLine;
            this.Status_textBox.Text += "Скорость: ";
            this.Status_textBox.Text += (MainForm.PortStatus) ? (MainForm.comm.BaudRate) : ("-");
            this.Status_textBox.Text += Environment.NewLine;
            this.Status_textBox.Text += "Parity: ";
            this.Status_textBox.Text += (MainForm.PortStatus) ? (MainForm.comm.Parity) : ("-");
            this.Status_textBox.Text += Environment.NewLine;
            this.Status_textBox.Text += "Stop Bits: ";
            this.Status_textBox.Text += (MainForm.PortStatus) ? (MainForm.comm.StopBits) : ("-");
            this.Status_textBox.Text += Environment.NewLine;
            this.Status_textBox.Text += "Data Bits: ";
            this.Status_textBox.Text += (MainForm.PortStatus) ? (MainForm.comm.DataBits) : ("-");
        }

        private void OpenPort_button_Click(object sender, EventArgs e)
        {
            PortComName = cboPortComboBox.Text;
            PortBaudRate = cboBaudComboBox.Text;
            PortParity = cboParityComboBox.Text;
            PortDataBits = cboDataComboBox.Text;
            PortStopBits = cboStopComboBox.Text;

            MainForm.comm.Parity = PortParity;
            MainForm.comm.StopBits = PortStopBits;
            MainForm.comm.DataBits = PortDataBits;
            MainForm.comm.BaudRate = PortBaudRate;
            MainForm.comm.PortName = PortComName;
            MainForm.PortBaudRate = PortBaudRate;
            MainForm.comm.DisplayWindow = Status_richBox;
            MainForm.PortStatus = (MainForm.comm.OpenPort()) ? true : false;
            TextBox_init();
            OpenPort_button.Enabled = !(MainForm.PortStatus);
            ClosePort_button.Enabled = (MainForm.PortStatus);
            TestMessage_button.Enabled = (MainForm.PortStatus);
            ((MainForm)this.Owner).cmdSend_button.Enabled = (MainForm.PortStatus);
            ((MainForm)this.Owner).MainSend.Enabled = (MainForm.PortStatus);
            MainForm.SerialChanged = true;
        }

        private void ClosePort_button_Click(object sender, EventArgs e)
        {
            MainForm.PortStatus = (MainForm.comm.ClosePort()) ? false : true;
            TextBox_init();

            OpenPort_button.Enabled = !(MainForm.PortStatus);
            ClosePort_button.Enabled = (MainForm.PortStatus);
            TestMessage_button.Enabled = (MainForm.PortStatus);
            ((MainForm)this.Owner).cmdSend_button.Enabled = (MainForm.PortStatus);
            ((MainForm)this.Owner).MainSend.Enabled = (MainForm.PortStatus);
            MainForm.SerialChanged = true;
        }

        private void CloseForm_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
