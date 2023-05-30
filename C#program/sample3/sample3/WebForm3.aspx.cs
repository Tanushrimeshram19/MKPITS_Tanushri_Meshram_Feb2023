﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sub1, sub2, sub3, total = 0, per;
            string grade;
            sub1 = Convert.ToInt32(TextBox1.Text);
            sub2 = Convert.ToInt32(TextBox2.Text);
            sub3 = Convert.ToInt32(TextBox3.Text);
            total = sub1 + sub2 + sub3;
            per = (total / 3) * 100;
            if (per >= 0)
            {
                Label3.Text = "A Grade";
            }
            else if (per >= 80)
            {
                Label3.Text = "B Grade";
            }
            else if (per >= 40)
            {
                Label3.Text = "Pass";

            }
            else
            {
                Label3.Text = "Fail";
            }
            Label1.Text = total.ToString();
            Label2.Text = total.ToString();
        }
    }
}