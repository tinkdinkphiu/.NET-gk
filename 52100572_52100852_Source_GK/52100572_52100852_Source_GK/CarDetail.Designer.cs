using System.Drawing;

namespace _52100572_52100852_Source_GK
{
    partial class CarDetail
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
            this.lbl_ID = new MaterialSkin.Controls.MaterialLabel();
            this.txt_ID = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbl_HangXe = new MaterialSkin.Controls.MaterialLabel();
            this.cbb_HangXe = new MaterialSkin.Controls.MaterialComboBox();
            this.lbl_Model = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Model = new MaterialSkin.Controls.MaterialTextBox2();
            this.cbb_LoaiXe = new MaterialSkin.Controls.MaterialComboBox();
            this.lbl_LoaiXe = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_TrangThai = new MaterialSkin.Controls.MaterialLabel();
            this.cbb_TrangThai = new MaterialSkin.Controls.MaterialComboBox();
            this.lbl_GiaThue = new MaterialSkin.Controls.MaterialLabel();
            this.txt_GiaThue = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_Edit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Delete = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Depth = 0;
            this.lbl_ID.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ID.Location = new System.Drawing.Point(32, 88);
            this.lbl_ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ID.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(16, 19);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ID.AnimateReadOnly = false;
            this.txt_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_ID.Depth = 0;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_ID.HideSelection = true;
            this.txt_ID.LeadingIcon = null;
            this.txt_ID.Location = new System.Drawing.Point(24, 112);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(2);
            this.txt_ID.MaxLength = 32767;
            this.txt_ID.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.PasswordChar = '\0';
            this.txt_ID.PrefixSuffixText = null;
            this.txt_ID.ReadOnly = false;
            this.txt_ID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_ID.SelectedText = "";
            this.txt_ID.SelectionLength = 0;
            this.txt_ID.SelectionStart = 0;
            this.txt_ID.ShortcutsEnabled = true;
            this.txt_ID.Size = new System.Drawing.Size(300, 48);
            this.txt_ID.TabIndex = 1;
            this.txt_ID.TabStop = false;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ID.TrailingIcon = null;
            this.txt_ID.UseSystemPasswordChar = false;
            // 
            // lbl_HangXe
            // 
            this.lbl_HangXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_HangXe.AutoSize = true;
            this.lbl_HangXe.Depth = 0;
            this.lbl_HangXe.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_HangXe.Location = new System.Drawing.Point(32, 184);
            this.lbl_HangXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_HangXe.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_HangXe.Name = "lbl_HangXe";
            this.lbl_HangXe.Size = new System.Drawing.Size(59, 19);
            this.lbl_HangXe.TabIndex = 2;
            this.lbl_HangXe.Text = "Hãng xe";
            // 
            // cbb_HangXe
            // 
            this.cbb_HangXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_HangXe.AutoResize = false;
            this.cbb_HangXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_HangXe.Depth = 0;
            this.cbb_HangXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_HangXe.DropDownHeight = 174;
            this.cbb_HangXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_HangXe.DropDownWidth = 121;
            this.cbb_HangXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_HangXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_HangXe.FormattingEnabled = true;
            this.cbb_HangXe.IntegralHeight = false;
            this.cbb_HangXe.ItemHeight = 43;
            this.cbb_HangXe.Items.AddRange(new object[] {
            "Toyota",
            "Chevrolet",
            "Ford",
            "Honda",
            "Hyundai",
            "Isuzu",
            "Suzuki",
            "Kia",
            "Mitsubishi",
            "Lexus",
            "Mazda",
            "Nissan",
            "Subaru",
            "Ssangyong",
            "Land Rover"});
            this.cbb_HangXe.Location = new System.Drawing.Point(24, 208);
            this.cbb_HangXe.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_HangXe.MaxDropDownItems = 4;
            this.cbb_HangXe.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_HangXe.Name = "cbb_HangXe";
            this.cbb_HangXe.Size = new System.Drawing.Size(300, 49);
            this.cbb_HangXe.StartIndex = 0;
            this.cbb_HangXe.TabIndex = 3;
            // 
            // lbl_Model
            // 
            this.lbl_Model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Model.AutoSize = true;
            this.lbl_Model.Depth = 0;
            this.lbl_Model.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Model.Location = new System.Drawing.Point(32, 280);
            this.lbl_Model.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Model.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Model.Name = "lbl_Model";
            this.lbl_Model.Size = new System.Drawing.Size(45, 19);
            this.lbl_Model.TabIndex = 4;
            this.lbl_Model.Text = "Model";
            this.lbl_Model.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_Model
            // 
            this.txt_Model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Model.AnimateReadOnly = false;
            this.txt_Model.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Model.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Model.Depth = 0;
            this.txt_Model.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Model.HideSelection = true;
            this.txt_Model.LeadingIcon = null;
            this.txt_Model.Location = new System.Drawing.Point(24, 304);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Model.MaxLength = 32767;
            this.txt_Model.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.PasswordChar = '\0';
            this.txt_Model.PrefixSuffixText = null;
            this.txt_Model.ReadOnly = false;
            this.txt_Model.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Model.SelectedText = "";
            this.txt_Model.SelectionLength = 0;
            this.txt_Model.SelectionStart = 0;
            this.txt_Model.ShortcutsEnabled = true;
            this.txt_Model.Size = new System.Drawing.Size(300, 48);
            this.txt_Model.TabIndex = 5;
            this.txt_Model.TabStop = false;
            this.txt_Model.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Model.TrailingIcon = null;
            this.txt_Model.UseSystemPasswordChar = false;
            // 
            // cbb_LoaiXe
            // 
            this.cbb_LoaiXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_LoaiXe.AutoResize = false;
            this.cbb_LoaiXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_LoaiXe.Depth = 0;
            this.cbb_LoaiXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_LoaiXe.DropDownHeight = 174;
            this.cbb_LoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiXe.DropDownWidth = 121;
            this.cbb_LoaiXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_LoaiXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_LoaiXe.FormattingEnabled = true;
            this.cbb_LoaiXe.IntegralHeight = false;
            this.cbb_LoaiXe.ItemHeight = 43;
            this.cbb_LoaiXe.Items.AddRange(new object[] {
            "4 cho (Mini)",
            "4 cho (Sedan)",
            "4 cho (Hatchback)",
            "5 cho (CUV Gam cao)",
            "7 cho (SUV Gam cao)",
            "7 cho (MPV Gam thap)",
            "Ban tai"});
            this.cbb_LoaiXe.Location = new System.Drawing.Point(24, 400);
            this.cbb_LoaiXe.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_LoaiXe.MaxDropDownItems = 4;
            this.cbb_LoaiXe.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_LoaiXe.Name = "cbb_LoaiXe";
            this.cbb_LoaiXe.Size = new System.Drawing.Size(300, 49);
            this.cbb_LoaiXe.StartIndex = 0;
            this.cbb_LoaiXe.TabIndex = 6;
            // 
            // lbl_LoaiXe
            // 
            this.lbl_LoaiXe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LoaiXe.AutoSize = true;
            this.lbl_LoaiXe.Depth = 0;
            this.lbl_LoaiXe.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_LoaiXe.Location = new System.Drawing.Point(32, 376);
            this.lbl_LoaiXe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LoaiXe.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_LoaiXe.Name = "lbl_LoaiXe";
            this.lbl_LoaiXe.Size = new System.Drawing.Size(54, 19);
            this.lbl_LoaiXe.TabIndex = 7;
            this.lbl_LoaiXe.Text = "Loại Xe";
            // 
            // lbl_TrangThai
            // 
            this.lbl_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_TrangThai.AutoSize = true;
            this.lbl_TrangThai.Depth = 0;
            this.lbl_TrangThai.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_TrangThai.Location = new System.Drawing.Point(32, 472);
            this.lbl_TrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TrangThai.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_TrangThai.Name = "lbl_TrangThai";
            this.lbl_TrangThai.Size = new System.Drawing.Size(74, 19);
            this.lbl_TrangThai.TabIndex = 8;
            this.lbl_TrangThai.Text = "Trạng thái";
            this.lbl_TrangThai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_TrangThai.AutoResize = false;
            this.cbb_TrangThai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_TrangThai.Depth = 0;
            this.cbb_TrangThai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_TrangThai.DropDownHeight = 174;
            this.cbb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TrangThai.DropDownWidth = 121;
            this.cbb_TrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_TrangThai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.IntegralHeight = false;
            this.cbb_TrangThai.ItemHeight = 43;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "Sẵn sàng",
            "Đang cho thuê"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(24, 496);
            this.cbb_TrangThai.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_TrangThai.MaxDropDownItems = 4;
            this.cbb_TrangThai.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(300, 49);
            this.cbb_TrangThai.StartIndex = 0;
            this.cbb_TrangThai.TabIndex = 9;
            // 
            // lbl_GiaThue
            // 
            this.lbl_GiaThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GiaThue.AutoSize = true;
            this.lbl_GiaThue.Depth = 0;
            this.lbl_GiaThue.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_GiaThue.Location = new System.Drawing.Point(32, 566);
            this.lbl_GiaThue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_GiaThue.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_GiaThue.Name = "lbl_GiaThue";
            this.lbl_GiaThue.Size = new System.Drawing.Size(69, 19);
            this.lbl_GiaThue.TabIndex = 10;
            this.lbl_GiaThue.Text = "Giá Thuê:";
            // 
            // txt_GiaThue
            // 
            this.txt_GiaThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_GiaThue.AnimateReadOnly = false;
            this.txt_GiaThue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_GiaThue.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_GiaThue.Depth = 0;
            this.txt_GiaThue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_GiaThue.HideSelection = true;
            this.txt_GiaThue.LeadingIcon = null;
            this.txt_GiaThue.Location = new System.Drawing.Point(24, 590);
            this.txt_GiaThue.Margin = new System.Windows.Forms.Padding(2);
            this.txt_GiaThue.MaxLength = 32767;
            this.txt_GiaThue.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_GiaThue.Name = "txt_GiaThue";
            this.txt_GiaThue.PasswordChar = '\0';
            this.txt_GiaThue.PrefixSuffixText = null;
            this.txt_GiaThue.ReadOnly = false;
            this.txt_GiaThue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_GiaThue.SelectedText = "";
            this.txt_GiaThue.SelectionLength = 0;
            this.txt_GiaThue.SelectionStart = 0;
            this.txt_GiaThue.ShortcutsEnabled = true;
            this.txt_GiaThue.Size = new System.Drawing.Size(300, 48);
            this.txt_GiaThue.TabIndex = 11;
            this.txt_GiaThue.TabStop = false;
            this.txt_GiaThue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_GiaThue.TrailingIcon = null;
            this.txt_GiaThue.UseSystemPasswordChar = false;
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.AutoSize = false;
            this.btn_Save.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Save.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Save.Depth = 0;
            this.btn_Save.HighEmphasis = true;
            this.btn_Save.Icon = null;
            this.btn_Save.Location = new System.Drawing.Point(225, 686);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(100, 40);
            this.btn_Save.TabIndex = 15;
            this.btn_Save.Text = "Lưu lại";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Cancel.AutoSize = false;
            this.btn_Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Cancel.Depth = 0;
            this.btn_Cancel.HighEmphasis = true;
            this.btn_Cancel.Icon = null;
            this.btn_Cancel.Location = new System.Drawing.Point(24, 686);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_Cancel.TabIndex = 16;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Cancel.UseAccentColor = false;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Edit.AutoSize = false;
            this.btn_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Edit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Edit.Depth = 0;
            this.btn_Edit.HighEmphasis = true;
            this.btn_Edit.Icon = null;
            this.btn_Edit.Location = new System.Drawing.Point(225, 686);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Edit.Size = new System.Drawing.Size(100, 40);
            this.btn_Edit.TabIndex = 17;
            this.btn_Edit.Text = "Chỉnh sửa";
            this.btn_Edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Edit.UseAccentColor = false;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Delete.AutoSize = false;
            this.btn_Delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Delete.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Delete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Delete.Depth = 0;
            this.btn_Delete.HighEmphasis = true;
            this.btn_Delete.Icon = null;
            this.btn_Delete.Location = new System.Drawing.Point(24, 686);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Delete.Size = new System.Drawing.Size(100, 40);
            this.btn_Delete.TabIndex = 18;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Delete.UseAccentColor = false;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // CarDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 750);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_GiaThue);
            this.Controls.Add(this.lbl_GiaThue);
            this.Controls.Add(this.cbb_TrangThai);
            this.Controls.Add(this.lbl_TrangThai);
            this.Controls.Add(this.lbl_LoaiXe);
            this.Controls.Add(this.cbb_LoaiXe);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.lbl_Model);
            this.Controls.Add(this.cbb_HangXe);
            this.Controls.Add(this.lbl_HangXe);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(348, 750);
            this.Name = "CarDetail";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Text = "Chi Tiết Xe";
            this.Load += new System.EventHandler(this.CarDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_ID;
        private MaterialSkin.Controls.MaterialTextBox2 txt_ID;
        private MaterialSkin.Controls.MaterialLabel lbl_HangXe;
        private MaterialSkin.Controls.MaterialComboBox cbb_HangXe;
        private MaterialSkin.Controls.MaterialLabel lbl_Model;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Model;
        private MaterialSkin.Controls.MaterialComboBox cbb_LoaiXe;
        private MaterialSkin.Controls.MaterialLabel lbl_LoaiXe;
        private MaterialSkin.Controls.MaterialLabel lbl_TrangThai;
        private MaterialSkin.Controls.MaterialComboBox cbb_TrangThai;
        private MaterialSkin.Controls.MaterialLabel lbl_GiaThue;
        private MaterialSkin.Controls.MaterialTextBox2 txt_GiaThue;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private MaterialSkin.Controls.MaterialButton btn_Cancel;
        private MaterialSkin.Controls.MaterialButton btn_Edit;
        private MaterialSkin.Controls.MaterialButton btn_Delete;
    }
}