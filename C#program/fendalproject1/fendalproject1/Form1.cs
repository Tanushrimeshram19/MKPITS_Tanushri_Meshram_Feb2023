using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fendalproject1
{
    public static class ProductStore1
    {
        private static string connectionString = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=fendal;";
        //method to creeate connection
        public static SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                // con.Open();
                return con;
            }
            catch (Exception ee)
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
            SqlConnection con = GetConnection();
            string query = "select   product_type_name from ProductCategory";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "ProductCategory");
            return ds;

        }

        //method to return product name for given product type name
        public static DataSet Gettableproductname(string product_type_name)
        {
            SqlConnection con = GetConnection();
            string query = "select p.product_name from Product1 p inner join ProductCategory t on p.ProductTypeId = t.Product_Category_ID   where t.Product_Type_Name = @product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            da.Fill(ds, "Product1");
            return ds;
        }
        public static DataSet GetGstDetails(string product_type_name)
        {
            SqlConnection con = GetConnection();

            string query = " select a.cgst,a.sgst,a.igst from tableproductgstdetails a inner join tableproductcategory b ona.product_gst_id = b.product_gst_id where b.Product_Type_Name = @product_type_name";
            DataSet dataSet = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@product_type_name", product_type_name);
            //da.Fill(ds, "tableproductgstdetails");
            return ds;
        }
        }
    }
