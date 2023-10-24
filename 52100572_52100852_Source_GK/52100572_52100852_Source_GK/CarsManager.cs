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
            lv_CarsManager.Columns.Add("Model", 100);
            lv_CarsManager.Columns.Add("Loại Xe", 200);
            lv_CarsManager.Columns.Add("Trạng Thái", 150);
            lv_CarsManager.Columns.Add("Giá Thuê (VND/Giờ)", 200);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string key = txt_Search.Text;
            List<XeOtoDTO> data;
            if (key.Length > 0)
            {
                 data = XeOtoBUS.Instance.SearchXeOto(key);
            }
            else
            {
                data = XeOtoBUS.Instance.GetXeOtoList();
            }
            bindingData(data);
        }

        private void CarsManager_Load(object sender, EventArgs e)
        {

            loadData();


        }

        private void loadData()
        {
            List<XeOtoDTO> data = XeOtoBUS.Instance.GetXeOtoList();
            bindingData(data);
        }
        private void bindingData(List<XeOtoDTO> data)
        {
            lv_CarsManager.Items.Clear();
            foreach (var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = item.XeOtoID.ToString();
                listViewItem.SubItems.Add(item.HangXe);
                listViewItem.SubItems.Add(item.Model);
                listViewItem.SubItems.Add(item.LoaiXe);
                listViewItem.SubItems.Add(item.TrangThai);
                listViewItem.SubItems.Add(item.Gia.ToString("N0"));
                lv_CarsManager.Items.Add(listViewItem);
            }
        }

        private void lv_CarsManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_CarsManager.SelectedItems)
            {
                XeOtoDTO xeOto = new XeOtoDTO
                {
                    XeOtoID = item.SubItems[0].Text,
                    HangXe = item.SubItems[1].Text,
                    Model = item.SubItems[2].Text,
                    LoaiXe = item.SubItems[3].Text,
                    TrangThai = item.SubItems[4].Text,
                    Gia = Double.Parse(item.SubItems[5].Text)
                };

                CarDetail carDetail = new CarDetail(xeOto);
                carDetail.ShowDialog();
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CarDetail carDetail = new CarDetail(null);
            carDetail.ShowDialog();
        }
        private void txt_Search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search.PerformClick();
                e.SuppressKeyPress = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
