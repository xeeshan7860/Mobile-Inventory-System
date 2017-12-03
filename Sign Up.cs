using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Professional
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

            this.textBox11.Text = System.DateTime.Now.ToShortDateString();
            this.textBox10.Text = System.DateTime.Now.ToShortDateString();
            this.textBox9.Text = System.DateTime.Now.ToShortDateString();
            this.WindowState = FormWindowState.Maximized;
        }

       private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hom = new Home();
            hom.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox7_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up su = new Sign_Up();
            su.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Professional f2 = new Professional();
            f2.ShowDialog();
        }
    }
}
