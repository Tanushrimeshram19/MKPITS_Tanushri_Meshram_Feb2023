using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursereg
{
    public static class Courseregistration
    {
        private static string connectionstring = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=sample;";
        public static SqlConnection GetConnection()
        {
            SqlConnection conn=new SqlConnection(connectionstring);
            try
            {
                return conn;
            }
            finally
            {
                conn.Close();
            }
        }
        public static DataSet GetTableCountry()
        {
            
            SqlConnection conn = GetConnection();
            string query = "select country from sheet1$";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query,conn);
            da.Fill(ds, "sheet1$");
            return ds;
        }
       
    }
}
