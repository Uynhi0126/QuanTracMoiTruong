namespace FormLogin.Models
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string MaPhongBan { get; set; }
        public string TenPhongBan { get; set; }  // JOIN từ bảng PhongBan
        public string MaChucVu { get; set; }
        public string TenChucVu { get; set; }  // JOIN từ bảng ChucVu
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public bool TrangThai { get; set; }  // true = hoạt động
    
    public string TenPhongBanHienThi
            {
                get
                {
                    switch (TenPhongBan)
                    {
                        case "Kinh doanh": return "Kinh doanh";
                        case "Ke hoach": return "Kế hoạch";
                        case "Hien truong": return "Hiện trường";
                        case "Thi nghiem": return "Thí nghiệm";
                        case "Ket qua": return "Kết quả";
                        default: return TenPhongBan ?? "";
                    }
                }
            }

            public string TenChucVuHienThi
            {
                get
                {
                    switch (TenChucVu)
                    {
                        case "Admin": return "Admin";
                        case "Truong phong": return "Trưởng phòng";
                        case "Nhan vien": return "Nhân viên";
                        default: return TenChucVu ?? "";
                    }
                }
            }

            // TrangThaiHienThi — Dùng trực tiếp khi bind vào DataGridView
            public string TrangThaiHienThi => TrangThai ? "Hoạt động" : "Đã khóa";
        }
    }

