using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _52100572_52100852_Source_GK
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();

            lv_Bill.Columns.Add("ID", 60);
            lv_Bill.Columns.Add("Khách Hàng ID", 120);
            lv_Bill.Columns.Add("Xe ID", 60);
            lv_Bill.Columns.Add("Thời gian thuê", 200);
            lv_Bill.Columns.Add("Giá Thuê (VND/Giờ)", 200);
            lv_Bill.Columns.Add("Trạng Thái", 150);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string key = txt_Search.Text;
            List<DonDatXeDTO> data;
            if (key.Length > 0)
            {
                data = DonDatXeBUS.Instance.Search(key);
            }
            else
            {
                data = DonDatXeBUS.Instance.GetDonDatXeList();
            }
            bindingData(data);
        }

        private void bindingData(List<DonDatXeDTO> data)
        {
            lv_Bill.Items.Clear();
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = item.DonDatXeID.ToString();
                listViewItem.SubItems.Add(item.KhachHangID.ToString());
                listViewItem.SubItems.Add(item.XeOtoID.ToString());
                listViewItem.SubItems.Add(item.ThoiGianThue.ToString("dd/MM/yyyy HH:mm:ss"));
                listViewItem.SubItems.Add(item.GiaThue.ToString());
                listViewItem.SubItems.Add(item.TinhTrangThanhToan.ToString());
                lv_Bill.Items.Add(listViewItem);
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            List<DonDatXeDTO> data = DonDatXeBUS.Instance.GetDonDatXeList();
            bindingData(data);
        }
    }
}
