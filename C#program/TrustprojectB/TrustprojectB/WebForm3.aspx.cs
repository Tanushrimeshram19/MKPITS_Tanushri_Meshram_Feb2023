using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrustprojectB
{
    public partial class WebForm3 : System.Web.UI.Page
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
            cmd.Parameters.AddWithValue("@vendor_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox1.Text = ""; ;
            TextBox1.Focus();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update vendor_MAster set vendor_name=@vendor_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@vendor_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from  vendor_Master where vendor_Name=@vendor_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@vendor_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from vendor_Master where vendor_Name=@vendor_Name";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@vendor_Name", TextBox1.Text);
            da.Fill(ds, "vendor_Master");
            TextBox1.Text = ds.Tables["vendor_Master"].Rows[0].ItemArray[0].ToString();
        }
    }
}