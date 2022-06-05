using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donem_Projesi
{
    public partial class frmAdGuncelleme : Form
    {
        public frmAdGuncelleme()
        {
            InitializeComponent();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Komutlar Komutlar = new Komutlar();//Komutlar sınıfından nesne türettik.

            Komutlar.Guncelle("ad", txtAd.Text, Kisi.Ad);//Güncelleme işlemini yaptık, açıklaması Komutlar sınıfında.

            MessageBox.Show("Adınız başarıyla güncellendi! Eski adınız: " + Kisi.Ad + " Yeni adınız ise: " + txtAd.Text);

            Kisi.Ad = txtAd.Text;//Sınıfımızdaki değişkenini güncelledik.
        }
    }
}
