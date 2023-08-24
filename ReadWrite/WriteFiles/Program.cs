using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WriteFiles.Model;

namespace WriteFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter book information:");

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Author: ");
            string author = Console.ReadLine();

            Console.Write("Year: ");
            string year = Console.ReadLine();

            string xmlFilePath = "C:\\Users\\Brave\\Desktop\\Aurionpro_training\\Assignments\\12\\ReadWrite\\WriteFiles\\XMLFile1.xml";
            string htmlFilePath = "C:\\Users\\Brave\\Desktop\\Aurionpro_training\\Assignments\\12\\ReadWrite\\WriteFiles\\HTMLFile1.xml";
            string txtFilePath = "C:\\Users\\Brave\\Desktop\\Aurionpro_training\\Assignments\\12\\ReadWrite\\WriteFiles\\TextFile1.xml";

            // Write user-provided book information to XML, HTML, and TXT files
            XMLWriter.WriteXml(title, author, year, xmlFilePath);
            HTMLWriter.WriteHtml(title, author, year, htmlFilePath);
            TextWriter.WriteTxt(title, author, year, txtFilePath);

            Console.WriteLine("Data written to XML, HTML, and TXT files.");
        
    }
    }
}
