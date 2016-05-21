namespace FacInfoCheckingTool.CSharp
{
    partial class FormTvInfoSetting
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
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.textBoxSwVersion = new System.Windows.Forms.TextBox();
            this.checkBoxMacAddr = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxMacAddr = new System.Windows.Forms.TextBox();
            this.checkBoxSwVer = new System.Windows.Forms.CheckBox();
            this.labelModelName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.InitialImage = null;
            this.pictureBoxLogo.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(150, 50);
            this.pictureBoxLogo.TabIndex = 3;
            this.pictureBoxLogo.TabStop = false;
            // 
            // textBoxSwVersion
            // 
            this.textBoxSwVersion.Location = new System.Drawing.Point(133, 29);
            this.textBoxSwVersion.Name = "textBoxSwVersion";
            this.textBoxSwVersion.Size = new System.Drawing.Size(124, 21);
            this.textBoxSwVersion.TabIndex = 11;
            this.textBoxSwVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxMacAddr
            // 
            this.checkBoxMacAddr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxMacAddr.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMacAddr.Name = "checkBoxMacAddr";
            this.checkBoxMacAddr.Size = new System.Drawing.Size(124, 20);
            this.checkBoxMacAddr.TabIndex = 12;
            this.checkBoxMacAddr.Text = "MAC 地址";
            this.checkBoxMacAddr.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxMacAddr, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSwVersion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxMacAddr, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxSwVer, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 68);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(260, 52);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // textBoxMacAddr
            // 
            this.textBoxMacAddr.Location = new System.Drawing.Point(3, 29);
            this.textBoxMacAddr.Name = "textBoxMacAddr";
            this.textBoxMacAddr.ReadOnly = true;
            this.textBoxMacAddr.Size = new System.Drawing.Size(124, 21);
            this.textBoxMacAddr.TabIndex = 14;
            this.textBoxMacAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxSwVer
            // 
            this.checkBoxSwVer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxSwVer.Location = new System.Drawing.Point(133, 3);
            this.checkBoxSwVer.Name = "checkBoxSwVer";
            this.checkBoxSwVer.Size = new System.Drawing.Size(124, 20);
            this.checkBoxSwVer.TabIndex = 13;
            this.checkBoxSwVer.Text = "软件版本";
            this.checkBoxSwVer.UseVisualStyleBackColor = false;
            this.checkBoxSwVer.CheckedChanged += new System.EventHandler(this.checkBoxSwVer_CheckedChanged);
            // 
            // labelModelName
            // 
            this.labelModelName.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelModelName.Location = new System.Drawing.Point(168, 12);
            this.labelModelName.Name = "labelModelName";
            this.labelModelName.Size = new System.Drawing.Size(104, 20);
            this.labelModelName.TabIndex = 14;
            this.labelModelName.Text = "Model";
            this.labelModelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(197, 39);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 15;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormTvInfoSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelModelName);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBoxLogo);
            this.Name = "FormTvInfoSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTvInfoSetting";
            this.Load += new System.EventHandler(this.FormTvInfoSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.TextBox textBoxSwVersion;
        private System.Windows.Forms.CheckBox checkBoxMacAddr;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelModelName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxMacAddr;
        private System.Windows.Forms.CheckBox checkBoxSwVer;
    }
}