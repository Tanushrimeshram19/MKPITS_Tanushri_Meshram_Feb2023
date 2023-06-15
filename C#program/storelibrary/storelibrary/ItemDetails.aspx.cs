using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace storelibrary
{
    public partial class ItemDetails : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=Trust");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {
         
                str = "select*from Trust";
                da = new SqlDataAdapter(str, con);
                da.Fill(ds, "Trust");
                GridView1.DataSource = ds.Tables["Item_Master"].DefaultView;
                GridView1.DataBind();
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string res = Vendorclass.insertVendor_Mast(TextBox1.Text);

            Label1.Text = res;
            getvendorid();
            TextBox1.Text = "";
        }
        public void getvendorid()
        {
            int res = Convert.ToInt32(VendorClass.getVendor_id());
            res = res + 1;
            TextBox2.Text = res.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string res = VendorClass.updateVendor_Mast(TextBox1.Text, Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string res = VendorClass.deleteVendor_Mast(Convert.ToInt32(TextBox2.Text));
            Label1.Text = res;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = VendorClass.searcVendor_Mast(Convert.ToInt32(TextBox2.Text));
            if (ds.Tables[0].Rows.Count != 0)
            {
                TextBox1.Text = ds.Tables["vendor_mast"].Rows[0].ItemArray[1].ToString();
            }
            else
            {
                Label1.Text = "no record exist";
            }
    }
}