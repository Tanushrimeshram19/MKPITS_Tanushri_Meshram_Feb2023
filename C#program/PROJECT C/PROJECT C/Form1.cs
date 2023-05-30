using PROJECT_C.Project1;
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

namespace PROJECT_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductDetails.GetProductCategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "product_category_id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductDetails.GetProductName(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "product_name";
            comboBox2.ValueMember = "product_id";
            {
                textBox2.Text = dr ["Available_Quantity"].ToString();
            }

            DataSet ds1 = ProductDetails.GetTotalQuantity(comboBox2.Text);
            foreach (DataRow dr in ds1.Tables[0].Rows)
            {
                textBox3.Text = dr["Total_Quantity"].ToString();
            }

            DataSet ds2 = ProductDetails.GetPrice(comboBox2.Text);
            foreach (DataRow dr in ds2.Tables[0].Rows)
            {
                textBox4.Text = dr["Price"].ToString();
            }

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            double total = Convert.ToDouble(textBox9.Text) * Convert.ToDouble(textBox4.Text);
            textBox10.Text = total.ToString();
        }
    }
}



        