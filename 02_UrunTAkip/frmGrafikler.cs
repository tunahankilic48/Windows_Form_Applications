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
    public partial class frmGrafikler : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-A10URF2\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");
        public frmGrafikler()
        {
            InitializeComponent();
        }

        private void frmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select Ad, Count(*) from TblUrunler inner join TblKategori\r\non TblUrunler.Kategori = TblKategori.ID\r\ngroup by Ad ",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chart1.Series["Kategori"].Points.AddXY(dr[0], dr[1]);
            }
            baglanti.Close();

        }
    }
}
