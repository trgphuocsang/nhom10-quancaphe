using System.Data;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;

namespace QuanLyCaPhe
{
    public partial class UC_ThanhToan : UserControl
    {
        private List<MonThanhToan> danhSachMon = new List<MonThanhToan>();
        private string tenBan = "";
        private decimal tongTien = 0;

        private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

        public UC_ThanhToan()
        {
            InitializeComponent();

            txtTienKhachDua.TextChanged += txtTienKhachDua_TextChanged;
            rdoTienMat.CheckedChanged += PhuongThuc_CheckedChanged;
            rdoChuyenKhoan.CheckedChanged += PhuongThuc_CheckedChanged;
        }

        // Nhận dữ liệu từ UC_BanHang
        public void NhanDuLieuThanhToan(
            List<MonThanhToan> dsMon,
            string tenBanDuocChon)
        {
            danhSachMon = dsMon;
            tenBan = tenBanDuocChon;

            flpChiTietMon.Controls.Clear();

            if (danhSachMon == null)
                return;

            foreach (MonThanhToan mon in danhSachMon)
            {
                ThemDongMon(mon);
            }

            TinhTongTien();

            // Nếu giao diện có label tên bàn thì cập nhật
            foreach (Control c in Controls)
            {
                if (c is Label lbl && lbl.Name == "lblTenBan")
                {
                    lbl.Text = string.IsNullOrWhiteSpace(tenBan)
                        ? "Chưa chọn"
                        : tenBan;
                }
            }
        }

        // Tạo dòng món tự động trong FlowLayoutPanel
        private void ThemDongMon(MonThanhToan mon)
        {
            Panel dong = new Panel();
            dong.Width = flpChiTietMon.ClientSize.Width - 25;
            dong.Height = 55;
            dong.BackColor = Color.White;
            dong.Margin = new Padding(0, 0, 0, 5);

            Label lblTen = new Label();
            lblTen.Text = mon.TenMon;
            lblTen.Location = new Point(5, 5);
            lblTen.Size = new Size(250, 22);
            lblTen.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            lblTen.ForeColor = Color.DarkSlateGray;
            lblTen.AutoEllipsis = true;

            Label lblSoLuong = new Label();
            lblSoLuong.Text = "x" + mon.SoLuong;
            lblSoLuong.Location = new Point(5, 29);
            lblSoLuong.Size = new Size(100, 20);
            lblSoLuong.Font = new Font("Segoe UI", 9);
            lblSoLuong.ForeColor = Color.Gray;

            Label lblThanhTien = new Label();
            lblThanhTien.Text = mon.ThanhTien.ToString("#,##0", cul) + "đ";
            lblThanhTien.Size = new Size(150, 25);
            lblThanhTien.Location = new Point(
                dong.Width - lblThanhTien.Width - 5, 15);
            lblThanhTien.TextAlign = ContentAlignment.MiddleRight;
            lblThanhTien.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblThanhTien.ForeColor = Color.DarkSlateGray;

            dong.Controls.Add(lblTen);
            dong.Controls.Add(lblSoLuong);
            dong.Controls.Add(lblThanhTien);

            flpChiTietMon.Controls.Add(dong);
        }

        // Tính tổng tiền
        private void TinhTongTien()
        {
            tongTien = 0;

            foreach (MonThanhToan mon in danhSachMon)
            {
                tongTien += mon.ThanhTien;
            }

            lblTongTienValue.Text =
                tongTien.ToString("#,##0", cul) + "đ";

            TinhTienThua();
        }

        // Khi khách nhập tiền
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            TinhTienThua();
        }

        private void TinhTienThua()
        {
            decimal tienKhachDua = 0;

            string text = txtTienKhachDua.Text.Trim()
                .Replace(".", "")
                .Replace(",", "");

            decimal.TryParse(text, out tienKhachDua);

            decimal tienThua = tienKhachDua - tongTien;

            if (tienThua < 0)
                tienThua = 0;

            txtTienThua.Text = tienThua.ToString("#,##0", cul) + "đ";
        }

