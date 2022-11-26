namespace Form_Islemleri
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.linklblSifremiUnuttum = new System.Windows.Forms.LinkLabel();
            this.lblAdminLoginForm = new System.Windows.Forms.Label();
            this.lblKoduGirin = new System.Windows.Forms.Label();
            this.txtCaptchaGiris = new System.Windows.Forms.TextBox();
            this.txtCaptcha = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(16, 110);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(124, 28);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(146, 110);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(277, 34);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(146, 285);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 32);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Location = new System.Drawing.Point(146, 377);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(254, 52);
            this.btnGirisYap.TabIndex = 6;
            this.btnGirisYap.Text = "Giris Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(16, 176);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(55, 28);
            this.lblSifre.TabIndex = 0;
            this.lblSifre.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(146, 173);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(277, 34);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // linklblSifremiUnuttum
            // 
            this.linklblSifremiUnuttum.AutoSize = true;
            this.linklblSifremiUnuttum.Location = new System.Drawing.Point(146, 332);
            this.linklblSifremiUnuttum.Name = "linklblSifremiUnuttum";
            this.linklblSifremiUnuttum.Size = new System.Drawing.Size(156, 28);
            this.linklblSifremiUnuttum.TabIndex = 5;
            this.linklblSifremiUnuttum.TabStop = true;
            this.linklblSifremiUnuttum.Text = "Şifremi Unuttum";
            this.linklblSifremiUnuttum.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblSifremiUnuttum_LinkClicked);
            // 
            // lblAdminLoginForm
            // 
            this.lblAdminLoginForm.AutoSize = true;
            this.lblAdminLoginForm.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAdminLoginForm.ForeColor = System.Drawing.Color.Red;
            this.lblAdminLoginForm.Location = new System.Drawing.Point(70, 9);
            this.lblAdminLoginForm.Name = "lblAdminLoginForm";
            this.lblAdminLoginForm.Size = new System.Drawing.Size(344, 42);
            this.lblAdminLoginForm.TabIndex = 8;
            this.lblAdminLoginForm.Text = "Admin Login Form";
            // 
            // lblKoduGirin
            // 
            this.lblKoduGirin.AutoSize = true;
            this.lblKoduGirin.Location = new System.Drawing.Point(16, 241);
            this.lblKoduGirin.Name = "lblKoduGirin";
            this.lblKoduGirin.Size = new System.Drawing.Size(106, 28);
            this.lblKoduGirin.TabIndex = 9;
            this.lblKoduGirin.Text = "Kodu Girin";
            // 
            // txtCaptchaGiris
            // 
            this.txtCaptchaGiris.Location = new System.Drawing.Point(146, 238);
            this.txtCaptchaGiris.Name = "txtCaptchaGiris";
            this.txtCaptchaGiris.Size = new System.Drawing.Size(125, 34);
            this.txtCaptchaGiris.TabIndex = 3;
            // 
            // txtCaptcha
            // 
            this.txtCaptcha.Enabled = false;
            this.txtCaptcha.Location = new System.Drawing.Point(298, 238);
            this.txtCaptcha.Name = "txtCaptcha";
            this.txtCaptcha.Size = new System.Drawing.Size(125, 34);
            this.txtCaptcha.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(500, 591);
            this.Controls.Add(this.txtCaptcha);
            this.Controls.Add(this.txtCaptchaGiris);
            this.Controls.Add(this.lblKoduGirin);
            this.Controls.Add(this.lblAdminLoginForm);
            this.Controls.Add(this.linklblSifremiUnuttum);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.btnGirisYap);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblKullaniciAdi;
        private TextBox txtKullaniciAdi;
        private CheckBox checkBox1;
        private Button btnGirisYap;
        private Label lblSifre;
        private TextBox txtSifre;
        private LinkLabel linklblSifremiUnuttum;
        private Label lblAdminLoginForm;
        private Label lblKoduGirin;
        private TextBox txtCaptchaGiris;
        private TextBox txtCaptcha;
        private System.Windows.Forms.Timer timer1;
    }
}