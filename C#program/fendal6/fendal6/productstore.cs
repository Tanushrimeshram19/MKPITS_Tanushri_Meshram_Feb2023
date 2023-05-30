using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fendal6
{
    public static class productstore
    {
        private static string connection = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=fendal;";
        public static SqlConnection GetSqlConnection()
        {
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
        public static DataSet Getproductcategory()
        {
            SqlConnection con = GetSqlConnection();
            string query = "select * from productcategory";
            DataSet ds = new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.Fill(ds, "tableproductcategory");
            return ds;
        }
        public static DataSet Getproductname(string product_type_Name)
        {
            SqlConnection con = GetSqlConnection();

            String query = "select p.Product_Id,p.Product_Name from Product1 p inner join ProductCategory t on p.ProductTypeId = t.Product_Category_Id where t.Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.SelectCommand.Parameters.AddWithValue("@Product_type_Name", product_type_Name);
            dr.Fill(ds, "Product1");
            return ds;
        }
        public static DataSet Getgstdetails(string product_type_name)
        {
            SqlConnection con = GetSqlConnection();
            string query = " select a.cgst,a.sgst,a.igst from productgstdetails a inner join productcategory b on a.product_gst_id = b.product_gst_id where b.Product_Type_Name = @product_type_name";
            //string query = "select p.cgst,p.sgst,p.igst from productgstdetail p inner join productcategory c on p.product_gst_id=c.product_gst_id where c.product_type_name=@product_type_name";
            DataSet ds = new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.SelectCommand.Parameters.AddWithValue("@product_type_name", @product_type_name);
            dr.Fill(ds, "productgstdetail");
            return ds;
        }
        public static DataSet Getproductprice(string product_name)
        {
            SqlConnection con = GetSqlConnection();
            string query = "select price from product1 where product_name=@product_name";
            DataSet ds = new DataSet();
            SqlDataAdapter dr = new SqlDataAdapter(query, con);
            dr.SelectCommand.Parameters.AddWithValue("@product_name", product_name);
            dr.Fill(ds, "product1");
            return ds;
        }
        public static string Saveinvoicedetails(string customer_name, long customer_contact, int product_category_id, int product_id, int residential_type_id, DateTime invoice_date, int price, int quantity, decimal cgst, decimal sgst, decimal igst, decimal cgst_value, decimal sgst_value, decimal igst_value, decimal total_amount)
        {
            string result = null;
            SqlConnection con = GetSqlConnection();
            string query = "insert into  invoicedetail values(@customer_name,@customer_contact,@product_id,@product_category_id,@residential_type_id,@invoice_date,@price,@quantity,@cgst,@sgst,@igst,@cgst_value,@sgst_value,@igst_value,@total_amount)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@customer_name", customer_name);
            cmd.Parameters.AddWithValue("@customer_contact", customer_contact);
            cmd.Parameters.AddWithValue("@product_id", product_id);
            cmd.Parameters.AddWithValue("@product_category_id", product_category_id);
            cmd.Parameters.AddWithValue("@residential_type_id", residential_type_id);
            cmd.Parameters.AddWithValue("@invoice_date", invoice_date);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@cgst", cgst);
            cmd.Parameters.AddWithValue("@sgst", sgst);
            cmd.Parameters.AddWithValue("@igst", igst);
            cmd.Parameters.AddWithValue("@cgst_value", cgst_value);
            cmd.Parameters.AddWithValue("@sgst_value", sgst_value);
            cmd.Parameters.AddWithValue("@igst_value", igst_value);
            cmd.Parameters.AddWithValue("@total_amount", total_amount);
            result = "record saved";
            try
            {
                cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            finally { con.Close(); }
        }
    }
}
