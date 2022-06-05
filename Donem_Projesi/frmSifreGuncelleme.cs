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
    public partial class frmSifreGuncelleme : Form
    {
        public frmSifreGuncelleme()
        {
            InitializeComponent();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Komutlar Komutlar = new Komutlar();//Komutlar sınıfından nesne türettik.

            Komutlar.Guncelle("sifre", txtSifre.Text, Kisi.Sifre);//Güncelleme işlemini yaptık, açıklaması Komutlar sınıfında.

            MessageBox.Show("Şifreniz başarıyla güncellendi!");

            Kisi.Sifre = txtSifre.Text;//Sınıfımızdaki değişkenini güncelledik.
        }
    }
}
