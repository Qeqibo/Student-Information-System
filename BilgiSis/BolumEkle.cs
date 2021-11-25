using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace BilgiSis
{
    public partial class BolumEkle : Form
    {
        BolumlerBLL bolum;
        AkademikBirimBLL akdm;
        private int BolumId;
        public BolumEkle()
        {
            bolum = new BolumlerBLL();
            akdm = new AkademikBirimBLL();
            InitializeComponent();
        }
        public void ComboDoldur()
        {

            comboBox_AkdmAd.DisplayMember = "AkademikBirimAdi";
            comboBox_AkdmAd.DataSource = akdm.TumAkademikBirimGetir();
            comboBox_AkdmAd.ValueMember = "AkademikBirimID";



            GridDoldur();
        }
        private void BolumEkle_Load(object sender, EventArgs e)
        {
            ComboDoldur();
        }
        public void GridDoldur()
        {
            dataGridView_BlmEkle.DataSource = bolum.TumBolumGetir();
        }
        private void button_BlmEkle_Click(object sender, EventArgs e)
        {
            try
            {
                BolumlerModel blm = new BolumlerModel
                {
                    AkademikBirimID = Convert.ToInt32(comboBox_AkdmAd.SelectedValue),
                    BolumAdi = textBox_BlmAd.Text.Trim(),
                };
                bolum.BolumEkle(blm);
                MessageBox.Show("Kayıt Tamamlandı");
                textBox_BlmAd.Text = "";
                GridDoldur();
                dataGridView_BlmEkle.Refresh();


            }
            catch
            {
                MessageBox.Show("Daha sonra tekrar deneyiniz");
            }



        }

        private void button_BlmSil_Click(object sender, EventArgs e)
        {
            if (BolumId == null && BolumId == 0)
            {
                MessageBox.Show("Seçili Bir Kayıt Bulanamadı");
            }
            else
            {
                try
                {
                    bool sonuc = bolum.BolumSil(BolumId);
                    if (sonuc == true)
                    {
                        MessageBox.Show("Başarıyla Silindi");
                        GridDoldur();
                        dataGridView_BlmEkle.Refresh();

                    }
                    else
                    {
                        MessageBox.Show("Tekrar Deneyiniz");
                    }
                }
                catch
                {
                    MessageBox.Show("Bir Hata Oluştu");
                }

            }
        }

        private void dataGridView_BlmEkle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int satır = e.RowIndex;
            BolumId = Convert.ToInt32(dataGridView_BlmEkle.Rows[satır].Cells[0].Value);
            textBox_BlmAd.Text = dataGridView_BlmEkle.Rows[satır].Cells[1].Value.ToString();
        }

   
    }
}
