using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom;

namespace Fendal4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
        enum Nationality
        {
            Indian, NRI
        }
        Nationality nationality;

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = productstore.Getproductcategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_type_Name";
            comboBox1.ValueMember = "Product_category_Id";
        }
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds=productstore.Getproductname(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "Product_ID";

            DataSet ds1 = productstore.Getgstdetails(comboBox1.Text);
            foreach(DataRow dr in ds1.Tables[0].Rows)
            {
                cgst = Convert.ToInt32(dr["cgst"].ToString());
                sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());
            }
            if (nationality == 0)
            {
                tgst = cgst + sgst;
            }
            else
            {
                tgst = igst;
            }
            textBox3.Text=cgst.ToString();
            textBox4.Text=sgst.ToString();
            textBox5.Text=tgst.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = cgst.ToString(); 
            textBox4.Text = sgst.ToString();
            textBox5.Text = textBox3.Text+textBox4.Text;
            CalculateTotal();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text= igst.ToString();
            CalculateTotal();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = productstore.Getproductprice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox6.Text= dr["price"].ToString();
            }
        }
        public void CalculateTotal()
        {
            double totalamount = Convert.ToDouble(textBox6.Text) * Convert.ToDouble(textBox7.Text);
            textBox8.Text= totalamount.ToString();

            double cgstamount = Convert.ToDouble(textBox6.Text )* (Convert.ToDouble(textBox3.Text )/100.0);
            textBox10.Text= cgstamount.ToString();

            double sgstamount = Convert.ToDouble(textBox6.Text) * (Convert.ToDouble(textBox4.Text) / 100.0);
            textBox12.Text= sgstamount.ToString();

            double igstamount = Convert.ToDouble(textBox6.Text) * (Convert.ToDouble(textBox5.Text) / 100.0);
            textBox11.Text= igstamount.ToString();

            double netamount= Convert.ToDouble(textBox8.Text) + Convert.ToDouble(textBox11.Text);
            textBox9.Text= netamount.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {

            }
            else
            {
                CalculateTotal();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Checkuserdetail();
        }
        public void Checkuserdetail()
        {
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("please fill all details");
            }
            else if (textBox7.Text == "0")
            {
                MessageBox.Show("quantity can not be zero");
            }
            else
            {
                string result = productstore.Saveinvoicedetails(textBox1.Text, Convert.ToInt32(textBox2.Text),
                    Convert.ToInt32(comboBox2.SelectedValue), Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(nationality),
                   dateTimePicker1.Value, Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox7.Text),
                    
                    Convert.ToDecimal(textBox3.Text), Convert.ToDecimal(textBox4.Text), Convert.ToDecimal(textBox5.Text),
                    Convert.ToDecimal(textBox10.Text), Convert.ToDecimal(textBox12.Text), Convert.ToDecimal(textBox11.Text),
                    Convert.ToDecimal(textBox8.Text));
                MessageBox.Show(result);
            }
        }
        public void Clearall()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clearall();
        }
    }
}
