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
            this.tab_home = new System.Windows.Forms.TabPage();
            this.tab_carsManager = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tab_customer = new System.Windows.Forms.TabPage();
            this.tab_bill = new System.Windows.Forms.TabPage();
            this.tab_schedule = new System.Windows.Forms.TabPage();
            this.tab_statistic = new System.Windows.Forms.TabPage();
            this.tab_admin = new System.Windows.Forms.TabPage();
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
            this.panel_body.Size = new System.Drawing.Size(974, 579);
            this.panel_body.TabIndex = 1;
            // 
            // menuControl
            // 
            this.menuControl.Controls.Add(this.tab_home);
            this.menuControl.Controls.Add(this.tab_carsManager);
            this.menuControl.Controls.Add(this.tab_customer);
            this.menuControl.Controls.Add(this.tab_bill);
            this.menuControl.Controls.Add(this.tab_schedule);
            this.menuControl.Controls.Add(this.tab_statistic);
            this.menuControl.Controls.Add(this.tab_admin);
            this.menuControl.Depth = 0;
            this.menuControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuControl.ImageList = this.imageList;
            this.menuControl.Location = new System.Drawing.Point(0, 0);
            this.menuControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.menuControl.Multiline = true;
            this.menuControl.Name = "menuControl";
            this.menuControl.SelectedIndex = 0;
            this.menuControl.Size = new System.Drawing.Size(974, 579);
            this.menuControl.TabIndex = 0;
            // 
            // tab_home
            // 
            this.tab_home.BackColor = System.Drawing.Color.White;
            this.tab_home.ImageKey = "home.png";
            this.tab_home.Location = new System.Drawing.Point(4, 39);
            this.tab_home.Name = "tab_home";
            this.tab_home.Padding = new System.Windows.Forms.Padding(3);
            this.tab_home.Size = new System.Drawing.Size(966, 536);
            this.tab_home.TabIndex = 0;
            this.tab_home.Text = "Trang chủ";
            // 
            // tab_carsManager
            // 
            this.tab_carsManager.BackColor = System.Drawing.Color.White;
            this.tab_carsManager.ImageKey = "car.png";
            this.tab_carsManager.Location = new System.Drawing.Point(4, 39);
            this.tab_carsManager.Name = "tab_carsManager";
            this.tab_carsManager.Padding = new System.Windows.Forms.Padding(3);
            this.tab_carsManager.Size = new System.Drawing.Size(966, 536);
            this.tab_carsManager.TabIndex = 1;
            this.tab_carsManager.Text = "Quản lý xe";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "bill.png");
            this.imageList.Images.SetKeyName(1, "car.png");
            this.imageList.Images.SetKeyName(2, "customer.png");
            this.imageList.Images.SetKeyName(3, "employee.png");
            this.imageList.Images.SetKeyName(4, "home.png");
            this.imageList.Images.SetKeyName(5, "schedule.png");
            this.imageList.Images.SetKeyName(6, "statistic.png");
            // 
            // tab_customer
            // 
            this.tab_customer.BackColor = System.Drawing.Color.White;
            this.tab_customer.ImageKey = "customer.png";
            this.tab_customer.Location = new System.Drawing.Point(4, 39);
            this.tab_customer.Name = "tab_customer";
            this.tab_customer.Size = new System.Drawing.Size(966, 536);
            this.tab_customer.TabIndex = 2;
            this.tab_customer.Text = "Khách hàng";
            // 
            // tab_bill
            // 
            this.tab_bill.BackColor = System.Drawing.Color.White;
            this.tab_bill.ImageKey = "bill.png";
            this.tab_bill.Location = new System.Drawing.Point(4, 39);
            this.tab_bill.Name = "tab_bill";
            this.tab_bill.Size = new System.Drawing.Size(966, 536);
            this.tab_bill.TabIndex = 3;
            this.tab_bill.Text = "Đơn đặt xe";
            // 
            // tab_schedule
            // 
            this.tab_schedule.BackColor = System.Drawing.Color.White;
            this.tab_schedule.ImageKey = "schedule.png";
            this.tab_schedule.Location = new System.Drawing.Point(4, 39);
            this.tab_schedule.Name = "tab_schedule";
            this.tab_schedule.Size = new System.Drawing.Size(966, 536);
            this.tab_schedule.TabIndex = 4;
            this.tab_schedule.Text = "Lịch trình";
            // 
            // tab_statistic
            // 
            this.tab_statistic.BackColor = System.Drawing.Color.White;
            this.tab_statistic.ImageKey = "statistic.png";
            this.tab_statistic.Location = new System.Drawing.Point(4, 39);
            this.tab_statistic.Name = "tab_statistic";
            this.tab_statistic.Size = new System.Drawing.Size(966, 536);
            this.tab_statistic.TabIndex = 5;
            this.tab_statistic.Text = "Báo cáo thống kê";
            // 
            // tab_admin
            // 
            this.tab_admin.BackColor = System.Drawing.Color.White;
            this.tab_admin.ImageKey = "employee.png";
            this.tab_admin.Location = new System.Drawing.Point(4, 39);
            this.tab_admin.Name = "tab_admin";
            this.tab_admin.Size = new System.Drawing.Size(966, 536);
            this.tab_admin.TabIndex = 6;
            this.tab_admin.Text = "Nhân viên";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 643);
            this.Controls.Add(this.panel_body);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.menuControl;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Text = "Trang chủ";
            this.panel_body.ResumeLayout(false);
            this.menuControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_body;
        private MaterialSkin.Controls.MaterialTabControl menuControl;
        private System.Windows.Forms.TabPage tab_home;
        private System.Windows.Forms.TabPage tab_carsManager;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tab_customer;
        private System.Windows.Forms.TabPage tab_bill;
        private System.Windows.Forms.TabPage tab_schedule;
        private System.Windows.Forms.TabPage tab_statistic;
        private System.Windows.Forms.TabPage tab_admin;
    }
}