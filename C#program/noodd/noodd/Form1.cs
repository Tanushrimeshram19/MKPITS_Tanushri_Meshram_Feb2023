using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace noodd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int isodd = 0;
            int num = Convert.ToInt32(textBox1.Text);
            for (int counter = 2; counter < num; counter++)
            {
                if (num % counter == 0)
                {
                    isodd++;
                    break;
                }
            }
            if (isodd == 0)
            {
                label2.Text = "enetred number is odd";
            }
            else
            {
                label2.Text = "not odd";
            }
        }
    }
}

