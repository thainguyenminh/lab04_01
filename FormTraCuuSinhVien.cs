
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using lab04_01.Models;

namespace lab04_01
{
    public partial class FormTraCuuSinhVien : Form
    {
        TextBox txtTuKhoa = new TextBox();
        ComboBox cboKhoa = new ComboBox();
        NumericUpDown numTu = new NumericUpDown();
        NumericUpDown numDen = new NumericUpDown();
        CheckBox chkChuaCoDiem = new CheckBox();
        Button btnXoaLoc = new Button();
        Button btnTim = new Button();
        Label lblKetQua = new Label();
        DataGridView dgvSinhVien = new DataGridView();

        public FormTraCuuSinhVien()
        {
            InitializeComponent();
            TaoGiaoDien();
            Load += FormTraCuuSinhVien_Load;
        }

        private void TaoGiaoDien()
        {
            Text = "Tra cứu Sinh viên";
            Size = new Size(850, 520);
            StartPosition = FormStartPosition.CenterScreen;

            Label lblTieuDe = new Label()
            {
                Text = "TRA CỨU SINH VIÊN",
                Font = new Font("Arial", 16, FontStyle.Bold),
                ForeColor = Color.RoyalBlue,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 55
            };
            Controls.Add(lblTieuDe);

            Label lblMa = new Label()
            {
                Text = "Mã SV / Họ tên:",
                Location = new Point(20, 75),
                AutoSize = true
            };
            Controls.Add(lblMa);

            txtTuKhoa.Location = new Point(140, 72);
            txtTuKhoa.Size = new Size(220, 25);
            Controls.Add(txtTuKhoa);

            Label lblKhoa = new Label()
            {
                Text = "Khoa:",
                Location = new Point(20, 112),
                AutoSize = true
            };
            Controls.Add(lblKhoa);

            cboKhoa.Location = new Point(140, 108);
            cboKhoa.Size = new Size(220, 25);
            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            Controls.Add(cboKhoa);

            Label lblTu = new Label()
            {
                Text = "Điểm TB từ:",
                Location = new Point(20, 150),
                AutoSize = true
            };
            Controls.Add(lblTu);

            numTu.Location = new Point(140, 147);
            numTu.Size = new Size(90, 25);
            numTu.DecimalPlaces = 1;
            numTu.Minimum = 0;
            numTu.Maximum = 10;
            numTu.Value = 0;
            Controls.Add(numTu);

            Label lblDen = new Label()
            {
                Text = "đến:",
                Location = new Point(265, 150),
                AutoSize = true
            };
            Controls.Add(lblDen);

            numDen.Location = new Point(310, 147);
            numDen.Size = new Size(90, 25);
            numDen.DecimalPlaces = 1;
            numDen.Minimum = 0;
            numDen.Maximum = 10;
            numDen.Value = 10;
            Controls.Add(numDen);

            chkChuaCoDiem.Text = "Bao gồm SV chưa có điểm";
            chkChuaCoDiem.Location = new Point(20, 185);
            chkChuaCoDiem.AutoSize = true;
            chkChuaCoDiem.Checked = true;
            Controls.Add(chkChuaCoDiem);

            btnTim.Text = "Tìm kiếm";
            btnTim.Location = new Point(230, 180);
            btnTim.Size = new Size(90, 30);
            btnTim.Click += (s, e) => TimKiemSinhVien();
            Controls.Add(btnTim);

            btnXoaLoc.Text = "Xóa bộ lọc";
            btnXoaLoc.Location = new Point(330, 180);
            btnXoaLoc.Size = new Size(100, 30);
            btnXoaLoc.Click += (s, e) => XoaBoLoc();
            Controls.Add(btnXoaLoc);

            lblKetQua.Text = "Tìm thấy: 0 sinh viên";
            lblKetQua.Location = new Point(20, 225);
            lblKetQua.AutoSize = true;
            lblKetQua.ForeColor = Color.RoyalBlue;
            lblKetQua.Font = new Font("Arial", 10, FontStyle.Bold);
            Controls.Add(lblKetQua);

            dgvSinhVien.Location = new Point(20, 255);
            dgvSinhVien.Size = new Size(790, 210);
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.MultiSelect = false;
            Controls.Add(dgvSinhVien);
        }

