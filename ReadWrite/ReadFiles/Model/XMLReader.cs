using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ReadFiles.Model
{
    internal class XMLReader
    {
        public static void ReadXmlFile(string filePath)
        {
            /*try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Process each line from the XML file.
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading XML file: " + ex.Message);
            }*/

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    XmlDocument xmlDoc = new XmlDocument();
                    xmlDoc.Load(reader);

                    XmlNodeList bookNodes = xmlDoc.SelectNodes("/library/book");
                    if (bookNodes != null)
                    {
                        foreach (XmlNode bookNode in bookNodes)
                        {
                            string title = bookNode.SelectSingleNode("title")?.InnerText;
                            string author = bookNode.SelectSingleNode("author")?.InnerText;
                            string year = bookNode.SelectSingleNode("year")?.InnerText;

                            Console.WriteLine("Title: " + title);
                            Console.WriteLine("Author: " + author);
                            Console.WriteLine("Year: " + year);
                            Console.WriteLine();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading XML file: " + ex.Message);
            }
        }
    }
}
