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
        // Biến lưu trữ quyền của tài khoản sau khi đăng nhập thành công
        private string accountRole;

        // Hàm khởi tạo mặc định (Để tránh lỗi hiển thị thiết kế trực quan của Visual Studio)
        public FormMain()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Đảm bảo chế độ Container luôn bật
            this.accountRole = "Admin";  // Mặc định quyền cao nhất nếu chạy kiểm thử độc lập
            PhanQuyenHeThong();
        }

        // Hàm khởi tạo tiếp nhận quyền trực tiếp từ Form Đăng nhập truyền sang
        public FormMain(string role)
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Vá lỗi triệt để ngoại lệ ArgumentException
            this.accountRole = role;
            PhanQuyenHeThong();
        }

        /// <summary>
        /// Thuật toán phân quyền hướng sự kiện: Bật/Tắt các khối chức năng dựa trên vai trò tài khoản
        /// </summary>
        private void PhanQuyenHeThong()
        {
            if (accountRole == "Admin")
            {
                lblDashboardTitle.Text = "BẢNG ĐIỀU HƯỚNG CHÍNH - [QUẢN TRỊ VIÊN]";

                // Quyền Admin: Cho phép truy cập toàn bộ hệ thống ô vuông
                btnQLPhongBan.Enabled = true;
                btnQLNhanVien.Enabled = true;
                btnQLCongTrinh.Enabled = true;
                btnQLThiCong.Enabled = true;
                btnChamCong.Enabled = true;
            }
            else
            {
                lblDashboardTitle.Text = "BẢNG ĐIỀU HƯỚNG CHÍNH - [NHÂN VIÊN CHẤM CÔNG]";

                // Quyền Nhân viên: Khóa cứng phân hệ cấu hình danh mục gốc
                btnQLPhongBan.Enabled = false;
                btnQLNhanVien.Enabled = false;
                btnQLCongTrinh.Enabled = false;

                // Chỉ để mở phân hệ thực thi nghiệp vụ công trường và xem báo cáo
                btnQLThiCong.Enabled = true;
                btnChamCong.Enabled = true;
            }
        }

        /// <summary>
        /// Hàm đa năng: Khởi tạo và quản lý vòng đời hiển thị Form con lồng dưới thanh Menu Top
        /// </summary>
        private void OpenChildForm(Type formType)
        {
            // 1. Kiểm tra xem cửa sổ con loại này đã tồn tại trong lòng MDI chưa
            Form existingForm = CheckExists(formType);
            if (existingForm != null)
            {
                existingForm.Activate(); // Nếu có rồi thì kích hoạt lên trước mặt người dùng
                existingForm.WindowState = FormWindowState.Maximized; // Phóng to để lấp đầy vùng trống bên dưới
                return;
            }

            // 2. Nếu chưa có, tiến hành tạo mới thực thể Form bằng kỹ thuật Reflection
            Form childForm = (Form)Activator.CreateInstance(formType);
            childForm.MdiParent = this; // Chỉ định FormMain làm khung chứa mẹ

            // 3. Hiển thị tối đa hóa bên dưới thanh pnlTopDashboard mà không sợ bị che khuất dữ liệu
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        // ====================================================================
        // KHỐI SỰ KIỆN XỬ LÝ CLICK CÁC Ô VUÔNG MENU THEO DESIGNER MỚI
        // ====================================================================

        // Sự kiện xử lý khi bấm ô vuông Quản lý Phòng ban
        private void menuQLPhongBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormPhongBan));
        }

        // Sự kiện xử lý khi bấm ô vuông Quản lý Nhân viên
        private void menuQLNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormNhanVien));
        }

        // Sự kiện xử lý khi bấm ô vuông Quản lý Công trình
        private void menuQLCongTrinh_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormCongTrinh));
        }

        // Sự kiện xử lý khi bấm ô vuông Quản lý Phân công Thi công
        private void menuThiCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormThiCong));
        }

        // Sự kiện xử lý khi bấm ô vuông Chấm công hằng ngày
        private void menuChamCong_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormChamCong));
        }

        // Sự kiện xử lý khi bấm ô vuông Báo cáo Công trình đang thực hiện
        private void menuRptCongTrinhDangLam_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormBaoCaoCongTrinh));
        }

        // Sự kiện xử lý khi bấm ô vuông Thống Kê Chuyên Cần Nhân Sự Theo Tháng
        private void menuRptChuyenCan_Click(object sender, EventArgs e)
        {
            OpenChildForm(typeof(FormBaoCaoChuyenCan));
        }

        /// <summary>
        /// Hàm duyệt vòng lặp tìm kiếm thực thể Form tránh hiện tượng chồng đối tượng con
        /// </summary>
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

        /// <summary>
        /// Đánh chặn hành vi đóng ứng dụng để đảm bảo tiến trình dữ liệu được lưu an toàn
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm quản lý nhân lực?",
                                                  "Xác nhận thoát hệ thống", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true; // Triệt tiêu lệnh đóng Form
                }
                else
                {
                    Application.Exit(); // Đóng và giải phóng hoàn toàn bộ nhớ chạy ngầm
                }
            }
        }
    }
}