using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_223LTC01_KTGK
{
    class TaiLieu
    {
        public int MaXB { get; set; }
        public string TenTL { get; set; }
        public string NPH { get; set; }
        public int MaDM { get; set; }

        protected TaiLieu(int maXB, string tenTL, string nph, int maDM)
        {
            MaXB = maXB;
            TenTL = tenTL;
            NPH = nph;
            MaDM = maDM;
        }
    }
}
