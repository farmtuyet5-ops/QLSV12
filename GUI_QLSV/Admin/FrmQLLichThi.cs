using System;
using System.Data;
using System.Windows.Forms;
using BUS_QLSV;
using DTO_QLSV;

namespace GUI_QLSV
{
    public partial class FrmQLLichThi : Form
    {
        BUS_LichThi bus = new BUS_LichThi();

        public FrmQLLichThi()
        {
            InitializeComponent();
        }

        private void FrmQLLichThi_Load(object sender, EventArgs e)
        {
            dtpNgayThi.Format = DateTimePickerFormat.Custom;
            dtpNgayThi.CustomFormat = "dd/MM/yyyy";

            dtpThoiGian.Format = DateTimePickerFormat.Custom;
            dtpThoiGian.CustomFormat = "HH:mm";
            dtpThoiGian.ShowUpDown = true;

            cbHinhThuc.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHinhThuc.Items.Clear();
            cbHinhThuc.Items.Add("Tự luận");
            cbHinhThuc.Items.Add("Trắc nghiệm");
            cbHinhThuc.Items.Add("Tự luận + trắc nghiệm");

            txtSiSo.ReadOnly = true;
            txtMonHoc.ReadOnly = true;
            TxtHocPhan.ReadOnly = true;

            LoadData();
        }

        private void LoadData()
        {
            dgvDSLT.DataSource = bus.GetAll();
            DinhDangGrid();
        }

        private void DinhDangGrid()
        {
            if (dgvDSLT.Columns.Count == 0) return;

            dgvDSLT.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDSLT.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDSLT.MultiSelect = false;
            dgvDSLT.ReadOnly = true;
            dgvDSLT.AllowUserToAddRows = false;

            dgvDSLT.Columns["MaLT"].HeaderText = "Mã lịch thi";
            dgvDSLT.Columns["MaHP"].HeaderText = "Mã học phần";
            dgvDSLT.Columns["TenMH"].HeaderText = "Môn học";
            dgvDSLT.Columns["MaLop"].HeaderText = "Lớp";
            dgvDSLT.Columns["NgayThi"].HeaderText = "Ngày thi";
            dgvDSLT.Columns["GioThi"].HeaderText = "Giờ thi";
            dgvDSLT.Columns["PhongThi"].HeaderText = "Phòng";
            dgvDSLT.Columns["HinhThuc"].HeaderText = "Hình thức";
            dgvDSLT.Columns["ThoiLuong"].HeaderText = "Thời lượng";
            dgvDSLT.Columns["SiSoDuThi"].HeaderText = "Sĩ số";

            if (dgvDSLT.Columns.Contains("MaMH"))
                dgvDSLT.Columns["MaMH"].Visible = false;

            if (dgvDSLT.Columns.Contains("TenHocKy"))
                dgvDSLT.Columns["TenHocKy"].Visible = false;

            if (dgvDSLT.Columns.Contains("NamHoc"))
                dgvDSLT.Columns["NamHoc"].Visible = false;
        }

        private DTO_LichThi LayDuLieu()
        {
            int thoiLuong = 0;
            int.TryParse(txtThoiLuong.Text.Trim(), out thoiLuong);

            return new DTO_LichThi
            {
                MaLT = txtMaHP.Text.Trim(),
                MaHP = TxtHocPhan.Text.Trim(),
                NgayThi = dtpNgayThi.Value.Date,
                GioThi = dtpThoiGian.Value.TimeOfDay,
                PhongThi = txtPhongThi.Text.Trim(),
                HinhThuc = cbHinhThuc.Text.Trim(),
                ThoiLuong = thoiLuong
            };
        }



        private void LamMoi()
        {
            txtMaHP.Clear();
            TxtHocPhan.Clear();
            txtMonHoc.Clear();
            txtPhongThi.Clear();
            txtSiSo.Clear();
            txtThoiLuong.Clear();
            txtTimKiem.Clear();

            cbHinhThuc.SelectedIndex = -1;
            dtpNgayThi.Value = DateTime.Now;
            dtpThoiGian.Value = DateTime.Now;

            txtMaHP.Focus();
        }

        private void dgvDSLT_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow r = dgvDSLT.Rows[e.RowIndex];

            txtMaHP.Text = r.Cells["MaLT"].Value.ToString();
            TxtHocPhan.Text = r.Cells["MaHP"].Value.ToString();
            txtMonHoc.Text = r.Cells["TenMH"].Value.ToString();
            txtPhongThi.Text = r.Cells["PhongThi"].Value.ToString();
            txtSiSo.Text = r.Cells["SiSoDuThi"].Value.ToString();
            cbHinhThuc.Text = r.Cells["HinhThuc"].Value.ToString();
            txtThoiLuong.Text = r.Cells["ThoiLuong"].Value.ToString();

            dtpNgayThi.Value = Convert.ToDateTime(r.Cells["NgayThi"].Value);

            TimeSpan gio = (TimeSpan)r.Cells["GioThi"].Value;
            dtpThoiGian.Value = DateTime.Today.Add(gio);
        }

        private void btThem_Click_1(object sender, EventArgs e)
        {
            DTO_LichThi lt = LayDuLieu();

            string kq = bus.Them(lt);

            if (kq == "")
            {
                MessageBox.Show("Thêm lịch thi thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(kq, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSua_Click_1(object sender, EventArgs e)
        {
            DTO_LichThi lt = LayDuLieu();

            string kq = bus.Sua(lt);

            if (kq == "")
            {
                MessageBox.Show("Sửa lịch thi thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(kq, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btXoa_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xoá lịch thi này không?",
                           "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            string kq = bus.Xoa(txtMaHP.Text.Trim());

            if (kq == "")
            {
                MessageBox.Show("Xoá lịch thi thành công.");
                LoadData();
                LamMoi();
            }
            else
            {
                MessageBox.Show(kq);
            }
        }

        private void btLamMoi_Click_1(object sender, EventArgs e)
        {
            LamMoi();
            LoadData();
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();

            if (tuKhoa == "")
            {
                LoadData();
                return;
            }

            dgvDSLT.DataSource = bus.TimKiem(tuKhoa);
            DinhDangGrid();
        }
    }
    
}