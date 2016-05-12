namespace AutoWBAdjustTool.CSharp
{
    partial class FormVPG
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
            this.tabControlVPG = new System.Windows.Forms.TabControl();
            this.tabPageChroma = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxW80 = new System.Windows.Forms.TextBox();
            this.textBoxW100 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxW20 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTiming = new System.Windows.Forms.TextBox();
            this.labelTiming = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelModel = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.tabControlVPG.SuspendLayout();
            this.tabPageChroma.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlVPG
            // 
            this.tabControlVPG.Controls.Add(this.tabPageChroma);
            this.tabControlVPG.Location = new System.Drawing.Point(12, 12);
            this.tabControlVPG.Name = "tabControlVPG";
            this.tabControlVPG.SelectedIndex = 0;
            this.tabControlVPG.Size = new System.Drawing.Size(260, 208);
            this.tabControlVPG.TabIndex = 0;
            // 
            // tabPageChroma
            // 
            this.tabPageChroma.Controls.Add(this.groupBox1);
            this.tabPageChroma.Controls.Add(this.textBoxTiming);
            this.tabPageChroma.Controls.Add(this.labelTiming);
            this.tabPageChroma.Controls.Add(this.comboBox1);
            this.tabPageChroma.Controls.Add(this.labelModel);
            this.tabPageChroma.Location = new System.Drawing.Point(4, 22);
            this.tabPageChroma.Name = "tabPageChroma";
            this.tabPageChroma.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChroma.Size = new System.Drawing.Size(252, 182);
            this.tabPageChroma.TabIndex = 0;
            this.tabPageChroma.Text = "Chroma";
            this.tabPageChroma.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxW80);
            this.groupBox1.Controls.Add(this.textBoxW100);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxW20);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 75);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pattern";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "20%亮度";
            // 
            // textBoxW80
            // 
            this.textBoxW80.Location = new System.Drawing.Point(180, 14);
            this.textBoxW80.Name = "textBoxW80";
            this.textBoxW80.Size = new System.Drawing.Size(30, 21);
            this.textBoxW80.TabIndex = 7;
            this.textBoxW80.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxW100
            // 
            this.textBoxW100.Location = new System.Drawing.Point(71, 46);
            this.textBoxW100.Name = "textBoxW100";
            this.textBoxW100.Size = new System.Drawing.Size(30, 21);
            this.textBoxW100.TabIndex = 9;
            this.textBoxW100.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "80%亮度";
            // 
            // textBoxW20
            // 
            this.textBoxW20.Location = new System.Drawing.Point(71, 14);
            this.textBoxW20.Name = "textBoxW20";
            this.textBoxW20.Size = new System.Drawing.Size(30, 21);
            this.textBoxW20.TabIndex = 5;
            this.textBoxW20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "100%亮度";
            // 
            // textBoxTiming
            // 
            this.textBoxTiming.Location = new System.Drawing.Point(191, 10);
            this.textBoxTiming.Name = "textBoxTiming";
            this.textBoxTiming.Size = new System.Drawing.Size(30, 21);
            this.textBoxTiming.TabIndex = 3;
            this.textBoxTiming.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTiming
            // 
            this.labelTiming.AutoSize = true;
            this.labelTiming.Location = new System.Drawing.Point(144, 14);
            this.labelTiming.Name = "labelTiming";
            this.labelTiming.Size = new System.Drawing.Size(41, 12);
            this.labelTiming.TabIndex = 2;
            this.labelTiming.Text = "Timing";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2401",
            "2402",
            "22293",
            "22293_A",
            "22293_B",
            "2233",
            "2233_A",
            "2233_B",
            "2333_B",
            "23293_B",
            "2234",
            "22294",
            "22294_A",
            "23294"});
            this.comboBox1.Location = new System.Drawing.Point(59, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(23, 14);
            this.labelModel.Name = "labelModel";
            this.labelModel.Size = new System.Drawing.Size(29, 12);
            this.labelModel.TabIndex = 0;
            this.labelModel.Text = "型号";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(193, 226);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormVPG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControlVPG);
            this.MaximizeBox = false;
            this.Name = "FormVPG";
            this.Text = "信号发生器设置";
            this.Load += new System.EventHandler(this.FormVPG_Load);
            this.tabControlVPG.ResumeLayout(false);
            this.tabPageChroma.ResumeLayout(false);
            this.tabPageChroma.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlVPG;
        private System.Windows.Forms.TabPage tabPageChroma;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelModel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelTiming;
        private System.Windows.Forms.TextBox textBoxTiming;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxW100;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxW80;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxW20;
    }
}