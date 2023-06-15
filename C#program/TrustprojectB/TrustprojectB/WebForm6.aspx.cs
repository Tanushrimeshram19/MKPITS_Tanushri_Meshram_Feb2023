using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TrustprojectB
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }



    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string query = null;
            SqlConnection con = new SqlConnection("server=\\sqlexpress;integrated security=true;database=trustdb1");
            SqlCommand command;
            if (RadioButton1.Checked)
            {
                try
                {
                    query = "insert into Transaction_details(item_id,transaction_date,department_id,quantity) values(@item_id,@transaction_date,@department_id,@quantity)";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    command.Parameters.AddWithValue("@transaction_date", TextBox1.Text);
                    command.Parameters.AddWithValue("@department_id", DropDownList2.SelectedValue);
                    command.Parameters.AddWithValue("@quantity", TextBox2.Text);
                    con.Open();
                    command.ExecuteNonQuery();
                    con.Close();

                    //code to get balance_quantity from item_master table
                    int bal_qty = 0;
                    query = "select balance_quantity from item_master where item_id=@item_id";
                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    con.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        bal_qty = Convert.ToInt32(reader[0].ToString());
                    }
                    reader.Close();
                    con.Close();
                    //  Response.Write("bal qty " + bal_qty.ToString());
                    int qty = bal_qty - Convert.ToInt32(TextBox2.Text);

                    query = "update item_master set balance_quantity=@balance_quantity where item_id=@item_id";

                    command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@balance_quantity", qty);
                    command.Parameters.AddWithValue("@item_id", DropDownList1.SelectedValue);
                    con.Open();
                    command.ExecuteNonQuery();
                    //con.Close();
                    Label1.Text = "item issued to department successfully";


                }
                catch (Exception ee)
                {
                    Label1.Text = ee.ToString();
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}


        