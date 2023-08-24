using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WriteFiles.Model
{
    internal class XMLWriter
    {
        public static void WriteXml(string title, string author, string year, string filePath)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                if (File.Exists(filePath))
                {
                    xmlDoc.Load(filePath);
                }
                else
                {
                    // Create a new XML document if the file doesn't exist
                    XmlDeclaration xmlDeclaration = xmlDoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                    xmlDoc.AppendChild(xmlDeclaration);
                    XmlNode libraryNode = xmlDoc.CreateElement("library");
                    xmlDoc.AppendChild(libraryNode);
                }

                XmlNode bookNode = xmlDoc.CreateElement("book");

                XmlNode titleNode = xmlDoc.CreateElement("title");
                titleNode.InnerText = title;
                bookNode.AppendChild(titleNode);

                XmlNode authorNode = xmlDoc.CreateElement("author");
                authorNode.InnerText = author;
                bookNode.AppendChild(authorNode);

                XmlNode yearNode = xmlDoc.CreateElement("year");
                yearNode.InnerText = year;
                bookNode.AppendChild(yearNode);

                xmlDoc.DocumentElement.AppendChild(bookNode);

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    xmlDoc.Save(writer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to XML file: " + ex.Message);
            }
        }
    }
}
