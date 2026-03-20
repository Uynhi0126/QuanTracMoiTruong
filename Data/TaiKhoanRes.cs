using FormLogin.Models;
using FormLogin.Repositories;

public class TaiKhoanRes : BaseRes
{
    public bool VerifyLogin(string user, string pass)
    {
        string hashedPass = MaHoaMatKhau(pass);
        string sql = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @u AND MatKhau = @p AND TrangThai = 1";
        int count = ExecuteScalar<int>(sql, cmd =>
        {
            cmd.Parameters.AddWithValue("@u", user);
            cmd.Parameters.AddWithValue("@p", hashedPass);
        });
        return count > 0;
    }
    //public NhanVien Login(string username, string passwordRaw)
    //{
    //    string hashedPassword = MaHoaMatKhau(passwordRaw);

    //    string sql = @"
    //    SELECT nv.*, pb.TenPhongBan, cv.TenChucVu 
    //    FROM TaiKhoan tk
    //    JOIN NhanVien nv ON tk.MaNhanVien = nv.MaNhanVien
    //    JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan
    //    JOIN ChucVu cv ON nv.MaChucVu = cv.MaChucVu
    //    WHERE tk.TenDangNhap = @user AND tk.MatKhau = @pass AND tk.TrangThai = 1";

    //    return Query(sql,
    //        r => MapRow(r, "MaNhanVien"),
    //        cmd =>
    //        {
    //            cmd.Parameters.AddWithValue("@user", username);
    //            cmd.Parameters.AddWithValue("@pass", hashedPassword);
    //        }
    //    ).FirstOrDefault();
    //}

    // Hàm hỗ trợ mã hóa (Ví dụ MD5 hoặc SHA256 tùy dự án của bạn)
    private string MaHoaMatKhau(string pass)
    {

        return pass;
    }
}