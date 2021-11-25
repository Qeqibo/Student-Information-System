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
   
    public class AkademikBirimBLL
    {
        Helper hlp = Helper.Ornek;
        public bool AkademikBirimEkle(AkademikBirimModel abm)
        {

            try
            {
                SqlParameter[] p = { new SqlParameter("@AkademikBirimAdi", abm.AkademikBirimAdi) };

                return hlp.ExecuteNonQuery("Insert into AkademikBirim values (@AkademikBirimAdi)", p) > 0;

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


        public List<AkademikBirimModel> TumAkademikBirimGetir()
        {

            SqlDataReader dr = hlp.ExecuteReader("Select AkademikBirimID,AkademikBirimAdi from AkademikBirim", null);

            List<AkademikBirimModel> abm = new List<AkademikBirimModel>();

            while (dr.Read())
            {

                AkademikBirimModel akbm = new AkademikBirimModel
                {
                    AkademikBirimAdi = dr["AkademikBirimAdi"].ToString(),
                    AkademikBirimID = Convert.ToInt32(dr["AkademikBirimID"]),

                };
                abm.Add(akbm);
            }
            dr.Close();
            return abm;
        }
    }
}




