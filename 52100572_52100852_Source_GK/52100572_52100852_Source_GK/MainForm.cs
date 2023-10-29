using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace _52100572_52100852_Source_GK
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                MaterialSkin.Primary.Indigo500,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Primary.Indigo100,
                MaterialSkin.Accent.Blue700,
                TextShade.WHITE
            );

            // Khởi tạo lúc vừa chạy form
            CarRental carRentalForm = new CarRental();
            EmbedFormInTabPage(carRentalForm, tab_Home);

            //Phân quyền
            if (SessionManager.Role != null)
            {
                if (!SessionManager.Role.Equals("admin"))
                {
                    menuControl.TabPages.Remove(tab_Statistic);
                    menuControl.TabPages.Remove(tab_Admin);
                }
            }

        }

        public void EmbedFormInTabPage(Form childForm, TabPage tabPage)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            tabPage.Controls.Clear();  // Xóa controls/forms cũ khỏi tab
            tabPage.Controls.Add(childForm);
            childForm.Show();
        }
        private void menuControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (menuControl.SelectedIndex)
            {
                case 0: // Trang chủ
                    CarRental carRentalForm = new CarRental();
                    EmbedFormInTabPage(carRentalForm, tab_Home);
                    break;
                case 1: // Quản lý xe
                    CarsManager carsManagerForm = new CarsManager();
                    EmbedFormInTabPage(carsManagerForm, tab_CarsManager);
                    break;
                case 2: // Quản lý khách hàng
                    CustomersManager customersManagerForm = new CustomersManager();
                    EmbedFormInTabPage(customersManagerForm, tab_Customer);
                    break;
                case 3: // Đơn đặt xe
                    Bill billForm = new Bill();
                    EmbedFormInTabPage(billForm, tab_Bill);
                    break;
                case 4: // Lịch trình
                    Schedule scheduleForm = new Schedule();
                    EmbedFormInTabPage(scheduleForm, tab_Schedule);
                    break;
                case 5: // Báo cáo thống kê
                    // Báo cáo thống kê chưa code
                    break;
                case 6: // Quản lý nhân viên
                    EmployeesManager employeesManagerForm = new EmployeesManager();
                    EmbedFormInTabPage(employeesManagerForm, tab_Admin);
                    break;
                default: break;
            }
        }
        public void startCarRental2(string carType)
        {
            CarRental2 carRental2Form = new CarRental2(carType);
            EmbedFormInTabPage(carRental2Form, tab_Home);
        }
        public void backToCarRental()
        {
            CarRental carRentalForm = new CarRental();
            EmbedFormInTabPage(carRentalForm, tab_Home);
        }
    }
}
