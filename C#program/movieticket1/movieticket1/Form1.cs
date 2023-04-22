using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace movieticket1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            comboBox3.Text = "";
            switch (comboBox1.Text)
            {
                case "Baahubali 2 The Conclusion":
                    comboBox2.Items.Add("Cinemax Cinemas (Eternity Mall)");
                    comboBox2.Items.Add("INOX Cinemas (Jaswant Tuli Mal");
                    break;
                case "KGF Chapter 2":
                    comboBox2.Items.Add("Panchsheel Cinema");
                    comboBox2.Items.Add("Alankar Cinema");
                    break;
                case "RRR ":
                    comboBox2.Items.Add("K Sera Sera Miniplex");
                    comboBox2.Items.Add("Goyal Talkies");

                    break;

            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            comboBox3.Items.Clear();
            switch (comboBox2.Text)
            {
                case "INOX Cinemas (Jaswant Tuli Mal":
                    comboBox3.Items.Add("12.00 PM");
                    comboBox3.Items.Add("03.00 PM");
                    textBox1.Text = "120";
                    break;
                case "Cinemax Cinemas (Eternity Mall)":
                    comboBox3.Items.Add("10.30 AM");
                    comboBox3.Items.Add("01.30 PM");
                    textBox1.Text = "420";
                    break;
                case "Panchsheel Cinema":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "100";
                    break;
                case "Alankar Cinema":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "100";
                    break;
                case "K Sera Sera Miniplex":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "100";
                    break;
                case "Goyal Talkies":
                    comboBox3.Items.Add("12.30 PM");
                    comboBox3.Items.Add("06.30 PM");
                    textBox1.Text = "100";
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Movie_Ticket mt = null;
            if (radioButton1.Checked)
            {
                mt = new Online_Booking(comboBox1.Text, comboBox2.Text, comboBox3.Text,
                Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));

            }
            else if (radioButton2.Checked)
            {
                mt = new BoxOffice(comboBox1.Text, comboBox2.Text, comboBox3.Text,
                Convert.ToInt32(numericUpDown1.Value), Convert.ToSingle(textBox1.Text));

            }
            label7.Text = mt.Calculate_Ticket_Price();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}


    

