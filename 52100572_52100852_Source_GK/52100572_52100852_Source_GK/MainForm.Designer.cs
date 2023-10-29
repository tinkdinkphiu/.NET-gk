using System.Drawing;

namespace _52100572_52100852_Source_GK
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_body = new System.Windows.Forms.Panel();
            this.menuControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tab_Home = new System.Windows.Forms.TabPage();
            this.tab_CarsManager = new System.Windows.Forms.TabPage();
            this.tab_Customer = new System.Windows.Forms.TabPage();
            this.tab_Bill = new System.Windows.Forms.TabPage();
            this.tab_Schedule = new System.Windows.Forms.TabPage();
            this.tab_Statistic = new System.Windows.Forms.TabPage();
            this.tab_Admin = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel_body.SuspendLayout();
            this.menuControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.menuControl);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 64);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1200, 736);
            this.panel_body.TabIndex = 1;
            // 
            // menuControl
            // 
            this.menuControl.Controls.Add(this.tab_Home);
            this.menuControl.Controls.Add(this.tab_CarsManager);
            this.menuControl.Controls.Add(this.tab_Customer);
            this.menuControl.Controls.Add(this.tab_Bill);
            this.menuControl.Controls.Add(this.tab_Schedule);
            this.menuControl.Controls.Add(this.tab_Statistic);
            this.menuControl.Controls.Add(this.tab_Admin);
            this.menuControl.Depth = 0;
            this.menuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl.ImageList = this.imageList;
            this.menuControl.Location = new System.Drawing.Point(0, 0);
            this.menuControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuControl.Multiline = true;
            this.menuControl.Name = "menuControl";
            this.menuControl.SelectedIndex = 0;
            this.menuControl.Size = new System.Drawing.Size(1200, 736);
            this.menuControl.TabIndex = 0;
            this.menuControl.SelectedIndexChanged += new System.EventHandler(this.menuControl_SelectedIndexChanged);
            // 
            // tab_Home
            // 
            this.tab_Home.BackColor = System.Drawing.Color.White;
            this.tab_Home.ImageKey = "home.png";
            this.tab_Home.Location = new System.Drawing.Point(4, 39);
            this.tab_Home.Name = "tab_Home";
            this.tab_Home.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_Home.Size = new System.Drawing.Size(1192, 693);
            this.tab_Home.TabIndex = 0;
            this.tab_Home.Text = "Trang chủ";
            // 
            // tab_CarsManager
            // 
            this.tab_CarsManager.BackColor = System.Drawing.Color.White;
            this.tab_CarsManager.ImageKey = "car.png";
            this.tab_CarsManager.Location = new System.Drawing.Point(4, 39);
            this.tab_CarsManager.Name = "tab_CarsManager";
            this.tab_CarsManager.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_CarsManager.Size = new System.Drawing.Size(1192, 693);
            this.tab_CarsManager.TabIndex = 1;
            this.tab_CarsManager.Text = "Quản lý xe";
            // 
            // tab_Customer
            // 
            this.tab_Customer.BackColor = System.Drawing.Color.White;
            this.tab_Customer.ImageKey = "customer.png";
            this.tab_Customer.Location = new System.Drawing.Point(4, 39);
            this.tab_Customer.Name = "tab_Customer";
            this.tab_Customer.Size = new System.Drawing.Size(1192, 693);
            this.tab_Customer.TabIndex = 2;
            this.tab_Customer.Text = "Khách hàng";
            // 
            // tab_Bill
            // 
            this.tab_Bill.BackColor = System.Drawing.Color.White;
            this.tab_Bill.ImageKey = "bill.png";
            this.tab_Bill.Location = new System.Drawing.Point(4, 39);
            this.tab_Bill.Name = "tab_Bill";
            this.tab_Bill.Size = new System.Drawing.Size(1192, 693);
            this.tab_Bill.TabIndex = 3;
            this.tab_Bill.Text = "Đơn đặt xe";
            // 
            // tab_Schedule
            // 
            this.tab_Schedule.BackColor = System.Drawing.Color.White;
            this.tab_Schedule.ImageKey = "schedule.png";
            this.tab_Schedule.Location = new System.Drawing.Point(4, 39);
            this.tab_Schedule.Name = "tab_Schedule";
            this.tab_Schedule.Size = new System.Drawing.Size(1192, 693);
            this.tab_Schedule.TabIndex = 4;
            this.tab_Schedule.Text = "Lịch trình";
            // 
            // tab_Statistic
            // 
            this.tab_Statistic.BackColor = System.Drawing.Color.White;
            this.tab_Statistic.ImageKey = "statistic.png";
            this.tab_Statistic.Location = new System.Drawing.Point(4, 39);
            this.tab_Statistic.Name = "tab_Statistic";
            this.tab_Statistic.Size = new System.Drawing.Size(1192, 693);
            this.tab_Statistic.TabIndex = 5;
            this.tab_Statistic.Text = "Báo cáo thống kê";
            // 
            // tab_Admin
            // 
            this.tab_Admin.BackColor = System.Drawing.Color.White;
            this.tab_Admin.ImageKey = "employee.png";
            this.tab_Admin.Location = new System.Drawing.Point(4, 39);
            this.tab_Admin.Name = "tab_Admin";
            this.tab_Admin.Size = new System.Drawing.Size(1192, 693);
            this.tab_Admin.TabIndex = 6;
            this.tab_Admin.Text = "Nhân viên";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bill.png");
            this.imageList.Images.SetKeyName(1, "car.png");
            this.imageList.Images.SetKeyName(2, "customer.png");
            this.imageList.Images.SetKeyName(3, "employee.png");
            this.imageList.Images.SetKeyName(4, "schedule.png");
            this.imageList.Images.SetKeyName(5, "statistic.png");
            this.imageList.Images.SetKeyName(6, "home.png");
            this.imageList.Images.SetKeyName(7, "log out.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.panel_body);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.menuControl;
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.panel_body.ResumeLayout(false);
            this.menuControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_body;
        private MaterialSkin.Controls.MaterialTabControl menuControl;
        private System.Windows.Forms.TabPage tab_Home;
        private System.Windows.Forms.TabPage tab_CarsManager;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tab_Customer;
        private System.Windows.Forms.TabPage tab_Bill;
        private System.Windows.Forms.TabPage tab_Schedule;
        private System.Windows.Forms.TabPage tab_Statistic;
        private System.Windows.Forms.TabPage tab_Admin;
    }
}