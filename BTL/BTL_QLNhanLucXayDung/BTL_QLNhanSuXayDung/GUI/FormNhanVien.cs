using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.DAL;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();

            // KÍCH HOẠT PHÍM TẮT: Cho phép Form đánh chặn và nhận diện phím bấm trước các điều khiển con
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormNhanVien_KeyDown);
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            TaiDanhSachPhongBanIntoCombobox();
            ResetForm();
        }

        /// <summary>
        /// Bộ lắng nghe sự kiện Phím tắt toàn diện cho phân hệ hồ sơ nhân sự (F1, F2, F3, F4, F5, ESC)
        /// </summary>
        private void FormNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            // Phím F5: Kích hoạt tìm kiếm
            if (e.KeyCode == Keys.F5)
            {
                e.Handled = true; // Ngăn hành động refresh mặc định nếu có của Windows
                LayDanhSachNhanVien(txtTimKiem.Text.Trim());
            }
            // Phím F1: Kích hoạt Thêm mới nhân viên
            else if (e.KeyCode == Keys.F1 && btnThem.Enabled)
            {
                e.Handled = true; // Ngăn chặn âm thanh bíp thông báo của Windows
                btnThem_Click(sender, e);
            }
            // Phím F2: Kích hoạt Sửa / Cập nhật hồ sơ nhân viên
            else if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                btnSua_Click(sender, e);
            }
            // Phím F3: Kích hoạt Xóa nhân viên được chọn
            else if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                btnXoa_Click(sender, e);
            }
            // Phím F4: Làm mới form / Tải lại dữ liệu gốc từ máy chủ
            else if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                btnLamMoi_Click(sender, e);
            }
            // Phím ESC: Đóng nhanh Form con để quay về bảng điều hướng Dashboard
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        private void TaiDanhSachPhongBanIntoCombobox()
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                string query = "SELECT MaPhong, TenPhong FROM tblPhongban";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    cboPhongBan.DataSource = dt;
                    cboPhongBan.DisplayMember = "TenPhong";
                    cboPhongBan.ValueMember = "MaPhong";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi nạp danh mục phòng ban: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Hàm tải danh sách nhân viên: Sử dụng duy nhất 'sp_SearchNhanVien' cho cả nạp dữ liệu ban đầu và tìm kiếm
        /// </summary>
        private void LayDanhSachNhanVien(string tuKhoa)
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    // Truyền từ khóa trực tiếp vào Store Procedure (để trống "" nghĩa là lấy toàn bộ)
                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dgvNhanVien.DataSource = dt;

                        if (dgvNhanVien.Columns.Count >= 5)
                        {
                            dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên";
                            dgvNhanVien.Columns[1].HeaderText = "Họ và Tên";
                            dgvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
                            dgvNhanVien.Columns[3].HeaderText = "Tên Phòng Ban";
                            dgvNhanVien.Columns[4].Visible = false; // Ẩn cột mã phòng ẩn ngầm đi
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Sự kiện click nút Tìm kiếm trên giao diện
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Lọc danh sách theo nội dung người dùng nhập
            LayDanhSachNhanVien(txtTimKiem.Text.Trim());
        }

        /// <summary>
        /// Bắt sự kiện nhấn phím trên ô Tìm kiếm: Gõ từ khóa rồi ấn Enter để thực hiện tìm kiếm luôn
        /// </summary>
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Ngắt tiếng kêu 'bíp' của Windows khi nhấn Enter trong TextBox
                btnTimKiem_Click(sender, e);
            }
        }

        // Sự kiện click nút Hiển thị tất cả (hoặc Hủy tìm kiếm)
        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear(); // Dọn trống TextBox tìm kiếm
            LayDanhSachNhanVien(""); // Truyền chuỗi rỗng vào Store để lấy lại toàn bộ danh sách
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text.Trim()) || string.IsNullOrEmpty(txtTenNV.Text.Trim()) || cboPhongBan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaPhong", cboPhongBan.SelectedValue.ToString());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm mới nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Thêm thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhân viên từ danh sách trước khi sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenNV", txtTenNV.Text.Trim());
                    cmd.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text.Trim());
                    cmd.Parameters.AddWithValue("@MaPhong", cboPhongBan.SelectedValue.ToString());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Sửa thất bại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa dữ liệu!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận hành động xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (SqlException ex) when (ex.Number == 547)
                    {
                        MessageBox.Show("Nhân viên này đang tham gia thi công công trình, không thể xóa bỏ!", "Lỗi khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                if (row.Cells.Count >= 5)
                {
                    txtMaNV.Text = row.Cells[0].Value?.ToString();
                    txtTenNV.Text = row.Cells[1].Value?.ToString();
                    txtDiaChi.Text = row.Cells[2].Value?.ToString();

                    if (row.Cells[4].Value != null)
                    {
                        cboPhongBan.SelectedValue = row.Cells[4].Value.ToString();
                    }

                    txtMaNV.Enabled = false;
                    btnThem.Enabled = false;
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtTimKiem.Clear(); // Dọn dẹp sạch ô tìm kiếm khi ClearForm
            if (cboPhongBan.Items.Count > 0) cboPhongBan.SelectedIndex = 0;

            txtMaNV.Enabled = true;
            btnThem.Enabled = true;

            // Gọi hàm với chuỗi rỗng để hiển thị toàn bộ danh sách
            LayDanhSachNhanVien("");
        }
    }
}