using Guna.UI2.WinForms;
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

namespace FormLogin
{
    public partial class FormThemNV : Form
    {
        private Color defaultBorderColor = Color.FromArgb(213, 218, 223);
        private Color errorBorderColor = Color.Red;
        private Color defaultPlaceholderColor = Color.FromArgb(125, 137, 149);

        public FormThemNV()
        {
            InitializeComponent();
            LoadComboBoxData();

            tbTenNV.TextChanged += (s, e) => CapNhatAvatarPreview();
            tbURLanh.TextChanged += (s, e) => CapNhatAvatarPreview(); // guna2TextBox2 là ô URL ảnh

            picBoxAnhNV.LoadCompleted += (s, e) =>
            {
                if (e.Error != null) // Nếu ảnh tải về bị lỗi (Link die)
                {
                    DrawAvatarChu(tbTenNV.Text.Trim());
                }
            };

            // Bắt sự kiện nút Tạo Tài Khoản và Nút Xóa
            btnTaoTK.Click += BtnTaoTK_Click;
            btnXoa.Click += btnXoa_Click;

        }

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
            ResetTextBox(tbMNV, "VD: NV001");
            ResetTextBox(tbTenNV, "Nhập họ tên đầy đủ");
            ResetTextBox(tbSDT, "VD: 0901234567");
            ResetTextBox(tbEmail, "VD: nv@mtrxanh.vn");
            ResetTextBox(tbDiaChi, "VD: 123 Lê Lợi...");
            ResetTextBox(tbURLanh, "Dán link ảnh...");

            cbPhongBan.BorderColor = defaultBorderColor;
            cbVaiTro.BorderColor = defaultBorderColor;
        }

        private void FormThemNV_Load(object sender, EventArgs e)
        {
            // Mở form lên thì vẽ ảnh chữ trống
            DrawAvatarChu("");
        }

        private void ThemSuaNV_Load(object sender, EventArgs e)
        {
            cbPhongBan.SelectedIndex = 0;
            cbVaiTro.SelectedIndex = 0;
        }
        private void LoadComboBoxData()
        {
            cbPhongBan.SelectedIndex = 0;
            cbVaiTro.SelectedIndex = 0; 
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            tbMNV.Clear();
            tbTenNV.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
            tbDiaChi.Clear();
            tbURLanh.Clear();
            cbPhongBan.SelectedIndex = 0;
            cbVaiTro.SelectedIndex = 0;

            DrawAvatarChu("");
        }

        private string GetInitials(string fullName)
        {
            if (string.IsNullOrWhiteSpace(fullName)) return "👤";
            string[] words = fullName.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length == 1) return words[0].Substring(0, 1).ToUpper();

            string first = words[words.Length - 2].Substring(0, 1).ToUpper();
            string second = words[words.Length - 1].Substring(0, 1).ToUpper();
            return first + second;
        }

        private void DrawAvatarChu(string fullName)
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
                using (Font font = new Font("Roboto", size * 0.35f, FontStyle.Bold))
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
            string url = tbURLanh.Text.Trim();
            string name = tbTenNV.Text.Trim();

            if (!string.IsNullOrEmpty(url) && (url.StartsWith("http://") || url.StartsWith("https://")))
            {
                try { picBoxAnhNV.LoadAsync(url); }
                catch { DrawAvatarChu(name); }
            }
            else { DrawAvatarChu(name); }
        }

        // XỬ LÝ KHI BẤM NÚT TẠO TÀI KHOẢN (Sinh Mật khẩu)
        // ================================================================
        private void BtnTaoTK_Click(object sender, EventArgs e)
        {
            ResetErrors();
            bool isValid = true;

            // --- 1. Kiểm tra Mã NV ---
            if (string.IsNullOrWhiteSpace(tbMNV.Text))
            {
                BaoLoiTextBox(tbMNV, "⚠ Vui lòng nhập mã nhân viên");
                isValid = false;
            }
            else
            {
                string maPattern = @"^[a-zA-Z0-9]+$"; // Chỉ cho phép chữ và số
                if (!Regex.IsMatch(tbMNV.Text.Trim(), maPattern))
                {
                    tbMNV.Clear();
                    BaoLoiTextBox(tbMNV, "⚠ Mã NV không chứa ký tự đặc biệt");
                    isValid = false;
                }
            }

            // --- 2. Kiểm tra Tên NV ---
            if (string.IsNullOrWhiteSpace(tbTenNV.Text))
            {
                BaoLoiTextBox(tbTenNV, "⚠ Vui lòng nhập tên nhân viên");
                isValid = false;
            }
            else
            {
                string namePattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s]+$";
                if (!Regex.IsMatch(tbTenNV.Text.Trim(), namePattern))
                {
                    tbTenNV.Clear();
                    BaoLoiTextBox(tbTenNV, "⚠ Tên không được chứa số hoặc ký tự đặc biệt");
                    isValid = false;
                }
            }

            // --- 3. Kiểm tra ComboBox ---
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

            // --- 4. Kiểm tra Địa chỉ (BẮT BUỘC) ---
            if (string.IsNullOrWhiteSpace(tbDiaChi.Text))
            {
                BaoLoiTextBox(tbDiaChi, "⚠ Vui lòng nhập địa chỉ nơi ở");
                isValid = false;
            }

            // --- 5. Kiểm tra SĐT (BẮT BUỘC & ĐÚNG ĐỊNH DẠNG) ---
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

            // --- 6. Kiểm tra Email (BẮT BUỘC & ĐÚNG ĐỊNH DẠNG) ---
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
            // NẾU HỢP LỆ -> TIẾN HÀNH TẠO TÀI KHOẢN
            // ==========================================
            string maNV = tbMNV.Text.Trim().ToUpper();
            string tenNV = tbTenNV.Text.Trim();
            string phongBan = cbPhongBan.SelectedItem.ToString();

            // Tự động sinh Mật khẩu = Mã phòng ban + 4 số cuối Mã NV
            string maPhongBan = "NV";
            if (phongBan == "Phòng Kinh Doanh") maPhongBan = "KD";
            else if (phongBan == "Phòng Kế Hoạch") maPhongBan = "KH";
            else if (phongBan == "Phòng Hiện Trường") maPhongBan = "HT";
            else if (phongBan == "Phòng Thí Nghiệm") maPhongBan = "PTN";
            else if (phongBan == "Phòng Kết Quả") maPhongBan = "KQ";
            else if (phongBan == "Quản Lý") maPhongBan = "QL";

            string soCuoi = new String(maNV.Where(Char.IsDigit).ToArray());
            if (soCuoi.Length > 4) soCuoi = soCuoi.Substring(soCuoi.Length - 4);
            else soCuoi = soCuoi.PadLeft(4, '0');

            string matKhauTuTao = maPhongBan + soCuoi;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn lưu và tạo tài khoản cho nhân viên này?",
                "Xác nhận tạo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string thongBao = $"✅ Đã thêm nhân viên thành công!\n\n" +
                                  $"🔑 THÔNG TIN ĐĂNG NHẬP:\n" +
                                  $"- Tài khoản: {maNV}\n" +
                                  $"- Mật khẩu: {matKhauTuTao}\n\n" +
                                  $"Vui lòng gửi thông tin này cho nhân viên {tenNV}.";

                MessageBox.Show(thongBao, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
