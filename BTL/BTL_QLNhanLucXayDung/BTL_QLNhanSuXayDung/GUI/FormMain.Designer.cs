namespace BTL_QLNhanSuXayDung.GUI
{
    partial class FormMain
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
            this.pnlTopDashboard = new System.Windows.Forms.Panel();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.grpDanhMuc = new System.Windows.Forms.GroupBox();
            this.btnQLPhongBan = new System.Windows.Forms.Button();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.btnQLCongTrinh = new System.Windows.Forms.Button();
            this.grpNghiepVu = new System.Windows.Forms.GroupBox();
            this.btnQLThiCong = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.grpBaoCao = new System.Windows.Forms.GroupBox();
            this.btnRptCongTrinh = new System.Windows.Forms.Button();
            this.btnRptChuyenCan = new System.Windows.Forms.Button();
            this.pnlTopDashboard.SuspendLayout();
            this.grpDanhMuc.SuspendLayout();
            this.grpNghiepVu.SuspendLayout();
            this.grpBaoCao.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopDashboard
            // 
            this.pnlTopDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.pnlTopDashboard.Controls.Add(this.lblDashboardTitle);
            this.pnlTopDashboard.Controls.Add(this.grpDanhMuc);
            this.pnlTopDashboard.Controls.Add(this.grpNghiepVu);
            this.pnlTopDashboard.Controls.Add(this.grpBaoCao);
            this.pnlTopDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlTopDashboard.Name = "pnlTopDashboard";
            this.pnlTopDashboard.Size = new System.Drawing.Size(1264, 180);
            this.pnlTopDashboard.TabIndex = 0;
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblDashboardTitle.Location = new System.Drawing.Point(12, 9);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(225, 25);
            this.lblDashboardTitle.Text = "BẢNG ĐIỀU HƯỚNG CHÍNH";
            // 
            // grpDanhMuc
            // 
            this.grpDanhMuc.Controls.Add(this.btnQLPhongBan);
            this.grpDanhMuc.Controls.Add(this.btnQLNhanVien);
            this.grpDanhMuc.Controls.Add(this.btnQLCongTrinh);
            this.grpDanhMuc.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDanhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.grpDanhMuc.Location = new System.Drawing.Point(12, 40);
            this.grpDanhMuc.Name = "grpDanhMuc";
            this.grpDanhMuc.Size = new System.Drawing.Size(410, 130);
            this.grpDanhMuc.TabIndex = 1;
            this.grpDanhMuc.TabStop = false;
            this.grpDanhMuc.Text = " I. DANH MỤC QUẢN LÝ";
            // 
            // btnQLPhongBan
            // 
            this.btnQLPhongBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(175)))));
            this.btnQLPhongBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLPhongBan.FlatAppearance.BorderSize = 0;
            this.btnQLPhongBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLPhongBan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLPhongBan.ForeColor = System.Drawing.Color.White;
            this.btnQLPhongBan.Location = new System.Drawing.Point(15, 22);
            this.btnQLPhongBan.Name = "btnQLPhongBan";
            this.btnQLPhongBan.Size = new System.Drawing.Size(120, 95);
            this.btnQLPhongBan.TabIndex = 0;
            this.btnQLPhongBan.Text = "Quản lý\r\n&Phòng ban";
            this.btnQLPhongBan.UseVisualStyleBackColor = false;
            this.btnQLPhongBan.Click += new System.EventHandler(this.menuQLPhongBan_Click);
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(175)))));
            this.btnQLNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNhanVien.FlatAppearance.BorderSize = 0;
            this.btnQLNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnQLNhanVien.Location = new System.Drawing.Point(145, 22);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(120, 95);
            this.btnQLNhanVien.TabIndex = 1;
            this.btnQLNhanVien.Text = "Quản lý\r\n&Nhân viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = false;
            this.btnQLNhanVien.Click += new System.EventHandler(this.menuQLNhanVien_Click);
            // 
            // btnQLCongTrinh
            // 
            this.btnQLCongTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(124)))), ((int)(((byte)(175)))));
            this.btnQLCongTrinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLCongTrinh.FlatAppearance.BorderSize = 0;
            this.btnQLCongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLCongTrinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLCongTrinh.ForeColor = System.Drawing.Color.White;
            this.btnQLCongTrinh.Location = new System.Drawing.Point(275, 22);
            this.btnQLCongTrinh.Name = "btnQLCongTrinh";
            this.btnQLCongTrinh.Size = new System.Drawing.Size(120, 95);
            this.btnQLCongTrinh.TabIndex = 2;
            this.btnQLCongTrinh.Text = "Quản lý\r\n&Công trình";
            this.btnQLCongTrinh.UseVisualStyleBackColor = false;
            this.btnQLCongTrinh.Click += new System.EventHandler(this.menuQLCongTrinh_Click);
            // 
            // grpNghiepVu
            // 
            this.grpNghiepVu.Controls.Add(this.btnQLThiCong);
            this.grpNghiepVu.Controls.Add(this.btnChamCong);
            this.grpNghiepVu.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNghiepVu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.grpNghiepVu.Location = new System.Drawing.Point(435, 40);
            this.grpNghiepVu.Name = "grpNghiepVu";
            this.grpNghiepVu.Size = new System.Drawing.Size(280, 130);
            this.grpNghiepVu.TabIndex = 2;
            this.grpNghiepVu.TabStop = false;
            this.grpNghiepVu.Text = " II. NGHIỆP VỤ XỬ LÝ";
            // 
            // btnQLThiCong
            // 
            this.btnQLThiCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnQLThiCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLThiCong.FlatAppearance.BorderSize = 0;
            this.btnQLThiCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLThiCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnQLThiCong.ForeColor = System.Drawing.Color.White;
            this.btnQLThiCong.Location = new System.Drawing.Point(15, 22);
            this.btnQLThiCong.Name = "btnQLThiCong";
            this.btnQLThiCong.Size = new System.Drawing.Size(120, 95);
            this.btnQLThiCong.TabIndex = 0;
            this.btnQLThiCong.Text = "Quản lý\r\n&Thi công";
            this.btnQLThiCong.UseVisualStyleBackColor = false;
            this.btnQLThiCong.Click += new System.EventHandler(this.menuThiCong_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChamCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCong.FlatAppearance.BorderSize = 0;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnChamCong.ForeColor = System.Drawing.Color.White;
            this.btnChamCong.Location = new System.Drawing.Point(145, 22);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(120, 95);
            this.btnChamCong.TabIndex = 1;
            this.btnChamCong.Text = "&Chấm công\r\nhằng ngày";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.menuChamCong_Click);
            // 
            // grpBaoCao
            // 
            this.grpBaoCao.Controls.Add(this.btnRptCongTrinh);
            this.grpBaoCao.Controls.Add(this.btnRptChuyenCan);
            this.grpBaoCao.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBaoCao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.grpBaoCao.Location = new System.Drawing.Point(728, 40);
            this.grpBaoCao.Name = "grpBaoCao";
            this.grpBaoCao.Size = new System.Drawing.Size(310, 130);
            this.grpBaoCao.TabIndex = 3;
            this.grpBaoCao.TabStop = false;
            this.grpBaoCao.Text = " III. HỆ THỐNG BÁO CÁO";
            // 
            // btnRptCongTrinh
            // 
            this.btnRptCongTrinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
            this.btnRptCongTrinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRptCongTrinh.FlatAppearance.BorderSize = 0;
            this.btnRptCongTrinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptCongTrinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRptCongTrinh.ForeColor = System.Drawing.Color.White;
            this.btnRptCongTrinh.Location = new System.Drawing.Point(15, 22);
            this.btnRptCongTrinh.Name = "btnRptCongTrinh";
            this.btnRptCongTrinh.Size = new System.Drawing.Size(120, 95);
            this.btnRptCongTrinh.TabIndex = 0;
            this.btnRptCongTrinh.Text = "&Công trình\r\nđang làm";
            this.btnRptCongTrinh.UseVisualStyleBackColor = false;
            this.btnRptCongTrinh.Click += new System.EventHandler(this.menuRptCongTrinhDangLam_Click);
            // 
            // btnRptChuyenCan
            // 
            this.btnRptChuyenCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(60)))), ((int)(((byte)(155)))));
            this.btnRptChuyenCan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRptChuyenCan.FlatAppearance.BorderSize = 0;
            this.btnRptChuyenCan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRptChuyenCan.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnRptChuyenCan.ForeColor = System.Drawing.Color.White;
            this.btnRptChuyenCan.Location = new System.Drawing.Point(145, 22);
            this.btnRptChuyenCan.Name = "btnRptChuyenCan";
            this.btnRptChuyenCan.Size = new System.Drawing.Size(150, 95);
            this.btnRptChuyenCan.TabIndex = 1;
            this.btnRptChuyenCan.Text = "Thống Kê\r\nChuyên Cần\r\nTheo &Tháng";
            this.btnRptChuyenCan.UseVisualStyleBackColor = false;
            this.btnRptChuyenCan.Click += new System.EventHandler(this.menuRptChuyenCan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pnlTopDashboard);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "FormMain";
            this.Text = "HỆ THỐNG QUẢN LÝ NHÂN LỰC CÔNG TRÌNH XÂY DỰNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlTopDashboard.ResumeLayout(false);
            this.pnlTopDashboard.PerformLayout();
            this.grpDanhMuc.ResumeLayout(false);
            this.grpNghiepVu.ResumeLayout(false);
            this.grpBaoCao.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopDashboard;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.GroupBox grpDanhMuc;
        private System.Windows.Forms.Button btnQLPhongBan;
        private System.Windows.Forms.Button btnQLNhanVien;
        private System.Windows.Forms.Button btnQLCongTrinh;
        private System.Windows.Forms.GroupBox grpNghiepVu;
        private System.Windows.Forms.Button btnQLThiCong;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.GroupBox grpBaoCao;
        private System.Windows.Forms.Button btnRptCongTrinh;
        private System.Windows.Forms.Button btnRptChuyenCan;
    }
}