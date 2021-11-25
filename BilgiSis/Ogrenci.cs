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
    public partial class Ogrenci : Form
    {
        DataTable dt = null;
        OgrencilerBLL orn;
        OgrenciModel ogrmodel;
        public Ogrenci()
        { //ogrmodel = new OgrenciModel();
           // orn = new OgrencilerBLL();
           
            InitializeComponent();
        }
       
        void GridDoldur()
        {
            ogrmodel = new OgrenciModel();
            orn = new OgrencilerBLL();
            dt= orn.OgrenciGetir();
            grdNot.DataSource = dt;
            //dataGridView1.AutoGenerateColumns = false;//bir sorun var
            
        }

        private void Ogrenci_Load(object sender, EventArgs e)
        {
            grdNot.AutoGenerateColumns = false;
            GridDoldur();
        }
    }
}
