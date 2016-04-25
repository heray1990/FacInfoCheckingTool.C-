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
            int index = 0;

            /* Load Brand and Model from config.xml. And initialize the 
             * items of comboBoxBrand and comboBoxModel. */
            foreach (string itemBrand in configXml.GetBrandList())
            {
                comboBoxBrand.Items.Add(itemBrand);

                if (itemBrand == configXml.CurrentBrand)
                {
                    index = configXml.GetBrandList().ToList().IndexOf(itemBrand);
                }
            }
            comboBoxBrand.SelectedIndex = index;

            comboBoxModel.Items.Clear();
            IEnumerable<string> modelList = configXml.GetModelList(comboBoxBrand.Text);
            foreach (string itemModel in modelList)
            {
                comboBoxModel.Items.Add(itemModel);

                if (itemModel == configXml.CurrentModel)
                {
                    index = modelList.ToList().IndexOf(itemModel);
                }
            }
            comboBoxModel.SelectedIndex = index;

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
            comboBoxModel.Items.Clear();
            foreach (string itemModel in queryModels)
            {
                comboBoxModel.Items.Add(itemModel);
            }
            comboBoxModel.SelectedIndex = 0;
        }
    }
}
