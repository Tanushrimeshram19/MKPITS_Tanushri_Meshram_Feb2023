using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPVal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("name" + TextBox1.Text + "<br>");
            sb.Append("password" + TextBox2.Text + "<br>");
            sb.Append("age" + TextBox3.Text + "<br>");
            sb.Append("emailid" + TextBox4.Text + "<br>");
            Label1.Text = sb.ToString();
        }
    }
}