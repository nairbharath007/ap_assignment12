using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace AppConfigUsingOOPS.Model
{
    internal abstract class ConnectionInfoBase : IConnectionInfo
    {
        public string Server { get; private set; }
        public string Database { get; private set; }

        public ConnectionInfoBase(string key)
        {
            LoadConnectionInfo(key);
        }

        public void LoadConnectionInfo(string key)
        {
            string connectionString = ConfigurationManager.AppSettings[key];

            if (!string.IsNullOrWhiteSpace(connectionString))
            {
                foreach (var keyValue in connectionString.Split(';'))
                {
                    var parts = keyValue.Split('=');
                    if (parts.Length == 2)
                    {
                        var name = parts[0].Trim().ToLower();
                        var value = parts[1].Trim();

                        if (name == "server") Server = value;
                        else if (name == "database") Database = value;
                    }
                }
            }
        }

        public bool IsValid()
        {
            return !string.IsNullOrWhiteSpace(Server) && !string.IsNullOrWhiteSpace(Database);
        }

        public abstract void Display();
    }
}
