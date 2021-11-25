namespace BilgiSis
{
    partial class DevamsızlıkEkle
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
            this.button_DvmKaydet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_DvmTarih = new System.Windows.Forms.TextBox();
            this.comboBox_DvmOgrn = new System.Windows.Forms.ComboBox();
            this.comboBox_DvmDers = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_DvmKaydet
            // 
            this.button_DvmKaydet.Location = new System.Drawing.Point(118, 160);
            this.button_DvmKaydet.Name = "button_DvmKaydet";
            this.button_DvmKaydet.Size = new System.Drawing.Size(75, 23);
            this.button_DvmKaydet.TabIndex = 0;
            this.button_DvmKaydet.Text = "Kaydet";
            this.button_DvmKaydet.UseVisualStyleBackColor = true;
            this.button_DvmKaydet.Click += new System.EventHandler(this.button_DvmKaydet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tarih";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ders :";
            // 
            // textBox_DvmTarih
            // 
            this.textBox_DvmTarih.Location = new System.Drawing.Point(72, 42);
            this.textBox_DvmTarih.Name = "textBox_DvmTarih";
            this.textBox_DvmTarih.Size = new System.Drawing.Size(121, 20);
            this.textBox_DvmTarih.TabIndex = 4;
            // 
            // comboBox_DvmOgrn
            // 
            this.comboBox_DvmOgrn.FormattingEnabled = true;
            this.comboBox_DvmOgrn.Location = new System.Drawing.Point(72, 78);
            this.comboBox_DvmOgrn.Name = "comboBox_DvmOgrn";
            this.comboBox_DvmOgrn.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DvmOgrn.TabIndex = 5;
            // 
            // comboBox_DvmDers
            // 
            this.comboBox_DvmDers.FormattingEnabled = true;
            this.comboBox_DvmDers.Location = new System.Drawing.Point(72, 122);
            this.comboBox_DvmDers.Name = "comboBox_DvmDers";
            this.comboBox_DvmDers.Size = new System.Drawing.Size(121, 21);
            this.comboBox_DvmDers.TabIndex = 6;
            // 
            // DevamsızlıkEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBox_DvmDers);
            this.Controls.Add(this.comboBox_DvmOgrn);
            this.Controls.Add(this.textBox_DvmTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_DvmKaydet);
            this.Name = "DevamsızlıkEkle";
            this.Text = "DevamsızlıkEkle";
            this.Load += new System.EventHandler(this.DevamsızlıkEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_DvmKaydet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_DvmTarih;
        private System.Windows.Forms.ComboBox comboBox_DvmOgrn;
        private System.Windows.Forms.ComboBox comboBox_DvmDers;
    }
}