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

namespace employeeconnections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (radioButton1.Checked)
            //{
            //    string result = null;
            //    result = emp.InsertRecord(textBox2.Text,radioButton1.Text,textBox3.Text,Convert.ToInt32(textBox4.Text),comboBox1.Text,Convert.ToDateTime(dateTimePicker1.Text));
            //    label8.Text = result;
            //    textBox1.Clear();
            //    textBox2.Clear();
            //    textBox1.Focus();
            //}
            //else if(radioButton1.Checked) 
            //{
            //            string result = null;
            //            result = emp.InsertRecord( textBox2.Text, radioButton1.Text, textBox3.Text, Convert.ToInt32(textBox4.Text), comboBox1.Text, Convert.ToDateTime(dateTimePicker1.Text));
            //            label8.Text = result;
            //            textBox1.Clear();
            //            textBox2.Clear();
            //            textBox1.Focus();
            //}

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataReader dr = emp.GetCity();
            //reading the records from sqldatareader
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["cityname"].ToString());
            }

        }

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    string result = null;
        //    result = emp.UpdateUsers(textBox1.Text, textBox2.Text);
        //    label8.Text = result;
        //    textBox1.Clear();
        //    textBox2.Clear();
        //    textBox1.Focus();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    string result = null;
        //    result = emp.deleteUsers(textBox1.Text);
        //    label8.Text = result;
        //    textBox1.Clear();
        //    textBox2.Clear();
        //    textBox1.Focus();
        //}
    }
    private void For(object sender, EventArgs e)
    {
        
    }
}
