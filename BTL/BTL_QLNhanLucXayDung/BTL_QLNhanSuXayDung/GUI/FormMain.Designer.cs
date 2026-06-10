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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLPhongBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQLCongTrinh = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuThiCong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuChamCong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRptCongTrinhDangLam = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRptChiTietNhanLuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDanhMuc,
            this.menuNghiepVu,
            this.menuBaoCao});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(600, 24);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "mainMenuStrip";
            // 
            // menuDanhMuc
            // 
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuQLPhongBan,
            this.menuQLNhanVien,
            this.menuQLCongTrinh});
            this.menuDanhMuc.Name = "menuDanhMuc";
            this.menuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.menuDanhMuc.Text = "&Danh mục";
            // 
            // menuQLPhongBan
            // 
            this.menuQLPhongBan.Name = "menuQLPhongBan";
            this.menuQLPhongBan.Size = new System.Drawing.Size(180, 22);
            this.menuQLPhongBan.Text = "Quản lý &Phòng ban";
            this.menuQLPhongBan.Click += new System.EventHandler(this.menuQLPhongBan_Click);
            // 
            // menuQLNhanVien
            // 
            this.menuQLNhanVien.Name = "menuQLNhanVien";
            this.menuQLNhanVien.Size = new System.Drawing.Size(180, 22);
            this.menuQLNhanVien.Text = "Quản lý &Nhân viên";
            this.menuQLNhanVien.Click += new System.EventHandler(this.menuQLNhanVien_Click);
            // 
            // menuQLCongTrinh
            // 
            this.menuQLCongTrinh.Name = "menuQLCongTrinh";
            this.menuQLCongTrinh.Size = new System.Drawing.Size(180, 22);
            this.menuQLCongTrinh.Text = "Quản lý &Công trình";
            this.menuQLCongTrinh.Click += new System.EventHandler(this.menuQLCongTrinh_Click);
            // 
            // menuNghiepVu
            // 
            this.menuNghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuThiCong,
            this.menuChamCong});
            this.menuNghiepVu.Name = "menuNghiepVu";
            this.menuNghiepVu.Size = new System.Drawing.Size(74, 20);
            this.menuNghiepVu.Text = "Nghiệ&p vụ";
            // 
            // menuThiCong
            // 
            this.menuThiCong.Name = "menuThiCong";
            this.menuThiCong.Size = new System.Drawing.Size(195, 22);
            this.menuThiCong.Text = "Quản lý &Thi công";
            this.menuThiCong.Click += new System.EventHandler(this.menuThiCong_Click);
            // 
            // menuChamCong
            // 
            this.menuChamCong.Name = "menuChamCong";
            this.menuChamCong.Size = new System.Drawing.Size(195, 22);
            this.menuChamCong.Text = "&Chấm công hằng ngày";
            this.menuChamCong.Click += new System.EventHandler(this.menuChamCong_Click);
            // 
            // menuBaoCao
            // 
            this.menuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRptCongTrinhDangLam,
            this.menuRptChiTietNhanLuc});
            this.menuBaoCao.Name = "menuBaoCao";
            this.menuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.menuBaoCao.Text = "&Báo cáo";
            // 
            // menuRptCongTrinhDangLam
            // 
            this.menuRptCongTrinhDangLam.Name = "menuRptCongTrinhDangLam";
            this.menuRptCongTrinhDangLam.Size = new System.Drawing.Size(489, 22);
            this.menuRptCongTrinhDangLam.Text = "&Công trình đang thực hiện";
            this.menuRptCongTrinhDangLam.Click += new System.EventHandler(this.menuRptCongTrinhDangLam_Click);
            // 
            // menuRptChiTietNhanLuc
            // 
            this.menuRptChiTietNhanLuc.Name = "menuRptChiTietNhanLuc";
            this.menuRptChiTietNhanLuc.Size = new System.Drawing.Size(489, 22);
            this.menuRptChiTietNhanLuc.Text = "Thống Kê Chuyên Cần Nhân Sự Theo Tháng";
            this.menuRptChiTietNhanLuc.Click += new System.EventHandler(this.menuRptChuyenCan_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.mainMenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "FormMain";
            this.Text = "HỆ THỐNG QUẢN LÝ NHÂN LỰC CÔNG TRÌNH XÂY DỰNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuQLPhongBan;
        private System.Windows.Forms.ToolStripMenuItem menuQLNhanVien;
        private System.Windows.Forms.ToolStripMenuItem menuQLCongTrinh;
        private System.Windows.Forms.ToolStripMenuItem menuNghiepVu;
        private System.Windows.Forms.ToolStripMenuItem menuThiCong;
        private System.Windows.Forms.ToolStripMenuItem menuChamCong;
        private System.Windows.Forms.ToolStripMenuItem menuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem menuRptCongTrinhDangLam;
        private System.Windows.Forms.ToolStripMenuItem menuRptChiTietNhanLuc;
    }
}