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
            return DonDatXeDAO.Instance.CreateDonDatXe(donDatXe,listtinhNang);
        }

        public List<DonDatXeDTO> GetDonDatXeList()
        {
            return DonDatXeDAO.Instance.GetDonDatXeList();
        }

        public List<DonDatXeDTO> Search(string key)
        {
            return DonDatXeDAO.Instance.SearchByConditions(key);
        }

        public List<string> getListTinhNangByID(int donDatXeID)
        {
            return DonDatXeDAO.Instance.GetTinhNangListByDonDatXe(donDatXeID);
        }
        
    }
}
