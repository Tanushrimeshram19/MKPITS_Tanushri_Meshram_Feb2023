using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int factorial = 1,number;
            number=Convert.ToInt32(textBox1.Text);
            for (int i = 1;i <= number;i++)

            {
                factorial = factorial * i;
                {
                    label2.Text = ("factorial" + factorial);
                }
            }
           
        }
    }
}
