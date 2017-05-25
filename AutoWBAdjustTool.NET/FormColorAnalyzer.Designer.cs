namespace AutoWBAdjustTool.NET
{
    partial class FormColorAnalyzer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormColorAnalyzer));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKM = new System.Windows.Forms.TabPage();
            this.textBoxCaChannel = new System.Windows.Forms.TextBox();
            this.labelChannel = new System.Windows.Forms.Label();
            this.comboBoxCaModel = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageKM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageKM);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(260, 208);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageKM
            // 
            this.tabPageKM.Controls.Add(this.textBoxCaChannel);
            this.tabPageKM.Controls.Add(this.labelChannel);
            this.tabPageKM.Controls.Add(this.comboBoxCaModel);
            this.tabPageKM.Controls.Add(this.labelModel);
            this.tabPageKM.Location = new System.Drawing.Point(4, 22);
            this.tabPageKM.Name = "tabPageKM";
            this.tabPageKM.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKM.Size = new System.Drawing.Size(252, 182);
            this.tabPageKM.TabIndex = 0;
            this.tabPageKM.Text = "KONICA MINOLTA";
            this.tabPageKM.UseVisualStyleBackColor = true;
            // 
            // textBoxCaChannel
            // 
            this.textBoxCaChannel.Location = new System.Drawing.Point(186, 10);
            this.textBoxCaChannel.Name = "textBoxCaChannel";
            this.textBoxCaChannel.Size = new System.Drawing.Size(40, 21);
            this.textBoxCaChannel.TabIndex = 5;
            // 
            // labelChannel
            // 
            this.labelChannel.AutoSize = true;
            this.labelChannel.Location = new System.Drawing.Point(151, 14);
            this.labelChannel.Name = "labelChannel";
            this.labelChannel.Size = new System.Drawing.Size(29, 12);
            this.labelChannel.TabIndex = 4;
            this.labelChannel.Text = "通道";
            // 
            // comboBoxCaModel
            // 
            this.comboBoxCaModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCaModel.FormattingEnabled = true;
            this.comboBoxCaModel.Items.AddRange(new object[] {
            "CA310",
            "CA210"});
            this.comboBoxCaModel.Location = new System.Drawing.Point(52, 11);
            this.comboBoxCaModel.Name = "comboBoxCaModel";
            this.comboBoxCaModel.Size = new System.Drawing.Size(70, 20);
            this.comboBoxCaModel.TabIndex = 3;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(17, 14);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(29, 12);
            this.labelModel.TabIndex = 2;
            this.labelModel.Text = "型号";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(193, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormColorAnalyzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormColorAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "色彩分析仪设置";
            this.Load += new System.EventHandler(this.FormColorAnalyzer_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageKM.ResumeLayout(false);
            this.tabPageKM.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageKM;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox comboBoxCaModel;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.TextBox textBoxCaChannel;
        private System.Windows.Forms.Label labelChannel;
    }
}