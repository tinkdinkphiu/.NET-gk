using System.Drawing;

namespace _52100572_52100852_Source_GK
{
    partial class Login
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
            this.lbl_Password = new MaterialSkin.Controls.MaterialLabel();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Login = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Depth = 0;
            this.lbl_Username.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Username.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Username.Location = new System.Drawing.Point(24, 88);
            this.lbl_Username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(134, 24);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Tên đăng nhập";
            // 
            // txt_Username
            // 
            this.txt_Username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Username.AnimateReadOnly = false;
            this.txt_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Username.HideSelection = true;
            this.txt_Username.Hint = "Vui lòng nhập tên đăng nhập";
            this.txt_Username.LeadingIcon = null;
            this.txt_Username.Location = new System.Drawing.Point(24, 120);
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
            this.txt_Username.Size = new System.Drawing.Size(328, 48);
            this.txt_Username.TabIndex = 1;
            this.txt_Username.TabStop = false;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Username.TrailingIcon = null;
            this.txt_Username.UseSystemPasswordChar = false;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Depth = 0;
            this.lbl_Password.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_Password.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_Password.Location = new System.Drawing.Point(24, 200);
            this.lbl_Password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(85, 24);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Mật khẩu";
            // 
            // txt_Password
            // 
            this.txt_Password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Password.AnimateReadOnly = false;
            this.txt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Password.Depth = 0;
            this.txt_Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.HideSelection = true;
            this.txt_Password.Hint = "Vui lòng nhập mật khẩu";
            this.txt_Password.LeadingIcon = null;
            this.txt_Password.Location = new System.Drawing.Point(24, 232);
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
            this.txt_Password.Size = new System.Drawing.Size(328, 48);
            this.txt_Password.TabIndex = 3;
            this.txt_Password.TabStop = false;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.TrailingIcon = null;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Login.AutoSize = false;
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Login.Depth = 0;
            this.btn_Login.HighEmphasis = true;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(24, 332);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Login.Size = new System.Drawing.Size(328, 48);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Login.UseAccentColor = false;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 404);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Username);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Username;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Username;
        private MaterialSkin.Controls.MaterialLabel lbl_Password;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Password;
        private MaterialSkin.Controls.MaterialButton btn_Login;
    }
}