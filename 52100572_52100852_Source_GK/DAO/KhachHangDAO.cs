using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class KhachHangDAO
    {
        public List<KhachHangDTO> GetKhachHangList()
        {
            string query = "SELECT * FROM KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<KhachHangDTO> khachHangList = new List<KhachHangDTO>();
            foreach (DataRow row in data.Rows)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    KhachHangID = Convert.ToInt32(row["KhachHangID"]),
                    Ten = row["Ten"].ToString(),
                    SoDienThoai = row["SoDienThoai"].ToString(),
                    DiaChi = row["DiaChi"].ToString(),
                    Email = row["Email"].ToString()
                };
                khachHangList.Add(khachHang);
            }
            return khachHangList;
        }

        public bool AddKhachHang(KhachHangDTO khachHang)
        {
            string query = "INSERT INTO KhachHang (Ten, SoDienThoai, DiaChi, Email) " +
                           "VALUES (@Ten, @SoDienThoai, @DiaChi, @Email)";
            object[] parameters = { khachHang.Ten, khachHang.SoDienThoai, khachHang.DiaChi, khachHang.Email };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateKhachHang(KhachHangDTO khachHang)
        {
            string query = "UPDATE KhachHang " +
                           "SET Ten = @Ten, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, Email = @Email " +
                           "WHERE KhachHangID = @KhachHangID";
            object[] parameters = { khachHang.Ten, khachHang.SoDienThoai, khachHang.DiaChi, khachHang.Email, khachHang.KhachHangID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteKhachHang(int khachHangID)
        {
            string query = "DELETE FROM KhachHang WHERE KhachHangID = @KhachHangID";
            object[] parameters = { khachHangID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        // Thêm các phương thức khác như tìm kiếm theo tên, số điện thoại, địa chỉ, vv.
    }

}
