using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppConfigUsingOOPS.Model
{
    internal interface IConnectionInfo
    {
        void Display();
        bool IsValid();
    }
}
