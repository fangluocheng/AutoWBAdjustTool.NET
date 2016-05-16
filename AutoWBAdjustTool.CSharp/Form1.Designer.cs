namespace AutoWBAdjustTool.CSharp
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVPG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpecSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCommonSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemSetting
            // 
            this.toolStripMenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVPG,
            this.toolStripMenuItemSpecSetting,
            this.toolStripMenuItemCommonSetting});
            this.toolStripMenuItemSetting.Name = "toolStripMenuItemSetting";
            this.toolStripMenuItemSetting.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemSetting.Text = "设置";
            // 
            // toolStripMenuItemVPG
            // 
            this.toolStripMenuItemVPG.Name = "toolStripMenuItemVPG";
            this.toolStripMenuItemVPG.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemVPG.Text = "信号发生器";
            this.toolStripMenuItemVPG.Click += new System.EventHandler(this.toolStripMenuItemVPG_Click);
            // 
            // toolStripMenuItemSpecSetting
            // 
            this.toolStripMenuItemSpecSetting.Name = "toolStripMenuItemSpecSetting";
            this.toolStripMenuItemSpecSetting.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemSpecSetting.Text = "规格设置";
            this.toolStripMenuItemSpecSetting.Click += new System.EventHandler(this.toolStripMenuItemSpecSetting_Click);
            // 
            // toolStripMenuItemCommonSetting
            // 
            this.toolStripMenuItemCommonSetting.Name = "toolStripMenuItemCommonSetting";
            this.toolStripMenuItemCommonSetting.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItemCommonSetting.Text = "通用设置";
            this.toolStripMenuItemCommonSetting.Click += new System.EventHandler(this.toolStripMenuItemCommonSetting_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVPG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpecSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommonSetting;
    }
}

