namespace GUI_QLSV
{
    partial class FrmQLLichThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.btLamMoi = new System.Windows.Forms.Button();
            this.txtMaHP = new System.Windows.Forms.TextBox();
            this.btSua = new System.Windows.Forms.Button();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtPhongThi = new System.Windows.Forms.TextBox();
            this.txtSiSo = new System.Windows.Forms.TextBox();
            this.dtpNgayThi = new System.Windows.Forms.DateTimePicker();
            this.dtpThoiGian = new System.Windows.Forms.DateTimePicker();
            this.txtMonHoc = new System.Windows.Forms.TextBox();
            this.TxtHocPhan = new System.Windows.Forms.TextBox();
            this.cbHinhThuc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btXoa = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvDSLT = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(22, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "QUẢN LÝ LỊCH THI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày thi:";
            // 
            // btThem
            // 
            this.btThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.btThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThem.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btThem.ForeColor = System.Drawing.Color.White;
            this.btThem.Location = new System.Drawing.Point(44, 546);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(137, 37);
            this.btThem.TabIndex = 1;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = false;
            this.btThem.Click += new System.EventHandler(this.btThem_Click_1);
            // 
            // btLamMoi
            // 
            this.btLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.btLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLamMoi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btLamMoi.ForeColor = System.Drawing.Color.Transparent;
            this.btLamMoi.Location = new System.Drawing.Point(469, 546);
            this.btLamMoi.Name = "btLamMoi";
            this.btLamMoi.Size = new System.Drawing.Size(137, 38);
            this.btLamMoi.TabIndex = 3;
            this.btLamMoi.Text = "Làm mới";
            this.btLamMoi.UseVisualStyleBackColor = false;
            this.btLamMoi.Click += new System.EventHandler(this.btLamMoi_Click_1);
            // 
            // txtMaHP
            // 
            this.txtMaHP.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHP.Location = new System.Drawing.Point(195, 36);
            this.txtMaHP.Multiline = true;
            this.txtMaHP.Name = "txtMaHP";
            this.txtMaHP.ReadOnly = true;
            this.txtMaHP.Size = new System.Drawing.Size(344, 37);
            this.txtMaHP.TabIndex = 2;
            // 
            // btSua
            // 
            this.btSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSua.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSua.ForeColor = System.Drawing.Color.White;
            this.btSua.Location = new System.Drawing.Point(260, 547);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(137, 37);
            this.btSua.TabIndex = 1;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = false;
            this.btSua.Click += new System.EventHandler(this.btSua_Click_1);
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.btTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTimKiem.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btTimKiem.ForeColor = System.Drawing.Color.White;
            this.btTimKiem.Location = new System.Drawing.Point(636, 37);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(128, 38);
            this.btTimKiem.TabIndex = 1;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.btThem);
            this.panel1.Controls.Add(this.btSua);
            this.panel1.Controls.Add(this.btLamMoi);
            this.panel1.Location = new System.Drawing.Point(930, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 713);
            this.panel1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtThoiLuong);
            this.groupBox1.Controls.Add(this.txtPhongThi);
            this.groupBox1.Controls.Add(this.txtSiSo);
            this.groupBox1.Controls.Add(this.dtpNgayThi);
            this.groupBox1.Controls.Add(this.dtpThoiGian);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMonHoc);
            this.groupBox1.Controls.Add(this.TxtHocPhan);
            this.groupBox1.Controls.Add(this.txtMaHP);
            this.groupBox1.Controls.Add(this.cbHinhThuc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.groupBox1.Location = new System.Drawing.Point(35, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 486);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG TIN LỊCH THI";
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThoiLuong.Location = new System.Drawing.Point(195, 438);
            this.txtThoiLuong.Multiline = true;
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(121, 37);
            this.txtThoiLuong.TabIndex = 10;
            // 
            // txtPhongThi
            // 
            this.txtPhongThi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhongThi.Location = new System.Drawing.Point(195, 319);
            this.txtPhongThi.Multiline = true;
            this.txtPhongThi.Name = "txtPhongThi";
            this.txtPhongThi.Size = new System.Drawing.Size(121, 37);
            this.txtPhongThi.TabIndex = 10;
            // 
            // txtSiSo
            // 
            this.txtSiSo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSiSo.Location = new System.Drawing.Point(434, 325);
            this.txtSiSo.Multiline = true;
            this.txtSiSo.Name = "txtSiSo";
            this.txtSiSo.Size = new System.Drawing.Size(121, 37);
            this.txtSiSo.TabIndex = 10;
            // 
            // dtpNgayThi
            // 
            this.dtpNgayThi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpNgayThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThi.Location = new System.Drawing.Point(195, 267);
            this.dtpNgayThi.Name = "dtpNgayThi";
            this.dtpNgayThi.Size = new System.Drawing.Size(215, 31);
            this.dtpNgayThi.TabIndex = 8;
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.CustomFormat = "HH:ss";
            this.dtpThoiGian.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpThoiGian.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThoiGian.Location = new System.Drawing.Point(195, 208);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Size = new System.Drawing.Size(215, 31);
            this.dtpThoiGian.TabIndex = 8;
            // 
            // txtMonHoc
            // 
            this.txtMonHoc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMonHoc.Location = new System.Drawing.Point(195, 147);
            this.txtMonHoc.Multiline = true;
            this.txtMonHoc.Name = "txtMonHoc";
            this.txtMonHoc.ReadOnly = true;
            this.txtMonHoc.Size = new System.Drawing.Size(344, 37);
            this.txtMonHoc.TabIndex = 2;
            // 
            // TxtHocPhan
            // 
            this.TxtHocPhan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TxtHocPhan.Location = new System.Drawing.Point(195, 95);
            this.TxtHocPhan.Multiline = true;
            this.TxtHocPhan.Name = "TxtHocPhan";
            this.TxtHocPhan.ReadOnly = true;
            this.TxtHocPhan.Size = new System.Drawing.Size(344, 37);
            this.TxtHocPhan.TabIndex = 2;
            // 
            // cbHinhThuc
            // 
            this.cbHinhThuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbHinhThuc.FormattingEnabled = true;
            this.cbHinhThuc.Location = new System.Drawing.Point(195, 375);
            this.cbHinhThuc.Name = "cbHinhThuc";
            this.cbHinhThuc.Size = new System.Drawing.Size(182, 33);
            this.cbHinhThuc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(34, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Thời lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(34, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hình thức:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(34, 331);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 25);
            this.label10.TabIndex = 0;
            this.label10.Text = "Phòng thi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(356, 331);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Sĩ số:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(34, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Môn học:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(34, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Thời gian:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(34, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Học phần:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(34, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lịch thi:";
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btXoa.ForeColor = System.Drawing.Color.White;
            this.btXoa.Location = new System.Drawing.Point(469, 608);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(137, 37);
            this.btXoa.TabIndex = 1;
            this.btXoa.Text = "Xoá";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click_1);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTimKiem.Location = new System.Drawing.Point(22, 37);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(534, 37);
            this.txtTimKiem.TabIndex = 2;
            // 
            // dgvDSLT
            // 
            this.dgvDSLT.AllowUserToAddRows = false;
            this.dgvDSLT.AllowUserToDeleteRows = false;
            this.dgvDSLT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSLT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDSLT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSLT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(241)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(35)))), ((int)(((byte)(77)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSLT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDSLT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSLT.DefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDSLT.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSLT.Location = new System.Drawing.Point(3, 86);
            this.dgvDSLT.Name = "dgvDSLT";
            this.dgvDSLT.ReadOnly = true;
            this.dgvDSLT.RowHeadersWidth = 62;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.dgvDSLT.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDSLT.RowTemplate.Height = 28;
            this.dgvDSLT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSLT.Size = new System.Drawing.Size(889, 593);
            this.dgvDSLT.TabIndex = 0;
            this.dgvDSLT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSLT_CellClick_1);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btTimKiem);
            this.groupBox3.Controls.Add(this.dgvDSLT);
            this.groupBox3.Controls.Add(this.txtTimKiem);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.groupBox3.Location = new System.Drawing.Point(29, 69);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(895, 682);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DANH SÁCH LỊCH THI";
            // 
            // FrmQLLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 1040);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQLLichThi";
            this.Text = "FrmQLLichThi";
            this.Load += new System.EventHandler(this.FrmQLLichThi_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Button btLamMoi;
        private System.Windows.Forms.TextBox txtMaHP;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvDSLT;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpNgayThi;
        private System.Windows.Forms.DateTimePicker dtpThoiGian;
        private System.Windows.Forms.TextBox txtSiSo;
        private System.Windows.Forms.ComboBox cbHinhThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMonHoc;
        private System.Windows.Forms.TextBox TxtHocPhan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPhongThi;
        private System.Windows.Forms.Label label10;
    }
}