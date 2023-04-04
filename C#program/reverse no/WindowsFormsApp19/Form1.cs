using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(); 
            int rows=Convert.ToInt32(textBox1.Text);
            for (int i = rows; i >= 1; i--)
            {
                for (int j = rows; j > i; j--)
                {
                    sb.Append("");
                }
                for (int k = 1; k < (i * 2); k++)
                {
                    sb.Append("*");
                }
                sb.Append("/n");
            }
                label1.Text=sb.ToString();
            }
        }
    }

