using System;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyCaPhe
{
    public partial class UC_ItemHoaDon : UserControl
    {
        public decimal DonGia { get; set; }
        public string TenMon { get; set; }

        public event EventHandler OnThayDoiSoLuong;

        public UC_ItemHoaDon(string stt, string tenMon, decimal donGia, int soLuong)
        {
            InitializeComponent();

            lblSTT.Text = stt;
            TenMon = tenMon;
            DonGia = donGia;
            lblTenMonHD.Text = tenMon; 
            lblSoLuong.Text = soLuong.ToString();
            CapNhatThanhTien();

            // nút tăng [+]
            btnTang.Click += (s, e) =>
            {
                int sl = int.Parse(lblSoLuong.Text) + 1;
                lblSoLuong.Text = sl.ToString();
                CapNhatThanhTien();
                OnThayDoiSoLuong?.Invoke(this, EventArgs.Empty);
            };

            // nút giảm [-]
            btnGiam.Click += (s, e) =>
            {
                int sl = int.Parse(lblSoLuong.Text);
                if (sl > 1)
                {
                    sl--;
                    lblSoLuong.Text = sl.ToString();
                    CapNhatThanhTien();
                    OnThayDoiSoLuong?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    // nếu sl giảm về 0 thì xóa dòng này khỏi flp
                    this.Parent.Controls.Remove(this);
                    OnThayDoiSoLuong?.Invoke(this, EventArgs.Empty);
                }
            };
        }

        private void CapNhatThanhTien()
        {
            int sl = int.Parse(lblSoLuong.Text);
            decimal thanhTien = sl * DonGia;
            System.Globalization.CultureInfo culVn = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
            lblThanhTien.Text = thanhTien.ToString("#,###", culVn.NumberFormat) + "đ";
        }

        private void UC_ItemHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}