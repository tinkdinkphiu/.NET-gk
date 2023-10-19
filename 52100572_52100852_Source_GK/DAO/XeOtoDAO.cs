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
                TrangThai = row["TrangThai"].ToString()
            };
            xeOtoList.Add(xeOto);
        }
        return xeOtoList;
    }

    public bool AddXeOto(XeOtoDTO xeOto)
    {
        string query = "INSERT INTO XeOto (HangXe, Model, LoaiXe, TrangThai) " +
                       "VALUES (@HangXe, @Model, @LoaiXe, @TrangThai)";
        object[] parameters = { xeOto.HangXe, xeOto.Model, xeOto.LoaiXe, xeOto.TrangThai };
        return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
    }

    public bool UpdateXeOto(XeOtoDTO xeOto)
    {
        string query = "UPDATE XeOto " +
                       "SET HangXe = @HangXe, Model = @Model, LoaiXe = @LoaiXe, TrangThai = @TrangThai " +
                       "WHERE XeOtoID = @XeOtoID";
        object[] parameters = { xeOto.HangXe, xeOto.Model, xeOto.LoaiXe, xeOto.TrangThai, xeOto.XeOtoID };
        return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
    }

    public bool DeleteXeOto(int xeOtoID)
    {
        string query = "DELETE FROM XeOto WHERE XeOtoID = @XeOtoID";
        object[] parameters = { xeOtoID };
        return DataProvider.Instance.ExecuteNonQuery(query, parameters) > 0;
    }

    // Thêm các phương thức khác như tìm kiếm theo hãng, mẫu, loại xe, vv.
}


}
