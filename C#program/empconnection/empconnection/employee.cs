using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empconnection
{
    
    
        //creating a static class
        public static class EmployeeDetails
        {
            //creating a static variable
            private static string connection = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=civika;";
            //creating a static method
            public static SqlConnection GetConnection()
            {
                //creating object of SqlConnection class
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
            //creating a static method to insert record into employee table
            public static string InsertEmployeedata(int employeeno, string name, string gender, string email, int mobileno, string city, DateTime dob)
            {
                SqlConnection conn = GetConnection();
                //creating a variable
                string query = "insert into emp values(@employeeno,@name,@gender,@email,@mobno,@city,@dob)";
                try
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@employeeno", employeeno);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@mobno", mobileno);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.ExecuteNonQuery();
                    return "record inserted";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                finally
                {
                    conn.Close();
                }
            }
            //creating a static method to update record into employeedata
            public static string UpdateEmployeedata(string email, string city)
            {
                SqlConnection conn = GetConnection();
                //creating a variable
                string query = "update  emp set Email=@email where City=@city";
                try
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@city", city);

                    command.ExecuteNonQuery();
                    return "record updated";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                finally { conn.Close(); }
            }
            //createing a static method to delete record from employeedata
            public static string DeleteEmployeedata(string city)
            {
                SqlConnection conn = GetConnection();
                //creating a variable
                string query = "delete emp where City=@city";
                try
                {
                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@city", city);

                    command.ExecuteNonQuery();
                    return "record deleted";
                }
                catch (Exception ex)
                {
                    return ex.ToString();
                }
                finally { conn.Close(); }
            }
            /*public static SqlDataReader GetCity()
            {
                SqlConnection conn= GetConnection();
                string query = "select*from cities";
                try
                {
                    SqlCommand cmd = new SqlCommand(query,conn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    return dr;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }*/
            public static DataSet GetCity()
            {
                SqlConnection conn = GetConnection();
                string query = "select * from city";
                try
                {
                    DataSet ds = new DataSet();
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    da.Fill(ds, "city");
                    return ds;
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            public static DataSet GetEmployee()
            {
                SqlConnection conn = GetConnection();
                DataSet ds = new DataSet();
                string query = "select * from emp";
                SqlDataAdapter ad = new SqlDataAdapter(query, conn);
                ad.Fill(ds, "emp");
                return ds;
            }
       public static DataSet SearchEmployee(int name)
        {
            SqlConnection conn = GetConnection();
            DataSet ds = new DataSet();
            string query = "select * from emp where name=@name";
            SqlDataAdapter ad = new SqlDataAdapter(query, conn);
            ad.SelectCommand.Parameters.AddWithValue("@name", name);
            ad.Fill(ds, "emp");
            return ds;
        }
    }
    }


