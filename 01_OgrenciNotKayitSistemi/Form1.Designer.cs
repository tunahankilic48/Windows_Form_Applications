namespace _01_OgrenciNotKayitSistemi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblOgrenciNotKayitSistemi = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblDers = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cmbDers = new System.Windows.Forms.ComboBox();
            this.lblSinav1 = new System.Windows.Forms.Label();
            this.lblSinav2 = new System.Windows.Forms.Label();
            this.lblSinav3 = new System.Windows.Forms.Label();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.txtSinav1 = new System.Windows.Forms.TextBox();
            this.txtSinav2 = new System.Windows.Forms.TextBox();
            this.txtSinav3 = new System.Windows.Forms.TextBox();
            this.txtOrtalama = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtDurum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOgrenciNotKayitSistemi
            // 
            this.lblOgrenciNotKayitSistemi.AutoSize = true;
            this.lblOgrenciNotKayitSistemi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblOgrenciNotKayitSistemi.Font = new System.Drawing.Font("Lucida Handwriting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOgrenciNotKayitSistemi.ForeColor = System.Drawing.Color.White;
            this.lblOgrenciNotKayitSistemi.Location = new System.Drawing.Point(351, 9);
            this.lblOgrenciNotKayitSistemi.Name = "lblOgrenciNotKayitSistemi";
            this.lblOgrenciNotKayitSistemi.Size = new System.Drawing.Size(472, 40);
            this.lblOgrenciNotKayitSistemi.TabIndex = 0;
            this.lblOgrenciNotKayitSistemi.Text = "Ogrenci Not Kayıt Sistemi";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(32, 74);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(94, 25);
            this.lblAdSoyad.TabIndex = 1;
            this.lblAdSoyad.Text = "Ad Soyad:";
            // 
            // lblDers
            // 
            this.lblDers.AutoSize = true;
            this.lblDers.Location = new System.Drawing.Point(74, 135);
            this.lblDers.Name = "lblDers";
            this.lblDers.Size = new System.Drawing.Size(52, 25);
            this.lblDers.TabIndex = 2;
            this.lblDers.Text = "Ders:";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(132, 71);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(251, 31);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // cmbDers
            // 
            this.cmbDers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDers.FormattingEnabled = true;
            this.cmbDers.Items.AddRange(new object[] {
            "Algoritma",
            "Yapay Zeka",
            "Biçimsel Diller",
            "Mikroişlemciler"});
            this.cmbDers.Location = new System.Drawing.Point(132, 132);
            this.cmbDers.Name = "cmbDers";
            this.cmbDers.Size = new System.Drawing.Size(251, 33);
            this.cmbDers.TabIndex = 2;
            // 
            // lblSinav1
            // 
            this.lblSinav1.AutoSize = true;
            this.lblSinav1.Location = new System.Drawing.Point(457, 77);
            this.lblSinav1.Name = "lblSinav1";
            this.lblSinav1.Size = new System.Drawing.Size(73, 25);
            this.lblSinav1.TabIndex = 5;
            this.lblSinav1.Text = "Sınav 1:";
            // 
            // lblSinav2
            // 
            this.lblSinav2.AutoSize = true;
            this.lblSinav2.Location = new System.Drawing.Point(457, 135);
            this.lblSinav2.Name = "lblSinav2";
            this.lblSinav2.Size = new System.Drawing.Size(73, 25);
            this.lblSinav2.TabIndex = 6;
            this.lblSinav2.Text = "Sınav 2:";
            // 
            // lblSinav3
            // 
            this.lblSinav3.AutoSize = true;
            this.lblSinav3.Location = new System.Drawing.Point(457, 181);
            this.lblSinav3.Name = "lblSinav3";
            this.lblSinav3.Size = new System.Drawing.Size(73, 25);
            this.lblSinav3.TabIndex = 7;
            this.lblSinav3.Text = "Sınav 3:";
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(679, 80);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(89, 25);
            this.lblOrtalama.TabIndex = 8;
            this.lblOrtalama.Text = "Ortalama:";
            // 
            // txtSinav1
            // 
            this.txtSinav1.Location = new System.Drawing.Point(536, 77);
            this.txtSinav1.Name = "txtSinav1";
            this.txtSinav1.Size = new System.Drawing.Size(125, 31);
            this.txtSinav1.TabIndex = 4;
            // 
            // txtSinav2
            // 
            this.txtSinav2.Location = new System.Drawing.Point(536, 132);
            this.txtSinav2.Name = "txtSinav2";
            this.txtSinav2.Size = new System.Drawing.Size(125, 31);
            this.txtSinav2.TabIndex = 5;
            // 
            // txtSinav3
            // 
            this.txtSinav3.Location = new System.Drawing.Point(536, 181);
            this.txtSinav3.Name = "txtSinav3";
            this.txtSinav3.Size = new System.Drawing.Size(125, 31);
            this.txtSinav3.TabIndex = 6;
            // 
            // txtOrtalama
            // 
            this.txtOrtalama.Enabled = false;
            this.txtOrtalama.Location = new System.Drawing.Point(774, 77);
            this.txtOrtalama.Name = "txtOrtalama";
            this.txtOrtalama.Size = new System.Drawing.Size(125, 31);
            this.txtOrtalama.TabIndex = 12;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(391, 234);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(144, 49);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(602, 234);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(154, 49);
            this.btnTemizle.TabIndex = 9;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(194, 234);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(146, 49);
            this.btnKaydet.TabIndex = 8;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(26, 304);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1116, 204);
            this.listBox1.TabIndex = 16;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(47, 181);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(79, 25);
            this.lblNumara.TabIndex = 17;
            this.lblNumara.Text = "Numara:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 181);
            this.maskedTextBox1.Mask = "00000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(251, 31);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(946, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(697, 135);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(71, 25);
            this.lblDurum.TabIndex = 8;
            this.lblDurum.Text = "Durum:";
            // 
            // txtDurum
            // 
            this.txtDurum.Enabled = false;
            this.txtDurum.Location = new System.Drawing.Point(774, 132);
            this.txtDurum.Name = "txtDurum";
            this.txtDurum.Size = new System.Drawing.Size(125, 31);
            this.txtDurum.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 526);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.lblNumara);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtDurum);
            this.Controls.Add(this.txtOrtalama);
            this.Controls.Add(this.txtSinav3);
            this.Controls.Add(this.txtSinav2);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.txtSinav1);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblSinav3);
            this.Controls.Add(this.lblSinav2);
            this.Controls.Add(this.lblSinav1);
            this.Controls.Add(this.cmbDers);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblDers);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.lblOgrenciNotKayitSistemi);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblOgrenciNotKayitSistemi;
        private Label lblAdSoyad;
        private Label lblDers;
        private TextBox txtAdSoyad;
        private ComboBox cmbDers;
        private Label lblSinav1;
        private Label lblSinav2;
        private Label lblSinav3;
        private Label lblOrtalama;
        private TextBox txtSinav1;
        private TextBox txtSinav2;
        private TextBox txtSinav3;
        private TextBox txtOrtalama;
        private Button btnHesapla;
        private Button btnTemizle;
        private Button btnKaydet;
        private ListBox listBox1;
        private Label lblNumara;
        private MaskedTextBox maskedTextBox1;
        private PictureBox pictureBox1;
        private Label lblDurum;
        private TextBox txtDurum;
    }
}