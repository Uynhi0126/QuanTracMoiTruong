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
    public partial class FormDoiMK : Form
    {

        // Mật khẩu hiện tại giả lập (sau sẽ lấy từ data base) 
        private const string MOCK_CURRENT_PW = "KD@1234";

        public FormDoiMK()
        {
            InitializeComponent();
        }

        private void tbmkHienTai_IconRightClick(object sender, EventArgs e)
        {
            if (tbmkHienTai.UseSystemPasswordChar == true)
            {
                tbmkHienTai.UseSystemPasswordChar = false;
                tbmkHienTai.IconRight = Properties.Resources.matdong;
            }
            else
            {
                tbmkHienTai.UseSystemPasswordChar = true;
                tbmkHienTai.IconRight = Properties.Resources.matmo;
            }
        }

        private void tbmkMoi_IconRightClick(object sender, EventArgs e)
        {
            if (tbmkMoi.UseSystemPasswordChar == true)
            {
                tbmkMoi.UseSystemPasswordChar = false;
                tbmkMoi.IconRight = Properties.Resources.matdong;
            }
            else
            {
                tbmkMoi.UseSystemPasswordChar = true;
                tbmkMoi.IconRight = Properties.Resources.matmo;
            }
        }

        private void tbXacNhanMK_IconRightClick(object sender, EventArgs e)
        {
            if (tbXacNhanMK.UseSystemPasswordChar == true)
            {
                tbXacNhanMK.UseSystemPasswordChar = false;
                tbXacNhanMK.IconRight = Properties.Resources.matdong;
            }
            else
            {
                tbXacNhanMK.UseSystemPasswordChar = true;
                tbXacNhanMK.IconRight = Properties.Resources.matmo;
            }
        }

        private void btnXacNhanDoiMK_Click(object sender, EventArgs e)
        {
            string currentPass = tbmkHienTai.Text;
            string newPass = tbmkMoi.Text;
            string confirmPass = tbXacNhanMK.Text;

            // 1. Validate Mật khẩu hiện tại
            if (string.IsNullOrWhiteSpace(currentPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmkHienTai.Focus(); // Đưa con trỏ về lại ô này để user sửa
                return;
            }
            if (currentPass != MOCK_CURRENT_PW)
            {
                MessageBox.Show("Mật khẩu hiện tại không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbmkHienTai.Focus(); // Đưa con trỏ về lại ô này để user sửa
                return;
            }

            // 2. Validate Mật khẩu mới
            if (string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmkMoi.Focus(); // Đưa con trỏ về lại ô này để user sửa
                return;
            }

            if (newPass.Contains(" "))
            {
                MessageBox.Show("Mật khẩu không được chứa khoảng trắng (dấu cách)!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmkMoi.Focus(); // Đưa con trỏ về lại ô này để user sửa
                return;
            }

            // Giới hạn cơ bản: Mật khẩu mới phải từ 6 ký tự trở lên
            if (newPass.Length < 6)
            {
                MessageBox.Show("Mật khẩu mới phải có tối thiểu 6 ký tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbmkMoi.Focus();
                return;
            }

            if (confirmPass != newPass)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbXacNhanMK.Focus();
                return;
            }
            MessageBox.Show("✅ Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
