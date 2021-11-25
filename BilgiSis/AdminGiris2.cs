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
    public partial class AdminGiris2 : Form
    {
        public AdminGiris2()
        {
            InitializeComponent();
        }

        private void button_OEekle_Click(object sender, EventArgs e)
        {
            PersonelEkle OE = new PersonelEkle();
            OE.ShowDialog();
            this.Hide();
        }

        private void button_BlmEkle_Click(object sender, EventArgs e)
        {
            BolumEkle blm = new BolumEkle();
            blm.ShowDialog();
            this.Hide();
        }

        private void button_AdmkBirimEkle_Click(object sender, EventArgs e)
        {
            AkademikBirimEkle akdm = new AkademikBirimEkle();
            akdm.Show();
            this.Hide();
        }

        private void button_OgrnEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogr = new OgrenciEkle();
            ogr.Show();
            this.Hide();
        }
    }
}
