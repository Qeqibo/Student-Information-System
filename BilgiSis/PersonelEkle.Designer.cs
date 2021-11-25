namespace BilgiSis
{
    partial class PersonelEkle
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
            this.textBox_OeSicil = new System.Windows.Forms.TextBox();
            this.textBox_OeAd = new System.Windows.Forms.TextBox();
            this.textBox_OeSoyad = new System.Windows.Forms.TextBox();
            this.textBox_OeTc = new System.Windows.Forms.TextBox();
            this.textBox_OeSifre = new System.Windows.Forms.TextBox();
            this.label_OEAd = new System.Windows.Forms.Label();
            this.label_OESoyad = new System.Windows.Forms.Label();
            this.label_OETc = new System.Windows.Forms.Label();
            this.label_OESicil = new System.Windows.Forms.Label();
            this.label_OEBolum = new System.Windows.Forms.Label();
            this.label_OESifre = new System.Windows.Forms.Label();
            this.button_OeKaydet = new System.Windows.Forms.Button();
            this.comboBox_OeBolum = new System.Windows.Forms.ComboBox();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_OeSicil
            // 
            this.textBox_OeSicil.Location = new System.Drawing.Point(82, 150);
            this.textBox_OeSicil.Name = "textBox_OeSicil";
            this.textBox_OeSicil.Size = new System.Drawing.Size(100, 20);
            this.textBox_OeSicil.TabIndex = 1;
            // 
            // textBox_OeAd
            // 
            this.textBox_OeAd.Location = new System.Drawing.Point(82, 27);
            this.textBox_OeAd.Name = "textBox_OeAd";
            this.textBox_OeAd.Size = new System.Drawing.Size(100, 20);
            this.textBox_OeAd.TabIndex = 2;
            // 
            // textBox_OeSoyad
            // 
            this.textBox_OeSoyad.Location = new System.Drawing.Point(82, 68);
            this.textBox_OeSoyad.Name = "textBox_OeSoyad";
            this.textBox_OeSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_OeSoyad.TabIndex = 3;
            // 
            // textBox_OeTc
            // 
            this.textBox_OeTc.Location = new System.Drawing.Point(82, 109);
            this.textBox_OeTc.Name = "textBox_OeTc";
            this.textBox_OeTc.Size = new System.Drawing.Size(100, 20);
            this.textBox_OeTc.TabIndex = 4;
            this.textBox_OeTc.Tag = "0";
            // 
            // textBox_OeSifre
            // 
            this.textBox_OeSifre.Location = new System.Drawing.Point(82, 211);
            this.textBox_OeSifre.Name = "textBox_OeSifre";
            this.textBox_OeSifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_OeSifre.TabIndex = 5;
            // 
            // label_OEAd
            // 
            this.label_OEAd.AutoSize = true;
            this.label_OEAd.Location = new System.Drawing.Point(12, 30);
            this.label_OEAd.Name = "label_OEAd";
            this.label_OEAd.Size = new System.Drawing.Size(26, 13);
            this.label_OEAd.TabIndex = 6;
            this.label_OEAd.Text = "Ad :";
            // 
            // label_OESoyad
            // 
            this.label_OESoyad.AutoSize = true;
            this.label_OESoyad.Location = new System.Drawing.Point(12, 71);
            this.label_OESoyad.Name = "label_OESoyad";
            this.label_OESoyad.Size = new System.Drawing.Size(43, 13);
            this.label_OESoyad.TabIndex = 7;
            this.label_OESoyad.Text = "Soyad :";
            // 
            // label_OETc
            // 
            this.label_OETc.AutoSize = true;
            this.label_OETc.Location = new System.Drawing.Point(12, 112);
            this.label_OETc.Name = "label_OETc";
            this.label_OETc.Size = new System.Drawing.Size(26, 13);
            this.label_OETc.TabIndex = 8;
            this.label_OETc.Text = "Tc :";
            // 
            // label_OESicil
            // 
            this.label_OESicil.AutoSize = true;
            this.label_OESicil.Location = new System.Drawing.Point(12, 149);
            this.label_OESicil.Name = "label_OESicil";
            this.label_OESicil.Size = new System.Drawing.Size(49, 13);
            this.label_OESicil.TabIndex = 9;
            this.label_OESicil.Text = "Sicil No :";
            // 
            // label_OEBolum
            // 
            this.label_OEBolum.AutoSize = true;
            this.label_OEBolum.Location = new System.Drawing.Point(12, 188);
            this.label_OEBolum.Name = "label_OEBolum";
            this.label_OEBolum.Size = new System.Drawing.Size(42, 13);
            this.label_OEBolum.TabIndex = 10;
            this.label_OEBolum.Text = "Bölüm :";
            // 
            // label_OESifre
            // 
            this.label_OESifre.AutoSize = true;
            this.label_OESifre.Location = new System.Drawing.Point(12, 214);
            this.label_OESifre.Name = "label_OESifre";
            this.label_OESifre.Size = new System.Drawing.Size(34, 13);
            this.label_OESifre.TabIndex = 11;
            this.label_OESifre.Text = "Şifre :";
            // 
            // button_OeKaydet
            // 
            this.button_OeKaydet.Location = new System.Drawing.Point(197, 226);
            this.button_OeKaydet.Name = "button_OeKaydet";
            this.button_OeKaydet.Size = new System.Drawing.Size(75, 23);
            this.button_OeKaydet.TabIndex = 12;
            this.button_OeKaydet.Text = "Kaydet";
            this.button_OeKaydet.UseVisualStyleBackColor = true;
            this.button_OeKaydet.Click += new System.EventHandler(this.button_OeKaydet_Click);
            // 
            // comboBox_OeBolum
            // 
            this.comboBox_OeBolum.FormattingEnabled = true;
            this.comboBox_OeBolum.Location = new System.Drawing.Point(82, 180);
            this.comboBox_OeBolum.Name = "comboBox_OeBolum";
            this.comboBox_OeBolum.Size = new System.Drawing.Size(100, 21);
            this.comboBox_OeBolum.TabIndex = 13;
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(197, 178);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_Guncelle.TabIndex = 14;
            this.button_Guncelle.Text = "Guncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(197, 139);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(75, 23);
            this.button_Sil.TabIndex = 15;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // PersonelEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_Guncelle);
            this.Controls.Add(this.comboBox_OeBolum);
            this.Controls.Add(this.button_OeKaydet);
            this.Controls.Add(this.label_OESifre);
            this.Controls.Add(this.label_OEBolum);
            this.Controls.Add(this.label_OESicil);
            this.Controls.Add(this.label_OETc);
            this.Controls.Add(this.label_OESoyad);
            this.Controls.Add(this.label_OEAd);
            this.Controls.Add(this.textBox_OeSifre);
            this.Controls.Add(this.textBox_OeTc);
            this.Controls.Add(this.textBox_OeSoyad);
            this.Controls.Add(this.textBox_OeAd);
            this.Controls.Add(this.textBox_OeSicil);
            this.Name = "PersonelEkle";
            this.Text = "PersonelEkle";
            this.Load += new System.EventHandler(this.PersonelEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_OeSicil;
        private System.Windows.Forms.TextBox textBox_OeAd;
        private System.Windows.Forms.TextBox textBox_OeSoyad;
        private System.Windows.Forms.TextBox textBox_OeTc;
        private System.Windows.Forms.TextBox textBox_OeSifre;
        private System.Windows.Forms.Label label_OEAd;
        private System.Windows.Forms.Label label_OESoyad;
        private System.Windows.Forms.Label label_OETc;
        private System.Windows.Forms.Label label_OESicil;
        private System.Windows.Forms.Label label_OEBolum;
        private System.Windows.Forms.Label label_OESifre;
        private System.Windows.Forms.Button button_OeKaydet;
        public System.Windows.Forms.ComboBox comboBox_OeBolum;
        private System.Windows.Forms.Button button_Guncelle;
        private System.Windows.Forms.Button button_Sil;
    }
}