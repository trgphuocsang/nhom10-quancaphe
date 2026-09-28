namespace QuanLyCaPhe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlMenu = new Panel();
            pictureBox1 = new PictureBox();
            pnlFooter = new Panel();
            label2 = new Label();
            picFooterIcon = new PictureBox();
            label3 = new Label();
            btnHoaDon = new Button();
            btnThongKe = new Button();
            btnBanHang = new Button();
            btnBan = new Button();
            btnNhanVien = new Button();
            btnSanPham = new Button();
            btnDanhMuc = new Button();
            pnlHienthi = new Panel();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFooterIcon).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.DarkSlateGray;
            pnlMenu.Controls.Add(pictureBox1);
            pnlMenu.Controls.Add(pnlFooter);
            pnlMenu.Controls.Add(btnHoaDon);
            pnlMenu.Controls.Add(btnThongKe);
            pnlMenu.Controls.Add(btnBanHang);
            pnlMenu.Controls.Add(btnBan);
            pnlMenu.Controls.Add(btnNhanVien);
            pnlMenu.Controls.Add(btnSanPham);
            pnlMenu.Controls.Add(btnDanhMuc);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(230, 753);
            pnlMenu.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(9, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlFooter
            // 
            pnlFooter.Controls.Add(label2);
            pnlFooter.Controls.Add(picFooterIcon);
            pnlFooter.Controls.Add(label3);
            pnlFooter.Dock = DockStyle.Bottom;
            pnlFooter.Location = new Point(0, 655);
            pnlFooter.Name = "pnlFooter";
            pnlFooter.Size = new Size(230, 98);
            pnlFooter.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 16);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "sunday.cafe ";
            // 
            // picFooterIcon
            // 
            picFooterIcon.Image = (Image)resources.GetObject("picFooterIcon.Image");
            picFooterIcon.Location = new Point(9, 14);
            picFooterIcon.Name = "picFooterIcon";
            picFooterIcon.Size = new Size(37, 36);
            picFooterIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picFooterIcon.TabIndex = 0;
            picFooterIcon.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(49, 36);
            label3.Name = "label3";
            label3.Size = new Size(174, 17);
            label3.TabIndex = 2;
            label3.Text = "Phần mềm quản lý bán hàng";
            // 
            // btnHoaDon
            // 
            btnHoaDon.FlatAppearance.BorderSize = 0;
            btnHoaDon.FlatStyle = FlatStyle.Flat;
            btnHoaDon.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHoaDon.ForeColor = Color.White;
            btnHoaDon.Location = new Point(20, 410);
            btnHoaDon.Name = "btnHoaDon";
            btnHoaDon.Padding = new Padding(15, 0, 0, 0);
            btnHoaDon.Size = new Size(190, 45);
            btnHoaDon.TabIndex = 7;
            btnHoaDon.Text = "📄   Hóa đơn";
            btnHoaDon.TextAlign = ContentAlignment.MiddleLeft;
            btnHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnThongKe.ForeColor = Color.White;
            btnThongKe.Location = new Point(20, 360);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Padding = new Padding(15, 0, 0, 0);
            btnThongKe.Size = new Size(190, 45);
            btnThongKe.TabIndex = 6;
            btnThongKe.Text = "📈   Thống kê";
            btnThongKe.TextAlign = ContentAlignment.MiddleLeft;
            btnThongKe.UseVisualStyleBackColor = true;
            // 
            // btnBanHang
            // 
            btnBanHang.FlatAppearance.BorderSize = 0;
            btnBanHang.FlatStyle = FlatStyle.Flat;
            btnBanHang.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnBanHang.ForeColor = Color.White;
            btnBanHang.Location = new Point(20, 100);
            btnBanHang.Name = "btnBanHang";
            btnBanHang.Padding = new Padding(15, 0, 0, 0);
            btnBanHang.Size = new Size(190, 45);
            btnBanHang.TabIndex = 1;
            btnBanHang.Text = "\U0001f6d2   Bán hàng";
            btnBanHang.TextAlign = ContentAlignment.MiddleLeft;
            btnBanHang.UseVisualStyleBackColor = true;
            // 
            // btnBan
            // 
            btnBan.FlatAppearance.BorderSize = 0;
            btnBan.FlatStyle = FlatStyle.Flat;
            btnBan.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnBan.ForeColor = Color.White;
            btnBan.Location = new Point(20, 310);
            btnBan.Name = "btnBan";
            btnBan.Padding = new Padding(15, 0, 0, 0);
            btnBan.Size = new Size(190, 45);
            btnBan.TabIndex = 5;
            btnBan.Text = "\U0001fa91   Bàn";
            btnBan.TextAlign = ContentAlignment.MiddleLeft;
            btnBan.UseVisualStyleBackColor = true;
            // 
            // btnNhanVien
            // 
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnNhanVien.ForeColor = Color.White;
            btnNhanVien.Location = new Point(20, 160);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Padding = new Padding(15, 0, 0, 0);
            btnNhanVien.Size = new Size(190, 45);
            btnNhanVien.TabIndex = 2;
            btnNhanVien.Text = "👤   Nhân viên";
            btnNhanVien.TextAlign = ContentAlignment.MiddleLeft;
            btnNhanVien.UseVisualStyleBackColor = true;
            // 
            // btnSanPham
            // 
            btnSanPham.FlatAppearance.BorderSize = 0;
            btnSanPham.FlatStyle = FlatStyle.Flat;
            btnSanPham.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSanPham.ForeColor = Color.White;
            btnSanPham.Location = new Point(20, 210);
            btnSanPham.Name = "btnSanPham";
            btnSanPham.Padding = new Padding(15, 0, 0, 0);
            btnSanPham.Size = new Size(190, 45);
            btnSanPham.TabIndex = 4;
            btnSanPham.Text = "☕   Sản phẩm";
            btnSanPham.TextAlign = ContentAlignment.MiddleLeft;
            btnSanPham.UseVisualStyleBackColor = true;
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.FlatAppearance.BorderSize = 0;
            btnDanhMuc.FlatStyle = FlatStyle.Flat;
            btnDanhMuc.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDanhMuc.ForeColor = Color.White;
            btnDanhMuc.Location = new Point(20, 260);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Padding = new Padding(15, 0, 0, 0);
            btnDanhMuc.Size = new Size(190, 45);
            btnDanhMuc.TabIndex = 3;
            btnDanhMuc.Text = "📁   Danh mục";
            btnDanhMuc.TextAlign = ContentAlignment.MiddleLeft;
            btnDanhMuc.UseVisualStyleBackColor = true;
            // 
            // pnlHienthi
            // 
            pnlHienthi.Dock = DockStyle.Fill;
            pnlHienthi.Location = new Point(230, 0);
            pnlHienthi.Name = "pnlHienthi";
            pnlHienthi.Size = new Size(1352, 753);
            pnlHienthi.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 753);
            Controls.Add(pnlHienthi);
            Controls.Add(pnlMenu);
            Name = "Form1";
            Text = "Phần mềm quản lý bán hàng";
            Load += Form1_Load;
            pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlFooter.ResumeLayout(false);
            pnlFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFooterIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private Panel pnlHienthi;
        private Button btnThongKe;
        private Button btnBan;
        private Button btnSanPham;
        private Button btnDanhMuc;
        private Button btnNhanVien;
        private Button btnBanHang;
        private Button btnHoaDon;
        private Panel pnlFooter;
        private Label label3;
        private Label label2;
        private PictureBox picFooterIcon;
        private PictureBox pictureBox1;
    }
}
