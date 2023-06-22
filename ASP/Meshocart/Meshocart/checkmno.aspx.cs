using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Meshocart
{
    public partial class checkmno : System.Web.UI.Page
    {
        string prodid;
        SqlConnection con = new SqlConnection("server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=shopdb");
        SqlCommand command;
        string query;
        protected void Page_Load(object sender, EventArgs e)
        {
            prodid = Convert.ToString(Session["ProductId"]);
            Response.Write("ProductId " + prodid);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = TextBox1.Text;
            string prodname = null;
            int prodprice = 0;
            int qty = 0;
            string sessionid = null;
            if (res == "123456")
            {
                query = "select * from products where ProductId=@ProductId";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@ProductId", prodid);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    prodname = dr["ProductName"].ToString();
                    prodprice = Convert.ToInt32(dr["ProductPrice"].ToString());

                    qty = 1;
                    sessionid = Session.SessionID;

                }
                con.Close();
                Response.Write("ProductName " + prodname + "<br>");
                Response.Write("ProductPrice " + prodprice + "<br>");
                Response.Write("qty " + qty + "<br>");
                Response.Write("session id " + sessionid + "<br>");
                //save the product data into carttable

                // Response.Redirect("cart1.aspx");
            }
            else
            {
                Label1.Text = "invalid otp";
            }
        }
    }
}