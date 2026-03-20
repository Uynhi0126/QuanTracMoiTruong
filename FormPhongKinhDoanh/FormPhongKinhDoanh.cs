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
    public partial class FormPhongKinhDoanh : Form
    {
        public FormPhongKinhDoanh()
        {
            InitializeComponent();
            this.Load += FormPhongKinhDoanh_Load;
        }

        private void addUserControl(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void FormPhongKinhDoanh_Load(object sender, EventArgs e)
        {
            // Tự động bật sáng nút Quản lý hợp đồng
            btnQuanLyHopDong.Checked = true;

            // Tự động gọi màn hình Quản lý hợp đồng ra
            btnQuanLyHopDong_Click(sender, e);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            if (pnlMenuCaiDat.Visible == true)
            {
                hieuUngXuatHien.HideSync(pnlMenuCaiDat);
            }
            // Nếu Menu đang ẩn -> Hiện nó lên
            else
            {
                pnlMenuCaiDat.BringToFront(); 
                hieuUngXuatHien.ShowSync(pnlMenuCaiDat);
            }
        }

        private void btnQuanLyHopDong_Click(object sender, EventArgs e)
        {
            UC_QuanLyHopDong ucQuanLy = new UC_QuanLyHopDong();
            addUserControl(ucQuanLy);
        }

        private void btnThemHopDong_Click(object sender, EventArgs e)
        {
            UC_ThemHopDong ucThemHD = new UC_ThemHopDong();
            addUserControl(ucThemHD);
        }

        // Đặt ở public để các UserControl con có thể gọi được
        public DialogResult ShowModalWithOverlay(Form modalForm)
        {
            DialogResult result; // Biến lưu kết quả trả về từ hộp thoại

            using (Form overlay = new Form())
            {
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.Opacity = 0.5; // Độ mờ 50%
                overlay.BackColor = Color.Black;

                // Bao phủ toàn bộ Form Phòng Kinh Doanh
                overlay.Size = this.Size;
                overlay.Location = this.Location;
                overlay.ShowInTaskbar = false;

                overlay.Show(this);

                // Mở hộp thoại và bắt lại kết quả người dùng bấm (Yes/No/Cancel)
                result = modalForm.ShowDialog(overlay);

                overlay.Hide();
            }
            this.Activate(); // Trả lại Focus cho form chính

            return result; // Gửi kết quả về cho UserControl
        }

        private void btnNhacKyLai_Click(object sender, EventArgs e)
        {
            FormNhacKyLaiHopDong frmNhac = new FormNhacKyLaiHopDong();
            this.ShowModalWithOverlay(frmNhac);
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            pnlMenuCaiDat.Visible = false;

            // Hiện popup Đổi Mật Khẩu với nền đen mờ bao phủ
            FormDoiMK frmDoiMK = new FormDoiMK();
            this.ShowModalWithOverlay(frmDoiMK);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            pnlMenuCaiDat.Visible = false;

            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất khỏi hệ thống?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // 2. Nếu người dùng bấm "Yes"
            if (result == DialogResult.Yes)
            {
                // Cách 1: Khởi động lại toàn bộ phần mềm (Cách SẠCH NHẤT, giải phóng toàn bộ bộ nhớ và quay về màn hình Login)
                Application.Restart();

                /* // Cách 2: (Nếu bạn không muốn dùng Application.Restart())
                // Ẩn form hiện tại đi
                this.Hide();
                
                // Mở lại form Login
                FormLogin frmLogin = new FormLogin();
                frmLogin.ShowDialog();
                
                // Tắt form này đi để phần mềm tắt hẳn
                this.Close(); 
                */
            }
        }
    }
}