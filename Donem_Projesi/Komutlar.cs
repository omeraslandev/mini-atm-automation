using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //C# üzerinden sql komutlarını yazabilmemiz için bu kütüphaneyi içe aktarmamız gerekiyor.

namespace Donem_Projesi
{
    public class Komutlar
    {
        SqlBaglantisi Baglanti = new SqlBaglantisi();

        public bool TekrarKontrol(string Telefon)
        {
            Baglanti.Baglan.Open(); // Bağlantımızı açtık.

            string Sorgu = "select * from Kisi where telefon=@telefon"; //@telefon parametresine sahip telefon kayıtlarını göster.

            SqlCommand Komut = new SqlCommand(Sorgu, Baglanti.Baglan); //Sorgumuzu SqlCommand'a attık.

            Komut.Parameters.AddWithValue("@telefon", Telefon); //@telefon parametresini, Telefon değişkenimdeki değerle doldur.

            SqlDataReader BilgiOkuyucu = Komut.ExecuteReader(); //Görüntülenen bilgiyi bir SqlDataReader'a attık. SqlDataReader sayesinde bu böyle bir kayıt var mı yok mu görebileceğiz.

            if (BilgiOkuyucu.Read()) // Okunabiliyorsa, yani yazmış olduğumuz where şartı eğer gerçekleşiyorsa bu telefon numarasına sahip bir kayıt görüntüleniyorsa,
            {
                Baglanti.Baglan.Close(); // Bağlantımızı kapattık.
                return true; // Metodumuzdan True değeri döndürdük.
            }

            else // Böyle bir kayıt yoksa,
            {
                Baglanti.Baglan.Close(); // Bağlantımızı kapattık.
                return false; // Metodumuzdan False değeri döndürdük.
            }
        }
        public void GirisYap(string Telefon)
        {
            Baglanti.Baglan.Open();

            SqlCommand Komut = new SqlCommand("select * from Kisi where telefon=@tel", Baglanti.Baglan);// Parametremize girdiğimiz telefon numarasındaki kaydı listeledik.

            Komut.Parameters.AddWithValue("@tel", Telefon);//@telefon parametresine Telefon değişkenindeki değeri attık.

            SqlDataReader BilgiOkuyucu = Komut.ExecuteReader();//Gösterilen sonucu SqlDataReader'a attık.

            while (BilgiOkuyucu.Read())//DataReader'ımız kayıt bulduğu sürece,
            {
                Kisi.ID = int.Parse(BilgiOkuyucu["id"].ToString());//Bulduğu kayıttaki id değerini Kisi sınıfımızdaki ID değişkenine gönderecek.
                Kisi.Ad = BilgiOkuyucu["ad"].ToString();//Bulduğu kayıttaki ad değerini Kisi sınıfımızdaki Ad değişkenine gönderecek.
                Kisi.Soyad = BilgiOkuyucu["soyad"].ToString();//Bulduğu kayıttaki soyad değerini Kisi sınıfımızdaki Soyad değişkenine gönderecek.
                Kisi.Sifre = BilgiOkuyucu["sifre"].ToString();//Bulduğu kayıttaki sifre değerini Kisi sınıfımızdaki Sifre değişkenine gönderecek.
                Kisi.Telefon = BilgiOkuyucu["telefon"].ToString();//Bulduğu kayıttaki telefon değerini Kisi sınıfımızdaki Telefon değişkenine gönderecek.
                Kisi.Bakiye = int.Parse(BilgiOkuyucu["bakiye"].ToString());//Bulduğu kayıttaki bakiye değerini Kisi sınıfımızdaki Bakiye değişkeninea gönderecek.
                break;//Döngüyü kır.
            }

            Baglanti.Baglan.Close();// Bağlantımızı kapattık.
        }
        public void Guncelle(string Tag, string NewText, string OldText)//Bilgi güncellemek için kullanacağımız metod.
        {
            Baglanti.Baglan.Open();//Bağlantımızı açıyoruz.

            /* Tag değişkeni, bizim sql sütununda hangi değeri değiştireceğimizdir. Yani telefon numarasını değiştirmek için "telefon" değerini atayabiliriz buraya.
             * NewText ise, Tag değişkenimize atayacağımız değerdir.
             * Örneğin '05555555555' telefon numarasına sahip bir telefon numarasını '05111111111' olarak değiştirecekseniz,
             * Buradaki '05111111111' bizim NewText'imizdir.
             * '05555555555' ise OldText'imizdir.
             * Yani örnek kullanımı: Guncelle("telefon","05111111111","05555555555");
             */

            string Sorgu = "update Kisi set "+Tag+"=@NewTag where "+Tag+"=@OldTag";
            SqlCommand cmd = new SqlCommand(Sorgu, Baglanti.Baglan);//Açıkladığımız algoritmanın sorgusunu yazdık.

            cmd.Parameters.AddWithValue("@NewTag", NewText);
            cmd.Parameters.AddWithValue("@OldTag", OldText);//Parametrelere atamaları gerçekleştirdik.

            cmd.ExecuteNonQuery();//Komudumuzu yürüttük.

            Baglanti.Baglan.Close();//Bağlantımızı kapatalım.
        }
    }
}
