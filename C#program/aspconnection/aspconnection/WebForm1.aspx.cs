using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace aspconnection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con=new SqlConnection("server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=students");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        string str = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void loaddata()
        {
            str = "select*from students";
            da=new SqlDataAdapter(str,con);
            da.Fill(ds,"students");
            GridView2.DataSource = ds.Tables["students"].DefaultView;
            GridView2.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            DataTable dt=new DataTable("dtable");
            DataRow dr;
            dt.Columns.Add(new DataColumn("ID", typeof(int)));
            dt.Columns.Add(new DataColumn("name",typeof(string)));
            dt.Columns.Add(new DataColumn("DOB", typeof(DateTime)));
            dr = dt.NewRow();
            dr[0] = 1;
            dr[1] = "tanu";
            dr[2]=DateTime.Now;
            dt.Rows.Add(dr);
            ds.Tables.Add(dt);
            GridView1.DataSource = ds.Tables["dtable"].DefaultView;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "select * from students";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(TextBox1.Text));
            cmd.Parameters.AddWithValue("@name", TextBox2.Text);
            cmd.Parameters.AddWithValue("@subject", TextBox3.Text);
            cmd.Parameters.AddWithValue("@marks", TextBox4.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox1.Text = "";
            TextBox1.Focus();
            loaddata();
        }
    }
}