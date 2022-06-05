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
    public partial class frmTelefonGuncelleme : Form
    {
        public frmTelefonGuncelleme()
        {
            InitializeComponent();
        }
        public bool Hata(string Telefon)
        {
            Komutlar Komutlar = new Komutlar();

            try { double.Parse(Telefon); }//Eğer telefon değeri double'a dönüştüğünde hata veriyorsa, geçerli bir telefon numarası değildir.
            catch
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.");//Hata verdiyse kullanıcıya mesajı iletelim.
                return true;//Hata durumu True olsun.
            }

            try//Substring metodu kullandığımız için eğer text 0 karakter olursa hata alıyoruz. bunu önlemek amacıyla try-catch kullandık.
            {
                if (Telefon.Substring(0, 2) != "05")//Eğer telefon değeri '05' ile başlamıyorsa ve daha önceden bir hatayla karşılaşılmadıysa,
                {
                    MessageBox.Show("Lütfen telefon numaranızı '05' ile başlayacak şekilde girin.");//Uyarı mesajı

                    return true;//Hata durumu True olsun.
                }
            }//Eğer text 0 karakterse hata vermiştir ve Hata durumu True olsun.
            catch { return true; }

            if (Telefon.Length != 11)//Eğer telefon numarası 11 değilde örneğin 7'se, geçerli bir telefon numarası değildir. Telefon değerinin 11 karakter olup olmadığını ve hata durumunu kontrol ediyoruz.
            {
                MessageBox.Show("Lütfen geçerli uzunlukta bir telefon numarası girin.");//Uyarı mesajı
                return true;//Hata durumu True olsun.
            }

            if (Komutlar.TekrarKontrol(Telefon) == true) //Eğer girilen telefon numarasına sahip bir kayıt varsa,
            {
                MessageBox.Show("Bu telefon numarası zaten kayıtlı!"); //Kullanıcıya, kayıtlı olan bir telefon numarasıyla tekrar kaydolamayacağını bildiriyoruz.
                return true;
            }


            return false;
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if(Hata(txtTelefon.Text) == false)
            {
                Komutlar Komutlar = new Komutlar();//Komutlar sınıfından nesne türettik.

                Komutlar.Guncelle("telefon", txtTelefon.Text, Kisi.Telefon);//Güncelleme işlemini yaptık, açıklaması Komutlar sınıfında.

                MessageBox.Show("Telefon numaranız başarıyla güncellendi! Eski telefon numaranız: " + Kisi.Telefon + " Yeni telefon numaranız ise: " + txtTelefon.Text);

                Kisi.Telefon = txtTelefon.Text;//Sınıfımızdaki değişkenini güncelledik.
            }
        }
    }
}
