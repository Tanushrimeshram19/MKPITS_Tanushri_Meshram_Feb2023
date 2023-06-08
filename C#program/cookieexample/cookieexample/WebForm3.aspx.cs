using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace cookieexample
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie12 = Request.Cookies["cookie1"];
            if (cookie12 != null)
            {
                string uname = cookie12.Values["username"].ToString();
                string email = cookie12.Values["email"].ToString();
                Label1.Text = "username:" + uname;
                Label2.Text = "email:" + email;
            }
            else
            {
                Label1.Text = "no permanent cookie exist";
            }
        }
    }
}