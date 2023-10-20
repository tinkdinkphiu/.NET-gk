using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NhienLieuDAO
    {
        private static NhienLieuDAO instance;

        public static NhienLieuDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhienLieuDAO();
                return instance;
            }
        }

        public List<NhienLieuDTO> GetAllNhienLieu()
        {
            List<NhienLieuDTO> nhienLieuList = new List<NhienLieuDTO>();

            string query = "SELECT * FROM NhienLieu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                NhienLieuDTO nhienLieu = new NhienLieuDTO
                {
                    NhienLieuID = Convert.ToInt32(row["NhienLieuID"]),
                    LoaiNhienLieu = row["LoaiNhienLieu"].ToString()
                };
                nhienLieuList.Add(nhienLieu);
            }

            return nhienLieuList;
        }
    }

}
