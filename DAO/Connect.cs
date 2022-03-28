using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectDotNet.DAO
{
    public class Connect
    {
        public static MySqlConnection configConnect(String host, int port, String database, String username, String password)
        {
            String connString = "Server=" + host + ";Database=" + database + ";User=" + username

               + ";Port=" + port + ";Password=" + password + ";SSL Mode = None";

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
        public static MySqlConnection getConnection()
        {
            String host = "localhost";
            int port = 3306;
            String database = "laptopsellingwebsite";
            String username = "root";
            String password = "";
            return configConnect(host, port, database, username, password);
        }
    }
}