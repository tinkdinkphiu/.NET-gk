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
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpk_KetThuc = new System.Windows.Forms.DateTimePicker();
            this.pieChart_Quantity = new LiveCharts.WinForms.PieChart();
            this.pieChart_Revenue = new LiveCharts.WinForms.PieChart();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.btn_Load = new MaterialSkin.Controls.MaterialButton();
            this.chart_RevenueOfYear = new LiveCharts.WinForms.CartesianChart();
            this.pieChart_CarDistributionByType = new LiveCharts.WinForms.PieChart();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpk_Year = new System.Windows.Forms.DateTimePicker();
            this.btn_LoadRevenueByYear = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lv_Revenue
            // 
            this.lv_Revenue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Revenue.AutoSizeTable = false;
            this.lv_Revenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_Revenue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Revenue.Depth = 0;
            this.lv_Revenue.FullRowSelect = true;
            this.lv_Revenue.HideSelection = false;
            this.lv_Revenue.Location = new System.Drawing.Point(32, 165);
            this.lv_Revenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_Revenue.MinimumSize = new System.Drawing.Size(267, 123);
            this.lv_Revenue.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_Revenue.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_Revenue.Name = "lv_Revenue";
            this.lv_Revenue.OwnerDraw = true;
            this.lv_Revenue.Size = new System.Drawing.Size(337, 127);
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
            this.lbl_Schedule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Schedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Schedule.Name = "lbl_Schedule";
            this.lbl_Schedule.Size = new System.Drawing.Size(1133, 74);
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
            this.cbb_RevenueBy.Location = new System.Drawing.Point(41, 99);
            this.cbb_RevenueBy.MaxDropDownItems = 4;
            this.cbb_RevenueBy.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_RevenueBy.Name = "cbb_RevenueBy";
            this.cbb_RevenueBy.Size = new System.Drawing.Size(202, 49);
            this.cbb_RevenueBy.StartIndex = 0;
            this.cbb_RevenueBy.TabIndex = 10;
            // 
            // dtpk_BatDau
            // 
            this.dtpk_BatDau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpk_BatDau.CustomFormat = "dd/MM/yyyy";
            this.dtpk_BatDau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_BatDau.Location = new System.Drawing.Point(379, 100);
            this.dtpk_BatDau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_BatDau.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpk_BatDau.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpk_BatDau.MinimumSize = new System.Drawing.Size(265, 48);
            this.dtpk_BatDau.Name = "dtpk_BatDau";
            this.dtpk_BatDau.Size = new System.Drawing.Size(265, 48);
            this.dtpk_BatDau.TabIndex = 50;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.Location = new System.Drawing.Point(301, 97);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(58, 59);
            this.lbl_ID.TabIndex = 51;
            this.lbl_ID.Text = "Từ ngày";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(662, 97);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(72, 59);
            this.materialLabel1.TabIndex = 53;
            this.materialLabel1.Text = "Đến ngày";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpk_KetThuc
            // 
            this.dtpk_KetThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpk_KetThuc.CustomFormat = "dd/MM/yyyy";
            this.dtpk_KetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_KetThuc.Location = new System.Drawing.Point(740, 100);
            this.dtpk_KetThuc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_KetThuc.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpk_KetThuc.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpk_KetThuc.MinimumSize = new System.Drawing.Size(265, 48);
            this.dtpk_KetThuc.Name = "dtpk_KetThuc";
            this.dtpk_KetThuc.Size = new System.Drawing.Size(265, 48);
            this.dtpk_KetThuc.TabIndex = 52;
            // 
            // pieChart_Quantity
            // 
            this.pieChart_Quantity.Location = new System.Drawing.Point(493, 165);
            this.pieChart_Quantity.Name = "pieChart_Quantity";
            this.pieChart_Quantity.Size = new System.Drawing.Size(280, 169);
            this.pieChart_Quantity.TabIndex = 54;
            this.pieChart_Quantity.Text = "pieChart1";
            // 
            // pieChart_Revenue
            // 
            this.pieChart_Revenue.Location = new System.Drawing.Point(779, 153);
            this.pieChart_Revenue.Name = "pieChart_Revenue";
            this.pieChart_Revenue.Size = new System.Drawing.Size(280, 169);
            this.pieChart_Revenue.TabIndex = 55;
            this.pieChart_Revenue.Text = "pieChart1";
            // 
            // materialLabel2
            // 
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(728, 210);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(72, 59);
            this.materialLabel2.TabIndex = 56;
            this.materialLabel2.Text = "Số lượng";
            this.materialLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(1021, 221);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(83, 59);
            this.materialLabel3.TabIndex = 57;
            this.materialLabel3.Text = "Doanh Thu";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_Load
            // 
            this.btn_Load.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Load.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Load.Depth = 0;
            this.btn_Load.HighEmphasis = true;
            this.btn_Load.Icon = null;
            this.btn_Load.Location = new System.Drawing.Point(1040, 108);
            this.btn_Load.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Load.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Load.Size = new System.Drawing.Size(64, 36);
            this.btn_Load.TabIndex = 58;
            this.btn_Load.Text = "Load";
            this.btn_Load.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Load.UseAccentColor = false;
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // chart_RevenueOfYear
            // 
            this.chart_RevenueOfYear.Location = new System.Drawing.Point(29, 358);
            this.chart_RevenueOfYear.Name = "chart_RevenueOfYear";
            this.chart_RevenueOfYear.Size = new System.Drawing.Size(802, 245);
            this.chart_RevenueOfYear.TabIndex = 59;
            this.chart_RevenueOfYear.Text = "cartesianChart1";
            // 
            // pieChart_CarDistributionByType
            // 
            this.pieChart_CarDistributionByType.Location = new System.Drawing.Point(837, 415);
            this.pieChart_CarDistributionByType.Name = "pieChart_CarDistributionByType";
            this.pieChart_CarDistributionByType.Size = new System.Drawing.Size(316, 160);
            this.pieChart_CarDistributionByType.TabIndex = 60;
            this.pieChart_CarDistributionByType.Text = "pieChart1";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(919, 340);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(165, 59);
            this.materialLabel4.TabIndex = 61;
            this.materialLabel4.Text = "Phân Bố Xe Theo Loại";
            this.materialLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpk_Year
            // 
            this.dtpk_Year.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpk_Year.CustomFormat = "yyyy";
            this.dtpk_Year.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk_Year.Location = new System.Drawing.Point(29, 305);
            this.dtpk_Year.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpk_Year.MaxDate = new System.DateTime(2300, 12, 31, 0, 0, 0, 0);
            this.dtpk_Year.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dtpk_Year.MinimumSize = new System.Drawing.Size(265, 48);
            this.dtpk_Year.Name = "dtpk_Year";
            this.dtpk_Year.Size = new System.Drawing.Size(265, 48);
            this.dtpk_Year.TabIndex = 62;
            // 
            // btn_LoadRevenueByYear
            // 
            this.btn_LoadRevenueByYear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_LoadRevenueByYear.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_LoadRevenueByYear.Depth = 0;
            this.btn_LoadRevenueByYear.HighEmphasis = true;
            this.btn_LoadRevenueByYear.Icon = null;
            this.btn_LoadRevenueByYear.Location = new System.Drawing.Point(333, 313);
            this.btn_LoadRevenueByYear.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_LoadRevenueByYear.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_LoadRevenueByYear.Name = "btn_LoadRevenueByYear";
            this.btn_LoadRevenueByYear.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_LoadRevenueByYear.Size = new System.Drawing.Size(64, 36);
            this.btn_LoadRevenueByYear.TabIndex = 63;
            this.btn_LoadRevenueByYear.Text = "Load";
            this.btn_LoadRevenueByYear.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_LoadRevenueByYear.UseAccentColor = false;
            this.btn_LoadRevenueByYear.UseVisualStyleBackColor = true;
            this.btn_LoadRevenueByYear.Click += new System.EventHandler(this.btn_LoadRevenueByYear_Click);
            // 
            // Revenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 615);
            this.Controls.Add(this.btn_LoadRevenueByYear);
            this.Controls.Add(this.dtpk_Year);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.pieChart_CarDistributionByType);
            this.Controls.Add(this.chart_RevenueOfYear);
            this.Controls.Add(this.btn_Load);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.pieChart_Revenue);
            this.Controls.Add(this.pieChart_Quantity);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.dtpk_KetThuc);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.dtpk_BatDau);
            this.Controls.Add(this.cbb_RevenueBy);
            this.Controls.Add(this.lv_Revenue);
            this.Controls.Add(this.lbl_Schedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1133, 615);
            this.Name = "Revenue";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Revenue_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialListView lv_Revenue;
        private MaterialSkin.Controls.MaterialLabel lbl_Schedule;
        private MaterialSkin.Controls.MaterialComboBox cbb_RevenueBy;
        private System.Windows.Forms.DateTimePicker dtpk_BatDau;
        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.DateTimePicker dtpk_KetThuc;
        private LiveCharts.WinForms.PieChart pieChart_Quantity;
        private LiveCharts.WinForms.PieChart pieChart_Revenue;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton btn_Load;
        private LiveCharts.WinForms.CartesianChart chart_RevenueOfYear;
        private LiveCharts.WinForms.PieChart pieChart_CarDistributionByType;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.DateTimePicker dtpk_Year;
        private MaterialSkin.Controls.MaterialButton btn_LoadRevenueByYear;
    }
}