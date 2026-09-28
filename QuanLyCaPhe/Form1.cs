namespace QuanLyCaPhe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UC_BanHang ucBanHang = new UC_BanHang();           
            ucBanHang.Dock = DockStyle.Fill;
            pnlHienthi.Controls.Clear();
            pnlHienthi.Controls.Add(ucBanHang);
            ucBanHang.BringToFront();
        }
    }
}
