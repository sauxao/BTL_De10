namespace BTL_QLNhanSuXayDung.GUI
{
    partial class FormThiCong
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
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.labelNhanVien = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.labelCongTrinh = new System.Windows.Forms.Label();
            this.cboCongTrinh = new System.Windows.Forms.ComboBox();
            this.labelSoNgayCong = new System.Windows.Forms.Label();
            this.txtSoNgayCong = new System.Windows.Forms.TextBox();
            this.groupBoxChucNang = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvThiCong = new System.Windows.Forms.DataGridView();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.groupBoxThongTin.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiCong)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.labelTieuDe.Location = new System.Drawing.Point(280, 15);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(380, 37);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "QUẢN LÝ TIẾN ĐỘ THI CÔNG";
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Controls.Add(this.txtSoNgayCong);
            this.groupBoxThongTin.Controls.Add(this.labelSoNgayCong);
            this.groupBoxThongTin.Controls.Add(this.cboCongTrinh);
            this.groupBoxThongTin.Controls.Add(this.labelCongTrinh);
            this.groupBoxThongTin.Controls.Add(this.cboNhanVien);
            this.groupBoxThongTin.Controls.Add(this.labelNhanVien);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBoxThongTin.Location = new System.Drawing.Point(16, 65);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(900, 110);
            this.groupBoxThongTin.TabIndex = 1;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin thi công";
            // 
            // labelNhanVien
            // 
            this.labelNhanVien.AutoSize = true;
            this.labelNhanVien.Location = new System.Drawing.Point(20, 43);
            this.labelNhanVien.Name = "labelNhanVien";
            this.labelNhanVien.Size = new System.Drawing.Size(78, 20);
            this.labelNhanVien.TabIndex = 0;
            this.labelNhanVien.Text = "Nhân viên:";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(110, 40);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(200, 24); // Đã sửa kích thước chuẩn
            this.cboNhanVien.TabIndex = 1;
            // 
            // labelCongTrinh
            // 
            this.labelCongTrinh.AutoSize = true;
            this.labelCongTrinh.Location = new System.Drawing.Point(340, 43);
            this.labelCongTrinh.Name = "labelCongTrinh";
            this.labelCongTrinh.Size = new System.Drawing.Size(81, 20);
            this.labelCongTrinh.TabIndex = 2;
            this.labelCongTrinh.Text = "Công trình:";
            // 
            // cboCongTrinh
            // 
            this.cboCongTrinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCongTrinh.FormattingEnabled = true;
            this.cboCongTrinh.Location = new System.Drawing.Point(435, 40);
            this.cboCongTrinh.Name = "cboCongTrinh";
            this.cboCongTrinh.Size = new System.Drawing.Size(220, 24); // Đã sửa kích thước chuẩn
            this.cboCongTrinh.TabIndex = 3;
            // 
            // labelSoNgayCong
            // 
            this.labelSoNgayCong.AutoSize = true;
            this.labelSoNgayCong.Location = new System.Drawing.Point(680, 43);
            this.labelSoNgayCong.Name = "labelSoNgayCong";
            this.labelSoNgayCong.Size = new System.Drawing.Size(102, 20);
            this.labelSoNgayCong.TabIndex = 4;
            this.labelSoNgayCong.Text = "Số ngày công:";
            // 
            // txtSoNgayCong
            // 
            this.txtSoNgayCong.Location = new System.Drawing.Point(790, 40);
            this.txtSoNgayCong.Name = "txtSoNgayCong";
            this.txtSoNgayCong.Size = new System.Drawing.Size(90, 27); // Đã sửa kích thước chuẩn
            this.txtSoNgayCong.TabIndex = 5;
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
            this.groupBoxChucNang.Location = new System.Drawing.Point(16, 185);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Size = new System.Drawing.Size(900, 75);
            this.groupBoxChucNang.TabIndex = 2;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Thao tác dữ liệu";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(15, 27);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 35);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(115, 27);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 35);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(215, 27);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 35);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(315, 27);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(100, 35);
            this.btnLamMoi.TabIndex = 3;
            this.btnLamMoi.Text = "Làm Mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(545, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(230, 27);
            this.txtTimKiem.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(785, 27);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 35);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvThiCong
            // 
            this.dgvThiCong.AllowUserToAddRows = false;
            this.dgvThiCong.AllowUserToDeleteRows = false;
            this.dgvThiCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThiCong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThiCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThiCong.Location = new System.Drawing.Point(16, 275);
            this.dgvThiCong.Name = "dgvThiCong";
            this.dgvThiCong.ReadOnly = true;
            this.dgvThiCong.RowHeadersWidth = 51;
            this.dgvThiCong.RowTemplate.Height = 24;
            this.dgvThiCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThiCong.Size = new System.Drawing.Size(900, 300);
            this.dgvThiCong.TabIndex = 3;
            this.dgvThiCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThiCong_CellClick);
            // 
            // FormThiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 593);
            this.Controls.Add(this.dgvThiCong);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.labelTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormThiCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thi Công Công Trình";
            this.Load += new System.EventHandler(this.FormThiCong_Load);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.groupBoxChucNang.ResumeLayout(false);
            this.groupBoxChucNang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiCong)).EndInit();
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
        private System.Windows.Forms.Label labelSoNgayCong;
        private System.Windows.Forms.TextBox txtSoNgayCong;
        private System.Windows.Forms.GroupBox groupBoxChucNang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvThiCong;
    }
}