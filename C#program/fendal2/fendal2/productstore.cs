using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fendal2
{ 
 public static class ProductStore
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




    public static DataSet Getproductprice(string Product_Name)
    {
        SqlConnection con = Getconnection();
        String query = "select price from product1";
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(
            query, con);
        da.SelectCommand.Parameters.AddWithValue("@Product_Name", Product_Name);
        da.Fill(ds, "price");
        return ds;
    }


    public static string SaveTableInvoiceDetails(string customer_name, string customer_contact, int product_category_id, int product_id, int residential_type_id, DateTime invoice_date
, decimal quantity, decimal price, decimal cgst, decimal sgst, decimal igst, decimal cgst_value, decimal sgst_value, decimal igst_value, decimal Total_Amount)
    {
        string result = null;
        string query = "insert into InvoiceDetail values(@customer_name,@customer_contact,@product_category_id,@product_id,@residential_type_id,@invoice_date,@quantity,@price,@cgst,@sgst,@igst,@cgst_value,@sgst_value,@igst_value,@Total_Amount)";
        SqlConnection con = Getconnection();
        SqlCommand command = new SqlCommand(query, con);
        command.Parameters.AddWithValue("@customer_name", customer_name);
        command.Parameters.AddWithValue("@customer_contact", customer_contact);
        command.Parameters.AddWithValue("@product_category_id", product_category_id);
        command.Parameters.AddWithValue("@product_id", product_id);
        command.Parameters.AddWithValue("@residential_type_id", residential_type_id);
        command.Parameters.AddWithValue("@invoice_date", invoice_date);
        command.Parameters.AddWithValue("@quantity", quantity);
        command.Parameters.AddWithValue("@price", price);
        command.Parameters.AddWithValue("@cgst", cgst);
        command.Parameters.AddWithValue("@sgst", sgst);
        command.Parameters.AddWithValue("@igst", igst);
        command.Parameters.AddWithValue("@cgst_value", cgst_value);
        command.Parameters.AddWithValue("@sgst_value", sgst_value);
        command.Parameters.AddWithValue("@igst_value", igst_value);
        command.Parameters.AddWithValue("@Total_Amount", Total_Amount);
        try
        {
            command.ExecuteNonQuery();
            result = "record saved successfullly";
        }
        catch (Exception ee)
        {
            result = ee.ToString();
        }
        finally
        {

            con.Close();
        }
        return result;
    }
}
}


