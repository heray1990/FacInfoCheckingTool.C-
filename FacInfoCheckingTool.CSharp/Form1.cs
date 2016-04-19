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

        private void Form1_Load(object sender, EventArgs e)
        {
            SplashScreen splashScreen = new SplashScreen();
            splashScreen.TopMost = true;
            this.Hide();
            this.ShowInTaskbar = false;

            if (splashScreen.ShowDialog() == DialogResult.OK)
            {
                pictureBoxLogo.Image = global::FacInfoCheckingTool.CSharp.Properties.Resources.CANTV;
                OutputLog.ShowLog(textBoxLog, "Hello world!");
                this.Show();
            }
        }
    }
}
