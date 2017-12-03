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
    public partial class NMISS : Form
    {
        public NMISS()
        {
            InitializeComponent();
        }

        private void NMISS_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Professional f3 = new Professional();
            f3.ShowDialog();
        }
    }
}
