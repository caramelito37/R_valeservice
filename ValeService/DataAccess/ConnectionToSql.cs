using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DataAccess
{
    public abstract class ConnectionToMySql
    {
        private readonly string connectionString;
        public ConnectionToMySql()
        {
            connectionString = "Server=localhost; Database=db_valeservice; User=root; port=3306; password=admin;";
        }
        protected MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
