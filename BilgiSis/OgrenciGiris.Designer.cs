namespace BilgiSis
{
    partial class OgrenciGiris
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
            this.textBox_OgrnNo = new System.Windows.Forms.TextBox();
            this.textBox_OgrnSifre = new System.Windows.Forms.TextBox();
            this.label_OgrnNo = new System.Windows.Forms.Label();
            this.label_OgrnSifre = new System.Windows.Forms.Label();
            this.button_OgrnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_OgrnNo
            // 
            this.textBox_OgrnNo.Location = new System.Drawing.Point(88, 54);
            this.textBox_OgrnNo.Name = "textBox_OgrnNo";
            this.textBox_OgrnNo.Size = new System.Drawing.Size(100, 20);
            this.textBox_OgrnNo.TabIndex = 0;
            // 
            // textBox_OgrnSifre
            // 
            this.textBox_OgrnSifre.Location = new System.Drawing.Point(88, 116);
            this.textBox_OgrnSifre.Name = "textBox_OgrnSifre";
            this.textBox_OgrnSifre.Size = new System.Drawing.Size(100, 20);
            this.textBox_OgrnSifre.TabIndex = 1;
            // 
            // label_OgrnNo
            // 
            this.label_OgrnNo.AutoSize = true;
            this.label_OgrnNo.Location = new System.Drawing.Point(16, 61);
            this.label_OgrnNo.Name = "label_OgrnNo";
            this.label_OgrnNo.Size = new System.Drawing.Size(50, 13);
            this.label_OgrnNo.TabIndex = 2;
            this.label_OgrnNo.Text = "Numara :";
            // 
            // label_OgrnSifre
            // 
            this.label_OgrnSifre.AutoSize = true;
            this.label_OgrnSifre.Location = new System.Drawing.Point(16, 123);
            this.label_OgrnSifre.Name = "label_OgrnSifre";
            this.label_OgrnSifre.Size = new System.Drawing.Size(34, 13);
            this.label_OgrnSifre.TabIndex = 3;
            this.label_OgrnSifre.Text = "Şifre :";
            // 
            // button_OgrnGiris
            // 
            this.button_OgrnGiris.Location = new System.Drawing.Point(98, 177);
            this.button_OgrnGiris.Name = "button_OgrnGiris";
            this.button_OgrnGiris.Size = new System.Drawing.Size(75, 23);
            this.button_OgrnGiris.TabIndex = 4;
            this.button_OgrnGiris.Text = "Giriş";
            this.button_OgrnGiris.UseVisualStyleBackColor = true;
            this.button_OgrnGiris.Click += new System.EventHandler(this.button_OgrnGiris_Click);
            // 
            // OgrenciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_OgrnGiris);
            this.Controls.Add(this.label_OgrnSifre);
            this.Controls.Add(this.label_OgrnNo);
            this.Controls.Add(this.textBox_OgrnSifre);
            this.Controls.Add(this.textBox_OgrnNo);
            this.Name = "OgrenciGiris";
            this.Text = "OgrenciGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_OgrnNo;
        private System.Windows.Forms.TextBox textBox_OgrnSifre;
        private System.Windows.Forms.Label label_OgrnNo;
        private System.Windows.Forms.Label label_OgrnSifre;
        private System.Windows.Forms.Button button_OgrnGiris;
    }
}