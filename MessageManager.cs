using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace SPI_Control
{
    public class MessageManager
    {
        #region Inits
        /// <summary>
        /// enumeration to hold our message types
        /// </summary>
        public enum MessageField 
        { 
            none = 0,
            Ctrl = 1, 
            Arbitr = 2, 
            Data = 3, 
            CRC = 4,
        };

        public int msgFieldStatus = 0;
        public static string[] msgSelectedNames = new string[10];
        private static string[] msgFieldNames = new string[10];

        private string _msgField = string.Empty;
        private RichTextBox _displayWindow;

        private ComboBox _comboBox;
        public ComboBox comboBox
        {
            get { return _comboBox; }
            set { _comboBox = value; }
        }

        public string sMessageField
        {
            get { return _msgField; }
            set { _msgField = value; }
        }
        /// <summary>
        /// property to hold our display window
        /// value
        /// </summary>
        public RichTextBox DisplayWindow
        {
            get { return _displayWindow; }
            set { _displayWindow = value; }
        }

        public MessageManager(string msgField)
        {
            _msgField = msgField;
        }

        public MessageManager()
        {
            _msgField = string.Empty;
        }
        #endregion

        #region MsgManagerInit
        public void MsgManagerInit()
        {
            //int num = (Enum.GetNames(typeof(MessageField))).Length;

            string[] names = Enum.GetNames(typeof(MessageField));

            for (int i = 5; i != 0; i--)
            {
                //msgDefaultNames[i - 1] = names[i - 1];
                msgFieldNames[i] = names[i - 1];
            }
            msgFieldNames[0] = names.Length.ToString();

        }
        #endregion

        #region AcceptRebuild
        public void AcceptRebuild()
        {
            
        }
        #endregion

        #region msgDisplayData
        public void msgDisplayData()
        {
            _comboBox.Invoke(new EventHandler(delegate
            {
                this._comboBox.Items.Clear();
                for (int i = 1; i <= (Int32.Parse(msgFieldNames[0])); i++)
                {
                    int mask = 1 << (i-1);
                    /*
                    if (msgFieldNames[i] != (comboBox.SelectedValue))
                    {
                        this._comboBox.Items.Add(msgFieldNames[i]);
                    }
                    */
                }
            }));
        }
        #endregion
    }
}
