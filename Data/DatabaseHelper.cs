using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace FormLogin
{
    public static class DatabaseHelper
    {

        // Tự động tìm file .db dù chạy từ Debug hay Release
        private static string DbPath => Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "quantrac_test_v3.db"  // <-- đổi thành tên file .db của cậu
        );

        public static string ConnectionString =>
            $"Data Source={DbPath};Version=3;";

        public static bool KiemTraKetNoi()
        {
            if (!File.Exists(DbPath))
            {
                MessageBox.Show(
                    $"Không tìm thấy file database!\nĐường dẫn: {DbPath}",
                    "Lỗi Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}