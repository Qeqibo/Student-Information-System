namespace BilgiSis
{
    partial class OEGiris
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
            this.textBox_OeGirisAd = new System.Windows.Forms.TextBox();
            this.textBox_OeGirisSifre = new System.Windows.Forms.TextBox();
            this.label_OeGirisAd = new System.Windows.Forms.Label();
            this.label_Sifre = new System.Windows.Forms.Label();
            this.button_OeGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_OeGirisAd
            // 
            this.textBox_OeGirisAd.Location = new System.Drawing.Point(87, 96);
            this.textBox_OeGirisAd.Name = "textBox_OeGirisAd";
            this.textBox_OeGirisAd.Size = new System.Drawing.Size(100, 20);
            this.textBox_OeGirisAd.TabIndex = 0;
            // 
            // textBox_OeGirisSifre
            // 
            this.textBox_OeGirisSifre.Location = new System.Drawing.Point(87, 139);
            this.textBox_OeGirisSifre.Name = "textBox_OeGirisSifre";
            this.textBox_OeGirisSifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_OeGirisSifre.TabIndex = 1;
            // 
            // label_OeGirisAd
            // 
            this.label_OeGirisAd.AutoSize = true;
            this.label_OeGirisAd.Location = new System.Drawing.Point(46, 103);
            this.label_OeGirisAd.Name = "label_OeGirisAd";
            this.label_OeGirisAd.Size = new System.Drawing.Size(26, 13);
            this.label_OeGirisAd.TabIndex = 2;
            this.label_OeGirisAd.Text = "Tc :";
            // 
            // label_Sifre
            // 
            this.label_Sifre.AutoSize = true;
            this.label_Sifre.Location = new System.Drawing.Point(46, 146);
            this.label_Sifre.Name = "label_Sifre";
            this.label_Sifre.Size = new System.Drawing.Size(34, 13);
            this.label_Sifre.TabIndex = 3;
            this.label_Sifre.Text = "Şifre :";
            // 
            // button_OeGiris
            // 
            this.button_OeGiris.Location = new System.Drawing.Point(100, 194);
            this.button_OeGiris.Name = "button_OeGiris";
            this.button_OeGiris.Size = new System.Drawing.Size(75, 23);
            this.button_OeGiris.TabIndex = 4;
            this.button_OeGiris.Text = "Giriş";
            this.button_OeGiris.UseVisualStyleBackColor = true;
            this.button_OeGiris.Click += new System.EventHandler(this.button_OeGiris_Click);
            // 
            // OEGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_OeGiris);
            this.Controls.Add(this.label_Sifre);
            this.Controls.Add(this.label_OeGirisAd);
            this.Controls.Add(this.textBox_OeGirisSifre);
            this.Controls.Add(this.textBox_OeGirisAd);
            this.Name = "OEGiris";
            this.Text = "OEGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_OeGirisAd;
        private System.Windows.Forms.TextBox textBox_OeGirisSifre;
        private System.Windows.Forms.Label label_OeGirisAd;
        private System.Windows.Forms.Label label_Sifre;
        private System.Windows.Forms.Button button_OeGiris;
    }
}