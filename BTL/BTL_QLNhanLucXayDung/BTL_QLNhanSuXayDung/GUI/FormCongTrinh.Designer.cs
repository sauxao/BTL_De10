namespace BTL_QLNhanSuXayDung.GUI
{
    partial class FormCongTrinh
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTieude = new System.Windows.Forms.Label();
            this.groupBoxTimKiem = new System.Windows.Forms.GroupBox();
            this.btnHienThiTatCa = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.lblTuKhoa = new System.Windows.Forms.Label();
            this.dgvCongTrinh = new System.Windows.Forms.DataGridView();
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.dtpNgayDuKien = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKhoiCong = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayCapPhep = new System.Windows.Forms.DateTimePicker();
            this.txtDiaDiem = new System.Windows.Forms.TextBox();
            this.txtTenCongTrinh = new System.Windows.Forms.TextBox();
            this.txtMaCongTrinh = new System.Windows.Forms.TextBox();
            this.lblNgayDuKien = new System.Windows.Forms.Label();
            this.lblNgayKhoiCong = new System.Windows.Forms.Label();
            this.lblNgayCapPhep = new System.Windows.Forms.Label();
            this.lblDiaDiem = new System.Windows.Forms.Label();
            this.lblTenCT = new System.Windows.Forms.Label();
            this.lblMaCT = new System.Windows.Forms.Label();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBoxTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTrinh)).BeginInit();
            this.groupBoxThongTin.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.ForeColor = System.Drawing.Color.Blue;
            this.lblTieude.Location = new System.Drawing.Point(12, 9);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(395, 26);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "QUẢN LÝ THÔNG TIN CÔNG TRÌNH";
            // 
            // groupBoxTimKiem
            // 
            this.groupBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTimKiem.Controls.Add(this.btnHienThiTatCa);
            this.groupBoxTimKiem.Controls.Add(this.btnTimKiem);
            this.groupBoxTimKiem.Controls.Add(this.txtTimKiem);
            this.groupBoxTimKiem.Controls.Add(this.lblTuKhoa);
            this.groupBoxTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTimKiem.Location = new System.Drawing.Point(17, 45);
            this.groupBoxTimKiem.Name = "groupBoxTimKiem";
            this.groupBoxTimKiem.Size = new System.Drawing.Size(950, 65);
            this.groupBoxTimKiem.TabIndex = 1;
            this.groupBoxTimKiem.TabStop = false;
            this.groupBoxTimKiem.Text = "Bộ lọc tìm kiếm";
            // 
            // btnHienThiTatCa
            // 
            this.btnHienThiTatCa.Location = new System.Drawing.Point(544, 23);
            this.btnHienThiTatCa.Name = "btnHienThiTatCa";
            this.btnHienThiTatCa.Size = new System.Drawing.Size(125, 28);
            this.btnHienThiTatCa.TabIndex = 3;
            this.btnHienThiTatCa.Text = "&Tất cả";
            this.btnHienThiTatCa.UseVisualStyleBackColor = true;
            this.btnHienThiTatCa.Click += new System.EventHandler(this.btnHienThiTatCa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(423, 23);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(105, 28);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(151, 26);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(254, 23);
            this.txtTimKiem.TabIndex = 1;
            // 
            // lblTuKhoa
            // 
            this.lblTuKhoa.AutoSize = true;
            this.lblTuKhoa.Location = new System.Drawing.Point(19, 29);
            this.lblTuKhoa.Name = "lblTuKhoa";
            this.lblTuKhoa.Size = new System.Drawing.Size(102, 17);
            this.lblTuKhoa.TabIndex = 0;
            this.lblTuKhoa.Text = "Từ khóa nhanh:";
            // 
            // dgvCongTrinh
            // 
            this.dgvCongTrinh.AllowUserToAddRows = false;
            this.dgvCongTrinh.AllowUserToDeleteRows = false;
            this.dgvCongTrinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCongTrinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCongTrinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCongTrinh.Location = new System.Drawing.Point(17, 340);
            this.dgvCongTrinh.Name = "dgvCongTrinh";
            this.dgvCongTrinh.ReadOnly = true;
            this.dgvCongTrinh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCongTrinh.Size = new System.Drawing.Size(950, 240);
            this.dgvCongTrinh.TabIndex = 4;
            this.dgvCongTrinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCongTrinh_CellClick);
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTin.Controls.Add(this.dtpNgayDuKien);
            this.groupBoxThongTin.Controls.Add(this.dtpNgayKhoiCong);
            this.groupBoxThongTin.Controls.Add(this.dtpNgayCapPhep);
            this.groupBoxThongTin.Controls.Add(this.txtDiaDiem);
            this.groupBoxThongTin.Controls.Add(this.txtTenCongTrinh);
            this.groupBoxThongTin.Controls.Add(this.txtMaCongTrinh);
            this.groupBoxThongTin.Controls.Add(this.lblNgayDuKien);
            this.groupBoxThongTin.Controls.Add(this.lblNgayKhoiCong);
            this.groupBoxThongTin.Controls.Add(this.lblNgayCapPhep);
            this.groupBoxThongTin.Controls.Add(this.lblDiaDiem);
            this.groupBoxThongTin.Controls.Add(this.lblTenCT);
            this.groupBoxThongTin.Controls.Add(this.lblMaCT);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTin.Location = new System.Drawing.Point(17, 120);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(950, 150);
            this.groupBoxThongTin.TabIndex = 2;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin chi tiết công trình";
            // 
            // dtpNgayDuKien
            // 
            this.dtpNgayDuKien.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDuKien.Location = new System.Drawing.Point(633, 105);
            this.dtpNgayDuKien.Name = "dtpNgayDuKien";
            this.dtpNgayDuKien.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayDuKien.TabIndex = 11;
            // 
            // dtpNgayKhoiCong
            // 
            this.dtpNgayKhoiCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKhoiCong.Location = new System.Drawing.Point(633, 68);
            this.dtpNgayKhoiCong.Name = "dtpNgayKhoiCong";
            this.dtpNgayKhoiCong.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayKhoiCong.TabIndex = 9;
            // 
            // dtpNgayCapPhep
            // 
            this.dtpNgayCapPhep.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayCapPhep.Location = new System.Drawing.Point(633, 29);
            this.dtpNgayCapPhep.Name = "dtpNgayCapPhep";
            this.dtpNgayCapPhep.Size = new System.Drawing.Size(200, 23);
            this.dtpNgayCapPhep.TabIndex = 7;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Location = new System.Drawing.Point(151, 105);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.Size = new System.Drawing.Size(300, 23);
            this.txtDiaDiem.TabIndex = 5;
            // 
            // txtTenCongTrinh
            // 
            this.txtTenCongTrinh.Location = new System.Drawing.Point(151, 68);
            this.txtTenCongTrinh.Name = "txtTenCongTrinh";
            this.txtTenCongTrinh.Size = new System.Drawing.Size(300, 23);
            this.txtTenCongTrinh.TabIndex = 3;
            // 
            // txtMaCongTrinh
            // 
            this.txtMaCongTrinh.Location = new System.Drawing.Point(151, 29);
            this.txtMaCongTrinh.Name = "txtMaCongTrinh";
            this.txtMaCongTrinh.Size = new System.Drawing.Size(150, 23);
            this.txtMaCongTrinh.TabIndex = 1;
            // 
            // lblNgayDuKien
            // 
            this.lblNgayDuKien.AutoSize = true;
            this.lblNgayDuKien.Location = new System.Drawing.Point(495, 110);
            this.lblNgayDuKien.Name = "lblNgayDuKien";
            this.lblNgayDuKien.Size = new System.Drawing.Size(125, 17);
            this.lblNgayDuKien.TabIndex = 10;
            this.lblNgayDuKien.Text = "Ngày hoàn thành *:";
            // 
            // lblNgayKhoiCong
            // 
            this.lblNgayKhoiCong.AutoSize = true;
            this.lblNgayKhoiCong.Location = new System.Drawing.Point(495, 71);
            this.lblNgayKhoiCong.Name = "lblNgayKhoiCong";
            this.lblNgayKhoiCong.Size = new System.Drawing.Size(121, 17);
            this.lblNgayKhoiCong.TabIndex = 8;
            this.lblNgayKhoiCong.Text = "Ngày khởi công *:";
            // 
            // lblNgayCapPhep
            // 
            this.lblNgayCapPhep.AutoSize = true;
            this.lblNgayCapPhep.Location = new System.Drawing.Point(495, 32);
            this.lblNgayCapPhep.Name = "lblNgayCapPhep";
            this.lblNgayCapPhep.Size = new System.Drawing.Size(113, 17);
            this.lblNgayCapPhep.TabIndex = 6;
            this.lblNgayCapPhep.Text = "Ngày cấp phép *:";
            // 
            // lblDiaDiem
            // 
            this.lblDiaDiem.AutoSize = true;
            this.lblDiaDiem.Location = new System.Drawing.Point(22, 108);
            this.lblDiaDiem.Name = "lblDiaDiem";
            this.lblDiaDiem.Size = new System.Drawing.Size(75, 17);
            this.lblDiaDiem.TabIndex = 4;
            this.lblDiaDiem.Text = "Địa điểm *:";
            // 
            // lblTenCT
            // 
            this.lblTenCT.AutoSize = true;
            this.lblTenCT.Location = new System.Drawing.Point(22, 71);
            this.lblTenCT.Name = "lblTenCT";
            this.lblTenCT.Size = new System.Drawing.Size(117, 17);
            this.lblTenCT.TabIndex = 2;
            this.lblTenCT.Text = "Tên công trình *:";
            // 
            // lblMaCT
            // 
            this.lblMaCT.AutoSize = true;
            this.lblMaCT.Location = new System.Drawing.Point(22, 32);
            this.lblMaCT.Name = "lblMaCT";
            this.lblMaCT.Size = new System.Drawing.Size(111, 17);
            this.lblMaCT.TabIndex = 0;
            this.lblMaCT.Text = "Mã công trình *:";
            // 
            // panelChucNang
            // 
            this.panelChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChucNang.Controls.Add(this.btnLamMoi);
            this.panelChucNang.Controls.Add(this.btnXoa);
            this.panelChucNang.Controls.Add(this.btnSua);
            this.panelChucNang.Controls.Add(this.btnThem);
            this.panelChucNang.Location = new System.Drawing.Point(17, 280);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(950, 45);
            this.panelChucNang.TabIndex = 3;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.Location = new System.Drawing.Point(375, 8);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 30);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "&Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(255, 8);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 30);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(135, 8);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 30);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "&Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(15, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormCongTrinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 596);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.dgvCongTrinh);
            this.Controls.Add(this.groupBoxTimKiem);
            this.Controls.Add(this.lblTieude);
            this.KeyPreview = true;
            this.Name = "FormCongTrinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hệ Thống Công Trình Xây Dựng";
            this.Load += new System.EventHandler(this.FormCongTrinh_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCongTrinh_KeyDown);
            this.groupBoxTimKiem.ResumeLayout(false);
            this.groupBoxTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCongTrinh)).EndInit();
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.panelChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.GroupBox groupBoxTimKiem;
        private System.Windows.Forms.Button btnHienThiTatCa;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label lblTuKhoa;
        private System.Windows.Forms.DataGridView dgvCongTrinh;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.Label lblNgayDuKien;
        private System.Windows.Forms.Label lblNgayKhoiCong;
        private System.Windows.Forms.Label lblNgayCapPhep;
        private System.Windows.Forms.Label lblDiaDiem;
        private System.Windows.Forms.Label lblTenCT;
        private System.Windows.Forms.Label lblMaCT;
        private System.Windows.Forms.DateTimePicker dtpNgayDuKien;
        private System.Windows.Forms.DateTimePicker dtpNgayKhoiCong;
        private System.Windows.Forms.DateTimePicker dtpNgayCapPhep;
        private System.Windows.Forms.TextBox txtDiaDiem;
        private System.Windows.Forms.TextBox txtTenCongTrinh;
        private System.Windows.Forms.TextBox txtMaCongTrinh;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
    }
}