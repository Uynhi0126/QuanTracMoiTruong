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
    public partial class FormNhapOTP : Form
    {
        private Color defaultBorderColor = Color.FromArgb(213, 218, 223);
        private Color errorBorderColor = Color.Red;
        private Color defaultPlaceholderColor = Color.FromArgb(125, 137, 149);



        public FormNhapOTP()
        {
            InitializeComponent();
        }

        private void btnXacNhanOTP_Click(object sender, EventArgs e)
        {


            if (txtBoxNhapOTP.Text == "123456")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Sai mã OTP rồi, nhập 123456 đi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
