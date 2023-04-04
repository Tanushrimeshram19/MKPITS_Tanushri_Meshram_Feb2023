using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formdiamond
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
            int height = Convert.ToInt32(textBox1.Text);

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    sb.Append(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    sb.Append("*");
                }
                sb.Append("\n");
            }
            label1.Text = sb.ToString();
            {
                
                int rows = Convert.ToInt32(textBox1.Text);
                for (int i = rows; i >= 1; i--)
                {
                    for (int j = rows; j > i; j--)
                    {
                        sb.Append(" ");
                    }
                    for (int k = 1; k < (i * 2); k++)
                    {
                        sb.Append("*");
                    }
                    sb.Append("\n");
                }
                label1.Text = sb.ToString();
            }
        }

    }
}
