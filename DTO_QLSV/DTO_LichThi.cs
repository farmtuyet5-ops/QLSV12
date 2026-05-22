using System;

namespace DTO_QLSV
{
    public class DTO_LichThi
    {
        public string MaLT { get; set; }
        public string MaHP { get; set; }
        public DateTime NgayThi { get; set; }
        public TimeSpan GioThi { get; set; }
        public string PhongThi { get; set; }
        public string HinhThuc { get; set; }
        public int ThoiLuong { get; set; }

        public DTO_LichThi() { }

        public DTO_LichThi(string maLT, string maHP, DateTime ngayThi, TimeSpan gioThi,
                           string phongThi, string hinhThuc, int thoiLuong)
        {
            MaLT = maLT;
            MaHP = maHP;
            NgayThi = ngayThi;
            GioThi = gioThi;
            PhongThi = phongThi;
            HinhThuc = hinhThuc;
            ThoiLuong = thoiLuong;
        }
    }
}