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
    public partial class frmKayitEkrani : Form
    {
        public frmKayitEkrani()
        {
            InitializeComponent();
        }
        void Temizle()//Kaydolduktan sonra bütün textbox'larımızı temizleyecek metod.
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtSifre.Clear();
            txtTelefon.Clear();
        }
        public bool Hata(string Telefon)
        {
            Komutlar komutlar = new Komutlar();//Bazı komutlar için kullanmış olduğumuz sınıftan nesne türettik.

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

            if (komutlar.TekrarKontrol(Telefon) == true) //Eğer girilen telefon numarasına sahip bir kayıt varsa,
            {
                MessageBox.Show("Bu telefon numarası zaten kayıtlı!"); //Kullanıcıya, kayıtlı olan bir telefon numarasıyla tekrar kaydolamayacağını bildiriyoruz.
                return true;
            }
            return false;//Eğer hiçbir koşula girmediyse hiçbir sorun yok demektir. Derleyici bu kod satırına kadar indiyse metodumuz false döndürsün.

        }
        private void btnKaydol_Click(object sender, EventArgs e)//Kaydol butonumuza tıkladığımızda oluşacak kodlar
        {
            SqlBaglantisi Baglanti = new SqlBaglantisi();//Bağlantı dizemizi kullanabilmek için bağlantı dizemizi tanıttığımız sınıftan nesne türettik.


            //Programımızın daha okunabilir ve anlaşılır olması için, textboxlarımızdan gelen verilerimizi değişkenlerimize attık.
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            string Sifre = txtSifre.Text;
            string Telefon = txtTelefon.Text;


            if (Hata(Telefon) == false)// Hata yoksa, kayıt işlemlerini yürütmeye başlayabiliriz.
            {
                Baglanti.Baglan.Open(); //Bağlantımızı açtık.

                string Sorgu = "insert into Kisi(ad,soyad,sifre,telefon,bakiye) values(@ad,@soyad,@sifre,@telefon,@bakiye)";
                /*Sql sorgumuzda, tablomuzdaki ad,soyad,sifre,telefon bilgilerini,
                 * @ad,@soyad,@sifre,@telefon parametreleriyle dolduracağımızı söylüyoruz.
                 * Peki id değerimiz nasıl sisteme girilecek?
                 * İd değeri için "identity  specification" özelliğini kullanıyoruz.
                 * Bu özellikle beraber, id sql tarafından otomatik atılıyor.
                 * 1. kaydımız için sistem id değerini "1" olarak atarken,
                 * 67. kaydımız için "67", 1000000. kaydımız için yine id değerini " 1000000" olarak atar.
                 * Bu sebeple biz bir id değeri girişi yapmadan, bu özelliğin kullanım kolaylığından faydalandık.
                 */

                SqlCommand komut = new SqlCommand(Sorgu, Baglanti.Baglan); //Sorgumuzu yürütebilmemiz için gereken SqlCommand komutu. Şimdi sırada parametrelerimizi doldurmak var.

                komut.Parameters.AddWithValue("@ad", Ad); //@ad parametresini, Ad değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@soyad", Soyad); //@soyad parametresini, Soyad değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@sifre", Sifre); //@sifre parametresini, Sifre değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@telefon", Telefon); //@telefon parametresini, Telefon değişkenimdeki değerle doldur.
                komut.Parameters.AddWithValue("@bakiye", 0); //@bakiye parametresini, 0'la doldur. Çünkü henüz hesaba para yüklenmedi.

                komut.ExecuteNonQuery(); //Sql'de yaptığımız gibi komudumuzu yürütebilmek için, ExecuteNonQuery() metodunu çağırıyoruz. Bununla birlikte sorgumuz Execute ediliyor.

                MessageBox.Show("Kayıt başarılı! Giriş yapma sayfasına yönlendiriliyorsunuz..."); //Kaydın başarıyla sisteme aktarıldığını kullanıcıya bildiriyoruz.

                frmGirisEkrani GirisEkrani = new frmGirisEkrani();//Giriş ekranını açabilmek için giriş ekranı formundan bir nesne türetmemiz gerekiyor. Sonuçta her form aslında bir sınıftır.

                GirisEkrani.Show(); //Giriş ekranını göster.
                this.Hide(); //Bu ekranı gizle.

                Temizle();//Bütün textbox'larımız temizlensin!

                Baglanti.Baglan.Close(); //Bağlantımızı kapattık.
            }
        }

        private void lnkGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        int i = 1;

        private void btnGor_Click(object sender, EventArgs e)
        {
            i++;

            if (i % 2 != 0)
                txtSifre.UseSystemPasswordChar = true;
            else
                txtSifre.UseSystemPasswordChar = false;
        }

        private void frmKayitEkrani_Load(object sender, EventArgs e)
        {
            //Application.Exit();
        }
    }
}
