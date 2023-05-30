using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectA
{
    public partial class Form1 : Form
    {
        enum category { student,IT_Professional}
        enum Gender { Male,Female,Other}
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Value =  DateTime.Today;
            dateTimePicker1.MinDate = DateTime.Today;
        }

        Category category;
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text = "1000";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                Category = category.Student;
                textBox2.Text = "1000";
            }
    }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox3.Clear();
                textBox4.Clear();
                category = Category.IT_Professional;
                textBox2.Text = "3000"; if (radioButton2.Checked)
                {
                    textBox3.Clear();
                    textBox4.Clear();
                    category = Category.IT_Professional;
                    textBox2.Text = "3000";
                }
            }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }