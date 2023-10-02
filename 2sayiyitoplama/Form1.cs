using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2sayiyitoplama
{
    public partial class fom1 : Form
    {
        public fom1()
        {
            InitializeComponent();
        }

        private void textSayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int sonuc = sayi1 + sayi2;

            lblSonuc.Text = sonuc.ToString();
            lblSonuc.Text = "İki Sayıyı Toplama:" + sonuc.ToString();




               
             
        }
    }
}
