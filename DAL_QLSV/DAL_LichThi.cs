using System;
using System.Data;
using System.Data.SqlClient;
using DTO_QLSV;

namespace DAL_QLSV
{
    public class DAL_LichThi : DBConnect
    {
        public DataTable GetAll()
        {
            string sql = "SELECT * FROM vw_LichThi_ChiTiet ORDER BY NgayThi, GioThi";
            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable TimKiem(string tuKhoa)
        {
            string sql = @"
                SELECT * 
                FROM vw_LichThi_ChiTiet
                WHERE MaLT LIKE @kw
                   OR MaHP LIKE @kw
                   OR TenMH LIKE @kw
                   OR PhongThi LIKE @kw
                   OR HinhThuc LIKE @kw
                ORDER BY NgayThi, GioThi";

            SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
            da.SelectCommand.Parameters.AddWithValue("@kw", "%" + tuKhoa + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool KiemTraTrungMa(string maLT)
        {
            string sql = "SELECT COUNT(*) FROM LichThi WHERE MaLT = @MaLT";

            if (_conn.State == ConnectionState.Closed)
               _conn.Open();

            SqlCommand cmd = new SqlCommand(sql,_conn);
            cmd.Parameters.AddWithValue("@MaLT", maLT);

            int count = (int)cmd.ExecuteScalar();
           _conn.Close();

            return count > 0;
        }

        public bool KiemTraTrungLich(string maLT, string maHP, DateTime ngayThi, TimeSpan gioThi, string phongThi)
        {
            string sql = @"
                SELECT COUNT(*)
                FROM LichThi
                WHERE MaLT <> @MaLT
                  AND NgayThi = @NgayThi
                  AND GioThi = @GioThi
                  AND (PhongThi = @PhongThi OR MaHP = @MaHP)";

            if (_conn.State ==ConnectionState.Closed)
               _conn.Open();

            SqlCommand cmd = new SqlCommand(sql,_conn);
            cmd.Parameters.AddWithValue("@MaLT", maLT);
            cmd.Parameters.AddWithValue("@MaHP", maHP);
            cmd.Parameters.AddWithValue("@NgayThi", ngayThi.Date);
            cmd.Parameters.AddWithValue("@GioThi", gioThi);
            cmd.Parameters.AddWithValue("@PhongThi", phongThi);

            int count = (int)cmd.ExecuteScalar();
           _conn.Close();

            return count > 0;
        }

        public bool Them(DTO_LichThi lt)
        {
            string sql = @"
                INSERT INTO LichThi(MaLT, MaHP, NgayThi, GioThi, PhongThi, HinhThuc, ThoiLuong)
                VALUES(@MaLT, @MaHP, @NgayThi, @GioThi, @PhongThi, @HinhThuc, @ThoiLuong)";

            return ThucThi(sql, lt);
        }

        public bool Sua(DTO_LichThi lt)
        {
            string sql = @"
                UPDATE LichThi
                SET MaHP = @MaHP,
                    NgayThi = @NgayThi,
                    GioThi = @GioThi,
                    PhongThi = @PhongThi,
                    HinhThuc = @HinhThuc,
                    ThoiLuong = @ThoiLuong
                WHERE MaLT = @MaLT";

            return ThucThi(sql, lt);
        }

        public bool Xoa(string maLT)
        {
            string sql = "DELETE FROM LichThi WHERE MaLT = @MaLT";

            if (_conn.State == ConnectionState.Closed)
               _conn.Open();

            SqlCommand cmd = new SqlCommand(sql,_conn);
            cmd.Parameters.AddWithValue("@MaLT", maLT);

            int kq = cmd.ExecuteNonQuery();
           _conn.Close();

            return kq > 0;
        }

        private bool ThucThi(string sql, DTO_LichThi lt)
        {
            if (_conn.State == ConnectionState.Closed)
               _conn.Open();

            SqlCommand cmd = new SqlCommand(sql,_conn);
            cmd.Parameters.AddWithValue("@MaLT", lt.MaLT);
            cmd.Parameters.AddWithValue("@MaHP", lt.MaHP);
            cmd.Parameters.AddWithValue("@NgayThi", lt.NgayThi.Date);
            cmd.Parameters.AddWithValue("@GioThi", lt.GioThi);
            cmd.Parameters.AddWithValue("@PhongThi", lt.PhongThi);
            cmd.Parameters.AddWithValue("@HinhThuc", lt.HinhThuc);
            cmd.Parameters.AddWithValue("@ThoiLuong", lt.ThoiLuong);

            int kq = cmd.ExecuteNonQuery();
           _conn.Close();

            return kq > 0;
        }
    }
}