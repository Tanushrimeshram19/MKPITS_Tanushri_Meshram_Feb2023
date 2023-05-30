using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    namespace fendalproject2
    {
        public static class courseregistration
        {
            private static string connection = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=institute;";
            public static SqlConnection GetSqlConnection()
            {
                SqlConnection conn = new SqlConnection(connection);
                try
                {
                    conn.Open();
                    return conn;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            public static DataSet getnation()
            {
                string query = "select * from TableNation";
                SqlConnection conn = GetSqlConnection();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "TableNation");
                return ds;
            }
            public static DataSet getState(string NationName)
            {
                string query = "select s.stateid,s.statename from tablestates s inner join tablenation n on s.nationid=n.nationid where nationname=@nationname";
                SqlConnection conn = GetSqlConnection();
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@nationname", NationName);
                da.Fill(ds, "TableState");
                return ds;
            }
            public static DataSet GetCity(string stateName)
            {
                SqlConnection conn = GetSqlConnection();
                string query = "select c.cityid,c.cityname from TableCitys c inner join TableStates s on c.stateid=s.stateid where Statename=@statename";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@statename", stateName);
                da.Fill(ds, "TableCity");
                return ds;
            }
        }
    }
}
