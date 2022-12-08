using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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
        public bool IsExistWithOutParameter(string cmdtext)
        {
            bool check = false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            using (connection)
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                using (command)
                {
                    command.CommandText = cmdtext;
                    SqlDataReader dataReader1 = command.ExecuteReader();
                    using (dataReader1)
                    {
                        while (dataReader1.Read())
                        {
                            check = true;
                            break;
                        }
                    }
                }
            }
            return check;
        }
        public bool IsExistWithParameter(string cmdtext, params IDataParameter[] sqlParams)
        {
            bool check = false;
            SqlConnection connection = new SqlConnection(ConnectionString);
            using (connection)
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                using (command)
                {
                    command.CommandText = cmdtext;
                    if (sqlParams != null)
                    {
                        foreach (IDataParameter para in sqlParams)
                        {
                            command.Parameters.Add(para);
                        }
                    }
                    SqlDataReader dataReader1 = command.ExecuteReader();
                    using (dataReader1)
                    {
                        while (dataReader1.Read())
                        {
                            check = true;
                            break;
                        }
                    }
                }
            }
            return check;
        }
        public DataSet GetDataSetWithParameter(string cmdtext, params IDataParameter[] sqlParams)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                SqlCommand cmd = new SqlCommand(cmdtext, con);
                if (sqlParams != null)
                {
                    foreach (IDataParameter para in sqlParams)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                da.Dispose();
                cmd.Parameters.Clear();
                return ds;
            }
            catch
            {
                throw;
            }
        }
    }
}
