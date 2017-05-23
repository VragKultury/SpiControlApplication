using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace COM2timers
{
    public class MessageManager
    {
        #region Inits
        /// <summary>
        /// enumeration to hold our message types
        /// </summary>
        public enum MessageField 
        { 
            My = 0,
            Ctrl = 1, 
            Arbitr = 2, 
            Data = 3, 
            CRC = 4,
        };

        private static string[] msgFieldNames = new string[10];

        private string _msgField = string.Empty;
        private int cntField;

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
            bool compareResult = false;
            _comboBox.Invoke(new EventHandler(delegate
            {
                this._comboBox.Items.Clear();
                for (int i = 1; i <= (Int32.Parse(msgFieldNames[0])); i++)
                {
                    for (int i2 = 0; i2 < (Int32.Parse(msgFieldNames[0])); i2++)
                    {
                        compareResult = (msgFieldNames[i] == MainForm.msgSelectedFields[i2]) ? true : false;
                    }
                    /*
                    if (msgFieldNames[i] != MainForm.msgSelectedFields[0] || MainForm.msgSelectedFields[1] ||
                        MainForm.msgSelectedFields[2] || MainForm.msgSelectedFields[3] || MainForm.msgSelectedFields[4] ||
                        MainForm.msgSelectedFields[5] || MainForm.msgSelectedFields[6] || MainForm.msgSelectedFields[7])
                     */
                    if (compareResult == false)
                        this._comboBox.Items.Add(msgFieldNames[i]);
                }
            }));
        }
        #endregion
        /*
        #region MsgCheckData
        public bool MsgCheckData(int num)
        {
            if ((msgFieldStatus & (1 << (num - 1))) != 0)
                return true;
            else return false;
        }
        #endregion
        */
    }
}
