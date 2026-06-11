namespace BTL_QLNhanSuXayDung.GUI
{
    partial class FormChamCong
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
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.labelTrangThai = new System.Windows.Forms.Label();
            this.dtpNgayCham = new System.Windows.Forms.DateTimePicker();
            this.labelNgayCham = new System.Windows.Forms.Label();
            this.cboCongTrinh = new System.Windows.Forms.ComboBox();
            this.labelCongTrinh = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvChamCong = new System.Windows.Forms.DataGridView();
            this.groupBoxThongTin.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.labelTieuDe.Location = new System.Drawing.Point(214, 12);
            this.labelTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(286, 30);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "CHẤM CÔNG HẰNG NGÀY";
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.txtGhiChu);
            this.groupBoxThongTin.Controls.Add(this.labelGhiChu);
            this.groupBoxThongTin.Controls.Add(this.cboTrangThai);
            this.groupBoxThongTin.Controls.Add(this.labelTrangThai);
            this.groupBoxThongTin.Controls.Add(this.dtpNgayCham);
            this.groupBoxThongTin.Controls.Add(this.labelNgayCham);
            this.groupBoxThongTin.Controls.Add(this.cboCongTrinh);
            this.groupBoxThongTin.Controls.Add(this.labelCongTrinh);
            this.groupBoxThongTin.Controls.Add(this.cboNhanVien);
            this.groupBoxThongTin.Controls.Add(this.labelNhanVien);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxThongTin.Location = new System.Drawing.Point(12, 53);
            this.groupBoxThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThongTin.Size = new System.Drawing.Size(675, 114);
            this.groupBoxThongTin.TabIndex = 1;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin nhật ký chấm công";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(326, 69);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(335, 23);
            this.txtGhiChu.TabIndex = 9;
            // 
            // labelGhiChu
            // 
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Location = new System.Drawing.Point(255, 72);
            this.labelGhiChu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(51, 15);
            this.labelGhiChu.TabIndex = 8;
            this.labelGhiChu.Text = "Ghi chú:";
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Location = new System.Drawing.Point(82, 69);
            this.cboTrangThai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(151, 23);
            this.cboTrangThai.TabIndex = 7;
            // 
            // labelTrangThai
            // 
            this.labelTrangThai.AutoSize = true;
            this.labelTrangThai.Location = new System.Drawing.Point(15, 72);
            this.labelTrangThai.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrangThai.Name = "labelTrangThai";
            this.labelTrangThai.Size = new System.Drawing.Size(62, 15);
            this.labelTrangThai.TabIndex = 6;
            this.labelTrangThai.Text = "Trạng thái:";
            // 
            // dtpNgayCham
            // 
            this.dtpNgayCham.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCham.Location = new System.Drawing.Point(555, 32);
            this.dtpNgayCham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpNgayCham.Name = "dtpNgayCham";
            this.dtpNgayCham.Size = new System.Drawing.Size(106, 23);
            this.dtpNgayCham.TabIndex = 5;
            // 
            // labelNgayCham
            // 
            this.labelNgayCham.AutoSize = true;
            this.labelNgayCham.Location = new System.Drawing.Point(510, 35);
            this.labelNgayCham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNgayCham.Name = "labelNgayCham";
            this.labelNgayCham.Size = new System.Drawing.Size(38, 15);
            this.labelNgayCham.TabIndex = 4;
            this.labelNgayCham.Text = "Ngày:";
            // 
            // cboCongTrinh
            // 
            this.cboCongTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCongTrinh.FormattingEnabled = true;
            this.cboCongTrinh.Location = new System.Drawing.Point(326, 32);
            this.cboCongTrinh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboCongTrinh.Name = "cboCongTrinh";
            this.cboCongTrinh.Size = new System.Drawing.Size(166, 23);
            this.cboCongTrinh.TabIndex = 3;
            // 
            // labelCongTrinh
            // 
            this.labelCongTrinh.AutoSize = true;
            this.labelCongTrinh.Location = new System.Drawing.Point(255, 35);
            this.labelCongTrinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCongTrinh.Name = "labelCongTrinh";
            this.labelCongTrinh.Size = new System.Drawing.Size(67, 15);
            this.labelCongTrinh.TabIndex = 2;
            this.labelCongTrinh.Text = "Công trình:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(82, 32);
            this.cboNhanVien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(151, 23);
            this.cboNhanVien.TabIndex = 1;
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.AutoSize = true;
            this.labelNhanVien.Location = new System.Drawing.Point(15, 35);
            this.labelNhanVien.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Size = new System.Drawing.Size(64, 15);
            this.labelNhanVien.TabIndex = 0;
            this.labelNhanVien.Text = "Nhân viên:";
            // 
            // groupBoxChucNang
            // 
            this.groupBoxChucNang.Controls.Add(this.btnTimKiem);
            this.groupBoxChucNang.Controls.Add(this.txtTimKiem);
            this.groupBoxChucNang.Controls.Add(this.btnLamMoi);
            this.groupBoxChucNang.Controls.Add(this.btnXoa);
            this.groupBoxChucNang.Controls.Add(this.btnSua);
            this.groupBoxChucNang.Controls.Add(this.btnThem);
            this.groupBoxChucNang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxChucNang.Location = new System.Drawing.Point(12, 175);
            this.groupBoxChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChucNang.Size = new System.Drawing.Size(675, 61);
            this.groupBoxChucNang.TabIndex = 2;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Thao tác dữ liệu";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(565, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(106, 28);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm (F5)";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(393, 25);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(168, 23);
            this.txtTimKiem.TabIndex = 4;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(236, 22);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(103, 28);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới (F4)";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(161, 22);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 28);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa (F3)";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(86, 22);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 28);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa (F2)";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(11, 22);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(68, 28);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm (F1)";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvChamCong
            // 
            this.dgvChamCong.AllowUserToAddRows = false;
            this.dgvChamCong.AllowUserToDeleteRows = false;
            this.dgvChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChamCong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChamCong.Location = new System.Drawing.Point(12, 248);
            this.dgvChamCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChamCong.Name = "dgvChamCong";
            this.dgvChamCong.ReadOnly = true;
            this.dgvChamCong.RowHeadersWidth = 51;
            this.dgvChamCong.RowTemplate.Height = 24;
            this.dgvChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChamCong.Size = new System.Drawing.Size(675, 219);
            this.dgvChamCong.TabIndex = 3;
            this.dgvChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChamCong_CellClick);
            // 
            // FormChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 482);
            this.Controls.Add(this.dgvChamCong);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.labelTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Nhật Ký Chấm Công";
            this.Load += new System.EventHandler(this.FormChamCong_Load);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChamCong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTieuDe;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label labelNhanVien;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.Label labelCongTrinh;
        private System.Windows.Forms.ComboBox cboCongTrinh;
        private System.Windows.Forms.DateTimePicker dtpNgayCham;
        private System.Windows.Forms.Label labelNgayCham;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label labelTrangThai;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label labelGhiChu;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvChamCong;
    }
}