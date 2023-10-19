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
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.btn_menu = new MaterialSkin.Controls.MaterialButton();
            this.pn_home = new System.Windows.Forms.Panel();
            this.btn_home = new MaterialSkin.Controls.MaterialButton();
            this.pn_carlist = new System.Windows.Forms.Panel();
            this.btn_carList = new MaterialSkin.Controls.MaterialButton();
            this.pn_customer = new System.Windows.Forms.Panel();
            this.btn_customer = new MaterialSkin.Controls.MaterialButton();
            this.pn_orderList = new System.Windows.Forms.Panel();
            this.btn_orderList = new MaterialSkin.Controls.MaterialButton();
            this.pn_schedule = new System.Windows.Forms.Panel();
            this.btn_schedule = new MaterialSkin.Controls.MaterialButton();
            this.pn_statistic = new System.Windows.Forms.Panel();
            this.btn_statistic = new MaterialSkin.Controls.MaterialButton();
            this.pn_admin = new System.Windows.Forms.Panel();
            this.btn_admin = new MaterialSkin.Controls.MaterialButton();
            this.sideBarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel_body = new System.Windows.Forms.Panel();
            this.sideBar.SuspendLayout();
            this.pn_menu.SuspendLayout();
            this.pn_home.SuspendLayout();
            this.pn_carlist.SuspendLayout();
            this.pn_customer.SuspendLayout();
            this.pn_orderList.SuspendLayout();
            this.pn_schedule.SuspendLayout();
            this.pn_statistic.SuspendLayout();
            this.pn_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.sideBar.Controls.Add(this.pn_menu);
            this.sideBar.Controls.Add(this.pn_home);
            this.sideBar.Controls.Add(this.pn_carlist);
            this.sideBar.Controls.Add(this.pn_customer);
            this.sideBar.Controls.Add(this.pn_orderList);
            this.sideBar.Controls.Add(this.pn_schedule);
            this.sideBar.Controls.Add(this.pn_statistic);
            this.sideBar.Controls.Add(this.pn_admin);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.Location = new System.Drawing.Point(0, 64);
            this.sideBar.Margin = new System.Windows.Forms.Padding(0);
            this.sideBar.MaximumSize = new System.Drawing.Size(250, 2000);
            this.sideBar.MinimumSize = new System.Drawing.Size(52, 2000);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(250, 2000);
            this.sideBar.TabIndex = 0;
            // 
            // pn_menu
            // 
            this.pn_menu.Controls.Add(this.btn_menu);
            this.pn_menu.Location = new System.Drawing.Point(3, 3);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(250, 100);
            this.pn_menu.TabIndex = 1;
            // 
            // btn_menu
            // 
            this.btn_menu.AutoSize = false;
            this.btn_menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_menu.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_menu.Depth = 0;
            this.btn_menu.HighEmphasis = true;
            this.btn_menu.Icon = null;
            this.btn_menu.Location = new System.Drawing.Point(-39, -17);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_menu.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_menu.Size = new System.Drawing.Size(326, 134);
            this.btn_menu.TabIndex = 2;
            this.btn_menu.Text = "Menu";
            this.btn_menu.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_menu.UseAccentColor = false;
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // pn_home
            // 
            this.pn_home.Controls.Add(this.btn_home);
            this.pn_home.Location = new System.Drawing.Point(3, 109);
            this.pn_home.Name = "pn_home";
            this.pn_home.Size = new System.Drawing.Size(250, 60);
            this.pn_home.TabIndex = 6;
            // 
            // btn_home
            // 
            this.btn_home.AutoSize = false;
            this.btn_home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_home.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_home.Depth = 0;
            this.btn_home.HighEmphasis = true;
            this.btn_home.Icon = null;
            this.btn_home.Location = new System.Drawing.Point(-25, -19);
            this.btn_home.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_home.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_home.Name = "btn_home";
            this.btn_home.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_home.Size = new System.Drawing.Size(300, 100);
            this.btn_home.TabIndex = 2;
            this.btn_home.Text = "Trang chủ";
            this.btn_home.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_home.UseAccentColor = false;
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // pn_carlist
            // 
            this.pn_carlist.Controls.Add(this.btn_carList);
            this.pn_carlist.Location = new System.Drawing.Point(3, 175);
            this.pn_carlist.Name = "pn_carlist";
            this.pn_carlist.Size = new System.Drawing.Size(250, 60);
            this.pn_carlist.TabIndex = 5;
            // 
            // btn_carList
            // 
            this.btn_carList.AutoSize = false;
            this.btn_carList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_carList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_carList.Depth = 0;
            this.btn_carList.HighEmphasis = true;
            this.btn_carList.Icon = null;
            this.btn_carList.Location = new System.Drawing.Point(-25, -19);
            this.btn_carList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_carList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_carList.Name = "btn_carList";
            this.btn_carList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_carList.Size = new System.Drawing.Size(300, 100);
            this.btn_carList.TabIndex = 2;
            this.btn_carList.Text = "Danh sách xe";
            this.btn_carList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_carList.UseAccentColor = false;
            this.btn_carList.UseVisualStyleBackColor = true;
            this.btn_carList.Click += new System.EventHandler(this.btn_carList_Click);
            // 
            // pn_customer
            // 
            this.pn_customer.Controls.Add(this.btn_customer);
            this.pn_customer.Location = new System.Drawing.Point(3, 241);
            this.pn_customer.Name = "pn_customer";
            this.pn_customer.Size = new System.Drawing.Size(250, 60);
            this.pn_customer.TabIndex = 4;
            // 
            // btn_customer
            // 
            this.btn_customer.AutoSize = false;
            this.btn_customer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_customer.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_customer.Depth = 0;
            this.btn_customer.HighEmphasis = true;
            this.btn_customer.Icon = null;
            this.btn_customer.Location = new System.Drawing.Point(-25, -19);
            this.btn_customer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_customer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_customer.Size = new System.Drawing.Size(300, 100);
            this.btn_customer.TabIndex = 2;
            this.btn_customer.Text = "Khách hàng";
            this.btn_customer.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_customer.UseAccentColor = false;
            this.btn_customer.UseVisualStyleBackColor = true;
            // 
            // pn_orderList
            // 
            this.pn_orderList.Controls.Add(this.btn_orderList);
            this.pn_orderList.Location = new System.Drawing.Point(3, 307);
            this.pn_orderList.Name = "pn_orderList";
            this.pn_orderList.Size = new System.Drawing.Size(250, 65);
            this.pn_orderList.TabIndex = 3;
            // 
            // btn_orderList
            // 
            this.btn_orderList.AutoSize = false;
            this.btn_orderList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_orderList.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_orderList.Depth = 0;
            this.btn_orderList.HighEmphasis = true;
            this.btn_orderList.Icon = null;
            this.btn_orderList.Location = new System.Drawing.Point(-25, -19);
            this.btn_orderList.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_orderList.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_orderList.Name = "btn_orderList";
            this.btn_orderList.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_orderList.Size = new System.Drawing.Size(300, 100);
            this.btn_orderList.TabIndex = 2;
            this.btn_orderList.Text = "Đơn đặt xe";
            this.btn_orderList.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_orderList.UseAccentColor = false;
            this.btn_orderList.UseVisualStyleBackColor = true;
            // 
            // pn_schedule
            // 
            this.pn_schedule.Controls.Add(this.btn_schedule);
            this.pn_schedule.Location = new System.Drawing.Point(3, 378);
            this.pn_schedule.Name = "pn_schedule";
            this.pn_schedule.Size = new System.Drawing.Size(250, 60);
            this.pn_schedule.TabIndex = 3;
            // 
            // btn_schedule
            // 
            this.btn_schedule.AutoSize = false;
            this.btn_schedule.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_schedule.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_schedule.Depth = 0;
            this.btn_schedule.HighEmphasis = true;
            this.btn_schedule.Icon = null;
            this.btn_schedule.Location = new System.Drawing.Point(-25, -19);
            this.btn_schedule.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_schedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_schedule.Size = new System.Drawing.Size(300, 100);
            this.btn_schedule.TabIndex = 2;
            this.btn_schedule.Text = "Lịch trình";
            this.btn_schedule.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_schedule.UseAccentColor = false;
            this.btn_schedule.UseVisualStyleBackColor = true;
            // 
            // pn_statistic
            // 
            this.pn_statistic.Controls.Add(this.btn_statistic);
            this.pn_statistic.Location = new System.Drawing.Point(3, 444);
            this.pn_statistic.Name = "pn_statistic";
            this.pn_statistic.Size = new System.Drawing.Size(250, 60);
            this.pn_statistic.TabIndex = 1;
            // 
            // btn_statistic
            // 
            this.btn_statistic.AutoSize = false;
            this.btn_statistic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_statistic.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_statistic.Depth = 0;
            this.btn_statistic.HighEmphasis = true;
            this.btn_statistic.Icon = null;
            this.btn_statistic.Location = new System.Drawing.Point(-25, -19);
            this.btn_statistic.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_statistic.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_statistic.Name = "btn_statistic";
            this.btn_statistic.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_statistic.Size = new System.Drawing.Size(300, 100);
            this.btn_statistic.TabIndex = 2;
            this.btn_statistic.Text = "Báo cáo, thống kê";
            this.btn_statistic.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_statistic.UseAccentColor = false;
            this.btn_statistic.UseVisualStyleBackColor = true;
            // 
            // pn_admin
            // 
            this.pn_admin.Controls.Add(this.btn_admin);
            this.pn_admin.Location = new System.Drawing.Point(3, 510);
            this.pn_admin.Name = "pn_admin";
            this.pn_admin.Size = new System.Drawing.Size(250, 60);
            this.pn_admin.TabIndex = 3;
            // 
            // btn_admin
            // 
            this.btn_admin.AutoSize = false;
            this.btn_admin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_admin.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_admin.Depth = 0;
            this.btn_admin.HighEmphasis = true;
            this.btn_admin.Icon = null;
            this.btn_admin.Location = new System.Drawing.Point(-25, -19);
            this.btn_admin.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_admin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_admin.Size = new System.Drawing.Size(300, 100);
            this.btn_admin.TabIndex = 2;
            this.btn_admin.Text = "Quản lý nhân viên";
            this.btn_admin.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_admin.UseAccentColor = false;
            this.btn_admin.UseVisualStyleBackColor = true;
            // 
            // sideBarTimer
            // 
            this.sideBarTimer.Interval = 10;
            this.sideBarTimer.Tick += new System.EventHandler(this.sideBarTimer_Tick);
            // 
            // panel_body
            // 
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(250, 64);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(724, 579);
            this.panel_body.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 643);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.sideBar);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 64, 0, 0);
            this.Text = "Trang chủ";
            this.sideBar.ResumeLayout(false);
            this.pn_menu.ResumeLayout(false);
            this.pn_home.ResumeLayout(false);
            this.pn_carlist.ResumeLayout(false);
            this.pn_customer.ResumeLayout(false);
            this.pn_orderList.ResumeLayout(false);
            this.pn_schedule.ResumeLayout(false);
            this.pn_statistic.ResumeLayout(false);
            this.pn_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel pn_statistic;
        private MaterialSkin.Controls.MaterialButton btn_statistic;
        private System.Windows.Forms.Panel pn_home;
        private MaterialSkin.Controls.MaterialButton btn_home;
        private System.Windows.Forms.Panel pn_carlist;
        private MaterialSkin.Controls.MaterialButton btn_carList;
        private System.Windows.Forms.Panel pn_customer;
        private MaterialSkin.Controls.MaterialButton btn_customer;
        private System.Windows.Forms.Panel pn_orderList;
        private MaterialSkin.Controls.MaterialButton btn_orderList;
        private System.Windows.Forms.Panel pn_schedule;
        private MaterialSkin.Controls.MaterialButton btn_schedule;
        private System.Windows.Forms.Panel pn_admin;
        private MaterialSkin.Controls.MaterialButton btn_admin;
        private System.Windows.Forms.Panel pn_menu;
        private MaterialSkin.Controls.MaterialButton btn_menu;
        private System.Windows.Forms.Timer sideBarTimer;
        private System.Windows.Forms.Panel panel_body;
    }
}