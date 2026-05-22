using System;
using System.Data;
using DAL_QLSV;
using DTO_QLSV;

namespace BUS_QLSV
{
    public class BUS_LichThi
    {
        private DAL_LichThi dal = new DAL_LichThi();

        public DataTable GetAll()
        {
            return dal.GetAll();
        }

        public DataTable TimKiem(string tuKhoa)
        {
            return dal.TimKiem(tuKhoa);
        }

        public string Them(DTO_LichThi lt)
        {
            string loi = KiemTra(lt, true);
            if (loi != "") return loi;

            if (dal.KiemTraTrungMa(lt.MaLT))
                return "Mã lịch thi đã tồn tại.";

            if (dal.KiemTraTrungLich(lt.MaLT, lt.MaHP, lt.NgayThi, lt.GioThi, lt.PhongThi))
                return "Bị trùng lịch thi hoặc trùng phòng thi.";

            return dal.Them(lt) ? "" : "Thêm lịch thi thất bại.";
        }

        public string Sua(DTO_LichThi lt)
        {
            string loi = KiemTra(lt, false);
            if (loi != "") return loi;

            if (dal.KiemTraTrungLich(lt.MaLT, lt.MaHP, lt.NgayThi, lt.GioThi, lt.PhongThi))
                return "Bị trùng lịch thi hoặc trùng phòng thi.";

            return dal.Sua(lt) ? "" : "Sửa lịch thi thất bại.";
        }

        public string Xoa(string maLT)
        {
            if (string.IsNullOrWhiteSpace(maLT))
                return "Vui lòng chọn lịch thi cần xoá.";

            return dal.Xoa(maLT) ? "" : "Xoá lịch thi thất bại.";
        }

        private string KiemTra(DTO_LichThi lt, bool them)
        {
            if (string.IsNullOrWhiteSpace(lt.MaLT))
                return "Vui lòng nhập mã lịch thi.";

            if (string.IsNullOrWhiteSpace(lt.MaHP))
                return "Vui lòng nhập mã học phần.";

            if (string.IsNullOrWhiteSpace(lt.PhongThi))
                return "Vui lòng nhập phòng thi.";

            if (string.IsNullOrWhiteSpace(lt.HinhThuc))
                return "Vui lòng chọn hình thức thi.";

            if (lt.HinhThuc != "Tự luận" &&
                lt.HinhThuc != "Trắc nghiệm" &&
                lt.HinhThuc != "Tự luận + trắc nghiệm")
                return "Hình thức thi không hợp lệ.";

            if (lt.ThoiLuong <= 0)
                return "Thời lượng phải lớn hơn 0.";

            return "";
        }
    }
}