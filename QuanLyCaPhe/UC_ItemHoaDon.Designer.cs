namespace QuanLyCaPhe
{
    partial class UC_ItemHoaDon
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
            lblSTT = new Label();
            lblTenMonHD = new Label();
            btnGiam = new Button();
            lblSoLuong = new Label();
            btnTang = new Button();
            lblThanhTien = new Label();
            btnTuyChon = new Button();
            SuspendLayout();
            // 
            // lblSTT
            // 
            lblSTT.AutoSize = true;
            lblSTT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSTT.ForeColor = Color.DarkSlateGray;
            lblSTT.Location = new Point(4, 17);
            lblSTT.Name = "lblSTT";
            lblSTT.Size = new Size(17, 20);
            lblSTT.TabIndex = 0;
            lblSTT.Text = "1";
            // 
            // lblTenMonHD
            // 
            lblTenMonHD.AutoSize = true;
            lblTenMonHD.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTenMonHD.ForeColor = Color.DarkSlateGray;
            lblTenMonHD.Location = new Point(28, 17);
            lblTenMonHD.Name = "lblTenMonHD";
            lblTenMonHD.Size = new Size(134, 20);
            lblTenMonHD.TabIndex = 1;
            lblTenMonHD.Text = "Cà phê hạnh nhân";
            // 
            // btnGiam
            // 
            btnGiam.FlatStyle = FlatStyle.System;
            btnGiam.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGiam.ForeColor = Color.DarkSlateGray;
            btnGiam.Location = new Point(188, 12);
            btnGiam.Name = "btnGiam";
            btnGiam.Size = new Size(30, 30);
            btnGiam.TabIndex = 2;
            btnGiam.Text = "-";
            btnGiam.UseVisualStyleBackColor = true;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(228, 17);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(17, 20);
            lblSoLuong.TabIndex = 3;
            lblSoLuong.Text = "2";
            // 
            // btnTang
            // 
            btnTang.FlatStyle = FlatStyle.System;
            btnTang.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTang.ForeColor = Color.DarkSlateGray;
            btnTang.Location = new Point(253, 12);
            btnTang.Name = "btnTang";
            btnTang.Size = new Size(30, 30);
            btnTang.TabIndex = 4;
            btnTang.Text = "+";
            btnTang.UseVisualStyleBackColor = true;
            // 
            // lblThanhTien
            // 
            lblThanhTien.AutoSize = true;
            lblThanhTien.ForeColor = Color.DarkSlateGray;
            lblThanhTien.Location = new Point(310, 17);
            lblThanhTien.Name = "lblThanhTien";
            lblThanhTien.Size = new Size(52, 20);
            lblThanhTien.TabIndex = 5;
            lblThanhTien.Text = "55.000";
            // 
            // btnTuyChon
            // 
            btnTuyChon.FlatStyle = FlatStyle.System;
            btnTuyChon.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTuyChon.ForeColor = Color.DarkSlateGray;
            btnTuyChon.Location = new Point(389, 12);
            btnTuyChon.Name = "btnTuyChon";
            btnTuyChon.Size = new Size(30, 30);
            btnTuyChon.TabIndex = 6;
            btnTuyChon.Text = "...";
            btnTuyChon.UseVisualStyleBackColor = true;
            // 
            // UC_ItemHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTuyChon);
            Controls.Add(lblThanhTien);
            Controls.Add(btnTang);
            Controls.Add(lblSoLuong);
            Controls.Add(btnGiam);
            Controls.Add(lblTenMonHD);
            Controls.Add(lblSTT);
            Name = "UC_ItemHoaDon";
            Size = new Size(425, 52);
            Load += UC_ItemHoaDon_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSTT;
        private Label lblTenMonHD;
        private Button btnGiam;
        private Label lblSoLuong;
        private Button btnTang;
        private Label lblThanhTien;
        private Button btnTuyChon;
    }
}
