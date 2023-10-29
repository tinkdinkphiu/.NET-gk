using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public bool UpDateDonDatXe(DonDatXeDTO donDatXe)
        {
            return DonDatXeDAO.Instance.UpdateDonDatXe(donDatXe);
        }        
        public bool PaymentComfirm(DonDatXeDTO donDatXe)
        {
            XeOtoBUS.Instance.UpdateTrangThai(donDatXe.XeOtoID, true);
            return DonDatXeDAO.Instance.UpdateDonDatXe(donDatXe);
        }

        public bool AddDonDatXe(KhachHangDTO khachHang, List<string> listtinhNang, DonDatXeDTO donDatXe)
        {
            KhachHangDTO newKH = KhachHangBUS.Instance.GetKhachHangByEmail(khachHang.Email);
            if ( newKH == null )
            {
               bool task = KhachHangBUS.Instance.AddKhachHang(khachHang);
               if ( !task )
                {
                    return false;
                }
            }
            newKH = KhachHangBUS.Instance.GetKhachHangByEmail(khachHang.Email);
            donDatXe.KhachHangID = newKH.KhachHangID;
            if (DonDatXeDAO.Instance.CreateDonDatXe(donDatXe, listtinhNang))
            {
                return XeOtoBUS.Instance.UpdateTrangThai(donDatXe.XeOtoID, false);
            }
            return false;
        }

        public List<DonDatXeDTO> GetDonDatXeList()
        {
            return DonDatXeDAO.Instance.GetDonDatXeList();
        }

        public List<DonDatXeDTO> Search(string key)
        {
            return DonDatXeDAO.Instance.SearchByConditions(key);
        }

        public List<string> getListTinhNangByID(string donDatXeID)
        {
            return DonDatXeDAO.Instance.GetTinhNangListByDonDatXe(donDatXeID);
        }
        
        public List<StaticsDTO> GetRevenueByHang(DateTime start, DateTime dateTime)
        {
            return DonDatXeDAO.Instance.GetRevenueByHang(start, dateTime);
        }

        public List<StaticsDTO> GetRevenueByModel(DateTime start, DateTime dateTime)
        {
            return DonDatXeDAO.Instance.GetRevenueByModel(start, dateTime);
        }        
        public List<StaticsDTO> GetCarDistributionByType()
        {
            return DonDatXeDAO.Instance.GetCarDistributionByType();
        }        
        
        public List<StaticsDTO> GetRevenueOfYear(int year)
        {
            return DonDatXeDAO.Instance.GetRevenueOfYear(year);
        }
    }
}
