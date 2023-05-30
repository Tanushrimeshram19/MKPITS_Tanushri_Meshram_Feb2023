using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace update
{
    public static class DatabaseConnection
    {

        private static string connectionString = "server=.LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=civika;";

        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                return con;
            }
            catch
            {
                return null;
            }

        }

        public static string InsertRecord(string username, string password)
        {
            SqlConnection con = GetConnection();

            string query = "insert into civica values(@username,@password)";

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
                public static string DeleteUsers(string username)
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
    

    







