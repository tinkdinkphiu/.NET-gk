﻿using BUS;
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
    public partial class Bill : Form
    {
        private bool isReloading = false;
        public Bill()
        {
            InitializeComponent();

            lv_Bill.Columns.Add("ID", 60);
            lv_Bill.Columns.Add("Khách Hàng ID", 120);
            lv_Bill.Columns.Add("Xe ID", 60);
            lv_Bill.Columns.Add("Nhiên Liệu", 100);
            lv_Bill.Columns.Add("Thời gian thuê", 200);
            lv_Bill.Columns.Add("Điểm đến", 200);
            lv_Bill.Columns.Add("Thời gian trả(Dự kiến)", 250);
            lv_Bill.Columns.Add("Giá Thuê (VND/Ngày)", 200);
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
                listViewItem.SubItems.Add(item.NhienLieu.ToString());
                listViewItem.SubItems.Add(item.ThoiGianThue.ToString("dd/MM/yyyy HH:mm:ss"));
                listViewItem.SubItems.Add(item.DiemDen.ToString());
                listViewItem.SubItems.Add(item.ThoiGianTraDK.ToString("dd/MM/yyyy"));
                listViewItem.SubItems.Add(item.GiaThue.ToString("N0"));
                if (item.TinhTrangThanhToan)
                {
                    listViewItem.SubItems.Add("Đã Thanh Toán");
                }
                else
                {
                    listViewItem.SubItems.Add("Chưa Thanh Toán");
                }
                lv_Bill.Items.Add(listViewItem);
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            List<DonDatXeDTO> data = DonDatXeBUS.Instance.GetDonDatXeList();
            bindingData(data);
        }


        private void lv_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReloading)
            {
                isReloading = false;
                return; 
            }
            foreach (ListViewItem item in lv_Bill.SelectedItems)
            {

                string inputDate = item.SubItems[4].Text;
                string format = "dd/MM/yyyy HH:mm:ss";

                if (DateTime.TryParseExact(inputDate, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                {
                    DateTime.TryParseExact(item.SubItems[6].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime returnDate);
                    DonDatXeDTO donDatXe = new DonDatXeDTO
                    {
                        DonDatXeID = item.SubItems[0].Text,
                        KhachHangID = item.SubItems[1].Text,
                        XeOtoID = item.SubItems[2].Text,
                        NhienLieu = item.SubItems[3].Text,
                        ThoiGianThue = result,
                        DiemDen = item.SubItems[5].Text,
                        ThoiGianTraDK = returnDate,
                        GiaThue = Double.Parse(item.SubItems[7].Text),
                        TinhTrangThanhToan = item.SubItems[8].Text.Equals("Đã Thanh Toán")
                    };
                    BillDetail billDetail = new BillDetail(null, donDatXe);
                    billDetail.ShowDialog();
                    Bill_Load(sender, e); 
                    isReloading = true;
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Bill_Load(sender, e);
        }
    }
}
