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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
            txt_ID.Text = xeOtoDTO.XeOtoID;
            txt_GiaThue.Text = xeOtoDTO.Gia.ToString("N0");
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
                checkBox.Tag =  Convert.ToInt32(tinhNang.TinhNangID);
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
            if(validateInput() && validateFuel())
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

        private bool validateFuel()
        {
            if(rdb_Xang.Checked || rdb_Dau.Checked || rdb_Dien.Checked) 
            {
                return true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn loại nhiên liệu", "Chưa chọn nhiên liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private bool validateInput()
        {
            string name = txt_Name.Text;
            string phone = txt_Phone.Text;
            string address = txt_Address.Text;
            string email = txt_Email.Text;
            if(!IsValidName(name) || !IsValidPhone(phone) || !IsValidAddress(address) || !IsValidEmail(email))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsValidName(string name)
        {
            string pattern = @"^[\p{L} ]+$";
            if(string.IsNullOrEmpty (name))
            {
                MessageBox.Show("Vui lòng nhập Họ tên", "Họ tên rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(!Regex.IsMatch(name, pattern))
            {
                MessageBox.Show("Họ tên chỉ được chứa ký tự là chữ", "Họ tên không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidPhone(string phone)
        {
            string pattern = "^[0-9]{10}$";
            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Vui lòng nhập Số điện thoại", "Số điện thoại rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(phone, pattern))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa số và phải đủ 10 ký tự", "Số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidAddress(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Vui lòng nhập Địa chỉ", "Địa chỉ rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            if(string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập Email", "Email rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if(!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Email không đúng cú pháp", "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
