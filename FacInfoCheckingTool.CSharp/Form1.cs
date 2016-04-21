using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FacInfoCheckingTool.CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string brandName;

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.TopMost = true;
            this.Hide();
            this.ShowInTaskbar = false;

            if (splashScreen.ShowDialog() == DialogResult.OK)
            {
                brandName = splashScreen.BrandName;
                if (brandName == "CAN")
                {
                    pictureBoxLogo.Image = global::FacInfoCheckingTool.CSharp.Properties.Resources.CANTV;
                }
                else if(brandName == "Haier")
                {
                    pictureBoxLogo.Image = global::FacInfoCheckingTool.CSharp.Properties.Resources.Haier;
                }

                labelModelName.Text = splashScreen.ModelName;

                splashScreen.Dispose();
                this.Show();
            }
        }

        private void watermarkTextBoxBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {            
            if (e.KeyChar == 13)
            {
                if (watermarkTextBoxBarcode.Text.Length == 1)
                {
                    watermarkTextBoxBarcode.ReadOnly = true;
                    watermarkTextBoxMacAddr.Focus();
                }
                else
                {
                    string caption = "整机条码长度不正确";
                    string message = "请输入正确的整机条码。";
                    var result = MessageBox.Show(message, caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    OutputLog.SaveLogInFile(caption + "！");

                    if (result == DialogResult.OK)
                    {
                        watermarkTextBoxBarcode.Text = "";
                        watermarkTextBoxBarcode.Focus();
                    }
                }
            }
            else if ((e.KeyChar >= 48 && e.KeyChar <= 57)  // 0-9
                || (e.KeyChar >= 65 && e.KeyChar <= 90)    // A-Z
                || (e.KeyChar >= 97 && e.KeyChar <= 122)   // a-z
                || (e.KeyChar == 46) || (e.KeyChar == 8))  // Del and Backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void watermarkTextBoxMacAddr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (watermarkTextBoxMacAddr.Text.Length == 1)
                {
                    watermarkTextBoxMacAddr.ReadOnly = true;
                    textBoxLog.Focus();
                }
                else
                {
                    string caption = "MAC 地址条码长度不正确";
                    string message = "请输入正确的 MAC 地址条码。";
                    var result = MessageBox.Show(message, caption,
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    OutputLog.SaveLogInFile(caption + "！");

                    if (result == DialogResult.OK)
                    {
                        watermarkTextBoxMacAddr.Text = "";
                        watermarkTextBoxMacAddr.Focus();
                    }
                }
            }
            else if ((e.KeyChar >= 48 && e.KeyChar <= 57)  // 0-9
                || (e.KeyChar >= 65 && e.KeyChar <= 90)    // A-Z
                || (e.KeyChar >= 97 && e.KeyChar <= 122)   // a-z
                || (e.KeyChar == 46) || (e.KeyChar == 8))  // Del and Backspace
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
