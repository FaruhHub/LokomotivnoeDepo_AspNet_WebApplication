using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToBase
{
    public class Connect
    {
        public static string ConnectionString
        {
            get
            {
                string connStr = ConfigurationManager.ConnectionStrings["RepairConnectionString"].ToString();
                SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder(connStr);
                return sqlConnectionStringBuilder.ToString();
            }
        }

        /// <summary>
        /// Returns open connection 
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
