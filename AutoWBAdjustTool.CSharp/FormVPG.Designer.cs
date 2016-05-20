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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVPG));
            this.tabControlVPG = new System.Windows.Forms.TabControl();
            this.tabPageChroma = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWhite = new System.Windows.Forms.TextBox();
            this.textBox100IRE = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxGrey = new System.Windows.Forms.TextBox();
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
            this.groupBox1.Controls.Add(this.textBoxWhite);
            this.groupBox1.Controls.Add(this.textBox100IRE);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxGrey);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 44);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pattern";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "暗场";
            // 
            // textBoxWhite
            // 
            this.textBoxWhite.Location = new System.Drawing.Point(112, 14);
            this.textBoxWhite.Name = "textBoxWhite";
            this.textBoxWhite.Size = new System.Drawing.Size(28, 21);
            this.textBoxWhite.TabIndex = 7;
            this.textBoxWhite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox100IRE
            // 
            this.textBox100IRE.Location = new System.Drawing.Point(192, 14);
            this.textBox100IRE.Name = "textBox100IRE";
            this.textBox100IRE.Size = new System.Drawing.Size(28, 21);
            this.textBox100IRE.TabIndex = 9;
            this.textBox100IRE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "亮场";
            // 
            // textBoxGrey
            // 
            this.textBoxGrey.Location = new System.Drawing.Point(41, 14);
            this.textBoxGrey.Name = "textBoxGrey";
            this.textBoxGrey.Size = new System.Drawing.Size(28, 21);
            this.textBoxGrey.TabIndex = 5;
            this.textBoxGrey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "100IRE";
            // 
            // textBoxTiming
            // 
            this.textBoxTiming.Location = new System.Drawing.Point(203, 10);
            this.textBoxTiming.Name = "textBoxTiming";
            this.textBoxTiming.Size = new System.Drawing.Size(28, 21);
            this.textBoxTiming.TabIndex = 3;
            this.textBoxTiming.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelTiming
            // 
            this.labelTiming.AutoSize = true;
            this.labelTiming.Location = new System.Drawing.Point(156, 14);
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
            this.comboBox1.Location = new System.Drawing.Point(52, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // labelModel
            // 
            this.labelModel.AutoSize = true;
            this.labelModel.Location = new System.Drawing.Point(17, 14);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormVPG";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox textBox100IRE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWhite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxGrey;
    }
}