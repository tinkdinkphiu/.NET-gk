using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using MaterialSkin;
using MaterialSkin.Controls;

namespace _52100572_52100852_Source_GK
{
    public partial class Login : MaterialForm
    {
        private MainForm mainForm;
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Tên đăng nhập trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Username.Focus();
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Mật khẩu trống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_Password.Focus();
            }
            else if (AccountBUS.Instance.Login(username, password))
            {
                mainForm = new MainForm();

                var materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.EnforceBackcolorOnAllComponents = true;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(MaterialSkin.Primary.Blue500, MaterialSkin.Primary.Blue700, MaterialSkin.Primary.Blue100, MaterialSkin.Accent.DeepOrange700, TextShade.WHITE);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài Khoản hoặc mật khẩu không đúng!", "Sai thông tin đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
            }
        }

    }
}
