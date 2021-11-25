using BLL;
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
    public partial class NotEkle : Form
    {
        OgrencilerBLL ogr;
        DerslerBLL ders;
        DonemBLL dnm;
        SınavTipBLL snv;
        public NotEkle()
        {
            ogr = new OgrencilerBLL();
            ders = new DerslerBLL();
            dnm = new DonemBLL();
            snv = new SınavTipBLL();
            InitializeComponent();
        }
        public void ComboboxDoldur()
        {
            comboBox_Ders.DataSource = ders.TumDersleriGetir();
            comboBox_Ders.DisplayMember = "DersKodu";
            comboBox_Ders.ValueMember = "DersID";
            //
            comboBox_Ogrenci.DataSource = ogr.TumOgrencileriGetir();
            comboBox_Ogrenci.DisplayMember = "OgrenciNo";
            comboBox_Ogrenci.ValueMember = "OgrenciID";
            //
            comboBox_Donem.DataSource = dnm.TumDonemleriGetir();
            comboBox_Donem.DisplayMember = "DönemAdi";
            comboBox_Donem.ValueMember = "DönemID";
            //
            comboBox_SınavTip.DataSource = snv.TumSınavTipleriniGetir();
            comboBox_SınavTip.DisplayMember = "SınavTipAdi";
            comboBox_SınavTip.ValueMember = "SınavTipID";
        }
        private void button_NotKaydet_Click(object sender, EventArgs e)
        {
            NotBLL Not = new NotBLL();
            try
            {
                if (Not.Ekle(new MODELs.OgrenciNotModel { OgrenciID = Convert.ToInt32( comboBox_Ogrenci.SelectedValue), DönemID = Convert.ToInt32( comboBox_Donem.SelectedValue), SınavTipID =Convert.ToInt32( comboBox_SınavTip.SelectedValue), DersKodu =Convert.ToString( comboBox_Ders.SelectedValue), Not =Convert.ToInt32( textBox_Not.Text.Trim()) }))
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

        private void NotEkle_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
        }
    }
    }
    
