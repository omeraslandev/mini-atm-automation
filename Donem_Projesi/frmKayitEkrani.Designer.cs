namespace Donem_Projesi
{
    partial class frmKayitEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnKaydol = new System.Windows.Forms.Button();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSifre = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lnkGiris = new System.Windows.Forms.LinkLabel();
            this.btnGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(108, 44);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(234, 26);
            this.txtAd.TabIndex = 0;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.txtSoyad.Location = new System.Drawing.Point(108, 76);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(234, 26);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.txtSifre.Location = new System.Drawing.Point(108, 108);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(4);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(197, 26);
            this.txtSifre.TabIndex = 2;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.txtTelefon.Location = new System.Drawing.Point(108, 140);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefon.MaxLength = 11;
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(234, 26);
            this.txtTelefon.TabIndex = 3;
            this.txtTelefon.Text = "05";
            // 
            // btnKaydol
            // 
            this.btnKaydol.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnKaydol.Location = new System.Drawing.Point(73, 196);
            this.btnKaydol.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydol.Name = "btnKaydol";
            this.btnKaydol.Size = new System.Drawing.Size(242, 93);
            this.btnKaydol.TabIndex = 4;
            this.btnKaydol.Text = "Kaydol";
            this.btnKaydol.UseVisualStyleBackColor = true;
            this.btnKaydol.Click += new System.EventHandler(this.btnKaydol_Click);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.LightGray;
            this.lblTelefon.Location = new System.Drawing.Point(13, 134);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(82, 29);
            this.lblTelefon.TabIndex = 21;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.ForeColor = System.Drawing.Color.LightGray;
            this.lblSifre.Location = new System.Drawing.Point(41, 105);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(54, 29);
            this.lblSifre.TabIndex = 20;
            this.lblSifre.Text = "Şifre";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.ForeColor = System.Drawing.Color.LightGray;
            this.lblSoyad.Location = new System.Drawing.Point(22, 76);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(73, 29);
            this.lblSoyad.TabIndex = 19;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.ForeColor = System.Drawing.Color.LightGray;
            this.lblAd.Location = new System.Drawing.Point(55, 44);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(40, 29);
            this.lblAd.TabIndex = 18;
            this.lblAd.Text = "Ad";
            // 
            // lnkGiris
            // 
            this.lnkGiris.AutoSize = true;
            this.lnkGiris.LinkColor = System.Drawing.Color.Cyan;
            this.lnkGiris.Location = new System.Drawing.Point(70, 293);
            this.lnkGiris.Name = "lnkGiris";
            this.lnkGiris.Size = new System.Drawing.Size(66, 17);
            this.lnkGiris.TabIndex = 22;
            this.lnkGiris.TabStop = true;
            this.lnkGiris.Text = "Giriş Yap";
            this.lnkGiris.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkGiris_LinkClicked);
            // 
            // btnGor
            // 
            this.btnGor.BackgroundImage = global::Donem_Projesi.Properties.Resources.NicePng_png_eye_463537;
            this.btnGor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGor.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnGor.Location = new System.Drawing.Point(313, 108);
            this.btnGor.Margin = new System.Windows.Forms.Padding(4);
            this.btnGor.Name = "btnGor";
            this.btnGor.Size = new System.Drawing.Size(29, 26);
            this.btnGor.TabIndex = 23;
            this.btnGor.UseVisualStyleBackColor = true;
            this.btnGor.Click += new System.EventHandler(this.btnGor_Click);
            // 
            // frmKayitEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(373, 364);
            this.Controls.Add(this.btnGor);
            this.Controls.Add(this.lnkGiris);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnKaydol);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmKayitEkrani";
            this.ShowIcon = false;
            this.Text = "Kayıt Ekranı";
            this.Load += new System.EventHandler(this.frmKayitEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnKaydol;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.LinkLabel lnkGiris;
        private System.Windows.Forms.Button btnGor;
    }
}

