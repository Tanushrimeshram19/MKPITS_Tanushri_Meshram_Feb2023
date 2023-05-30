using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fendhal
{
   public static class projectstore
    {
        private static string stringconncetion = "server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=fendal;";
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(stringconncetion);
            try
            {
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet gettablecategory()

        {
            SqlConnection con = Getconnection();
            string query = "select * from ProductCategory;";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(ds, "product");
            return ds;


        }
        public static DataSet getproduct(string Product_type_name)
        {
            SqlConnection con = Getconnection();
            String query = "select p.Product_Id,p.Product_Name from Product1 p inner join ProductCategory t on p.ProductTypeId = t.Product_Category_Id where t.Product_Type_Name = @Product_Type_Name";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_type_name", Product_type_name);
            da.Fill(ds, "TableProduct1");
            return ds;
        }
        public static DataSet Getproductgst(string Product_Type_Name)
        {
            SqlConnection con = Getconnection();
            String query = "select a.cgst,a.sgst,a.igst from productgstdetails a inner join productcategory b on\r\na.product_gst_id = b.product_gst_id where b.Product_Type_Name = 'AC and Fridge'\r\n";
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(
                query, con);
            da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Type_Name);
            da.Fill(ds, "price");
            return ds;
        }

    }
}
