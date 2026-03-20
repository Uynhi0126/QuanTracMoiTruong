using FormLogin.Repositories;
using System;
using System.Windows.Forms;
using FormLogin.Models;

namespace FormLogin
{
    public partial class FormThemNV : Form
    {
        private readonly NhanVienRes _nvRepo = new NhanVienRes();
        private readonly string _maPBmacdinh;
        public FormThemNV(string maPBmacdinh = "")
        {
            InitializeComponent();
            _maPBmacdinh = maPBmacdinh;
            this.Load += FormThemNV_Load;
            btnTaoTK.Click += BtnTaoTK_Click;
            btnXoa.Click += BtnXoa_Click;
        }
        private void FormThemNV_Load(object sender, EventArgs e)
        {


        }
        private void BtnTaoTK_Click(object sender, EventArgs e)
        {
            //var nv = new NhanVien
            //{
            //    MaNhanVien = txtMaNV.Text.Trim(),
            //    HoTen = txtHoTen.Text.Trim(),
            //    MaPhongBan = _maPBmacdinh,
            //    MaChucVu = txtMaCV.Text.Trim(),
            //    SoDienThoai = txtSDT.Text.Trim(),
            //    Email = txtEmail.Text.Trim()
            //};
            //try
            //{
            //    _nvRepo.Insert(nv);
            //    MessageBox.Show("Thêm nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            //txtMaNV.Clear();
            //txtHoTen.Clear();
            //txtMaCV.Clear();
            //txtSDT.Clear();
            //txtEmail.Clear();
        }
    }
}
