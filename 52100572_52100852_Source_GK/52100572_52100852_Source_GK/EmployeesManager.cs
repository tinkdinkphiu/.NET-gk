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
    public partial class EmployeesManager : Form
    {
        private bool isReloading = false;
        public EmployeesManager()
        {
            InitializeComponent();

            lv_EmployeeManager.Columns.Add("ID", 60);
            lv_EmployeeManager.Columns.Add("Username", 200);
            lv_EmployeeManager.Columns.Add("Role", 100);
        }

        void bindingData(List<AccountDTO> data)
        {
            lv_EmployeeManager.Items.Clear();
            foreach(var item in data)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems[0].Text = item.AccountID.ToString();
                listViewItem.SubItems.Add(item.Username);
                listViewItem.SubItems.Add(item.Role);

                lv_EmployeeManager.Items.Add(listViewItem);
            }
        }

        private void EmployeesManager_Load(object sender, EventArgs e)
        {
            List<AccountDTO> data = AccountBUS.Instance.GetAccountList();
            bindingData(data);
        }

        private void lv_EmployeeManager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isReloading)
            {
                isReloading = false;
                return;
            }
            foreach(ListViewItem item in lv_EmployeeManager.SelectedItems)
            {
                AccountDTO account = new AccountDTO
                {
                    AccountID = item.SubItems[0].Text,
                    Username = item.SubItems[1].Text,
                    Role = item.SubItems[2].Text
                };

                EmployeeDetail employeeDetail = new EmployeeDetail(account);
                employeeDetail.ShowDialog();
                EmployeesManager_Load(sender, e);
                isReloading=true;
                break;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            EmployeesManager_Load(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            string key = txt_Search.Text;
            List<AccountDTO> data;
            if(key.Length > 0)
            {
                data = AccountBUS.Instance.Search(key);
            }
            else
            {
                data = AccountBUS.Instance.Search(key);
            }
            bindingData(data);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            EmployeeDetail employeeDetail = new EmployeeDetail(null);
            employeeDetail.ShowDialog();
            EmployeesManager_Load(sender, e);
        }
    }
}
