using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Professional
{
    public partial class setting : Form
    {
        ICSCONN cls = new ICSCONN();
        public setting()
        {
            InitializeComponent();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.BackColor = Color.White;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            setting sett = new setting();
            sett.ShowDialog();
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutBox1 abt = new AboutBox1();
            abt.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            setting sett = new setting();
            sett.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up su = new Sign_Up();
            su.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hom = new Home();
            hom.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            if (checkBox3.Checked)
            {
                MessageBox.Show("Dou You Agree??", "Alert", MessageBoxButtons.YesNoCancel);
                SqlCommand cmd = new SqlCommand("delete from nokia_mobail", cls.conn);
                cmd.ExecuteScalar();
                MessageBox.Show("All Nokia Record has been Deleted", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            else if (checkBox4.Checked)
            {
                MessageBox.Show("Dou You Agree??", "Alert", MessageBoxButtons.YesNoCancel);
                SqlCommand cmd = new SqlCommand("delete  from vander", cls.conn);
                cmd.ExecuteScalar();
                MessageBox.Show("All Nokia Record has been Deleted", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            else if (checkBox5.Checked)
            {
                MessageBox.Show("Dou You Agree??", "Alert", MessageBoxButtons.YesNoCancel);
                SqlCommand cmd = new SqlCommand("delete  from customer", cls.conn);
                cmd.ExecuteScalar();
                MessageBox.Show("All Nokia Record has been Deleted", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            else if (checkBox1.Checked)
            {
                MessageBox.Show("Dou You Agree??", "Alert", MessageBoxButtons.YesNoCancel);
                SqlCommand cmd = new SqlCommand("delete  from customer,vander,nokia_mobail", cls.conn);
                cmd.ExecuteScalar();
                MessageBox.Show("All Nokia Record has been Deleted", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            }
            cls.conn.Close();
        }

        private void groupBox14_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professional f2 = new Professional();
            DialogResult DR = colorDialog1.ShowDialog();
            if(DR == DialogResult.OK)
            {
                f2.textBox1.BackColor = colorDialog1.Color;
                f2.textBox2.BackColor = colorDialog1.Color;
                f2.textBox4.BackColor = colorDialog1.Color;
                f2.textBox5.BackColor = colorDialog1.Color;
                f2.textBox6.BackColor = colorDialog1.Color;
                f2.textBox7.BackColor = colorDialog1.Color;
                f2.textBox8.BackColor = colorDialog1.Color;
                f2.textBox9.BackColor = colorDialog1.Color;
                f2.textBox10.BackColor = colorDialog1.Color;
                f2.textBox11.BackColor = colorDialog1.Color;
                f2.textBox12.BackColor = colorDialog1.Color;
                f2.textBox25.BackColor = colorDialog1.Color;
                f2.textBox26.BackColor = colorDialog1.Color;
                f2.textBox25.BackColor = colorDialog1.Color;
                f2.textBox26.BackColor = colorDialog1.Color;
                f2.textBox28.BackColor = colorDialog1.Color;
                f2.textBox30.BackColor = colorDialog1.Color;
                f2.textBox31.BackColor = colorDialog1.Color;
                f2.textBox32.BackColor = colorDialog1.Color;
                f2.textBox33.BackColor = colorDialog1.Color;
                f2.textBox34.BackColor = colorDialog1.Color;
                f2.textBox35.BackColor = colorDialog1.Color;
                f2.textBox36.BackColor = colorDialog1.Color;
                f2.textBox30.BackColor = colorDialog1.Color;
                f2.textBox41.BackColor = colorDialog1.Color;
                f2.textBox42.BackColor = colorDialog1.Color;
                f2.textBox43.BackColor = colorDialog1.Color;
                f2.textBox44.BackColor = colorDialog1.Color;
                f2.textBox45.BackColor = colorDialog1.Color;
                f2.textBox46.BackColor = colorDialog1.Color;
                f2.textBox47.BackColor = colorDialog1.Color;
                f2.textBox48.BackColor = colorDialog1.Color;
                f2.textBox49.BackColor = colorDialog1.Color;
                f2.textBox50.BackColor = colorDialog1.Color;
                f2.textBox51.BackColor = colorDialog1.Color;
                f2.textBox52.BackColor = colorDialog1.Color;
                f2.textBox55.BackColor = colorDialog1.Color;
                f2.textBox56.BackColor = colorDialog1.Color;
                f2.textBox57.BackColor = colorDialog1.Color;
                f2.textBox58.BackColor = colorDialog1.Color;
                f2.textBox60.BackColor = colorDialog1.Color;
                f2.textBox61.BackColor = colorDialog1.Color;
                f2.textBox62.BackColor = colorDialog1.Color;
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Professional f2 = new Professional();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Setting Save", "Congrates", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
