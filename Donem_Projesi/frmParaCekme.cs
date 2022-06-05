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
    public partial class frmParaCekme : Form
    {
        public frmParaCekme()
        {
            InitializeComponent();
        }
        void ParaCek(int Para)
        {
            SqlBaglantisi Baglanti = new SqlBaglantisi();//Bağlantı dizemizi kullanabilmek için bağlantı dizemizi tanıttığımız sınıftan nesne türettik.

            Baglanti.Baglan.Open();//Bağlantımızı açıyoruz.

            string Sorgu = "update Kisi set bakiye=@tutar where telefon=@tel";
            SqlCommand Komut = new SqlCommand(Sorgu, Baglanti.Baglan);//@tel parametresindeki değere sahip kaydın bakiyesini güncelleyen sorguyu yazdık.

            Komut.Parameters.AddWithValue("@tutar", Kisi.Bakiye - Para);//@tutar parametresini, sistemdeki mevcut bakiyeyle, çekilmek istenen tutarın çıkarımıyla doldur.
            Komut.Parameters.AddWithValue("@tel", Kisi.Telefon);//@tel parametresini, sistemdeki telefon numarasıyla doldur.

            Komut.ExecuteNonQuery();//Komudu yürüt.

            Kisi.Bakiye = Kisi.Bakiye - Para;//Sınıfımızdaki bakiye değerini güncelleyelim.

            MessageBox.Show("Para çekme işlemi başarılı! " + Para + " tl çektiniz ve hesabınızda " + Kisi.Bakiye.ToString() + "tl kaldı.");//Uyarı mesajı
        }

        public bool Hata(int Para)
        {
            if (Para > Kisi.Bakiye)//Çekilmek istenen tutarın mevcut bakiyeden fazla olup olmadığını kontrol ediyoruz.
            {
                MessageBox.Show("Bu kadar paranız yok, para çekme işlemi iptal edildi.");
                return true;//Eğer bu koşul çalışırsa, metodumuz True değeri döndürecektir.
            }
            if (Kisi.Bakiye == 0)//Kişinin para çekebilmesi için biraz parası olması gerekiyor. Kişinin parası var mı kontrol ediyoruz.
            {
                MessageBox.Show("Hiç paranız yok, para çekmek için önce para yüklemelisiniz.");
                return true;//Eğer bu koşul çalışırsa, metodumuz True değeri döndürecektir.
            }
            if (Para % 10 != 0)//Çekeceği para 10 ve katlarında mı kontrol ediyoruz.
            {
                MessageBox.Show("Çekmek istediğiniz tutar 10 ve katlarında olmalıdır, para çekme işlemi iptal edildi.");
                return true;//Eğer bu koşul çalışırsa, metodumuz True değeri döndürecektir.
            }

            return false;//Eğer hiçbir koşula girmediyse hiçbir sorun yok demektir. O zaman False dönsün.
        }
        
        private void txtPara_TextChanged(object sender, EventArgs e)// Para değerimizi aldığımız textbox her değiştiğinde,
        {
            btnCek.Text = txtPara.Text + " " + "Tl Çek";//Örneğin textboxdaki değerimiz '250' ise, butonumuzda '250 Tl Çek' yazısı gözükecektir.
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            int Tutar = 0;
            bool HataDurum = false;

            /*Programımızın daha okunabilir ve anlaşılır olması için, textboxdan gelen veriyi Tutar ismindeki değişkene attık ve textboxa girilen verinin
            * sayı olup olmadığını kontrol ettik.
            */
            try { Tutar = int.Parse(txtPara.Text); }//Para değeri int'e çevrilemiyorsa tam sayı değil demektir.
            catch {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");//Uyarı mesajı
                HataDurum = true;
            }

            if (Hata(Tutar) == true)//Metodumuz True değeri döndürdüyse HataDurum değişkenimize True değerini atayalım.
                HataDurum = true;

            else if(HataDurum == false)//Eğer bir tane bile hata yoksa, para çekme işlemi gerçekleşsin!
                ParaCek(Tutar);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if(Hata(10) == false)//Hata yoksa para çekme işlemi gerçekleşsin.
                ParaCek(10);
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            if (Hata(20) == false)
                ParaCek(20);
        }

        private void btn50_Click(object sender, EventArgs e)
        {
            if (Hata(50) == false)
                ParaCek(50);
        }

        private void btn100_Click(object sender, EventArgs e)
        {
            if (Hata(100) == false)
                ParaCek(100);
        }

        private void btn200_Click(object sender, EventArgs e)
        {
            if (Hata(200) == false)
                ParaCek(200);
        }

        private void btn500_Click(object sender, EventArgs e)
        {
            if (Hata(500) == false)
                ParaCek(500);
        }

        private void lnkGiris_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmMenu menu = new frmMenu();//frmMenu formundan nesne türetiyoruz.

            menu.Show();//Menü ekranı açılsın.

            this.Hide();//Bu ekran gizlensin.
        }
    }
}
