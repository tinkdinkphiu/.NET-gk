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
            
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;   
            if (AccountBUS.Instance.Login(username, password))
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
                MessageBox.Show("Tài Khoản hoặc mật khẩu không đúng!");
            }

        }
    }
}
