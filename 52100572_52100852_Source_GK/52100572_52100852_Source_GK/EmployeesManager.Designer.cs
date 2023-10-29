namespace _52100572_52100852_Source_GK
{
    partial class EmployeesManager
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
            this.lbl_EmployeesManager = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Search = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Search = new MaterialSkin.Controls.MaterialButton();
            this.btn_Add = new MaterialSkin.Controls.MaterialButton();
            this.lv_EmployeeManager = new MaterialSkin.Controls.MaterialListView();
            this.btn_Refresh = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_EmployeesManager
            // 
            this.lbl_EmployeesManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_EmployeesManager.Depth = 0;
            this.lbl_EmployeesManager.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_EmployeesManager.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_EmployeesManager.Location = new System.Drawing.Point(0, 0);
            this.lbl_EmployeesManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_EmployeesManager.Name = "lbl_EmployeesManager";
            this.lbl_EmployeesManager.Size = new System.Drawing.Size(790, 60);
            this.lbl_EmployeesManager.TabIndex = 8;
            this.lbl_EmployeesManager.Text = "Quản lý nhân viên";
            this.lbl_EmployeesManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txt_Search.Location = new System.Drawing.Point(24, 62);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(2);
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
            this.txt_Search.Size = new System.Drawing.Size(200, 48);
            this.txt_Search.TabIndex = 9;
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
            this.btn_Search.Location = new System.Drawing.Point(239, 62);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Search.Size = new System.Drawing.Size(100, 40);
            this.btn_Search.TabIndex = 10;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Search.UseAccentColor = false;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Add.AutoSize = false;
            this.btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Add.Depth = 0;
            this.btn_Add.HighEmphasis = true;
            this.btn_Add.Icon = null;
            this.btn_Add.Location = new System.Drawing.Point(616, 62);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Add.Size = new System.Drawing.Size(150, 40);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Add.UseAccentColor = false;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lv_EmployeeManager
            // 
            this.lv_EmployeeManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_EmployeeManager.AutoSizeTable = false;
            this.lv_EmployeeManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_EmployeeManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_EmployeeManager.Depth = 0;
            this.lv_EmployeeManager.FullRowSelect = true;
            this.lv_EmployeeManager.HideSelection = false;
            this.lv_EmployeeManager.Location = new System.Drawing.Point(24, 134);
            this.lv_EmployeeManager.Margin = new System.Windows.Forms.Padding(2);
            this.lv_EmployeeManager.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv_EmployeeManager.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_EmployeeManager.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_EmployeeManager.Name = "lv_EmployeeManager";
            this.lv_EmployeeManager.OwnerDraw = true;
            this.lv_EmployeeManager.Size = new System.Drawing.Size(742, 342);
            this.lv_EmployeeManager.TabIndex = 12;
            this.lv_EmployeeManager.UseCompatibleStateImageBehavior = false;
            this.lv_EmployeeManager.View = System.Windows.Forms.View.Details;
            this.lv_EmployeeManager.SelectedIndexChanged += new System.EventHandler(this.lv_EmployeeManager_SelectedIndexChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AutoSize = false;
            this.btn_Refresh.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Refresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Refresh.Depth = 0;
            this.btn_Refresh.HighEmphasis = true;
            this.btn_Refresh.Icon = null;
            this.btn_Refresh.Location = new System.Drawing.Point(354, 62);
            this.btn_Refresh.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Refresh.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Refresh.Size = new System.Drawing.Size(100, 40);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Làm Mới";
            this.btn_Refresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Refresh.UseAccentColor = false;
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // EmployeesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.lv_EmployeeManager);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_EmployeesManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(790, 400);
            this.Name = "EmployeesManager";
            this.Text = "EmployeesManager";
            this.Load += new System.EventHandler(this.EmployeesManager_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_EmployeesManager;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Search;
        private MaterialSkin.Controls.MaterialButton btn_Search;
        private MaterialSkin.Controls.MaterialButton btn_Add;
        private MaterialSkin.Controls.MaterialListView lv_EmployeeManager;
        private MaterialSkin.Controls.MaterialButton btn_Refresh;
    }
}