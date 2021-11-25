namespace BilgiSis
{
    partial class BolumEkle
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
            this.textBox_BlmAd = new System.Windows.Forms.TextBox();
            this.label_BlmAd = new System.Windows.Forms.Label();
            this.label_AkdmAd = new System.Windows.Forms.Label();
            this.button_BlmEkle = new System.Windows.Forms.Button();
            this.comboBox_AkdmAd = new System.Windows.Forms.ComboBox();
            this.dataGridView_BlmEkle = new System.Windows.Forms.DataGridView();
            this.button_BlmSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BlmEkle)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_BlmAd
            // 
            this.textBox_BlmAd.Location = new System.Drawing.Point(91, 88);
            this.textBox_BlmAd.Name = "textBox_BlmAd";
            this.textBox_BlmAd.Size = new System.Drawing.Size(100, 20);
            this.textBox_BlmAd.TabIndex = 0;
            // 
            // label_BlmAd
            // 
            this.label_BlmAd.AutoSize = true;
            this.label_BlmAd.Location = new System.Drawing.Point(1, 95);
            this.label_BlmAd.Name = "label_BlmAd";
            this.label_BlmAd.Size = new System.Drawing.Size(58, 13);
            this.label_BlmAd.TabIndex = 2;
            this.label_BlmAd.Text = "Bölüm Ad :";
            // 
            // label_AkdmAd
            // 
            this.label_AkdmAd.AutoSize = true;
            this.label_AkdmAd.Location = new System.Drawing.Point(1, 122);
            this.label_AkdmAd.Name = "label_AkdmAd";
            this.label_AkdmAd.Size = new System.Drawing.Size(85, 13);
            this.label_AkdmAd.TabIndex = 3;
            this.label_AkdmAd.Text = "Akademik Birim :";
            // 
            // button_BlmEkle
            // 
            this.button_BlmEkle.Location = new System.Drawing.Point(197, 71);
            this.button_BlmEkle.Name = "button_BlmEkle";
            this.button_BlmEkle.Size = new System.Drawing.Size(75, 23);
            this.button_BlmEkle.TabIndex = 4;
            this.button_BlmEkle.Text = "Kaydet";
            this.button_BlmEkle.UseVisualStyleBackColor = true;
            this.button_BlmEkle.Click += new System.EventHandler(this.button_BlmEkle_Click);
            // 
            // comboBox_AkdmAd
            // 
            this.comboBox_AkdmAd.FormattingEnabled = true;
            this.comboBox_AkdmAd.Location = new System.Drawing.Point(91, 114);
            this.comboBox_AkdmAd.Name = "comboBox_AkdmAd";
            this.comboBox_AkdmAd.Size = new System.Drawing.Size(100, 21);
            this.comboBox_AkdmAd.TabIndex = 5;
            // 
            // dataGridView_BlmEkle
            // 
            this.dataGridView_BlmEkle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BlmEkle.Location = new System.Drawing.Point(4, 141);
            this.dataGridView_BlmEkle.Name = "dataGridView_BlmEkle";
            this.dataGridView_BlmEkle.Size = new System.Drawing.Size(277, 119);
            this.dataGridView_BlmEkle.TabIndex = 6;
            this.dataGridView_BlmEkle.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_BlmEkle_CellContentClick);
            // 
            // button_BlmSil
            // 
            this.button_BlmSil.Location = new System.Drawing.Point(197, 100);
            this.button_BlmSil.Name = "button_BlmSil";
            this.button_BlmSil.Size = new System.Drawing.Size(75, 23);
            this.button_BlmSil.TabIndex = 7;
            this.button_BlmSil.Text = "Sil";
            this.button_BlmSil.UseVisualStyleBackColor = true;
            this.button_BlmSil.Click += new System.EventHandler(this.button_BlmSil_Click);
            // 
            // BolumEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button_BlmSil);
            this.Controls.Add(this.dataGridView_BlmEkle);
            this.Controls.Add(this.comboBox_AkdmAd);
            this.Controls.Add(this.button_BlmEkle);
            this.Controls.Add(this.label_AkdmAd);
            this.Controls.Add(this.label_BlmAd);
            this.Controls.Add(this.textBox_BlmAd);
            this.Name = "BolumEkle";
            this.Text = "BolumEkle";
            this.Load += new System.EventHandler(this.BolumEkle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BlmEkle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_BlmAd;
        private System.Windows.Forms.Label label_BlmAd;
        private System.Windows.Forms.Label label_AkdmAd;
        private System.Windows.Forms.Button button_BlmEkle;
        private System.Windows.Forms.ComboBox comboBox_AkdmAd;
        private System.Windows.Forms.DataGridView dataGridView_BlmEkle;
        private System.Windows.Forms.Button button_BlmSil;
    }
}