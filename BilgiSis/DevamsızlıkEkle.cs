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

    public partial class DevamsızlıkEkle : Form
    {
        OgrencilerBLL ogr;
        DerslerBLL ders;
        public DevamsızlıkEkle()
        {
            ogr = new OgrencilerBLL();
            ders = new DerslerBLL();
            InitializeComponent();
        }
       public void ComboboxDoldur()
        {
           comboBox_DvmDers.DataSource = ders.TumDersleriGetir();
            comboBox_DvmDers.DisplayMember = "DersKodu";
            comboBox_DvmDers.ValueMember = "DersID";
            //
            comboBox_DvmOgrn.DataSource = ogr.TumOgrencileriGetir();
            comboBox_DvmOgrn.DisplayMember = "OgrenciNo";
            comboBox_DvmOgrn.ValueMember = "OgrenciID";

        }
        private void button_DvmKaydet_Click(object sender, EventArgs e)
        {
            DevamsızlıkBLL dvm = new DevamsızlıkBLL();
            try
            {
                if (dvm.Ekle(new DevamsızlıkModel { OgrenciID = Convert.ToInt32(comboBox_DvmOgrn.SelectedValue), DersID = Convert.ToInt32(comboBox_DvmDers.SelectedValue), Tarih = Convert.ToDateTime(textBox_DvmTarih.Text.Trim()) }))
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

        private void DevamsızlıkEkle_Load(object sender, EventArgs e)
        {
            ComboboxDoldur();
           // ComboboxDoldur1();
        }
    }


}

