namespace AutoWBAdjustTool.NET
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemConnectCa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDisconnectCa = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVPG = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSpecSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemCommonSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemColorAnalyzer = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxCoordinate = new System.Windows.Forms.PictureBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelProcess = new System.Windows.Forms.Label();
            this.labelWarm = new System.Windows.Forms.Label();
            this.labelStandard = new System.Windows.Forms.Label();
            this.labelCool = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelModelName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelLv = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.labelSpecLv = new System.Windows.Forms.Label();
            this.labelSpecy = new System.Windows.Forms.Label();
            this.labelSpecx = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.labelValueLv = new System.Windows.Forms.Label();
            this.labelValuey = new System.Windows.Forms.Label();
            this.labelValuex = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoordinate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFunction,
            this.toolStripMenuItemSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(634, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItemFunction
            // 
            this.toolStripMenuItemFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemConnectCa,
            this.toolStripMenuItemDisconnectCa});
            this.toolStripMenuItemFunction.Name = "toolStripMenuItemFunction";
            this.toolStripMenuItemFunction.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemFunction.Text = "功能";
            // 
            // toolStripMenuItemConnectCa
            // 
            this.toolStripMenuItemConnectCa.Name = "toolStripMenuItemConnectCa";
            this.toolStripMenuItemConnectCa.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItemConnectCa.Text = "连接 CA310/CA210";
            this.toolStripMenuItemConnectCa.Click += new System.EventHandler(this.toolStripMenuItemConnectCa_Click);
            // 
            // toolStripMenuItemDisconnectCa
            // 
            this.toolStripMenuItemDisconnectCa.Name = "toolStripMenuItemDisconnectCa";
            this.toolStripMenuItemDisconnectCa.Size = new System.Drawing.Size(183, 22);
            this.toolStripMenuItemDisconnectCa.Text = "断开 CA310/CA210";
            this.toolStripMenuItemDisconnectCa.Click += new System.EventHandler(this.toolStripMenuItemDisconnectCa_Click);
            // 
            // toolStripMenuItemSetting
            // 
            this.toolStripMenuItemSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVPG,
            this.toolStripMenuItemSpecSetting,
            this.toolStripMenuItemCommonSetting,
            this.toolStripMenuItemColorAnalyzer});
            this.toolStripMenuItemSetting.Name = "toolStripMenuItemSetting";
            this.toolStripMenuItemSetting.Size = new System.Drawing.Size(44, 21);
            this.toolStripMenuItemSetting.Text = "设置";
            // 
            // toolStripMenuItemVPG
            // 
            this.toolStripMenuItemVPG.Name = "toolStripMenuItemVPG";
            this.toolStripMenuItemVPG.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemVPG.Text = "信号发生器";
            this.toolStripMenuItemVPG.Click += new System.EventHandler(this.toolStripMenuItemVPG_Click);
            // 
            // toolStripMenuItemSpecSetting
            // 
            this.toolStripMenuItemSpecSetting.Name = "toolStripMenuItemSpecSetting";
            this.toolStripMenuItemSpecSetting.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemSpecSetting.Text = "规格设置";
            this.toolStripMenuItemSpecSetting.Click += new System.EventHandler(this.toolStripMenuItemSpecSetting_Click);
            // 
            // toolStripMenuItemCommonSetting
            // 
            this.toolStripMenuItemCommonSetting.Name = "toolStripMenuItemCommonSetting";
            this.toolStripMenuItemCommonSetting.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemCommonSetting.Text = "通用设置";
            this.toolStripMenuItemCommonSetting.Click += new System.EventHandler(this.toolStripMenuItemCommonSetting_Click);
            // 
            // toolStripMenuItemColorAnalyzer
            // 
            this.toolStripMenuItemColorAnalyzer.Name = "toolStripMenuItemColorAnalyzer";
            this.toolStripMenuItemColorAnalyzer.Size = new System.Drawing.Size(160, 22);
            this.toolStripMenuItemColorAnalyzer.Text = "色彩分析仪设置";
            this.toolStripMenuItemColorAnalyzer.Click += new System.EventHandler(this.toolStripMenuItemColorAnalyzer_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBoxCoordinate);
            this.panel1.Controls.Add(this.textBoxLog);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.labelProcess);
            this.panel1.Controls.Add(this.labelWarm);
            this.panel1.Controls.Add(this.labelStandard);
            this.panel1.Controls.Add(this.labelCool);
            this.panel1.Controls.Add(this.textBoxBarcode);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.labelModelName);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(12, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 303);
            this.panel1.TabIndex = 1;
            // 
            // pictureBoxCoordinate
            // 
            this.pictureBoxCoordinate.BackgroundImage = global::AutoWBAdjustTool.NET.Properties.Resources.Picture1;
            this.pictureBoxCoordinate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxCoordinate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCoordinate.Location = new System.Drawing.Point(159, 48);
            this.pictureBoxCoordinate.Name = "pictureBoxCoordinate";
            this.pictureBoxCoordinate.Size = new System.Drawing.Size(251, 176);
            this.pictureBoxCoordinate.TabIndex = 16;
            this.pictureBoxCoordinate.TabStop = false;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxLog.Location = new System.Drawing.Point(409, 48);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(200, 254);
            this.textBoxLog.TabIndex = 15;
            // 
            // labelTime
            // 
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTime.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTime.Location = new System.Drawing.Point(-1, 262);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(161, 40);
            this.labelTime.TabIndex = 14;
            this.labelTime.Text = "0s";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcess
            // 
            this.labelProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelProcess.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProcess.Location = new System.Drawing.Point(-1, 223);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(161, 40);
            this.labelProcess.TabIndex = 13;
            this.labelProcess.Text = "INITIAL";
            this.labelProcess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWarm
            // 
            this.labelWarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelWarm.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarm.Location = new System.Drawing.Point(-1, 184);
            this.labelWarm.Name = "labelWarm";
            this.labelWarm.Size = new System.Drawing.Size(161, 40);
            this.labelWarm.TabIndex = 12;
            this.labelWarm.Text = "WARM";
            this.labelWarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStandard
            // 
            this.labelStandard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStandard.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStandard.Location = new System.Drawing.Point(-1, 145);
            this.labelStandard.Name = "labelStandard";
            this.labelStandard.Size = new System.Drawing.Size(161, 40);
            this.labelStandard.TabIndex = 11;
            this.labelStandard.Text = "STANDARD";
            this.labelStandard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCool
            // 
            this.labelCool.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCool.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelCool.Location = new System.Drawing.Point(-1, 106);
            this.labelCool.Name = "labelCool";
            this.labelCool.Size = new System.Drawing.Size(161, 40);
            this.labelCool.TabIndex = 10;
            this.labelCool.Text = "COOL";
            this.labelCool.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBarcode.Font = new System.Drawing.Font("SimSun", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxBarcode.Location = new System.Drawing.Point(-1, 77);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(161, 30);
            this.textBoxBarcode.TabIndex = 9;
            this.textBoxBarcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.LimeGreen;
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft YaHei", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStatus.Location = new System.Drawing.Point(159, -1);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(450, 50);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "ADJUST COLOR";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModelName
            // 
            this.labelModelName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelModelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelModelName.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelModelName.Location = new System.Drawing.Point(-1, 48);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(161, 30);
            this.labelModelName.TabIndex = 7;
            this.labelModelName.Text = "Model";
            this.labelModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-1, -1);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.pictureBoxLogo.Size = new System.Drawing.Size(161, 50);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel1.Controls.Add(this.labelLv, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelx, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labely, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelSpecLv, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSpecy, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSpecx, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSpec, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelValueLv, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelValuey, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelValuex, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelValue, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(159, 223);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 79);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // labelLv
            // 
            this.labelLv.Location = new System.Drawing.Point(185, 1);
            this.labelLv.Name = "labelLv";
            this.labelLv.Size = new System.Drawing.Size(60, 18);
            this.labelLv.TabIndex = 3;
            this.labelLv.Text = "Lv";
            this.labelLv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelx
            // 
            this.labelx.Location = new System.Drawing.Point(51, 1);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(60, 18);
            this.labelx.TabIndex = 1;
            this.labelx.Text = "x";
            this.labelx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labely
            // 
            this.labely.Location = new System.Drawing.Point(118, 1);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(60, 18);
            this.labely.TabIndex = 2;
            this.labely.Text = "y";
            this.labely.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpecLv
            // 
            this.labelSpecLv.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSpecLv.Location = new System.Drawing.Point(185, 51);
            this.labelSpecLv.Name = "labelSpecLv";
            this.labelSpecLv.Size = new System.Drawing.Size(60, 22);
            this.labelSpecLv.TabIndex = 10;
            this.labelSpecLv.Text = "210";
            this.labelSpecLv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpecy
            // 
            this.labelSpecy.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSpecy.Location = new System.Drawing.Point(118, 51);
            this.labelSpecy.Name = "labelSpecy";
            this.labelSpecy.Size = new System.Drawing.Size(60, 22);
            this.labelSpecy.TabIndex = 9;
            this.labelSpecy.Text = "2970";
            this.labelSpecy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpecx
            // 
            this.labelSpecx.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSpecx.Location = new System.Drawing.Point(51, 51);
            this.labelSpecx.Name = "labelSpecx";
            this.labelSpecx.Size = new System.Drawing.Size(60, 22);
            this.labelSpecx.TabIndex = 8;
            this.labelSpecx.Text = "2670";
            this.labelSpecx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSpec
            // 
            this.labelSpec.Location = new System.Drawing.Point(1, 51);
            this.labelSpec.Margin = new System.Windows.Forms.Padding(0);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(43, 22);
            this.labelSpec.TabIndex = 7;
            this.labelSpec.Text = "Spec";
            this.labelSpec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValueLv
            // 
            this.labelValueLv.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelValueLv.Location = new System.Drawing.Point(185, 24);
            this.labelValueLv.Name = "labelValueLv";
            this.labelValueLv.Size = new System.Drawing.Size(60, 22);
            this.labelValueLv.TabIndex = 6;
            this.labelValueLv.Text = "210";
            this.labelValueLv.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValuey
            // 
            this.labelValuey.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelValuey.Location = new System.Drawing.Point(118, 24);
            this.labelValuey.Name = "labelValuey";
            this.labelValuey.Size = new System.Drawing.Size(60, 22);
            this.labelValuey.TabIndex = 5;
            this.labelValuey.Text = "2800";
            this.labelValuey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValuex
            // 
            this.labelValuex.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelValuex.Location = new System.Drawing.Point(51, 24);
            this.labelValuex.Name = "labelValuex";
            this.labelValuex.Size = new System.Drawing.Size(60, 22);
            this.labelValuex.TabIndex = 4;
            this.labelValuex.Text = "2700";
            this.labelValuex.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelValue
            // 
            this.labelValue.Location = new System.Drawing.Point(1, 24);
            this.labelValue.Margin = new System.Windows.Forms.Padding(0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(43, 22);
            this.labelValue.TabIndex = 0;
            this.labelValue.Text = "Value";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "自动白平衡调整";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoordinate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVPG;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSpecSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCommonSetting;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemColorAnalyzer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelWarm;
        private System.Windows.Forms.Label labelStandard;
        private System.Windows.Forms.Label labelCool;
        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.PictureBox pictureBoxCoordinate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelLv;
        private System.Windows.Forms.Label labelValuex;
        private System.Windows.Forms.Label labelValuey;
        private System.Windows.Forms.Label labelValueLv;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.Label labelSpecLv;
        private System.Windows.Forms.Label labelSpecy;
        private System.Windows.Forms.Label labelSpecx;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFunction;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemConnectCa;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDisconnectCa;
    }
}

