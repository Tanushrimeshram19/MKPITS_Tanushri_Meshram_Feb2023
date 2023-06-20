using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DrivenItMachinetest
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("server=LAPTOP-9HOA3TDR\\SQLEXPRESS;integrated security=true;database=DrivenIt.Db");
        SqlCommand command = null;
        string query = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into transactions values(@itemid,@TransType,@Transqty,@Transdate)";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {
                    transt = "R";
                }
                command.Parameters.AddWithValue("@transtype", transt);
                command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@transdate", TextBox2.Text);
                con.Open();
                command.ExecuteNonQuery();


                query = "select max(balqty) from itemmaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                if (transt == "I")
                {
                    bq = bq - Convert.ToInt32(TextBox1.Text);
                }
                else if (transt == "R")
                {
                    bq = bq + Convert.ToInt32(TextBox1.Text);

                }


                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty", bq);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                Label1.Text = "record saved";
            }
            catch (Exception ex)
            {

                Label1.Text = ex.ToString();
            }
            finally
            {
                con.Close();
            }
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("transid" + transid);
            int updatedqty = 0;
            updatedqty = Convert.ToInt32(TextBox2.Text) - oldtransqty;
            Response.Write("updated quantity is" + updatedqty);

            try
            {
                query = "update transactions set transtype=@transtype,transqty=@transqty,transedate=@transedate where itemid = @itemid";

                command = new SqlCommand(query, con);

                string transt = null;
                if (RadioButton1.Checked)
                {
                    transt = "I";
                }
                else if (RadioButton2.Checked)
                {

                    transt = "R";
                }
                command.Parameters.AddWithValue("@transtype", transt);
                command.Parameters.AddWithValue("@transqty", Convert.ToInt32(TextBox1.Text));
                command.Parameters.AddWithValue("@transedate", TextBox2.Text);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                con.Open();
                command.ExecuteNonQuery();


                query = "select max(balqty) from itemmaster where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                int bq = Convert.ToInt32(command.ExecuteScalar());
                Response.Write("bq" + bq.ToString());
                Response.Write("updataedqty" + updatedqty.ToString());

                if (RadioButton1.Checked)
                {
                    bq = bq - updatedqty;
                }
                else if (RadioButton2.Checked)
                {
                    bq = bq + updatedqty;

                }
                Response.Write("newupdaatedqty" + bq.ToString());
                if (bq < 0)
                {
                    Label1.Text = "stock not available";
                }
                else { 
                query = "update itemmaster set balqty=@balqty where itemid=@itemid";
                command = new SqlCommand(query, con);
                command.Parameters.AddWithValue("@balqty", bq);
                command.Parameters.AddWithValue("@itemid", DropDownList1.SelectedValue);
                command.ExecuteNonQuery();

                    Label1.Text = "record updated succesfully";
                    }
                }
                catch (Exception ex)
                {

                    Label1.Text = ex.ToString();
                }

                finally
                {
                    con.Close();
                }
            
        }

       
        protected void Button3_Click(object sender, EventArgs e)
        {

        }
        static int oldtransqty;
        static int transid;


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[4].Text;
            oldtransqty = Convert.ToInt32(TextBox1.Text);
            DateTime dd = Convert.ToDateTime(GridView1.SelectedRow.Cells[5].Text);
            TextBox2.Text = dd.ToString("yyyy-MM-dd");
            DropDownList1.SelectedValue = GridView1.SelectedRow.Cells[1].Text;

            string res = GridView1.SelectedRow.Cells[3].Text;
            if (res == "I")
            {
                RadioButton2.Checked = false;
                RadioButton1.Checked = true;
            }
            if (res == "R")
            {
                RadioButton1.Checked = false;
                RadioButton2.Checked = true;

            }
            transid = Convert.ToInt32(GridView1.SelectedRow.Cells[1].Text);
        }
    }
}