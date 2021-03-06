﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace TelephoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = ConfigurationManager.AppSettings["InputFileName"];
            string tagName = ConfigurationManager.AppSettings["TagName"];
            string attributeName = ConfigurationManager.AppSettings["AttributeName"];
            string query = ConfigurationManager.AppSettings["Query"];

            CreateXmlFile(fileName);
            GetPhoneNumbersViaXMLReader(fileName, tagName, attributeName);

            Console.WriteLine(new string('-', 15));

            GetPhoneNumbersViaXPath(fileName, query);

            Console.ReadKey();
        }

        static void CreateXmlFile(string fileName)
        {
            var xmlWriter = new XmlTextWriter(fileName, null);

            xmlWriter.Formatting = Formatting.Indented;

            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("MyContacts");

            xmlWriter.WriteStartElement("Contact");
            xmlWriter.WriteStartAttribute("TelephoneNumber");
            xmlWriter.WriteString("3752912345678");
            xmlWriter.WriteEndAttribute();
            xmlWriter.WriteString("Andrey");
            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndElement();

            xmlWriter.WriteEndDocument();

            xmlWriter.Close();
        }

        static void GetPhoneNumbersViaXMLReader(string fileName, string tagName, string attributeName)
        {
            var xmlReader = new XmlTextReader(fileName);

            while (xmlReader.Read())
            {
                if (xmlReader.NodeType == XmlNodeType.Element)
                {
                    if (xmlReader.Name.Equals(tagName))
                    {
                        Console.WriteLine(xmlReader.GetAttribute(attributeName));
                    }
                }
            }
        }

        static void GetPhoneNumbersViaXPath(string fileName, string query)
        {
            var xPathDocument = new XPathDocument(fileName);

            var navigator = xPathDocument.CreateNavigator();

            var phoneNumbers = navigator.Select(query);

            foreach (var number in phoneNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
