using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace storedlibrary
{
    public static class Class2
        {
            //Connection
            static SqlConnection con = DBConnection.getConnection();
            static string query = null;
            static SqlCommand cmd = null;

            //Method To Insert Record Into Department_Mast
            public static string insertDepartment_Mast(string Department_Name)
            {
                string res = null;
                try
                {
                    query = "insert into Department_Mast values(@Department_Name)";
                    cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("Department_Name", Department_Name);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    //con.Close();
                    res = "Record Saved In Depertment Master Successfully";
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();
                }
                return res;
            }
            //Method To Return Department Id
            public static string getDepartment_Id()
            {
                string res = null;
                try
                {
                    query = "select max(Department_Id)from Department_Mast";
                    cmd = new SqlCommand(query, con);
                    con.Open();
                    int did = Convert.ToInt32(cmd.ExecuteScalar());
                    res = did.ToString();
                }
                catch (Exception ex)
                {
                    res = ex.ToString();
                }
                finally
                {
                    con.Close();
                }
                return res;


            }
        }
    }









