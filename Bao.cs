using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_223LTC01_KTGK
{
    class Bao : TaiLieu
    {
        public DateTime NgayPH { get; set; }

        public Bao(int maXB, string tenTL, string nph, int maDM, DateTime ngayPH) : base(maXB, tenTL, nph, maDM)
        {
            NgayPH = ngayPH;
        }
    }
}
