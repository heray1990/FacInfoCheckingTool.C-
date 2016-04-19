namespace FacInfoCheckingTool.CSharp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.串口设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSwVer = new System.Windows.Forms.Label();
            this.labelMacAddr = new System.Windows.Forms.Label();
            this.labelSwVerTitle = new System.Windows.Forms.Label();
            this.labelMacAddrTitle = new System.Windows.Forms.Label();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelModelName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.watermarkTextBoxMacAddr = new FacInfoCheckingTool.CSharp.WatermarkTextBox();
            this.watermarkTextBoxBarcode = new FacInfoCheckingTool.CSharp.WatermarkTextBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.watermarkTextBoxMacAddr);
            this.groupBox1.Controls.Add(this.watermarkTextBoxBarcode);
            this.groupBox1.Location = new System.Drawing.Point(165, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条码数据";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(357, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.串口设置ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 串口设置ToolStripMenuItem
            // 
            this.串口设置ToolStripMenuItem.Name = "串口设置ToolStripMenuItem";
            this.串口设置ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.串口设置ToolStripMenuItem.Text = "串口设置";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelSwVer, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelMacAddr, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelSwVerTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelMacAddrTitle, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 115);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(337, 55);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // labelSwVer
            // 
            this.labelSwVer.BackColor = System.Drawing.SystemColors.Window;
            this.labelSwVer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSwVer.Location = new System.Drawing.Point(168, 27);
            this.labelSwVer.Margin = new System.Windows.Forms.Padding(0);
            this.labelSwVer.Name = "labelSwVer";
            this.labelSwVer.Size = new System.Drawing.Size(169, 27);
            this.labelSwVer.TabIndex = 3;
            this.labelSwVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMacAddr
            // 
            this.labelMacAddr.BackColor = System.Drawing.SystemColors.Window;
            this.labelMacAddr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMacAddr.Location = new System.Drawing.Point(0, 27);
            this.labelMacAddr.Margin = new System.Windows.Forms.Padding(0);
            this.labelMacAddr.Name = "labelMacAddr";
            this.labelMacAddr.Size = new System.Drawing.Size(168, 27);
            this.labelMacAddr.TabIndex = 2;
            this.labelMacAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSwVerTitle
            // 
            this.labelSwVerTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSwVerTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSwVerTitle.Location = new System.Drawing.Point(168, 0);
            this.labelSwVerTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelSwVerTitle.Name = "labelSwVerTitle";
            this.labelSwVerTitle.Size = new System.Drawing.Size(169, 27);
            this.labelSwVerTitle.TabIndex = 1;
            this.labelSwVerTitle.Text = "软件版本";
            this.labelSwVerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMacAddrTitle
            // 
            this.labelMacAddrTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelMacAddrTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMacAddrTitle.Location = new System.Drawing.Point(0, 0);
            this.labelMacAddrTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelMacAddrTitle.Name = "labelMacAddrTitle";
            this.labelMacAddrTitle.Size = new System.Drawing.Size(168, 27);
            this.labelMacAddrTitle.TabIndex = 0;
            this.labelMacAddrTitle.Text = "MAC 地址";
            this.labelMacAddrTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBoxLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBoxLog.Location = new System.Drawing.Point(10, 176);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.Size = new System.Drawing.Size(337, 120);
            this.textBoxLog.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelResult);
            this.groupBox2.Location = new System.Drawing.Point(10, 302);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "检验结果";
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.Window;
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelResult.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelResult.Location = new System.Drawing.Point(8, 17);
            this.labelResult.Margin = new System.Windows.Forms.Padding(0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(323, 34);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Checking";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelModelName
            // 
            this.labelModelName.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelModelName.Location = new System.Drawing.Point(10, 84);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(150, 25);
            this.labelModelName.TabIndex = 6;
            this.labelModelName.Text = "Model";
            this.labelModelName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(10, 28);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 50);
            this.pictureBoxLogo.TabIndex = 2;
            this.pictureBoxLogo.TabStop = false;
            // 
            // watermarkTextBoxMacAddr
            // 
            this.watermarkTextBoxMacAddr.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.watermarkTextBoxMacAddr.Location = new System.Drawing.Point(6, 49);
            this.watermarkTextBoxMacAddr.Name = "watermarkTextBoxMacAddr";
            this.watermarkTextBoxMacAddr.Size = new System.Drawing.Size(170, 23);
            this.watermarkTextBoxMacAddr.TabIndex = 2;
            this.watermarkTextBoxMacAddr.WatermarkText = "请输入 MAC 地址";
            // 
            // watermarkTextBoxBarcode
            // 
            this.watermarkTextBoxBarcode.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.watermarkTextBoxBarcode.Location = new System.Drawing.Point(6, 20);
            this.watermarkTextBoxBarcode.Name = "watermarkTextBoxBarcode";
            this.watermarkTextBoxBarcode.Size = new System.Drawing.Size(170, 23);
            this.watermarkTextBoxBarcode.TabIndex = 1;
            this.watermarkTextBoxBarcode.WatermarkText = "请输入电视条码";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 372);
            this.Controls.Add(this.labelModelName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "工厂信息检验工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 串口设置ToolStripMenuItem;
        private WatermarkTextBox watermarkTextBoxBarcode;
        private WatermarkTextBox watermarkTextBoxMacAddr;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelSwVerTitle;
        private System.Windows.Forms.Label labelMacAddrTitle;
        private System.Windows.Forms.Label labelMacAddr;
        private System.Windows.Forms.Label labelSwVer;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Label labelModelName;
    }
}

