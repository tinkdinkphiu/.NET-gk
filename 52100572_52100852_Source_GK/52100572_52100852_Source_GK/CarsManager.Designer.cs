namespace _52100572_52100852_Source_GK
{
    partial class CarsManager
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
            this.lbl_carsManager = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Search = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Search = new MaterialSkin.Controls.MaterialButton();
            this.btn_Add = new MaterialSkin.Controls.MaterialButton();
            this.lv_CarsManager = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // lbl_carsManager
            // 
            this.lbl_carsManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_carsManager.Depth = 0;
            this.lbl_carsManager.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_carsManager.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_carsManager.Location = new System.Drawing.Point(16, 20);
            this.lbl_carsManager.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_carsManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_carsManager.Name = "lbl_carsManager";
            this.lbl_carsManager.Size = new System.Drawing.Size(1091, 36);
            this.lbl_carsManager.TabIndex = 0;
            this.lbl_carsManager.Text = "Quản lý xe";
            this.lbl_carsManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.txt_Search.Location = new System.Drawing.Point(15, 79);
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
            this.txt_Search.Size = new System.Drawing.Size(190, 48);
            this.txt_Search.TabIndex = 1;
            this.txt_Search.TabStop = false;
            this.txt_Search.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Search.TrailingIcon = null;
            this.txt_Search.UseSystemPasswordChar = false;
            // 
            // btn_Search
            // 
            this.btn_Search.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Search.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Search.Depth = 0;
            this.btn_Search.HighEmphasis = true;
            this.btn_Search.Icon = null;
            this.btn_Search.Location = new System.Drawing.Point(232, 82);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Search.Size = new System.Drawing.Size(86, 36);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Search.UseAccentColor = false;
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Add.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Add.Depth = 0;
            this.btn_Add.HighEmphasis = true;
            this.btn_Add.Icon = null;
            this.btn_Add.Location = new System.Drawing.Point(342, 82);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Add.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Add.Size = new System.Drawing.Size(93, 36);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Thêm mới";
            this.btn_Add.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Add.UseAccentColor = false;
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // lv_CarsManager
            // 
            this.lv_CarsManager.AutoSizeTable = false;
            this.lv_CarsManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_CarsManager.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_CarsManager.Depth = 0;
            this.lv_CarsManager.FullRowSelect = true;
            this.lv_CarsManager.HideSelection = false;
            this.lv_CarsManager.Location = new System.Drawing.Point(16, 144);
            this.lv_CarsManager.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv_CarsManager.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_CarsManager.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_CarsManager.Name = "lv_CarsManager";
            this.lv_CarsManager.OwnerDraw = true;
            this.lv_CarsManager.Size = new System.Drawing.Size(1090, 451);
            this.lv_CarsManager.TabIndex = 4;
            this.lv_CarsManager.UseCompatibleStateImageBehavior = false;
            this.lv_CarsManager.View = System.Windows.Forms.View.Details;
            this.lv_CarsManager.SelectedIndexChanged += new System.EventHandler(this.lv_CarsManager_SelectedIndexChanged);
            // 
            // CarsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 609);
            this.Controls.Add(this.lv_CarsManager);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lbl_carsManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CarsManager";
            this.Text = "CarsManager";
            this.Load += new System.EventHandler(this.CarsManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_carsManager;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Search;
        private MaterialSkin.Controls.MaterialButton btn_Search;
        private MaterialSkin.Controls.MaterialButton btn_Add;
        private MaterialSkin.Controls.MaterialListView lv_CarsManager;
    }
}