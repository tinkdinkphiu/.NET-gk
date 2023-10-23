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
            if (customerDTO != null)
            {
                customerDTO.Ten = txt_Name.Text;
                customerDTO.SoDienThoai = txt_Phone.Text;
                customerDTO.DiaChi = txt_Address.Text;
                customerDTO.Email = txt_Email.Text;

                // Handle the save operation for the customer
                // You need to update the customer data here
                if (KhachHangBUS.Instance.UpdateKhachHang(customerDTO))
                {
                    MessageBox.Show("Cập nhật thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công");
                }
            }
            else
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
                    MessageBox.Show("Tạo mới không thành công");
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
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }
    }
}
