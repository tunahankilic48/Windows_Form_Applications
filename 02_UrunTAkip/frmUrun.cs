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
    
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A10URF2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select UrunID, UrunAd, Stok, AlisFiyat, SatisFiyat, Ad, Kategori from TblUrunler\r\nInner join TblKategori\r\non TblUrunler.Kategori = TblKategori.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["Kategori"].Visible = false;
        }

        private void frmUrun_Load(object sender, EventArgs e)
        {
            
            SqlCommand komut2 = new SqlCommand("Select * from TblKategori", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            cmbKategori.DisplayMember = "Ad";
            cmbKategori.ValueMember = "ID";
            cmbKategori.DataSource = dt2;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("insert into TblUrunler (Ad, Stok, AlisFiyat, SatisFiyat, Kategori) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut3.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            komut3.Parameters.AddWithValue("@p2", nudStok.Value);
            komut3.Parameters.AddWithValue("@p3", txtAlisFiyati.Text);
            komut3.Parameters.AddWithValue("@p4", txtSatisFiyati.Text);
            komut3.Parameters.AddWithValue("@p5", cmbKategori.SelectedValue);
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("delete from TblUrunler where UrunID = @p1", baglanti);
            komut4.Parameters.AddWithValue("@p1", txtUrunId.Text);
            komut4.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("istediğiniz Ürünün silme işlemi başarılır bir şekilde gerçekleşti!");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUrunId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUrunAdi.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            nudStok.Value = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            txtAlisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSatisFiyati.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            cmbKategori.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value. ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("update TblUrunler set UrunAd = @p1, Stok = @p2, AlisFiyat = @p3, SatisFiyat = @p4, Kategori = @p5 where UrunID = @p6",baglanti);
            komut5.Parameters.AddWithValue("@p1", txtUrunAdi.Text);
            komut5.Parameters.AddWithValue("@p2", nudStok.Value);
            komut5.Parameters.AddWithValue("@p3", decimal.Parse(txtAlisFiyati.Text));
            komut5.Parameters.AddWithValue("@p4", decimal.Parse( txtSatisFiyati.Text));
            komut5.Parameters.AddWithValue("@p5", cmbKategori.SelectedValue);
            komut5.Parameters.AddWithValue("@p6", txtUrunId.Text);
            komut5.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme işlemi başarıyla gerçekleştirildi.");
        }
    }
}
