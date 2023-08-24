using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFiles.Model
{
    internal class TextWriter
    {
        public static void WriteTxt(string title, string author, string year, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Title: " + title);
                    writer.WriteLine("Author: " + author);
                    writer.WriteLine("Year: " + year);
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to TXT file: " + ex.Message);
            }
        }
    }
}
