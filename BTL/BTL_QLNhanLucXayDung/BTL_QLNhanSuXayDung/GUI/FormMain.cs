using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        // Sự kiện xử lý khi bấm nút Thoát 
        private void menuThoat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Sự kiện xử lý khi bấm nút Quản lý Công trình 
        private void menuQLCongTrinh_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(FormCongTrinh));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormCongTrinh f = new FormCongTrinh();
                f.MdiParent = this; // Ép hiển thị bên trong lòng FormMain
                f.Show();
            }
        }

        /// Sự kiện mở phân hệ Quản lý Phòng ban 
        private void menuQLPhongBan_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(FormPhongBan));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormPhongBan f = new FormPhongBan();
                f.MdiParent = this; // Ép hiển thị trong lòng FormMain mẹ
                f.Show();
            }
        }

        /// Sự kiện mở phân hệ Quản lý Nhân viên
        private void menuQLNhanVien_Click(object sender, EventArgs e)
        {
            Form frm = CheckExists(typeof(FormNhanVien));
            if (frm != null)
            {
                frm.Activate();
            }
            else
            {
                FormNhanVien f = new FormNhanVien();
                f.MdiParent = this; // Ép hiển thị trong lòng FormMain mẹ
                f.Show();
            }
        }
        // nghiệp vụ phân công thi công 
        private void menuThiCong_Click(object sender, EventArgs e)
        {
            FormThiCong fThiCong = new FormThiCong();
            fThiCong.MdiParent = this; // Hiển thị lồng bên trong FormMain vì FormMain là MdiContainer
            fThiCong.Show();
        }
        // nghiệp vụ chấm công
        private void menuChamCong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FormChamCong đã mở chưa, nếu mở rồi thì kích hoạt lên trước mặt
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormChamCong)
                {
                    child.Activate();
                    return;
                }
            }

            // Nếu chưa mở, tiến hành khởi tạo và hiển thị lồng bên trong FormMain (MDI)
            FormChamCong fChamCong = new FormChamCong();
            fChamCong.MdiParent = this; // Chỉ định FormMain là cha nếu FormMain là IsMdiContainer = true
            fChamCong.Show();
        }

        // báo cáo công trình đang làm
        private void menuRptCongTrinhDangLam_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem FormBaoCaoCongTrinh đã hiển thị hay chưa
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormBaoCaoCongTrinh)
                {
                    child.Activate();
                    return;
                }
            }

            // Nếu chưa mở, tiến hành tạo mới và lồng vào FormMain cha
            FormBaoCaoCongTrinh fBaoCao = new FormBaoCaoCongTrinh();
            fBaoCao.MdiParent = this;
            fBaoCao.Show();
        }
        
        // báo cáo chuyên cần
        private void menuRptChuyenCan_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is FormBaoCaoChuyenCan)
                {
                    child.Activate();
                    return;
                }
            }

            FormBaoCaoChuyenCan fChuyenCan = new FormBaoCaoChuyenCan();
            fChuyenCan.MdiParent = this;
            fChuyenCan.Show();
        }

        // Hàm kiểm tra tránh mở lặp lại nhiều cửa sổ con cùng loại
        private Form CheckExists(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    return f;
                }
            }
            return null;
        }
    }
}
