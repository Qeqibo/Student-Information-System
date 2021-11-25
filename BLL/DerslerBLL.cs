using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MODEL;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
 public   class DerslerBLL
    {
        Helper hlp = Helper.Ornek;
        public List<DerslerModel> TumDersleriGetir()
        {

            SqlDataReader dr = hlp.ExecuteReader("Select DersID,DersKodu,BolumlerID,DönemID from Dersler", null);

            List<DerslerModel> listders = new List<DerslerModel>();

            while (dr.Read())
            {

                DerslerModel modelders = new DerslerModel
                {
                    DersKodu = dr["DersKodu"].ToString(),
                    
                    DersID = Convert.ToInt32(dr["DersID"]),
                   
                    BolumlerID = Convert.ToInt32(dr["BolumlerID"]),
                    DonemID = Convert.ToInt32(dr["DönemID"])

                };
                listders.Add(modelders);
            }
            dr.Close();
            return listders;
        }
    }
}
