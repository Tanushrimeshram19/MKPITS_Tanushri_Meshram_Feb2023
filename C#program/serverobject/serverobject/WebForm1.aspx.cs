using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace serverobject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("hello from webform1");
            Server.Execute("webform2.aspx");
            Response.Write("Welcome back to webform1 page");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("hello from webform1 transfer page");
            Server.Transfer("webform2.aspx");
            Response.Write("Welcome back to webform1 transfer page");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write(Server.HtmlEncode("<H1> is an example of a heading tag</H1>"));
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Write(Server.UrlEncode("http://localhost/code/map.aspx"));
            Response.Write("http://localhost/code/map.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            string name = Server.UrlEncode("John Saounder");
            Response.Redirect("webform3.aspx?name+name");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string name = Server.UrlEncode("tanu meshram");
            Response.Redirect("webform3.aspx?name=" + name);
        }
    }
}