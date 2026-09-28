namespace QuanLyCaPhe
{
    partial class UC_TheSanPham
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picHinhAnh = new PictureBox();
            lblTenMon = new Label();
            lblGiaTien = new Label();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // picHinhAnh
            // 
            picHinhAnh.Location = new Point(3, 4);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(162, 116);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 0;
            picHinhAnh.TabStop = false;
            // 
            // lblTenMon
            // 
            lblTenMon.AutoSize = true;
            lblTenMon.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMon.ForeColor = Color.DarkSlateGray;
            lblTenMon.Location = new Point(4, 132);
            lblTenMon.Name = "lblTenMon";
            lblTenMon.Size = new Size(59, 23);
            lblTenMon.TabIndex = 1;
            lblTenMon.Text = "label1";
            // 
            // lblGiaTien
            // 
            lblGiaTien.AutoSize = true;
            lblGiaTien.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGiaTien.ForeColor = Color.DarkSlateGray;
            lblGiaTien.Location = new Point(5, 167);
            lblGiaTien.Name = "lblGiaTien";
            lblGiaTien.Size = new Size(50, 20);
            lblGiaTien.TabIndex = 2;
            lblGiaTien.Text = "label1";
            // 
            // UC_TheSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblGiaTien);
            Controls.Add(lblTenMon);
            Controls.Add(picHinhAnh);
            Name = "UC_TheSanPham";
            Size = new Size(170, 205);
            Load += UC_TheSanPham_Load;
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picHinhAnh;
        private Label lblTenMon;
        private Label lblGiaTien;
    }
}
