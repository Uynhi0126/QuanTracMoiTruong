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

namespace FormLogin
{
    public partial class FormNhacKyLaiHopDong : Form
    {
        public FormNhacKyLaiHopDong()
        {
            InitializeComponent();
            this.Load += FormNhacKyLai_Load;
            btnDaHieu.Click += BtnDaHieu_Click;
        }

        private void BtnDaHieu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormNhacKyLai_Load(object sender, EventArgs e)
        {
            // Reset danh sách
            flpDanhSach.Controls.Clear();

            // GIẢ LẬP DỮ LIỆU: Tìm các hợp đồng Quý sắp hết hạn trong 30 ngày
            // Thực tế bạn sẽ dùng vòng lặp for hoặc câu lệnh SQL để lấy từ Database ra
            ThemDongNhacNho("HD-2025-041", "Nhà Máy Phú Lộc", "Đất | Quý (3 tháng/lần)", "05/04/2026", 18);
            ThemDongNhacNho("HD-2025-038", "KCN Hòa Khánh", "Không khí | Quý (3 tháng/lần)", "30/03/2026", 12);
            ThemDongNhacNho("HD-2025-058", "KCN Khánh Hòa", "Tổng hợp | Quý (3 tháng/lần)", "30/03/2026", 12);
            ThemDongNhacNho("HD-2025-058", "TDTU", "Tổng hợp | Quý (3 tháng/lần)", "30/03/2026", 12);
            ThemDongNhacNho("HD-2025-058", "HCM USSH", "Tổng hợp | Quý (3 tháng/lần)", "30/03/2026", 12);
        }

        private void ThemDongNhacNho(string maHD, string tenDN, string chiTiet, string ngayHetHan, int soNgayConLai)
        {
            // 1. Tạo một cái Panel chứa 1 dòng
            Panel pnlItem = new Panel();
            pnlItem.Width = flpDanhSach.Width - 25; // Trừ hao thanh cuộn
            pnlItem.Height = 70;
            pnlItem.BackColor = Color.FromArgb(255, 243, 224); // Màu cam nhạt (warn-pale)
            pnlItem.Margin = new Padding(0, 0, 0, 8); // Khoảng cách giữa các dòng

            // Vẽ cái viền cam bên trái giống CSS: border-left: 3px solid var(--warn)
            Panel pnlBorder = new Panel { Width = 3, Dock = DockStyle.Left, BackColor = Color.FromArgb(245, 124, 0) };
            pnlItem.Controls.Add(pnlBorder);

            // 2. Tạo Label chứa thông tin Hợp đồng
            Label lblInfo = new Label();
            lblInfo.Text = $"📄 {maHD} - {tenDN}\n{chiTiet} | Đến: {ngayHetHan} (Còn {soNgayConLai} ngày)";
            lblInfo.Font = new Font("Roboto", 9);
            lblInfo.AutoSize = true;
            lblInfo.Size = new Size(pnlItem.Width - 130, pnlItem.Height - 20); // Dành chỗ cho nút ở bên phải
            lblInfo.Location = new Point(10, 10);
            pnlItem.Controls.Add(lblInfo);

            // 3. Tạo nút Gửi Email (Dùng Guna2Button cho đẹp)
            Guna2Button btnSend = new Guna2Button();
            btnSend.Text = "Gửi Email Nhắc";
            btnSend.Size = new Size(100, 50);
            btnSend.BorderRadius = 6;
            btnSend.FillColor = Color.FromArgb(27, 94, 32); // Màu xanh primary
            btnSend.Font = new Font("Roboto", 8, FontStyle.Bold);
            btnSend.TextAlign = HorizontalAlignment.Center; // Căn giữa theo chiều ngang
            btnSend.Padding = new Padding(0);               // Xóa bỏ khoảng đệm thừa
            btnSend.TextOffset = new Point(-1, 2);           // MẸO: Đẩy toàn bộ chữ dịch xuống dưới 1 pixel để bù trừ cho cái icon ✉

            // Canh nút sang góc phải của Panel
            btnSend.Location = new Point(pnlItem.Width - btnSend.Width - 10, 10);
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;

            // Xử lý sự kiện khi bấm nút (Có hiệu ứng Delay giống HTML)
            btnSend.Click += async (s, e) =>
            {
                btnSend.Text = "Đang gửi";
                btnSend.FillColor = Color.Gray;
                btnSend.Enabled = false;

                // Tạm dừng 0.9 giây để giả lập thời gian gửi email qua mạng
                await Task.Delay(900);

                btnSend.Text = "Đã gửi";
                btnSend.FillColor = Color.FromArgb(158, 158, 158); // Chuyển màu xám hoàn tất

                // Bạn có thể chèn MessageBox báo thành công hoặc gọi hàm ShowToast ở đây
            };

            pnlItem.Controls.Add(btnSend);

            // Đưa dòng vừa tạo vào FlowLayoutPanel
            flpDanhSach.Controls.Add(pnlItem);
        }
    }
}
