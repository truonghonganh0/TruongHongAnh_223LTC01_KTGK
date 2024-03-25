using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruongHongAnh_223LTC01_KTGK
{
    class DanhMuc
    {
        public int ID { get; set; }
        public string TenDM { get; set; }
        public int maSach { get; set; }
        public int maBao {get; set;}
        public int maTapChi { get; set; }

        public DanhMuc(int id, string tenDM, int maSach, int maBao, int maTapChi)
        {
            ID = id;
            TenDM = tenDM;
            this.maSach = maSach;
            this.maBao = maBao;
            this.maTapChi = maTapChi;
        }
    }
}
