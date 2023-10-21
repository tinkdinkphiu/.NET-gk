using Spire.Xls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DTO;

namespace BUS
{
    public class ExcelHelper
    {

        private static ExcelHelper instance;

        public static ExcelHelper Instance
        {
            get
            {
                if (instance == null)
                    instance = new ExcelHelper();
                return instance;
            }
        }
        private ExcelHelper() { }

        public bool addCustomerToExcel(List<KhachHangDTO> khachHangs)
        {
            try
            {
                var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
                int index = outPutDirectory.IndexOf("52100572_52100852_Source_GK");
                outPutDirectory = outPutDirectory.Substring(0, index);
                var filePath = Path.Combine(outPutDirectory, "52100572_52100852_Source_GK//Output//CustomerList.xlsx");
                string absoluteFilePath = new Uri(filePath).LocalPath;

                Workbook workbook = new Workbook();
                workbook.LoadFromFile(absoluteFilePath);

                Worksheet worksheet = workbook.Worksheets[0];


                //worksheet.InsertRow(0);
                worksheet.Range[1, 1].Value = "Mã khách hàng";
                worksheet.Range[1, 2].Value = "Tên khách hàng";
                worksheet.Range[1, 3].Value = "Số điện thoại";
                worksheet.Range[1, 4].Value = "Email";
                worksheet.Range[1, 5].Value = "Địa chỉ";

                int lastRow = 1+1;
                if (khachHangs != null && khachHangs.Count > 0)
                {
                    // Duyệt qua danh sách khachHangs và thêm từng khách hàng vào Excel
                    foreach (var khachHang in khachHangs)
                    {
                        worksheet.Range[lastRow, 1].Value = khachHang.KhachHangID;
                        worksheet.Range[lastRow, 2].Value = khachHang.Ten;
                        worksheet.Range[lastRow, 3].Value = khachHang.SoDienThoai;
                        worksheet.Range[lastRow, 4].Value = khachHang.Email;
                        worksheet.Range[lastRow, 5].Value = khachHang.DiaChi;
                        lastRow++;
                    }

                    // Lưu lại workbook sau khi thêm dữ liệu
                    workbook.Save();
                    return true;
                }
                else
                {
                    return false; // Trả về false nếu danh sách khachHangs rỗng hoặc null
                }

            }
            catch (Exception ex) {
                throw;
                return false; }
        }
    }
}
