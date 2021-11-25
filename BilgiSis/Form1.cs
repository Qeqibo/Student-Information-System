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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_OeGit_Click(object sender, EventArgs e)
        {
            OEGiris OE = new OEGiris();
            OE.ShowDialog();
            this.Hide();
        }

        private void button_AdmnGit_Click(object sender, EventArgs e)
        {
            AdminGiris admn = new AdminGiris();
            admn.ShowDialog();
            this.Hide();
        }

        private void button_OgrnGit_Click(object sender, EventArgs e)
        {
            OgrenciGiris ogrn = new OgrenciGiris();
            ogrn.ShowDialog();
            this.Hide();

        }
    }
}
