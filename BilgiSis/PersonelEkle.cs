using BLL;
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

namespace BilgiSis
{
    public partial class PersonelEkle : Form
    {
        BolumlerBLL bolum;
        public PersonelEkle()
        {
            bolum = new BolumlerBLL();
            InitializeComponent();
        }
        public void ComboboxDoldur()
        {

            comboBox_OeBolum.DataSource = bolum.TumBolumGetir();
            comboBox_OeBolum.DisplayMember = "BolumAdi";
            comboBox_OeBolum.ValueMember = "BolumlerID";
            
        }
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }
        private void button_OeKaydet_Click(object sender, EventArgs e)
        {
            OgretimElemaniBLL OE = new OgretimElemaniBLL();
            try
            {
                if (OE.OgretimElemanıEkle(new OgretimElemaniModel { OgrElemaniTC = textBox_OeTc.Text.Trim(), OgrElemaniAdi = textBox_OeAd.Text.Trim(), OgrElemaniSoyad = textBox_OeSoyad.Text.Trim(), BolumlerID = comboBox_OeBolum.SelectedIndex, OgrElemaniSifre = textBox_OeSifre.Text.Trim(), OgrElemaniSicilNo = textBox_OeSicil.Text.Trim() }))
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

        private void button_Guncelle_Click(object sender, EventArgs e)
        {
            OgretimElemaniBLL OE = new OgretimElemaniBLL();
            try
            {
                if (OE.Guncelle(new OgretimElemaniModel { OgrElemaniTC = textBox_OeTc.Text.Trim(), OgrElemaniAdi = textBox_OeAd.Text.Trim(), OgrElemaniSoyad = textBox_OeSoyad.Text.Trim(), BolumlerID = comboBox_OeBolum.SelectedIndex, OgrElemaniSifre = textBox_OeSifre.Text.Trim(), OgrElemaniSicilNo = textBox_OeSicil.Text.Trim() }))
                {

                    MessageBox.Show("Guncelleme Başarılı");
                }
                else
                {
                    MessageBox.Show("Guncelleme başarısız");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void button_Sil_Click(object sender, EventArgs e)
        {

            OgretimElemaniBLL OE = new OgretimElemaniBLL();
            try
            {
                if (OE.Sil(new OgretimElemaniModel { OgrElemaniTC = textBox_OeTc.Text.Trim()}))
                {

                    MessageBox.Show("Silme Başarılı");
                }
                else
                {
                    MessageBox.Show("Silme başarısız");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
