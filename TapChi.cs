using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_223LTC01_KTGK
{
    class TapChi : TaiLieu
    {
        public int SoPH { get; set; }
        public int TrangPH { get; set; }

        public TapChi(int maXB, string tenTL, string nph, int maDM, int soPH, int trangPH) :base(maXB, tenTL, nph, maDM)
        {
            SoPH = soPH;
            TrangPH = trangPH;
        }
    }
}
