namespace Donem_Projesi
{
    partial class frmFatura
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
            this.btnOde = new System.Windows.Forms.Button();
            this.cmbFaturaTur = new System.Windows.Forms.ComboBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Raleway", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(130, 112);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(227, 90);
            this.btnOde.TabIndex = 27;
            this.btnOde.Text = "Öde";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // cmbFaturaTur
            // 
            this.cmbFaturaTur.Font = new System.Drawing.Font("Raleway", 12F, System.Drawing.FontStyle.Italic);
            this.cmbFaturaTur.FormattingEnabled = true;
            this.cmbFaturaTur.Location = new System.Drawing.Point(239, 51);
            this.cmbFaturaTur.Name = "cmbFaturaTur";
            this.cmbFaturaTur.Size = new System.Drawing.Size(197, 30);
            this.cmbFaturaTur.TabIndex = 0;
            this.cmbFaturaTur.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFaturaTur_KeyPress);
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Raleway", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.ForeColor = System.Drawing.Color.LightGray;
            this.lblTelefon.Location = new System.Drawing.Point(32, 52);
            this.lblTelefon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(200, 29);
            this.lblTelefon.TabIndex = 26;
            this.lblTelefon.Text = "Fatura türünü seçin.";
            // 
            // frmFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(480, 250);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.cmbFaturaTur);
            this.Name = "frmFatura";
            this.ShowIcon = false;
            this.Text = "Fatura Ödeme Ekranı";
            this.Load += new System.EventHandler(this.frmFatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.ComboBox cmbFaturaTur;
        private System.Windows.Forms.Label lblTelefon;
    }
}