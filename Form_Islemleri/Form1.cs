namespace Form_Islemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void KodOlustur()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(10000, 100000);
            txtCaptcha.Text = sayi.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KodOlustur();
            timer1.Start();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if(txtKullaniciAdi.Text == "admin" && txtSifre.Text == "1234" && txtCaptchaGiris.Text == txtCaptcha.Text)
            {
                Form2 frm = new Form2();
                frm.kullaniciAdi = txtKullaniciAdi.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalý Giriþ Yapýldý!!", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linklblSifremiUnuttum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
            
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if (sayac % 2 == 0)
            {
                lblAdminLoginForm.BackColor = Color.DarkBlue;
            }
            else
            {
                lblAdminLoginForm.BackColor = Color.Yellow;
            }
            if (sayac == 10)
            {
                sayac = 0;
            }
        }
    }
}