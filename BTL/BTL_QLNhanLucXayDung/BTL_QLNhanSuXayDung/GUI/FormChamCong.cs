using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.DAL;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormChamCong : Form
    {
        // Biến lưu trữ Mã Nhật Ký đang chọn từ DataGridView để phục vụ Sửa/Xóa
        private int maNhatKyDangChon = -1;

        public FormChamCong()
        {
            InitializeComponent();
        }

        private void FormChamCong_Load(object sender, EventArgs e)
        {
            TaiNhanVienVaoCombobox();

            // Tự động load danh sách công trình dựa theo nhân viên đầu tiên (nếu có)
            if (cboNhanVien.SelectedValue != null)
            {
                TaiCongTrinhTheoNhanVien(cboNhanVien.SelectedValue.ToString());
            }

            NapTrangThaiMacDinh();
            ResetForm();
        }

        private void TaiNhanVienVaoCombobox()
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                // RÀNG BUỘC: Chỉ lấy những nhân viên đã thực sự được phân công trong bảng thi công
                string query = @"SELECT DISTINCT nv.MaNV, nv.TenNV 
                                FROM tblNhanvien nv 
                                INNER JOIN tblThiCong tc ON nv.MaNV = tc.MaNV";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    cboNhanVien.DataSource = dt;
                    cboNhanVien.DisplayMember = "TenNV";
                    cboNhanVien.ValueMember = "MaNV";

                    // Hủy đăng ký sự kiện cũ (nếu có) và đăng ký lại để tránh chạy trùng lặp
                    cboNhanVien.SelectedIndexChanged -= CboNhanVien_SelectedIndexChanged;
                    cboNhanVien.SelectedIndexChanged += CboNhanVien_SelectedIndexChanged;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CboNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi người dùng chọn nhân viên khác, tự động load lại các công trình của nhân viên đó
            if (cboNhanVien.SelectedValue != null && cboNhanVien.SelectedValue is string)
            {
                string maNV = cboNhanVien.SelectedValue.ToString();
                TaiCongTrinhTheoNhanVien(maNV);
            }
        }

        private void TaiCongTrinhTheoNhanVien(string maNV)
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                // RÀNG BUỘC: Chỉ tải các công trình mà nhân viên này đang tham gia thi công
                string query = @"SELECT ct.MaCongTrinh, ct.TenCongTrinh 
                                FROM tblCongtrinh ct
                                INNER JOIN tblThiCong tc ON ct.MaCongTrinh = tc.MaCongTrinh
                                WHERE tc.MaNV = @MaNV";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    cboCongTrinh.DataSource = dt;
                    cboCongTrinh.DisplayMember = "TenCongTrinh";
                    cboCongTrinh.ValueMember = "MaCongTrinh";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải công trình theo nhân viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NapTrangThaiMacDinh()
        {
            cboTrangThai.Items.Clear();
            cboTrangThai.Items.Add("Đi làm");
            cboTrangThai.Items.Add("Nghỉ phép");
            cboTrangThai.Items.Add("Nghỉ không phép");
            cboTrangThai.SelectedIndex = 0;
        }

        private void LayDanhSachChamCong(string tuKhoa = "")
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchChamCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TuKhoa", tuKhoa);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dgvChamCong.DataSource = dt;

                        if (dgvChamCong.Columns.Count >= 8)
                        {
                            dgvChamCong.Columns[0].HeaderText = "Mã Nhật Ký";
                            dgvChamCong.Columns[1].HeaderText = "Ngày Chấm";
                            dgvChamCong.Columns[2].HeaderText = "Mã NV";
                            dgvChamCong.Columns[3].HeaderText = "Tên Nhân Viên";
                            dgvChamCong.Columns[4].HeaderText = "Mã Công Trình";
                            dgvChamCong.Columns[5].HeaderText = "Tên Công Trình";
                            dgvChamCong.Columns[6].HeaderText = "Trạng Thái";
                            dgvChamCong.Columns[7].HeaderText = "Ghi Chú";

                            dgvChamCong.Columns[0].Width = 80;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tải dữ liệu nhật ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cboNhanVien.SelectedValue == null || cboCongTrinh.SelectedValue == null)
            {
                MessageBox.Show("Dữ liệu nhân viên hoặc công trình trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_InsertChamCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NgayCham", dtpNgayCham.Value.Date);
                    cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaCongTrinh", cboCongTrinh.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Thêm nhật ký chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi kết quả", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maNhatKyDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn một bản ghi dưới danh sách trước khi sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_UpdateChamCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNhatKy", maNhatKyDangChon);
                    cmd.Parameters.AddWithValue("@NgayCham", dtpNgayCham.Value.Date);
                    cmd.Parameters.AddWithValue("@MaNV", cboNhanVien.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@MaCongTrinh", cboCongTrinh.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@TrangThai", cboTrangThai.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text.Trim());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật nhật ký chấm công thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maNhatKyDangChon == -1)
            {
                MessageBox.Show("Vui lòng chọn nhật ký cần xóa dưới danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn xóa nhật ký chấm công này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No) return;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_DeleteChamCong", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MaNhatKy", maNhatKyDangChon);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa nhật ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ResetForm();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void dgvChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvChamCong.Rows.Count)
            {
                DataGridViewRow row = dgvChamCong.Rows[e.RowIndex];
                if (row.Cells.Count >= 8)
                {
                    maNhatKyDangChon = Convert.ToInt32(row.Cells[0].Value);

                    if (DateTime.TryParse(row.Cells[1].Value?.ToString(), out DateTime ngayCham))
                        dtpNgayCham.Value = ngayCham;

                    // THỨ TỰ ĐỒNG BỘ: Chọn Nhân viên trước -> Ép load lại danh sách công trình của NV đó -> Chọn Công trình
                    string maNV = row.Cells[2].Value?.ToString();
                    cboNhanVien.SelectedValue = maNV;

                    TaiCongTrinhTheoNhanVien(maNV);
                    cboCongTrinh.SelectedValue = row.Cells[4].Value?.ToString();

                    cboTrangThai.SelectedItem = row.Cells[6].Value?.ToString();
                    txtGhiChu.Text = row.Cells[7].Value?.ToString();

                    btnThem.Enabled = false;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LayDanhSachChamCong(txtTimKiem.Text.Trim());
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            txtGhiChu.Clear();
            txtTimKiem.Clear();
            dtpNgayCham.Value = DateTime.Now;
            maNhatKyDangChon = -1;

            if (cboNhanVien.Items.Count > 0) cboNhanVien.SelectedIndex = 0;

            // Làm mới lại danh sách công trình khớp với nhân viên đang được chọn mặc định
            if (cboNhanVien.SelectedValue != null)
            {
                TaiCongTrinhTheoNhanVien(cboNhanVien.SelectedValue.ToString());
            }

            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;

            btnThem.Enabled = true;
            LayDanhSachChamCong();
        }
    }
}