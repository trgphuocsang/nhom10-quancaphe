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
            ucBanHang = new UC_BanHang();

            ucBanHang.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Clear();
            pnlHienthi.Controls.Add(ucBanHang);

            ucBanHang.BringToFront();
        }

        // mở lại màn hình bán hàng cũ
        public void MoManHinhBanHang()
        {
            pnlHienthi.Controls.Clear();

            ucBanHang.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Add(ucBanHang);

            ucBanHang.BringToFront();
        }

        // mở màn hình mới dùng khi hủy TT hoặc TT thành công
        public void MoManHinhBanHangMoi()
        {
            // xóa các giao diện đang hiển thị trong panel

            pnlHienthi.Controls.Clear();

            if (ucBanHang != null)
            {
                ucBanHang.Dispose();
            }

            // tạo màn hình bán hàng mới
            ucBanHang = new UC_BanHang();

            ucBanHang.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Add(ucBanHang);

            ucBanHang.BringToFront();
        }

        // mở màn hình thanh toán
        public void MoManHinhThanhToan(UC_ThanhToan ucThanhToan)
        {
            pnlHienthi.Controls.Clear();

            ucThanhToan.Dock = DockStyle.Fill;

            pnlHienthi.Controls.Add(ucThanhToan);

            ucThanhToan.BringToFront();
        }
    }
}