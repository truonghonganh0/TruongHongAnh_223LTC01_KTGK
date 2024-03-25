using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_223LTC01_KTGK
{
    class Sach : TaiLieu
    {
        public string TenTG {get; set;}
        public int SoTrang { get; set; }

        public Sach(int maXB, string tenTL, string nph, int maDM, string tenTG, int sotrang) : base(maXB, tenTL, nph, maDM)
        {
            TenTG = tenTG;
            SoTrang = sotrang;
        }
    }
}
