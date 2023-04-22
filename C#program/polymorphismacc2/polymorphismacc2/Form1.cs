using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace polymorphismacc2
{

    public partial class Form1 : Form
    {
        internal class Account
        {
            public int bal = 1000;
            public virtual int deposite(int amt)
            {

                return bal;
            }
        }
        internal class Saving : Account
        {
            public int intrest = 500;
            public override int deposite(int amt)
            {
                bal = bal + amt + intrest;
                return bal;
            }
        }
        internal class Current : Account
        {
            public override int deposite(int amt)
            {
                bal = bal + amt;
                return bal;
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Account act = null;
            string acttype;
            acttype = Convert.ToString(textBox3.Text);
            if (acttype == "saving")
            {
                act = new Saving();
                int result = act.deposite(Convert.ToInt32(textBox2.Text));
                label4.Text = Convert.ToString(result);
            }
            else if (acttype == "current")
            {
                act = new Current();
                int result = act.deposite(Convert.ToInt32(textBox2.Text));
                label4.Text = Convert.ToString(result);
            }
        }
    }
}



        
    
