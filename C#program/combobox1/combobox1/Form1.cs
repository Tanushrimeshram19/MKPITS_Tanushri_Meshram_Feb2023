using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string country = comboBox1.Text;
            switch (country)
            {
                case "india":
                    comboBox2.Items.Add("nagpur");
                    comboBox2.Items.Add("pune");
                    comboBox2.Items.Add("mumbai");
                    comboBox2.Items.Add("delhi");
                    comboBox2.Items.Add("amravati");
                    break;
                case "usa":
                    comboBox2.Items.Add("New york");
                    comboBox2.Items.Add("chicago");
                    comboBox2.Items.Add("Housion");
                    break;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SetSelected(0, true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "country :" + comboBox1.Text + "\n";
            label4.Text = "city :" + comboBox2.Text + "\n";

            label4.Text +
        }
    }
}

      
