namespace BilgiSis
{
    partial class NotEkle
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
            this.comboBox_SınavTip = new System.Windows.Forms.ComboBox();
            this.comboBox_Ogrenci = new System.Windows.Forms.ComboBox();
            this.comboBox_Ders = new System.Windows.Forms.ComboBox();
            this.comboBox_Donem = new System.Windows.Forms.ComboBox();
            this.textBox_Not = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_NotKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox_SınavTip
            // 
            this.comboBox_SınavTip.FormattingEnabled = true;
            this.comboBox_SınavTip.Location = new System.Drawing.Point(104, 180);
            this.comboBox_SınavTip.Name = "comboBox_SınavTip";
            this.comboBox_SınavTip.Size = new System.Drawing.Size(121, 21);
            this.comboBox_SınavTip.TabIndex = 0;
            // 
            // comboBox_Ogrenci
            // 
            this.comboBox_Ogrenci.FormattingEnabled = true;
            this.comboBox_Ogrenci.Location = new System.Drawing.Point(104, 56);
            this.comboBox_Ogrenci.Name = "comboBox_Ogrenci";
            this.comboBox_Ogrenci.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Ogrenci.TabIndex = 1;
            // 
            // comboBox_Ders
            // 
            this.comboBox_Ders.FormattingEnabled = true;
            this.comboBox_Ders.Location = new System.Drawing.Point(104, 95);
            this.comboBox_Ders.Name = "comboBox_Ders";
            this.comboBox_Ders.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Ders.TabIndex = 2;
            // 
            // comboBox_Donem
            // 
            this.comboBox_Donem.FormattingEnabled = true;
            this.comboBox_Donem.Location = new System.Drawing.Point(104, 139);
            this.comboBox_Donem.Name = "comboBox_Donem";
            this.comboBox_Donem.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Donem.TabIndex = 3;
            // 
            // textBox_Not
            // 
            this.textBox_Not.Location = new System.Drawing.Point(104, 220);
            this.textBox_Not.Name = "textBox_Not";
            this.textBox_Not.Size = new System.Drawing.Size(121, 20);
            this.textBox_Not.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ders :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Donem :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sınav Tip :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Not :";
            // 
            // button_NotKaydet
            // 
            this.button_NotKaydet.Location = new System.Drawing.Point(167, 27);
            this.button_NotKaydet.Name = "button_NotKaydet";
            this.button_NotKaydet.Size = new System.Drawing.Size(75, 23);
            this.button_NotKaydet.TabIndex = 10;
            this.button_NotKaydet.Text = "Kaydet";
            this.button_NotKaydet.UseVisualStyleBackColor = true;
            this.button_NotKaydet.Click += new System.EventHandler(this.button_NotKaydet_Click);
            // 
            // NotEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_NotKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Not);
            this.Controls.Add(this.comboBox_Donem);
            this.Controls.Add(this.comboBox_Ders);
            this.Controls.Add(this.comboBox_Ogrenci);
            this.Controls.Add(this.comboBox_SınavTip);
            this.Name = "NotEkle";
            this.Text = "NotEkle";
            this.Load += new System.EventHandler(this.NotEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_SınavTip;
        private System.Windows.Forms.ComboBox comboBox_Ogrenci;
        private System.Windows.Forms.ComboBox comboBox_Ders;
        private System.Windows.Forms.ComboBox comboBox_Donem;
        private System.Windows.Forms.TextBox textBox_Not;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_NotKaydet;
    }
}