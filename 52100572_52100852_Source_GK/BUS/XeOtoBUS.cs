using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class XeOtoBUS
    {
        private XeOtoDAO xeOtoDAO = XeOtoDAO.Instance;

        private static XeOtoBUS instance;

        public static XeOtoBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeOtoBUS();
                return instance;
            }
        }

        public List<XeOtoDTO> GetXeOtoList()
        {
            return xeOtoDAO.GetXeOtoList();
        }        
        

        public List<TinhNangDTO> GetTinhNangList()
        {
            return TinhNangDAO.Instance.GetAllTinhNang();
        }

        public bool AddXeOto(XeOtoDTO xeOto)
        {
            // Thêm xử lý validation nếu cần
            if (xeOto.HangXe == null || xeOto.Model == null || xeOto.LoaiXe == null)
            {
                // Xử lý lỗi hoặc thông báo
                return false;
            }

            return xeOtoDAO.AddXeOto(xeOto);
        }

        public bool UpdateXeOto(XeOtoDTO xeOto)
        {
            // Thêm xử lý validation nếu cần
            if (xeOto.HangXe == null || xeOto.Model == null || xeOto.LoaiXe == null)
            {
                // Xử lý lỗi hoặc thông báo
                return false;
            }

            return xeOtoDAO.UpdateXeOto(xeOto);
        }

        public bool UpdateTrangThai(string xeOtoID, bool isAvaiable)
        {
            // Thêm xử lý validation nếu cần
            if (isAvaiable)
            {
                return xeOtoDAO.UpdateTrangThai(xeOtoID, "Sẵn sàng");
            }
            return xeOtoDAO.UpdateTrangThai(xeOtoID, "Đang cho thuê");
        }

        public bool DeleteXeOto(string xeOtoID)
        {
            return xeOtoDAO.DeleteXeOto(xeOtoID);
        }

        public List<XeOtoDTO> SearchXeOto(string keyword)
        {
            return xeOtoDAO.SearchXeOtoByConditions(keyword);
        }

        public XeOtoDTO GetXeOtoByID(string xeOtoID)
        {
            return xeOtoDAO.GetXeOtoByID(xeOtoID);
        }

        public bool isAvaiable(string xeOtoID)
        {
            return xeOtoDAO.GetXeOtoByID(xeOtoID).TrangThai.Equals("Sẵn sàng");
        }
    }

}
