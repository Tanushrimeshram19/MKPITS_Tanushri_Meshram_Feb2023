using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, total;
            s1 = int.Parse(textBox1.Text);
            s2= int.Parse(textBox2.Text);
            s3= int.Parse(textBox3.Text);
            total=s1+s2+s3;
            label4.Text = "total:" + total;
            float per = (total / 300.0f) * 100.0f;
            label5.Text = "per:" + per;
            if (per >= 75)
            {
                label6.Text = "grade:grade";
            }
            else
            {
                label6.Text = "grade:fail";
            }
            }
        }
    }

