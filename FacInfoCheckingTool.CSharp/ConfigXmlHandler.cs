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
        public static string currentBrand, currentModel;
        public static string comBaudRate, comId;
        public static bool macAddrChecked, swVerChecked;
        private string xmlFile;

        public string CurrentBrand
        {
            set
            {
                config.Descendants("currentproduct").First().SetElementValue("brand", value.ToString());
                currentBrand = value.ToString();
            }
            get
            {
                return config.Descendants("currentproduct").Descendants("brand").First().Value;
            }
        }

        public string CurrentModel
        {
            set
            {
                config.Descendants("currentproduct").First().SetElementValue("model", value.ToString());
                currentModel = value.ToString();
            }
            get
            {
                return config.Descendants("currentproduct").Descendants("model").First().Value;
            }
        }

        public string ComBaudRate
        {
            set
            {
                config.Descendants("serialport").First().SetAttributeValue("baud", value.ToString());
                comBaudRate = value.ToString();
            }
            get
            {
                return config.Descendants("serialport").Attributes("baud").First().Value;
            }
        }

        public string ComId
        {
            set
            {
                config.Descendants("serialport").First().SetAttributeValue("id", value.ToString());
                comId = value.ToString();
            }
            get
            {
                return config.Descendants("serialport").Attributes("id").First().Value;
            }
        }

        public bool MacAddrChecked
        {
            set
            {
                if (value)
                {
                    (from c in config.Descendants("macaddr")
                     where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                      && (c.Parent.Attribute("name").Value == currentModel)
                     select c).First().SetAttributeValue("enable", "true");
                }
                else
                {
                    (from c in config.Descendants("macaddr")
                     where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                      && (c.Parent.Attribute("name").Value == currentModel)
                     select c).First().SetAttributeValue("enable", "false");
                }
                macAddrChecked = value;
            }
            get
            {
                if ((from c in config.Descendants("macaddr")
                       where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                        && (c.Parent.Attribute("name").Value == currentModel)
                       select c.Attributes("enable").First().Value).First().ToLower() == "true")
                {
                    return true;
                }
                else { return false; }
            }
        }

        public bool SwVerChecked
        {
            set
            {
                if (value)
                {
                    (from c in config.Descendants("swversion")
                     where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                      && (c.Parent.Attribute("name").Value == currentModel)
                     select c).First().SetAttributeValue("enable", "true");
                }
                else
                {
                    (from c in config.Descendants("swversion")
                     where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                      && (c.Parent.Attribute("name").Value == currentModel)
                     select c).First().SetAttributeValue("enable", "false");
                }
                swVerChecked = value;
            }
            get
            {
                if ((from c in config.Descendants("swversion")
                     where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                      && (c.Parent.Attribute("name").Value == currentModel)
                     select c.Attributes("enable").First().Value).First().ToLower() == "true")
                {
                    return true;
                }
                else { return false; }
            }
        }

        public string SwVersion
        {
            set
            {
                (from c in config.Descendants("product").Descendants("model")
                 where (c.Parent.Attribute("brand").Value == currentBrand)
                 && (c.Attribute("name").Value == currentModel)
                 select c).First().SetElementValue("swversion", value);
            }
            get
            {
                return (from c in config.Descendants("swversion")
                        where (c.Parent.Parent.Attribute("brand").Value == currentBrand)
                        && (c.Parent.Attribute("name").Value == currentModel)
                        select c.Value).First();
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

        public void SaveConfigXml()
        {
            config.Save(xmlFile);
        }
    }
}
