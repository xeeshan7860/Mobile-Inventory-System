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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Sign_Up SU = new Sign_Up();
            SU.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.textBox1.CharacterCasing = CharacterCasing.Normal;
            this.textBox2.CharacterCasing = CharacterCasing.Normal;
            this.textBox1.MaxLength = 20;
            this.textBox2.MaxLength = 16;
            this.textBox2.PasswordChar='*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "zeeshan" && this.textBox2.Text == "zeesh")
            {
                MessageBox.Show("You Are In Mobile Inventory SysteM Software","Congratulations",MessageBoxButtons.OK,MessageBoxIcon.None);
                this.Hide();
                NMISS f2= new NMISS();
                f2.ShowDialog();
            }
            else if(this.textBox1.Text=="" && this.textBox2.Text=="")
            {
                MessageBox.Show("Please Enter The User Name & Password","Alert",MessageBoxButtons.RetryCancel);
            }
            else if (this.textBox1.Text != "zeeshan")
            {
                MessageBox.Show("Please Enter Correct User Name","Warning",MessageBoxButtons.RetryCancel,MessageBoxIcon.Warning);
                this.textBox1.Clear();
                this.textBox2.Clear();
            }
            else if (this.textBox2.Text != "zeesh")
            {
                MessageBox.Show("Please Enter Correct Password", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                this.textBox2.Clear();
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("You Also Must Enter Password", "Warning", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                this.textBox2.Clear();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
