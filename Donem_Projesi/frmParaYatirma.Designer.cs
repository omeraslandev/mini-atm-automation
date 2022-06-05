namespace Donem_Projesi
{
    partial class frmParaYatirma
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
            this.btnYatir = new System.Windows.Forms.Button();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYatir
            // 
            this.btnYatir.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYatir.Location = new System.Drawing.Point(46, 98);
            this.btnYatir.Name = "btnYatir";
            this.btnYatir.Size = new System.Drawing.Size(414, 80);
            this.btnYatir.TabIndex = 28;
            this.btnYatir.Text = "Tl Yatır";
            this.btnYatir.UseVisualStyleBackColor = true;
            this.btnYatir.Click += new System.EventHandler(this.btnYatir_Click);
            // 
            // txtPara
            // 
            this.txtPara.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPara.Location = new System.Drawing.Point(46, 65);
            this.txtPara.Margin = new System.Windows.Forms.Padding(4);
            this.txtPara.MaxLength = 50;
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(414, 26);
            this.txtPara.TabIndex = 21;
            this.txtPara.TextChanged += new System.EventHandler(this.txtPara_TextChanged);
            // 
            // frmParaYatirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(528, 245);
            this.Controls.Add(this.btnYatir);
            this.Controls.Add(this.txtPara);
            this.Name = "frmParaYatirma";
            this.ShowIcon = false;
            this.Text = "Para Yatırma Ekranı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnYatir;
        private System.Windows.Forms.TextBox txtPara;
    }
}