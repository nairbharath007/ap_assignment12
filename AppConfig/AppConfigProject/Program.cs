using System;
using System.Collections.Generic;
using System.Configuration;  //access to config settings in App.config file
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayConnectionInfo("connection1");
            DisplayConnectionInfo("connection2");

            Console.ReadLine();
        }

        static void DisplayConnectionInfo(string key)
        {
            string connectionString = ConfigurationManager.AppSettings[key];
            if (!string.IsNullOrEmpty(connectionString))
            {
                string server = null, database = null;

                var keyValuePairs = connectionString.Split(';');
                foreach (var keyValue in keyValuePairs)
                {
                    var parts = keyValue.Split('=');
                    if (parts.Length == 2)
                    {
                        var name = parts[0].Trim().ToLower();
                        var value = parts[1].Trim();

                        if (name == "server")
                            server = value;
                        else if (name == "database")
                            database = value;
                    }
                }
                if (!string.IsNullOrEmpty(server) && !string.IsNullOrEmpty(database))
                {
                    Console.WriteLine($"  Server: {server}");
                    Console.WriteLine($"  Database: {database}");
                    Console.WriteLine();
                }
            }
        }
    }

}
