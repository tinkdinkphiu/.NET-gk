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
    public partial class CarRental : Form
    {
        public CarRental()
        {
            InitializeComponent();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.startCarRental2("4 cho (Mini)");
        }
        private void sedan_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.startCarRental2("4 cho (Sedan)");
        }
        private void hatchback_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.startCarRental2("4 cho (Hatchback)");
        }
        private void cuv_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.startCarRental2("5 cho (CUV Gam cao)");
        }
        private void suv_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.startCarRental2("7 cho (SUV Gam cao)");
        }
        private void mpv_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.startCarRental2("7 cho (MPV Gam thap)");
        }
        private void truck_Click(object sender, EventArgs e)
        {
            MainForm mainForm = this.ParentForm as MainForm;
            mainForm.startCarRental2("Ban tai");
        }
    }
}
