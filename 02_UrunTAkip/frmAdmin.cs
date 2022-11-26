using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _02_UrunTAkip
{
    public partial class frmAdmin : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A10URF2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from TblAdmin where Kullanici = @p1 and Sifre = @p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if(dr.Read())
            {
                frmYonlendirme frmYonlendirme = new frmYonlendirme();
                frmYonlendirme.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!\nLütfen yeniden deneyiniz!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            txtKullaniciAdi.Clear();
            txtSifre.Clear();
            baglanti.Close();
        }
    }
}
