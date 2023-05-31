using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace aspresigster
{
    public partial class webform : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("name " + TextBox1.Text + "<br>");
            sb.Append("password " + TextBox2.Text + "<br>");
            sb.Append("address " + TextBox3.Text + "<br>");
            sb.Append("mobile no " + TextBox4.Text + "<br>");
            sb.Append("date of birth " + TextBox5.Text + "<br>");
            if (Male.Checked)

                sb.Append("gender " + Male.Text + "<br>");
            else if (Female.Checked)
                sb.Append("gender " + Female.Text + "<br>");
          
                sb.Append("hobby " + Singing.Text + "<br>");
            
                sb.Append("hobby " + Dancing.Text + "<br>");
            sb.Append("city " + DropDownList1.Text + "<br>");

            Label1.Text = sb.ToString();
        }
    }
}