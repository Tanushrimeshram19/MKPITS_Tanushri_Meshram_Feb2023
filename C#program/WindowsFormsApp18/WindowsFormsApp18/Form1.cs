using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            int total = 0;
            if (radioButton1.Checked)
            {
                total = total + 10;
            }
            if (radioButton4.Checked)
            {
                total = total + 10;
            }
            int counter = 0;
            if (checkBox1.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total + 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox2.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total - 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            if (checkBox3.Checked)
            {
                counter = counter + 1;
                if (counter < 3)
                {
                    total = total + 5;
                }
                else
                {
                    MessageBox.Show("please select only 2 options");
                }
            }
            label4.Text = "total out of 20 :" + total;
        }
        int cnt = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt = cnt + 1;
            if (cnt <= 15)
            {
                label6.Text = "Time left : 00 : " + cnt.ToString() + " sec";
            }
            else

            {
                timer1.Enabled = false;
                button1.Enabled = false;
                MessageBox.Show("time over");

            }
        }
    }
}


  
