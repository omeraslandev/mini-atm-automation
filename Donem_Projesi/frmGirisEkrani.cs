using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //C# üzerinden sql komutlarını yazabilmemiz için bu kütüphaneyi içe aktarmamız gerekiyor.

namespace Donem_Projesi
{
    public partial class frmGirisEkrani : Form
    {
        public frmGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)//btnGirisYap butonuna tıklandığında,
        {
            SqlBaglantisi Baglanti = new SqlBaglantisi();//Bağlantı dizemizi kullanabilmek için bağlantı dizemizi tanıttığımız sınıftan nesne türettik.
            Komutlar komutlar = new Komutlar();//Bazı komutlar için kullanmış olduğumuz sınıftan nesne türettik.

            //Programımızın daha okunabilir ve anlaşılır olması için, textboxlarımızdan gelen verilerimizi değişkenlerimize attık.
            string Sifre = txtSifre.Text;
            string Telefon = txtTelefon.Text;

            Baglanti.Baglan.Open(); //Bağlantımızı açtık.

            string Sorgu = "select * from Kisi where telefon=@tel and sifre=@sifre";
            SqlCommand Komut = new SqlCommand(Sorgu, Baglanti.Baglan);//Yazacağımız @tel ve @sifre parametrelerine sahip kaydı seçen sorguyu yazıyoruz.

            Komut.Parameters.AddWithValue("@tel", Telefon);//@tel parametresini, Telefon değişkeniyle doldur.
            Komut.Parameters.AddWithValue("@sifre", Sifre);//@sifre parametresini, Sifre değişkeniyle doldur.

            SqlDataReader BilgiOkuyucu = Komut.ExecuteReader();//Görüntülenen bilgiyi bir SqlDataReader'a attık. SqlDataReader sayesinde bu böyle bir kayıt var mı yok mu görebileceğiz.

            if (BilgiOkuyucu.Read())// Okunabiliyorsa, yani yazmış olduğumuz where şartı eğer gerçekleşiyorsa bu değerlere sahip bir kayıt görüntüleniyorsa,
            {
                komutlar.GirisYap(Telefon);//GirisYap metoduyla kullanıcını bütün bilgilerini Kisi sınıfımıza aktarıyoruz.

                MessageBox.Show("Giriş başarılı!");//Girişin başarılı olduğunu kullanıcıya bildiriyoruz.

                frmParaCekme ParakCekmeEkrani = new frmParaCekme();//Para çekme ekranından nesne türetiyoruz.

                ParakCekmeEkrani.Show();//Para çekme ekranını açıyoruz.
                this.Hide();//Bu ekranı gizliyoruz.
            }
            else
            {
                MessageBox.Show("Bu kayıt bilgilerine sahip bir kullanıcı yok. Lütfen bilgilerinizi gözden geçirin veya kayıt olun.");
            }

            Baglanti.Baglan.Close(); //Bağlantımızı kapattık.
        }

        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//lnkKayitOl link labeline tıklandığında,
        {
            frmKayitEkrani KayitEkrani = new frmKayitEkrani();//Kayıt ekranını açabilmek için kayıt ekranı formundan bir nesne türetmemiz gerekiyor. 

            KayitEkrani.ShowDialog();
        }

        private void frmGirisEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }
    }
}
