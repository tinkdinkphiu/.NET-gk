using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonDatXeDTO
    {
        public int DonDatXeID { get; set; }
        public int KhachHangID { get; set; }
        public int XeOtoID { get; set; }
        public Double GiaThue { get; set; }
        public string NhienLieu { get; set; }
        public DateTime ThoiGianThue { get; set; }
        public bool TinhTrangThanhToan { get; set; }
    }
}
