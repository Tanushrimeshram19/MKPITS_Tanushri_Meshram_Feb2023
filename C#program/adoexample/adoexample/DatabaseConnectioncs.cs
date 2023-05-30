using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace adoexample
{
    public static class DatabaseConnectioncs
    {
        private static string connection= "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=civika;";
        public static SqlConnection GetData()
        {
            SqlConnection con=new SqlConnection(connection);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }
        public static string InsertData(string username,string password) 
        {
            SqlConnection conn=GetData();
            string query = "insert into userdata values(@username,@password)";
            try
            {
                SqlCommand cmd =new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { conn.Close(); }
        }
    }
}
