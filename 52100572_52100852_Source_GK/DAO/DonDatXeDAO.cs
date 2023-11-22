using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
                DateTime? thoigiantra = null;
                try
                {
                    thoigiantra = Convert.ToDateTime(row["ThoiGianTra"]);
                }
                catch
                {

                }

                DonDatXeDTO donDatXe = new DonDatXeDTO
                {
                    DonDatXeID = row["DonDatXeID"].ToString(),
                    KhachHangID = row["KhachHangID"].ToString(),
                    XeOtoID = row["XeOtoID"].ToString(),
                    GiaThue = Double.Parse(row["GiaThue"].ToString()),
                    NhienLieu = row["NhienLieu"].ToString(),
                    DiemDen = row["DiemDen"].ToString(),
                    ThoiGianTraDK = Convert.ToDateTime(row["ThoiGianTraDK"]),
                    ThoiGianThue = Convert.ToDateTime(row["ThoiGianThue"]),
                    TinhTrangThanhToan = Convert.ToBoolean(row["TinhTrangThanhToan"]),
                    Total = Double.Parse(row["Total"].ToString()),
                    ThoiGianTra = thoigiantra
                };
                donDatXeList.Add(donDatXe);
            }
            return donDatXeList;
        }

        public bool CreateDonDatXe(DonDatXeDTO donDatXe, List<string> tinhNangIDList)
        {
            string query = "INSERT INTO DonDatXe (KhachHangID, XeOtoID, ThoiGianThue, TinhTrangThanhToan, NhienLieu, GiaThue, DiemDen, ThoiGianTraDK) " +
                           "VALUES ( @KhachHangID , @XeOtoID , @ThoiGianThue , @TinhTrangThanhToan , @NhienLieu , @GiaThue , @DiemDen , @ThoiGianTraDK ); " +
                           "SELECT SCOPE_IDENTITY();";
            object[] parameters = { donDatXe.KhachHangID, donDatXe.XeOtoID, donDatXe.ThoiGianThue, 
                donDatXe.TinhTrangThanhToan, donDatXe.NhienLieu, donDatXe.GiaThue, donDatXe.DiemDen, donDatXe.ThoiGianTraDK};
            int donDatXeID = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
            foreach (string item in tinhNangIDList)
            {
                AddTinhNangToDonDatXe(donDatXeID, int.Parse(item));
            }

            return donDatXeID >= 0;
        }
        public bool UpdateDonDatXe(DonDatXeDTO donDatXe)
        {
            string query = "UPDATE [dbo].[DonDatXe] " +
                           "SET [KhachHangID] = @KhachHangID , " +
                               "[XeOtoID] = @XeOtoID , " +
                               "[ThoiGianThue] = @ThoiGianThue , " +
                               "[TinhTrangThanhToan] = @TinhTrangThanhToan , " +
                               "[Total] = @Total , " +
                               "[ThoiGianTra] = @ThoiGianTra " +
                               "[ThoiGianTraDK] = @ThoiGianTraDK " +
                               "[DiemDen] = @DiemDen " + 
                           "WHERE DonDatXeID = @DonDatXeID";

            object[] parameters = {
                donDatXe.KhachHangID,
                donDatXe.XeOtoID,
                donDatXe.ThoiGianThue,
                donDatXe.TinhTrangThanhToan,
                donDatXe.Total,
                donDatXe.ThoiGianTra,
                donDatXe.DonDatXeID,
                donDatXe.ThoiGianTraDK,
                donDatXe.DiemDen
            };

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
                           "VALUES ( @DonDatXeID , @TinhNangID )";
            object[] parameters = { donDatXeID, tinhNangID };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<string> GetTinhNangListByDonDatXe(string donDatXeID)
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
            string query = "SELECT * FROM DonDatXe WHERE  DonDatXeID LIKE '%' + @DonDatXeID + '%' OR XeOtoID LIKE '%' + @XeOtoID + '%' OR KhachHangID LIKE '%' + @KhachHangID + '%' ";
            object[] parameters = { keyword, keyword, keyword };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<DonDatXeDTO> donDatXeList = new List<DonDatXeDTO>();
            foreach (DataRow row in data.Rows)
            {
                DateTime? thoigiantra = null;
                try
                {
                    thoigiantra = Convert.ToDateTime(row["ThoiGianTra"]);
                }
                catch
                {

                }

                DonDatXeDTO donDatXe = new DonDatXeDTO
                {
                    DonDatXeID = row["DonDatXeID"].ToString(),
                    KhachHangID = row["KhachHangID"].ToString(),
                    XeOtoID = row["XeOtoID"].ToString(),
                    GiaThue = Double.Parse(row["GiaThue"].ToString()),
                    NhienLieu = row["NhienLieu"].ToString(),
                    DiemDen = row["DiemDen"].ToString(),
                    ThoiGianTraDK = Convert.ToDateTime(row["ThoiGianTraDK"]),
                    ThoiGianThue = Convert.ToDateTime(row["ThoiGianThue"]),
                    TinhTrangThanhToan = Convert.ToBoolean(row["TinhTrangThanhToan"]),
                    Total = Double.Parse(row["Total"].ToString()),
                    ThoiGianTra = thoigiantra
                };
                donDatXeList.Add(donDatXe);
            }
            return donDatXeList;
        }


        public List<StaticsDTO> GetRevenueByHang(DateTime start, DateTime end)
        {
            string query = "SELECT XeOto.HangXe,  " +
                   "COUNT(DonDatXe.DonDatXeID) AS SoLuong, " +
                   "  SUM(DonDatXe.Total) AS DoanhThu FROM DonDatXe " +
                   "JOIN XeOto ON DonDatXe.XeOtoID = XeOto.XeOtoID " +
                   "WHERE DonDatXe.ThoiGianThue BETWEEN @StartDate AND @EndDate " +
                   "GROUP BY XeOto.HangXe";

            object[] parameters = { start, end };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            List<StaticsDTO> revenues = new List<StaticsDTO>();
            foreach (DataRow row in data.Rows)
            {
               StaticsDTO revenue = new StaticsDTO
               {
                   item1 = row["HangXe"].ToString(),
                   item2 = row["SoLuong"].ToString(),
                   item3 = row["DoanhThu"].ToString()
               };
                revenues.Add(revenue);
            }
            return revenues;
        }

        public List<StaticsDTO> GetRevenueByModel(DateTime start, DateTime end)
        {
            string query = "SELECT XeOto.Model,  " +
                   "COUNT(DonDatXe.DonDatXeID) AS SoLuong, " +
                   "  SUM(DonDatXe.Total) AS DoanhThu FROM DonDatXe " +
                   "JOIN XeOto ON DonDatXe.XeOtoID = XeOto.XeOtoID " +
                   "WHERE DonDatXe.ThoiGianThue BETWEEN @StartDate AND @EndDate " +
                   "GROUP BY XeOto.Model";

            object[] parameters = { start, end };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);
            List<StaticsDTO> revenues = new List<StaticsDTO>();
            foreach (DataRow row in data.Rows)
            {
                StaticsDTO revenue = new StaticsDTO
                {
                    item1 = row["Model"].ToString(),
                    item2 = row["SoLuong"].ToString(),
                    item3 = row["DoanhThu"].ToString()
                };
                revenues.Add(revenue);
            }
            return revenues;
        }
        public List<StaticsDTO> GetCarDistributionByType()
        {
            string query = "SELECT LoaiXe, COUNT(XeOtoID) AS SoLuong " +
                "FROM XeOto GROUP BY LoaiXe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            List<StaticsDTO> revenues = new List<StaticsDTO>();
            foreach (DataRow row in data.Rows)
            {
                StaticsDTO revenue = new StaticsDTO
                {
                    item1 = row["LoaiXe"].ToString(),
                    item2 = row["SoLuong"].ToString(),
                };
                revenues.Add(revenue);
            }
            return revenues;
        }

        public List<StaticsDTO> GetRevenueOfYear(int year)
        {
            string query = "SELECT MONTH(ThoiGianThue) as Thang,  SUM(GiaThue) as DoanhThu " +
                "FROM DonDatXe WHERE YEAR(ThoiGianThue) = @Year GROUP BY MONTH(ThoiGianThue)";
            object[] parameters = { year };
            DataTable data = DataProvider.Instance.ExecuteQuery(query,parameters);
            List<StaticsDTO> revenues = new List<StaticsDTO>();
            foreach (DataRow row in data.Rows)
            {
                StaticsDTO revenue = new StaticsDTO
                {
                    item1 = row["Thang"].ToString(),
                    item2 = row["DoanhThu"].ToString(),
                };
                revenues.Add(revenue);
            }
            return revenues;
        }
    }

}

