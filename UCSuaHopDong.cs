using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class UCSuaHopDong : UserControl
    {
        private string maHopDongCanSua;
        private Color defaultBorderColor = Color.FromArgb(213, 218, 223);
        private Color errorBorderColor = Color.Red;
        private Color defaultPlaceholderColor = Color.FromArgb(125, 137, 149);

        public UCSuaHopDong(String maHD)
        {
            InitializeComponent();
            LoadComboBoxData();
            this.maHopDongCanSua = maHD; 
            this.Load += UCSuaHopDong_Load; 
        }

        private void LoadComboBoxData()
        {
            cbChuKyQuanTrac.SelectedIndex = 0;
            cbLoaiHinhQuanTrac.SelectedIndex = 0;
        }

        private void UCSuaHopDong_Load(object sender, EventArgs e)
        {
            if(tbMaHD != null)
            {
                tbMaHD.Text = maHopDongCanSua;
                tbMaHD.ReadOnly = true;
            }
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


        private void BaoLoiTextBox(Guna2TextBox tb, string cauThongBao)
        {
            tb.BorderColor = errorBorderColor;
            tb.PlaceholderForeColor = errorBorderColor;
            tb.PlaceholderText = cauThongBao;
        }

        private void ResetTextBox(Guna2TextBox tb, string duLieuBanDau)
        {
            tb.BorderColor = defaultBorderColor;
            tb.PlaceholderForeColor = defaultPlaceholderColor;
            tb.PlaceholderText = duLieuBanDau;
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
                    BaoLoiTextBox(tbTenDoanhNghiep, "⚠ Tên Doanh Nghiệp không được chứa số hoặc ký tự đặc biệt");
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
                BaoLoiTextBox(tbSDT, "⚠ Vui lòng nhập số ĐT");
                isValid = false;
            }
            else
            {
                string sdtPattern = @"^(0[3|5|7|8|9])+([0-9]{8})$";
                if (!Regex.IsMatch(tbSDT.Text.Trim(), sdtPattern))
                {
                    tbSDT.Clear();
                    BaoLoiTextBox(tbSDT, "⚠ SĐT sai định dạng (vd: 0912345678)");
                    isValid = false;
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
                    BaoLoiTextBox(tbEmailKhachHang, "⚠ Email sai định dạng (vd: a@b.com)");
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

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu cập nhật hợp đồng? Các thông tin đã sữa sẽ được lưu lại.", "Xác nhận lưu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Đã cập nhật hợp đồng {maHD} cho {tenDN} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                QuayVeDanhSach();
            }
            
        }



        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy? Các thông tin đang sữa sẽ không được lưu.", "Xác nhận hủy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                QuayVeDanhSach();
            }
        }

        private void QuayVeDanhSach()
        {
            Panel pnlContainer = (Panel)this.Parent;
            Form formCha = this.ParentForm; // ← Lấy tham chiếu TRƯỚC

            if (pnlContainer != null)
            {
                pnlContainer.Controls.Clear();
                UC_QuanLyHopDong ucQuanLy = new UC_QuanLyHopDong();
                ucQuanLy.Dock = DockStyle.Fill;
                pnlContainer.Controls.Add(ucQuanLy);
                ucQuanLy.BringToFront();

                if (formCha != null) { /* ... */ }
            }
        }


    }
}
