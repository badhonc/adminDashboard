using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class DbConnection
    {
        private static string ConnectionString = ConfigurationManager.AppSettings["ConnectionString1"];

        public static SqlConnection GetConnection()
        {
            var con = new SqlConnection(ConnectionString);
            con.Open();
            return con;
        }
    }
}
