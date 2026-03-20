using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace FormLogin.Repositories
{
    /// <summary>
    /// Lớp cha chứa các phương thức query dùng chung cho mọi bảng.
    /// Mọi Repository đều kế thừa từ đây — thay thế DbContext của EF.
    ///
    /// Cách dùng:
    ///   public class NhanVienRepository : BaseRepository { ... }
    ///   public class KhachHangRepository : BaseRepository { ... }
    ///   → Không cần viết lại GetConnection() hay xử lý lỗi nữa
    /// </summary>
    public abstract class BaseRes
    {
        protected string ConnectionString => DatabaseHelper.ConnectionString;

        /// <summary>Mở kết nối SQLite — luôn dùng trong using() để tự đóng.</summary>
        protected SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(ConnectionString);
            conn.Open();
            return conn;
        }

        // ════════════════════════════════════════════════════════════════
        // QUERY — Tương đương .Where(...).ToList() trong EF
        // Trả về List<T>, T là class Model bất kỳ
        //
        // Ví dụ:
        //   var ds = Query("SELECT * FROM NhanVien WHERE MaPhongBan=@pb",
        //                  r => new NhanVien { HoTen = r["HoTen"].ToString() },
        //                  cmd => cmd.Parameters.AddWithValue("@pb", "PB01"));
        // ════════════════════════════════════════════════════════════════
        protected List<T> Query<T>(
            string sql,
            Func<SQLiteDataReader, T> map,
            Action<SQLiteCommand> addParams = null)
        {
            var results = new List<T>();
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                addParams?.Invoke(cmd);
                using (var reader = cmd.ExecuteReader())
                    while (reader.Read())
                        results.Add(map(reader));
            }
            return results;
        }

        // ════════════════════════════════════════════════════════════════
        // QUERY SINGLE — Tương đương .FirstOrDefault(...) trong EF
        // Trả về 1 object hoặc null
        // ════════════════════════════════════════════════════════════════
        protected T QuerySingle<T>(
            string sql,
            Func<SQLiteDataReader, T> map,
            Action<SQLiteCommand> addParams = null)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                addParams?.Invoke(cmd);
                using (var reader = cmd.ExecuteReader())
                    if (reader.Read()) return map(reader);
            }
            return default;
        }

        // ════════════════════════════════════════════════════════════════
        // EXECUTE — Tương đương .SaveChanges() trong EF
        // Dùng cho INSERT, UPDATE, DELETE
        // Trả về số dòng bị ảnh hưởng (>0 = thành công)
        // ════════════════════════════════════════════════════════════════
        protected int Execute(
            string sql,
            Action<SQLiteCommand> addParams = null)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                addParams?.Invoke(cmd);
                return cmd.ExecuteNonQuery();
            }
        }

        // ════════════════════════════════════════════════════════════════
        // EXECUTE TRANSACTION — Dùng khi cần INSERT nhiều bảng cùng lúc
        // Ví dụ: thêm NhanVien + tạo TaiKhoan → phải thành công cả 2
        // Nếu 1 bước lỗi → tự động rollback về trạng thái ban đầu
        // ════════════════════════════════════════════════════════════════
        protected bool ExecuteTransaction(Action<SQLiteConnection, SQLiteTransaction> work)
        {
            using (var conn = GetConnection())
            using (var tx = conn.BeginTransaction())
            {
                try
                {
                    work(conn, tx);
                    tx.Commit();
                    return true;
                }
                catch
                {
                    tx.Rollback();
                    return false;
                }
            }
        }

        // ════════════════════════════════════════════════════════════════
        // EXECUTE SCALAR — Tương đương .Count() / .Max() trong EF
        // Trả về 1 giá trị đơn (int, string, ...)
        // ════════════════════════════════════════════════════════════════
        protected T ExecuteScalar<T>(
            string sql,
            Action<SQLiteCommand> addParams = null)
        {
            using (var conn = GetConnection())
            using (var cmd = new SQLiteCommand(sql, conn))
            {
                addParams?.Invoke(cmd);
                var result = cmd.ExecuteScalar();
                if (result == null || result == DBNull.Value) return default;
                return (T)Convert.ChangeType(result, typeof(T));
            }
        }

        // ════════════════════════════════════════════════════════════════
        // HELPER: Đọc giá trị từ reader an toàn (trả về "" thay vì crash)
        // ════════════════════════════════════════════════════════════════
        protected static string ReadString(SQLiteDataReader r, string col)
        {
            int idx = r.GetOrdinal(col);
            return r.IsDBNull(idx) ? "" : r.GetString(idx);
        }

        protected static bool ReadBool(SQLiteDataReader r, string col)
        {
            int idx = r.GetOrdinal(col);
            return !r.IsDBNull(idx) && r.GetInt32(idx) == 1;
        }
    }
}