        private void FormTraCuuSinhVien_Load(
            object? sender, EventArgs e)
        {
            try
            {
                using var db = new QuanLySinhVienDbContext();

                var dsKhoa = db.Khoas
                    .OrderBy(k => k.TenKhoa)
                    .ToList();

                dsKhoa.Insert(0, new Khoa
                {
                    Id = 0,
                    TenKhoa = "-- Tất cả Khoa --"
                });

                cboKhoa.DisplayMember = "TenKhoa";
                cboKhoa.ValueMember = "Id";
                cboKhoa.DataSource = dsKhoa;
                cboKhoa.SelectedIndex = 0;

                TimKiemSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tải dữ liệu: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void TimKiemSinhVien()
        {
            try
            {
                if (numTu.Value > numDen.Value)
                {
                    MessageBox.Show(
                        "Điểm từ không được lớn hơn điểm đến!");
                    return;
                }

                using var db = new QuanLySinhVienDbContext();

                var ds = db.SinhViens
                    .Include(sv => sv.Khoa)
                    .AsEnumerable()
                    .ToList();

                string tuKhoa = txtTuKhoa.Text.Trim();

                // Tìm theo mã sinh viên hoặc họ tên
                if (!string.IsNullOrWhiteSpace(tuKhoa))
                {
                    ds = ds.Where(sv =>
                        (sv.MaSV != null &&
                         sv.MaSV.Contains(
                             tuKhoa,
                             StringComparison.OrdinalIgnoreCase))
                        ||
                        (sv.HoTen != null &&
                         sv.HoTen.Contains(
                             tuKhoa,
                             StringComparison.OrdinalIgnoreCase))
                    ).ToList();
                }

                // Lọc theo khoa
                if (cboKhoa.SelectedValue != null)
                {
                    int idKhoa = Convert.ToInt32(
                        cboKhoa.SelectedValue);

                    if (idKhoa != 0)
                    {
                        ds = ds.Where(sv =>
                            sv.KhoaId == idKhoa).ToList();
                    }
                }

                // Lọc theo điểm trung bình
                double diemTu = Convert.ToDouble(numTu.Value);
                double diemDen = Convert.ToDouble(numDen.Value);

                ds = ds.Where(sv =>
                    (sv.DiemTB.HasValue &&
                     sv.DiemTB.Value >= diemTu &&
                     sv.DiemTB.Value <= diemDen)
                    ||
                    (chkChuaCoDiem.Checked &&
                     !sv.DiemTB.HasValue)
                ).ToList();

                // Hiển thị kết quả
                dgvSinhVien.DataSource = ds.Select(sv => new
                {
                    sv.Id,
                    sv.MaSV,
                    sv.HoTen,
                    NgaySinh = sv.NgaySinh.ToString("dd/MM/yyyy"),
                    sv.GioiTinh,
                    DiemTB = sv.DiemTB.HasValue
                        ? sv.DiemTB.Value.ToString("0.0")
                        : "Chưa có điểm",
                    Khoa = sv.Khoa == null
                        ? ""
                        : sv.Khoa.TenKhoa
                }).ToList();

                lblKetQua.Text =
                    "Tìm thấy: " + ds.Count + " sinh viên";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi tra cứu: " + ex.Message,
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void XoaBoLoc()
        {
            txtTuKhoa.Clear();

            if (cboKhoa.Items.Count > 0)
                cboKhoa.SelectedIndex = 0;

            numTu.Value = 0;
            numDen.Value = 10;
            chkChuaCoDiem.Checked = true;

            TimKiemSinhVien();
        }
    }
}

