using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenialNet.DbConnection
{
    class DatabaseConfig
    {
        public static string GetConnectionString()
        {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Databases\\DataBaseGenial.mdf;Integrated Security=True;Connect Timeout=30";
        }
    }
}
