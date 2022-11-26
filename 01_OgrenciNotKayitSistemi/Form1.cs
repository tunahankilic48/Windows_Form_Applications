namespace _01_OgrenciNotKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            double sinav1 = Convert.ToDouble(txtSinav1.Text);
            double sinav2 = Convert.ToDouble(txtSinav2.Text);
            double sinav3 = Convert.ToDouble(txtSinav3.Text);
            double ortalama = (sinav1 + sinav2 + sinav3) / 3;
            txtOrtalama.Text = ortalama.ToString();
            if (ortalama < 50)
            {
                txtDurum.Text = "Kaldý";
            }
            else
            {
                txtDurum.Text = "Geçti";
            }
            btnHesapla.Enabled = false;
            btnKaydet.Enabled = true;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtOrtalama.Text != "")
            {
                string adSoyad = txtAdSoyad.Text;
                string ders = cmbDers.Text;
                string numara = maskedTextBox1.Text;
                string[] ogrenciBilgileri = new string[] { adSoyad, ders, numara, txtOrtalama.Text, txtDurum.Text };
                string ogrenci = $"{adSoyad} - {ders} - {numara} - {txtOrtalama.Text} - {txtDurum.Text} ";
                listBox1.Items.Add(ogrenci);
                listBox1.Items.Add(new String('-', 60));
                btnKaydet.Enabled = false;

            }
            else
            {
                MessageBox.Show("Lütfen Öncelikle Sýnav Notlarýnýzý Girerek Ortalamanýzý Hesaplayýnýz!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnKaydet.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnKaydet.Enabled = false;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtAdSoyad.Clear();
            txtDurum.Clear();
            txtOrtalama.Clear();
            txtSinav1.Clear();
            txtSinav2.Clear();
            txtSinav3.Clear();
            cmbDers.SelectedIndex = -1;
            maskedTextBox1.Clear();
            txtAdSoyad.Focus();
            btnHesapla.Enabled = true;
        }
    }
}