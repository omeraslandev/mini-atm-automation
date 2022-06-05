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
    public partial class frmHavale : Form
    {
        public frmHavale()
        {
            InitializeComponent();
        }

        SqlBaglantisi Baglanti = new SqlBaglantisi();//SqlBaglantisi sınıfımızdan nesne türetiyoruz.

        private void txtPara_TextChanged(object sender, EventArgs e)// Para değerimizi aldığımız textbox her değiştiğinde,
        {
            btnGonder.Text = txtPara.Text + " " + "Tl Gönder";//Örneğin textboxdaki değerimiz '250' ise, butonumuzda '250 Tl Gönder' yazısı gözükecektir.
        }

        void Temizle()//Bütün textboxlarımızı silmek için yazdığımız metod.
        {
            txtAd.Clear(); //Ad değerini aldığımız textboxı temizle.
            txtSoyad.Clear(); //Soyad değerini aldığımız textboxı temizle.
            txtTel.Clear(); //Telefon değerini aldığımız textboxı temizle.
            txtPara.Clear(); //Para değerini aldığımız textboxı temizle.
        }

        public int Bakiye(string Ad, string Soyad, string Telefon)//Havale göndereceğimiz kişinin bakiyesine ulaşmak için metod.
        {
            Baglanti.Baglan.Open();// Bağlantımızı açıyoruz.

            string Sorgu = "select * from Kisi where telefon=@tel and ad=@ad and soyad=@soyad";
            SqlCommand Komut = new SqlCommand(Sorgu, Baglanti.Baglan);// Belirleyeceğimiz ad, soyad ve telefon değerlerine sahip kaydı seçen sorguyu yazdık.

            Komut.Parameters.AddWithValue("@ad", Ad); //@ad parametresini, Ad değişkenimdeki değerle doldur.
            Komut.Parameters.AddWithValue("@soyad", Soyad); //@soyad parametresini, Soyad değişkenimdeki değerle doldur.
            Komut.Parameters.AddWithValue("@tel", Telefon); //@tel parametresini, Telefon değişkenimdeki değerle doldur.

            SqlDataReader BilgiOkuyucu = Komut.ExecuteReader();//Gösterilen sonucu SqlDataReader'a attık.

            while (BilgiOkuyucu.Read())//DataReader'ımız kayıt bulduğu sürece,
            {
                int bakiye = int.Parse(BilgiOkuyucu["bakiye"].ToString());//Bulduğu kayıttaki bakiye değerini 'bakiye' ismine sahip int değişkenine gönderecek.

                Baglanti.Baglan.Close(); // Bağlantımızı kapatıyoruz

                return bakiye; // Metodumuzun değerini bakiye değerimiz olarak döndürüyoruz.
            }

            //Eğer while döngüsüne girmezse veya bakiye değerini bulamazsa, 'return bakiye;' komudu çalışmayacak ve derleyici direkt bu kod satırına geçecek.
            //Eğer bakiye kaydı bulursa zaten return komuduyla bundan önce çoktan metoddan çıkmış olacak ve buralara kadar gelmeyecek.

            Baglanti.Baglan.Close();// Bağlantımızı kapatıyoruz

            return -1;
            /*Geriye değer döndüren bir metod olduğu için bir değer döndürmemiz gerekiyor. '-1' değerini döndürdük ve programımızın ilerleyen aşamalarında
            * eğer bu metoddan dönen değer '-1' ise gibi işlemler yapacağız.
            */
        }

        void Havale(int Para)// Havale işlemi için tanımladığımız geriye değer döndürmeyen metod.
        {
            //Programımızın daha okunabilir ve anlaşılır olması için, textboxlarımızdan gelen verilerimizi değişkenlerimize attık.
            string Ad = txtAd.Text;
            string Soyad = txtSoyad.Text;
            string Telefon = txtTel.Text;
            int HavaleYapilacakKisininBakiyesi = Bakiye(txtAd.Text, txtSoyad.Text, txtTel.Text);//Havale yapacağımız kullanıcının bakiyesini 'HavaleYapilacakKisininBakiyesi' değişkenine attık.

            Baglanti.Baglan.Open();// Bağlantımızı açıyoruz.

            string Sorgu = "update Kisi set bakiye=@bakiye where telefon=@tel and ad=@ad and soyad=@soyad";
            SqlCommand Gonder_Komut = new SqlCommand(Sorgu, Baglanti.Baglan);//Havalesi yapılacak kişinin bakiyesini güncelleyecek sorguyu yazdık.

            Gonder_Komut.Parameters.AddWithValue("@bakiye", HavaleYapilacakKisininBakiyesi + Para); //@bakiye parametresini, kişinin bakiyesiyle havale yapılacak paranın toplamıyla doldur. Yani en güncel bakiyeyle.
            Gonder_Komut.Parameters.AddWithValue("@ad", Ad);//@ad parametresini, Ad değişkenimdeki değerle doldur.
            Gonder_Komut.Parameters.AddWithValue("@soyad", Soyad);//@soyad parametresini, Soyad değişkenimdeki değerle doldur.
            Gonder_Komut.Parameters.AddWithValue("@tel", Telefon);//@ad parametresini, Telefon değişkenimdeki değerle doldur.

            Gonder_Komut.ExecuteNonQuery(); //Sql'de yaptığımız gibi komudumuzu yürütebilmek için, ExecuteNonQuery() metodunu çağırıyoruz. Bununla birlikte sorgumuz Execute ediliyor.

            Sorgu = "update Kisi set bakiye=@tutar where telefon=@tel"; //Paramızı attık, şimdi parayı atan hesaptan para eksiltelim.

            SqlCommand Cek_Komut = new SqlCommand(Sorgu, Baglanti.Baglan); //Giriş yapmış olduğumuz hesaba telefon bilgisiyle erişip bakiye bilgisini güncelleyen sorguyu yazıyoruzç

            Cek_Komut.Parameters.AddWithValue("@tutar", Kisi.Bakiye - Para); //@tutar parametresini, Kisi sınıfımızdaki Bakiye değerinden, 'Para' değişkeninin çıkarılmasıyla ortaya çıkan sayıyla doldur.
            Cek_Komut.Parameters.AddWithValue("@tel", Kisi.Telefon);//@tel parametresini, Kisi sınıfımızdaki Telefon değişkenimdeki değerle doldur.

            Cek_Komut.ExecuteNonQuery(); //Komudumuzu yürütüyoruz.

            Kisi.Bakiye = Kisi.Bakiye - Para; //Sınıfımızdaki bakiye bilgisini güncelliyoruz.

            MessageBox.Show("Havale işlemi başarılı."); //Havale işleminin başarılı olduğunu kullanıcıya bildiriyoruz.

            Baglanti.Baglan.Close();//Bağlantımızı kapatıyoruz.
        }

        public bool BireyselHavaleKontrol()//Kullanıcının kendi kendine havale yapmasını önlemek için yazdığımız metod.
        {
            if (txtAd.Text == Kisi.Ad && txtSoyad.Text == Kisi.Soyad && txtTel.Text == Kisi.Telefon)//Koşulumuz.
            {
                //Eğer kullanıcı kendi kendine havale yapmaya çalışıyorsa bir uyarı yazısı çıkacak ve sistem kullanıcıya, kullanıcının kendisine para yatırmasını önerecek.
                DialogResult dialog = MessageBox.Show("Kendinize havale yapamazsınız. Hesabınıza para yatırmak istiyorsanız 'Evet'e tıklayın.", "Sistem", MessageBoxButtons.YesNo);


                if (dialog == DialogResult.Yes) //Eğer çıkan uyarıda 'Evet' tuşuna tıklandıysa,
                {
                    frmParaYatirma ParaYatir = new frmParaYatirma();//ParaYatir formumuzdan nesne türetiyoruz.

                    ParaYatir.Show();//Para Yatırma Ekranımızı açıyoruz.

                    this.Hide();//Bu ekranı gizliyoruz.

                    return true;//Ve olumsuz bir durum olduğu için hata kontrolünden True sonucunu döndürüyoruz.
                }

                return true;//Eğer çıkan uyarıda 'Hayır' tuşuna tıkladıysa veya uyarıyı kapattıysa olumsuz bir durum olduğu için hata kontrolünden True sonucunu döndürüyoruz.
            }

            return false;//Hiçbir problem yoksa derleyici bu kod satırına inecektir ve False değeri dönecektir.
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            bool Hata = false;//Hata durumunu tutmak için bir değişken tanımlıyoruz.

            if (Bakiye(txtAd.Text, txtSoyad.Text, txtTel.Text) == -1)//Bu metodda eğer kullanıcı bulunmazsa -1 değeri döndüren algoritmayı tasarlamıştık. Eğer -1 değeri dönerse yani kullanıcı bulunamazsa,
            {
                Hata = true;//Hata durumumuz True oluyor.
                MessageBox.Show("Kullanıcı bulunamadı.");//Kullancıya uyarıyı iletiyoruz.
            }
            if (BireyselHavaleKontrol() == true) Hata = true;//Eğer kullanıcı kendi kendine havale göndermek istiyorsa Hata durumumuz True oluyor.

            if (Hata == false)//Eğer bir tane bile hata durumu ortaya çıktıysa bu değişken True olmuştur.
                              //Ama yukarıya yazdığımız koşulların hiçbiri gerçekleşmediyse bu değişkenin değerine de hiçbir şey dokunamayacaktır.
                              //Bu sebeple eğer Hata durumumuz ilk tanımladığımız gibi False'sa,
            {
                try//Şunu dene,
                {
                    if (Kisi.Bakiye < int.Parse(txtPara.Text))//Havale yapacağı tutar bakiyesinden büyükse,
                    {
                        MessageBox.Show("Bu kadar paranız yok, işlem iptal edildi. Hesaptaki paranız: " + Kisi.Bakiye.ToString());//Uyarı mesajı
                    }
                    else
                    {
                        Havale(int.Parse(txtPara.Text));//Burada try-catch kullanma sebebi şu, textbox'dan gelen veriyi int'e çevirmeye çalışıyoruz.
                                                        //Ve '' , ' ' , '.' gibi karakterler int'e çevrilemediği gibi 'asdasd' gibi harfler de çevrilemez.
                                                        //Biz bakiye değerini güncellemek istediğimiz için tam sayı değerlerine ihtiyacımız var.
                                                        //Bu sebeple eğer textboxdan gelen veri sorunsuz bir şekilde int'e çevrilebiliyorsa programımız çalışmaya devam edebilir.
                        Temizle();//Bütün textboxlardaki yazıyı sil.
                    }
                }
                catch
                {
                    MessageBox.Show("Lütfen geçerli bir bakiye giriniz."); //Kullanıcıya uyarıyı iletiyoruz.
                }
            }

        }
    }
}
