using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace FormLogin
{
    public partial class FormSuaNV : Form
    {
        // ================================================================
        // 1. KHAI BÁO MÀU SẮC DÙNG ĐỂ BÁO LỖI VÀ KHÓA Ô
        // ================================================================
        private Color defaultBorderColor = Color.FromArgb(213, 218, 223);
        private Color errorBorderColor = Color.Red;
        private Color defaultPlaceholderColor = Color.FromArgb(125, 137, 149);
        private Color lockedFillColor = Color.FromArgb(226, 226, 226); // Màu xám cho ô bị khóa

        public FormSuaNV()
        {
            InitializeComponent();

            // ==========================================
            // KHÓA MÃ NV VÀ TÊN NV (KHÔNG CHO CHỈNH SỬA)
            // ==========================================
            tbMNV.ReadOnly = true;
            tbMNV.FillColor = lockedFillColor; // Đổi nền thành màu xám

            tbTenNV.ReadOnly = true;
            tbTenNV.FillColor = lockedFillColor; // Đổi nền thành màu xám

            // ==========================================
            // ĐĂNG KÝ SỰ KIỆN CHO AVATAR
            // ==========================================
            // Vì tên không đổi được nữa, ta chỉ cần bắt sự kiện khi người dùng dán URL ảnh mới
            guna2TextBox2.TextChanged += (s, e) => CapNhatAvatarPreview();

            picBoxAnhNV.LoadCompleted += (s, e) =>
            {
                if (e.Error != null) // Nếu ảnh tải về bị lỗi (Link die)
                {
                    DrawAvatarChữ(tbTenNV.Text.Trim());
                }
            };

            // Bắt sự kiện nút Lưu (Lưu ý: Đổi tên btnTaoTK thành tên nút Lưu của bạn nếu cần)
            btnTaoTK.Click += BtnLuu_Click;
            btnXoa.Click += (s, e) => this.Close(); // Nút hủy/đóng form
        }

        private void FormSuaNV_Load(object sender, EventArgs e)
        {
            // GIẢ LẬP DỮ LIỆU ĐƯỢC TRUYỀN VÀO TỪ BẢNG ADMIN (Để test)
            // Thực tế bạn sẽ truyền dữ liệu từ Form Admin sang các ô này
            if (string.IsNullOrWhiteSpace(tbMNV.Text))
            {
                tbMNV.Text = "NV007";
                tbTenNV.Text = "Nguyễn Văn Admin";
                cbPhongBan.SelectedIndex = 1;
                cbVaiTro.SelectedIndex = 1;
            }

            // Mở form lên thì load ảnh đại diện ngay
            CapNhatAvatarPreview();
        }

        // ================================================================
        // 2. CÁC HÀM HỖ TRỢ HIỂN THỊ LỖI GIAO DIỆN
        // ================================================================
        private void BaoLoiTextBox(Guna2TextBox tb, string cauThongBao)
        {
            tb.BorderColor = errorBorderColor;
            tb.PlaceholderForeColor = errorBorderColor;
            tb.PlaceholderText = cauThongBao;
        }

        private void ResetTextBox(Guna2TextBox tb, string chuMoBanDau)
        {
            tb.BorderColor = defaultBorderColor;
            tb.PlaceholderForeColor = defaultPlaceholderColor;
            tb.PlaceholderText = chuMoBanDau;
        }

        private void ResetErrors()
        {
            ResetTextBox(tbSDT, "0901234567"/*Thay bằng số điện thoại hiện tại trên DB */ );
            ResetTextBox(tbEmail, "nv@mtrxanh.vn"/*Thay bằng email hiện tại trên DB */);
            ResetTextBox(tbDiaChi, "VD: 123 Lê Lợi..."/*Thay bằng địa chỉ hiện tại trên DB */);
            ResetTextBox(guna2TextBox2, "Dán link ảnh..."/*Thay bằng địa chỉ hiện tại trên DB */);

            cbPhongBan.BorderColor = defaultBorderColor;
            cbVaiTro.BorderColor = defaultBorderColor;
        }

        // ================================================================
        // 3. BỘ NÃO XỬ LÝ AVATAR TỰ ĐỘNG
        // ================================================================
        private string GetInitials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return "👤";
            string[] words = fullName.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 1) return words[0].Substring(0, 1).ToUpper();

            string first = words[words.Length - 2].Substring(0, 1).ToUpper();
            string second = words[words.Length - 1].Substring(0, 1).ToUpper();
            return first + second;
        }

        private void DrawAvatarChữ(string fullName)
        {
            int size = picBoxAnhNV.Width > 0 ? picBoxAnhNV.Width : 120;
            Bitmap bmp = new Bitmap(size, size);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Color bgColor = Color.FromArgb(27, 94, 32);
                using (SolidBrush bgBrush = new SolidBrush(bgColor))
                {
                    g.FillEllipse(bgBrush, 0, 0, size, size);
                }

                string initials = GetInitials(fullName);
                using (Font font = new Font("Segoe UI", size * 0.35f, FontStyle.Bold))
                using (SolidBrush textBrush = new SolidBrush(Color.White))
                {
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    g.DrawString(initials, font, textBrush, new RectangleF(0, 0, size, size), sf);
                }
            }
            if (picBoxAnhNV.Image != null) picBoxAnhNV.Image.Dispose();
            picBoxAnhNV.Image = bmp;
        }

        private void CapNhatAvatarPreview()
        {
            string url = guna2TextBox2.Text.Trim();
            string name = tbTenNV.Text.Trim();

            if (!string.IsNullOrEmpty(url) && (url.StartsWith("http://") || url.StartsWith("https://")))
            {
                try { picBoxAnhNV.LoadAsync(url); }
                catch { DrawAvatarChữ(name); }
            }
            else { DrawAvatarChữ(name); }
        }

        // ================================================================
        // 4. XỬ LÝ KHI BẤM NÚT LƯU CẬP NHẬT
        // ================================================================
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            ResetErrors();
            bool isValid = true;

            // --- 1. Kiểm tra ComboBox ---
            if (cbPhongBan.SelectedIndex <= 0)
            {
                cbPhongBan.BorderColor = errorBorderColor;
                isValid = false;
            }
            if (cbVaiTro.SelectedIndex <= 0)
            {
                cbVaiTro.BorderColor = errorBorderColor;
                isValid = false;
            }

            // --- 2. Kiểm tra Địa chỉ (BẮT BUỘC) ---
            if (string.IsNullOrWhiteSpace(tbDiaChi.Text))
            {
                BaoLoiTextBox(tbDiaChi, "⚠ Vui lòng nhập địa chỉ nơi ở");
                isValid = false;
            }

            // --- 3. Kiểm tra SĐT (BẮT BUỘC & ĐÚNG ĐỊNH DẠNG) ---
            if (string.IsNullOrWhiteSpace(tbSDT.Text))
            {
                BaoLoiTextBox(tbSDT, "⚠ Vui lòng nhập số điện thoại");
                isValid = false;
            }
            else
            {
                string sdtSach = tbSDT.Text.Replace(" ", "").Replace(".", "").Trim();
                string sdtPattern = @"^(0[3|5|7|8|9])+([0-9]{8})$";
                if (!Regex.IsMatch(sdtSach, sdtPattern))
                {
                    tbSDT.Clear();
                    BaoLoiTextBox(tbSDT, "⚠ SĐT sai định dạng (vd: 0912345678)");
                    isValid = false;
                }
            }

            // --- 4. Kiểm tra Email (BẮT BUỘC & ĐÚNG ĐỊNH DẠNG) ---
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                BaoLoiTextBox(tbEmail, "⚠ Vui lòng nhập email nhân viên");
                isValid = false;
            }
            else
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(tbEmail.Text.Trim(), emailPattern))
                {
                    tbEmail.Clear();
                    BaoLoiTextBox(tbEmail, "⚠ Email sai định dạng (vd: a@b.com)");
                    isValid = false;
                }
            }

            // DỪNG LẠI NẾU CÓ LỖI
            if (!isValid) return;

            // ==========================================
            // NẾU HỢP LỆ -> TIẾN HÀNH LƯU CẬP NHẬT
            // ==========================================
            string maNV = tbMNV.Text.Trim().ToUpper();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn lưu cập nhật cho nhân viên {maNV} không?",
                "Xác nhận cập nhật",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("✅ Đã cập nhật thông tin nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}