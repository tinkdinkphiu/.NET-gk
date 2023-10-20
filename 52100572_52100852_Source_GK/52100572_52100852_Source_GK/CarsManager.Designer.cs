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
            this.SuspendLayout();
            // 
            // lbl_carsManager
            // 
            this.lbl_carsManager.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_carsManager.Depth = 0;
            this.lbl_carsManager.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.lbl_carsManager.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.lbl_carsManager.Location = new System.Drawing.Point(12, 16);
            this.lbl_carsManager.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_carsManager.Name = "lbl_carsManager";
            this.lbl_carsManager.Size = new System.Drawing.Size(818, 29);
            this.lbl_carsManager.TabIndex = 0;
            this.lbl_carsManager.Text = "Quản lý xe";
            this.lbl_carsManager.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CarsManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 495);
            this.Controls.Add(this.lbl_carsManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CarsManager";
            this.Text = "CarsManager";
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_carsManager;
    }
}