using ReadFiles.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string xmlPath = "C:\\Users\\Brave\\Desktop\\Aurionpro_training\\Assignments\\12\\ReadWrite\\ReadFiles\\XMLFile1.xml";
            string htmlPath = "C:\\Users\\Brave\\Desktop\\Aurionpro_training\\Assignments\\12\\ReadWrite\\ReadFiles\\HTMLFile1.html";
            string textPath = "C:\\Users\\Brave\\Desktop\\Aurionpro_training\\Assignments\\12\\ReadWrite\\ReadFiles\\TextFile1.txt";

            // Case Study 1: Reading from an XML File
            Console.WriteLine("Reading from XML File: \n");
            XMLReader.ReadXmlFile(xmlPath);
            Console.WriteLine();

            // Case Study 2: Reading from an HTML File
            Console.WriteLine("Reading from HTML File: \n");
            HTMLReader.ReadHtmlFile(htmlPath);
            Console.WriteLine();

            // Case Study 3: Reading from a Text File
            //TextReader.ReadTextFile(textPath);
            Console.WriteLine("Reading from Text File: \n");
            Model.TextReader.ReadTextFile(textPath);
        }
    }
}
