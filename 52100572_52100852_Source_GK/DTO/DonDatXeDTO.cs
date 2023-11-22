using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatXeDTO
    {
        public string DonDatXeID { get; set; }
        public string KhachHangID { get; set; }
        public string XeOtoID { get; set; }
        public string DiemDen  { get; set; }
        public Double GiaThue { get; set; }
        public string NhienLieu { get; set; }
        public DateTime ThoiGianThue { get; set; }
        public DateTime ThoiGianTraDK { get; set; }
        public bool TinhTrangThanhToan { get; set; }

        public Double Total { get; set; }

        public DateTime? ThoiGianTra { get; set; }
    }
}
