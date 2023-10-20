using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DonDatXeDAO
    {
        private static DonDatXeDAO instance;

        public static DonDatXeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonDatXeDAO();
                return instance;
            }
        }
        public List<DonDatXeDTO> GetDonDatXeList()
        {
            string query = "SELECT * FROM DonDatXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<DonDatXeDTO> donDatXeList = new List<DonDatXeDTO>();
            foreach (DataRow row in data.Rows)
            {
                DonDatXeDTO donDatXe = new DonDatXeDTO
                {
                    DonDatXeID = Convert.ToInt32(row["DonDatXeID"]),
                    KhachHangID = Convert.ToInt32(row["KhachHangID"]),
                    XeOtoID = Convert.ToInt32(row["XeOtoID"]),
                    GiaThue = Double.Parse(row["GiaThue"].ToString()),
                    NhienLieu = row["NhienLieu"].ToString(),
                    ThoiGianThue = Convert.ToDateTime(row["ThoiGianThue"]),
                    TinhTrangThanhToan = Convert.ToBoolean(row["TinhTrangThanhToan"])
                };
                donDatXeList.Add(donDatXe);
            }
            return donDatXeList;
        }

        public bool CreateDonDatXe(DonDatXeDTO donDatXe, List<string>tinhNangIDList)
        {
            string query = "INSERT INTO DonDatXe (KhachHangID, XeOtoID, ThoiGianThue, TinhTrangThanhToan, NhienLieu, GiaThue) " +
                           "VALUES (@KhachHangID , @XeOtoID , @ThoiGianThue , @TinhTrangThanhToan , @NhienLieu , @GiaThue )";
            object[] parameters = { donDatXe.KhachHangID, donDatXe.XeOtoID, donDatXe.ThoiGianThue, donDatXe.TinhTrangThanhToan, donDatXe.NhienLieu,donDatXe.GiaThue};
            int donDatXeID = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
            foreach (string item in tinhNangIDList)
            {
                AddTinhNangToDonDatXe(donDatXeID,int.Parse(item));
            }

            return donDatXeID > 0;
        }

        public bool UpdateDonDatXe(DonDatXeDTO donDatXe)
        {
            string query = "UPDATE DonDatXe " +
                           "SET KhachHangID = @KhachHangID, XeOtoID = @XeOtoID, " +
                           "ThoiGianThue = @ThoiGianThue , TinhTrangThanhToan = @TinhTrangThanhToan " +
                           "WHERE DonDatXeID = @DonDatXeID";
            object[] parameters = { donDatXe.KhachHangID, donDatXe.XeOtoID, donDatXe.ThoiGianThue, donDatXe.TinhTrangThanhToan, donDatXe.DonDatXeID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteDonDatXe(int donDatXeID)
        {
            string query = "DELETE FROM DonDatXe WHERE DonDatXeID = @DonDatXeID";
            object[] parameters = { donDatXeID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool AddTinhNangToDonDatXe(int donDatXeID, int tinhNangID)
        {
            // Kiểm tra xem đơn đặt xe và tính năng đã được liên kết chưa, nếu đã liên kết thì không thêm nữa
            string checkQuery = "SELECT COUNT(*) FROM DonDatXe_TinhNang WHERE DonDatXeID = @DonDatXeID AND TinhNangID = @TinhNangID";
            object[] checkParameters = { donDatXeID, tinhNangID };
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(checkQuery, checkParameters));

            if (count > 0)
            {
                return false; // Đơn đặt xe đã có tính năng này
            }

            // Nếu chưa có liên kết, thêm liên kết mới
            string query = "INSERT INTO DonDatXe_TinhNang (DonDatXeID, TinhNangID) " +
                           "VALUES ( @DonDatXeID , @TinhNangID)";
            object[] parameters = { donDatXeID, tinhNangID };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<string> GetTinhNangListByDonDatXe(int donDatXeID)
        {
            List<string> tinhNangList = new List<string>();

            string query = "SELECT * FROM DonDatXe_TinhNang WHERE DonDatXeID = @donDatXeID";
            object[] parameters = { donDatXeID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                tinhNangList.Add(row["TinhNangID"].ToString());
            }

            return tinhNangList;
        }

        public List<DonDatXeDTO> SearchByConditions(string keyword)
        {
            string query = "SELECT * FROM DonDatXe WHERE TenKhachHang LIKE '%' + @TenKhachHang + '%' OR DonDatXeID LIKE '%' + @DonDatXeID + '%' OR XeOtoID LIKE '%' + @XeOtoID + '%' OR KhachHangID LIKE '%' + @KhachHangID + '%'";
            object[] parameters = { keyword, keyword, keyword,keyword };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<DonDatXeDTO> donDatXeList = new List<DonDatXeDTO>();
            foreach (DataRow row in data.Rows)
            {
                DonDatXeDTO donDatXe = new DonDatXeDTO
                {
                    DonDatXeID = Convert.ToInt32(row["DonDatXeID"]),
                    KhachHangID = Convert.ToInt32(row["KhachHangID"]),
                    XeOtoID = Convert.ToInt32(row["XeOtoID"]),
                    GiaThue = Double.Parse(row["GiaThue"].ToString()),
                    NhienLieu = row["NhienLieu"].ToString(),
                    ThoiGianThue = Convert.ToDateTime(row["ThoiGianThue"]),
                    TinhTrangThanhToan = Convert.ToBoolean(row["TinhTrangThanhToan"])
                };
                donDatXeList.Add(donDatXe);
            }
            return donDatXeList;
        }

    }

}
