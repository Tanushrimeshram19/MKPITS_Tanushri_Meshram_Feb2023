using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace employeeconnection
{
    internal class emp
    {
        private static string connectionString = "server=.LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=civica";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch (SqlException ee)
            {
                return null;
            }
        }
            public static SqlDataReader GetCity()
            {
                SqlConnection con = GetConnection();
                string query = "select * from city";
                try
                {
                    SqlCommand command = new SqlCommand(query, con);
                    
                    SqlDataReader dr = command.ExecuteReader();
                    return dr;
                }
                catch
                {
                    return null;
                }

            }


        }

    }

