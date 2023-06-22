﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Meshocart
{
    public partial class productdetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=ShopDb");
        SqlDataAdapter da;
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["ProductId"].ToString();
            // Response.Write(prodid);

            da = new SqlDataAdapter("select * from products where ProductId=@ProductId", con);

            da.SelectCommand.Parameters.AddWithValue("@ProductId", prodid);
            ds = new DataSet();
            da.Fill(ds, "productdetails");
            DataList1.DataSource = ds.Tables["productdetails"].DefaultView;
            DataList1.DataBind();
        }
    }
}