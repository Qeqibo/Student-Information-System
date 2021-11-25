using BLL;
using MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiSis
{
    public partial class OgrenciGiris : Form
    {
        public OgrenciGiris()
        {
            InitializeComponent();
        }

        private void button_OgrnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                OgrencilerBLL ob = new OgrencilerBLL();
                OgrenciModel om = ob.OgrenciGiris(textBox_OgrnNo.Text.Trim(), textBox_OgrnSifre.Text.Trim());


                if (om == null)
                {

                    MessageBox.Show("Kullanıcı Bulunamadı.");
                }
                else
                {

                    Ogrenci obg = new Ogrenci();
                    obg.ShowDialog();
                    this.Hide();
                }
            }

            catch (SqlException ex)
            {

                MessageBox.Show("Veritabanı hatası");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bilinmeyen Bir Hata Oluştu");
            }
        }
    }
    }
    

