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
                    NhienLieu = row["NhienLieu"].ToString(),
                    ThoiGianThue = Convert.ToDateTime(row["ThoiGianThue"]),
                    TinhTrangThanhToan = Convert.ToBoolean(row["TinhTrangThanhToan"])
                };
                donDatXeList.Add(donDatXe);
            }
            return donDatXeList;
        }

        public bool CreateDonDatXe(DonDatXeDTO donDatXe)
        {
            string query = "INSERT INTO DonDatXe (KhachHangID, XeOtoID, ThoiGianThue, TinhTrangThanhToan) " +
                           "VALUES (@KhachHangID, @XeOtoID, @ThoiGianThue, @TinhTrangThanhToan)";
            object[] parameters = { donDatXe.KhachHangID, donDatXe.XeOtoID, donDatXe.ThoiGianThue, donDatXe.TinhTrangThanhToan };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool UpdateDonDatXe(DonDatXeDTO donDatXe)
        {
            string query = "UPDATE DonDatXe " +
                           "SET KhachHangID = @KhachHangID, XeOtoID = @XeOtoID, " +
                           "ThoiGianThue = @ThoiGianThue, TinhTrangThanhToan = @TinhTrangThanhToan " +
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

    }

}
