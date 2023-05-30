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

namespace fendhal
{

    public partial class Form1 : Form
    {
        enum Nationality { Indian, NRI }
        Nationality nationality;
        int cgst = 0;
        int sgst = 0;
        int igst = 0;
        int tgst = 0;
        public Form1()
        {

            InitializeComponent();
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.gettablecategory();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Product_type_Name";
            comboBox1.ValueMember = "Product_Category_ID";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.Indian;
            // MessageBox.Show(nationality.ToString());
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();

            textBox8.Text = Convert.ToString(Convert.ToInt32(textBox6.Text) + Convert.ToInt32(textBox7.Text));

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            nationality = Nationality.NRI;
            // MessageBox.Show(nationality.ToString());
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = igst.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.Getproductprice(comboBox2.Text);
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                textBox2.Text = dr["price"].ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = ProductStore.getproduct(comboBox1.Text);
            comboBox2.DataSource = ds.Tables[0];
            comboBox2.DisplayMember = "Product_Name";
            comboBox2.ValueMember = "Product_Id";

            DataSet ds1 = ProductStore.Getproductgst(comboBox1.Text);

            foreach (DataRow dr in ds1.Tables[0].Rows)
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
            textBox6.Text = cgst.ToString();
            textBox7.Text = sgst.ToString();
            textBox8.Text = tgst.ToString();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            {
                {
                    if (textBox3.Text == "")
                    {

                    }
                    else
                    {
                        double totalamount = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox3.Text);
                        textBox4.Text = totalamount.ToString();
                        double cgstamount = Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(textBox6.Text) / 100.0);
                        textBox9.Text = cgstamount.ToString();
                        double sgstamount = Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(textBox7.Text) / 100.0);
                        textBox10.Text = sgstamount.ToString();
                        double igstamount = Convert.ToDouble(textBox2.Text) * (Convert.ToDouble(textBox8.Text) / 100.0);
                        textBox11.Text = igstamount.ToString();
                        double netamount = Convert.ToDouble(textBox4.Text) + Convert.ToDouble(textBox11.Text);
                        textBox5.Text = netamount.ToString();
                    }
                }

            }
        }
    }

