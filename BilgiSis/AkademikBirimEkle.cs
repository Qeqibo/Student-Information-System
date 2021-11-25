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
    public partial class AkademikBirimEkle : Form
    {
        public AkademikBirimEkle()
        {
            InitializeComponent();
        }

        private void button_AkdmkBirimEkle_Click(object sender, EventArgs e)
        {

            AkademikBirimBLL AKDMK = new AkademikBirimBLL();

            if (AKDMK.AkademikBirimEkle(new AkademikBirimModel { AkademikBirimAdi = textBox_AkdmBirimAd.Text.Trim() }))
            {
                MessageBox.Show("Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kaydedilemedi");
            }
        }
    }
}
