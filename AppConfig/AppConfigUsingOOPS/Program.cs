using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using AppConfigUsingOOPS.Model;

namespace AppConfigUsingOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IConnectionInfo connection1 = new ConnectionInfoDerived("connection1");
            IConnectionInfo connection2 = new ConnectionInfoDerived("connection2");

            connection1.Display();
            connection2.Display();

            Console.ReadLine();
        }
    }
}
