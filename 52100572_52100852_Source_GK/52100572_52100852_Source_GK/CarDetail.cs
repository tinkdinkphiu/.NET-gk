using BUS;
using DTO;
using MaterialSkin;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _52100572_52100852_Source_GK
{
    public partial class CarDetail : MaterialForm
    {
        private XeOtoDTO xeOtoDTO;
        public CarDetail(XeOtoDTO xeOtoDTO)
        {
            InitializeComponent();

            this.xeOtoDTO = xeOtoDTO;
            if (xeOtoDTO != null )
            {
                txt_ID.Text = xeOtoDTO.XeOtoID.ToString();
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
            
        }

        public void toggle(bool isEditing)
        {
            if(isEditing)
            {
                txt_ID.Enabled = false;
                txt_Model.Enabled = true;
                txt_GiaThue.Enabled = true;
                btn_Cancel.Visible = true;
                btn_Save.Visible = true;
                cbb_HangXe.Enabled = true;
                cbb_TrangThai.Enabled = true;
                cbb_LoaiXe.Enabled = true;
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
            }
            else
            {
                btn_Edit.Visible = true;
                txt_ID.Enabled = false;
                txt_Model.Enabled = false;
                txt_GiaThue.Enabled = false;
                cbb_HangXe.Enabled = false;
                cbb_TrangThai.Enabled = false;
                cbb_LoaiXe.Enabled = false;
                btn_Cancel.Visible = false;
                btn_Save.Visible = false;
                btn_Delete.Visible = true;
            }
        }

        private void CarDetail_Load(object sender, EventArgs e)
        {
            if (xeOtoDTO != null)
            {
                toggle(false);
            }
            else
            {
                toggle(true);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if (xeOtoDTO != null)
            {
                txt_ID.Text = xeOtoDTO.XeOtoID.ToString();
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
                toggle(false);
            }
            else
            {
                this.Close();
            }
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            toggle(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(validateInput())
            {
                if (xeOtoDTO != null)
                {
                    xeOtoDTO.Model = txt_Model.Text;
                    xeOtoDTO.HangXe = cbb_HangXe.Text;
                    xeOtoDTO.LoaiXe = cbb_LoaiXe.Text;
                    xeOtoDTO.TrangThai = cbb_TrangThai.Text;
                    xeOtoDTO.Gia = double.Parse(txt_GiaThue.Text);
                
                    if (XeOtoBUS.Instance.UpdateXeOto(xeOtoDTO))
                    {
                        MessageBox.Show("Cập nhật thành công");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại");
                    }
                }
                else
                {
                    xeOtoDTO = new XeOtoDTO();
                    xeOtoDTO.Model = txt_Model.Text;
                    xeOtoDTO.HangXe = cbb_HangXe.Text;
                    xeOtoDTO.LoaiXe = cbb_LoaiXe.Text;
                    xeOtoDTO.TrangThai = cbb_TrangThai.Text;
                    xeOtoDTO.Gia = double.Parse(txt_GiaThue.Text);
       
                    if (XeOtoBUS.Instance.AddXeOto(xeOtoDTO))
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

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (xeOtoDTO != null)
            {

                if (XeOtoBUS.Instance.DeleteXeOto(xeOtoDTO.XeOtoID))
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
            string model = txt_Model.Text;
            string price = txt_GiaThue.Text;
            if (!IsValidModel(model) || !IsValidPrice(price)) {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsValidModel(string model)
        {
            string pattern = @"^[a-zA-Z0-9\s]+$";
            if (string.IsNullOrEmpty(model))
            {
                MessageBox.Show("Vui lòng nhập Model", "Model rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(model, pattern))
            {
                MessageBox.Show("Model chỉ được chứa ký tự là chữ và số", "Model không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool IsValidPrice(string price)
        {
            string pattern = @"^[0-9]+$";
            if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Vui lòng nhập Giá", "Giá rỗng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!Regex.IsMatch(price, pattern))
            {
                MessageBox.Show("Giá chỉ được chứa các chữ số", "Giá không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

    }
}
