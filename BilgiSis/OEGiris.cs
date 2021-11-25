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
    public partial class OEGiris : Form
    {
        public OEGiris()
        {
            InitializeComponent();
        }

        private void button_OeGiris_Click(object sender, EventArgs e)
        {
            try
            {
                OgretimElemaniBLL BllOE = new OgretimElemaniBLL();

                OgretimElemaniModel ModelOE = BllOE.OgretimElemanıGiris(textBox_OeGirisAd.Text.Trim(), textBox_OeGirisSifre.Text.Trim());


                if (ModelOE == null)
                {

                    MessageBox.Show(" Ad vaya Şifre hatalı");
                }
                else
                {
                    OE oge = new OE();
                    oge.Show();
                    this.Hide();
                }

            }
            catch (SqlException ex)
            {

                MessageBox.Show("Veritabanı Hatası");
            }
            catch (Exception ex)
            {

                MessageBox.Show("?????????");
            }
        }
    }
    }
