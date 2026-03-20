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
    public partial class FormNhapMKMoi : Form
    {
        public FormNhapMKMoi()
        {
            InitializeComponent();
        }

        private void tbMatKhauMoi_IconRightClick(object sender, EventArgs e)
        {
            if (tbMatKhauMoi.UseSystemPasswordChar == true)
            {
                tbMatKhauMoi.UseSystemPasswordChar = false;
                tbMatKhauMoi.IconRight = Properties.Resources.matdong;
            }
            else
            {
                tbMatKhauMoi.UseSystemPasswordChar = true;
                tbMatKhauMoi.IconRight = Properties.Resources.matmo;
            }
        }

        private void btnXacNhanDoiMK_Click(object sender, EventArgs e)
        {   

            string newPass = tbMatKhauMoi.Text;
            // Validate Mật khẩu mới
            if (string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMatKhauMoi.Focus(); // Đưa con trỏ về lại ô này để user sửa
                return;
            }

            if (newPass.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng (dấu cách)!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMatKhauMoi.Focus(); // Đưa con trỏ về lại ô này để user sửa
                return;
            }

            if (newPass.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có tối thiểu 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbMatKhauMoi.Focus();
                return;
            }

            MessageBox.Show("Đổi mật khẩu thành công! Quay lại đăng nhập nhé.", "Test", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
