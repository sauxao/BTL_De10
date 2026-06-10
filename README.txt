====================================================================
	Dự án: Bài Tập Lớn Quản Lý Nhân Sự Ngành Xây Dựng
====================================================================

- Môi trường: visual studio 2026, C# WinForms (.NET Framework Version=v4.7.2) & SQL Server & SSMS 2022 .
- Công cụ báo cáo: Microsoft ReportViewer (RDLC).
- Lưu ý:  từ visual studio 2022 hết hỗ trợ Crystal Reports nên phần mềm này sẽ thay thế bằng Microsoft ReportViewer


--------------------------------------------------------------------
1. HƯỚNG DẪN CÀI ĐẶT 
--------------------------------------------------------------------
+ Cài đặt Thư viện ReportViewer
Vào menu Tools ->  NuGet Package Manager ->  Package Manager Console. Gõ lệnh sau và ấn Enter:
Install-Package Microsoft.ReportingServices.ReportViewerControl.Winforms
+ Restore file Backup\BTL_QLNhanLucXayDung.bak vào database 
+ Sửa lại chuỗi kết nối Database (Connection String) trong project DAL\DbContext.cs theo server của máy hiện tại

- Chức năng phần mềm:
+ Quản lý: phòng ban, nhân viên, công trình
+ Nghiệp vụ: Phân công nhân viên theo công trình, chấm công
+ Báo cáo: báo cáo công trình đang thực hiện, báo cáo đánh giá chuyên cần nhân viên


--------------------------------------------------------------------
2. CÁC LƯU Ý QUAN TRỌNG KHI CHẠY TRÊN MÁY TÍNH KHÁC
--------------------------------------------------------------------
* Sửa Chuỗi Kết Nối: 
  Vào file cấu hình kết nối database trong code (file DbContext.cs), 
  sửa mục "Data Source=.\SQLEXPRESS" hoặc "Data Source=." để phần mềm 
  tự động kết nối vào hệ thống SQL Server của máy hiện tại.

* Lỗi thiếu thư viện báo cáo: 
  Nếu máy mới báo lỗi không chạy được ReportViewer, hãy mở cửa sổ 
  "Package Manager Console" trong Visual Studio và chạy lệnh:
  Install-Package Microsoft.ReportingServices.ReportViewerControl.Winforms

* File thiết kế báo cáo (.rdlc): 
  Đảm bảo file "rptChuyenCan.rdlc" nằm trong thư mục Reports và đã được 
  chỉnh thuộc tính "Copy to Output Directory = Copy always" trong ô Properties.