using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int n1=Convert.ToInt32(this.Text);
            int n2=Convert.ToInt32(this.Text);
            int result=n1 + n2;
            label3.Text = "addition:" + result;
        }

 

        private void button2_Click_1(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(this.Text);
            int n2 = Convert.ToInt32(this.Text);
            int result = n1 -n2;
            label3.Text = "subtraction:" + result;
        }

    }
}

