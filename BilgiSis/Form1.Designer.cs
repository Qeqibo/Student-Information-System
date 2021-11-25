namespace BilgiSis
{
    partial class Form1
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
            this.button_OgrnGit = new System.Windows.Forms.Button();
            this.button_OeGit = new System.Windows.Forms.Button();
            this.button_AdmnGit = new System.Windows.Forms.Button();
            this.label_OgrnGit = new System.Windows.Forms.Label();
            this.label_OeGit = new System.Windows.Forms.Label();
            this.label_AdmnGit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_OgrnGit
            // 
            this.button_OgrnGit.Location = new System.Drawing.Point(199, 136);
            this.button_OgrnGit.Name = "button_OgrnGit";
            this.button_OgrnGit.Size = new System.Drawing.Size(75, 23);
            this.button_OgrnGit.TabIndex = 0;
            this.button_OgrnGit.Text = "Git";
            this.button_OgrnGit.UseVisualStyleBackColor = true;
            this.button_OgrnGit.Click += new System.EventHandler(this.button_OgrnGit_Click);
            // 
            // button_OeGit
            // 
            this.button_OeGit.Location = new System.Drawing.Point(106, 136);
            this.button_OeGit.Name = "button_OeGit";
            this.button_OeGit.Size = new System.Drawing.Size(75, 23);
            this.button_OeGit.TabIndex = 1;
            this.button_OeGit.Text = "Git";
            this.button_OeGit.UseVisualStyleBackColor = true;
            this.button_OeGit.Click += new System.EventHandler(this.button_OeGit_Click);
            // 
            // button_AdmnGit
            // 
            this.button_AdmnGit.Location = new System.Drawing.Point(4, 136);
            this.button_AdmnGit.Name = "button_AdmnGit";
            this.button_AdmnGit.Size = new System.Drawing.Size(75, 23);
            this.button_AdmnGit.TabIndex = 2;
            this.button_AdmnGit.Text = "Git";
            this.button_AdmnGit.UseVisualStyleBackColor = true;
            this.button_AdmnGit.Click += new System.EventHandler(this.button_AdmnGit_Click);
            // 
            // label_OgrnGit
            // 
            this.label_OgrnGit.AutoSize = true;
            this.label_OgrnGit.Location = new System.Drawing.Point(207, 105);
            this.label_OgrnGit.Name = "label_OgrnGit";
            this.label_OgrnGit.Size = new System.Drawing.Size(67, 13);
            this.label_OgrnGit.TabIndex = 3;
            this.label_OgrnGit.Text = "Öğrenci Giriş";
            // 
            // label_OeGit
            // 
            this.label_OeGit.AutoSize = true;
            this.label_OeGit.Location = new System.Drawing.Point(115, 105);
            this.label_OeGit.Name = "label_OeGit";
            this.label_OeGit.Size = new System.Drawing.Size(71, 13);
            this.label_OeGit.TabIndex = 4;
            this.label_OeGit.Text = "Personel Giriş";
            // 
            // label_AdmnGit
            // 
            this.label_AdmnGit.AutoSize = true;
            this.label_AdmnGit.Location = new System.Drawing.Point(15, 105);
            this.label_AdmnGit.Name = "label_AdmnGit";
            this.label_AdmnGit.Size = new System.Drawing.Size(59, 13);
            this.label_AdmnGit.TabIndex = 5;
            this.label_AdmnGit.Text = "Admin Giriş";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_AdmnGit);
            this.Controls.Add(this.label_OeGit);
            this.Controls.Add(this.label_OgrnGit);
            this.Controls.Add(this.button_AdmnGit);
            this.Controls.Add(this.button_OeGit);
            this.Controls.Add(this.button_OgrnGit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OgrnGit;
        private System.Windows.Forms.Button button_OeGit;
        private System.Windows.Forms.Button button_AdmnGit;
        private System.Windows.Forms.Label label_OgrnGit;
        private System.Windows.Forms.Label label_OeGit;
        private System.Windows.Forms.Label label_AdmnGit;
    }
}

