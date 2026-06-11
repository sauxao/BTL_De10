namespace BTL_QLNhanSuXayDung.GUI
{
    partial class FormPhongBan
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
            this.groupBoxThongTin = new System.Windows.Forms.GroupBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtMaPhong = new System.Windows.Forms.TextBox();
            this.lblTenPB = new System.Windows.Forms.Label();
            this.lblMaPB = new System.Windows.Forms.Label();
            this.panelChucNang = new System.Windows.Forms.Panel();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvPhongBan = new System.Windows.Forms.DataGridView();
            this.groupBoxThongTin.SuspendLayout();
            this.panelChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTieude
            // 
            this.lblTieude.AutoSize = true;
            this.lblTieude.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieude.ForeColor = System.Drawing.Color.Blue;
            this.lblTieude.Location = new System.Drawing.Point(12, 9);
            this.lblTieude.Name = "lblTieude";
            this.lblTieude.Size = new System.Drawing.Size(262, 26);
            this.lblTieude.TabIndex = 0;
            this.lblTieude.Text = "QUẢN LÝ PHÒNG BAN";
            // 
            // groupBoxThongTin
            // 
            this.groupBoxThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxThongTin.Controls.Add(this.txtTenPhong);
            this.groupBoxThongTin.Controls.Add(this.txtMaPhong);
            this.groupBoxThongTin.Controls.Add(this.lblTenPB);
            this.groupBoxThongTin.Controls.Add(this.lblMaPB);
            this.groupBoxThongTin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxThongTin.Location = new System.Drawing.Point(17, 50);
            this.groupBoxThongTin.Name = "groupBoxThongTin";
            this.groupBoxThongTin.Size = new System.Drawing.Size(600, 110);
            this.groupBoxThongTin.TabIndex = 1;
            this.groupBoxThongTin.TabStop = false;
            this.groupBoxThongTin.Text = "Thông tin phòng ban";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(150, 65);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(300, 23);
            this.txtTenPhong.TabIndex = 3;
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.Location = new System.Drawing.Point(150, 26);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(150, 23);
            this.txtMaPhong.TabIndex = 1;
            // 
            // lblTenPB
            // 
            this.lblTenPB.AutoSize = true;
            this.lblTenPB.Location = new System.Drawing.Point(20, 68);
            this.lblTenPB.Name = "lblTenPB";
            this.lblTenPB.Size = new System.Drawing.Size(119, 17);
            this.lblTenPB.TabIndex = 2;
            this.lblTenPB.Text = "Tên phòng ban *:";
            // 
            // lblMaPB
            // 
            this.lblMaPB.AutoSize = true;
            this.lblMaPB.Location = new System.Drawing.Point(20, 29);
            this.lblMaPB.Name = "lblMaPB";
            this.lblMaPB.Size = new System.Drawing.Size(113, 17);
            this.lblMaPB.TabIndex = 0;
            this.lblMaPB.Text = "Mã phòng ban *:";
            // 
            // panelChucNang
            // 
            this.panelChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelChucNang.Controls.Add(this.btnLamMoi);
            this.panelChucNang.Controls.Add(this.btnXoa);
            this.panelChucNang.Controls.Add(this.btnSua);
            this.panelChucNang.Controls.Add(this.btnThem);
            this.panelChucNang.Location = new System.Drawing.Point(17, 170);
            this.panelChucNang.Name = "panelChucNang";
            this.panelChucNang.Size = new System.Drawing.Size(600, 45);
            this.panelChucNang.TabIndex = 2;
            // 
            // btnLamMoi
            // 
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
            this.btnThem.Location = new System.Drawing.Point(15, 8);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 30);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            this.btnThem.Text = "&Thêm mới (F1)";
            this.btnSua.Text = "&Sửa (F2)";
            this.btnXoa.Text = "&Xóa (F3)";
            this.btnLamMoi.Text = "&Làm mới (F4)";
            // dgvPhongBan
            // 
            this.dgvPhongBan.AllowUserToAddRows = false;
            this.dgvPhongBan.AllowUserToDeleteRows = false;
            this.dgvPhongBan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhongBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhongBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhongBan.Location = new System.Drawing.Point(17, 230);
            this.dgvPhongBan.Name = "dgvPhongBan";
            this.dgvPhongBan.ReadOnly = true;
            this.dgvPhongBan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPhongBan.Size = new System.Drawing.Size(600, 200);
            this.dgvPhongBan.TabIndex = 3;
            this.dgvPhongBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhongBan_CellClick);
            // 
            // FormPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.dgvPhongBan);
            this.Controls.Add(this.panelChucNang);
            this.Controls.Add(this.groupBoxThongTin);
            this.Controls.Add(this.lblTieude);
            this.Name = "FormPhongBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Phòng Ban";
            this.Load += new System.EventHandler(this.FormPhongBan_Load);
            this.groupBoxThongTin.ResumeLayout(false);
            this.groupBoxThongTin.PerformLayout();
            this.panelChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhongBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTieude;
        private System.Windows.Forms.GroupBox groupBoxThongTin;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtMaPhong;
        private System.Windows.Forms.Label lblTenPB;
        private System.Windows.Forms.Label lblMaPB;
        private System.Windows.Forms.Panel panelChucNang;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvPhongBan;
    }
}