using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToBase
{
   public class Depo
    {
        public static SqlDataAdapter da = null;
        public static DataTable table;
        public static DataTable GetDepo()
        {
            table = new DataTable("Depo");
            using (SqlConnection conn = Connect.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetDepo";
                    cmd.CommandType = CommandType.StoredProcedure;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }

            return table;
        }


        public static DataTable GetRepairByName(string TypeRepair)
        {
            table = new DataTable("Repairs");
            using (SqlConnection conn = Connect.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetRepairByName";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("TypeRepair", System.Data.SqlDbType.Char, 40));
                    cmd.Parameters["TypeRepair"].Value = TypeRepair;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }
            return table;
        }

        public static void AddRepair(string TypeRepair, double Money, bool Bonus, int BonusPercent, DateTime DateStart, 
            DateTime DateStop, string Reason, int IDbrigadi, int RegNumber)
        {
            using (SqlConnection conn = Connect.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"InsertRepair";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    SqlParameter p1 = new SqlParameter("TypeRepair", System.Data.SqlDbType.Char, 40);
                    p1.Value = TypeRepair;
                    cmd.Parameters.Add(p1);
                    SqlParameter p2 = new SqlParameter("Money", System.Data.SqlDbType.Money);
                    p2.Value = Money;
                    cmd.Parameters.Add(p2);
                    SqlParameter p3 = new SqlParameter("Bonus", System.Data.SqlDbType.Bit);
                    p3.Value = Bonus;
                    cmd.Parameters.Add(p3);
                    SqlParameter p4 = new SqlParameter("BonusPercent", System.Data.SqlDbType.Int);
                    p4.Value = BonusPercent;
                    cmd.Parameters.Add(p4);
                    SqlParameter p5 = new SqlParameter("DateStart", System.Data.SqlDbType.DateTime);
                    p5.Value = DateStart;
                    cmd.Parameters.Add(p5);
                    SqlParameter p6 = new SqlParameter("DateStop", System.Data.SqlDbType.DateTime);
                    p6.Value = DateStop;
                    cmd.Parameters.Add(p6);
                    SqlParameter p7 = new SqlParameter("Reason", System.Data.SqlDbType.Char, 40);
                    p7.Value = Reason;
                    cmd.Parameters.Add(p7);
                    SqlParameter p8 = new SqlParameter("IDbrigadi", System.Data.SqlDbType.Int);
                    p8.Value = IDbrigadi;
                    cmd.Parameters.Add(p8);
                    SqlParameter p9 = new SqlParameter("RegNumber", System.Data.SqlDbType.Int);
                    p9.Value = RegNumber;
                    cmd.Parameters.Add(p9);
                    cmd.ExecuteNonQuery();

                }
            }
        }

        public static void DeleteRepair(int TypeRepair)
        {
            using (SqlConnection conn = Connect.GetSqlConnection())
            {
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"DeleteFromRepair";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    SqlParameter p1 = new SqlParameter("TypeRepair", System.Data.SqlDbType.Char, 40);
                    p1.Value = TypeRepair;
                    cmd.Parameters.Add(p1);
                    cmd.ExecuteNonQuery();

                }
            }
        }
       

        public static DataTable GetLokomotiv(int NOdepo)
        {
            table = new DataTable("Lokomotiv");
            using (SqlConnection conn = Connect.GetSqlConnection())
            {

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"GetLokomotiv";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("NOdepo", System.Data.SqlDbType.Int));
                    cmd.Parameters["NOdepo"].Value = NOdepo;
                    da = new SqlDataAdapter(cmd);
                    da.Fill(table);
                }
            }
            return table;
        }
        
    }
}
