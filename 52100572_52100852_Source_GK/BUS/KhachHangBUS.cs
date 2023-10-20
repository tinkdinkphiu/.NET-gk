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

        public bool AddKhachHang(KhachHangDTO khachHang)
        {
            // Thêm xử lý validation nếu cần
            if (string.IsNullOrEmpty(khachHang.Ten) || string.IsNullOrEmpty(khachHang.SoDienThoai) || string.IsNullOrEmpty(khachHang.DiaChi) || string.IsNullOrEmpty(khachHang.Email))
            {
                // Xử lý lỗi hoặc thông báo
                return false;
            }

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

        public bool DeleteKhachHang(int khachHangID)
        {
            return khachHangDAO.DeleteKhachHang(khachHangID);
        }

        public KhachHangDTO GetKhachHangByID(int xeOtoID)
        {
            return khachHangDAO.GetKhachHangByID(xeOtoID);
        }
    }
}