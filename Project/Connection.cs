using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Connection
    {
        public static MySqlConnection conn = new MySqlConnection("server=localhost;database=project_db;Uid=root;password=;");        
    }
}
