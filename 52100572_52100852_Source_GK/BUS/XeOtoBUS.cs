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
        private XeOtoDAO xeOtoDAO;

        public XeOtoBUS()
        {
            xeOtoDAO = XeOtoDAO.Instance;
        }

        public List<XeOtoDTO> GetXeOtoList()
        {
            return xeOtoDAO.GetXeOtoList();
        }

        public bool AddXeOto(XeOtoDTO xeOto, List<TinhNangDTO> listtinhNang)
        {
            // Thêm xử lý validation nếu cần
            if (xeOto.HangXe == null || xeOto.Model == null || xeOto.LoaiXe == null)
            {
                // Xử lý lỗi hoặc thông báo
                return false;
            }

            return xeOtoDAO.AddXeOto(xeOto, listtinhNang);
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

        public bool DeleteXeOto(int xeOtoID)
        {
            return xeOtoDAO.DeleteXeOto(xeOtoID);
        }

        public List<XeOtoDTO> SearchXeOto(string keyword)
        {
            return xeOtoDAO.SearchXeOtoByConditions(keyword);
        }

        public XeOtoDTO GetXeOtoByID(int xeOtoID)
        {
            return xeOtoDAO.GetXeOtoByID(xeOtoID);
        }
    }

}
