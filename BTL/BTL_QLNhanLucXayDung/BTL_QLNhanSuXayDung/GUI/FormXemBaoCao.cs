using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BTL_QLNhanSuXayDung.DAL;

namespace BTL_QLNhanSuXayDung.GUI
{
    public partial class FormXemBaoCao : Form
    {
        public FormXemBaoCao()
        {
            InitializeComponent();
        }

        public void NapDuLieuVaoReport()
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

                        // Thiết lập đường dẫn tương đối tới file .rdlc trong thư mục chạy bin\Debug\Reports
                        reportViewer1.LocalReport.ReportPath = "Reports\\rptBaoCaoCongTrinh.rdlc";

                        reportViewer1.LocalReport.DataSources.Clear();

                        // Tên "DataSetBaoCao" ở đây phải trùng khớp 100% với Name bạn đặt ở Bước 2
                        ReportDataSource rds = new ReportDataSource("DataSetBaoCao", dt);

                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi nạp báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}