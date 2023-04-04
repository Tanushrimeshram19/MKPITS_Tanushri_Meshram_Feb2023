using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox2.Items.Clear();
            string state = comboBox1.Text;

            switch(state)
            {
                case "Maharashtra":
                    comboBox2.Items.Add("Pune");
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Nagpur");
                    break;

                case "Uttar Pradesh":
                    comboBox2.Items.Add("Lucknow");
                    comboBox2.Items.Add("Agra");
                    comboBox2.Items.Add("Jhansi");
                    break;

                case "Madhya Pradesh":
                    comboBox2.Items.Add("Bhopal");
                    comboBox2.Items.Add("Indore");
                    comboBox2.Items.Add("Betul");
                    break;
    



            }

        }
    }
}
