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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            frmParaCekme ParaCekme = new frmParaCekme();

            ParaCekme.Show();//Para çekme ekranı açılsın.
        }

        private void btnParaYukleme_Click(object sender, EventArgs e)
        {
            frmParaYatirma ParaYatirma = new frmParaYatirma();

            ParaYatirma.Show();//Para yatırma ekranı açılsın.
        }

        private void btnHavale_Click(object sender, EventArgs e)
        {
            frmHavale havale = new frmHavale();

            havale.Show();//Havale ekranı açılsın.
        }

        private void btnFatura_Click(object sender, EventArgs e)
        {
            frmFatura Fatura = new frmFatura();

            Fatura.Show();//Fatura ekranı açılsın.
        }

        private void cmbBilgiTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Tur = cmbBilgiTur.Text;

            if(Tur == "Ad")
            {
                frmAdGuncelleme ad = new frmAdGuncelleme();

                ad.Show();
            }
            else if(Tur == "Soyad")
            {
                frmSoyadGuncelleme soyad = new frmSoyadGuncelleme();

                soyad.Show();
            }
            else if(Tur == "Şifre")
            {
                frmSifreGuncelleme sifre = new frmSifreGuncelleme();

                sifre.Show();
            }
            else if(Tur == "Telefon")
            {
                frmTelefonGuncelleme tel = new frmTelefonGuncelleme();

                tel.Show();
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            cmbBilgiTur.Visible = false;
        }

        private void btnBilgiGuncelleme_Click(object sender, EventArgs e)
        {
            cmbBilgiTur.Visible = true;
        }

        private void cmbBilgiTur_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;//Combobox'a dışarıdan metin girilmesini engelledik.
        }

        private void btnHakkında_Click(object sender, EventArgs e)
        {
            frmHakkinda hakkinda = new frmHakkinda();

            hakkinda.Show();
        }

        private void btnFatura_Click_1(object sender, EventArgs e)
        {
            frmFatura fatura = new frmFatura();

            fatura.Show();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
