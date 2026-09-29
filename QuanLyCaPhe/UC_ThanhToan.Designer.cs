namespace QuanLyCaPhe
{
    partial class UC_ThanhToan
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
            pnlNen = new Panel();
            pnlKhungNgoai = new Panel();
            pnlThanhToanTT = new Panel();
            btnHuyTT = new Button();
            btnXacNhanIn = new Button();
            txtTienThua = new TextBox();
            lblTienThua = new Label();
            txtTienKhachDua = new TextBox();
            lblTienKhachDua = new Label();
            gbPhuongThuc = new GroupBox();
            rdoChuyenKhoan = new RadioButton();
            rdoTienMat = new RadioButton();
            lblTieuDeTT = new Label();
            pnlChiTiet = new Panel();
            flpChiTietMon = new FlowLayoutPanel();
            lblTongTienValue = new Label();
            lblTongThanhToan = new Label();
            pnlKeTongTien = new Panel();
            pnlKeChiTiet = new Panel();
            lblChiTiet = new Label();
            pnlHeader = new Panel();
            lblTieuDe = new Label();
            btnQuayLai = new Button();
            pnlNen.SuspendLayout();
            pnlKhungNgoai.SuspendLayout();
            pnlThanhToanTT.SuspendLayout();
            gbPhuongThuc.SuspendLayout();
            pnlChiTiet.SuspendLayout();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNen
            // 
            pnlNen.BackColor = SystemColors.GradientInactiveCaption;
            pnlNen.Controls.Add(pnlKhungNgoai);
            pnlNen.Location = new Point(20, 20);
            pnlNen.Name = "pnlNen";
            pnlNen.Size = new Size(1312, 713);
            pnlNen.TabIndex = 0;
            // 
            // pnlKhungNgoai
            // 
            pnlKhungNgoai.BackColor = Color.White;
            pnlKhungNgoai.BorderStyle = BorderStyle.FixedSingle;
            pnlKhungNgoai.Controls.Add(pnlThanhToanTT);
            pnlKhungNgoai.Controls.Add(pnlChiTiet);
            pnlKhungNgoai.Controls.Add(pnlHeader);
            pnlKhungNgoai.Location = new Point(20, 15);
            pnlKhungNgoai.Name = "pnlKhungNgoai";
            pnlKhungNgoai.Size = new Size(1272, 683);
            pnlKhungNgoai.TabIndex = 0;
            // 
            // pnlThanhToanTT
            // 
            pnlThanhToanTT.BorderStyle = BorderStyle.FixedSingle;
            pnlThanhToanTT.Controls.Add(btnHuyTT);
            pnlThanhToanTT.Controls.Add(btnXacNhanIn);
            pnlThanhToanTT.Controls.Add(txtTienThua);
            pnlThanhToanTT.Controls.Add(lblTienThua);
            pnlThanhToanTT.Controls.Add(txtTienKhachDua);
            pnlThanhToanTT.Controls.Add(lblTienKhachDua);
            pnlThanhToanTT.Controls.Add(gbPhuongThuc);
            pnlThanhToanTT.Controls.Add(lblTieuDeTT);
            pnlThanhToanTT.Location = new Point(636, 100);
            pnlThanhToanTT.Name = "pnlThanhToanTT";
            pnlThanhToanTT.Size = new Size(596, 550);
            pnlThanhToanTT.TabIndex = 2;
            // 
            // btnHuyTT
            // 
            btnHuyTT.FlatAppearance.BorderColor = Color.Gainsboro;
            btnHuyTT.FlatAppearance.BorderSize = 0;
            btnHuyTT.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btnHuyTT.FlatStyle = FlatStyle.Flat;
            btnHuyTT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHuyTT.ForeColor = Color.DarkSlateGray;
            btnHuyTT.Location = new Point(20, 445);
            btnHuyTT.Name = "btnHuyTT";
            btnHuyTT.Size = new Size(556, 58);
            btnHuyTT.TabIndex = 8;
            btnHuyTT.Text = "Hủy đơn";
            btnHuyTT.UseVisualStyleBackColor = true;
            btnHuyTT.Click += btnHuyTT_Click;
            // 
            // btnXacNhanIn
            // 
            btnXacNhanIn.BackColor = Color.DarkSlateGray;
            btnXacNhanIn.FlatAppearance.BorderSize = 0;
            btnXacNhanIn.FlatAppearance.MouseOverBackColor = Color.SlateGray;
            btnXacNhanIn.FlatStyle = FlatStyle.Flat;
            btnXacNhanIn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhanIn.ForeColor = Color.White;
            btnXacNhanIn.Location = new Point(20, 375);
            btnXacNhanIn.Name = "btnXacNhanIn";
            btnXacNhanIn.Size = new Size(556, 58);
            btnXacNhanIn.TabIndex = 7;
            btnXacNhanIn.Text = "Xác nhận và in HĐ";
            btnXacNhanIn.UseVisualStyleBackColor = false;
            btnXacNhanIn.Click += btnXacNhanIn_Click;
            // 
            // txtTienThua
            // 
            txtTienThua.BackColor = Color.Honeydew;
            txtTienThua.BorderStyle = BorderStyle.FixedSingle;
            txtTienThua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienThua.ForeColor = Color.DarkSlateGray;
            txtTienThua.Location = new Point(20, 305);
            txtTienThua.Name = "txtTienThua";
            txtTienThua.ReadOnly = true;
            txtTienThua.Size = new Size(556, 34);
            txtTienThua.TabIndex = 6;
            txtTienThua.Text = "đ";
            txtTienThua.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTienThua
            // 
            lblTienThua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienThua.ForeColor = Color.DarkSlateGray;
            lblTienThua.Location = new Point(20, 270);
            lblTienThua.Name = "lblTienThua";
            lblTienThua.Size = new Size(556, 28);
            lblTienThua.TabIndex = 5;
            lblTienThua.Text = "Tiền thừa";
            // 
            // txtTienKhachDua
            // 
            txtTienKhachDua.BackColor = Color.White;
            txtTienKhachDua.BorderStyle = BorderStyle.FixedSingle;
            txtTienKhachDua.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTienKhachDua.ForeColor = Color.DarkSlateGray;
            txtTienKhachDua.Location = new Point(20, 215);
            txtTienKhachDua.Name = "txtTienKhachDua";
            txtTienKhachDua.Size = new Size(556, 34);
            txtTienKhachDua.TabIndex = 4;
            txtTienKhachDua.TextAlign = HorizontalAlignment.Right;
            // 
            // lblTienKhachDua
            // 
            lblTienKhachDua.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTienKhachDua.ForeColor = Color.DarkSlateGray;
            lblTienKhachDua.Location = new Point(20, 180);
            lblTienKhachDua.Name = "lblTienKhachDua";
            lblTienKhachDua.Size = new Size(556, 28);
            lblTienKhachDua.TabIndex = 3;
            lblTienKhachDua.Text = "Tiền khách đưa";
            // 
            // gbPhuongThuc
            // 
            gbPhuongThuc.Controls.Add(rdoChuyenKhoan);
            gbPhuongThuc.Controls.Add(rdoTienMat);
            gbPhuongThuc.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbPhuongThuc.ForeColor = Color.DarkSlateGray;
            gbPhuongThuc.Location = new Point(20, 65);
            gbPhuongThuc.Name = "gbPhuongThuc";
            gbPhuongThuc.Size = new Size(556, 100);
            gbPhuongThuc.TabIndex = 2;
            gbPhuongThuc.TabStop = false;
            gbPhuongThuc.Text = "Phương thức thanh toán";
            // 
            // rdoChuyenKhoan
            // 
            rdoChuyenKhoan.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoChuyenKhoan.Location = new Point(280, 35);
            rdoChuyenKhoan.Name = "rdoChuyenKhoan";
            rdoChuyenKhoan.Size = new Size(220, 30);
            rdoChuyenKhoan.TabIndex = 1;
            rdoChuyenKhoan.TabStop = true;
            rdoChuyenKhoan.Text = "Chuyển khoản";
            rdoChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rdoTienMat
            // 
            rdoTienMat.Checked = true;
            rdoTienMat.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdoTienMat.Location = new Point(20, 35);
            rdoTienMat.Name = "rdoTienMat";
            rdoTienMat.Size = new Size(180, 30);
            rdoTienMat.TabIndex = 0;
            rdoTienMat.TabStop = true;
            rdoTienMat.Text = "Tiền mặt";
            rdoTienMat.UseVisualStyleBackColor = true;
            // 
            // lblTieuDeTT
            // 
            lblTieuDeTT.AutoSize = true;
            lblTieuDeTT.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDeTT.ForeColor = Color.DarkSlateGray;
            lblTieuDeTT.Location = new Point(20, 15);
            lblTieuDeTT.Name = "lblTieuDeTT";
            lblTieuDeTT.Size = new Size(140, 35);
            lblTieuDeTT.TabIndex = 0;
            lblTieuDeTT.Text = "Thanh toán";
            lblTieuDeTT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlChiTiet
            // 
            pnlChiTiet.BorderStyle = BorderStyle.FixedSingle;
            pnlChiTiet.Controls.Add(flpChiTietMon);
            pnlChiTiet.Controls.Add(lblTongTienValue);
            pnlChiTiet.Controls.Add(lblTongThanhToan);
            pnlChiTiet.Controls.Add(pnlKeTongTien);
            pnlChiTiet.Controls.Add(pnlKeChiTiet);
            pnlChiTiet.Controls.Add(lblChiTiet);
            pnlChiTiet.Location = new Point(20, 100);
            pnlChiTiet.Name = "pnlChiTiet";
            pnlChiTiet.Size = new Size(596, 550);
            pnlChiTiet.TabIndex = 1;
            // 
            // flpChiTietMon
            // 
            flpChiTietMon.AutoScroll = true;
            flpChiTietMon.FlowDirection = FlowDirection.TopDown;
            flpChiTietMon.Location = new Point(20, 100);
            flpChiTietMon.Margin = new Padding(0);
            flpChiTietMon.Name = "flpChiTietMon";
            flpChiTietMon.Size = new Size(556, 300);
            flpChiTietMon.TabIndex = 11;
            flpChiTietMon.WrapContents = false;
            // 
            // lblTongTienValue
            // 
            lblTongTienValue.Font = new Font("Segoe UI", 22.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTienValue.ForeColor = Color.DarkSlateGray;
            lblTongTienValue.Location = new Point(20, 475);
            lblTongTienValue.Name = "lblTongTienValue";
            lblTongTienValue.Size = new Size(556, 55);
            lblTongTienValue.TabIndex = 10;
            lblTongTienValue.Text = "230.000 đ";
            // 
            // lblTongThanhToan
            // 
            lblTongThanhToan.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongThanhToan.ForeColor = Color.DarkSlateGray;
            lblTongThanhToan.Location = new Point(20, 435);
            lblTongThanhToan.Name = "lblTongThanhToan";
            lblTongThanhToan.Size = new Size(556, 35);
            lblTongThanhToan.TabIndex = 9;
            lblTongThanhToan.Text = "Tổng thanh toán";
            // 
            // pnlKeTongTien
            // 
            pnlKeTongTien.BackColor = Color.Gainsboro;
            pnlKeTongTien.ForeColor = Color.White;
            pnlKeTongTien.Location = new Point(20, 420);
            pnlKeTongTien.Name = "pnlKeTongTien";
            pnlKeTongTien.Size = new Size(556, 1);
            pnlKeTongTien.TabIndex = 8;
            // 
            // pnlKeChiTiet
            // 
            pnlKeChiTiet.BackColor = Color.Gainsboro;
            pnlKeChiTiet.Location = new Point(20, 85);
            pnlKeChiTiet.Name = "pnlKeChiTiet";
            pnlKeChiTiet.Size = new Size(556, 1);
            pnlKeChiTiet.TabIndex = 1;
            // 
            // lblChiTiet
            // 
            lblChiTiet.AutoSize = true;
            lblChiTiet.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChiTiet.ForeColor = Color.DarkSlateGray;
            lblChiTiet.Location = new Point(20, 15);
            lblChiTiet.Name = "lblChiTiet";
            lblChiTiet.Size = new Size(206, 35);
            lblChiTiet.TabIndex = 0;
            lblChiTiet.Text = "Chi tiết đơn hàng";
            lblChiTiet.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.WhiteSmoke;
            pnlHeader.Controls.Add(lblTieuDe);
            pnlHeader.Controls.Add(btnQuayLai);
            pnlHeader.Location = new Point(20, 15);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1232, 65);
            pnlHeader.TabIndex = 0;
            // 
            // lblTieuDe
            // 
            lblTieuDe.Font = new Font("Segoe UI", 19.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTieuDe.ForeColor = Color.DarkSlateGray;
            lblTieuDe.Location = new Point(950, 10);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(260, 45);
            lblTieuDe.TabIndex = 1;
            lblTieuDe.Text = "Thanh toán";
            lblTieuDe.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnQuayLai
            // 
            btnQuayLai.BackColor = Color.Gainsboro;
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuayLai.ForeColor = Color.DarkSlateGray;
            btnQuayLai.Location = new Point(20, 18);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(205, 34);
            btnQuayLai.TabIndex = 0;
            btnQuayLai.Text = "← Quay lại";
            btnQuayLai.UseVisualStyleBackColor = false;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // UC_ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlNen);
            Name = "UC_ThanhToan";
            Size = new Size(1352, 753);
            Load += UC_ThanhToan_Load;
            pnlNen.ResumeLayout(false);
            pnlKhungNgoai.ResumeLayout(false);
            pnlThanhToanTT.ResumeLayout(false);
            pnlThanhToanTT.PerformLayout();
            gbPhuongThuc.ResumeLayout(false);
            pnlChiTiet.ResumeLayout(false);
            pnlChiTiet.PerformLayout();
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlNen;
        private Panel pnlKhungNgoai;
        private Panel pnlHeader;
        private Label lblTieuDe;
        private Button btnQuayLai;
        private Panel pnlChiTiet;
        private Panel pnlKeChiTiet;
        private Label lblChiTiet;
        private Label lblTongThanhToan;
        private Panel pnlKeTongTien;
        private Panel pnlThanhToanTT;
        private Label lblTieuDeTT;
        private Label lblTongTienValue;
        private GroupBox gbPhuongThuc;
        private RadioButton rdoTienMat;
        private Label lblTienThua;
        private TextBox txtTienKhachDua;
        private Label lblTienKhachDua;
        private RadioButton rdoChuyenKhoan;
        private Button btnXacNhanIn;
        private TextBox txtTienThua;
        private Button btnHuyTT;
        private FlowLayoutPanel flpChiTietMon;
    }
}
