namespace QuanLyCaPhe
{
    public class MonThanhToan
    {
        public string TenMon { get; set; }
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }

        public decimal ThanhTien
        {
            get { return DonGia * SoLuong; }
        }
    }
}