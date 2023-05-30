using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

public static class emp

{

    private static string connectionString = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=civika";

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
    public static string InsertRecord(string name, string gender, string gmail, int mobno, string city, DateTime dateofbirth)
    {
        SqlConnection con = GetConnection();

        string query = "insert into emp values(@name,@gender,@gmail,@mobno,@city,@dateofbirth)";

        try
        {

            SqlCommand command = new SqlCommand(query, con);


            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@gender", gender);
            command.Parameters.AddWithValue("@gmail", gmail);
            command.Parameters.AddWithValue("@mobno", mobno);
            command.Parameters.AddWithValue("@city", city);
            command.Parameters.AddWithValue("@dateofbirth", dateofbirth);


            command.ExecuteNonQuery();
            return "record inserted successfully";
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
    



  

       


    
         


        

