using System;
using System.Collections.Generic;
using FormLogin.Models;

namespace FormLogin.Repositories
{
    public class NhanVienRes : BaseRes
    {
        private const string SELECT_BASE = @"
            SELECT nv.MaNhanVien, nv.HoTen, nv.MaPhongBan,
                   pb.TenPhongBan, nv.MaChucVu, cv.TenChucVu,
                   nv.SoDienThoai, nv.Email,
                   COALESCE(tk.TrangThai, 1) AS TrangThai
            FROM   NhanVien nv
            LEFT JOIN PhongBan  pb ON nv.MaPhongBan = pb.MaPhongBan
            LEFT JOIN ChucVu    cv ON nv.MaChucVu   = cv.MaChucVu
            LEFT JOIN TaiKhoan  tk ON nv.MaNhanVien  = tk.MaNhanVien";
        private NhanVien MapRow(System.Data.SQLite.SQLiteDataReader r) => new NhanVien
        {
            MaNhanVien = ReadString(r, "MaNhanVien"),
            HoTen = ReadString(r, "HoTen"),
            MaPhongBan = ReadString(r, "MaPhongBan"),
            TenPhongBan = ReadString(r, "TenPhongBan"),  // ← THÊM VÀO (lỗi 1)
            MaChucVu = ReadString(r, "MaChucVu"),
            TenChucVu = ReadString(r, "TenChucVu"),    // ← THÊM VÀO (lỗi 1)
            SoDienThoai = ReadString(r, "SoDienThoai"),
            Email = ReadString(r, "Email"),
            TrangThai = ReadBool(r, "TrangThai"),       // ← THÊM VÀO (lỗi 1)
        };

        // ── GetAll ────────────────────────────────────────────────────────
        public List<NhanVien> GetAll() =>
            Query(SELECT_BASE + " ORDER BY nv.MaNhanVien", MapRow);

        // ── GetByPhongBan ─────────────────────────────────────────────────
        // Tham số @pb là "parameterized query" — ngăn SQL Injection
        // KHÔNG bao giờ ghép chuỗi: "WHERE MaPhongBan = '" + maPhongBan + "'"
        public List<NhanVien> GetByPhongBan(string maPhongBan) =>
            Query(
                SELECT_BASE + " WHERE nv.MaPhongBan = @pb ORDER BY nv.MaNhanVien",
                MapRow,
                cmd => cmd.Parameters.AddWithValue("@pb", maPhongBan)
            );

        // ── Search ────────────────────────────────────────────────────────
        public List<NhanVien> Search(string keyword) =>
            Query(
                SELECT_BASE + @" WHERE nv.HoTen       LIKE @kw
                                    OR nv.MaNhanVien  LIKE @kw
                                 ORDER BY nv.MaNhanVien",
                MapRow,
                cmd => cmd.Parameters.AddWithValue("@kw", $"%{keyword}%")
            );

        // ── GetById ───────────────────────────────────────────────────────
        public NhanVien GetById(string maNhanVien) =>
            QuerySingle(
                SELECT_BASE + " WHERE nv.MaNhanVien = @ma",
                MapRow,
                cmd => cmd.Parameters.AddWithValue("@ma", maNhanVien)
            );

        // ── Add ───────────────────────────────────────────────────────────
        public bool Add(NhanVien nv)
        {
            int rows = Execute(@"
                INSERT INTO NhanVien
                    (MaNhanVien, HoTen, MaPhongBan, MaChucVu, SoDienThoai, Email)
                VALUES
                    (@ma, @ht, @pb, @cv, @sdt, @email)",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@ma", nv.MaNhanVien);
                    cmd.Parameters.AddWithValue("@ht", nv.HoTen);
                    cmd.Parameters.AddWithValue("@pb", nv.MaPhongBan);
                    cmd.Parameters.AddWithValue("@cv", nv.MaChucVu);
                    cmd.Parameters.AddWithValue("@sdt", nv.SoDienThoai ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", nv.Email ?? (object)DBNull.Value);
                });
            return rows > 0;
        }

        // ── Update ────────────────────────────────────────────────────────
        public bool Update(NhanVien nv)
        {
            int rows = Execute(@"
                UPDATE NhanVien SET
                    HoTen       = @ht,
                    MaPhongBan  = @pb,
                    MaChucVu    = @cv,
                    SoDienThoai = @sdt,
                    Email       = @email
                WHERE MaNhanVien = @ma",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@ma", nv.MaNhanVien);
                    cmd.Parameters.AddWithValue("@ht", nv.HoTen);
                    cmd.Parameters.AddWithValue("@pb", nv.MaPhongBan);
                    cmd.Parameters.AddWithValue("@cv", nv.MaChucVu);
                    cmd.Parameters.AddWithValue("@sdt", nv.SoDienThoai ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@email", nv.Email ?? (object)DBNull.Value);
                });
            return rows > 0;
        }

        // ── SetTrangThai ──────────────────────────────────────────────────
        public bool SetTrangThai(string maNhanVien, bool hoatDong)
        {
            int rows = Execute(
                "UPDATE TaiKhoan SET TrangThai = @tt WHERE MaNhanVien = @ma",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@ma", maNhanVien);
                    cmd.Parameters.AddWithValue("@tt", hoatDong ? 1 : 0);
                });
            return rows > 0;
        }

        // ════════════════════════════════════════════════════════════════════
        // ❌ LỖI 2 TRONG CODE CŨ CỦA CẬU:
        //   public int Count(string maPhongBan = "") =>
        //       ExecuteScalar<int>(
        //           "SELECT COUNT(*) FROM NhanVien" +
        //           (string.IsNullOrEmpty(maPhongBan) ? "" : " WHERE MaPhongBan = @pb")
        //       );   ← THIẾU phần truyền @pb vào command!
        //
        //   → SQL có "WHERE MaPhongBan = @pb" nhưng không có gì gán giá trị cho @pb
        //   → SQLite sẽ báo lỗi: "no such bind parameter: @pb"
        //
        // ✅ CÁCH FIX: Truyền thêm Action<SQLiteCommand> có điều kiện
        // ════════════════════════════════════════════════════════════════════
        public int Count(string maPhongBan = "")
        {
            if (string.IsNullOrEmpty(maPhongBan))
            {
                // Không có điều kiện → không cần truyền param
                return ExecuteScalar<int>("SELECT COUNT(*) FROM NhanVien");
            }
            else
            {
                // Có điều kiện → phải truyền param @pb vào
                return ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM NhanVien WHERE MaPhongBan = @pb",
                    cmd => cmd.Parameters.AddWithValue("@pb", maPhongBan)
                );
            }
        }

        // ── SinhMaNhanVien ────────────────────────────────────────────────
        public string SinhMaNhanVien(string maChucVu, string maPhongBan)
        {
            string pbCode = maPhongBan.Replace("PB", "");
            int stt = ExecuteScalar<int>(
                "SELECT COUNT(*)+1 FROM NhanVien WHERE MaChucVu=@cv AND MaPhongBan=@pb",
                cmd =>
                {
                    cmd.Parameters.AddWithValue("@cv", maChucVu);
                    cmd.Parameters.AddWithValue("@pb", maPhongBan);
                });
            return $"NV{maChucVu}{pbCode}{stt:D3}";
        }
    }
}