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

        private void tbMatKhau_IconRightClick(object sender, EventArgs e)
        {
            if (tbMatKhau.UseSystemPasswordChar == true)
            {
                tbMatKhau.UseSystemPasswordChar = false;
                tbMatKhau.IconRight = Properties.Resources.matmo;
            }
            else
            {
                tbMatKhau.UseSystemPasswordChar = true;
                tbMatKhau.IconRight = Properties.Resources.matdong;
            }
        }

    }
}
