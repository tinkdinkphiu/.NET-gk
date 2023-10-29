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
    public partial class CustomersManager : Form
    {
        private bool isReloading = false;
        public CustomersManager()
        {
            InitializeComponent();

            lv_CustomersManager.Columns.Add("ID", 60);
            lv_CustomersManager.Columns.Add("Tên khách hàng", 150);
            lv_CustomersManager.Columns.Add("Số điện thoại", 150);
            lv_CustomersManager.Columns.Add("Địa chỉ", 200);
            lv_CustomersManager.Columns.Add("Email", 150);
        }

        void bindingData(List<KhachHangDTO> data)
        {
            lv_CustomersManager.Items.Clear();
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = item.KhachHangID.ToString();
                listViewItem.SubItems.Add(item.Ten);
                listViewItem.SubItems.Add(item.SoDienThoai);
                listViewItem.SubItems.Add(item.DiaChi);
                listViewItem.SubItems.Add(item.Email);

                lv_CustomersManager.Items.Add(listViewItem);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            CustomerDetail customerDetail = new CustomerDetail(null);
            customerDetail.ShowDialog();
            CustomersManager_Load(sender, e);
        }

        private void CustomersManager_Load(object sender, EventArgs e)
        {
            List<KhachHangDTO> data = KhachHangBUS.Instance.GetKhachHangList();
           bindingData(data);
        }

        private void lv_CustomersManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReloading)
            {
                isReloading = false;
                return;
            }
            foreach (ListViewItem item in lv_CustomersManager.SelectedItems)
            {
                KhachHangDTO khachHang = new KhachHangDTO
                {
                    KhachHangID = item.SubItems[0].Text,
                    Ten = item.SubItems[1].Text,
                    SoDienThoai = item.SubItems[2].Text,
                    DiaChi = item.SubItems[3].Text,
                    Email = item.SubItems[4].Text
                };

                CustomerDetail customerDetail = new CustomerDetail(khachHang);
                customerDetail.ShowDialog();
                CustomersManager_Load(sender, e);
                isReloading = true;

            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            CustomersManager_Load(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string key = txt_Search.Text;
            List<KhachHangDTO> data;
            if (key.Length > 0)
            {
                data = KhachHangBUS.Instance.Search(key);
            }
            else
            {
                data = KhachHangBUS.Instance.Search(key);
            }
            bindingData(data);
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            List<KhachHangDTO> data = KhachHangBUS.Instance.GetKhachHangList();
            if (ExcelHelper.Instance.addCustomerToExcel(data))
            {
                MessageBox.Show("Đã xuất ra file tại: /Output/CustomerList.xlsx");
            }
        }
    }
}
