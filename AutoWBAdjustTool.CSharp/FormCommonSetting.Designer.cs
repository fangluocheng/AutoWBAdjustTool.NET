namespace AutoWBAdjustTool.CSharp
{
    partial class FormCommonSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxInputSrc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBarcodeLen = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxComMode = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSerialPort = new System.Windows.Forms.TabPage();
            this.comboBoxBaudRate = new System.Windows.Forms.ComboBox();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.comboBoxComId = new System.Windows.Forms.ComboBox();
            this.labelComId = new System.Windows.Forms.Label();
            this.tabPageNetwork = new System.Windows.Forms.TabPage();
            this.tabPageI2c = new System.Windows.Forms.TabPage();
            this.comboBoxI2cClockRate = new System.Windows.Forms.ComboBox();
            this.labelI2cClockRate = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageSerialPort.SuspendLayout();
            this.tabPageI2c.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "电视信源";
            // 
            // comboBoxInputSrc
            // 
            this.comboBoxInputSrc.FormattingEnabled = true;
            this.comboBoxInputSrc.Location = new System.Drawing.Point(71, 12);
            this.comboBoxInputSrc.Name = "comboBoxInputSrc";
            this.comboBoxInputSrc.Size = new System.Drawing.Size(56, 20);
            this.comboBoxInputSrc.TabIndex = 1;
            this.comboBoxInputSrc.Text = "HDMI3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "整机条码长度";
            // 
            // textBoxBarcodeLen
            // 
            this.textBoxBarcodeLen.Location = new System.Drawing.Point(237, 11);
            this.textBoxBarcodeLen.Name = "textBoxBarcodeLen";
            this.textBoxBarcodeLen.Size = new System.Drawing.Size(35, 21);
            this.textBoxBarcodeLen.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(193, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "电脑与电视的通讯方式";
            // 
            // comboBoxComMode
            // 
            this.comboBoxComMode.FormattingEnabled = true;
            this.comboBoxComMode.Items.AddRange(new object[] {
            "串口",
            "网口",
            "I2C"});
            this.comboBoxComMode.Location = new System.Drawing.Point(156, 44);
            this.comboBoxComMode.Name = "comboBoxComMode";
            this.comboBoxComMode.Size = new System.Drawing.Size(80, 20);
            this.comboBoxComMode.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSerialPort);
            this.tabControl1.Controls.Add(this.tabPageNetwork);
            this.tabControl1.Controls.Add(this.tabPageI2c);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 150);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageSerialPort
            // 
            this.tabPageSerialPort.Controls.Add(this.comboBoxBaudRate);
            this.tabPageSerialPort.Controls.Add(this.labelBaudRate);
            this.tabPageSerialPort.Controls.Add(this.comboBoxComId);
            this.tabPageSerialPort.Controls.Add(this.labelComId);
            this.tabPageSerialPort.Location = new System.Drawing.Point(4, 22);
            this.tabPageSerialPort.Name = "tabPageSerialPort";
            this.tabPageSerialPort.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSerialPort.Size = new System.Drawing.Size(252, 124);
            this.tabPageSerialPort.TabIndex = 0;
            this.tabPageSerialPort.Text = "串口设置";
            this.tabPageSerialPort.UseVisualStyleBackColor = true;
            // 
            // comboBoxBaudRate
            // 
            this.comboBoxBaudRate.FormattingEnabled = true;
            this.comboBoxBaudRate.Location = new System.Drawing.Point(59, 35);
            this.comboBoxBaudRate.Name = "comboBoxBaudRate";
            this.comboBoxBaudRate.Size = new System.Drawing.Size(80, 20);
            this.comboBoxBaudRate.TabIndex = 11;
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(12, 38);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(41, 12);
            this.labelBaudRate.TabIndex = 10;
            this.labelBaudRate.Text = "波特率";
            // 
            // comboBoxComId
            // 
            this.comboBoxComId.FormattingEnabled = true;
            this.comboBoxComId.Location = new System.Drawing.Point(59, 9);
            this.comboBoxComId.Name = "comboBoxComId";
            this.comboBoxComId.Size = new System.Drawing.Size(80, 20);
            this.comboBoxComId.TabIndex = 9;
            // 
            // labelComId
            // 
            this.labelComId.AutoSize = true;
            this.labelComId.Location = new System.Drawing.Point(12, 12);
            this.labelComId.Name = "labelComId";
            this.labelComId.Size = new System.Drawing.Size(41, 12);
            this.labelComId.TabIndex = 8;
            this.labelComId.Text = "端口号";
            // 
            // tabPageNetwork
            // 
            this.tabPageNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabPageNetwork.Name = "tabPageNetwork";
            this.tabPageNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNetwork.Size = new System.Drawing.Size(252, 124);
            this.tabPageNetwork.TabIndex = 1;
            this.tabPageNetwork.Text = "网口设置";
            this.tabPageNetwork.UseVisualStyleBackColor = true;
            // 
            // tabPageI2c
            // 
            this.tabPageI2c.Controls.Add(this.comboBoxI2cClockRate);
            this.tabPageI2c.Controls.Add(this.labelI2cClockRate);
            this.tabPageI2c.Location = new System.Drawing.Point(4, 22);
            this.tabPageI2c.Name = "tabPageI2c";
            this.tabPageI2c.Size = new System.Drawing.Size(252, 124);
            this.tabPageI2c.TabIndex = 2;
            this.tabPageI2c.Text = "I2C 设置";
            this.tabPageI2c.UseVisualStyleBackColor = true;
            // 
            // comboBoxI2cClockRate
            // 
            this.comboBoxI2cClockRate.FormattingEnabled = true;
            this.comboBoxI2cClockRate.Location = new System.Drawing.Point(83, 9);
            this.comboBoxI2cClockRate.Name = "comboBoxI2cClockRate";
            this.comboBoxI2cClockRate.Size = new System.Drawing.Size(80, 20);
            this.comboBoxI2cClockRate.TabIndex = 11;
            // 
            // labelI2cClockRate
            // 
            this.labelI2cClockRate.AutoSize = true;
            this.labelI2cClockRate.Location = new System.Drawing.Point(12, 12);
            this.labelI2cClockRate.Name = "labelI2cClockRate";
            this.labelI2cClockRate.Size = new System.Drawing.Size(65, 12);
            this.labelI2cClockRate.TabIndex = 10;
            this.labelI2cClockRate.Text = "Clock Rate";
            // 
            // FormCommonSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.comboBoxComMode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxBarcodeLen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxInputSrc);
            this.Controls.Add(this.label1);
            this.Name = "FormCommonSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "通用设置";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSerialPort.ResumeLayout(false);
            this.tabPageSerialPort.PerformLayout();
            this.tabPageI2c.ResumeLayout(false);
            this.tabPageI2c.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxInputSrc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBarcodeLen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxComMode;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSerialPort;
        private System.Windows.Forms.TabPage tabPageNetwork;
        private System.Windows.Forms.TabPage tabPageI2c;
        private System.Windows.Forms.Label labelComId;
        private System.Windows.Forms.ComboBox comboBoxComId;
        private System.Windows.Forms.ComboBox comboBoxBaudRate;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.ComboBox comboBoxI2cClockRate;
        private System.Windows.Forms.Label labelI2cClockRate;
    }
}