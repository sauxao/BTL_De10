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
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            TaiDanhSachPhongBanIntoCombobox();
            ResetForm();
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

        private void LayDanhSachNhanVien()
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TuKhoa", "");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dgvNhanVien.DataSource = dt;

                        dgvNhanVien.Columns[0].HeaderText = "Mã Nhân Viên"; // Cột MaNV từ Store đổ ra
                        dgvNhanVien.Columns[1].HeaderText = "Họ và Tên";
                        dgvNhanVien.Columns[2].HeaderText = "Địa Chỉ";
                        dgvNhanVien.Columns[3].HeaderText = "Tên Phòng Ban";
                        dgvNhanVien.Columns[4].Visible = false; // Ẩn mã phòng ẩn ngầm đi
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txtTenNV.Text) || cboPhongBan.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng điền đầy đủ các thông tin bắt buộc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim()); // Đổi thành @MaNV khớp với Store
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
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim()); // Đổi thành @MaNV khớp với Store
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
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;
            if (MessageBox.Show("Bạn có thực sự muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteNhanVien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text.Trim()); // Đổi thành @MaNV khớp với Store

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
                    txtMaNV.Text = row.Cells[0].Value?.ToString(); // Lấy giá trị MaNV từ lưới đổ lên TextBox
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
            if (cboPhongBan.Items.Count > 0) cboPhongBan.SelectedIndex = 0;

            txtMaNV.Enabled = true;
            btnThem.Enabled = true;
            LayDanhSachNhanVien();
        }
    }
}