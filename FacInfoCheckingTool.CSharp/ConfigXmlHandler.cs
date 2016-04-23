using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace FacInfoCheckingTool.CSharp
{
    class ConfigXmlHandler
    {
        public ConfigXmlHandler(string xmlFileName)
        {
            xmlFile = xmlFileName;
            config = XDocument.Load(xmlFileName);
        }

        private XDocument config;
        private static string currentBrand, currentModel;
        private string xmlFile;

        public static string CurrentBrand
        {
            set
            {
                currentBrand = value;
            }
            get
            {
                return currentBrand;
            }
        }

        public static string CurrentModel
        {
            set
            {
                currentModel = value;
            }
            get
            {
                return currentModel;
            }
        }

        public string InitialBrandName
        {
            get
            {
                return config.Descendants("currentproduct").Descendants("brand").First().Value;
            }
        }
        public string InitialModelName
        {
            get
            {
                return config.Descendants("currentproduct").Descendants("model").First().Value; 
            }
        }
        public string SwVersion
        {
            get
            {
                return (from c in config.Descendants("swversion")
                        where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                        && (c.Parent.Attribute("name").Value == currentModel)
                        select c.Value).First(); ;
            }
        }
        public uint BarcodeLength
        {
            get
            {
                return uint.Parse((from c in config.Descendants("barcodelength")
                                   where c.Parent.Attribute("brand").Value == currentBrand
                                   select c.Value).First());
            }
        }
        public uint MacAddrLength
        {
            get
            {
                return uint.Parse((from c in config.Descendants("macaddrlength")
                                   where c.Parent.Attribute("brand").Value == currentBrand
                                   select c.Value).First());
            }
        }
        public uint ComBaudRate
        {
            get
            {
                return uint.Parse(config.Descendants("serialport").Attributes("baud").First().Value); ;
            }
        }
        public uint ComId
        {
            get
            {
                return uint.Parse(config.Descendants("serialport").Attributes("id").First().Value);
            }
        }

        public IEnumerable<string> GetBrandList()
        {
            return from item in config.Descendants("products").Descendants("product").Attributes()
                   select item.Value;
        }

        public IEnumerable<string> GetModelList(string brandName)
        {
            return from item in config.Descendants("product").Descendants("model")
                   where (string)item.Parent.Attribute("brand").Value == brandName
                   select item.Attribute("name").Value;
        }

        public IEnumerable<string> RefreshModelList(string brandName)
        {
            return from item in config.Descendants("product").Descendants("model")
                   where (string)item.Parent.Attribute("brand").Value == brandName
                   select item.Attribute("name").Value;
        }

        public void SetCurrentBrandInXml(string brandName)
        {
            config.Descendants("currentproduct").First().SetElementValue("brand", brandName);
        }

        public void SetCurrentModelInXml(string modelName)
        {
            config.Descendants("currentproduct").First().SetElementValue("model", modelName);
        }

        public void SaveConfigXml()
        {
            config.Save(xmlFile);
        }
    }
}
