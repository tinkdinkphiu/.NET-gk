using System;
using BUS;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using DTO;

namespace _52100572_52100852_Source_GK
{
    public partial class CarsManager : Form
    {
        public CarsManager()
        {
            InitializeComponent();

            lv_CarsManager.Columns.Add("ID", 60);
            lv_CarsManager.Columns.Add("Hãng Xe", 120);
            lv_CarsManager.Columns.Add("Model", 60);
            lv_CarsManager.Columns.Add("Loại Xe", 120);
            lv_CarsManager.Columns.Add("Trạng Thái", 150);
            lv_CarsManager.Columns.Add("Giá Thuê (VND/Giờ)", 200);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void CarsManager_Load(object sender, EventArgs e)
        {
            List<XeOtoDTO> data = XeOtoBUS.Instance.GetXeOtoList();

            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = item.XeOtoID.ToString();
                listViewItem.SubItems.Add(item.HangXe);
                listViewItem.SubItems.Add(item.Model);
                listViewItem.SubItems.Add(item.LoaiXe);
                listViewItem.SubItems.Add(item.TrangThai);
                listViewItem.SubItems.Add(item.Gia.ToString());

                lv_CarsManager.Items.Add(listViewItem);
            }
        }
    }
}
