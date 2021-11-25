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
    public partial class OE : Form
    {
        public OE()
        {
            InitializeComponent();
        }

        private void button_DvmGir_Click(object sender, EventArgs e)
        {
            DevamsızlıkEkle dvm = new DevamsızlıkEkle();
            dvm.Show();
            this.Hide();
        }

        private void button_NotGir_Click(object sender, EventArgs e)
        {
            NotEkle not = new NotEkle();
            not.ShowDialog();
            this.Hide();
        }

      
    }
}
