﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sessionandapplication
{
    public partial class register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int uc = (int)Session["usercount"];
            uc = uc + 1;
            Session["usercount"] = uc;
            Response.Write("user session count " + uc);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int uc = (int)Session["usercount"];
            Session["username"] = TextBox1.Text;
            Session["email"] = TextBox2.Text;
            Label1.Text = "value stored in session variable";
        }
    }
}