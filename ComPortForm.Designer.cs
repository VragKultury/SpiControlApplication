namespace SPI_Control
{
    partial class ComPortForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComPortForm));
            this.ComPortOptions_box = new System.Windows.Forms.GroupBox();
            this.cboDataComboBox = new System.Windows.Forms.ComboBox();
            this.cboStopComboBox = new System.Windows.Forms.ComboBox();
            this.cboParityComboBox = new System.Windows.Forms.ComboBox();
            this.cboBaudComboBox = new System.Windows.Forms.ComboBox();
            this.cboPortComboBox = new System.Windows.Forms.ComboBox();
            this.DataBitsName = new System.Windows.Forms.Label();
            this.StopBitsName = new System.Windows.Forms.Label();
            this.ParityName = new System.Windows.Forms.Label();
            this.BaudRateName = new System.Windows.Forms.Label();
            this.PortName = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.portOpen_box = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.Status_richBox = new System.Windows.Forms.RichTextBox();
            this.Status_textBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ClosePort_button = new System.Windows.Forms.Button();
            this.OpenPort_button = new System.Windows.Forms.Button();
            this.TestMessage_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseForm_button = new System.Windows.Forms.Button();
            this.ComPortOptions_box.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.portOpen_box.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComPortOptions_box
            // 
            this.ComPortOptions_box.Controls.Add(this.cboDataComboBox);
            this.ComPortOptions_box.Controls.Add(this.cboStopComboBox);
            this.ComPortOptions_box.Controls.Add(this.cboParityComboBox);
            this.ComPortOptions_box.Controls.Add(this.cboBaudComboBox);
            this.ComPortOptions_box.Controls.Add(this.cboPortComboBox);
            this.ComPortOptions_box.Controls.Add(this.DataBitsName);
            this.ComPortOptions_box.Controls.Add(this.StopBitsName);
            this.ComPortOptions_box.Controls.Add(this.ParityName);
            this.ComPortOptions_box.Controls.Add(this.BaudRateName);
            this.ComPortOptions_box.Controls.Add(this.PortName);
            this.ComPortOptions_box.Location = new System.Drawing.Point(3, 3);
            this.ComPortOptions_box.Name = "ComPortOptions_box";
            this.ComPortOptions_box.Size = new System.Drawing.Size(91, 228);
            this.ComPortOptions_box.TabIndex = 0;
            this.ComPortOptions_box.TabStop = false;
            this.ComPortOptions_box.Text = "Настройки";
            // 
            // cboDataComboBox
            // 
            this.cboDataComboBox.FormattingEnabled = true;
            this.cboDataComboBox.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboDataComboBox.Location = new System.Drawing.Point(9, 195);
            this.cboDataComboBox.Name = "cboDataComboBox";
            this.cboDataComboBox.Size = new System.Drawing.Size(76, 21);
            this.cboDataComboBox.TabIndex = 14;
            // 
            // cboStopComboBox
            // 
            this.cboStopComboBox.FormattingEnabled = true;
            this.cboStopComboBox.Location = new System.Drawing.Point(9, 155);
            this.cboStopComboBox.Name = "cboStopComboBox";
            this.cboStopComboBox.Size = new System.Drawing.Size(76, 21);
            this.cboStopComboBox.TabIndex = 13;
            // 
            // cboParityComboBox
            // 
            this.cboParityComboBox.FormattingEnabled = true;
            this.cboParityComboBox.Location = new System.Drawing.Point(7, 119);
            this.cboParityComboBox.Name = "cboParityComboBox";
            this.cboParityComboBox.Size = new System.Drawing.Size(78, 21);
            this.cboParityComboBox.TabIndex = 1;
            // 
            // cboBaudComboBox
            // 
            this.cboBaudComboBox.FormattingEnabled = true;
            this.cboBaudComboBox.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cboBaudComboBox.Location = new System.Drawing.Point(9, 74);
            this.cboBaudComboBox.Name = "cboBaudComboBox";
            this.cboBaudComboBox.Size = new System.Drawing.Size(76, 21);
            this.cboBaudComboBox.TabIndex = 11;
            // 
            // cboPortComboBox
            // 
            this.cboPortComboBox.FormattingEnabled = true;
            this.cboPortComboBox.Location = new System.Drawing.Point(9, 34);
            this.cboPortComboBox.Name = "cboPortComboBox";
            this.cboPortComboBox.Size = new System.Drawing.Size(76, 21);
            this.cboPortComboBox.TabIndex = 10;
            // 
            // DataBitsName
            // 
            this.DataBitsName.AutoSize = true;
            this.DataBitsName.Location = new System.Drawing.Point(7, 184);
            this.DataBitsName.Name = "DataBitsName";
            this.DataBitsName.Size = new System.Drawing.Size(50, 13);
            this.DataBitsName.TabIndex = 0;
            this.DataBitsName.Text = "Data Bits";
            // 
            // StopBitsName
            // 
            this.StopBitsName.AutoSize = true;
            this.StopBitsName.Location = new System.Drawing.Point(7, 143);
            this.StopBitsName.Name = "StopBitsName";
            this.StopBitsName.Size = new System.Drawing.Size(49, 13);
            this.StopBitsName.TabIndex = 0;
            this.StopBitsName.Text = "Stop Bits";
            // 
            // ParityName
            // 
            this.ParityName.AutoSize = true;
            this.ParityName.Location = new System.Drawing.Point(7, 102);
            this.ParityName.Name = "ParityName";
            this.ParityName.Size = new System.Drawing.Size(33, 13);
            this.ParityName.TabIndex = 0;
            this.ParityName.Text = "Parity";
            // 
            // BaudRateName
            // 
            this.BaudRateName.AutoSize = true;
            this.BaudRateName.Location = new System.Drawing.Point(6, 58);
            this.BaudRateName.Name = "BaudRateName";
            this.BaudRateName.Size = new System.Drawing.Size(58, 13);
            this.BaudRateName.TabIndex = 16;
            this.BaudRateName.Text = "Baud Rate";
            // 
            // PortName
            // 
            this.PortName.AutoSize = true;
            this.PortName.Location = new System.Drawing.Point(6, 18);
            this.PortName.Name = "PortName";
            this.PortName.Size = new System.Drawing.Size(26, 13);
            this.PortName.TabIndex = 15;
            this.PortName.Text = "Port";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.89743F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.10256F));
            this.tableLayoutPanel1.Controls.Add(this.ComPortOptions_box, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.portOpen_box, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(273, 307);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // portOpen_box
            // 
            this.portOpen_box.Controls.Add(this.tableLayoutPanel3);
            this.portOpen_box.Location = new System.Drawing.Point(100, 3);
            this.portOpen_box.Name = "portOpen_box";
            this.portOpen_box.Size = new System.Drawing.Size(166, 228);
            this.portOpen_box.TabIndex = 2;
            this.portOpen_box.TabStop = false;
            this.portOpen_box.Text = "Состояние";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.Status_richBox, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.Status_textBox, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 13);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(164, 218);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // Status_richBox
            // 
            this.Status_richBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Status_richBox.Location = new System.Drawing.Point(3, 112);
            this.Status_richBox.Name = "Status_richBox";
            this.Status_richBox.Size = new System.Drawing.Size(158, 103);
            this.Status_richBox.TabIndex = 2;
            this.Status_richBox.Text = "";
            // 
            // Status_textBox
            // 
            this.Status_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Status_textBox.Location = new System.Drawing.Point(3, 3);
            this.Status_textBox.Multiline = true;
            this.Status_textBox.Name = "Status_textBox";
            this.Status_textBox.Size = new System.Drawing.Size(158, 103);
            this.Status_textBox.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.ClosePort_button, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.OpenPort_button, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(100, 237);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(170, 67);
            this.tableLayoutPanel5.TabIndex = 21;
            // 
            // ClosePort_button
            // 
            this.ClosePort_button.Location = new System.Drawing.Point(3, 36);
            this.ClosePort_button.Name = "ClosePort_button";
            this.ClosePort_button.Size = new System.Drawing.Size(158, 27);
            this.ClosePort_button.TabIndex = 1;
            this.ClosePort_button.Text = "Закрыть COM порт";
            this.ClosePort_button.UseVisualStyleBackColor = true;
            this.ClosePort_button.Click += new System.EventHandler(this.ClosePort_button_Click);
            // 
            // OpenPort_button
            // 
            this.OpenPort_button.Location = new System.Drawing.Point(3, 3);
            this.OpenPort_button.Name = "OpenPort_button";
            this.OpenPort_button.Size = new System.Drawing.Size(158, 27);
            this.OpenPort_button.TabIndex = 0;
            this.OpenPort_button.Text = "Открыть COM порт";
            this.OpenPort_button.UseVisualStyleBackColor = true;
            this.OpenPort_button.Click += new System.EventHandler(this.OpenPort_button_Click);
            // 
            // TestMessage_button
            // 
            this.TestMessage_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestMessage_button.Location = new System.Drawing.Point(3, 3);
            this.TestMessage_button.Name = "TestMessage_button";
            this.TestMessage_button.Size = new System.Drawing.Size(130, 22);
            this.TestMessage_button.TabIndex = 3;
            this.TestMessage_button.Text = "Тестирование порта";
            this.TestMessage_button.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 348);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.TestMessage_button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.CloseForm_button, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 316);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(273, 28);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // CloseForm_button
            // 
            this.CloseForm_button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseForm_button.Location = new System.Drawing.Point(139, 3);
            this.CloseForm_button.Name = "CloseForm_button";
            this.CloseForm_button.Size = new System.Drawing.Size(131, 22);
            this.CloseForm_button.TabIndex = 3;
            this.CloseForm_button.Text = "Закрыть";
            this.CloseForm_button.UseVisualStyleBackColor = true;
            this.CloseForm_button.Click += new System.EventHandler(this.CloseForm_button_Click);
            // 
            // ComPortForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 350);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ComPortForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки COM порта";
            this.Load += new System.EventHandler(this.ComPortForm_Load);
            this.ComPortOptions_box.ResumeLayout(false);
            this.ComPortOptions_box.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.portOpen_box.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ComPortOptions_box;
        private System.Windows.Forms.ComboBox cboDataComboBox;
        private System.Windows.Forms.ComboBox cboStopComboBox;
        private System.Windows.Forms.ComboBox cboParityComboBox;
        private System.Windows.Forms.ComboBox cboBaudComboBox;
        public System.Windows.Forms.ComboBox cboPortComboBox;
        private System.Windows.Forms.Label DataBitsName;
        private System.Windows.Forms.Label StopBitsName;
        private System.Windows.Forms.Label ParityName;
        private System.Windows.Forms.Label BaudRateName;
        private System.Windows.Forms.Label PortName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox portOpen_box;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button OpenPort_button;
        private System.Windows.Forms.Button ClosePort_button;
        private System.Windows.Forms.Button TestMessage_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button CloseForm_button;
        private System.Windows.Forms.RichTextBox Status_richBox;
        private System.Windows.Forms.TextBox Status_textBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}