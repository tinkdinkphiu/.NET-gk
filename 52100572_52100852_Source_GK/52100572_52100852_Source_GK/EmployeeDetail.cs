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
    public partial class EmployeeDetail : MaterialForm
    {
        private AccountDTO accountDTO;
        public EmployeeDetail(AccountDTO accountDTO)
        {
            InitializeComponent();

            this.accountDTO = accountDTO;
            if(accountDTO != null )
            {
                txt_Username.Text = accountDTO.Username;
                txt_Password.Text = accountDTO.Password;
                int index = cbb_Role.FindString(accountDTO.Role);
                if(index != -1 )
                {
                    cbb_Role.SelectedIndex = index;
                }

                Toggle(false);
            }
            else
            {
                Toggle(true);
            }
        }

        public void Toggle(bool isEditing)
        {
            if(isEditing)
            {
                txt_Username.Enabled = true;
                txt_Password.Enabled = true;
                cbb_Role.Enabled = true;
                btn_Edit.Visible = false;
                btn_Delete.Visible = false;
                btn_Save.Visible = true;
                btn_Cancel.Visible = true;
            }
            else
            {
                txt_Username.Enabled = false;   
                txt_Password.Enabled = false;
                cbb_Role.Enabled = false;
                btn_Edit.Visible = true;
                btn_Delete.Visible = true;
                btn_Save.Visible = false;
                btn_Cancel.Visible = false;
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Toggle(true);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if(accountDTO != null)
            {
                accountDTO.Role = cbb_Role.Text;

                if(AccountBUS.Instance.UpdateAccount(accountDTO))
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
                accountDTO = new AccountDTO { 
                    Username = txt_Username.Text,
                    Password = txt_Password.Text,
                    Role = cbb_Role.Text,
                };
                if (AccountBUS.Instance.AddAccount(accountDTO))
                {
                    MessageBox.Show("Thêm thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if(accountDTO != null)
            {
                if (AccountBUS.Instance.DeleteAccount(accountDTO.Username))
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

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            if(accountDTO != null)
            {
                txt_Username.Text = accountDTO.Username;
                int index = cbb_Role.FindString(accountDTO.Role);
                if(index != -1)
                {
                    cbb_Role.SelectedIndex = index;
                    Toggle(false);
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
