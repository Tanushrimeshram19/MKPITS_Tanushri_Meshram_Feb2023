using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
us; ing system.Data

namespace PROJECT_C
{
 
        public static class ProductDetails
        {
            private static string conncetion = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=institute1;";
            public static SqlConnection GetConnection()
            {
                SqlConnection con = new SqlConnection(conncetion);
                con.Open();
                return con;
            }
            public static DataSet GetProductCategory()
            {
                SqlConnection con = GetConnection();
                string query = "select product_category_id,product_type_name from tableproductcategory";
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.Fill(ds, "product_type_name");
                return ds;
            }
            public static DataSet GetProductName(string product_type_name)
            {
                SqlConnection con = GetConnection();
                string query = "select p.product_id,p.product_name from tableproduct p inner join tableproductcategory c on p.producttypeid=c.product_category_id where c.product_type_name=@product_type_name";
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
                dr.Fill(ds, "tableproduct");
                return ds;
            }
            public static DataSet GetAvailableQuantity(string product_name)
            {
                SqlConnection con = GetConnection();
                string query = "select Available_Quantity from tableproduct where product_name=@product_name";
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue("@product_name", product_name);
                dr.Fill(ds, "tableproduct");
                return ds;
            }
            public static DataSet GetTotalQuantity(string product_name)
            {
                SqlConnection con = GetConnection();
                string query = "select Total_Quantity from tableproduct where product_name=@product_name";
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue("@product_name", product_name);
                dr.Fill(ds, "tableproduct");
                return ds;
            }
            public static DataSet GetPrice(string product_name)
            {
                SqlConnection con = GetConnection();
                string query = "select price from tableproduct where product_name=@product_name";
                DataSet ds = new DataSet();
                SqlDataAdapter dr = new SqlDataAdapter(query, con);
                dr.SelectCommand.Parameters.AddWithValue("@product_name", product_name);
                dr.Fill(ds, "tableproduct");
                return ds;
            }
        }
    }

}
        
    



        
