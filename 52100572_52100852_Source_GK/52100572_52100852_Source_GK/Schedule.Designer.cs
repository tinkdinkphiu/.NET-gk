﻿namespace _52100572_52100852_Source_GK
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
            this.lbl_Schedule.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_Schedule.Name = "lbl_Schedule";
            this.lbl_Schedule.Size = new System.Drawing.Size(790, 60);
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
            this.lv_Schedule.Location = new System.Drawing.Point(24, 134);
            this.lv_Schedule.Margin = new System.Windows.Forms.Padding(2);
            this.lv_Schedule.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv_Schedule.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_Schedule.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_Schedule.Name = "lv_Schedule";
            this.lv_Schedule.OwnerDraw = true;
            this.lv_Schedule.Size = new System.Drawing.Size(742, 342);
            this.lv_Schedule.TabIndex = 9;
            this.lv_Schedule.UseCompatibleStateImageBehavior = false;
            this.lv_Schedule.View = System.Windows.Forms.View.Details;
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
            this.btn_Search.Location = new System.Drawing.Point(240, 65);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btn_Search.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Search.Size = new System.Drawing.Size(100, 40);
            this.btn_Search.TabIndex = 11;
            this.btn_Search.Text = "Tìm kiếm";
            this.btn_Search.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Search.UseAccentColor = false;
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 500);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.txt_Search);
            this.Controls.Add(this.lv_Schedule);
            this.Controls.Add(this.lbl_Schedule);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_Schedule;
        private MaterialSkin.Controls.MaterialListView lv_Schedule;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Search;
        private MaterialSkin.Controls.MaterialButton btn_Search;
    }
}