        // Xử lý phương thức thanh toán
        private void PhuongThuc_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoChuyenKhoan.Checked)
            {
                txtTienKhachDua.Text = tongTien.ToString("0");
                txtTienKhachDua.Enabled = false;
            }
            else if (rdoTienMat.Checked)
            {
                txtTienKhachDua.Enabled = true;
            }

            TinhTienThua();
        }

        private void UC_ThanhToan_Load(object sender, EventArgs e)
        {
        }

        private void btnXacNhanIn_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra danh sách món
            if (danhSachMon == null || danhSachMon.Count == 0)
            {
                MessageBox.Show("Chưa có món trong hóa đơn!");
                return;
            }

            // 2. Kiểm tra phương thức thanh toán
            if (!rdoTienMat.Checked && !rdoChuyenKhoan.Checked)
            {
                MessageBox.Show("Vui lòng chọn phương thức thanh toán!");
                return;
            }

            // 3. Lấy tiền khách đưa
            decimal tienKhachDua = 0;

            string chuoiTien = txtTienKhachDua.Text.Trim();

            string soTien =
                System.Text.RegularExpressions.Regex.Replace(
                    chuoiTien, @"[^\d]", "");

            decimal.TryParse(soTien, out tienKhachDua);

            // 4. Kiểm tra tiền khách đưa
            if (rdoTienMat.Checked && tienKhachDua < tongTien)
            {
                MessageBox.Show("Tiền khách đưa chưa đủ!");
                return;
            }

            // Chuyển khoản: mặc định thanh toán đúng tổng tiền
            if (rdoChuyenKhoan.Checked)
            {
                tienKhachDua = tongTien;
            }

            decimal tienThua = tienKhachDua - tongTien;

            if (tienThua < 0)
            {
                tienThua = 0;
            }

            string phuongThuc = rdoTienMat.Checked
                ? "Tiền mặt"
                : "Chuyển khoản";

            try
            {
                using (SqlConnection connection =
                    DataProvider.Instance.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                        connection.BeginTransaction())
                    {
                        try
                        {
                            // 5. Lưu hóa đơn
                            string queryHoaDon = @"
                        INSERT INTO HoaDon
                        (
                            TenBan,
                            TongTien,
                            PhuongThucThanhToan,
                            TienKhachDua,
                            TienThua
                        )
                        VALUES
                        (
                            @TenBan,
                            @TongTien,
                            @PhuongThuc,
                            @TienKhachDua,
                            @TienThua
                        );

                        SELECT CAST(SCOPE_IDENTITY() AS INT);
                    ";

                            int maHoaDon;

                            using (SqlCommand cmd = new SqlCommand(
                                queryHoaDon, connection, transaction))
                            {
                                cmd.Parameters.Add("@TenBan",
                                    SqlDbType.NVarChar, 50).Value =
                                    string.IsNullOrWhiteSpace(tenBan)
                                        ? (object)DBNull.Value
                                        : tenBan;

                                cmd.Parameters.Add("@TongTien",
                                    SqlDbType.Decimal).Value = tongTien;

                                cmd.Parameters["@TongTien"].Precision = 18;
                                cmd.Parameters["@TongTien"].Scale = 2;

                                cmd.Parameters.Add("@PhuongThuc",
                                    SqlDbType.NVarChar, 50).Value =
                                    phuongThuc;

                                cmd.Parameters.Add("@TienKhachDua",
                                    SqlDbType.Decimal).Value =
                                    tienKhachDua;

                                cmd.Parameters["@TienKhachDua"].Precision = 18;
                                cmd.Parameters["@TienKhachDua"].Scale = 2;

                                cmd.Parameters.Add("@TienThua",
                                    SqlDbType.Decimal).Value = tienThua;

                                cmd.Parameters["@TienThua"].Precision = 18;
                                cmd.Parameters["@TienThua"].Scale = 2;

                                maHoaDon = (int)cmd.ExecuteScalar();
                            }

                            // 6. Lưu chi tiết từng món
                            string queryChiTiet = @"
                        INSERT INTO ChiTietHoaDon
                        (
                            MaHoaDon,
                            TenMon,
                            DonGia,
                            SoLuong,
                            ThanhTien
                        )
                        VALUES
                        (
                            @MaHoaDon,
                            @TenMon,
                            @DonGia,
                            @SoLuong,
                            @ThanhTien
                        );
                    ";

                            foreach (MonThanhToan mon in danhSachMon)
                            {
                                using (SqlCommand cmd = new SqlCommand(
                                    queryChiTiet, connection, transaction))
                                {
                                    cmd.Parameters.Add("@MaHoaDon",
                                        SqlDbType.Int).Value = maHoaDon;

                                    cmd.Parameters.Add("@TenMon",
                                        SqlDbType.NVarChar, 200).Value =
                                        mon.TenMon;

                                    cmd.Parameters.Add("@DonGia",
                                        SqlDbType.Decimal).Value =
                                        mon.DonGia;

                                    cmd.Parameters["@DonGia"].Precision = 18;
                                    cmd.Parameters["@DonGia"].Scale = 2;

                                    cmd.Parameters.Add("@SoLuong",
                                        SqlDbType.Int).Value =
                                        mon.SoLuong;

                                    cmd.Parameters.Add("@ThanhTien",
                                        SqlDbType.Decimal).Value =
                                        mon.ThanhTien;

                                    cmd.Parameters["@ThanhTien"].Precision = 18;
                                    cmd.Parameters["@ThanhTien"].Scale = 2;

                                    cmd.ExecuteNonQuery();
                                }
                            }

                            // 7. Hoàn tất giao dịch SQL
                            transaction.Commit();

                            // 8. Thông báo thanh toán thành công
                            MessageBox.Show(
                                "Thanh toán thành công!\n" +
                                "Mã hóa đơn: " + maHoaDon +
                                "\nTổng tiền: " +
                                tongTien.ToString("#,##0", cul) + "đ",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                        catch
                        {
                            // Có lỗi thì hoàn tác giao dịch
                            transaction.Rollback();

                            throw;
                        }
                    }
                }

                // 9. Sau khi lưu hóa đơn thành công
                // Tạo màn hình bán hàng mới, giỏ hàng trống
                Form1 form = this.FindForm() as Form1;

                if (form != null)
                {
                    form.MoManHinhBanHangMoi();
                }
                else
                {
                    MessageBox.Show(
                        "Không tìm thấy Form1!",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi khi lưu hóa đơn:\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Form1 form = this.FindForm() as Form1;

            if (form != null)
            {
                form.MoManHinhBanHang();
            }
        }

        private void btnHuyTT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
         "Bạn có chắc chắn muốn hủy hóa đơn này?",
         "Xác nhận hủy",
         MessageBoxButtons.YesNo,
         MessageBoxIcon.Question
     );

            if (result == DialogResult.Yes)
            {
                Form1 form = this.FindForm() as Form1;

                if (form != null)
                {
                    form.MoManHinhBanHangMoi();
                }
            }
        }
    }
}