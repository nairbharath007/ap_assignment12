using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFiles.Model
{
    internal class HTMLReader
    {
        public static void ReadHtmlFile(string filePath)
        {
            /*try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Process each line from the HTML file.
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading HTML file: " + ex.Message);
            }*/


            /*Console.WriteLine("============using HTML Agility pAck========");
            try
            {
                HtmlDocument htmlDoc = new HtmlDocument();
                using (StreamReader reader = new StreamReader(filePath))
                {
                    htmlDoc.Load(reader);

                    var bookNodes = htmlDoc.DocumentNode.SelectNodes("//li");
                    if (bookNodes != null)
                    {
                        foreach (var bookNode in bookNodes)
                        {
                            string title = bookNode.SelectSingleNode(".//strong[text()='Title:']/following-sibling::text()")?.InnerText.Trim();
                            string author = bookNode.SelectSingleNode(".//strong[text()='Author:']/following-sibling::text()")?.InnerText.Trim();
                            string year = bookNode.SelectSingleNode(".//strong[text()='Year:']/following-sibling::text()")?.InnerText.Trim();

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
                Console.WriteLine("Error reading HTML file: " + ex.Message);
            }*/



            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    string currentTitle = null, currentAuthor = null, currentYear = null;

                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Trim(); // Trim leading and trailing whitespace

                        if (line.StartsWith("<strong>Title:</strong>"))
                        {
                            currentTitle = line.Substring("<strong>Title:</strong>".Length).Trim();
                        }
                        else if (line.StartsWith("<strong>Author:</strong>"))
                        {
                            currentAuthor = line.Substring("<strong>Author:</strong>".Length).Trim();
                        }
                        else if (line.StartsWith("<strong>Year:</strong>"))
                        {
                            currentYear = line.Substring("<strong>Year:</strong>".Length).Trim();

                            // Display book information when all three fields are found
                            if (!string.IsNullOrEmpty(currentTitle) && !string.IsNullOrEmpty(currentAuthor) && !string.IsNullOrEmpty(currentYear))
                            {
                                Console.WriteLine("Title: " + currentTitle);
                                Console.WriteLine("Author: " + currentAuthor);
                                Console.WriteLine("Year: " + currentYear);
                                Console.WriteLine();

                                // Reset the fields for the next book
                                currentTitle = null;
                                currentAuthor = null;
                                currentYear = null;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading HTML file: " + ex.Message);
            }
        }
    }
}
