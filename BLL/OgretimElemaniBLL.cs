using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OgretimElemaniBLL
    {
        public OgretimElemaniModel OgretimElemanıGiris(string OgrElemaniTC, string OgrElemaniSifre)
        {


            try
            {
                OgretimElemaniModel ogrm = new OgretimElemaniModel();
                
                SqlParameter[] p = { new SqlParameter("@OgrElemaniTC", OgrElemaniTC), new SqlParameter("@OgrElemaniSifre", OgrElemaniSifre) };
                Helper hlp = Helper.Ornek;
                SqlDataReader dr = hlp.ExecuteReader("Select OgrElemaniTC,OgrElemaniAdi,OgrElemaniSoyad,BolumlerID,OgrElemaniSifre,OgrElemaniSicilNo from OgrElemani where OgrElemaniTC=@OgrElemaniTC and OgrElemaniSifre=@OgrElemaniSifre", p);
                if (dr.Read())
                {
                    ogrm = new OgretimElemaniModel();

                }
                else
                {
                    ogrm = null;

                }

                return ogrm;
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

        public bool OgretimElemanıEkle(OgretimElemaniModel oem)
        {

            try
            {
                SqlParameter[] p = {new SqlParameter("@OgrElemaniTC", oem.OgrElemaniTC),
                     new SqlParameter("@OgrElemaniAdi", oem.OgrElemaniAdi),
                      new SqlParameter("@OgrElemaniSoyad", oem.OgrElemaniSoyad),
                      new SqlParameter ("@OgrElemaniSicilNo" , oem.OgrElemaniSicilNo),
                       new SqlParameter("@OgrElemaniSifre", oem.OgrElemaniSifre),
                       new SqlParameter("@OgrElamaniBolumID",oem.BolumlerID)
                     };

                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Insert into OgrElemani values (@OgrElemaniTC,@OgrElemaniAdi,@OgrElemaniSoyad,@OgrElamaniBolumID,@OgrElemaniSifre,@OgrElemaniSicilNo) ", p) > 0;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw;
            }



        }

        public bool Guncelle(OgretimElemaniModel oem)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Tc", oem.OgrElemaniTC), new SqlParameter("@Ad", oem.OgrElemaniAdi), new SqlParameter("@Soyad", oem.OgrElemaniSoyad), new SqlParameter("@BolumID", oem.BolumlerID), new SqlParameter("@sİFRE", oem.OgrElemaniSifre), new SqlParameter("@Sifre", oem.OgrElemaniSifre), new SqlParameter("@SicilNo", oem.OgrElemaniSicilNo) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Update OgrElemani set OgrElemaniTC=@Tc, OgrElemaniAdi=@Ad,OgrElemaniSoyad=@Soyad,BolumlerID=@BolumID,OgrElemaniSifre=@Sifre,OgrElemaniSicilNo=@SicilNo where OgrElemaniTC=@Tc", p) > 0;
            }
            catch (SqlException ex)
            {

                throw;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public bool Sil(OgretimElemaniModel oeb)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@Tc", oeb.OgrElemaniTC) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Delete from OgrElemani where @Tc=OgrElemaniTC", p) > 0;
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
