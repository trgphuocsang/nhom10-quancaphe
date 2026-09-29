namespace QuanLyCaPhe
{
    public partial class Form1 : Form
    {
        private UC_BanHang ucBanHang;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo màn hình bán hàng lần đầu
            ucBanHang = new UC_BanHang();

            ucBanHang.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Clear();
            pnlHienthi.Controls.Add(ucBanHang);

            ucBanHang.BringToFront();
        }

        // 1. MỞ LẠI MÀN HÌNH BÁN HÀNG CŨ
        // Giữ nguyên món ăn, số lượng và bàn đã chọn
        public void MoManHinhBanHang()
        {
            pnlHienthi.Controls.Clear();

            ucBanHang.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Add(ucBanHang);

            ucBanHang.BringToFront();
        }

        // 2. MỞ MÀN HÌNH BÁN HÀNG MỚI
        // Dùng khi hủy thanh toán hoặc thanh toán thành công
        public void MoManHinhBanHangMoi()
        {
            pnlHienthi.Controls.Clear();

            // Giải phóng màn hình bán hàng cũ
            if (ucBanHang != null)
            {
                ucBanHang.Dispose();
            }

            // Tạo màn hình bán hàng mới
            ucBanHang = new UC_BanHang();

            ucBanHang.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Add(ucBanHang);

            ucBanHang.BringToFront();
        }

        // 3. MỞ MÀN HÌNH THANH TOÁN
        public void MoManHinhThanhToan(UC_ThanhToan ucThanhToan)
        {
            pnlHienthi.Controls.Clear();

            ucThanhToan.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Add(ucThanhToan);

            ucThanhToan.BringToFront();
        }
    }
}