using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace FacInfoCheckingTool.CSharp
{
    public partial class SplashScreen : Form
    {

        public SplashScreen()
        {
            InitializeComponent();
            xmlFileName = Path.GetDirectoryName(Application.ExecutablePath) + @"\config.xml";
            configXml = new ConfigXmlHandler(xmlFileName);
        }

        private string xmlFileName;
        ConfigXmlHandler configXml;

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            /* Load Brand and Model from config.xml. And initialize the 
             * items of comboBoxBrand and comboBoxModel. */
            comboBoxBrand.Text = configXml.CurrentBrand;
            comboBoxModel.Text = configXml.CurrentModel;

            foreach (string itemBrand in configXml.GetBrandList())
            {
                comboBoxBrand.Items.Add(itemBrand);
            }

            foreach (string itemModel in configXml.GetModelList(comboBoxBrand.Text))
            {
                comboBoxModel.Items.Add(itemModel);
            }

            ConfigXmlHandler.comBaudRate = configXml.ComBaudRate;
            ConfigXmlHandler.comId = configXml.ComId;

            labelVersion.Text = OutputLog.Version();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            ConfigXmlHandler.currentBrand = comboBoxBrand.Text;
            ConfigXmlHandler.currentModel = comboBoxModel.Text;
            configXml.CurrentBrand = comboBoxBrand.Text;
            configXml.CurrentModel = comboBoxModel.Text;
            configXml.SaveConfigXml();

            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void comboBoxBrand_SelectedIndexChanged(object sender, EventArgs e)
        {           
            IEnumerable<string> queryModels = configXml.RefreshModelList(comboBoxBrand.Text);
            comboBoxModel.Text = queryModels.First();
            comboBoxModel.Items.Clear();
            foreach (string itemModel in queryModels)
            {
                comboBoxModel.Items.Add(itemModel);
            }
        }
    }
}
