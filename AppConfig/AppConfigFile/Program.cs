using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;

namespace AppConfigFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading an application setting
            string appSettingValue = ConfigurationManager.AppSettings["AppSettingKey"];
            Console.WriteLine($"Application Setting: {appSettingValue}");

            // Reading a connection string
            string connectionString = ConfigurationManager.ConnectionStrings["MyDbConnection"].ConnectionString;
            Console.WriteLine($"Connection String: {connectionString}");

            Console.ReadLine();
        }
    }
}
