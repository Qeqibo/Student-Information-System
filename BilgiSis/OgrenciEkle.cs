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
using MODEL;
namespace BilgiSis
{
    public partial class OgrenciEkle : Form
    {
        BolumlerBLL bolum;
        public OgrenciEkle()
        {
            bolum = new BolumlerBLL();
            InitializeComponent();
        }
        public void ComboboxDoldur()
        {

            comboBox_OgrnBolum.DataSource = bolum.TumBolumGetir();
            comboBox_OgrnBolum.DisplayMember = "BolumAdi";
            comboBox_OgrnBolum.ValueMember = "BolumlerID";

        }
        private void button_OgrnEkle_Click(object sender, EventArgs e)
        {
          OgrencilerBLL   OG = new OgrencilerBLL();
            try
            {
                if (OG.Ekle(new OgrenciModel { OgrenciNo = Convert.ToInt32( textBox_OgrnNumara.Text.Trim()), OgrenciAdi = textBox_OgrnAd.Text.Trim(), OgrenciSoyadi = textBox_OgrbSoyad.Text.Trim(), OgrenciSifre = textBox_OgrnSifre.Text.Trim(), BolumlerID = 1}))
                {

                    MessageBox.Show("Kayıt Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Kayıt Tamamlanamadı");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }

        private void button_Sil_Click(object sender, EventArgs e)
        {
            OgrencilerBLL OG = new OgrencilerBLL();
            try
            {
                if (OG.Sil(Convert.ToInt32(textBox_OgrnNumara.Text)))
                {

                    MessageBox.Show("Silme Tamamlandı");
                }
                else
                {
                    MessageBox.Show("Silme Tamamlanamadı");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            OgrencilerBLL OE = new OgrencilerBLL();
            try
            {
                OgrenciModel MODEL = new OgrenciModel();
                textBox_OgrnNumara.Tag = MODEL.OgrenciID;
                if (OE.Guncelle(new OgrenciModel { OgrenciID=Convert.ToInt32(textBox_OgrnNumara.Tag)   ,OgrenciNo =Convert.ToInt32( textBox_OgrnNumara.Text.Trim()), OgrenciAdi = textBox_OgrnAd.Text.Trim(), OgrenciSoyadi = textBox_OgrbSoyad.Text.Trim(), OgrenciSifre = textBox_OgrnSifre.Text.Trim(), BolumlerID =Convert.ToInt32( comboBox_OgrnBolum.SelectedValue) }))
                {

                    MessageBox.Show("Guncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Guncelleme başarısız");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
    }
    

