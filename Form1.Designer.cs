namespace lab04_01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            tệpToolStripMenuItem = new ToolStripMenuItem();
            dữLiệuToolStripMenuItem = new ToolStripMenuItem();
            mnuQuanLyKhoa = new ToolStripMenuItem();
            pnlQuanLyThongTinSV = new Panel();
            lblQuanLyThongTinSV = new Label();
            statusStrip1 = new StatusStrip();
            tslblSanSang = new ToolStripStatusLabel();
            tslblTongSo = new ToolStripStatusLabel();
            gpbThongTinSinhVien = new GroupBox();
            btnLamMoi = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnCong = new Button();
            txtDiemTB = new TextBox();
            cboKhoa = new ComboBox();
            radNu = new RadioButton();
            radNam = new RadioButton();
            dtpNgaySinh = new DateTimePicker();
            txtHoTen = new TextBox();
            txtMaSoSV = new TextBox();
            lblDiemTB = new Label();
            lblKhoa = new Label();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            lblHoTen = new Label();
            lblMaSoSV = new Label();
            dataGridView1 = new DataGridView();
            MaSV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            Khoa = new DataGridViewTextBoxColumn();
            DiemTB = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            pnlQuanLyThongTinSV.SuspendLayout();
            statusStrip1.SuspendLayout();
            gpbThongTinSinhVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tệpToolStripMenuItem, dữLiệuToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(986, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tệpToolStripMenuItem
            // 
            tệpToolStripMenuItem.Name = "tệpToolStripMenuItem";
            tệpToolStripMenuItem.Size = new Size(39, 20);
            tệpToolStripMenuItem.Text = "Tệp";
            // 
            // dữLiệuToolStripMenuItem
            // 
            dữLiệuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuQuanLyKhoa });
            dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            dữLiệuToolStripMenuItem.Size = new Size(56, 20);
            dữLiệuToolStripMenuItem.Text = "Dữ liệu";
            // 
            // mnuQuanLyKhoa
            // 
            mnuQuanLyKhoa.Name = "mnuQuanLyKhoa";
            mnuQuanLyKhoa.ShortcutKeys = Keys.F1;
            mnuQuanLyKhoa.Size = new Size(180, 22);
            mnuQuanLyKhoa.Text = "Quản lý khoa";
            // 
            // pnlQuanLyThongTinSV
            // 
            pnlQuanLyThongTinSV.BackColor = Color.FromArgb(232, 240, 254);
            pnlQuanLyThongTinSV.Controls.Add(lblQuanLyThongTinSV);
            pnlQuanLyThongTinSV.Dock = DockStyle.Top;
            pnlQuanLyThongTinSV.Location = new Point(0, 24);
            pnlQuanLyThongTinSV.Margin = new Padding(3, 2, 3, 2);
            pnlQuanLyThongTinSV.Name = "pnlQuanLyThongTinSV";
            pnlQuanLyThongTinSV.Size = new Size(986, 74);
            pnlQuanLyThongTinSV.TabIndex = 1;
            // 
            // lblQuanLyThongTinSV
            // 
            lblQuanLyThongTinSV.AutoSize = true;
            lblQuanLyThongTinSV.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuanLyThongTinSV.ForeColor = Color.FromArgb(13, 17, 161);
            lblQuanLyThongTinSV.Location = new Point(340, 19);
            lblQuanLyThongTinSV.Name = "lblQuanLyThongTinSV";
            lblQuanLyThongTinSV.Size = new Size(324, 32);
            lblQuanLyThongTinSV.TabIndex = 0;
            lblQuanLyThongTinSV.Text = "Quản lý thông tin sinh viên";
            lblQuanLyThongTinSV.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslblSanSang, tslblTongSo });
            statusStrip1.Location = new Point(0, 522);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(986, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslblSanSang
            // 
            tslblSanSang.Name = "tslblSanSang";
            tslblSanSang.Size = new Size(923, 17);
            tslblSanSang.Spring = true;
            tslblSanSang.Text = "Sẵn sàng";
            tslblSanSang.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tslblTongSo
            // 
            tslblTongSo.Name = "tslblTongSo";
            tslblTongSo.Size = new Size(50, 17);
            tslblTongSo.Text = "Tổng số";
            // 
            // gpbThongTinSinhVien
            // 
            gpbThongTinSinhVien.Controls.Add(btnLamMoi);
            gpbThongTinSinhVien.Controls.Add(btnSua);
            gpbThongTinSinhVien.Controls.Add(btnXoa);
            gpbThongTinSinhVien.Controls.Add(btnThem);
            gpbThongTinSinhVien.Controls.Add(btnCong);
            gpbThongTinSinhVien.Controls.Add(txtDiemTB);
            gpbThongTinSinhVien.Controls.Add(cboKhoa);
            gpbThongTinSinhVien.Controls.Add(radNu);
            gpbThongTinSinhVien.Controls.Add(radNam);
            gpbThongTinSinhVien.Controls.Add(dtpNgaySinh);
            gpbThongTinSinhVien.Controls.Add(txtHoTen);
            gpbThongTinSinhVien.Controls.Add(txtMaSoSV);
            gpbThongTinSinhVien.Controls.Add(lblDiemTB);
            gpbThongTinSinhVien.Controls.Add(lblKhoa);
            gpbThongTinSinhVien.Controls.Add(lblGioiTinh);
            gpbThongTinSinhVien.Controls.Add(lblNgaySinh);
            gpbThongTinSinhVien.Controls.Add(lblHoTen);
            gpbThongTinSinhVien.Controls.Add(lblMaSoSV);
            gpbThongTinSinhVien.Dock = DockStyle.Left;
            gpbThongTinSinhVien.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gpbThongTinSinhVien.ForeColor = SystemColors.ControlText;
            gpbThongTinSinhVien.Location = new Point(0, 98);
            gpbThongTinSinhVien.Margin = new Padding(3, 2, 3, 2);
            gpbThongTinSinhVien.Name = "gpbThongTinSinhVien";
            gpbThongTinSinhVien.Padding = new Padding(3, 2, 3, 2);
            gpbThongTinSinhVien.Size = new Size(219, 424);
            gpbThongTinSinhVien.TabIndex = 3;
            gpbThongTinSinhVien.TabStop = false;
            gpbThongTinSinhVien.Text = "Thông tin sinh viên";
            gpbThongTinSinhVien.Enter += gpbThongTinSinhVien_Enter;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.DarkGray;
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(108, 380);
            btnLamMoi.Margin = new Padding(3, 2, 3, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(82, 36);
            btnLamMoi.TabIndex = 17;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Blue;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(108, 333);
            btnSua.Margin = new Padding(3, 2, 3, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(82, 36);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(10, 380);
            btnXoa.Margin = new Padding(3, 2, 3, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(81, 36);
            btnXoa.TabIndex = 15;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 192, 0);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(10, 333);
            btnThem.Margin = new Padding(3, 2, 3, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(81, 36);
            btnThem.TabIndex = 14;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnCong
            // 
            btnCong.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCong.Location = new Point(178, 241);
            btnCong.Margin = new Padding(3, 2, 3, 2);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(35, 28);
            btnCong.TabIndex = 13;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(10, 300);
            txtDiemTB.Margin = new Padding(3, 2, 3, 2);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(110, 23);
            txtDiemTB.TabIndex = 12;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(10, 247);
            cboKhoa.Margin = new Padding(3, 2, 3, 2);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(163, 23);
            cboKhoa.TabIndex = 11;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(74, 200);
            radNu.Margin = new Padding(3, 2, 3, 2);
            radNu.Name = "radNu";
            radNu.Size = new Size(42, 19);
            radNu.TabIndex = 10;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(10, 200);
            radNam.Margin = new Padding(3, 2, 3, 2);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 9;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(10, 143);
            dtpNgaySinh.Margin = new Padding(3, 2, 3, 2);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(204, 23);
            dtpNgaySinh.TabIndex = 8;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(10, 92);
            txtHoTen.Margin = new Padding(3, 2, 3, 2);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(204, 23);
            txtHoTen.TabIndex = 7;
            // 
            // txtMaSoSV
            // 
            txtMaSoSV.Location = new Point(10, 45);
            txtMaSoSV.Margin = new Padding(3, 2, 3, 2);
            txtMaSoSV.Name = "txtMaSoSV";
            txtMaSoSV.Size = new Size(204, 23);
            txtMaSoSV.TabIndex = 6;
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Font = new Font("Segoe UI", 9F);
            lblDiemTB.Location = new Point(10, 283);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(52, 15);
            lblDiemTB.TabIndex = 5;
            lblDiemTB.Text = "Điểm TB";
            lblDiemTB.Click += lblDiemTB_Click;
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Font = new Font("Segoe UI", 9F);
            lblKhoa.Location = new Point(10, 230);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(34, 15);
            lblKhoa.TabIndex = 4;
            lblKhoa.Text = "Khoa";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI", 9F);
            lblGioiTinh.Location = new Point(10, 176);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(52, 15);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI", 9F);
            lblNgaySinh.Location = new Point(10, 126);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(60, 15);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Font = new Font("Segoe UI", 9F);
            lblHoTen.Location = new Point(10, 74);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(43, 15);
            lblHoTen.TabIndex = 1;
            lblHoTen.Text = "Họ tên";
            // 
            // lblMaSoSV
            // 
            lblMaSoSV.AutoSize = true;
            lblMaSoSV.Font = new Font("Segoe UI", 9F);
            lblMaSoSV.Location = new Point(10, 28);
            lblMaSoSV.Name = "lblMaSoSV";
            lblMaSoSV.Size = new Size(55, 15);
            lblMaSoSV.TabIndex = 0;
            lblMaSoSV.Text = "Mã số SV";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(13, 71, 161);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSV, HoTen, NgaySinh, GioiTinh, Khoa, DiemTB });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(219, 100);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(767, 107);
            dataGridView1.TabIndex = 4;
            // 
            // MaSV
            // 
            MaSV.HeaderText = "Mã SV";
            MaSV.MinimumWidth = 6;
            MaSV.Name = "MaSV";
            MaSV.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ và tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // NgaySinh
            // 
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.MinimumWidth = 6;
            NgaySinh.Name = "NgaySinh";
            NgaySinh.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // Khoa
            // 
            Khoa.HeaderText = "Khoa";
            Khoa.MinimumWidth = 6;
            Khoa.Name = "Khoa";
            Khoa.ReadOnly = true;
            // 
            // DiemTB
            // 
            DiemTB.HeaderText = "Điểm TB";
            DiemTB.MinimumWidth = 6;
            DiemTB.Name = "DiemTB";
            DiemTB.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(986, 544);
            Controls.Add(dataGridView1);
            Controls.Add(gpbThongTinSinhVien);
            Controls.Add(statusStrip1);
            Controls.Add(pnlQuanLyThongTinSV);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlQuanLyThongTinSV.ResumeLayout(false);
            pnlQuanLyThongTinSV.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            gpbThongTinSinhVien.ResumeLayout(false);
            gpbThongTinSinhVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tệpToolStripMenuItem;
        private ToolStripMenuItem dữLiệuToolStripMenuItem;
        private Panel pnlQuanLyThongTinSV;
        private Label lblQuanLyThongTinSV;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel tslblSanSang;
        private GroupBox gpbThongTinSinhVien;
        private Label lblKhoa;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private Label lblHoTen;
        private Label lblMaSoSV;
        private Label lblDiemTB;
        private RadioButton radNu;
        private RadioButton radNam;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtHoTen;
        private TextBox txtMaSoSV;
        private ComboBox cboKhoa;
        private TextBox txtDiemTB;
        private Button btnLamMoi;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Button btnCong;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaSV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn Khoa;
        private DataGridViewTextBoxColumn DiemTB;
        private ToolStripStatusLabel tslblTongSo;
        private ToolStripMenuItem mnuQuanLyKhoa;
    }
}
