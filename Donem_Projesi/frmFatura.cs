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
    public partial class frmFatura : Form
    {
        public frmFatura()
        {
            InitializeComponent();
        }

        private void frmFatura_Load(object sender, EventArgs e)
        {
            cmbFaturaTur.Items.Add("Elektrik");
            cmbFaturaTur.Items.Add("Su");
            cmbFaturaTur.Items.Add("Doğalgaz");
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            if(cmbFaturaTur.Text != "")//Fatura tipi seçildi mi kontrol ediyoruz.
            {
                if(Kisi.Bakiye > 50)//Fatura ödeyecek kadar bakiye var mı kontrol ediyoruz.
                {
                    SqlBaglantisi Baglanti = new SqlBaglantisi();//Bağlantı dizemizi kullanabilmek için bağlantı dizemizi tanıttığımız sınıftan nesne türettik.

                    Baglanti.Baglan.Open();//Bağlantımızı açıyoruz.

                    string Sorgu = "update Kisi set bakiye=@tutar where telefon=@tel";
                    SqlCommand Komut = new SqlCommand(Sorgu, Baglanti.Baglan);//@tel parametresindeki değere sahip kaydın bakiyesini güncelleyen sorguyu yazdık.

                    Komut.Parameters.AddWithValue("@tutar", Kisi.Bakiye - 50);//@tutar parametresini, sistemdeki mevcut bakiyeyle, çekilmek istenen tutarın çıkarımıyla doldur.
                    Komut.Parameters.AddWithValue("@tel", Kisi.Telefon);//@tel parametresini, sistemdeki telefon numarasıyla doldur.

                    Komut.ExecuteNonQuery();//Komudu yürüt.

                    Kisi.Bakiye = Kisi.Bakiye - 50;//Sınıfımızdaki bakiye değerini güncelleyelim.

                    MessageBox.Show("Fatura ödeme işlemi başarılı! Hesabınızda " + Kisi.Bakiye.ToString() + "tl kaldı.");//Uyarı mesajı

                    Baglanti.Baglan.Close();//Bağlantımızı kapatıyoruz.
                }
                else//Yoksa, işlem gerçekleşmez ve program hata verir.
                {
                    MessageBox.Show("Faturanızı ödeyecek kadar paranız yok.");
                }
            }
            else//Seçilmediyse, işlem gerçekleşmez ve program hata verir.
            {
                MessageBox.Show("Lütfen fatura tipi seçin.");
            }
        }

        private void cmbFaturaTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//Combobox'ın itemleri dışında bir metin girilmesini engelledik.
        }
    }
}
