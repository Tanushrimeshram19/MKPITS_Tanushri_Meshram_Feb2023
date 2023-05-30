using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertconncetion
{
    internal class DataConnection
    {
        private static string Stringconnect = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=average;";
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(Stringconnect);
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



        public static string InsertRecord(string username, string password)
        {
            SqlConnection con = GetConnection();

            string query = "insert into users values(@username,@password)";

            try
            {

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                command.ExecuteNonQuery();
                return "record inserted successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {

            }
        }
        public static string UpdateUsers(string username, string password)
        {
            SqlConnection con = GetConnection();

            string query = "update users set password=@password where username=@username";

            try
            {
                
                SqlCommand command = new SqlCommand(query, con);
                

                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@username", username);
                
                command.ExecuteNonQuery();
                return "record updated successfully";
            }
            catch (Exception ee)
            {
                return ee.ToString();
            }
            finally
            {
                con.Close();
            }
        }
            public static string deleteUsers(string username)
            {
                SqlConnection con = GetConnection();
                
                string query = "delete from users  where username=@username";
               
                try
                {
                    
                    SqlCommand command = new SqlCommand(query, con);
                


                    command.Parameters.AddWithValue("@username", username);
                    
                    command.ExecuteNonQuery();
                    return "record deleted successfully";
                }
                catch (Exception ee)
                {
                    return ee.ToString();
                }
                finally
                {
                    con.Close();
                }


            }

        }
    }


