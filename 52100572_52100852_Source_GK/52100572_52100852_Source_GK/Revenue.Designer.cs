namespace _52100572_52100852_Source_GK
{
    partial class Revenue
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
            this.lv_Revenue = new MaterialSkin.Controls.MaterialListView();
            this.lbl_Schedule = new MaterialSkin.Controls.MaterialLabel();
            this.cbb_RevenueBy = new MaterialSkin.Controls.MaterialComboBox();
            this.dtpk_BatDau = new System.Windows.Forms.DateTimePicker();
            this.lbl_DateStart = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_DateEnd = new MaterialSkin.Controls.MaterialLabel();
            this.dtpk_KetThuc = new System.Windows.Forms.DateTimePicker();
            this.pieChart_Quantity = new LiveCharts.WinForms.PieChart();
            this.pieChart_Revenue = new LiveCharts.WinForms.PieChart();
            this.lbl_Quantity = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_Profit = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Load = new MaterialSkin.Controls.MaterialButton();
            this.chart_RevenueOfYear = new LiveCharts.WinForms.CartesianChart();
            this.pieChart_CarDistributionByType = new LiveCharts.WinForms.PieChart();
            this.lbl_CarType = new MaterialSkin.Controls.MaterialLabel();
            this.dtpk_Year = new System.Windows.Forms.DateTimePicker();
            this.btn_LoadRevenueByYear = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lv_Revenue
            // 
            this.lv_Revenue.AutoSizeTable = false;
            this.lv_Revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Revenue.Depth = 0;
            this.lv_Revenue.FullRowSelect = true;
            this.lv_Revenue.HideSelection = false;
            this.lv_Revenue.Location = new System.Drawing.Point(24, 135);
            this.lv_Revenue.Margin = new System.Windows.Forms.Padding(2);
            this.lv_Revenue.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv_Revenue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_Revenue.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_Revenue.Name = "lv_Revenue";
            this.lv_Revenue.OwnerDraw = true;
            this.lv_Revenue.Size = new System.Drawing.Size(298, 103);
            this.lv_Revenue.TabIndex = 9;
            this.lv_Revenue.UseCompatibleStateImageBehavior = false;
            this.lv_Revenue.View = System.Windows.Forms.View.Details;
            // 
            // lbl_Schedule
            // 
            this.lbl_Schedule.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Schedule.Depth = 0;
            this.lbl_Schedule.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Schedule.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_Schedule.Location = new System.Drawing.Point(0, 0);
            this.lbl_Schedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Schedule.Name = "lbl_Schedule";
            this.lbl_Schedule.Size = new System.Drawing.Size(975, 60);
            this.lbl_Schedule.TabIndex = 8;
            this.lbl_Schedule.Text = "Thống Kê";
            this.lbl_Schedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbb_RevenueBy
            // 
            this.cbb_RevenueBy.AutoResize = false;
            this.cbb_RevenueBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_RevenueBy.Depth = 0;
            this.cbb_RevenueBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_RevenueBy.DropDownHeight = 174;
            this.cbb_RevenueBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_RevenueBy.DropDownWidth = 121;
            this.cbb_RevenueBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_RevenueBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_RevenueBy.FormattingEnabled = true;
            this.cbb_RevenueBy.IntegralHeight = false;
            this.cbb_RevenueBy.ItemHeight = 43;
            this.cbb_RevenueBy.Items.AddRange(new object[] {
            "Hãng xe",
            "Mẫu xe"});
            this.cbb_RevenueBy.Location = new System.Drawing.Point(24, 62);
            this.cbb_RevenueBy.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_RevenueBy.MaxDropDownItems = 4;
            this.cbb_RevenueBy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_RevenueBy.Name = "cbb_RevenueBy";
            this.cbb_RevenueBy.Size = new System.Drawing.Size(200, 49);
            this.cbb_RevenueBy.StartIndex = 0;
            this.cbb_RevenueBy.TabIndex = 10;
            // 
            // dtpk_BatDau
            // 
            this.dtpk_BatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpk_BatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_BatDau.Location = new System.Drawing.Point(316, 62);
            this.dtpk_BatDau.Margin = new System.Windows.Forms.Padding(2);
            this.dtpk_BatDau.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpk_BatDau.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpk_BatDau.MinimumSize = new System.Drawing.Size(200, 48);
            this.dtpk_BatDau.Name = "dtpk_BatDau";
            this.dtpk_BatDau.Size = new System.Drawing.Size(200, 48);
            this.dtpk_BatDau.TabIndex = 50;
            // 
            // lbl_DateStart
            // 
            this.lbl_DateStart.Depth = 0;
            this.lbl_DateStart.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_DateStart.Location = new System.Drawing.Point(252, 62);
            this.lbl_DateStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DateStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_DateStart.Name = "lbl_DateStart";
            this.lbl_DateStart.Size = new System.Drawing.Size(60, 48);
            this.lbl_DateStart.TabIndex = 51;
            this.lbl_DateStart.Text = "Từ ngày";
            this.lbl_DateStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_DateEnd
            // 
            this.lbl_DateEnd.Depth = 0;
            this.lbl_DateEnd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_DateEnd.Location = new System.Drawing.Point(544, 62);
            this.lbl_DateEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_DateEnd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_DateEnd.Name = "lbl_DateEnd";
            this.lbl_DateEnd.Size = new System.Drawing.Size(70, 48);
            this.lbl_DateEnd.TabIndex = 53;
            this.lbl_DateEnd.Text = "Đến ngày";
            this.lbl_DateEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpk_KetThuc
            // 
            this.dtpk_KetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpk_KetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_KetThuc.Location = new System.Drawing.Point(618, 63);
            this.dtpk_KetThuc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpk_KetThuc.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpk_KetThuc.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpk_KetThuc.MinimumSize = new System.Drawing.Size(200, 48);
            this.dtpk_KetThuc.Name = "dtpk_KetThuc";
            this.dtpk_KetThuc.Size = new System.Drawing.Size(200, 48);
            this.dtpk_KetThuc.TabIndex = 52;
            // 
            // pieChart_Quantity
            // 
            this.pieChart_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pieChart_Quantity.Location = new System.Drawing.Point(627, 224);
            this.pieChart_Quantity.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart_Quantity.Name = "pieChart_Quantity";
            this.pieChart_Quantity.Size = new System.Drawing.Size(150, 150);
            this.pieChart_Quantity.TabIndex = 54;
            this.pieChart_Quantity.Text = "pieChart1";
            // 
            // pieChart_Revenue
            // 
            this.pieChart_Revenue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pieChart_Revenue.Location = new System.Drawing.Point(762, 354);
            this.pieChart_Revenue.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart_Revenue.Name = "pieChart_Revenue";
            this.pieChart_Revenue.Size = new System.Drawing.Size(150, 150);
            this.pieChart_Revenue.TabIndex = 55;
            this.pieChart_Revenue.Text = "pieChart1";
            // 
            // lbl_Quantity
            // 
            this.lbl_Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Quantity.Depth = 0;
            this.lbl_Quantity.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Quantity.Location = new System.Drawing.Point(24, 506);
            this.lbl_Quantity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Quantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Quantity.Name = "lbl_Quantity";
            this.lbl_Quantity.Size = new System.Drawing.Size(150, 48);
            this.lbl_Quantity.TabIndex = 56;
            this.lbl_Quantity.Text = "Số lượng";
            this.lbl_Quantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Profit
            // 
            this.lbl_Profit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_Profit.Depth = 0;
            this.lbl_Profit.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Profit.Location = new System.Drawing.Point(278, 506);
            this.lbl_Profit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Profit.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Profit.Name = "lbl_Profit";
            this.lbl_Profit.Size = new System.Drawing.Size(150, 48);
            this.lbl_Profit.TabIndex = 57;
            this.lbl_Profit.Text = "Doanh Thu";
            this.lbl_Profit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Load
            // 
            this.btn_Load.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Load.AutoSize = false;
            this.btn_Load.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Load.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Load.Depth = 0;
            this.btn_Load.HighEmphasis = true;
            this.btn_Load.Icon = null;
            this.btn_Load.Location = new System.Drawing.Point(871, 71);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Load.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Load.Size = new System.Drawing.Size(80, 40);
            this.btn_Load.TabIndex = 58;
            this.btn_Load.Text = "Load";
            this.btn_Load.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Load.UseAccentColor = false;
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // chart_RevenueOfYear
            // 
            this.chart_RevenueOfYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_RevenueOfYear.Location = new System.Drawing.Point(351, 135);
            this.chart_RevenueOfYear.Margin = new System.Windows.Forms.Padding(2);
            this.chart_RevenueOfYear.Name = "chart_RevenueOfYear";
            this.chart_RevenueOfYear.Size = new System.Drawing.Size(600, 200);
            this.chart_RevenueOfYear.TabIndex = 59;
            this.chart_RevenueOfYear.Text = "cartesianChart1";
            // 
            // pieChart_CarDistributionByType
            // 
            this.pieChart_CarDistributionByType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pieChart_CarDistributionByType.Location = new System.Drawing.Point(532, 354);
            this.pieChart_CarDistributionByType.Margin = new System.Windows.Forms.Padding(2);
            this.pieChart_CarDistributionByType.Name = "pieChart_CarDistributionByType";
            this.pieChart_CarDistributionByType.Size = new System.Drawing.Size(150, 150);
            this.pieChart_CarDistributionByType.TabIndex = 60;
            this.pieChart_CarDistributionByType.Text = "pieChart1";
            // 
            // lbl_CarType
            // 
            this.lbl_CarType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_CarType.Depth = 0;
            this.lbl_CarType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_CarType.Location = new System.Drawing.Point(527, 506);
            this.lbl_CarType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CarType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_CarType.Name = "lbl_CarType";
            this.lbl_CarType.Size = new System.Drawing.Size(160, 48);
            this.lbl_CarType.TabIndex = 61;
            this.lbl_CarType.Text = "Phân Bố Xe Theo Loại";
            this.lbl_CarType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpk_Year
            // 
            this.dtpk_Year.CustomFormat = "yyyy";
            this.dtpk_Year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_Year.Location = new System.Drawing.Point(24, 263);
            this.dtpk_Year.Margin = new System.Windows.Forms.Padding(2);
            this.dtpk_Year.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpk_Year.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpk_Year.MinimumSize = new System.Drawing.Size(200, 48);
            this.dtpk_Year.Name = "dtpk_Year";
            this.dtpk_Year.Size = new System.Drawing.Size(200, 48);
            this.dtpk_Year.TabIndex = 62;
            // 
            // btn_LoadRevenueByYear
            // 
            this.btn_LoadRevenueByYear.AutoSize = false;
            this.btn_LoadRevenueByYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_LoadRevenueByYear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_LoadRevenueByYear.Depth = 0;
            this.btn_LoadRevenueByYear.HighEmphasis = true;
            this.btn_LoadRevenueByYear.Icon = null;
            this.btn_LoadRevenueByYear.Location = new System.Drawing.Point(242, 263);
            this.btn_LoadRevenueByYear.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_LoadRevenueByYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_LoadRevenueByYear.Name = "btn_LoadRevenueByYear";
            this.btn_LoadRevenueByYear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_LoadRevenueByYear.Size = new System.Drawing.Size(80, 40);
            this.btn_LoadRevenueByYear.TabIndex = 63;
            this.btn_LoadRevenueByYear.Text = "Load";
            this.btn_LoadRevenueByYear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_LoadRevenueByYear.UseAccentColor = false;
            this.btn_LoadRevenueByYear.UseVisualStyleBackColor = true;
            this.btn_LoadRevenueByYear.Click += new System.EventHandler(this.btn_LoadRevenueByYear_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 578);
            this.Controls.Add(this.btn_LoadRevenueByYear);
            this.Controls.Add(this.dtpk_Year);
            this.Controls.Add(this.lbl_CarType);
            this.Controls.Add(this.pieChart_CarDistributionByType);
            this.Controls.Add(this.chart_RevenueOfYear);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.lbl_Profit);
            this.Controls.Add(this.lbl_Quantity);
            this.Controls.Add(this.pieChart_Revenue);
            this.Controls.Add(this.pieChart_Quantity);
            this.Controls.Add(this.lbl_DateEnd);
            this.Controls.Add(this.dtpk_KetThuc);
            this.Controls.Add(this.lbl_DateStart);
            this.Controls.Add(this.dtpk_BatDau);
            this.Controls.Add(this.cbb_RevenueBy);
            this.Controls.Add(this.lv_Revenue);
            this.Controls.Add(this.lbl_Schedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(975, 578);
            this.Name = "Revenue";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Revenue_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView lv_Revenue;
        private MaterialSkin.Controls.MaterialLabel lbl_Schedule;
        private MaterialSkin.Controls.MaterialComboBox cbb_RevenueBy;
        private System.Windows.Forms.DateTimePicker dtpk_BatDau;
        private MaterialSkin.Controls.MaterialLabel lbl_DateStart;
        private MaterialSkin.Controls.MaterialLabel lbl_DateEnd;
        private System.Windows.Forms.DateTimePicker dtpk_KetThuc;
        private LiveCharts.WinForms.PieChart pieChart_Quantity;
        private LiveCharts.WinForms.PieChart pieChart_Revenue;
        private MaterialSkin.Controls.MaterialLabel lbl_Quantity;
        private MaterialSkin.Controls.MaterialLabel lbl_Profit;
        private MaterialSkin.Controls.MaterialButton btn_Load;
        private LiveCharts.WinForms.CartesianChart chart_RevenueOfYear;
        private LiveCharts.WinForms.PieChart pieChart_CarDistributionByType;
        private MaterialSkin.Controls.MaterialLabel lbl_CarType;
        private System.Windows.Forms.DateTimePicker dtpk_Year;
        private MaterialSkin.Controls.MaterialButton btn_LoadRevenueByYear;
    }
}