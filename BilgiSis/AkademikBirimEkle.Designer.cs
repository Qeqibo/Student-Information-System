namespace BilgiSis
{
    partial class AkademikBirimEkle
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
            this.textBox_AkdmBirimAd = new System.Windows.Forms.TextBox();
            this.button_AkdmkBirimEkle = new System.Windows.Forms.Button();
            this.label_AkdmkAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_AkdmBirimAd
            // 
            this.textBox_AkdmBirimAd.Location = new System.Drawing.Point(72, 130);
            this.textBox_AkdmBirimAd.Name = "textBox_AkdmBirimAd";
            this.textBox_AkdmBirimAd.Size = new System.Drawing.Size(100, 20);
            this.textBox_AkdmBirimAd.TabIndex = 0;
            // 
            // button_AkdmkBirimEkle
            // 
            this.button_AkdmkBirimEkle.Location = new System.Drawing.Point(197, 130);
            this.button_AkdmkBirimEkle.Name = "button_AkdmkBirimEkle";
            this.button_AkdmkBirimEkle.Size = new System.Drawing.Size(75, 23);
            this.button_AkdmkBirimEkle.TabIndex = 1;
            this.button_AkdmkBirimEkle.Text = "Kaydet";
            this.button_AkdmkBirimEkle.UseVisualStyleBackColor = true;
            this.button_AkdmkBirimEkle.Click += new System.EventHandler(this.button_AkdmkBirimEkle_Click);
            // 
            // label_AkdmkAd
            // 
            this.label_AkdmkAd.AutoSize = true;
            this.label_AkdmkAd.Location = new System.Drawing.Point(12, 130);
            this.label_AkdmkAd.Name = "label_AkdmkAd";
            this.label_AkdmkAd.Size = new System.Drawing.Size(53, 13);
            this.label_AkdmkAd.TabIndex = 2;
            this.label_AkdmkAd.Text = "Birim Adı :";
            // 
            // AkademikBirimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label_AkdmkAd);
            this.Controls.Add(this.button_AkdmkBirimEkle);
            this.Controls.Add(this.textBox_AkdmBirimAd);
            this.Name = "AkademikBirimEkle";
            this.Text = "AkademikBirimEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_AkdmBirimAd;
        private System.Windows.Forms.Button button_AkdmkBirimEkle;
        private System.Windows.Forms.Label label_AkdmkAd;
    }
}