namespace Donem_Projesi
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnHakkında = new System.Windows.Forms.Button();
            this.btnFatura = new System.Windows.Forms.Button();
            this.btnBilgiGuncelleme = new System.Windows.Forms.Button();
            this.btnHavale = new System.Windows.Forms.Button();
            this.btnParaCekme = new System.Windows.Forms.Button();
            this.btnParaYukleme = new System.Windows.Forms.Button();
            this.cmbBilgiTur = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHakkında
            // 
            this.btnHakkında.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHakkında.Location = new System.Drawing.Point(500, 219);
            this.btnHakkında.Name = "btnHakkında";
            this.btnHakkında.Size = new System.Drawing.Size(224, 155);
            this.btnHakkında.TabIndex = 33;
            this.btnHakkında.Text = "Hakkında";
            this.btnHakkında.UseVisualStyleBackColor = true;
            this.btnHakkında.Click += new System.EventHandler(this.btnHakkında_Click);
            // 
            // btnFatura
            // 
            this.btnFatura.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFatura.Location = new System.Drawing.Point(40, 219);
            this.btnFatura.Name = "btnFatura";
            this.btnFatura.Size = new System.Drawing.Size(224, 155);
            this.btnFatura.TabIndex = 32;
            this.btnFatura.Text = "Fatura Ödeme";
            this.btnFatura.UseVisualStyleBackColor = true;
            this.btnFatura.Click += new System.EventHandler(this.btnFatura_Click_1);
            // 
            // btnBilgiGuncelleme
            // 
            this.btnBilgiGuncelleme.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBilgiGuncelleme.Location = new System.Drawing.Point(270, 219);
            this.btnBilgiGuncelleme.Name = "btnBilgiGuncelleme";
            this.btnBilgiGuncelleme.Size = new System.Drawing.Size(224, 155);
            this.btnBilgiGuncelleme.TabIndex = 31;
            this.btnBilgiGuncelleme.Text = "Bilgi Güncelleme";
            this.btnBilgiGuncelleme.UseVisualStyleBackColor = true;
            this.btnBilgiGuncelleme.Click += new System.EventHandler(this.btnBilgiGuncelleme_Click);
            // 
            // btnHavale
            // 
            this.btnHavale.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHavale.Location = new System.Drawing.Point(500, 58);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(224, 155);
            this.btnHavale.TabIndex = 30;
            this.btnHavale.Text = "Havale";
            this.btnHavale.UseVisualStyleBackColor = true;
            this.btnHavale.Click += new System.EventHandler(this.btnHavale_Click);
            // 
            // btnParaCekme
            // 
            this.btnParaCekme.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCekme.Location = new System.Drawing.Point(40, 58);
            this.btnParaCekme.Name = "btnParaCekme";
            this.btnParaCekme.Size = new System.Drawing.Size(224, 155);
            this.btnParaCekme.TabIndex = 29;
            this.btnParaCekme.Text = "Para Çekme";
            this.btnParaCekme.UseVisualStyleBackColor = true;
            this.btnParaCekme.Click += new System.EventHandler(this.btnParaCekme_Click);
            // 
            // btnParaYukleme
            // 
            this.btnParaYukleme.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYukleme.Location = new System.Drawing.Point(270, 58);
            this.btnParaYukleme.Name = "btnParaYukleme";
            this.btnParaYukleme.Size = new System.Drawing.Size(224, 155);
            this.btnParaYukleme.TabIndex = 28;
            this.btnParaYukleme.Text = "Para Yatırma";
            this.btnParaYukleme.UseVisualStyleBackColor = true;
            this.btnParaYukleme.Click += new System.EventHandler(this.btnParaYukleme_Click);
            // 
            // cmbBilgiTur
            // 
            this.cmbBilgiTur.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.cmbBilgiTur.FormattingEnabled = true;
            this.cmbBilgiTur.Items.AddRange(new object[] {
            "Ad",
            "Soyad",
            "Telefon",
            "Şifre"});
            this.cmbBilgiTur.Location = new System.Drawing.Point(270, 380);
            this.cmbBilgiTur.Name = "cmbBilgiTur";
            this.cmbBilgiTur.Size = new System.Drawing.Size(224, 30);
            this.cmbBilgiTur.TabIndex = 34;
            this.cmbBilgiTur.Text = "Güncellenecek Bilgi?";
            this.cmbBilgiTur.SelectedIndexChanged += new System.EventHandler(this.cmbBilgiTur_SelectedIndexChanged);
            this.cmbBilgiTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBilgiTur_KeyPress);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(791, 443);
            this.Controls.Add(this.cmbBilgiTur);
            this.Controls.Add(this.btnHakkında);
            this.Controls.Add(this.btnFatura);
            this.Controls.Add(this.btnBilgiGuncelleme);
            this.Controls.Add(this.btnHavale);
            this.Controls.Add(this.btnParaCekme);
            this.Controls.Add(this.btnParaYukleme);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMenu";
            this.ShowIcon = false;
            this.Text = "Menü";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHakkında;
        private System.Windows.Forms.Button btnFatura;
        private System.Windows.Forms.Button btnBilgiGuncelleme;
        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.Button btnParaCekme;
        private System.Windows.Forms.Button btnParaYukleme;
        private System.Windows.Forms.ComboBox cmbBilgiTur;
    }
}