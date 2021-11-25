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
    public class BolumlerBLL
    {
        Helper hlp = Helper.Ornek;

        public bool BolumEkle(BolumlerModel bm)
        {
            try
            {
                SqlParameter[] p = { new SqlParameter("@BolumAdi", bm.BolumAdi), new SqlParameter("@AkademikBirimID", bm.AkademikBirimID) };
                return hlp.ExecuteNonQuery("Insert into Bolumler (BolumAdi,AkademikBirimID) values(@BolumAdi,@AkademikBirimID)", p) > 0;
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
        public bool BolumSil(int BolumlerId)
        {

            try
            {
                SqlParameter[] p = { new SqlParameter("@BolumlerID", BolumlerId) };
                return hlp.ExecuteNonQuery("DELETE FROM Bolumler WHERE BolumlerID=@BolumlerID", p) > 0;

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


        public List<BolumlerModel> TumBolumGetir()
        {
            SqlDataReader dr = hlp.ExecuteReader("Select BolumlerID,BolumAdi,AkademikBirimID from Bolumler", null);

            List<BolumlerModel> oum = new List<BolumlerModel>();

            while (dr.Read())
            {

                BolumlerModel bm = new BolumlerModel
                {
                    BolumAdi = dr["BolumAdi"].ToString(),
                    BolumlerID = Convert.ToInt32(dr["BolumlerID"]),
                    AkademikBirimID = Convert.ToInt32(dr["AkademikBirimID"]),


                };
                oum.Add(bm);
            }
            dr.Close();
            return oum;
        }
    }
}
