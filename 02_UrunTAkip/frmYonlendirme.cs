using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_UrunTAkip
{
    public partial class frmYonlendirme : Form
    {
        public frmYonlendirme()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            frmUrun frmUrun = new frmUrun();
            frmUrun.Show();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            frmIstatistik frmIstatistik = new frmIstatistik();
            frmIstatistik.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            frmGrafikler frmGrafikler = new frmGrafikler();
            frmGrafikler.Show();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            frmAdmin frmAdmin = new frmAdmin();
            frmAdmin.Show();
            this.Hide();
        }
    }
}
