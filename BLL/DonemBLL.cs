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
public    class DonemBLL
    {
        Helper hlp = Helper.Ornek;
        public List<DönemModel> TumDonemleriGetir()
        {

            SqlDataReader dr = hlp.ExecuteReader("Select DönemID,DönemAdi from Donem", null);

            List<DönemModel> listdonem = new List<DönemModel>();

            while (dr.Read())
            {

                DönemModel modeldonem = new DönemModel
                {
                    DonemAdi = dr["DönemAdi"].ToString(),
               
                    DönemID = Convert.ToInt32(dr["DönemID"])
                  

                };
                listdonem.Add(modeldonem);
            }
            dr.Close();
            return listdonem;
        }
    }
}

