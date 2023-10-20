using BUS;
using DTO;
using MaterialSkin.Controls;
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
    public partial class BillDetail : MaterialForm
    {
        private XeOtoDTO xeOtoDTO;
        private List<string> tinhNangIDList;

        private Double total;
        private Double giaNhienLieu;
        private string nhienLieu;
        public BillDetail(XeOtoDTO xeOtoDTO)
        {
            InitializeComponent();
            this.xeOtoDTO = xeOtoDTO;
            tinhNangIDList = new List<string>();
            if (xeOtoDTO != null )
            {
                txt_ID.Text = xeOtoDTO.XeOtoID.ToString();
                txt_GiaThue.Text = xeOtoDTO.Gia.ToString();
                txt_Model.Text = xeOtoDTO.Model.ToString();
                this.total = xeOtoDTO.Gia;
            }

            txt_ID.Enabled = false;
            txt_Model.Enabled = false;
            txt_GiaThue.Enabled = false;
            cbb_HangXe.Enabled = false;
            cbb_TrangThai.Enabled = false;
            cbb_LoaiXe.Enabled = false;
            bindingTotal();
        }

        private void bindingTotal()
        {
            lbl_Total.Text = "Tổng: " + (total+giaNhienLieu).ToString("N0") + " VND/giờ";
        }

        private void CarDetail_Load(object sender, EventArgs e)
        {
            List<TinhNangDTO> tinhNangDTOs = XeOtoBUS.Instance.GetTinhNangList();
            foreach (TinhNangDTO tinhNang in tinhNangDTOs)
            {
                MaterialCheckbox checkBox = new MaterialCheckbox();
                checkBox.Text = tinhNang.TenTinhNang;
                checkBox.Tag =  tinhNang.TinhNangID;
                checkBox.CheckedChanged += CheckBox_CheckedChanged;
                checkBox.Width = 180;
                if (tinhNangIDList.Contains(tinhNang.TinhNangID.ToString()))
                {
                    checkBox.Checked = true;
                }
                fpnl_TinhNang.Controls.Add(checkBox);
            }
        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            int gia = (int)checkBox.Tag;
            if (checkBox.Checked)
            {
                total += gia * 10000;
                tinhNangIDList.Add(gia.ToString());
            }
            else
            {
                total -= gia * 10000;
                tinhNangIDList.Remove(gia.ToString());
            }
            bindingTotal();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdb_Dien_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_Dien.Checked)
            {
                giaNhienLieu = 50000;
                nhienLieu = "Điện";
            }
            else if (rdb_Dau.Checked)
            {
                giaNhienLieu = 100000;
                nhienLieu = "Dầu Diesel";
            }            
            else if (rdb_Xang.Checked)
            {
                giaNhienLieu = 98000;
                nhienLieu = "Xăng";
            }
            bindingTotal();
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            KhachHangDTO khachHang = new KhachHangDTO
            {
                Ten = txt_Name.Text,
                DiaChi = txt_Address.Text,
                Email = txt_Email.Text,
                SoDienThoai = txt_Phone.Text
            };

            DonDatXeDTO donDatXe = new DonDatXeDTO
            {
                XeOtoID = xeOtoDTO.XeOtoID,
                GiaThue = total + giaNhienLieu,
                NhienLieu = nhienLieu,
                TinhTrangThanhToan = false,
                ThoiGianThue = DateTime.Now
            };
            bool task = DonDatXeBUS.Instance.AddDonDatXe(khachHang,tinhNangIDList, donDatXe);
            if (task)
            {
                MessageBox.Show("Thuê xe thành công!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }
    }
}
