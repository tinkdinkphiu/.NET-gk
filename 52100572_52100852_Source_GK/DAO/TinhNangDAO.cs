using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TinhNangDAO
    {
        private static TinhNangDAO instance;

        public static TinhNangDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TinhNangDAO();
                return instance;
            }
        }
        public List<TinhNangDTO> GetAllTinhNang()
        {
            List<TinhNangDTO> tinhNangList = new List<TinhNangDTO>();

            string query = "SELECT * FROM TinhNangXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                TinhNangDTO tinhNang = new TinhNangDTO
                {
                    TinhNangID = Convert.ToInt32(row["TinhNangID"]),
                    TenTinhNang = row["TenTinhNang"].ToString()
                };
                tinhNangList.Add(tinhNang);
            }

            return tinhNangList;
        }

        public TinhNangDTO GetTinhNangByID(int tinhNangID)
        {
            string query = "SELECT * FROM TinhNangXe WHERE TinhNangID = @TinhNangID";
            object[] parameters = { tinhNangID };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                TinhNangDTO tinhNang = new TinhNangDTO
                {
                    TinhNangID = Convert.ToInt32(row["TinhNangID"]),
                    TenTinhNang = row["TenTinhNang"].ToString()
                };
                return tinhNang;
            }
            else
            {
                return null; // Hoặc có thể xử lý nếu không tìm thấy tính năng với ID tương ứng
            }
        }

    }

}
