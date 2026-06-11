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
            this.txtSoNgayCong = new System.Windows.Forms.TextBox();
            this.labelSoNgayCong = new System.Windows.Forms.Label();
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
            this.dgvThiCong = new System.Windows.Forms.DataGridView();
            this.labelTieuDe = new System.Windows.Forms.Label();
            this.groupBoxThongTin.SuspendLayout();
            this.groupBoxChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThiCong)).BeginInit();
            this.SuspendLayout();
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
            this.groupBoxThongTin.Location = new System.Drawing.Point(12, 53);
            this.groupBoxThongTin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxThongTin.Size = new System.Drawing.Size(725, 89);
            this.groupBoxThongTin.TabIndex = 1;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin thi công";
            // 
            // txtSoNgayCong
            // 
            this.txtSoNgayCong.Location = new System.Drawing.Point(592, 32);
            this.txtSoNgayCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSoNgayCong.Name = "txtSoNgayCong";
            this.txtSoNgayCong.Size = new System.Drawing.Size(129, 23);
            this.txtSoNgayCong.TabIndex = 5;
            // 
            // labelSoNgayCong
            // 
            this.labelSoNgayCong.AutoSize = true;
            this.labelSoNgayCong.Location = new System.Drawing.Point(510, 35);
            this.labelSoNgayCong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSoNgayCong.Name = "labelSoNgayCong";
            this.labelSoNgayCong.Size = new System.Drawing.Size(82, 15);
            this.labelSoNgayCong.TabIndex = 4;
            this.labelSoNgayCong.Text = "Số ngày công:";
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
            this.groupBoxChucNang.Location = new System.Drawing.Point(12, 150);
            this.groupBoxChucNang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChucNang.Name = "groupBoxChucNang";
            this.groupBoxChucNang.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxChucNang.Size = new System.Drawing.Size(725, 61);
            this.groupBoxChucNang.TabIndex = 2;
            this.groupBoxChucNang.TabStop = false;
            this.groupBoxChucNang.Text = "Thao tác dữ liệu";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(589, 22);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(137, 28);
            this.btnTimKiem.TabIndex = 5;
            this.btnTimKiem.Text = "Tìm Kiếm (F5)";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(409, 25);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(174, 23);
            this.txtTimKiem.TabIndex = 4;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(236, 22);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(86, 28);
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
            // dgvThiCong
            // 
            this.dgvThiCong.AllowUserToAddRows = false;
            this.dgvThiCong.AllowUserToDeleteRows = false;
            this.dgvThiCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThiCong.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvThiCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThiCong.Location = new System.Drawing.Point(12, 223);
            this.dgvThiCong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvThiCong.Name = "dgvThiCong";
            this.dgvThiCong.ReadOnly = true;
            this.dgvThiCong.RowHeadersWidth = 51;
            this.dgvThiCong.RowTemplate.Height = 24;
            this.dgvThiCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvThiCong.Size = new System.Drawing.Size(725, 244);
            this.dgvThiCong.TabIndex = 3;
            this.dgvThiCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThiCong_CellClick);
            // 
            // labelTieuDe
            // 
            this.labelTieuDe.AutoSize = true;
            this.labelTieuDe.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTieuDe.ForeColor = System.Drawing.Color.Blue;
            this.labelTieuDe.Location = new System.Drawing.Point(210, 12);
            this.labelTieuDe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTieuDe.Name = "labelTieuDe";
            this.labelTieuDe.Size = new System.Drawing.Size(314, 30);
            this.labelTieuDe.TabIndex = 0;
            this.labelTieuDe.Text = "QUẢN LÝ TIẾN ĐỘ THI CÔNG";
            // 
            // FormThiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 482);
            this.Controls.Add(this.dgvThiCong);
            this.Controls.Add(this.groupBoxChucNang);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.labelTieuDe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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