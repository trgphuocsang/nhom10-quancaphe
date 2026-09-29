using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyCaPhe
{
    public partial class UC_BanHang : UserControl
    {
        private string banDangChon = "";
        private int maLoaiDangChon = 1;
        public UC_BanHang()
        {
            InitializeComponent();



            txtTimKiem.Enter += txtTimKiem_Enter;
            txtTimKiem.Leave += txtTimKiem_Leave;

            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
        }

        private void pnlSearchBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle rect = new Rectangle(1, 1, pnlSearchBox.Width - 3, pnlSearchBox.Height - 3);
            int radius = 16;

            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                using (SolidBrush brush = new SolidBrush(Color.White))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (Pen pen = new Pen(Color.FromArgb(160, 175, 190), 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
        private void txtTimKiem_Enter(object? sender, EventArgs e)
        {
            if (txtTimKiem.Text.Contains("Tìm món"))
            {
                txtTimKiem.Text = "";
                txtTimKiem.ForeColor = Color.Black;
            }
        }
        private void txtTimKiem_Leave(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTimKiem.Text))
            {
                txtTimKiem.Text = "Tìm món...";
                txtTimKiem.ForeColor = Color.Gray;
            }
        }

        private void PanelCard_Click(object? sender, EventArgs e)
        {
            Panel? clickedPanel = null;

            if (sender is Panel pnl)
            {
                clickedPanel = pnl;
            }
            else if (sender is Control ctrl)
            {
                clickedPanel = ctrl.Parent as Panel;
            }

            if (clickedPanel == null) return;

            // bỏ chọn bàn htai
            string tenBanHienTai = clickedPanel.Tag != null ? clickedPanel.Tag.ToString() : "";
            if (banDangChon == tenBanHienTai)
            {
                // reset lại trạng thái bàn về bth
                clickedPanel.BackColor = Color.FromArgb(235, 245, 250);
                DoiMautext(clickedPanel, Color.FromArgb(15, 45, 60));

                banDangChon = ""; // xóa bàn đang chọn

                // reset bàn bên hóa đơn
                if (lblTenBan != null)
                {
                    lblTenBan.Text = "Chưa chọn";
                    lblTenBan.ForeColor = Color.Gray;
                }
                else
                {
                    foreach (Control box in pnlKhungHoaDon.Controls)
                    {
                        if (box is Label l && l.Name == "lblTenBan")
                        {
                            l.Text = "Chưa chọn";
                            l.ForeColor = Color.Gray;
                            break;
                        }
                    }
                }
                return;
            }

            // đổi màu các bàn về trạng thái bth
            foreach (Control c in flowPanelBan.Controls)
            {
                if (c is Panel p)
                {
                    p.BackColor = Color.FromArgb(235, 245, 250);
                    DoiMautext(p, Color.FromArgb(15, 45, 60));
                }
            }

            // đổi màu bàn đc chọn
            clickedPanel.BackColor = Color.DarkSlateGray;
            DoiMautext(clickedPanel, Color.White);

            // lấy tên số bàn từ tag
            if (clickedPanel.Tag != null)
            {
                banDangChon = clickedPanel.Tag.ToString();

                // gán tên bàn lên lblTenBan 
                if (lblTenBan != null)
                {
                    lblTenBan.Text = banDangChon;
                    lblTenBan.ForeColor = Color.DarkSlateGray;
                }
                else
                {
                    foreach (Control box in pnlKhungHoaDon.Controls)
                    {
                        if (box is Label l && l.Name == "lblTenBan")
                        {
                            l.Text = banDangChon;
                            l.ForeColor = Color.FromArgb(0, 102, 204);
                            break;
                        }
                    }
                }
            }
        }


        private void DoiMautext(Panel pnl, Color color)
        {
            foreach (Control subCtrl in pnl.Controls)
            {
                if (subCtrl is Label lbl)
                {
                    lbl.ForeColor = color;
                }
            }
        }

        public void LoadMenuTheoDanhMuc(int maLoai)
        {
            maLoaiDangChon = maLoai;

            string query = "SELECT TenMon, Gia, HinhAnh FROM MonAn " +
                           "WHERE MaLoai = " + maLoai;

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            HienThiDanhSachMon(dt);
        }

        private Image CatVaCanhGiuaAnh(string duongDanFile, int targetWidth, int targetHeight)
        {
            byte[] fileBytes = System.IO.File.ReadAllBytes(duongDanFile);
            using (var ms = new System.IO.MemoryStream(fileBytes))
            {
                using (var originalImage = Image.FromStream(ms))
                {
                    double targetRatio = (double)targetWidth / targetHeight;
                    double originalRatio = (double)originalImage.Width / originalImage.Height;

                    int sourceX = 0, sourceY = 0;
                    int sourceWidth = originalImage.Width;
                    int sourceHeight = originalImage.Height;

                    if (originalRatio > targetRatio)
                    {
                        sourceWidth = (int)(originalImage.Height * targetRatio);
                        sourceX = (originalImage.Width - sourceWidth) / 2;
                    }
                    else
                    {
                        sourceHeight = (int)(originalImage.Width / targetRatio);
                        sourceY = (originalImage.Height - sourceHeight) / 2;
                    }

                    var targetImage = new Bitmap(targetWidth, targetHeight);
                    using (var graphics = Graphics.FromImage(targetImage))
                    {
                        graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                        graphics.DrawImage(originalImage,
                            new Rectangle(0, 0, targetWidth, targetHeight),
                            new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                            GraphicsUnit.Pixel);
                    }
                    return targetImage;
                }
            }
        }

        private void btnCatCaPhe_Click(object sender, EventArgs e)
        {
            LoadMenuTheoDanhMuc(1);
        }

        private void btnCatTra_Click(object sender, EventArgs e)
        {
            LoadMenuTheoDanhMuc(2);
        }

        private void btnCatMatcha_Click(object sender, EventArgs e)
        {
            LoadMenuTheoDanhMuc(3);
        }

        private void btnCatNuocEp_Click(object sender, EventArgs e)
        {
            LoadMenuTheoDanhMuc(4);
        }
        private void btnCatBanh_Click(object sender, EventArgs e)
        {
            LoadMenuTheoDanhMuc(5);
        }

        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            LoadMenuTheoDanhMuc(1);
        }


        private void ThemMonVaoHoaDon(string tenMon, decimal donGia)
        {
            // ktra trong flpHoaDon có món này chưa, nếu có rồi thì tăng số lượng lên 1
            foreach (Control ctrl in flpHoaDon.Controls)
            {
                if (ctrl is UC_ItemHoaDon item && item.TenMon == tenMon)
                {
                    foreach (Control sub in item.Controls)
                    {
                        if (sub is Label lbl && lbl.Name == "lblSoLuong")
                        {
                            int sl = int.Parse(lbl.Text) + 1;
                            lbl.Text = sl.ToString();

                            // cập nhật thành tiền và tổng tiền
                            TinhTongTien();
                            return;
                        }
                    }
                }
            }

            int stt = flpHoaDon.Controls.Count + 1;
            UC_ItemHoaDon newItem = new UC_ItemHoaDon(stt.ToString(), tenMon, donGia, 1);

            // tính lại tổng tiền khi có thay đổi
            newItem.OnThayDoiSoLuong += (s, e) =>
            {
                TinhTongTien();
            };

            flpHoaDon.Controls.Add(newItem);
            TinhTongTien();
        }

        // hàm tính tổng tiền hóa đơn
        private void TinhTongTien()
        {
            decimal tongTien = 0;
            foreach (Control ctrl in flpHoaDon.Controls)
            {
                if (ctrl is UC_ItemHoaDon item)
                {
                    foreach (Control sub in item.Controls)
                    {
                        if (sub is Label lbl && lbl.Name == "lblSoLuong")
                        {
                            int sl = int.Parse(lbl.Text);
                            tongTien += sl * item.DonGia;
                            break;
                        }
                    }
                }
            }

            System.Globalization.CultureInfo cul = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            string tienFormat = tongTien.ToString("#,###", cul.NumberFormat) + "đ";

            // gán tiền vào lblTongTien 
            if (lblTongTien != null)
            {
                lblTongTien.Text = tienFormat;
            }
            else
            {
                foreach (Control c in pnlKhungHoaDon.Controls)
                {
                    if (c is Label l && l.Name == "lblTongTien")
                    {
                        l.Text = tienFormat;
                        break;
                    }
                }
            }
        }

        private void btnHuyHD_Click(object sender, EventArgs e)
        {
            if (flpHoaDon.Controls.Count == 0)
            {
                MessageBox.Show("Hóa đơn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dr = MessageBox.Show("Xác nhận hủy hóa đơn này?", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                // xóa tất cả các món ăn đang hiển thị trong khung hóa đơn
                flpHoaDon.Controls.Clear();

                // gọi lại hàm tính tổng tiền
                TinhTongTien();
            }
        }


        private void txtTimKiem_TextChanged(object? sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "Tìm món..." || string.IsNullOrWhiteSpace(tuKhoa))
            {
                LoadMenuTheoDanhMuc(maLoaiDangChon);
                return;
            }

            // tìm món theo tên 
            string tuKhoaSQL = tuKhoa.Replace("'", "''");

            string query = "SELECT TenMon, Gia, HinhAnh FROM MonAn " +
                           "WHERE TenMon LIKE N'%" + tuKhoaSQL + "%'";

            DataTable dt = DataProvider.Instance.ExecuteQuery(query);

            HienThiDanhSachMon(dt);
        }

        private void HienThiDanhSachMon(DataTable dt)
        {
            flpMenu.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                UC_TheSanPham theSP = new UC_TheSanPham();

                string tenMon = row["TenMon"].ToString();
                decimal giaGoc = Convert.ToDecimal(row["Gia"]);

                System.Globalization.CultureInfo cul =
                    System.Globalization.CultureInfo.GetCultureInfo("vi-VN");

                string giaTien = giaGoc.ToString("#,###", cul.NumberFormat) + "đ";

                Image img = null;
                string tenFileAnh = row["HinhAnh"].ToString();

                if (!string.IsNullOrEmpty(tenFileAnh))
                {
                    string duongDanDayDu = System.IO.Path.Combine(
                        Application.StartupPath, "Images", tenFileAnh);

                    if (System.IO.File.Exists(duongDanDayDu))
                    {
                        try
                        {
                            img = CatVaCanhGiuaAnh(duongDanDayDu, 162, 116);
                        }
                        catch
                        {
                            img = null;
                        }
                    }
                }

                theSP.GanThongTin(tenMon, giaTien, img);

                theSP.OnChonSanPham += (sender, e) =>
                {
                    ThemMonVaoHoaDon(tenMon, giaGoc);
                };

                flpMenu.Controls.Add(theSP);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            // ktra hđ có món chưa
            if (flpHoaDon.Controls.Count == 0)
            {
                MessageBox.Show(
                    "Vui lòng chọn món trước khi thanh toán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // ktra đã chọn bàn chưa
            if (string.IsNullOrWhiteSpace(banDangChon))
            {
                MessageBox.Show(
                    "Vui lòng chọn bàn trước khi thanh toán!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }

            // lấy danh sách món từ hóa đơn
            List<MonThanhToan> dsMon = new List<MonThanhToan>();

            foreach (Control ctrl in flpHoaDon.Controls)
            {
                if (ctrl is UC_ItemHoaDon item)
                {
                    int soLuong = 1;

                    foreach (Control sub in item.Controls)
                    {
                        if (sub is Label lbl && lbl.Name == "lblSoLuong")
                        {
                            int.TryParse(lbl.Text, out soLuong);
                            break;
                        }
                    }

                    MonThanhToan mon = new MonThanhToan()
                    {
                        TenMon = item.TenMon,
                        DonGia = item.DonGia,
                        SoLuong = soLuong
                    };

                    dsMon.Add(mon);
                }
            }

            // tạo màn hình thanh toán, truyền dữ liệu
            UC_ThanhToan ucThanhToan = new UC_ThanhToan();

            ucThanhToan.NhanDuLieuThanhToan(dsMon, banDangChon);

            // mở màn hình thanh toán
            Form1 formChinh = this.FindForm() as Form1;

            if (formChinh != null)
            {
                formChinh.MoManHinhThanhToan(ucThanhToan);
            }
            else
            {
                MessageBox.Show(
                    "Không tìm thấy Form1 để mở màn hình thanh toán!",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}