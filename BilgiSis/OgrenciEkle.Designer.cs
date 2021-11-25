namespace BilgiSis
{
    partial class OgrenciEkle
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
            this.textBox_OgrnSifre = new System.Windows.Forms.TextBox();
            this.textBox_OgrnAd = new System.Windows.Forms.TextBox();
            this.textBox_OgrbSoyad = new System.Windows.Forms.TextBox();
            this.textBox_OgrnNumara = new System.Windows.Forms.TextBox();
            this.comboBox_OgrnBolum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_OgrnEkle = new System.Windows.Forms.Button();
            this.button_Sil = new System.Windows.Forms.Button();
            this.button_Guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_OgrnSifre
            // 
            this.textBox_OgrnSifre.Location = new System.Drawing.Point(69, 170);
            this.textBox_OgrnSifre.Name = "textBox_OgrnSifre";
            this.textBox_OgrnSifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_OgrnSifre.TabIndex = 1;
            // 
            // textBox_OgrnAd
            // 
            this.textBox_OgrnAd.Location = new System.Drawing.Point(69, 43);
            this.textBox_OgrnAd.Name = "textBox_OgrnAd";
            this.textBox_OgrnAd.Size = new System.Drawing.Size(100, 20);
            this.textBox_OgrnAd.TabIndex = 2;
            // 
            // textBox_OgrbSoyad
            // 
            this.textBox_OgrbSoyad.Location = new System.Drawing.Point(69, 69);
            this.textBox_OgrbSoyad.Name = "textBox_OgrbSoyad";
            this.textBox_OgrbSoyad.Size = new System.Drawing.Size(100, 20);
            this.textBox_OgrbSoyad.TabIndex = 3;
            // 
            // textBox_OgrnNumara
            // 
            this.textBox_OgrnNumara.Location = new System.Drawing.Point(69, 95);
            this.textBox_OgrnNumara.Name = "textBox_OgrnNumara";
            this.textBox_OgrnNumara.Size = new System.Drawing.Size(100, 20);
            this.textBox_OgrnNumara.TabIndex = 4;
            this.textBox_OgrnNumara.Tag = "0";
            // 
            // comboBox_OgrnBolum
            // 
            this.comboBox_OgrnBolum.FormattingEnabled = true;
            this.comboBox_OgrnBolum.Location = new System.Drawing.Point(69, 134);
            this.comboBox_OgrnBolum.Name = "comboBox_OgrnBolum";
            this.comboBox_OgrnBolum.Size = new System.Drawing.Size(100, 21);
            this.comboBox_OgrnBolum.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numara :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bölüm :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre :";
            // 
            // button_OgrnEkle
            // 
            this.button_OgrnEkle.Location = new System.Drawing.Point(6, 216);
            this.button_OgrnEkle.Name = "button_OgrnEkle";
            this.button_OgrnEkle.Size = new System.Drawing.Size(75, 23);
            this.button_OgrnEkle.TabIndex = 12;
            this.button_OgrnEkle.Text = "Kaydet";
            this.button_OgrnEkle.UseVisualStyleBackColor = true;
            this.button_OgrnEkle.Click += new System.EventHandler(this.button_OgrnEkle_Click);
            // 
            // button_Sil
            // 
            this.button_Sil.Location = new System.Drawing.Point(87, 216);
            this.button_Sil.Name = "button_Sil";
            this.button_Sil.Size = new System.Drawing.Size(75, 23);
            this.button_Sil.TabIndex = 13;
            this.button_Sil.Text = "Sil";
            this.button_Sil.UseVisualStyleBackColor = true;
            this.button_Sil.Click += new System.EventHandler(this.button_Sil_Click);
            // 
            // button_Guncelle
            // 
            this.button_Guncelle.Location = new System.Drawing.Point(168, 216);
            this.button_Guncelle.Name = "button_Guncelle";
            this.button_Guncelle.Size = new System.Drawing.Size(75, 23);
            this.button_Guncelle.TabIndex = 14;
            this.button_Guncelle.Text = "Guncelle";
            this.button_Guncelle.UseVisualStyleBackColor = true;
            this.button_Guncelle.Click += new System.EventHandler(this.button_Guncelle_Click);
            // 
            // OgrenciEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_Guncelle);
            this.Controls.Add(this.button_Sil);
            this.Controls.Add(this.button_OgrnEkle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_OgrnBolum);
            this.Controls.Add(this.textBox_OgrnNumara);
            this.Controls.Add(this.textBox_OgrbSoyad);
            this.Controls.Add(this.textBox_OgrnAd);
            this.Controls.Add(this.textBox_OgrnSifre);
            this.Name = "OgrenciEkle";
            this.Text = "OgrenciEkle";
            this.Load += new System.EventHandler(this.OgrenciEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_OgrnSifre;
        private System.Windows.Forms.TextBox textBox_OgrnAd;
        private System.Windows.Forms.TextBox textBox_OgrbSoyad;
        private System.Windows.Forms.TextBox textBox_OgrnNumara;
        private System.Windows.Forms.ComboBox comboBox_OgrnBolum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_OgrnEkle;
        private System.Windows.Forms.Button button_Sil;
        private System.Windows.Forms.Button button_Guncelle;
    }
}