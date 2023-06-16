
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Trustclasslibrary
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = storedlibrary.class2.insertDepartment_Mast(TextBox2.Text);
            Label1.Text = res;
            // getDepartment_Id();
            TextBox2.Text = "";
        }
        public void getdepartementid()
        {
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            }
        }
    }
    
