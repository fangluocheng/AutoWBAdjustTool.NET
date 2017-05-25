using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace AutoWBAdjustTool.NET
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

        public static string GetNodeValueByBrand(string brand, string node)
        {
            return (from c in config.Descendants(node)
                    where c.Parent.Attribute("name").Value == brand
                    select c.Value).First();
        }

        public static string GetNodeValueByBrand(string brand, string node1, string node2)
        {
            return (from c in config.Descendants(node1).Descendants(node2)
                    where c.Parent.Parent.Attribute("name").Value == brand
                    select c.Value).First();
        }

        public static string GetNodeValueByBrandAndModel(string brand, string model, string node)
        {
            return (from c in config.Descendants(node)
                    where (c.Parent.Parent.Attribute("name").Value == brand)
                    && (c.Parent.Attribute("name").Value == model)
                    select c.Value).First();
        }

        public static string GetNodeValueByBrandAndModel(string brand, string model, string node1, string node2)
        {
            return (from c in config.Descendants(node1).Descendants(node2)
                    where (c.Parent.Parent.Parent.Attribute("name").Value == brand)
                    && (c.Parent.Parent.Attribute("name").Value == model)
                    select c.Value).First();
        }

        public static string GetNodeValueByBrandAndModel(string brand, string model, string node1, string node2, string node3)
        {
            return (from c in config.Descendants(node1).Descendants(node2).Descendants(node3)
                    where (c.Parent.Parent.Parent.Parent.Attribute("name").Value == brand)
                    && (c.Parent.Parent.Parent.Attribute("name").Value == model)
                    select c.Value).First();
        }

        public static void SetNodeValue(string node, string value)
        {
            config.Descendants(node).First().SetValue(value);
        }

        public static void SetNodeValueByBrand(string brand, string node, string value)
        {
            (from c in config.Descendants(node)
             where c.Parent.Attribute("name").Value == brand
             select c).First().SetValue(value);
        }

        public static void SetNodeValueByBrand(string brand, string node1, string node2, string value)
        {
            (from c in config.Descendants(node1).Descendants(node2)
             where c.Parent.Parent.Attribute("name").Value == brand
             select c).First().SetValue(value);
        }

        public static void SetNodeValueByBrandAndModel(string brand, string model, string node, string value)
        {
            (from c in config.Descendants(node)
             where (c.Parent.Parent.Attribute("name").Value == brand)
             && (c.Parent.Attribute("name").Value == model)
             select c).First().SetValue(value);
        }

        public static void SetNodeValueByBrandAndModel(string brand, string model, string node1, string node2, string value)
        {
            (from c in config.Descendants(node1).Descendants(node2)
             where (c.Parent.Parent.Parent.Attribute("name").Value == brand)
             && (c.Parent.Parent.Attribute("name").Value == model)
             select c).First().SetValue(value);
        }

        public static string GetAttributeValueByNode(string node, string attributeValue)
        {
            return config.Descendants(node).Attributes(attributeValue).First().Value;
        }

        public static string GetAttributeValueByNode(string node1, string node2, string attributeValue)
        {
            return config.Descendants(node1).Descendants(node2).Attributes(attributeValue).First().Value;
        }

        public static string GetAttributeValueByBrand(string brand, string node, string attributeValue)
        {
            return (from c in config.Descendants(node)
                    where (c.Parent.Attribute("name").Value == brand)
                    select c.Attributes(attributeValue).First().Value).First();
        }        

        public static void SetAttributeValueByNode(string node, string attributeName, string attributeValue)
        {
            config.Descendants(node).First().SetAttributeValue(attributeName, attributeValue);
        }

        public static void SetAttributeValueByNode(string node1, string node2, string attributeName, string attributeValue)
        {
            config.Descendants(node1).Descendants(node2).First().SetAttributeValue(attributeName, attributeValue);
        }

        public static void SetAttributeValueByBrand(string brand, string node, string attributeName, string attributeValue)
        {
            (from c in config.Descendants(node)
             where (c.Parent.Attribute("name").Value == brand)
             select c).First().SetAttributeValue(attributeName, attributeValue);
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
