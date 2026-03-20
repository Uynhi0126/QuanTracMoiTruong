using System;

namespace FormLogin.Models
{
    public class TaiKhoan
    {
        public string MaNhanVien { get; set; } 
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}