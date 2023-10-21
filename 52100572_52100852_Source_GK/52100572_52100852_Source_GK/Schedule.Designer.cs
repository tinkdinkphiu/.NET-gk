namespace _52100572_52100852_Source_GK
{
    partial class Schedule
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
            this.lbl_Schedule = new MaterialSkin.Controls.MaterialLabel();
            this.lv_Schedule = new MaterialSkin.Controls.MaterialListView();
            this.txt_Search = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Search = new MaterialSkin.Controls.MaterialButton();
            this.btn_Refresh = new MaterialSkin.Controls.MaterialButton();
            this.btn_CheckCar = new MaterialSkin.Controls.MaterialButton();
            this.txt_XeOToID = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
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
            this.lbl_Schedule.Size = new System.Drawing.Size(1053, 74);
            this.lbl_Schedule.TabIndex = 8;
            this.lbl_Schedule.Text = "Lịch trình";
            this.lbl_Schedule.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lv_Schedule
            // 
            this.lv_Schedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_Schedule.AutoSizeTable = false;
            this.lv_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_Schedule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_Schedule.Depth = 0;
            this.lv_Schedule.FullRowSelect = true;
            this.lv_Schedule.HideSelection = false;
            this.lv_Schedule.Location = new System.Drawing.Point(32, 165);
            this.lv_Schedule.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lv_Schedule.MinimumSize = new System.Drawing.Size(267, 123);
            this.lv_Schedule.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_Schedule.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_Schedule.Name = "lv_Schedule";
            this.lv_Schedule.OwnerDraw = true;
            this.lv_Schedule.Size = new System.Drawing.Size(989, 421);
            this.lv_Schedule.TabIndex = 9;
            this.lv_Schedule.UseCompatibleStateImageBehavior = false;
            this.lv_Schedule.View = System.Windows.Forms.View.Details;
            this.lv_Schedule.SelectedIndexChanged += new System.EventHandler(this.lv_Schedule_SelectedIndexChanged);
            // 
            // txt_Search
            // 
            this.txt_Search.AnimateReadOnly = false;
            this.txt_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Search.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Search.Depth = 0;
            this.txt_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Search.HideSelection = true;
            this.txt_Search.Hint = "Nhập từ khóa tìm kiếm";
            this.txt_Search.LeadingIcon = null;
            this.txt_Search.Location = new System.Drawing.Point(32, 76);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Search.MaxLength = 32767;
            this.txt_Search.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.PasswordChar = '\0';
            this.txt_Search.PrefixSuffixText = null;
            this.txt_Search.ReadOnly = false;
            this.txt_Search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Search.SelectedText = "";
            this.txt_Search.SelectionLength = 0;
            this.txt_Search.SelectionStart = 0;
            this.txt_Search.ShortcutsEnabled = true;
            this.txt_Search.Size = new System.Drawing.Size(267, 48);
            this.txt_Search.TabIndex = 10;
            this.txt_Search.TabStop = false;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.TrailingIcon = null;
            this.txt_Search.UseSystemPasswordChar = false;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSize = false;
            this.btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Search.Depth = 0;
            this.btn_Search.HighEmphasis = true;
            this.btn_Search.Icon = null;
            this.btn_Search.Location = new System.Drawing.Point(320, 80);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Search.Size = new System.Drawing.Size(133, 49);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Search.UseAccentColor = false;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AutoSize = false;
            this.btn_Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Refresh.Depth = 0;
            this.btn_Refresh.HighEmphasis = true;
            this.btn_Refresh.Icon = null;
            this.btn_Refresh.Location = new System.Drawing.Point(509, 80);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Refresh.Size = new System.Drawing.Size(133, 49);
            this.btn_Refresh.TabIndex = 12;
            this.btn_Refresh.Text = "Làm Mới";
            this.btn_Refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Refresh.UseAccentColor = false;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_CheckCar
            // 
            this.btn_CheckCar.AutoSize = false;
            this.btn_CheckCar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_CheckCar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_CheckCar.Depth = 0;
            this.btn_CheckCar.HighEmphasis = true;
            this.btn_CheckCar.Icon = null;
            this.btn_CheckCar.Location = new System.Drawing.Point(888, 80);
            this.btn_CheckCar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_CheckCar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_CheckCar.Name = "btn_CheckCar";
            this.btn_CheckCar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_CheckCar.Size = new System.Drawing.Size(133, 49);
            this.btn_CheckCar.TabIndex = 13;
            this.btn_CheckCar.Text = "Kiểm tra";
            this.btn_CheckCar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_CheckCar.UseAccentColor = false;
            this.btn_CheckCar.UseVisualStyleBackColor = true;
            this.btn_CheckCar.Click += new System.EventHandler(this.btn_CheckCar_Click);
            // 
            // txt_XeOToID
            // 
            this.txt_XeOToID.AnimateReadOnly = false;
            this.txt_XeOToID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_XeOToID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_XeOToID.Depth = 0;
            this.txt_XeOToID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_XeOToID.HideSelection = true;
            this.txt_XeOToID.Hint = "Nhập mã xe";
            this.txt_XeOToID.LeadingIcon = null;
            this.txt_XeOToID.Location = new System.Drawing.Point(699, 81);
            this.txt_XeOToID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_XeOToID.MaxLength = 32767;
            this.txt_XeOToID.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_XeOToID.Name = "txt_XeOToID";
            this.txt_XeOToID.PasswordChar = '\0';
            this.txt_XeOToID.PrefixSuffixText = null;
            this.txt_XeOToID.ReadOnly = false;
            this.txt_XeOToID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_XeOToID.SelectedText = "";
            this.txt_XeOToID.SelectionLength = 0;
            this.txt_XeOToID.SelectionStart = 0;
            this.txt_XeOToID.ShortcutsEnabled = true;
            this.txt_XeOToID.Size = new System.Drawing.Size(172, 48);
            this.txt_XeOToID.TabIndex = 14;
            this.txt_XeOToID.TabStop = false;
            this.txt_XeOToID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_XeOToID.TrailingIcon = null;
            this.txt_XeOToID.UseSystemPasswordChar = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 615);
            this.Controls.Add(this.txt_XeOToID);
            this.Controls.Add(this.btn_CheckCar);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lv_Schedule);
            this.Controls.Add(this.lbl_Schedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.Load += new System.EventHandler(this.Schedule_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Schedule;
        private MaterialSkin.Controls.MaterialListView lv_Schedule;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Search;
        private MaterialSkin.Controls.MaterialButton btn_Search;
        private MaterialSkin.Controls.MaterialButton btn_Refresh;
        private MaterialSkin.Controls.MaterialButton btn_CheckCar;
        private MaterialSkin.Controls.MaterialTextBox2 txt_XeOToID;
    }
}