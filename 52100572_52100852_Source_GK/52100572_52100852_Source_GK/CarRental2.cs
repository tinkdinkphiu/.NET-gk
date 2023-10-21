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
    public partial class CarRental2 : Form
    {
        private string startCarRental2CarType;
        public CarRental2(string carTypeFromRental1)
        {
            InitializeComponent();

            lv_CarList.Columns.Add("ID", 60);
            lv_CarList.Columns.Add("Hãng Xe", 120);
            lv_CarList.Columns.Add("Model", 60);
            lv_CarList.Columns.Add("Loại Xe", 200);
            lv_CarList.Columns.Add("Trạng Thái", 150);
            lv_CarList.Columns.Add("Giá Thuê (VND/Giờ)", 200);

            this.startCarRental2CarType = carTypeFromRental1;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.backToCarRental();
        }

        private void CarRental2_Load(object sender, EventArgs e)
        {
            List<XeOtoDTO> data = XeOtoBUS.Instance.SearchXeOto(startCarRental2CarType);
            bindingData(data);
        }
        private void bindingData(List<XeOtoDTO> data)
        {
            lv_CarList.Items.Clear();
            foreach (var item in data)
            {
                if(item.TrangThai.Equals("Sẵn sàng"))
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.SubItems[0].Text = item.XeOtoID.ToString();
                    listViewItem.SubItems.Add(item.HangXe);
                    listViewItem.SubItems.Add(item.Model);
                    listViewItem.SubItems.Add(item.LoaiXe);
                    listViewItem.SubItems.Add(item.TrangThai);
                    listViewItem.SubItems.Add(item.Gia.ToString());
                    lv_CarList.Items.Add(listViewItem);
                }
                
            }
        }
        private void lv_CarList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lv_CarList.SelectedItems)
            {
                XeOtoDTO xeOto = new XeOtoDTO
                {
                    XeOtoID = item.SubItems[0].Text,
                    HangXe = item.SubItems[1].Text,
                    Model = item.SubItems[2].Text,
                    LoaiXe = item.SubItems[3].Text,
                    TrangThai = item.SubItems[4].Text,
                    Gia = int.Parse(item.SubItems[5].Text)
                };

                BillDetail billDetails = new BillDetail(xeOto,null);
                billDetails.ShowDialog();
            }
        }
    }
}
