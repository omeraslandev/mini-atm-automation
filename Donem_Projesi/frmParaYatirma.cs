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
    public partial class frmParaYatirma : Form
    {
        public frmParaYatirma()
        {
            InitializeComponent();
        }

        private void txtPara_TextChanged(object sender, EventArgs e)//txtPara her değiştiğinde,
        {
            btnYatir.Text = txtPara.Text + " " + "Tl Yatır";//Örneğin textboxdaki değerimiz '250' ise, butonumuzda '250 Tl Yatır' yazısı gözükecektir.
        }

        private void btnYatir_Click(object sender, EventArgs e)
        {
            int Tutar = 0;
            bool Hata = false;

            /*Programımızın daha okunabilir ve anlaşılır olması için, textboxdan gelen veriyi Tutar ismindeki değişkene attık ve textboxa girilen verinin
            * sayı olup olmadığını kontrol ettik.
            */
            try { Tutar = int.Parse(txtPara.Text); }//Eğer para değerimiz int'e çevrildiğinde hata alıyorsak,
            catch
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.");//Uyarı mesajı
                Hata = true;//Hata durumumuz True olsun.
            }

            if(Hata == false)//Eğer Hatamız yoksa işlemi gerçekleştirebiliriz.
            {
                SqlBaglantisi Baglanti = new SqlBaglantisi();//Bağlantı dizemizi kullanabilmek için bağlantı dizemizi tanıttığımız sınıftan nesne türettik.

                Baglanti.Baglan.Open();//Bağlantımızı açalım.

                string Sorgu = "update Kisi set bakiye=@tutar where telefon=@tel";
                SqlCommand Komut = new SqlCommand(Sorgu, Baglanti.Baglan);//Where koşulunda belirttiğimiz telefon değerine sahip kaydın bakiye tutarını @bakiye parametresindeki değerle güncelleyen sorguyu yazdık.

                Komut.Parameters.AddWithValue("@tutar", Kisi.Bakiye + Tutar);//@tutar parametresini, sistemdeki kullanıcının mevcut bakiyesiyle yatırılacak bakiyenin toplamıyla doldurduk.
                Komut.Parameters.AddWithValue("@tel", Kisi.Telefon);//@tel parametresini, sistemdeki kullancının telefon numarasıyla doldurduk.

                Komut.ExecuteNonQuery();//Komudumuzu yürüttük.

                Kisi.Bakiye = Kisi.Bakiye + Tutar;//Sınıfımızdaki bakiye değerini güncelledik.

                MessageBox.Show("Para yatırma işlemi başarılı! " + Tutar + " tl yatırdınız ve artık hesabınızda " + Kisi.Bakiye.ToString() + "tl var!");//Kullanıcıya mesajı ilettik.
            }
        }
    }
    
}
