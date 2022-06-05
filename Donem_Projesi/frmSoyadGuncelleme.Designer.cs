namespace Donem_Projesi
{
    partial class frmSoyadGuncelleme
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
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.lbSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnGüncelle.Location = new System.Drawing.Point(96, 91);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(471, 128);
            this.btnGüncelle.TabIndex = 34;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lbSoyad
            // 
            this.lbSoyad.AutoSize = true;
            this.lbSoyad.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSoyad.ForeColor = System.Drawing.Color.LightGray;
            this.lbSoyad.Location = new System.Drawing.Point(24, 41);
            this.lbSoyad.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(116, 29);
            this.lbSoyad.TabIndex = 33;
            this.lbSoyad.Text = "Yeni Soyad";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.txtSoyad.Location = new System.Drawing.Point(152, 44);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtSoyad.MaxLength = 50;
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(504, 26);
            this.txtSoyad.TabIndex = 32;
            // 
            // frmSoyadGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(725, 271);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.lbSoyad);
            this.Controls.Add(this.txtSoyad);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSoyadGuncelleme";
            this.ShowIcon = false;
            this.Text = "Soyad Güncelleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lbSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
    }
}