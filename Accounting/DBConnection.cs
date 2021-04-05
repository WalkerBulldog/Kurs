using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting
{
    public class DBConnection : IDisposable
    {
        private static readonly DBConnection instance = new DBConnection();
        private readonly MySqlCommand command;
        private DBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "enterprice";
            string username = "root";
            string password = "2094ALex";
            string connString = "Server=" + host + ";Database=" + database
               + ";port=" + port + ";User Id=" + username + ";password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();
            command = new MySqlCommand { Connection = conn };
        }
        public static DBConnection Instance { get => instance; }
        public MySqlCommand Command { get => command; }
        public void Dispose()
        {
            command.Connection.Close();
        }
    }
}
