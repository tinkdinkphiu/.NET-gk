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
        private KhachHangDTO khachHang;
        private DonDatXeDTO donDatXe;
        public BillDetail(XeOtoDTO xeOtoDTO, DonDatXeDTO donDatXe)
        {
            InitializeComponent();
            this.xeOtoDTO = xeOtoDTO;
            tinhNangIDList = new List<string>();
            if (xeOtoDTO != null )
            {
                bindingXeOto(xeOtoDTO);

                this.total = xeOtoDTO.Gia;
            }
            if(donDatXe != null)
            {
                total = donDatXe.GiaThue;
                giaNhienLieu = 0;

                //hien them controls
                lbl_ID_KH.Visible = true;
                lbl_ID_DonDatXe.Visible = true;
                lbl_ThoiGianThue.Visible = true;
                txt_ID_KH.Visible = true;
                txt_ID_DonDatXe.Visible = true;
                txt_ThoiGianThue.Visible = true;
                //disable controls
                foreach (Control control in this.Controls)
                {
                    control.Enabled = false;
                }

                txt_ID_KH.Text = donDatXe.KhachHangID.ToString();
                txt_ID_DonDatXe.Text = donDatXe.DonDatXeID.ToString();
                txt_ThoiGianThue.Text = donDatXe.ThoiGianThue.ToString("dd/MM/yyyy HH:mm:ss");

                this.xeOtoDTO = XeOtoBUS.Instance.GetXeOtoByID(donDatXe.XeOtoID);
                this.khachHang = KhachHangBUS.Instance.GetKhachHangByID(donDatXe.KhachHangID);
                this.tinhNangIDList = DonDatXeBUS.Instance.getListTinhNangByID(donDatXe.DonDatXeID);
                bindingXeOto(this.xeOtoDTO);
                bindingKH(this.khachHang);

                btn_Confirm.Visible = false;
                btn_Cancel.Enabled = true;
            }

            txt_ID.Enabled = false;
            txt_Model.Enabled = false;
            txt_GiaThue.Enabled = false;
            cbb_HangXe.Enabled = false;
            cbb_TrangThai.Enabled = false;
            cbb_LoaiXe.Enabled = false;
            bindingTotal();
        }

        private void bindingKH(KhachHangDTO khachHangDTO)
        {
            txt_ID_KH.Text = khachHangDTO.KhachHangID.ToString();
            txt_Name.Text = khachHangDTO.Ten;
            txt_Address.Text = khachHangDTO.DiaChi;
            txt_Email.Text = khachHangDTO.Email;
            txt_Phone.Text = khachHangDTO.SoDienThoai;
        }

        private void bindingXeOto(XeOtoDTO xeOtoDTO)
        {
            txt_ID.Text = xeOtoDTO.XeOtoID.ToString();
            txt_GiaThue.Text = xeOtoDTO.Gia.ToString();
            txt_Model.Text = xeOtoDTO.Model.ToString();

            int index = cbb_LoaiXe.FindString(xeOtoDTO.LoaiXe);
            if (index != -1)
            {
                cbb_LoaiXe.SelectedIndex = index;
            }
            index = cbb_HangXe.FindString(xeOtoDTO.HangXe);
            if (index != -1)
            {
                cbb_HangXe.SelectedIndex = index;
            }

            index = cbb_TrangThai.FindString(xeOtoDTO.TrangThai);
            if (index != -1)
            {
                cbb_TrangThai.SelectedIndex = index;
            }
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
            khachHang = new KhachHangDTO
            {
                Ten = txt_Name.Text,
                DiaChi = txt_Address.Text,
                Email = txt_Email.Text,
                SoDienThoai = txt_Phone.Text
            };

            donDatXe = new DonDatXeDTO
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
