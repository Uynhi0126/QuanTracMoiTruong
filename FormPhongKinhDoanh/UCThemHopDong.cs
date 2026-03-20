using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FormLogin
{
    public partial class UC_ThemHopDong : UserControl
    {
        private Color defaultBorderColor = Color.FromArgb(213, 218, 223);
        private Color errorBorderColor = Color.Red;
        private Color defaultPlaceholderColor = Color.FromArgb(125, 137, 149);
        public UC_ThemHopDong()
        {
            InitializeComponent();
            LoadComboBoxData();
            this.Load += UC_ThemHopDong_Load;
        }

        private void LoadComboBoxData()
        {
            cbChuKyQuanTrac.SelectedIndex = 0;
            cbLoaiHinhQuanTrac.SelectedIndex = 0;
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

        public void UC_ThemHopDong_Load(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnLuuHopDong_Click(object sender, EventArgs e)
        {
            ResetErrors();
            bool isValid = true;

            // Kiểm tra các trường bắt buộc

            if (string.IsNullOrWhiteSpace(tbTenDoanhNghiep.Text))
            {
                BaoLoiTextBox(tbTenDoanhNghiep, "⚠ Vui lòng nhập tên doanh nghiệp");
                isValid = false;
            }
            else
            {
                string namePattern = @"^[a-zA-Z0-9ÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s\.\,\-\&]+$";

                if (!Regex.IsMatch(tbTenDoanhNghiep.Text.Trim(), namePattern))
                {
                    tbTenDoanhNghiep.Clear();
                    BaoLoiTextBox(tbTenDoanhNghiep, "⚠ Tên Doanh Nghiệp không hợp lệ");
                    isValid = false;
                }
            }

            if (string.IsNullOrWhiteSpace(tbMaDoanhNghiep.Text))
            {
                BaoLoiTextBox(tbMaDoanhNghiep, "⚠ Vui lòng nhập mã doanh nghiệp");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbDiaChi.Text))
            {
                BaoLoiTextBox(tbDiaChi, "⚠ Vui lòng nhập địa chỉ");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbSDT.Text))
            {
                BaoLoiTextBox(tbSDT, "⚠ Vui lòng nhập số điện thoại");
                isValid = false;
            }
            else
            {
                // Dọn dẹp khoảng trắng, dấu chấm, dấu gạch ngang nếu user lỡ nhập
                string sdtSach = tbSDT.Text.Replace(".", "").Replace(" ", "").Replace("-", "").Trim();
                string sdtPattern = @"^(0[35789])[0-9]{8}$";

                if (!Regex.IsMatch(sdtSach, sdtPattern))
                {
                    tbSDT.Clear();
                    BaoLoiTextBox(tbSDT, "⚠ SĐT không hợp lệ (10 số, đầu 03, 05, 07, 08, 09)");
                    tbSDT.Focus();
                    isValid = false;
                }
                else
                {
                    tbSDT.Text = sdtSach; // Chuẩn hóa số điện thoại
                }
            }

            if (string.IsNullOrWhiteSpace(tbNguoiDaiDien.Text))
            {
                BaoLoiTextBox(tbNguoiDaiDien, "⚠ Vui lòng nhập người đại diện");
                isValid = false;
            }
            else
            {
                string namePattern = @"^[a-zA-ZÀÁÂÃÈÉÊÌÍÒÓÔÕÙÚĂĐĨŨƠàáâãèéêìíòóôõùúăđĩũơƯĂẠẢẤẦẨẪẬẮẰẲẴẶẸẺẼỀỀỂưăạảấầẩẫậắằẳẵặẹẻẽềềểỄỆỈỊỌỎỐỒỔỖỘỚỜỞỠỢỤỦỨỪễệỉịọỏốồổỗộớờởỡợụủứừỬỮỰỲỴÝỶỸửữựỳỵỷỹ\s]+$";

                if (!Regex.IsMatch(tbNguoiDaiDien.Text.Trim(), namePattern))
                {
                    tbNguoiDaiDien.Clear();
                    BaoLoiTextBox(tbNguoiDaiDien, "⚠ Tên không được chứa số hoặc ký tự đặc biệt");
                    isValid = false;
                }
            }

            if (cbChuKyQuanTrac.SelectedIndex <= 0)
            {
                cbChuKyQuanTrac.BorderColor = errorBorderColor;
                isValid = false;
            }

            if (cbLoaiHinhQuanTrac.SelectedIndex <= 0)
            {
                cbLoaiHinhQuanTrac.BorderColor = errorBorderColor;
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(tbEmailKhachHang.Text))
            {
                BaoLoiTextBox(tbEmailKhachHang, "⚠ Vui lòng nhập email khách hàng");
                isValid = false;
            }
            else
            {
                string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
                if (!Regex.IsMatch(tbEmailKhachHang.Text.Trim(), emailPattern))
                {
                    tbEmailKhachHang.Clear();
                    BaoLoiTextBox(tbEmailKhachHang, "⚠ Email sai định dạng (vd:a@b.com)");
                    isValid = false;
                }
            }

            // Kiểm tra Logic ngày tháng (Ngày trả kết quả phải lớn hơn ngày ký)
            if (dtpNgayTraKQ.Value.Date < dtpNgayKy.Value.Date)
            {
                MessageBox.Show("Ngày trả kết quả không được nhỏ hơn ngày ký kết!", "Lỗi ngày tháng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                isValid = false;
            }

            // Nếu có lỗi thì dừng lại, không lưu
            if (!isValid) return;

            // Nếu tất cả hợp lệ, tiến hành lưu dữ liệu (ví dụ: gọi API hoặc lưu vào database)
            string maHD = tbMaHD.Text;
            string tenDN = tbTenDoanhNghiep.Text.Trim();

            MessageBox.Show($"✅ Đã lưu hợp đồng {maHD} cho {tenDN} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Lưu xong thì làm sạch form để sẵn sàng tạo cái mới
            ResetForm();
            
        }

        // SỰ KIỆN BẤM NÚT LÀM MỚI (HỦY)
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetErrors()
        {
            // Trả lại viền xám và chữ mờ mặc định cho TextBox
            ResetTextBox(tbTenDoanhNghiep, "Nhập vào tên doanh nghiệp");
            ResetTextBox(tbMaDoanhNghiep, "Nhập mã doanh nghiệp");
            ResetTextBox(tbDiaChi, "Nhập địa chỉ");
            ResetTextBox(tbSDT, "Số Điện Thoại người đại diện");
            ResetTextBox(tbNguoiDaiDien, "Họ tên người đại diện");
            ResetTextBox(tbEmailKhachHang, "Nhập email khách hàng");

            // Trả lại viền xám cho ComboBox
            cbChuKyQuanTrac.BorderColor = defaultBorderColor;
            cbLoaiHinhQuanTrac.BorderColor = defaultBorderColor;
        }

        private void ResetForm()
        {
            ResetErrors();

            tbTenDoanhNghiep.Clear();
            tbMaDoanhNghiep.Clear();
            tbNguoiDaiDien.Clear();
            tbSDT.Clear();
            tbDiaChi.Clear();
            tbEmailKhachHang.Clear();
            LoadComboBoxData();
            dtpNgayKy.Value = DateTime.Now;
            dtpNgayTraKQ.Value = DateTime.Now.AddDays(20);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy? Các thông tin đang nhập sẽ không được lưu.", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // 2. Tìm cái Panel đang chứa UC_ThemHopDong này (chính là pnlContainer bên FormPhongKinhDoanh)
                Panel pnlContainer = (Panel)this.Parent;
                Form formCha = this.ParentForm;

                if (pnlContainer != null)
                {
                    // 3. Xóa màn hình "Thêm Hợp Đồng" hiện tại đi
                    pnlContainer.Controls.Clear();

                    // 4. Khởi tạo và đưa màn hình "Quản Lý Hợp Đồng" (bảng danh sách) vào lại
                    UC_QuanLyHopDong ucQuanLy = new UC_QuanLyHopDong();
                    ucQuanLy.Dock = DockStyle.Fill;
                    pnlContainer.Controls.Add(ucQuanLy);
                    ucQuanLy.BringToFront();
                    
                    if (formCha != null)
                    {
                        Control[] foundButtons = formCha.Controls.Find("btnQuanLyHopDong", true);
                        if (foundButtons.Length > 0 && foundButtons[0] is Guna2Button)
                        {
                            ((Guna2Button)foundButtons[0]).Checked = true;
                        }
                    }
                }
            }
        }
    }
}
