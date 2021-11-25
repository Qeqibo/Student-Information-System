namespace BilgiSis
{
    partial class AdminGiris
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
            this.textBox_AdmnKadi = new System.Windows.Forms.TextBox();
            this.textBox_AdmnSifre = new System.Windows.Forms.TextBox();
            this.label_AdminAd = new System.Windows.Forms.Label();
            this.label_AdmnSifre = new System.Windows.Forms.Label();
            this.button_AdmnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_AdmnKadi
            // 
            this.textBox_AdmnKadi.Location = new System.Drawing.Point(91, 106);
            this.textBox_AdmnKadi.Name = "textBox_AdmnKadi";
            this.textBox_AdmnKadi.Size = new System.Drawing.Size(100, 20);
            this.textBox_AdmnKadi.TabIndex = 0;
            // 
            // textBox_AdmnSifre
            // 
            this.textBox_AdmnSifre.Location = new System.Drawing.Point(91, 151);
            this.textBox_AdmnSifre.Name = "textBox_AdmnSifre";
            this.textBox_AdmnSifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_AdmnSifre.TabIndex = 1;
            // 
            // label_AdminAd
            // 
            this.label_AdminAd.AutoSize = true;
            this.label_AdminAd.Location = new System.Drawing.Point(33, 113);
            this.label_AdminAd.Name = "label_AdminAd";
            this.label_AdminAd.Size = new System.Drawing.Size(26, 13);
            this.label_AdminAd.TabIndex = 2;
            this.label_AdminAd.Text = "Ad :";
            // 
            // label_AdmnSifre
            // 
            this.label_AdmnSifre.AutoSize = true;
            this.label_AdmnSifre.Location = new System.Drawing.Point(33, 158);
            this.label_AdmnSifre.Name = "label_AdmnSifre";
            this.label_AdmnSifre.Size = new System.Drawing.Size(28, 13);
            this.label_AdmnSifre.TabIndex = 3;
            this.label_AdmnSifre.Text = "Şifre";
            // 
            // button_AdmnGiris
            // 
            this.button_AdmnGiris.Location = new System.Drawing.Point(102, 198);
            this.button_AdmnGiris.Name = "button_AdmnGiris";
            this.button_AdmnGiris.Size = new System.Drawing.Size(75, 23);
            this.button_AdmnGiris.TabIndex = 4;
            this.button_AdmnGiris.Text = "Giris";
            this.button_AdmnGiris.UseVisualStyleBackColor = true;
            this.button_AdmnGiris.Click += new System.EventHandler(this.button_AdmnGiris_Click);
            // 
            // AdminGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_AdmnGiris);
            this.Controls.Add(this.label_AdmnSifre);
            this.Controls.Add(this.label_AdminAd);
            this.Controls.Add(this.textBox_AdmnSifre);
            this.Controls.Add(this.textBox_AdmnKadi);
            this.Name = "AdminGiris";
            this.Text = "AdminGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AdmnKadi;
        private System.Windows.Forms.TextBox textBox_AdmnSifre;
        private System.Windows.Forms.Label label_AdminAd;
        private System.Windows.Forms.Label label_AdmnSifre;
        private System.Windows.Forms.Button button_AdmnGiris;
    }
}