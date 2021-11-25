using DAL;
using MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
    public class OgrencilerBLL
    {
        int oNo;
        Helper hlp = Helper.Ornek;
        public OgrenciModel OgrenciGiris(string OgrenciNo, string OgrenciSifre)
        {
            OgrenciModel om;

            try
            {
                SqlParameter[] p = { new SqlParameter("@OgrenciNo", OgrenciNo), new SqlParameter("@OgrenciSifre", OgrenciSifre) };
                Helper hlp = Helper.Ornek;
                SqlDataReader dr = hlp.ExecuteReader("Select OgrenciID,OgrenciNo,OgrenciAdi,OgrenciSoyadi,OgrenciSifre,BolumlerID from Ogrenciler where OgrenciNo=@OgrenciNo and OgrenciSifre=@OgrenciSifre ", p);
                if (dr.Read())
                {
                    om = new OgrenciModel();
                    om.OgrenciNo = Convert.ToInt32(dr["OgrenciNo"].ToString());
                    oNo= Convert.ToInt32(dr["OgrenciNo"].ToString());
                    om.OgrenciSifre = dr["OgrenciSifre"].ToString();
                }
                else
                {
                    om = null;

                }

                return om;
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
        public bool Ekle(OgrenciModel om)
        {
            try
            {

                SqlParameter[] p = { new SqlParameter("@OgrID", om.OgrenciID),
                    new SqlParameter("@No", om.OgrenciNo),
                    new SqlParameter("@Ad", om.OgrenciAdi),
                    new SqlParameter("@Soyad", om.OgrenciSoyadi),
                    new SqlParameter("@Sifre", om.OgrenciSifre),
                    new SqlParameter("@BolumID", om.BolumlerID)
                };
                Helper hlp = Helper.Ornek;

                return hlp.ExecuteNonQuery("Insert into Ogrenciler values(@No,@Ad,@Soyad,@Sifre,@BolumID)", p) > 0;
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

        public List<OgrenciModel> TumOgrencileriGetir()
        {

            SqlDataReader dr = hlp.ExecuteReader("Select OgrenciID,OgrenciNo,OgrenciAdi,OgrenciSoyadi,OgrenciSifre,BolumlerID from Ogrenciler", null);

            List<OgrenciModel> listogr = new List<OgrenciModel>();

            while (dr.Read())
            {

                OgrenciModel modelogrn = new OgrenciModel
                {
                    OgrenciAdi = dr["OgrenciAdi"].ToString(),
                    OgrenciSoyadi = dr["OgrenciSoyadi"].ToString(),
                    OgrenciNo= Convert.ToInt32(dr["OgrenciNo"]),
                    OgrenciID = Convert.ToInt32(dr["OgrenciID"]),
                    BolumlerID= Convert.ToInt32(dr["BolumlerID"]),

                };
                listogr.Add(modelogrn);
            }
            dr.Close();
            return listogr;
        }

        public DataTable OgrenciGetir()
        {
            
           // SqlParameter[] p = { new SqlParameter("@OgrNo", oNo) };
          //  string cmdtext1 = "SELECT  Dersler.DersKodu, Devamsızlık.Tarih, Donem.DönemAdi, SınavTipleri.SınavTipAdi, SınavTipleri.Agırlık, OgrenciNot.[Not], Ogrenciler.OgrenciNo, Ogrenciler.OgrenciAdi, Ogrenciler.OgrenciSoyadi FROM Dersler INNER JOIN Devamsızlık ON Dersler.DersID = Devamsızlık.DersID INNER JOIN Donem ON Dersler.DönemID = Donem.DönemID INNER JOIN Ogrenciler ON Devamsızlık.OgrenciID = Ogrenciler.OgrenciID INNER JOIN OgrenciNot ON Donem.DönemID = OgrenciNot.DönemID AND Ogrenciler.OgrenciID = OgrenciNot.OgrenciID INNER JOIN SınavTipleri ON OgrenciNot.SınavTipID = SınavTipleri.SınavTipID WHERE @OgrNo=OgrenciID";

         return    hlp.MyDataTable("SELECT  OgrenciNot.NotID, Ogrenciler.OgrenciNo, Donem.DönemAdi, SınavTipleri.SınavTipAdi, Dersler.DersKodu, OgrenciNot.[Not], Devamsızlık.Tarih FROM   Dersler INNER JOIN Devamsızlık ON Dersler.DersID = Devamsızlık.DersID INNER JOIN Donem ON Dersler.DönemID = Donem.DönemID INNER JOIN Ogrenciler ON Devamsızlık.OgrenciID = Ogrenciler.OgrenciID INNER JOIN OgrenciNot ON Donem.DönemID = OgrenciNot.DönemID AND Ogrenciler.OgrenciID = OgrenciNot.OgrenciID INNER JOIN SınavTipleri ON OgrenciNot.SınavTipID = SınavTipleri.SınavTipID", null);
           
        }
        public bool Sil(int no)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@No", no) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Delete from Ogrenciler where OgrenciNo=@No", p) > 0;
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
        public bool Guncelle(OgrenciModel oem)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@ID", oem.OgrenciID),new SqlParameter("@No", oem.OgrenciNo), new SqlParameter("@Ad", oem.OgrenciAdi), new SqlParameter("@Soyad", oem.OgrenciSoyadi), new SqlParameter("@Sifre", oem.OgrenciSifre), new SqlParameter("@BolumlerID", oem.BolumlerID) };
                Helper hlp = Helper.Ornek;
                return hlp.ExecuteNonQuery("Update Ogrenciler set OgrenciID=@ID,OgrenciNo=@No ,OgrenciAdi=@Ad,OgrenciSoyadi,OgrenciSifre=@Sifre,BolumlerID=@BolumlerID where OgrenciNo=@No", p) > 0;
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
       
    }
}
