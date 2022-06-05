namespace Donem_Projesi
{
    partial class frmAdGuncelleme
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
            this.lbAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic);
            this.btnGüncelle.Location = new System.Drawing.Point(89, 74);
            this.btnGüncelle.Margin = new System.Windows.Forms.Padding(5);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(486, 140);
            this.btnGüncelle.TabIndex = 31;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbAd.ForeColor = System.Drawing.Color.LightGray;
            this.lbAd.Location = new System.Drawing.Point(53, 35);
            this.lbAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(82, 29);
            this.lbAd.TabIndex = 30;
            this.lbAd.Text = "Yeni Ad";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.txtAd.Location = new System.Drawing.Point(144, 38);
            this.txtAd.Margin = new System.Windows.Forms.Padding(5);
            this.txtAd.MaxLength = 50;
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(488, 26);
            this.txtAd.TabIndex = 29;
            // 
            // frmAdGuncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(709, 271);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.lbAd);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAdGuncelleme";
            this.ShowIcon = false;
            this.Text = "Ad Güncelleme Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.TextBox txtAd;
    }
}