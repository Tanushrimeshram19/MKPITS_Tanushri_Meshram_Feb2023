using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace connectvitystudent
{
    public static  class Class1
    {
    private static class Databaseconnections
        {
            private static string connect = "LAPTOP-9HOA3TDR\\SQLEXPRESS ;integrated security = true;database=students;";
            public static SqlConnection Getdata()
            {
                SqlConnection conn = new SqlConnection(connect);
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
                    public static string InsertData(string fistname,string lastname,string course)
                    {
                        String query="insert into studentdata values(@firstname,@lastname,@course")
                        SqlConnection conn = Getdata();
                try
                {
                    sql
                }
                }
                }
                
            }
        }
    }
}
