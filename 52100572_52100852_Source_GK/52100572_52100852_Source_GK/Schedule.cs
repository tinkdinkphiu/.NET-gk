using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52100572_52100852_Source_GK
{
    public partial class Schedule : Form
    {
        private bool isReloading = false;
        public Schedule()
        {
            InitializeComponent();
            lv_Schedule.Columns.Add("Đơn Đặt Xe ID", 60);
            lv_Schedule.Columns.Add("Khách Hàng ID", 120);
            lv_Schedule.Columns.Add("Xe ID", 60);
            lv_Schedule.Columns.Add("Thời gian thuê", 200);
            lv_Schedule.Columns.Add("Giá Thuê (VND/Ngày)", 200);
            lv_Schedule.Columns.Add("Tạm Tính", 200); //5
            lv_Schedule.Columns.Add("Tuyến Đường", 200);
            lv_Schedule.Columns.Add("Thời gian trả (Dự Kiến)", 250);
            lv_Schedule.Columns.Add("Thời gian trả", 200);
            lv_Schedule.Columns.Add("Thành Tiền", 200);
            lv_Schedule.Columns.Add("Trạng Thái", 150);
        }

        private void bindingData(List<DonDatXeDTO> data)
        {

            lv_Schedule.Items.Clear();
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = item.DonDatXeID.ToString();
                listViewItem.SubItems.Add(item.KhachHangID.ToString());
                listViewItem.SubItems.Add(item.XeOtoID.ToString());

                listViewItem.SubItems.Add(item.ThoiGianThue.ToString("dd/MM/yyyy HH:mm:ss"));
                listViewItem.SubItems.Add(item.GiaThue.ToString("N0"));
                if (item.TinhTrangThanhToan)
                {
                    listViewItem.SubItems.Add(item.Total.ToString("N0"));
                    listViewItem.SubItems.Add("Hồ Chí Minh - " + item.DiemDen.ToString());
                    listViewItem.SubItems.Add(item.ThoiGianTraDK.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add(item.ThoiGianTra?.ToString("dd/MM/yyyy HH:mm:ss"));
                    listViewItem.SubItems.Add(item.Total.ToString("N0"));
                    listViewItem.SubItems.Add("Đã Thanh Toán");
                }
                else
                {
                    listViewItem.SubItems.Add(tamTinh(item.ThoiGianThue, item.GiaThue).ToString("N0"));
                    listViewItem.SubItems.Add("Hồ Chí Minh - " + item.DiemDen.ToString());
                    listViewItem.SubItems.Add(item.ThoiGianTraDK.ToString("dd/MM/yyyy"));
                    listViewItem.SubItems.Add("N/A");
                    listViewItem.SubItems.Add("N/A");
                    listViewItem.SubItems.Add("Chưa Thanh Toán");
                }

                lv_Schedule.Items.Add(listViewItem);
            }
        }

        private double tamTinh(DateTime ThoiGianThue, double giaThue)
        {
            DateTime ngayTra = DateTime.Now;
            TimeSpan thoiGianThueSpan = ngayTra - ThoiGianThue;
            double soGioDaThue = thoiGianThueSpan.TotalHours;
            return soGioDaThue * giaThue;

        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            List<DonDatXeDTO> data = DonDatXeBUS.Instance.GetDonDatXeList();
            bindingData(data);
        }

        private void lv_Schedule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReloading)
            {
                isReloading = false;
                return;
            }
            foreach (ListViewItem item in lv_Schedule.SelectedItems)
            {

                string inputDate = item.SubItems[3].Text;
                string format = "dd/MM/yyyy HH:mm:ss";
                DateTime.TryParseExact(inputDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime thoiGianThue);
                DateTime.TryParseExact(item.SubItems[7].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime thoiGianTraDk);
                DateTime.TryParseExact(item.SubItems[8].Text, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime thoiGianTra);
               
                DonDatXeDTO donDatXe;
                if (item.SubItems[10].Text.Equals("Đã Thanh Toán"))
                {
                     donDatXe = new DonDatXeDTO
                    {
                        DonDatXeID = item.SubItems[0].Text,
                        KhachHangID = item.SubItems[1].Text,
                        XeOtoID = item.SubItems[2].Text,
                        ThoiGianThue = thoiGianThue,
                        GiaThue = Double.Parse(item.SubItems[4].Text),
                        DiemDen = item.SubItems[6].Text,
                        ThoiGianTraDK = thoiGianTraDk,
                         ThoiGianTra = thoiGianTra,
                        Total = Double.Parse(item.SubItems[9].Text),
                        TinhTrangThanhToan = item.SubItems[10].Text.Equals("Đã Thanh Toán")
                    };
                }
                else
                {
                     donDatXe = new DonDatXeDTO
                    {
                        DonDatXeID = item.SubItems[0].Text,
                        KhachHangID = item.SubItems[1].Text,
                        XeOtoID = item.SubItems[2].Text,
                        ThoiGianThue = thoiGianThue,
                        GiaThue = Double.Parse(item.SubItems[4].Text),
                        TinhTrangThanhToan = item.SubItems[10].Text.Equals("Đã Thanh Toán"),
                         DiemDen = item.SubItems[6].Text,
                         ThoiGianTraDK = thoiGianTraDk
                     };
                }


                PaymentConfirmation paymentFrm = new PaymentConfirmation(donDatXe);
                paymentFrm.ShowDialog();
                Schedule_Load(sender, e);
                isReloading = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Schedule_Load(sender, e);
        }

        private void btn_CheckCar_Click(object sender, EventArgs e)
        {
            string xeOtoID = txt_XeOToID.Text;
            if (XeOtoBUS.Instance.isAvaiable(xeOtoID))
            {
                MessageBox.Show("Xe số "+ xeOtoID+" sẵn sàng cho thuê");
            }
            else
            {
                MessageBox.Show("Xe số " + xeOtoID + " đang cho thuê");
            }
        }
    }
}
