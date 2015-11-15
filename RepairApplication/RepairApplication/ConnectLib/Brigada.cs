using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToBase
{
    public class Brigada
    {
        public static SqlDataAdapter da = null;
        public static DataTable table;
        public static DataTable GetBrigads(int NOdepo)
        {
            table = new DataTable("Brigada");
            using (SqlConnection conn = Connect.GetSqlConnection())
            {

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetBrigadaById";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("NOdepo", System.Data.SqlDbType.Int));
                    cmd.Parameters["NOdepo"].Value = NOdepo;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }
            return table;
        }
 
        public static DataTable GetArchive()

        {
            table = new DataTable("Vacancy");
            using (SqlConnection conn = Connect.GetSqlConnection())
            {

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetArchive";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }
            return table;
        }
        public static DataTable GetMoneyByRepair()
        {
            table = new DataTable("Money");
            using (SqlConnection conn = Connect.GetSqlConnection())
            {

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetMoneyByRepair";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }
            return table;
        }

        public static DataTable GetRepair()
        {
            table = new DataTable("Repair");
            using (SqlConnection conn = Connect.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetRepair";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }

            return table;
        }

    }
}
