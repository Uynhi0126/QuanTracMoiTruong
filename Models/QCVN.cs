using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormLogin.Models
{
    public class QCVN
    {
        public string MaQCVN { get; set; }
        public string TenQCVN { get; set; }
        public string MaNenMau { get; set; }
        public string MaChiTieu { get; set; }
        public double? GiaTriMin { get; set; }
        public double? GiaTriMax { get; set; }
        public int NamBanHanh { get; set; }
        public string GhiChu { get; set; }
    }

}
