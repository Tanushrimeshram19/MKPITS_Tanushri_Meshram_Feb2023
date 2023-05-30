using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace fendalproject1

    {
        //create static class
        public static class ProductStore
        {

            //create static variable
            private static string connection = "server=INBOOK_X1\\TEW_SQLEXPRESS;integrated security=true;database=Fendhal;";
            //create static method
            public static SqlConnection GetSqlConnection()
            {
                SqlConnection con = new SqlConnection(connection);
                try
                {
                    //con.Open();
                    return con;
                }
                catch
                {
                    return null;
                }
                finally
                {
                    //con.Close();
                }
            }
            public static DataSet Gettableproductcategory()
            {
                SqlConnection conn = GetSqlConnection();
                string query = "select Product_type_Name from TableProductCategory";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "Product_type_Name");
                return ds;
            }
            public static DataSet Gettableproductname(string product_type_name)
            {
                SqlConnection con = GetSqlConnection();
                string query = "select p.product_Name from TableProduct p inner join TableProductCategory t on p.ProductTypeID = t.Product_Category_ID   where t.Product_Type_Name = @product_type_name";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
                da.Fill(ds, "tableproduct");
                return ds;

            }
            //method to return gstdetails for given product name
            public static DataSet GetGstDetails(string product_type_name)
            {
                SqlConnection con = GetSqlConnection();
                string query = "select a.cgst,a.sgst,a.igst from TableProductGstDetails a inner join tableproductcategory b on a.Product_Gst_Id=b.Product_Gst_id where b.Product_type_Name=@product_type_name";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
                da.Fill(ds, "tableproductcategorry");
                return ds;
            }
            public static DataSet GetProductPrice(string Product_Name)
            {
                SqlConnection con = GetSqlConnection();
                string query = "select price from tableproduct where Product_Name=@Product_Name";
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@product_name", Product_Name);
                da.Fill(ds, "tableproduct");
                return ds;

            }
        }
    }







