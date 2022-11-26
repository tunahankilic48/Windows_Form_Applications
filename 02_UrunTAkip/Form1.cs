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

namespace _02_UrunTAkip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A10URF2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        private void btnListele_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("Select * From TblKategori", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("insert into TblKategori (Ad) values (@p1)", baglanti);
            komut2.Parameters.AddWithValue("@p1", txtKategoriAdi.Text);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori adı başarılı bir şekilde eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from TblKategori where ID = @p1", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtId.Text);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme işlemi başarıyla gerçekleşti.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("update TblKategori set Ad = @p1 where ID = @p2", baglanti);
            komut4.Parameters.AddWithValue("@p1", txtKategoriAdi.Text);
            komut4.Parameters.AddWithValue("@p2", txtId.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori güncelleme işlemi başarıyla gerçekleşti.");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut5 = new SqlCommand("Select * From TblKategori where Ad = @p1", baglanti);
            komut5.Parameters.AddWithValue("@p1", txtKategoriAdi.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut5);

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }
    }
}

// Data Source=DESKTOP-A10URF2\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True
