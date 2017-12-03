using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.Sql;
using System.Data.SqlClient;
//using System.Data.SqlTypes;

namespace Professional
{
    public partial class Professional : Form
    {
        ICSCONN cls = new ICSCONN();
        public Professional()
        {
            InitializeComponent();
        }

        private void Professional_Load(object sender, EventArgs e)
        {
            this.dataGridView2.ForeColor = Color.Black;
            this.groupBox24.Enabled = false;
            this.groupBox25.Enabled = false;
            //vander new record
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            //customer new record
            this.groupBox21.Enabled = false;
            this.groupBox20.Enabled = false;
            this.groupBox18.Enabled = false;
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from nokia_mobail",cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                this.comboBox9.Items.Add(dr["nmdid"]);
                this.comboBox6.Items.Add(dr["nmdid"]);
                this.comboBox5.Items.Add(dr["nmdid"]);
            }
            cls.conn.Close();
            cls.conn.Open();
             cmd = new SqlCommand("select * from vander", cls.conn);
             dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox10.Items.Add(dr["vandid"]);
                this.comboBox1.Items.Add(dr["vandid"]);
                this.comboBox7.Items.Add(dr["vandid"]);
            }
            cls.conn.Close();
            cls.conn.Open();
             cmd = new SqlCommand("select * from customer", cls.conn);
             dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox11.Items.Add(dr["cusdid"]);
                this.comboBox2.Items.Add(dr["cusdid"]);
                this.comboBox8.Items.Add(dr["cusdid"]);
            }
            cls.conn.Close();
            this.WindowState = FormWindowState.Maximized;
            this.button4.Visible = false;
            this.button14.Visible = false;
            //vander id namespace Deleted label
            this.label28.Visible = false;
            this.label29.Visible = false;
            this.button12.Visible =false;
            //vander id namespace Deleted TB
            this.comboBox10.Visible = false;
            this.textBox28.Visible = false;
            //
            //customer id namespace Deleted label
            this.label30.Visible = false;
            this.label31.Visible = false;
            this.button13.Visible = false;
            //customer id namespace Deleted TB
            this.comboBox11.Visible = false;
            this.textBox30.Visible = false;
            this.tabPage7.Text = "New Entries";
            this.tabPage8.Text = "Insert New Mobile Models";
            this.tabPage9.Text = "Delete Record";
            this.tabPage10.Text = "Edits";
            this.tabPage6.Text = "All Models";
            this.tabPage5.Text = "Find Selected Record ";
            this.tabPage11.Text = "Vanders & Customers";
            this.tabPage12.Text = "Nokia Models";
            //Mobail delete
            this.groupBox12.Enabled = false;
           
            //customer new record
            //Department delete
            this.groupBox13.Enabled = false;
            //Mobail edit
            this.groupBox17.Enabled = false;
            //member department edit
            this.groupBox23.Enabled = false;
            //costomer edit
            this.groupBox22.Visible = false;
            //vander edit
            this.groupBox16.Visible = false;
        }

        private void addItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox12_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox13_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox23_Enter(object sender, EventArgs e)
        {

        }

        private void label54_Click(object sender, EventArgs e)
        {

        }
        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox10_Enter_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

            this.groupBox12.Enabled = true;
            //hide dipart record delete
            this.groupBox13.Enabled = false;
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            this.button14.Visible = true;
            this.groupBox1.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox21.Enabled = true;
            this.groupBox20.Enabled = true;
            this.groupBox18.Enabled = true;
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            this.button4.Visible = true;
            this.groupBox1.Enabled = true;
            this.groupBox2.Enabled = true;
            this.groupBox3.Enabled = true;
            this.groupBox21.Enabled = false;
            this.groupBox20.Enabled = false;
            this.groupBox18.Enabled = false;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            this.groupBox13.Enabled = true;
            //hide MObail record delete
            this.groupBox12.Enabled = false;
        }

        private void radioButton12_CheckedChanged_1(object sender, EventArgs e)
        {

            this.groupBox17.Enabled = true;
            ////dipart member edit
            this.groupBox23.Enabled = false;
        }

        private void radioButton11_CheckedChanged_1(object sender, EventArgs e)
        {

            this.groupBox23.Enabled = true;
            //Mobail edit
            this.groupBox17.Enabled = false;
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            this.groupBox16.Visible = true;
            //cutomer edit
            this.groupBox22.Visible = false;
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {

            this.groupBox22.Visible = true;
            //vander edit
            this.groupBox16.Visible = false;
        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            //vander id namespace Deleted label
            this.label28.Visible = true;
            this.label29.Visible = true;
            this.button12.Visible = true;
            //vander id namespace Deleted TB
            this.comboBox10.Visible = true;
            this.textBox28.Visible = true;
            //customer id namespace Deleted label
            this.label30.Visible = false;
            this.label31.Visible = false;
            //customer id namespace Deleted TB
            this.comboBox11.Visible = false;
            this.textBox30.Visible = false;
            this.button13.Visible = false;
        }

        private void radioButton6_CheckedChanged_1(object sender, EventArgs e)
        {
            //customer id namespace Deleted label
            this.label30.Visible = true;
            this.label31.Visible = true;
            this.button13.Visible = true;
            //customer id namespace Deleted TB
            this.comboBox11.Visible = true;
            this.textBox30.Visible = true;
            //vander id namespace Deleted label
            this.label28.Visible = false;
            this.label29.Visible = false;
            //vander id namespace Deleted TB
            this.comboBox10.Visible = false;
            this.textBox28.Visible = false;
            this.button12.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into nokia_mobail (nmdid,nmname,nmcountry,nmcity,nmmodel,nmimei,nmdate) values (@nmdid,@nmname,@nmcountry,@nmcity,@nmmodel,@nmimei,@nmdate)", cls.conn);
                cmd.Parameters.AddWithValue(@"nmdid", textBox36.Text);
                cmd.Parameters.AddWithValue(@"nmname", textBox35.Text);
                cmd.Parameters.AddWithValue(@"nmcountry", textBox32.Text);
                cmd.Parameters.AddWithValue(@"nmcity", textBox31.Text);
                cmd.Parameters.AddWithValue(@"nmmodel", textBox34.Text);
                cmd.Parameters.AddWithValue(@"nmimei", textBox26.Text);
                cmd.Parameters.AddWithValue(@"nmdate", textBox33.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Has Been Inserted", "Command Sucsessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("You Cannot Input Same ID Becouse Its Primary Key", "Alert");
            }
            cls.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into vander (vandid,vandname,vandcountry,vandcity,vandpc,vandcnic,vandrel,vandph) values (@vandid,@vandname,@vandcountry,@vandcity,@vandpc,@vandcnic,@vandrel,@vandph)", cls.conn);
                cmd.Parameters.AddWithValue(@"vandid", textBox1.Text);
                cmd.Parameters.AddWithValue(@"vandname", textBox2.Text);
                cmd.Parameters.AddWithValue(@"vandcountry", textBox6.Text);
                cmd.Parameters.AddWithValue(@"vandcity", textBox5.Text);
                cmd.Parameters.AddWithValue(@"vandpc", textBox4.Text);
                cmd.Parameters.AddWithValue(@"vandcnic", textBox8.Text);
                cmd.Parameters.AddWithValue(@"vandrel", textBox7.Text);
                cmd.Parameters.AddWithValue(@"vandph", textBox9.Text);
                cmd.ExecuteScalar();
                MessageBox.Show("Data Has Been Inserted", "Command Sucsessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("You Cannot Input Same ID Becouse Its Primary Key", "Alert");
            }
            cls.conn.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into customer (cusdid,cusname,cuscountry,cuscity,cuspc,cuscnic,cusrel,cusph) values (@cusdid,@cusname,@cuscountry,@cuscity,@cuspc,@cuscnic,@cusrel,@cusph)", cls.conn);
                cmd.Parameters.AddWithValue(@"cusdid", textBox61.Text);
                cmd.Parameters.AddWithValue(@"cusname", textBox60.Text);
                cmd.Parameters.AddWithValue(@"cuscountry", textBox58.Text);
                cmd.Parameters.AddWithValue(@"cuscity", textBox57.Text);
                cmd.Parameters.AddWithValue(@"cuspc", textBox56.Text);
                cmd.Parameters.AddWithValue(@"cuscnic", textBox11.Text);
                cmd.Parameters.AddWithValue(@"cusrel", textBox10.Text);
                cmd.Parameters.AddWithValue(@"cusph", textBox12.Text);
                cmd.ExecuteScalar();
                MessageBox.Show("Data Has Been Inserted", "Command Sucsessful", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("You Cannot Input Same ID Becouse Its Primary Key", "Alert");
            }
            cls.conn.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox61.Clear();
            textBox60.Clear();
            textBox58.Clear();
            textBox57.Clear();
            textBox56.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox12.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox36.Clear();
            textBox35.Clear();
            textBox32.Clear();
            textBox31.Clear();
            textBox34.Clear();
            textBox26.Clear();
            textBox33.Clear();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            
        }

        private void groupBox17_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox23_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox16_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox22_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (radioButton9.Checked) 
            {
                cls.conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from nokia_mobail", cls.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                cls.conn.Close();
            }
            else if (radioButton10.Checked)
            {
                cls.conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from vander", cls.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                cls.conn.Close();
            }
            else if (radioButton17.Checked)
            {
                cls.conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select * from customer", cls.conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
                cls.conn.Close();
            }

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from nokia_mobail where nmdid='"+comboBox9.Text+"'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox25.Text=(dr["nmmodel"]).ToString();
            }
            cls.conn.Close();
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from vander where vandid='"+comboBox10.Text+"'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox28.Text = (dr["vandname"]).ToString();
            }
            cls.conn.Close();
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer where cusdid='"+comboBox11.Text+"'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
           if (dr.Read())
            {
                this.textBox30.Text = (dr["cusname"]).ToString();
            }
            cls.conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("delete from nokia_mobail where nmdid=@nmdid", cls.conn);
            cmd.Parameters.AddWithValue("nmdid", comboBox9.Text);
            cmd.Parameters.AddWithValue("vpname", textBox25.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Data has been Deleted", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            this.comboBox9.Items.Clear();
            this.textBox25.Clear();
            cmd = new SqlCommand("select * from nokia_mobail", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox9.Items.Add(dr["nmdid"]);
            }
            cls.conn.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("delete from vander where vandid=@vandid", cls.conn);
            cmd.Parameters.AddWithValue("vandid", comboBox10.Text);
            cmd.Parameters.AddWithValue("vandname", textBox28.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Data has been Deleted", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            this.comboBox10.Items.Clear();
            this.textBox28.Clear();
            cmd = new SqlCommand("select * from vander", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox10.Items.Add(dr["vandid"]);
            }
            cls.conn.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("delete from customer where cusdid=@cusdid", cls.conn);
            cmd.Parameters.AddWithValue("cusdid", comboBox11.Text);
            cmd.Parameters.AddWithValue("cusname", textBox30.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Data has been Deleted", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            this.comboBox11.Items.Clear();
            this.textBox30.Clear();
            cmd = new SqlCommand("select * from customer", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox11.Items.Add(dr["cusdid"]);
            }
            cls.conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton18_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox24.Enabled = true;
            this.groupBox25.Enabled = false;
        }

        private void radioButton19_CheckedChanged(object sender, EventArgs e)
        {

            this.groupBox25.Enabled = true;
            this.groupBox24.Enabled = false;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            this.tabControl2.Enabled = true;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void groupBox19_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {


            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("update nokia_mobail set nmmodel=@nmmodel where nmdid='"+comboBox6.Text+"'", cls.conn);
            cmd.Parameters.AddWithValue("nmmodel", textBox50.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Data has been Updated", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            this.comboBox6.Items.Clear();
            this.textBox50.Clear();
            cmd = new SqlCommand("select * from nokia_mobail", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox6.Items.Add(dr["nmdid"]);
            }
            cls.conn.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("update vander set vandname=@vandname,vandcountry=@vandcountry,vandrel=@vandrel,vandph=@vandph,vandcity=@vandcity where vandid='" + comboBox7.Text + "'", cls.conn);
            cmd.Parameters.AddWithValue("vandname",textBox48.Text);
            cmd.Parameters.AddWithValue("vandcity",textBox44.Text);
            cmd.Parameters.AddWithValue("vandph",textBox43.Text);
            cmd.Parameters.AddWithValue("vandcountry",textBox42.Text);
            cmd.Parameters.AddWithValue("vandrel",textBox41.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Data has been Updated", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            this.textBox48.Clear();
            this.textBox44.Clear();
            this.textBox43.Clear();
            this.textBox42.Clear();
            this.textBox41.Clear();
            cmd = new SqlCommand("select * from vander", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox6.Items.Add(dr["vandid"]);
            }
            cls.conn.Close();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from nokia_mobail where nmdid='" + comboBox6.Text + "'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox50.Text = (dr["nmmodel"]).ToString();
            }
            cls.conn.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home hom = new Home();
            hom.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up SU = new Sign_Up();
            SU.ShowDialog();
        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void groupBox21_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from vander where vandid='" + comboBox7.Text + "'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox48.Text = (dr["vandname"]).ToString();
                this.textBox44.Text = (dr["vandcity"]).ToString();
                this.textBox43.Text = (dr["vandph"]).ToString();
                this.textBox42.Text = (dr["vandcountry"]).ToString();
                this.textBox41.Text = (dr["vandrel"]).ToString();
            }
            cls.conn.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from vander where vandid='" + comboBox1.Text + "'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                //chart1.DataBindTable(dr, "vandid");
                this.textBox51.Text = (dr["vandname"]).ToString();
            }
            cls.conn.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer where cusdid='" + comboBox2.Text + "'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox52.Text = (dr["cusname"]).ToString();
            }
            cls.conn.Close();
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from nokia_mobail where nmdid='" + comboBox5.Text + "'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox55.Text = (dr["nmmodel"]).ToString();
            }
            cls.conn.Close();
        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("select * from customer where cusdid='" + comboBox8.Text + "'", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.textBox62.Text = (dr["cusname"]).ToString();
                this.textBox49.Text = (dr["cuscity"]).ToString();
                this.textBox47.Text = (dr["cusph"]).ToString();
                this.textBox46.Text = (dr["cuscountry"]).ToString();
                this.textBox45.Text = (dr["cusrel"]).ToString();
            }
            cls.conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cls.conn.Open();
            SqlCommand cmd = new SqlCommand("update customer set cusname=@cusname,cuscountry=@cuscountry,cusrel=@cusrel,cusph=@cusph,cuscity=@cuscity where cusdid='"+comboBox8.Text+"'", cls.conn);
            cmd.Parameters.AddWithValue("cusname",textBox62.Text);
            cmd.Parameters.AddWithValue("cuscity",textBox49.Text);
            cmd.Parameters.AddWithValue("cusph",textBox47.Text);
            cmd.Parameters.AddWithValue("cuscountry",textBox46.Text);
            cmd.Parameters.AddWithValue("cusrel",textBox45.Text);
            cmd.ExecuteScalar();
            MessageBox.Show("Data has been Updated", "Command Succesfull", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            this.textBox62.Clear();
            this.textBox49.Clear();
            this.textBox47.Clear();
            this.textBox46.Clear();
            this.textBox45.Clear();
            cmd = new SqlCommand("select * from customer", cls.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.comboBox6.Items.Add(dr["cusdid"]);
            }
            cls.conn.Close();
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
                    }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Professional p = new Professional();
            p.ShowDialog();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sign_Up su = new Sign_Up();
            su.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tabPage11_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox50_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox48_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {

        }

        }
}
