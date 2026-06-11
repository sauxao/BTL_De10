using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.DAL;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormCongTrinh : Form
    {
        public FormCongTrinh()
        {
            InitializeComponent();

            // KÍCH HOẠT PHÍM TẮT: Cho phép Form đánh chặn và nhận diện phím bấm trước các điều khiển con
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormCongTrinh_KeyDown);
        }

        private void FormCongTrinh_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Bộ lắng nghe sự kiện Phím tắt toàn diện cho phân hệ quản lý công trình (F1, F2, F3, F4, ESC)
        /// </summary>
        private void FormCongTrinh_KeyDown(object sender, KeyEventArgs e)
        {
            // Phím F1: Kích hoạt Thêm mới công trình
            if (e.KeyCode == Keys.F1 && btnThem.Enabled)
            {
                e.Handled = true; // Ngăn chặn tiếng bíp thông báo của Windows
                btnThem_Click(sender, e);
            }
            // Phím F2: Kích hoạt Sửa / Cập nhật thông tin công trình
            else if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                btnSua_Click(sender, e);
            }
            // Phím F3: Kích hoạt Xóa công trình được chọn
            else if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                btnXoa_Click(sender, e);
            }
            // Phím F4: Làm mới form / Tải lại toàn bộ danh sách dữ liệu gốc
            else if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                btnLamMoi_Click(sender, e);
            }
            // Phím F5: Kích hoạt tìm kiếm
            if (e.KeyCode == Keys.F5)
            {
                e.Handled = true; // Ngăn hành động refresh mặc định nếu có của Windows
                LayDanhSachCongTrinh(txtTimKiem.Text.Trim());
            }
            // Phím ESC: Đóng nhanh Form con để quay lại Dashboard chính
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        // 1. Hàm tải danh sách công trình bằng Stored Procedure
        private void LayDanhSachCongTrinh(string tuKhoa)
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchCongTrinh", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        da.Fill(dt);
                        dgvCongTrinh.DataSource = dt;

                        // Định dạng lại giao diện hiển thị cột
                        if (dgvCongTrinh.Columns.Count >= 6)
                        {
                            dgvCongTrinh.Columns[0].HeaderText = "Mã Công Trình";
                            dgvCongTrinh.Columns[1].HeaderText = "Tên Công Trình";
                            dgvCongTrinh.Columns[2].HeaderText = "Địa Điểm";
                            dgvCongTrinh.Columns[3].HeaderText = "Ngày Cấp Phép";
                            dgvCongTrinh.Columns[4].HeaderText = "Ngày Khởi Công";
                            dgvCongTrinh.Columns[5].HeaderText = "Ngày Hoàn Thành";
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 2. Chức năng THÊM MỚI công trình sử dụng Stored Procedure
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraHopLe()) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertCongTrinh", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCongTrinh", txtMaCongTrinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenCongTrinh", txtTenCongTrinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaDiem", txtDiaDiem.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayCapPhep", dtpNgayCapPhep.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@NgayKhoiCong", dtpNgayKhoiCong.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@NgayDuKienHoanThanh", dtpNgayDuKien.Value.ToString("yyyy-MM-dd"));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới công trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể thêm dữ liệu!\nChi tiết lỗi: " + ex.Message, "Lỗi Dữ Liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        // 3. Chức năng CẬP NHẬT / SỬA thông tin sử dụng Stored Procedure
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCongTrinh.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn công trình từ danh sách trước khi sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!KiemTraHopLe()) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateCongTrinh", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCongTrinh", txtMaCongTrinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenCongTrinh", txtTenCongTrinh.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaDiem", txtDiaDiem.Text.Trim());
                    cmd.Parameters.AddWithValue("@NgayCapPhep", dtpNgayCapPhep.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@NgayKhoiCong", dtpNgayKhoiCong.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@NgayDuKienHoanThanh", dtpNgayDuKien.Value.ToString("yyyy-MM-dd"));

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin công trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 4. Chức năng XÓA CÔNG TRÌNH sử dụng Stored Procedure
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaCongTrinh.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn công trình cần xóa từ danh sách!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show($"Bạn có chắc chắn muốn xóa công trình [{txtTenCongTrinh.Text}] không?\nHành động này không thể hoàn tác!", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.No) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteCongTrinh", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaCongTrinh", txtMaCongTrinh.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa công trình thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (SqlException ex) when (ex.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa công trình này! Vì dữ liệu công trình đang liên kết với danh sách phân công thi công hoặc chấm công hằng ngày.", "Cảnh Báo Khóa Ngoại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Sự kiện click chọn dòng trên DataGridView
        private void dgvCongTrinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCongTrinh.Rows.Count)
            {
                DataGridViewRow row = dgvCongTrinh.Rows[e.RowIndex];

                // Đảm bảo lưới dữ liệu có đủ tối thiểu 6 cột để tránh lỗi vượt chỉ mục hệ thống
                if (row.Cells.Count >= 6)
                {
                    txtMaCongTrinh.Text = row.Cells[0].Value?.ToString();
                    txtTenCongTrinh.Text = row.Cells[1].Value?.ToString();
                    txtDiaDiem.Text = row.Cells[2].Value?.ToString();

                    if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime dtCP))
                        dtpNgayCapPhep.Value = dtCP;

                    if (row.Cells[4].Value != null && DateTime.TryParse(row.Cells[4].Value.ToString(), out DateTime dtKC))
                        dtpNgayKhoiCong.Value = dtKC;

                    if (row.Cells[5].Value != null && DateTime.TryParse(row.Cells[5].Value.ToString(), out DateTime dtDK))
                        dtpNgayDuKien.Value = dtDK;

                    // Khóa textbox Mã công trình và nút Thêm khi đang thực hiện chọn xem/sửa/xóa
                    txtMaCongTrinh.Enabled = false;
                    btnThem.Enabled = false;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LayDanhSachCongTrinh(txtTimKiem.Text.Trim());
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        // Hàm dọn dẹp các ô nhập liệu
        private void ResetForm()
        {
            txtMaCongTrinh.Clear();
            txtTenCongTrinh.Clear();
            txtDiaDiem.Clear();
            txtTimKiem.Clear();
            dtpNgayCapPhep.Value = DateTime.Now;
            dtpNgayKhoiCong.Value = DateTime.Now;
            dtpNgayDuKien.Value = DateTime.Now;

            txtMaCongTrinh.Enabled = true;
            btnThem.Enabled = true;

            LayDanhSachCongTrinh("");
        }

        // Hàm kiểm tra tính toàn vẹn của dữ liệu nghiệp vụ xây dựng
        private bool KiemTraHopLe()
        {
            if (string.IsNullOrEmpty(txtMaCongTrinh.Text.Trim()) || string.IsNullOrEmpty(txtTenCongTrinh.Text.Trim()) || string.IsNullOrEmpty(txtDiaDiem.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả các trường thông tin có dấu (*)", "Yêu cầu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpNgayKhoiCong.Value < dtpNgayCapPhep.Value)
            {
                MessageBox.Show("Lỗi logic ngày tháng: Ngày khởi công xây dựng không thể trước ngày cấp phép!", "Sai lệch nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dtpNgayDuKien.Value < dtpNgayKhoiCong.Value)
            {
                MessageBox.Show("Lỗi logic ngày tháng: Ngày dự kiến hoàn thành phải sau ngày khởi công!", "Sai lệch nghiệp vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    }
}