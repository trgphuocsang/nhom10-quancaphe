using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class UC_TheSanPham : UserControl
    {
        // khai báo sự kiện khi bấm vào sản phẩm
        public event EventHandler? OnChonSanPham;
        public UC_TheSanPham()
        {
            InitializeComponent();

            this.Click += (s, e) => OnChonSanPham?.Invoke(this, EventArgs.Empty);
            DangKySuKienChoCon(this);
        }

        private void DangKySuKienChoCon(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.Click += (s, e) => OnChonSanPham?.Invoke(this, EventArgs.Empty);
                if (child.HasChildren)
                {
                    DangKySuKienChoCon(child);
                }
            }
        }

        public void GanThongTin(string tenMon, string giaTien, Image hinhAnh)
        {
            lblTenMon.Text = tenMon;
            lblGiaTien.Text = giaTien;

            if (hinhAnh != null)
            {
                picHinhAnh.Image = hinhAnh;
                picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void UC_TheSanPham_Load(object sender, EventArgs e)
        {

        }
    }
}