using DAL;
using MODEL;
using MODELs;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
public    class NotBLL
    {
        public bool Ekle(OgrenciNotModel om)
        {
            try
            {

                SqlParameter[] p = { new SqlParameter("@OgrID", om.OgrenciID),
                    new SqlParameter("@DonemID", om.DönemID),
                    new SqlParameter("@SınavTipID", om.SınavTipID),
                    new SqlParameter("@DersKodu", om.DersKodu),
                    new SqlParameter("@Not", om.Not)
                  
                };
                Helper hlp = Helper.Ornek;

                return hlp.ExecuteNonQuery("Insert into OgrenciNot values(@OgrID,@DonemID,@SınavTipID,@DersKodu,@Not)", p) > 0;
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
