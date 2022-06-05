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
    public partial class frmSoyadGuncelleme : Form
    {
        public frmSoyadGuncelleme()
        {
            InitializeComponent();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Komutlar Komutlar = new Komutlar();//Komutlar sınıfından nesne türettik.

            Komutlar.Guncelle("soyad", txtSoyad.Text, Kisi.Soyad);//Güncelleme işlemini yaptık, açıklaması Komutlar sınıfında.

            MessageBox.Show("Soyadınız başarıyla güncellendi! Eski soyadınız: " + Kisi.Soyad + " Yeni soyadınız ise: " + txtSoyad.Text);

            Kisi.Soyad = txtSoyad.Text;//Sınıfımızdaki değişkenini güncelledik.
        }
    }
}
