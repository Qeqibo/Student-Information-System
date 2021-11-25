using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELs
{
  public  class OgrenciNotModel
    {
        public int NotID { get; set; }
        public int OgrenciID { get; set; }
        public int DönemID { get; set; }
        public int SınavTipID { get; set; }
        public string DersKodu { get; set; }
        public int Not { get; set; }

    }
}
