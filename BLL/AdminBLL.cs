using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Model;
using MODEL;

namespace BLL
{
    public class AdminBLL
    {
        public AdminModel AdminGiris(string AdminAd, string AdminSifre)
        {
            AdminModel adm;

            try
            {
                SqlParameter[] p = { new SqlParameter("@AdminAd", AdminAd), new SqlParameter("@AdminSifre", AdminSifre) };
                Helper hlp = Helper.Ornek;
                SqlDataReader dr = hlp.ExecuteReader("Select AdminID, AdminAd, AdminSoyad, AdminSifre from Admin where AdminAd=@AdminAd and AdminSifre=@AdminSifre", p);
                if (dr.Read())
                {
                    adm = new AdminModel();
                    adm.AdminAd = dr["AdminAd"].ToString();
                    adm.AdminSifre = dr["AdminSifre"].ToString();
                }
                else
                {
                    adm = null;

                }

                return adm;
            }
            catch (SqlException ex)
            {

                throw ex;
            }


            catch (Exception ex)
            {

                throw ex;
            }



        }

        public bool OgtElemanıEkle(OgretimElemaniModel ogm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@OgrElemaniTC", ogm.OgrElemaniTC),
                                     new SqlParameter("@OgrElemaniAdi", ogm.OgrElemaniAdi),
                                     new SqlParameter("@OgrElemaniSoyad", ogm.OgrElemaniSoyad),
                                     new SqlParameter("@BolumlerID", ogm.BolumlerID),
                                     new SqlParameter("@OgrElemaniSifre", ogm.OgrElemaniSifre),
                                     new SqlParameter("@OgrElemaniSicilNo", ogm.OgrElemaniSicilNo)};
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Insert into OgrElemani values(OgrElemaniTC,OgrElemaniAdi,OgrElemaniSoyad,BolumlerID,OgrElemaniSifre,OgrElemaniSicilNo)", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


       
    }
}
