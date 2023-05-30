using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sample4
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            int res = 0;
            string op;
            if (TextBox3.Text == "+")
            {

                res = Convert.ToInt32(TextBox1.Text) + Convert.ToInt32(TextBox2.Text);
                Label1.Text = res.ToString();
            }

            else if (TextBox3.Text == "-")
            {


                res = Convert.ToInt32(TextBox1.Text) - Convert.ToInt32(TextBox2.Text);
                Label1.Text = res.ToString();
            }
            else if (TextBox3.Text == "*")
            {

                res = Convert.ToInt32(TextBox1.Text) * Convert.ToInt32(TextBox2.Text);
                Label1.Text = res.ToString();
            }
            else if (TextBox3.Text == "/")
            {
                res = Convert.ToInt32(TextBox1.Text) / Convert.ToInt32(TextBox2.Text);
                Label1.Text = res.ToString();
            }
            else
            {
                Label1.Text = "inavlid operator";
            }
        }
    }
}