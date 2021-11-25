using BLL;
using Model;
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
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }

        private void button_AdmnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                AdminBLL ad = new AdminBLL();
                AdminModel admn = ad.AdminGiris(textBox_AdmnKadi.Text.Trim(), textBox_AdmnSifre.Text.Trim());


                if (admn == null)
                {

                    MessageBox.Show("Kullanıcı Bulunamadı.");
                }
                else
                {

                    AdminGiris2 po = new AdminGiris2();
                    po.Show();
                    this.Hide();
                }


            }

            catch (SqlException ex)
            {

                MessageBox.Show(ex.ToString());
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
                
            }

        }
    }
    }
