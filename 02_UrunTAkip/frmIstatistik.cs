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
    public partial class frmIstatistik : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A10URF2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        public frmIstatistik()
        {
            InitializeComponent();
        }

        private void frmIstatistik_Load(object sender, EventArgs e)
        {
            // Toplam Kategori Sayısı
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from TblKategori", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblToplamKategori.Text = dr1[0].ToString();
            }
            baglanti.Close();

            // Toplam Ürün Sayısı
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from TblUrunler", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblToplamUrunSayisi.Text = dr2[0].ToString();
            }
            baglanti.Close();

            // En Yüksek Stoklu Ürün
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("select* from TblUrunler where Stok = (select max(stok) from TblUrunler)", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblEnYuksekStokluUrunSayisi.Text = dr3[1].ToString();
            }
            baglanti.Close();

            // En Düşük Stoklu Ürün
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("select* from TblUrunler where Stok = (select min(stok) from TblUrunler)", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                lblEnDusukStokSayiliUrun.Text += dr4[1].ToString() + "\n";
            }
            baglanti.Close();

            // Toplam Beyaz Eşya Sayısı
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("select count(*) from TblUrunler where Kategori = (select ID From TblKategori where Ad = 'Beyaz Eşya')", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblToplamBeyazEsyaSayisi.Text = dr5[0].ToString();


            }
            baglanti.Close();

            // Toplam Küçük Ev Aletleri Sayısı
            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select count(*) from TblUrunler where Kategori = (select ID From TblKategori where Ad = 'Küçük ev aletleri')", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblToplamKucukEvAletleriSayisi.Text = dr6[0].ToString();

            }
            baglanti.Close();

            // Laptopların Toplam Karı
            baglanti.Open();
            SqlCommand komut7 = new SqlCommand("select stok*(SatisFiyat - AlisFiyat) from TblUrunler where UrunAd = 'Laptop'", baglanti);
            SqlDataReader dr7 = komut7.ExecuteReader();
            while (dr7.Read())
            {
                lblLaptopToplamKar.Text = dr7[0].ToString() + " ₺";

            }
            baglanti.Close();

            // Beyaz Eşyaların Toplam Karı
            baglanti.Open();
            SqlCommand komut8 = new SqlCommand("select Sum(stok*(SatisFiyat-AlisFiyat)) from TblUrunler where Kategori = (select ID From TblKategori where Ad = 'Beyaz Eşya')", baglanti);
            SqlDataReader dr8 = komut8.ExecuteReader();
            while (dr8.Read())
            {
                lblBeyazEsyaToplamKar.Text = dr8[0].ToString() + " ₺";

            }
            baglanti.Close();


            
            
        }
    }
}
