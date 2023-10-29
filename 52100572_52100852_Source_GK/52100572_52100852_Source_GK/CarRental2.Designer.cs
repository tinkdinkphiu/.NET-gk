namespace _52100572_52100852_Source_GK
{
    partial class CarRental2
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
            this.lbl_ChooseCar = new MaterialSkin.Controls.MaterialLabel();
            this.btn_back = new MaterialSkin.Controls.MaterialButton();
            this.lv_CarList = new MaterialSkin.Controls.MaterialListView();
            this.SuspendLayout();
            // 
            // lbl_ChooseCar
            // 
            this.lbl_ChooseCar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ChooseCar.Depth = 0;
            this.lbl_ChooseCar.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_ChooseCar.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_ChooseCar.Location = new System.Drawing.Point(0, 0);
            this.lbl_ChooseCar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_ChooseCar.Name = "lbl_ChooseCar";
            this.lbl_ChooseCar.Size = new System.Drawing.Size(800, 60);
            this.lbl_ChooseCar.TabIndex = 1;
            this.lbl_ChooseCar.Text = "Chọn xe";
            this.lbl_ChooseCar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_back.AutoSize = false;
            this.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_back.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_back.Depth = 0;
            this.btn_back.HighEmphasis = true;
            this.btn_back.Icon = null;
            this.btn_back.Location = new System.Drawing.Point(24, 440);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_back.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_back.Name = "btn_back";
            this.btn_back.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_back.Size = new System.Drawing.Size(100, 36);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Trở lại";
            this.btn_back.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_back.UseAccentColor = false;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lv_CarList
            // 
            this.lv_CarList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_CarList.AutoSizeTable = false;
            this.lv_CarList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lv_CarList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lv_CarList.Depth = 0;
            this.lv_CarList.FullRowSelect = true;
            this.lv_CarList.HideSelection = false;
            this.lv_CarList.Location = new System.Drawing.Point(24, 69);
            this.lv_CarList.MinimumSize = new System.Drawing.Size(200, 100);
            this.lv_CarList.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lv_CarList.MouseState = MaterialSkin.MouseState.OUT;
            this.lv_CarList.Name = "lv_CarList";
            this.lv_CarList.OwnerDraw = true;
            this.lv_CarList.Size = new System.Drawing.Size(752, 350);
            this.lv_CarList.TabIndex = 3;
            this.lv_CarList.UseCompatibleStateImageBehavior = false;
            this.lv_CarList.View = System.Windows.Forms.View.Details;
            this.lv_CarList.SelectedIndexChanged += new System.EventHandler(this.lv_CarList_SelectedIndexChanged);
            // 
            // CarRental2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 504);
            this.Controls.Add(this.lv_CarList);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_ChooseCar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(800, 504);
            this.Name = "CarRental2";
            this.Text = "CarRental2";
            this.Load += new System.EventHandler(this.CarRental2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_ChooseCar;
        private MaterialSkin.Controls.MaterialButton btn_back;
        private MaterialSkin.Controls.MaterialListView lv_CarList;
    }
}