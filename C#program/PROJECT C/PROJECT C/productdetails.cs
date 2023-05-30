using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT_C
{
    public static class productdetails

        {
            private static string connection = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=product;";
            public static SqlConnection GetSqlConnection()
            {
                SqlConnection conn = new SqlConnection(connection);
      
                    conn.Open();
                    return conn;
              
            }
            public static DataSet Getproductcategory()
            {
                SqlConnection con = GetSqlConnection();
                string query = "select product_category_id,product_type_name from tableproductcategory";
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.Fill(ds, "product_type_name");
                return ds;
            }
            public static DataSet Getproductname(string product_type_Name)
            {
                SqlConnection con = GetSqlConnection();

                String query = "select p.Product_Id,p.Product_Name from tableProduct p inner join tableProductCategory c on p.ProductTypeId = c.Product_Category_Id where t.Product_Type_Name = @Product_Type_Name";
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue("@Product_type_Name", product_type_Name);
                dr.Fill(ds, "Product1");
                return ds;
            }
        
            }
        }
    



        
