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
            this.lbl_username = new MaterialSkin.Controls.MaterialLabel();
            this.input_username = new MaterialSkin.Controls.MaterialTextBox2();
            this.lbl_password = new MaterialSkin.Controls.MaterialLabel();
            this.input_password = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Depth = 0;
            this.lbl_username.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_username.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_username.Location = new System.Drawing.Point(24, 88);
            this.lbl_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(134, 24);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Tên đăng nhập";
            // 
            // input_username
            // 
            this.input_username.AnimateReadOnly = false;
            this.input_username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.input_username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.input_username.Depth = 0;
            this.input_username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.input_username.HideSelection = true;
            this.input_username.Hint = "Vui lòng nhập tên đăng nhập";
            this.input_username.LeadingIcon = null;
            this.input_username.Location = new System.Drawing.Point(24, 120);
            this.input_username.MaxLength = 32767;
            this.input_username.MouseState = MaterialSkin.MouseState.OUT;
            this.input_username.Name = "input_username";
            this.input_username.PasswordChar = '\0';
            this.input_username.PrefixSuffixText = null;
            this.input_username.ReadOnly = false;
            this.input_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_username.SelectedText = "";
            this.input_username.SelectionLength = 0;
            this.input_username.SelectionStart = 0;
            this.input_username.ShortcutsEnabled = true;
            this.input_username.Size = new System.Drawing.Size(328, 48);
            this.input_username.TabIndex = 1;
            this.input_username.TabStop = false;
            this.input_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.input_username.TrailingIcon = null;
            this.input_username.UseSystemPasswordChar = false;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Depth = 0;
            this.lbl_password.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_password.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.lbl_password.Location = new System.Drawing.Point(24, 200);
            this.lbl_password.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(85, 24);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // input_password
            // 
            this.input_password.AnimateReadOnly = false;
            this.input_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.input_password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.input_password.Depth = 0;
            this.input_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.input_password.HideSelection = true;
            this.input_password.Hint = "Vui lòng nhập mật khẩu";
            this.input_password.LeadingIcon = null;
            this.input_password.Location = new System.Drawing.Point(24, 232);
            this.input_password.MaxLength = 32767;
            this.input_password.MouseState = MaterialSkin.MouseState.OUT;
            this.input_password.Name = "input_password";
            this.input_password.PasswordChar = '●';
            this.input_password.PrefixSuffixText = null;
            this.input_password.ReadOnly = false;
            this.input_password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.input_password.SelectedText = "";
            this.input_password.SelectionLength = 0;
            this.input_password.SelectionStart = 0;
            this.input_password.ShortcutsEnabled = true;
            this.input_password.Size = new System.Drawing.Size(328, 48);
            this.input_password.TabIndex = 3;
            this.input_password.TabStop = false;
            this.input_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.input_password.TrailingIcon = null;
            this.input_password.UseSystemPasswordChar = true;
            this.input_password.Click += new System.EventHandler(this.input_password_Click);
            // 
            // btn_login
            // 
            this.btn_login.AutoSize = false;
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_login.Depth = 0;
            this.btn_login.HighEmphasis = true;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(24, 332);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_login.Size = new System.Drawing.Size(328, 48);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 404);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.input_password);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.input_username);
            this.Controls.Add(this.lbl_username);
            this.Name = "Login";
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_username;
        private MaterialSkin.Controls.MaterialTextBox2 input_username;
        private MaterialSkin.Controls.MaterialLabel lbl_password;
        private MaterialSkin.Controls.MaterialTextBox2 input_password;
        private MaterialSkin.Controls.MaterialButton btn_login;
    }
}