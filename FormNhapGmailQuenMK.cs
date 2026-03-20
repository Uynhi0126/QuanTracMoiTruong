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
    public partial class FormNhapGmailQuenMK : Form
    {
        private Color defaultBorderColor = Color.FromArgb(213, 218, 223);
        private Color errorBorderColor = Color.Red;
        private Color defaultPlaceholderColor = Color.FromArgb(125, 137, 149);
        public FormNhapGmailQuenMK()
        {
            InitializeComponent();
        }

        private void FormNhapGmailQuenMK_Load(object sender, EventArgs e)
        {

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            // 1. Code kiểm tra email và gửi OTP của bạn ở đây...
            // string otp = TaoMaOTP();
            // GuiEmail(email, otp);

            // kiểm tra định dạng email 
            tbEmail.BorderColor = defaultBorderColor; 
            string email = tbEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(email))
            {
                tbEmail.BorderColor = errorBorderColor;
                MessageBox.Show("Vui lòng nhập email của bạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return;
            }
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                tbEmail.BorderColor = errorBorderColor;
                MessageBox.Show("Email sai định dạng (Ví dụ đúng: abc@gmail.com)", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
                return;
            }

            MessageBox.Show("Đã gửi OTP giả '123456' đến email của bạn!", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 2. Nếu gửi thành công, đánh dấu kết quả là OK và đóng form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
