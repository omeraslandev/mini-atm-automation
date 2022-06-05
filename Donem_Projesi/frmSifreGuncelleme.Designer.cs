namespace Donem_Projesi
{
    partial class frmSifreGuncelleme
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
            this.lbSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnGüncelle.Location = new System.Drawing.Point(106, 103);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(507, 158);
            this.btnGüncelle.TabIndex = 40;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lbSifre
            // 
            this.lbSifre.AutoSize = true;
            this.lbSifre.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSifre.ForeColor = System.Drawing.Color.LightGray;
            this.lbSifre.Location = new System.Drawing.Point(36, 47);
            this.lbSifre.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lbSifre.Name = "lbSifre";
            this.lbSifre.Size = new System.Drawing.Size(97, 29);
            this.lbSifre.TabIndex = 39;
            this.lbSifre.Text = "Yeni Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.txtSifre.Location = new System.Drawing.Point(149, 50);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(9, 7, 9, 7);
            this.txtSifre.MaxLength = 16;
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(549, 26);
            this.txtSifre.TabIndex = 38;
            // 
            // frmSifreGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(745, 314);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.lbSifre);
            this.Controls.Add(this.txtSifre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmSifreGuncelleme";
            this.ShowIcon = false;
            this.Text = "Şifre Güncelleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lbSifre;
        private System.Windows.Forms.TextBox txtSifre;
    }
}