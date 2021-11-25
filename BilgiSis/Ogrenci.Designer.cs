namespace BilgiSis
{
    partial class Ogrenci
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
            this.grdNot = new System.Windows.Forms.DataGridView();
            this.NotID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OgrenciAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DönemAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SınavTipAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DersKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdNot)).BeginInit();
            this.SuspendLayout();
            // 
            // grdNot
            // 
            this.grdNot.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdNot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdNot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NotID,
            this.OgrenciAdi,
            this.DönemAdi,
            this.SınavTipAdi,
            this.DersKodu,
            this.puan,
            this.Tarih});
            this.grdNot.Location = new System.Drawing.Point(39, 50);
            this.grdNot.Name = "grdNot";
            this.grdNot.Size = new System.Drawing.Size(448, 150);
            this.grdNot.TabIndex = 0;
            // 
            // NotID
            // 
            this.NotID.DataPropertyName = "NotID";
            this.NotID.HeaderText = "NotID";
            this.NotID.Name = "NotID";
            this.NotID.Visible = false;
            // 
            // OgrenciAdi
            // 
            this.OgrenciAdi.DataPropertyName = "OgrenciAdi";
            this.OgrenciAdi.HeaderText = "OgrenciID";
            this.OgrenciAdi.Name = "OgrenciAdi";
            // 
            // DönemAdi
            // 
            this.DönemAdi.DataPropertyName = "DönemAdi";
            this.DönemAdi.HeaderText = "DönemID";
            this.DönemAdi.Name = "DönemAdi";
            // 
            // SınavTipAdi
            // 
            this.SınavTipAdi.DataPropertyName = "SınavTipAdi";
            this.SınavTipAdi.HeaderText = "SinavTipi";
            this.SınavTipAdi.Name = "SınavTipAdi";
            // 
            // DersKodu
            // 
            this.DersKodu.DataPropertyName = "DersKodu";
            this.DersKodu.HeaderText = "DersKodu";
            this.DersKodu.Name = "DersKodu";
            // 
            // puan
            // 
            this.puan.HeaderText = "puan";
            this.puan.Name = "puan";
            // 
            // Tarih
            // 
            this.Tarih.HeaderText = "Tarih";
            this.Tarih.Name = "Tarih";
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 261);
            this.Controls.Add(this.grdNot);
            this.Name = "Ogrenci";
            this.Text = "Ogrenci";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdNot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdNot;
        private System.Windows.Forms.DataGridViewTextBoxColumn NotID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OgrenciAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DönemAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SınavTipAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn DersKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn puan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tarih;
    }
}