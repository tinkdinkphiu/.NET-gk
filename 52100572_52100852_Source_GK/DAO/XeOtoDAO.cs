using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class XeOtoDAO
    {
        private static XeOtoDAO instance;

        public static XeOtoDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new XeOtoDAO();
                return instance;
            }
        }

        public List<XeOtoDTO> GetXeOtoList()
        {
            string query = "SELECT * FROM XeOto";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<XeOtoDTO> xeOtoList = new List<XeOtoDTO>();
            foreach (DataRow row in data.Rows)
            {
                XeOtoDTO xeOto = new XeOtoDTO
                {
                    XeOtoID = Convert.ToInt32(row["XeOtoID"]),
                    HangXe = row["HangXe"].ToString(),
                    Model = row["Model"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    NhienLieu = row["NhienLieu"].ToString(),
                    Gia = Double.Parse(row["GiaThue"].ToString()),
                    TrangThai = row["TrangThai"].ToString()
                };
                xeOtoList.Add(xeOto);
            }
            return xeOtoList;
        }

        public XeOtoDTO GetXeOtoByID(int xeOtoID)
        {
            string query = "SELECT * FROM XeOto WHERE XeOtoID = @XeOtoID";
            object[] parameters = { xeOtoID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                XeOtoDTO xeOto = new XeOtoDTO
                {
                    XeOtoID = Convert.ToInt32(row["XeOtoID"]),
                    HangXe = row["HangXe"].ToString(),
                    Model = row["Model"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    Gia = Double.Parse(row["GiaThue"].ToString()),
                    NhienLieu = row["NhienLieu"].ToString(),
                    TrangThai = row["TrangThai"].ToString()
                };

                // Lấy danh sách XeOto_TinhNangDTO
                List<XeOto_TinhNangDTO> listTinhNang = GetXeOto_TinhNangListByXeOtoID(xeOto.XeOtoID);

                // Xây dựng danh sách TinhNangDTO từ XeOto_TinhNangDTO
                xeOto.TinhNangList = new List<TinhNangDTO>();
                foreach (var xeOto_TinhNang in listTinhNang)
                {
                    TinhNangDTO tinhNang = TinhNangDAO.Instance.GetTinhNangByID(xeOto_TinhNang.TinhNangID);
                    xeOto.TinhNangList.Add(tinhNang);
                }

                return xeOto;
            }
            else
            {
                return null;
            }
        }

        public bool AddXeOto(XeOtoDTO xeOto, List<TinhNangDTO> listTinhNang)
        {
            string query = "INSERT INTO XeOto (HangXe, Model, LoaiXe, NhienLieu, TrangThai, GiaThue ) " +
                           "VALUES ( @HangXe, @Model, @LoaiXe, @NhienLieu, @TrangThai )";
            object[] parameters = { xeOto.HangXe, xeOto.Model, xeOto.LoaiXe, xeOto.NhienLieu, xeOto.TrangThai, xeOto.Gia};
            int xeOToId = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
            foreach (var tinhNang in listTinhNang)
            {
                AddTinhNangToXeOto(xeOToId, tinhNang.TinhNangID);
            }
            return xeOToId > 0;
        }

        public bool UpdateXeOto(XeOtoDTO xeOto)
        {
            string query = "UPDATE XeOto " +
                           "SET HangXe = @HangXe, Model = @Model, LoaiXe = @LoaiXe, NhienLieu = @NhienLieu, TrangThai = @TrangThai , GiaThue = @Gia " +
                           "WHERE XeOtoID = @XeOtoID";
            object[] parameters = { xeOto.HangXe, xeOto.Model, xeOto.LoaiXe, xeOto.NhienLieu, xeOto.TrangThai,xeOto.Gia, xeOto.XeOtoID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteXeOto(int xeOtoID)
        {
            string query = "DELETE FROM XeOto WHERE XeOtoID = @XeOtoID";
            object[] parameters = { xeOtoID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<XeOtoDTO> SearchXeOtoByConditions(string keyword)
        {
            string query = "SELECT * FROM XeOto WHERE HangXe = @keyword OR Model = @keyword OR LoaiXe = @keyword";
            object[] parameters = { keyword, keyword, keyword };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<XeOtoDTO> result = new List<XeOtoDTO>();
            foreach (DataRow row in data.Rows)
            {
                XeOtoDTO xeOto = new XeOtoDTO
                {
                    XeOtoID = Convert.ToInt32(row["XeOtoID"]),
                    HangXe = row["HangXe"].ToString(),
                    Model = row["Model"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    Gia = Double.Parse(row["GiaThue"].ToString()),
                    NhienLieu = row["NhienLieu"].ToString(),
                    TrangThai = row["TrangThai"].ToString()
                };
                result.Add(xeOto);
            }
            return result;
        }
        public bool AddTinhNangToXeOto(int xeOtoID, int tinhNangID)
        {
            // Kiểm tra xem xe ô tô và tính năng đã được liên kết chưa, nếu đã liên kết thì không thêm nữa
            string checkQuery = "SELECT COUNT(*) FROM XeOto_TinhNang WHERE XeOtoID = @XeOtoID AND TinhNangID = @TinhNangID";
            object[] checkParameters = { xeOtoID, tinhNangID };
            int count = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(checkQuery, checkParameters));

            if (count > 0)
            {
                return false; // Xe ô tô đã có tính năng này
            }

            // Nếu chưa có liên kết, thêm liên kết mới
            string query = "INSERT INTO XeOto_TinhNang (XeOtoID, TinhNangID) " +
                           "VALUES (@XeOtoID, @TinhNangID)";
            object[] parameters = { xeOtoID, tinhNangID };

            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<LoaiXeDTO> GetLoaiXeList()
        {
            List<LoaiXeDTO> loaiXeList = new List<LoaiXeDTO>();

            string query = "SELECT * FROM LoaiXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                LoaiXeDTO loaiXe = new LoaiXeDTO
                {
                    LoaiXeID = Convert.ToInt32(row["LoaiXeID"]),
                    TenLoaiXe = row["TenLoaiXe"].ToString(),
                    // Các trường thông tin khác về loại xe
                };

                loaiXeList.Add(loaiXe);
            }

            return loaiXeList;
        }



        public List<XeOto_TinhNangDTO> GetXeOto_TinhNangListByXeOtoID(int xeOtoID)
        {
            List<XeOto_TinhNangDTO> xeOto_TinhNangList = new List<XeOto_TinhNangDTO>();

            string query = "SELECT * FROM XeOto_TinhNang WHERE XeOtoID = @XeOtoID";
            object[] parameters = { xeOtoID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            foreach (DataRow row in data.Rows)
            {
                XeOto_TinhNangDTO xeOto_TinhNang = new XeOto_TinhNangDTO
                {
                    XeOtoID = Convert.ToInt32(row["XeOtoID"]),
                    TinhNangID = Convert.ToInt32(row["TinhNangID"])
                };
                xeOto_TinhNangList.Add(xeOto_TinhNang);
            }

            return xeOto_TinhNangList;
        }
    }

}
