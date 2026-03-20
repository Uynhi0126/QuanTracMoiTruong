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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void ShowModalWithOverlay(Form modalForm)
        {
            using (Form overlay = new Form())
            {
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.Opacity = 0.5; 
                overlay.BackColor = Color.Black;
                overlay.Size = this.Size;
                overlay.Location = this.Location;
                overlay.ShowInTaskbar = false;

                overlay.Show(this); 

                modalForm.ShowDialog(overlay);

                overlay.Hide();
            }
            this.Activate();
        }



        private void tbMatKhau_IconRightClick(object sender, EventArgs e)
        {
            if (tbMatKhau.UseSystemPasswordChar == true)
            {
                tbMatKhau.UseSystemPasswordChar = false;
                tbMatKhau.IconRight = Properties.Resources.matdong;
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
                tbMatKhau.IconRight = Properties.Resources.matmo;
            }
        }

        private void linkLBQuenMK_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNhapGmailQuenMK frmGmail = new FormNhapGmailQuenMK();
            ShowModalWithOverlay(frmGmail);

            // Nếu bước 1 thành công (người dùng bấm Tiếp tục chứ không phải bấm dấu X tắt đi)
            if (frmGmail.DialogResult == DialogResult.OK)
            {
                // MỞ BƯỚC 2: Form nhập OTP
                // (Lưu ý: Bạn có thể cần truyền email hoặc mã OTP từ form 1 sang form 2 để so sánh)
                FormNhapOTP frmOTP = new FormNhapOTP();
                ShowModalWithOverlay(frmOTP);

                // Nếu bước 2 thành công (nhập đúng OTP)
                if (frmOTP.DialogResult == DialogResult.OK)
                {
                    // MỞ BƯỚC 3: Form đặt lại mật khẩu mới
                    FormNhapMKMoi frmDatLai = new FormNhapMKMoi();
                    ShowModalWithOverlay(frmDatLai);

                    // Nếu đổi mật khẩu thành công
                    if (frmDatLai.DialogResult == DialogResult.OK)
                    {
                        // Lúc này cả 3 form đã tắt, người dùng quay lại Form Login bình thường
                        // Có thể tự động điền sẵn tên đăng nhập cho họ nếu muốn
                    }
                }
            }
        }

    }
}
