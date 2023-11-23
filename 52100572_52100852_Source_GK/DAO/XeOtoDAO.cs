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
                    XeOtoID = row["XeOtoID"].ToString(),
                    HangXe = row["HangXe"].ToString(),
                    Model = row["Model"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    Gia = Double.Parse(row["GiaThue"].ToString()),
                    TrangThai = row["TrangThai"].ToString()
                };
                xeOtoList.Add(xeOto);
            }
            return xeOtoList;
        }

        public XeOtoDTO GetXeOtoByID(string xeOtoID)
        {
            string query = "SELECT * FROM XeOto WHERE XeOtoID = @XeOtoID";
            object[] parameters = { xeOtoID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                XeOtoDTO xeOto = new XeOtoDTO
                {
                    XeOtoID = row["XeOtoID"].ToString(),
                    HangXe = row["HangXe"].ToString(),
                    Model = row["Model"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    Gia = Double.Parse(row["GiaThue"].ToString()),
                    TrangThai = row["TrangThai"].ToString()
                };

                return xeOto;
            }
            else
            {
                return null;
            }
        }

        public bool AddXeOto(XeOtoDTO xeOto)
        {
            string query = "INSERT INTO XeOto (HangXe, Model, LoaiXe, TrangThai, GiaThue ) " +
                           "VALUES ( @HangXe , @Model , @LoaiXe , @TrangThai , @GiaThue )";
            object[] parameters = { xeOto.HangXe, xeOto.Model, xeOto.LoaiXe, xeOto.TrangThai, xeOto.Gia};
            int xeOToId = Convert.ToInt32(DataProvider.Instance.ExecuteScalar(query, parameters));
            
            return xeOToId >= 0;
        }

        public bool UpdateXeOto(XeOtoDTO xeOto)
        {
            string query = "UPDATE XeOto " +
                           "SET HangXe = @HangXe , Model = @Model , LoaiXe = @LoaiXe , TrangThai = @TrangThai , GiaThue = @Gia " +
                           "WHERE XeOtoID = @XeOtoID ";
            object[] parameters = { xeOto.HangXe, xeOto.Model, xeOto.LoaiXe, xeOto.TrangThai,xeOto.Gia, xeOto.XeOtoID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        } 
        
        public bool UpdateTrangThai(string xeOtoID, string trangThai)
        {
            string query = "UPDATE XeOto " +
                           "SET TrangThai = @TrangThai " +
                           "WHERE XeOtoID = @XeOtoID ";
            object[] parameters = { trangThai, xeOtoID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public bool DeleteXeOto(string xeOtoID)
        {
            string query = "DELETE FROM XeOto WHERE XeOtoID = @XeOtoID";
            object[] parameters = { xeOtoID };
            return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
        }

        public List<XeOtoDTO> SearchXeOtoByConditions(string keyword)
        {
            string query = "SELECT * FROM XeOto WHERE XeOtoID LIKE '%' + @XeOtoID + '%' OR HangXe LIKE '%' + @HangXe + '%' OR Model LIKE '%' + @Model + '%' OR LoaiXe LIKE '%' + @LoaiXe + '%' OR TrangThai LIKE '%' + @TrangThai + '%'";
            object[] parameters = { keyword, keyword, keyword, keyword, keyword };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            List<XeOtoDTO> result = new List<XeOtoDTO>();
            foreach (DataRow row in data.Rows)
            {
                XeOtoDTO xeOto = new XeOtoDTO
                {
                    XeOtoID = row["XeOtoID"].ToString(),
                    HangXe = row["HangXe"].ToString(),
                    Model = row["Model"].ToString(),
                    LoaiXe = row["LoaiXe"].ToString(),
                    Gia = Double.Parse(row["GiaThue"].ToString()),
                    TrangThai = row["TrangThai"].ToString()
                };
                result.Add(xeOto);
            }
            return result;
        }
      
    }

}
