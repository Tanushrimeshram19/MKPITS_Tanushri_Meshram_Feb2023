using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trustclasslibrary
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=Trust");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            str = "select*from Trust";
            da = new SqlDataAdapter(str, con);
            da.Fill(ds, "Trust");
            GridView1.DataSource = ds.Tables["Trust"].DefaultView;
            GridView1.DataBind();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            str = "insert into vendor_MAster values(@vendor_Name)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@vendor_Name", TextBox2.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox2.Text = ""; ;
            TextBox2.Focus();
        }
    }
}