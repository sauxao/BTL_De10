using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.DAL;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormPhongBan : Form
    {
        public FormPhongBan()
        {
            InitializeComponent();

            // KÍCH HOẠT PHÍM TẮT: Cho phép Form đánh chặn và nhận diện phím bấm trước các điều khiển con
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormPhongBan_KeyDown);
        }

        private void FormPhongBan_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        /// <summary>
        /// Bộ lắng nghe sự kiện Phím tắt toàn diện cho hệ thống (F1, F2, F3, F4, ESC)
        /// </summary>
        private void FormPhongBan_KeyDown(object sender, KeyEventArgs e)
        {
            // Phím F1: Kích hoạt Thêm mới dữ liệu
            if (e.KeyCode == Keys.F1 && btnThem.Enabled)
            {
                e.Handled = true; // Ngăn chặn tiếng bíp thông báo của Windows
                btnThem_Click(sender, e);
            }
            // Phím F2: Kích hoạt Sửa / Cập nhật dữ liệu
            else if (e.KeyCode == Keys.F2)
            {
                e.Handled = true;
                btnSua_Click(sender, e);
            }
            // Phím F3: Kích hoạt Xóa bản ghi
            else if (e.KeyCode == Keys.F3)
            {
                e.Handled = true;
                btnXoa_Click(sender, e);
            }
            // Phím F4: Làm mới toàn bộ ô nhập liệu (Clear)
            else if (e.KeyCode == Keys.F4)
            {
                e.Handled = true;
                btnLamMoi_Click(sender, e);
            }
            // Phím ESC: Đóng nhanh Form con để quay lại Dashboard
            else if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        private void LayDanhSachPhongBan()
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchPhongBan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TuKhoa", ""); // Để trống để lấy toàn bộ

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dgvPhongBan.DataSource = dt;
                        dgvPhongBan.Columns[0].HeaderText = "Mã Phòng Ban";
                        dgvPhongBan.Columns[1].HeaderText = "Tên Phòng Ban";
                    }
                    catch (Exception ex) { MessageBox.Show("Lỗi tải danh sách: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text.Trim()) || string.IsNullOrEmpty(txtTenPhong.Text.Trim()))
            {
                MessageBox.Show("Vui lòng điền đầy đủ Mã phòng và Tên phòng!", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertPhongBan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm phòng ban thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi thực thi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn một phòng ban từ danh sách trước khi sửa!", "Cảnh báo dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdatePhongBan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());
                    cmd.Parameters.AddWithValue("@TenPhong", txtTenPhong.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi thực thi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaPhong.Text.Trim()))
            {
                MessageBox.Show("Vui lòng chọn phòng ban cần xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa phòng ban này không?", "Xác nhận xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeletePhongBan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaPhong", txtMaPhong.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa phòng ban thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (SqlException ex) when (ex.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa vì đang có hồ sơ nhân viên thuộc biên chế của phòng ban này!", "Lỗi ràng buộc khóa ngoại", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void dgvPhongBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaPhong.Text = dgvPhongBan.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtTenPhong.Text = dgvPhongBan.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMaPhong.Enabled = false; // Khóa trường khóa chính tránh lỗi sửa nhầm ID gốc
                btnThem.Enabled = false;    // Vô hiệu hóa nút thêm để tránh trùng lặp thực thể
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtMaPhong.Clear();
            txtTenPhong.Clear();
            txtMaPhong.Enabled = true;
            btnThem.Enabled = true;
            LayDanhSachPhongBan();
        }
    }
}