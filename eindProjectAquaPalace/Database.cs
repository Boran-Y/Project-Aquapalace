using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace eindProjectAquaPalace
{
     class Database
    {
        public static MySqlConnection start()
        {
            string dbServername = "127.0.0.1";
            string dbUsername = "root";
            string dbPassword = "";
            string dbName = "Aquapalace";

            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = dbServername;
            builder.UserID = dbUsername;
            builder.Password = dbPassword;
            builder.Database = dbName;

            MySqlConnection conn = new MySqlConnection(builder.ToString());
            return conn;
        }
    }
}
