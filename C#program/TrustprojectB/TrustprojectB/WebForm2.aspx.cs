using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Security.Cryptography;

namespace TrustprojectB
{
    public partial class WebForm2 : System.Web.UI.Page
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
            str = "insert into Department_MAster values(@Department_Name)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record inserted";
            TextBox1.Text = ""; ;
            TextBox1.Focus();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            str = "update Department_MAster set department_name=@Department_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record updated";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            str = "delete from Department_Master where Department_Name=@Department_Name";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.Parameters.AddWithValue("@Department_Name", TextBox1.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Label1.Text = "record deleted";
            TextBox1.Text = "";
            TextBox1.Focus();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            str = "select * from department_Master where department_Name=@department_Name";
            da = new SqlDataAdapter(str, con);
            da.SelectCommand.Parameters.AddWithValue("@Department_Name", TextBox1.Text);
            da.Fill(ds, "department_Master");
            TextBox2.Text = ds.Tables["department_Master"].Rows[0].ItemArray[1].ToString();



        }
    }
}