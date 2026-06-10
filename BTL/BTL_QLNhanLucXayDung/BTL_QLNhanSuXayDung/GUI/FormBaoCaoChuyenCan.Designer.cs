namespace BTL_QLNhanSuXayDung.GUI
{
    partial class FormBaoCaoChuyenCan
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

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudThang = new System.Windows.Forms.NumericUpDown();
            this.nudNam = new System.Windows.Forms.NumericUpDown();
            this.dgvChuyenCan = new System.Windows.Forms.DataGridView();
            this.btnXemBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenCan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tháng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Năm:";
            // 
            // nudThang
            // 
            this.nudThang.Location = new System.Drawing.Point(60, 19);
            this.nudThang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThang.Name = "nudThang";
            this.nudThang.Size = new System.Drawing.Size(52, 20);
            this.nudThang.TabIndex = 7;
            this.nudThang.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudThang.ValueChanged += new System.EventHandler(this.nudThang_ValueChanged);
            // 
            // nudNam
            // 
            this.nudNam.Location = new System.Drawing.Point(165, 19);
            this.nudNam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nudNam.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.nudNam.Minimum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudNam.Name = "nudNam";
            this.nudNam.Size = new System.Drawing.Size(68, 20);
            this.nudNam.TabIndex = 6;
            this.nudNam.Value = new decimal(new int[] {
            2026,
            0,
            0,
            0});
            this.nudNam.ValueChanged += new System.EventHandler(this.nudNam_ValueChanged);
            // 
            // dgvChuyenCan
            // 
            this.dgvChuyenCan.AllowUserToAddRows = false;
            this.dgvChuyenCan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChuyenCan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChuyenCan.Location = new System.Drawing.Point(19, 57);
            this.dgvChuyenCan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvChuyenCan.Name = "dgvChuyenCan";
            this.dgvChuyenCan.RowHeadersWidth = 51;
            this.dgvChuyenCan.Size = new System.Drawing.Size(622, 284);
            this.dgvChuyenCan.TabIndex = 4;
            // 
            // btnXemBaoCao
            // 
            this.btnXemBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemBaoCao.Location = new System.Drawing.Point(513, 14);
            this.btnXemBaoCao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXemBaoCao.Name = "btnXemBaoCao";
            this.btnXemBaoCao.Size = new System.Drawing.Size(128, 27);
            this.btnXemBaoCao.TabIndex = 5;
            this.btnXemBaoCao.Text = "Xem & In Báo Cáo";
            this.btnXemBaoCao.UseVisualStyleBackColor = true;
            this.btnXemBaoCao.Click += new System.EventHandler(this.btnXemBaoCao_Click);
            // 
            // FormBaoCaoChuyenCan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.btnXemBaoCao);
            this.Controls.Add(this.dgvChuyenCan);
            this.Controls.Add(this.nudNam);
            this.Controls.Add(this.nudThang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBaoCaoChuyenCan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Chuyên Cần Nhân Sự";
            this.Load += new System.EventHandler(this.FormBaoCaoChuyenCan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChuyenCan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudThang;
        private System.Windows.Forms.NumericUpDown nudNam;
        private System.Windows.Forms.DataGridView dgvChuyenCan;
        private System.Windows.Forms.Button btnXemBaoCao;
    }
}