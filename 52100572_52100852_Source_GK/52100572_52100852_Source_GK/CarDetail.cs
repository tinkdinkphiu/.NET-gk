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

        private void lbl_GiaThue_Click(object sender, EventArgs e)
        {

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
                    MessageBox.Show("Cập nhật không thành công");
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
                    MessageBox.Show("Cập nhật không thành công");
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
                    MessageBox.Show("Xóa không thành công");
                }
            }
        }
    }
}
