using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonDatXeBUS
    {

        private static DonDatXeBUS instance;

        public static DonDatXeBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonDatXeBUS();
                return instance;
            }
        }

        public bool AddDonDatXe(XeOtoDTO xeOto, List<TinhNangDTO> listtinhNang, string nhienLieu)
        {
            // Thêm xử lý validation nếu cần
            if (xeOto.HangXe == null || xeOto.Model == null || xeOto.LoaiXe == null)
            {
                // Xử lý lỗi hoặc thông báo
                return false;
            }

            return true;
        }
    }
}
