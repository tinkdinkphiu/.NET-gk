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
        public CustomersManager()
        {
            InitializeComponent();

            lv_CustomersManager.Columns.Add("ID", 60);
            lv_CustomersManager.Columns.Add("Tên khách hàng", 150);
            lv_CustomersManager.Columns.Add("Số điện thoại", 150);
            lv_CustomersManager.Columns.Add("Địa chỉ", 200);
            lv_CustomersManager.Columns.Add("Email", 150);

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void CustomersManager_Load(object sender, EventArgs e)
        {
            List<KhachHangDTO> data = KhachHangBUS.Instance.GetKhachHangList();

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
    }
}
