using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your username: ");
            string username = Console.ReadLine();

            // Define the file path
            string filePath = "usernames.txt";

            // Append the username to the file
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(username);
                }

                Console.WriteLine("Username saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving username: " + ex.Message);
            }
        }
    }
}
