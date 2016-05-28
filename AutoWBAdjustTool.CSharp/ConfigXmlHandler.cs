using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace AutoWBAdjustTool.CSharp
{
    public static class ConfigXmlHandler
    {
        private const string xmlFileName = @".\config.xml";
        private static XDocument config = XDocument.Load(xmlFileName);
        
        public static void SaveConfigXml()
        {
            config.Save(xmlFileName);
        }

        public static string GetNodeValue(string node)
        {
            return config.Descendants(node).First().Value;
        }

        public static void SetNodeValue(string node, string value)
        {
            config.Descendants(node).First().SetValue(value);
        }

        public static string GetAttributeValueByNode(string node, string attribute)
        {
            return config.Descendants(node).Attributes(attribute).First().Value;
        }

        public static IEnumerable<string> GetBrandList()
        {
            return from item in config.Descendants("products").Descendants("brand").Attributes()
                   select item.Value;
        }

        public static IEnumerable<string> GetModelList(string brandName)
        {
            return from item in config.Descendants("brand").Descendants("model")
                   where (string)item.Parent.Attribute("name").Value == brandName
                   select item.Attribute("name").Value;
        }
    }
}
