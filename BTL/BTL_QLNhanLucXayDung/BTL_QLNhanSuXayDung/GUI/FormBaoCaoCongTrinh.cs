using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.DAL;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormBaoCaoCongTrinh : Form
    {
        public FormBaoCaoCongTrinh()
        {
            InitializeComponent();
        }

        private void FormBaoCaoCongTrinh_Load(object sender, EventArgs e)
        {
            TaiDuLieuBaoCao();
        }

        /// <summary>
        /// Nạp dữ liệu vào lưới hiển thị trên giao diện từ SQL Server
        /// </summary>
        private void TaiDuLieuBaoCao()
        {
            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_BaoCaoCongTrinhDangThucHien", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    try
                    {
                        da.Fill(dt);
                        dgvBaoCao.DataSource = dt;
                        lblTongSo.Text = "Tổng số công trình đang thực hiện: " + dt.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể lấy dữ liệu thống kê: " + ex.Message, "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnTaiLai_Click(object sender, EventArgs e)
        {
            TaiDuLieuBaoCao();
        }

        /// <summary>
        /// Logic xuất dữ liệu từ DataGridView ra file Excel dạng CSV nhanh gọn
        /// </summary>
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trên lưới để kết xuất Excel!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel CSV Files (*.csv)|*.csv";
            sfd.FileName = "ThongKe_TienDo_CongTrinh.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int columnCount = dgvBaoCao.Columns.Count;
                    string columnNames = "";
                    string[] outputCsv = new string[dgvBaoCao.Rows.Count + 1];

                    for (int i = 0; i < columnCount; i++)
                    {
                        columnNames += dgvBaoCao.Columns[i].HeaderText.ToString() + ",";
                    }
                    outputCsv[0] = columnNames;

                    for (int i = 1; (i - 1) < dgvBaoCao.Rows.Count; i++)
                    {
                        for (int j = 0; j < columnCount; j++)
                        {
                            var val = dgvBaoCao.Rows[i - 1].Cells[j].Value;
                            outputCsv[i] += (val != null ? val.ToString().Replace(",", " ") : "") + ",";
                        }
                    }

                    System.IO.File.WriteAllLines(sfd.FileName, outputCsv, System.Text.Encoding.UTF8);
                    MessageBox.Show("Xuất file báo cáo thống kê Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra khi lưu file: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Sự kiện Click nút mở màn hình xem bản in Report RDLC Microsoft
        /// </summary>
        private void btnInBaoCao_Click(object sender, EventArgs e)
        {
            // 1. Khởi tạo thực thể Form phụ xem báo cáo
            FormXemBaoCao frmIn = new FormXemBaoCao();

            // 2. Gọi hàm nạp dữ liệu động từ database đẩy thẳng vào file RDLC
            frmIn.NapDuLieuVaoReport();

            // 3. Kích hoạt hiển thị Form
            frmIn.ShowDialog();
        }
    }
}