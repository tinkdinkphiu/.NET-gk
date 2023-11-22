using DTO;
using DAO;
using System;
using System.Collections.Generic;

namespace BUS
{
    public class KhachHangBUS
    {
        private KhachHangDAO khachHangDAO = KhachHangDAO.Instance;

        private static KhachHangBUS instance;

        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
        }

        public List<KhachHangDTO> GetKhachHangList()
        {
            return khachHangDAO.GetKhachHangList();
        }        
        
        public List<KhachHangDTO> Search(string key)
        {
            return khachHangDAO.SearchKhachHangByNameAndPhone(key);
        }

        public bool AddKhachHang(KhachHangDTO khachHang)
        {
            return khachHangDAO.AddKhachHang(khachHang);
        }

        public bool UpdateKhachHang(KhachHangDTO updatedKhachHang)
        {
            // Thêm xử lý validation nếu cần
            if (string.IsNullOrEmpty(updatedKhachHang.Ten) || string.IsNullOrEmpty(updatedKhachHang.SoDienThoai) || string.IsNullOrEmpty(updatedKhachHang.DiaChi) || string.IsNullOrEmpty(updatedKhachHang.Email))
            {
                // Xử lý lỗi hoặc thông báo
                return false;
            }

            return khachHangDAO.UpdateKhachHang(updatedKhachHang);
        }

        public bool DeleteKhachHang(string khachHangID)
        {
            return khachHangDAO.DeleteKhachHang(khachHangID);
        }

        public KhachHangDTO GetKhachHangByID(string xeOtoID)
        {
            return khachHangDAO.GetKhachHangByID(xeOtoID);
        }       
        
        public KhachHangDTO GetKhachHangByPhone(string phone)
        {
            return khachHangDAO.GetKhachHangByPhone(phone);
        }

        public KhachHangDTO GetKhachHangByEmail(string email)
        {
            return khachHangDAO.GetKhachHangByEmail(email);
        }
    }
}