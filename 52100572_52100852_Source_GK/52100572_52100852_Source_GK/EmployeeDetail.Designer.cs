namespace _52100572_52100852_Source_GK
{
    partial class EmployeeDetail
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
            this.lbl_Username = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Username = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbl_Role = new MaterialSkin.Controls.MaterialLabel();
            this.cbb_Role = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_Delete = new MaterialSkin.Controls.MaterialButton();
            this.btn_Edit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Cancel = new MaterialSkin.Controls.MaterialButton();
            this.btn_Save = new MaterialSkin.Controls.MaterialButton();
            this.lbl_Password = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.Depth = 0;
            this.lbl_Username.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Username.Location = new System.Drawing.Point(24, 88);
            this.lbl_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(80, 48);
            this.lbl_Username.TabIndex = 33;
            this.lbl_Username.Text = "Username";
            this.lbl_Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Username.AnimateReadOnly = false;
            this.txt_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Username.HideSelection = true;
            this.txt_Username.LeadingIcon = null;
            this.txt_Username.Location = new System.Drawing.Point(132, 88);
            this.txt_Username.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PrefixSuffixText = null;
            this.txt_Username.ReadOnly = false;
            this.txt_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.ShortcutsEnabled = true;
            this.txt_Username.Size = new System.Drawing.Size(300, 48);
            this.txt_Username.TabIndex = 35;
            this.txt_Username.TabStop = false;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Username.TrailingIcon = null;
            this.txt_Username.UseSystemPasswordChar = false;
            // 
            // lbl_Role
            // 
            this.lbl_Role.Depth = 0;
            this.lbl_Role.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Role.Location = new System.Drawing.Point(24, 150);
            this.lbl_Role.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Role.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(80, 48);
            this.lbl_Role.TabIndex = 36;
            this.lbl_Role.Text = "Role";
            this.lbl_Role.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbb_Role
            // 
            this.cbb_Role.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Role.AutoResize = false;
            this.cbb_Role.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbb_Role.Depth = 0;
            this.cbb_Role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_Role.DropDownHeight = 174;
            this.cbb_Role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Role.DropDownWidth = 121;
            this.cbb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbb_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbb_Role.FormattingEnabled = true;
            this.cbb_Role.IntegralHeight = false;
            this.cbb_Role.ItemHeight = 43;
            this.cbb_Role.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.cbb_Role.Location = new System.Drawing.Point(132, 150);
            this.cbb_Role.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_Role.MaxDropDownItems = 4;
            this.cbb_Role.MouseState = MaterialSkin.MouseState.OUT;
            this.cbb_Role.Name = "cbb_Role";
            this.cbb_Role.Size = new System.Drawing.Size(300, 49);
            this.cbb_Role.StartIndex = 0;
            this.cbb_Role.TabIndex = 37;
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
            this.btn_Delete.Location = new System.Drawing.Point(24, 326);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Delete.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Delete.Size = new System.Drawing.Size(100, 40);
            this.btn_Delete.TabIndex = 41;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Delete.UseAccentColor = false;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
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
            this.btn_Edit.Location = new System.Drawing.Point(332, 326);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Edit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Edit.Size = new System.Drawing.Size(100, 40);
            this.btn_Edit.TabIndex = 40;
            this.btn_Edit.Text = "Chỉnh sửa";
            this.btn_Edit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Edit.UseAccentColor = false;
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
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
            this.btn_Cancel.Location = new System.Drawing.Point(24, 326);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Cancel.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Cancel.Size = new System.Drawing.Size(100, 40);
            this.btn_Cancel.TabIndex = 39;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Cancel.UseAccentColor = false;
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
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
            this.btn_Save.Location = new System.Drawing.Point(332, 326);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Save.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Save.Size = new System.Drawing.Size(100, 40);
            this.btn_Save.TabIndex = 38;
            this.btn_Save.Text = "Lưu lại";
            this.btn_Save.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Save.UseAccentColor = false;
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.Depth = 0;
            this.lbl_Password.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Password.Location = new System.Drawing.Point(24, 213);
            this.lbl_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(80, 48);
            this.lbl_Password.TabIndex = 42;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.AnimateReadOnly = false;
            this.txt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Password.Depth = 0;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.HideSelection = true;
            this.txt_Password.LeadingIcon = null;
            this.txt_Password.Location = new System.Drawing.Point(132, 213);
            this.txt_Password.Margin = new System.Windows.Forms.Padding(2);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '●';
            this.txt_Password.PrefixSuffixText = null;
            this.txt_Password.ReadOnly = false;
            this.txt_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.ShortcutsEnabled = true;
            this.txt_Password.Size = new System.Drawing.Size(300, 48);
            this.txt_Password.TabIndex = 43;
            this.txt_Password.TabStop = false;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.TrailingIcon = null;
            this.txt_Password.UseSystemPasswordChar = false;
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 390);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.cbb_Role);
            this.Controls.Add(this.lbl_Role);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.MinimumSize = new System.Drawing.Size(456, 390);
            this.Name = "EmployeeDetail";
            this.Text = "EmployeeDetail";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Username;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Username;
        private MaterialSkin.Controls.MaterialLabel lbl_Role;
        private MaterialSkin.Controls.MaterialComboBox cbb_Role;
        private MaterialSkin.Controls.MaterialButton btn_Delete;
        private MaterialSkin.Controls.MaterialButton btn_Edit;
        private MaterialSkin.Controls.MaterialButton btn_Cancel;
        private MaterialSkin.Controls.MaterialButton btn_Save;
        private MaterialSkin.Controls.MaterialLabel lbl_Password;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Password;
    }
}