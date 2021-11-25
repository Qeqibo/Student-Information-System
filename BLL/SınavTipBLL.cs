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
  public  class SınavTipBLL
    {
        Helper hlp = Helper.Ornek;
        public List<SınavTipModel> TumSınavTipleriniGetir()
        {

            SqlDataReader dr = hlp.ExecuteReader("Select SınavTipID,SınavTipAdi,Agırlık from SınavTipleri", null);

            List<SınavTipModel> listSınav = new List<SınavTipModel>();

            while (dr.Read())
            {

                SınavTipModel modelsınav = new SınavTipModel
                {
                    SınavTipAdi = dr["SınavTipAdi"].ToString(),

                    SınavTipID = Convert.ToInt32(dr["SınavTipID"]),
                    Agırlık= Convert.ToInt32(dr["Agırlık"])


                };
                listSınav.Add(modelsınav);
            }
            dr.Close();
            return listSınav;
        }
    }
}
    

