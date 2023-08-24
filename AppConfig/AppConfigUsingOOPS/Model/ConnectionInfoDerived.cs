using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigUsingOOPS.Model
{
    internal class ConnectionInfoDerived : ConnectionInfoBase
    {
        public ConnectionInfoDerived(string key) : base(key) { }

        public override void Display()
        {
            if (IsValid())
            {
                Console.WriteLine($"\n\tServer: {Server}\n\tDatabase: {Database}\n");
            }
            else
            {
                Console.WriteLine("\tInvalid or missing connection information.\n");
            }
        }
    }
}
