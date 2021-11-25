namespace BilgiSis
{
    partial class AdminGiris2
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
            this.button_OEekle = new System.Windows.Forms.Button();
            this.button_OgrnEkle = new System.Windows.Forms.Button();
            this.button_BlmEkle = new System.Windows.Forms.Button();
            this.button_AdmkBirimEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_OEekle
            // 
            this.button_OEekle.Location = new System.Drawing.Point(111, 63);
            this.button_OEekle.Name = "button_OEekle";
            this.button_OEekle.Size = new System.Drawing.Size(129, 26);
            this.button_OEekle.TabIndex = 0;
            this.button_OEekle.Text = "Personel Ekle";
            this.button_OEekle.UseVisualStyleBackColor = true;
            this.button_OEekle.Click += new System.EventHandler(this.button_OEekle_Click);
            // 
            // button_OgrnEkle
            // 
            this.button_OgrnEkle.Location = new System.Drawing.Point(111, 109);
            this.button_OgrnEkle.Name = "button_OgrnEkle";
            this.button_OgrnEkle.Size = new System.Drawing.Size(129, 26);
            this.button_OgrnEkle.TabIndex = 1;
            this.button_OgrnEkle.Text = "Öğrenci Ekle";
            this.button_OgrnEkle.UseVisualStyleBackColor = true;
            this.button_OgrnEkle.Click += new System.EventHandler(this.button_OgrnEkle_Click);
            // 
            // button_BlmEkle
            // 
            this.button_BlmEkle.Location = new System.Drawing.Point(111, 153);
            this.button_BlmEkle.Name = "button_BlmEkle";
            this.button_BlmEkle.Size = new System.Drawing.Size(129, 26);
            this.button_BlmEkle.TabIndex = 2;
            this.button_BlmEkle.Text = "Bölüm Ekle";
            this.button_BlmEkle.UseVisualStyleBackColor = true;
            this.button_BlmEkle.Click += new System.EventHandler(this.button_BlmEkle_Click);
            // 
            // button_AdmkBirimEkle
            // 
            this.button_AdmkBirimEkle.Location = new System.Drawing.Point(111, 202);
            this.button_AdmkBirimEkle.Name = "button_AdmkBirimEkle";
            this.button_AdmkBirimEkle.Size = new System.Drawing.Size(129, 26);
            this.button_AdmkBirimEkle.TabIndex = 3;
            this.button_AdmkBirimEkle.Text = "Akademik Birim Ekle";
            this.button_AdmkBirimEkle.UseVisualStyleBackColor = true;
            this.button_AdmkBirimEkle.Click += new System.EventHandler(this.button_AdmkBirimEkle_Click);
            // 
            // AdminGiris2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 302);
            this.Controls.Add(this.button_AdmkBirimEkle);
            this.Controls.Add(this.button_BlmEkle);
            this.Controls.Add(this.button_OgrnEkle);
            this.Controls.Add(this.button_OEekle);
            this.Name = "AdminGiris2";
            this.Text = "AdminGiris2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_OEekle;
        private System.Windows.Forms.Button button_OgrnEkle;
        private System.Windows.Forms.Button button_BlmEkle;
        private System.Windows.Forms.Button button_AdmkBirimEkle;
    }
}