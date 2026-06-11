using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.DAL;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormThiCong : Form
    {
        public FormThiCong()
        {
            InitializeComponent();

            // KÍCH HOẠT PHÍM TẮT: Cho phép Form đánh chặn và xử lý phím bấm trước các điều khiển con
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormThiCong_KeyDown);
        }

        private void FormThiCong_Load(object sender, EventArgs e)
        {
            TaiNhanVienVaoCombobox();
            TaiCongTrinhVaoCombobox();
            ResetForm();
        }

        /// <summary>
        /// Bộ lắng nghe và điều hướng sự kiện phím tắt toàn cục cho Phân hệ Phân công Thi công
        /// </summary>
        private void FormThiCong_KeyDown(object sender, KeyEventArgs e)
        {
            // Phím F1: Kích hoạt Thêm mới phân công thi công
            if (e.KeyCode == Keys.F1 && btnThem.Enabled)
            {
                e.Handled = true; // Ngăn chặn âm thanh bíp mặc định của Windows
                btnThem_Click(sender, e);
            }
            // Phím F2: Kích hoạt Sửa số ngày công
            else if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                btnSua_Click(sender, e);
            }
            // Phím F3: Kích hoạt Xóa/Hủy phân công thi công
            else if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                btnXoa_Click(sender, e);
            }
            // Phím F4: Làm mới Form và nạp lại danh sách gốc từ hệ thống
            else if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                btnLamMoi_Click(sender, e);
            }
            // Phím F5: Kích hoạt tìm kiếm
            if (e.KeyCode == Keys.F5)
            {
                e.Handled = true; // Ngăn hành động refresh mặc định nếu có của Windows
                LayDanhSachThiCong(txtTimKiem.Text.Trim());
            }
            // Phím ESC: Thoát nhanh form thi công để quay lại bảng điều hướng chính
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        private void TaiNhanVienVaoCombobox()
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                string query = "SELECT MaNV, TenNV FROM tblNhanvien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    cboNhanVien.DataSource = dt;
                    cboNhanVien.DisplayMember = "TenNV";
                    cboNhanVien.ValueMember = "MaNV";
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tải nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void TaiCongTrinhVaoCombobox()
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                string query = "SELECT MaCongTrinh, TenCongTrinh FROM tblCongtrinh";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    cboCongTrinh.DataSource = dt;
                    cboCongTrinh.DisplayMember = "TenCongTrinh";
                    cboCongTrinh.ValueMember = "MaCongTrinh";
                }
                catch (Exception ex) { MessageBox.Show("Lỗi tải công trình: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void LayDanhSachThiCong(string tuKhoa = "")
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchThiCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dgvThiCong.DataSource = dt;

                        // Định dạng lại tên tiêu đề cột hiển thị trên DataGridView
                        if (dgvThiCong.Columns.Count >= 5)
                        {
                            dgvThiCong.Columns[0].HeaderText = "Mã NV";
                            dgvThiCong.Columns[1].HeaderText = "Tên Nhân Viên";
                            dgvThiCong.Columns[2].HeaderText = "Mã Công Trình";
                            dgvThiCong.Columns[3].HeaderText = "Tên Công Trình";
                            dgvThiCong.Columns[4].HeaderText = "Số Ngày Công";
                        }
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách thi công: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        // Chức năng THÊM MỚI phân công thi công
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboCongTrinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng lựa chọn đầy đủ Nhân viên và Công trình!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoNgayCong.Text.Trim(), out int soNgayCong) || soNgayCong < 0)
            {
                MessageBox.Show("Số ngày công phải là số nguyên dương hợp lệ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertThiCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaCongTrinh", cboCongTrinh.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SoNgayCong", soNgayCong);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Phân công thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi xử lý dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        // Chức năng SỬA số ngày công
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboCongTrinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin phân công dưới danh sách trước khi sửa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtSoNgayCong.Text.Trim(), out int soNgayCong) || soNgayCong < 0)
            {
                MessageBox.Show("Số ngày công để sửa đổi phải là một số nguyên dương!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateThiCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaCongTrinh", cboCongTrinh.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@SoNgayCong", soNgayCong);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật số ngày công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        // Chức năng XÓA phân công thi công
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboCongTrinh.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin phân công dưới danh sách trước khi xóa!", "Nhắc nhở", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn hủy phân công thi công của nhân viên này tại công trình đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteThiCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaCongTrinh", cboCongTrinh.SelectedValue.ToString());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa phân công thi công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        // Sự kiện click chọn dòng dữ liệu an toàn trên DataGridView
        private void dgvThiCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvThiCong.Rows.Count)
            {
                DataGridViewRow row = dgvThiCong.Rows[e.RowIndex];
                if (row.Cells.Count >= 5)
                {
                    cboNhanVien.SelectedValue = row.Cells[0].Value?.ToString();
                    cboCongTrinh.SelectedValue = row.Cells[2].Value?.ToString();
                    txtSoNgayCong.Text = row.Cells[4].Value?.ToString();

                    // Khóa thay đổi Khóa chính phức hợp khi sửa/xóa
                    cboNhanVien.Enabled = false;
                    cboCongTrinh.Enabled = false;
                    btnThem.Enabled = false;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LayDanhSachThiCong(txtTimKiem.Text.Trim());
        }

        /// <summary>
        /// Bổ sung sự kiện KeyDown riêng cho TextBox Tìm kiếm: Gõ từ khóa rồi ấn Enter để thực thi tìm kiếm luôn
        /// </summary>
        private void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Triệt tiêu tiếng chuông cảnh báo hệ thống
                btnTimKiem_Click(sender, e);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtSoNgayCong.Clear();
            txtTimKiem.Clear();

            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;
            if (cboCongTrinh.Items.Count > 0) cboCongTrinh.SelectedIndex = 0;

            cboNhanVien.Enabled = true;
            cboCongTrinh.Enabled = true;
            btnThem.Enabled = true;

            LayDanhSachThiCong();
        }
    }
}