using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFiles.Model
{
    internal class HTMLWriter
    {
        public static void WriteHtml(string title, string author, string year, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("<li>");
                    writer.WriteLine($"<strong>Title:</strong> {title}");
                    writer.WriteLine("<br>");
                    writer.WriteLine($"<strong>Author:</strong> {author}");
                    writer.WriteLine("<br>");
                    writer.WriteLine($"<strong>Year:</strong> {year}");
                    writer.WriteLine("</li>");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to HTML file: " + ex.Message);
            }
        }
    }
}
