using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FacInfoCheckingTool.CSharp
{
    public partial class FormTvInfoSetting : Form
    {
        public FormTvInfoSetting()
        {
            InitializeComponent();
        }

        private ConfigXmlHandler configXml;

        private void FormTvInfoSetting_Load(object sender, EventArgs e)
        {
            string xmlFileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\config.xml";
            configXml = new ConfigXmlHandler(xmlFileName);

            textBoxSwVersion.Text = configXml.SwVersion;

            if (ConfigXmlHandler.macAddrChecked)
            {
                checkBoxMacAddr.Checked = true;
            }
            else
            {
                checkBoxMacAddr.Checked = false;
            }

            if (ConfigXmlHandler.swVerChecked)
            {
                checkBoxSwVer.Checked = true;
                textBoxSwVersion.ReadOnly = false;
            }
            else
            {
                checkBoxSwVer.Checked = false;
                textBoxSwVersion.ReadOnly = true;
            }

            if (ConfigXmlHandler.currentBrand == "CAN")
            {
                pictureBoxLogo.Image = global::FacInfoCheckingTool.CSharp.Properties.Resources.CANTV;
            }
            else if (ConfigXmlHandler.currentBrand == "Haier")
            {
                pictureBoxLogo.Image = global::FacInfoCheckingTool.CSharp.Properties.Resources.Haier;
            }
            else
            {
                pictureBoxLogo.Image = global::FacInfoCheckingTool.CSharp.Properties.Resources.CANTV;
            }

            labelModelName.Text = ConfigXmlHandler.currentModel;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            configXml.MacAddrChecked = checkBoxMacAddr.Checked;
            configXml.SwVerChecked = checkBoxSwVer.Checked;
            if (configXml.SwVerChecked)
            {
                configXml.SwVersion = textBoxSwVersion.Text;
            }
            configXml.SaveConfigXml();

            this.Hide();
        }

        private void checkBoxSwVer_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSwVer.Checked)
            {
                textBoxSwVersion.ReadOnly = false;
            }
            else
            {
                textBoxSwVersion.ReadOnly = true;
            }
        }
    }
}
