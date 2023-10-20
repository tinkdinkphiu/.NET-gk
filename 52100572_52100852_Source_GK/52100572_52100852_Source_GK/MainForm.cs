using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace _52100572_52100852_Source_GK
{
    public partial class MainForm : MaterialForm
    {
        bool sidebarExpand;
        public MainForm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Blue700, TextShade.WHITE);
        
            CarRental carRentalForm = new CarRental();
            EmbedFormInTabPage(carRentalForm, tab_home);
        }

        private void EmbedFormInTabPage(Form childForm, TabPage tabPage)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            //tabPage.Controls.Clear();  // Clear previous controls/forms from the tab page
            tabPage.Controls.Add(childForm);
            childForm.Show();
        }
        private void menuControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (menuControl.SelectedIndex)
            {
                case 0:
                    //CarRental carRentalForm = new CarRental();
                    //EmbedFormInTabPage(carRentalForm, tab_home);
                    break;
                case 1:
                    CarsManager carsManagerForm = new CarsManager();
                    EmbedFormInTabPage(carsManagerForm, tab_carsManager);
                    break;
            }
        }
    }
}
