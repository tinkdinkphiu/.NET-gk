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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace _52100572_52100852_Source_GK
{
    public partial class CustomerDetail : MaterialForm
    {

        private KhachHangDTO customerDTO;

        public CustomerDetail(KhachHangDTO customerDTO)
        {
            InitializeComponent();

            this.customerDTO = customerDTO;
            if (customerDTO != null)
            {
                // Initialize controls with customer data
                txt_ID_KH.Text = customerDTO.KhachHangID.ToString();
                txt_Name.Text = customerDTO.Ten;
                txt_Phone.Text = customerDTO.SoDienThoai;
                txt_Address.Text = customerDTO.DiaChi;
                txt_Email.Text = customerDTO.Email;

                Toggle(false);
            }
            else
            {
                Toggle(true);
            }
        }

        public void Toggle(bool isEditing)
        {
            if (isEditing)
            {
                txt_ID_KH.Enabled = false;

                txt_Name.Enabled = true;
                txt_Phone.Enabled = true;
                txt_Address.Enabled = true;
                txt_Email.Enabled = true;

                btn_Cancel.Visible = true;
                btn_Save.Visible = true;
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
            }
            else
            {
                txt_ID_KH.Enabled = false;

                txt_Name.Enabled = false;
                txt_Phone.Enabled = false;
                txt_Address.Enabled = false;
                txt_Email.Enabled = false;

                btn_Cancel.Visible = false;
                btn_Save.Visible = false;
                btn_Edit.Visible = true;
                btn_Delete.Visible = true;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Toggle(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(validateInput())
            {
                if (customerDTO != null)
                {
                    var flag = true;
                    if (txt_Phone.Text != customerDTO.SoDienThoai && KhachHangBUS.Instance.GetKhachHangByPhone(txt_Phone.Text) != null )
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại!", "Số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = false;
                    }
                    else if (txt_Email.Text != customerDTO.Email && KhachHangBUS.Instance.GetKhachHangByEmail(txt_Email.Text) != null)
                    {
                        MessageBox.Show("Email đã tồn tại!", "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = false;
                    }
                    if (flag)
                    {
                        customerDTO.Ten = txt_Name.Text;
                        customerDTO.SoDienThoai = txt_Phone.Text;
                        customerDTO.DiaChi = txt_Address.Text;
                        customerDTO.Email = txt_Email.Text;
                        if (KhachHangBUS.Instance.UpdateKhachHang(customerDTO))
                        {
                            MessageBox.Show("Cập nhật thành công");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại");
                        }
                    }
                }
                else
                {
                    var flag = true;
                    if (KhachHangBUS.Instance.GetKhachHangByPhone(txt_Phone.Text) != null)
                    {
                        MessageBox.Show("Số điện thoại đã tồn tại!", "Số điện thoại không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = false;
                    }
                    else if (KhachHangBUS.Instance.GetKhachHangByEmail(txt_Email.Text) != null)
                    {
                        MessageBox.Show("Email đã tồn tại!", "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        flag = false;
                    }

                    if (flag)
                    {
                        customerDTO = new KhachHangDTO();
                        customerDTO.Ten = txt_Name.Text;
                        customerDTO.SoDienThoai = txt_Phone.Text;
                        customerDTO.DiaChi = txt_Address.Text;
                        customerDTO.Email = txt_Email.Text;

                        // Handle the create operation for the new customer
                        // You need to insert the new customer data here
                        if (KhachHangBUS.Instance.AddKhachHang(customerDTO))
                        {
                            MessageBox.Show("Tạo mới thành công");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Tạo mới thất bại");
                        }
                    }

                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (customerDTO != null)
            {
                txt_ID_KH.Text = customerDTO.KhachHangID.ToString();
                txt_Name.Text = customerDTO.Ten;
                txt_Phone.Text = customerDTO.SoDienThoai;
                txt_Address.Text = customerDTO.DiaChi;
                txt_Email.Text = customerDTO.Email;
                Toggle(false);
            }
            else
            {
                this.Close();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (customerDTO != null)
            {
                // Handle the delete operation for the customer
                if (KhachHangBUS.Instance.DeleteKhachHang(customerDTO.KhachHangID))
                {
                    MessageBox.Show("Xóa thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        private bool validateInput()
        {
            string name = txt_Name.Text;
            string phone = txt_Phone.Text;
            string address = txt_Address.Text;
            string email = txt_Email.Text;
            if (!IsValidName(name) || !IsValidPhone(phone) || !IsValidAddress(address) || !IsValidEmail(email))
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
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập Họ tên", "Họ tên rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(name, pattern))
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
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập Email", "Email rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(email, pattern))
            {
                MessageBox.Show("Email không đúng cú pháp", "Email không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}
