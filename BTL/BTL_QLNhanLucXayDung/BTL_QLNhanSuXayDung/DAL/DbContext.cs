using System.Data.SqlClient;

namespace BTL_QLNhanSuXayDung.DAL
{
    public class DbContext
    {
        // Chuỗi kết nối đến database của bạn 
        private static string connectionString = @"Server=.;Database=BTL_QLNhanLucXayDung;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}