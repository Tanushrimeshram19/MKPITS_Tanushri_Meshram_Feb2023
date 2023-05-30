using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form f2 = null;
        Form f3 = null;


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        Form2 F2;
        Form F3;

        private void invoiceFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void customerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            f3= new Form3();
            f3.MdiParent = this;
            f3.Show();
        }

        private void existToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                toolStripProgressBar1.Value = i;
            }
            f2=new Form2();
            f2.MdiParent = this;
            f2.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
