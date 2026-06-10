using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using BTL_QLNhanSuXayDung.DAL;
using Microsoft.Reporting.WinForms;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormBaoCaoChuyenCan : Form
    {
        public FormBaoCaoChuyenCan()
        {
            InitializeComponent();
        }

        private void FormBaoCaoChuyenCan_Load(object sender, EventArgs e)
        {
            // Tự động lấy Tháng / Năm hiện tại của hệ thống máy tính
            nudThang.Value = DateTime.Now.Month;
            nudNam.Value = DateTime.Now.Year;

            // LƯU Ý: Không gọi TaiDuLieuLenLuoi() ở đây nữa, vì khi gán Value ở 2 dòng trên,
            // sự kiện ValueChanged sẽ tự kích hoạt và nạp dữ liệu lên lưới rồi!
        }

        private void TaiDuLieuLenLuoi()
        {
            int thang = (int)nudThang.Value;
            int nam = (int)nudNam.Value;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_BaoCaoChuyenCanNhanVienTheoThang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        da.Fill(dt);
                        dgvChuyenCan.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi nạp dữ liệu lên bảng: " + ex.Message, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void nudThang_ValueChanged(object sender, EventArgs e)
        {
            TaiDuLieuLenLuoi();
        }

        private void nudNam_ValueChanged(object sender, EventArgs e)
        {
            TaiDuLieuLenLuoi();
        }

        private void btnXemBaoCao_Click(object sender, EventArgs e)
        {
            int thang = (int)nudThang.Value;
            int nam = (int)nudNam.Value;

            using (SqlConnection conn = DbContext.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand("sp_BaoCaoChuyenCanNhanVienTheoThang", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Thang", thang);
                    cmd.Parameters.AddWithValue("@Nam", nam);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dt.CaseSensitive = false; // Bỏ qua phân biệt chữ hoa/thường để mapping cột chính xác

                    try
                    {
                        da.Fill(dt);

                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show($"Tháng {thang}/{nam} không có dữ liệu chấm công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        FormXemBaoCao frmIn = new FormXemBaoCao();
                        frmIn.reportViewer1.LocalReport.ReportPath = "Reports\\rptChuyenCan.rdlc";
                        frmIn.reportViewer1.LocalReport.DataSources.Clear();

                        // Đổ dữ liệu vào đúng DataSet cấu hình trên file rdlc
                        ReportDataSource rds = new ReportDataSource("DataSetChuyenCan", dt);
                        frmIn.reportViewer1.LocalReport.DataSources.Add(rds);

                        // Đẩy tham số chuỗi hiển thị lên tiêu đề phụ của báo cáo
                        ReportParameter[] rptParams = new ReportParameter[] {
                            new ReportParameter("paThangNam", $"{thang} năm {nam}")
                        };
                        frmIn.reportViewer1.LocalReport.SetParameters(rptParams);

                        frmIn.reportViewer1.RefreshReport();
                        frmIn.ShowDialog();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xuất báo cáo: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}