using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Islemleri
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string kullaniciAdi;

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text = kullaniciAdi;
        }
    }
}
