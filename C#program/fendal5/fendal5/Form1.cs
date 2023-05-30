using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace fendal5
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

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataSet ds = productstore.Getproductname(comboBox1.Text);
            ComboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "Product_ID";

            DataSet ds1 = productstore.Getgstdetails(comboBox1.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            { 
             cgst = Convert.ToInt32(dr["cgst"].ToString());
             sgst = Convert.ToInt32(dr["sgst"].ToString());
                igst = Convert.ToInt32(dr["igst"].ToString());
                if (nationality == 0)
                {
                    tgst = cgst + sgst;
                }
                else
                {
                    tgst = igst;
                }
                textBox3.Text = cgst.ToString();
                textBox4.Text = sgst.ToString();
                textBox5.Text = tgst.ToString();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text = textBox3.Text + textBox4.Text;
            CalculateTotal();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            textBox3.Text = cgst.ToString();
            textBox4.Text = sgst.ToString();
            textBox5.Text=igst.ToString();
        }
    }
}

