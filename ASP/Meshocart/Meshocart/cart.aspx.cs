using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Meshocart
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string prodid = Request.QueryString["ProductId"].ToString();
            Session["ProductId"] = prodid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("checkmno.aspx");
        }
    }
}