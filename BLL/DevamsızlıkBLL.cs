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
  public  class DevamsızlıkBLL
    {
        public bool Ekle(DevamsızlıkModel om)
        {
            try
            {

                SqlParameter[] p = { new SqlParameter("@OgrID", om.OgrenciID),
                    new SqlParameter("@DersID", om.DersID),
                   new SqlParameter("@Tarih", om.Tarih)
                };
                Helper hlp = Helper.Ornek;

                return hlp.ExecuteNonQuery("Insert into Devamsızlık values(@OgrID,@DersID,@Tarih)", p) > 0;
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
