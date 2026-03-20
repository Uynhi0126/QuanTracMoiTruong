using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;
using FormLogin.Repositories;
namespace FormLogin
{
    public partial class FormAdmin : Form
    {
        private readonly NhanVienRes _nvRepo = new NhanVienRes();
        private System.Windows.Forms.Timer menuTimer = new System.Windows.Forms.Timer { Interval = 150 };
        private Color normalColor = Color.FromArgb(27, 94, 32);
        private Color hoverColor = Color.FromArgb(46, 125, 50);
        public FormAdmin()
        {
            InitializeComponent();

            this.Load -= FormAdmin_Load;
            this.Load += FormAdmin_Load;

            inforNV.CellPainting -= inforNV_CellPainting;
            inforNV.CellPainting += inforNV_CellPainting;

            inforNV.CellMouseClick -= inforNV_CellMouseClick;
            inforNV.CellMouseClick += inforNV_CellMouseClick;

            btonThemNV.Click -= btonThemNV_Click;
            btonThemNV.Click += btonThemNV_Click;

            lblArrow.Parent = btnDropMenu;
            lblArrow.BackColor = Color.Transparent;
            lblArrow.Location = new Point(
                btnDropMenu.Width - lblArrow.Width - 10,
                (btnDropMenu.Height - lblArrow.Height) / 2);

            btnDropMenu.Text = "Tất cả nhân viên";
            lblArrow.Text = "▼";

            SetupDropdownMenuLogic();
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            if (!DatabaseHelper.KiemTraKetNoi()) return;
            LoadNhanVien();
        }
        private void LoadNhanVien(string maPhongBan = "")
        {
            try
            {
                var danhSach = string.IsNullOrEmpty(maPhongBan)
                    ? _nvRepo.GetAll()
                    : _nvRepo.GetByPhongBan(maPhongBan);

                inforNV.Rows.Clear();
                if (maPhongBan == "AD") return;
                foreach (var nv in danhSach)
                {
                    if(nv.MaChucVu == "01") continue; 
                    inforNV.Rows.Add(
                        nv.HoTen,
                        nv.MaNhanVien,
                        nv.TenPhongBanHienThi,   
                        nv.TenChucVuHienThi,     
                        nv.SoDienThoai,
                        nv.Email,
                        "",  
                        ""   
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Lỗi tải danh sách nhân viên:\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BoxTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = BoxTimKiem.Text.Trim();
            string maPhongBan = LayMaPhongBanHienTai();

            try
            {
                var ketQua = string.IsNullOrEmpty(keyword)
                    ? (string.IsNullOrEmpty(maPhongBan)
                        ? _nvRepo.GetAll()
                        : _nvRepo.GetByPhongBan(maPhongBan))
                    : _nvRepo.Search(keyword);

                inforNV.Rows.Clear();
                foreach (var nv in ketQua)
                {
                    if(nv.MaChucVu == "01") continue;
                    inforNV.Rows.Add(
                        nv.HoTen, nv.MaNhanVien,
                        nv.TenPhongBanHienThi, nv.TenChucVuHienThi,
                        nv.SoDienThoai, nv.Email, "", "");
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Search error: {ex.Message}");
            }
        }

        
        private void btonThemNV_Click(object sender, EventArgs e)
        {
            var popUpThem = new FormThemNV();
            ShowModalWithOverlay(popUpThem);
            LoadNhanVien(LayMaPhongBanHienTai());
        }

       
        private void inforNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = inforNV.Columns[e.ColumnIndex].Name;
            if (colName != "colSua" && colName != "colKhoa") return;
            // Kiểm tra click có trúng vùng button không (giữ nguyên logic cũ)
            int paddingX = 12, paddingY = 10;
            Rectangle cellRect = inforNV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
            Rectangle btnRect = new Rectangle(
                paddingX, paddingY,
                cellRect.Width - paddingX * 2,
                cellRect.Height - paddingY * 2);

            if (!btnRect.Contains(e.X, e.Y)) return;

            // Lấy MaNhanVien từ cột colMaNV (cột ẩn hoặc cột hiển thị)
            string maNV = inforNV.Rows[e.RowIndex].Cells["colMaNV"].Value?.ToString();
            if (string.IsNullOrEmpty(maNV)) return;

            if (colName == "colSua")
            {
                //var popUpSua = new FormSuaNV (maNV);
                //ShowModalWithOverlay(popUpSua);
            }
            else // colKhoa
            {
                // Lấy trạng thái hiện tại để toggle
                var nv = _nvRepo.GetById(maNV);
                if (nv == null) return;

                string hanhDong = nv.TrangThai ? "khóa" : "mở";
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn {hanhDong} tài khoản của\n{nv.HoTen} ({maNV})?",
                    $"Xác nhận {hanhDong} tài khoản",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    bool ok = _nvRepo.SetTrangThai(maNV, !nv.TrangThai);
                    if (ok)
                        MessageBox.Show($"Đã {hanhDong} tài khoản {maNV} thành công.",
                            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show($"Không thể {hanhDong} tài khoản. Thử lại.",
                            "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Reload bảng sau thao tác
            LoadNhanVien(LayMaPhongBanHienTai());
        }

        // Ánh xạ tên hiển thị → mã phòng ban trong DB
        private string LayMaPhongBanHienTai() 
        {
            string ten = btnDropMenu.Text;
            if (ten == "Admin") return "ADMIN_FILTER";
            else if (ten == "Kinh doanh") return "PB01";
            else if (ten == "Kế hoạch") return "PB02";
            else if (ten == "Hiện trường") return "PB03";
            else if (ten == "Thí nghiệm") return "PB04";
            else if (ten == "Kết quả") return "PB05";
            else return  "";
            
        }

        private void ChonPhongBan(string tenPhongBan)
        {
            btnDropMenu.Text = tenPhongBan;
            lblArrow.Text = "▼";
            btnDropMenu.FillColor = normalColor;
            guna2Transition1.HideSync(pnlMenu);
            LoadNhanVien(LayMaPhongBanHienTai());
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

        private void SetupDropdownMenuLogic()
        {
            pnlMenu.Visible = false;

            btnAllNV.Click += (s, e) => ChonPhongBan("Tất cả nhân viên");
            btnKinhDoanh.Click += (s, e) => ChonPhongBan("Kinh doanh");
            btnKeHoach.Click += (s, e) => ChonPhongBan("Kế hoạch");
            btnHienTruong.Click += (s, e) => ChonPhongBan("Hiện trường");
            btnThiNghiem.Click += (s, e) => ChonPhongBan("Thí nghiệm");
            btnKetQua.Click += (s, e) => ChonPhongBan("Kết quả");
            btnAdmin.Click += (s, e) => ChonPhongBan("Admin");

            Action showMenu = () =>
            {
                menuTimer.Stop();
                btnDropMenu.FillColor = hoverColor;
                if (!pnlMenu.Visible)
                {
                    lblArrow.Text = "▲";
                    pnlMenu.BringToFront();
                    guna2Transition1.ShowSync(pnlMenu);
                }
            };

            btnDropMenu.MouseEnter += (s, e) => showMenu();
            lblArrow.MouseEnter += (s, e) => showMenu();
            btnDropMenu.MouseLeave += (s, e) => menuTimer.Start();
            lblArrow.MouseLeave += (s, e) => menuTimer.Start();
            pnlMenu.MouseEnter += (s, e) => menuTimer.Stop();
            pnlMenu.MouseLeave += (s, e) => menuTimer.Start();

            menuTimer.Tick += (s, e) =>
            {
                Point mousePos = Cursor.Position;
                Rectangle btn = btnDropMenu.RectangleToScreen(btnDropMenu.ClientRectangle);
                Rectangle menu = pnlMenu.RectangleToScreen(pnlMenu.ClientRectangle);
                menu.Y -= 5;
                menu.Height += 5;

                if (!btn.Contains(mousePos) && !menu.Contains(mousePos))
                {
                    menuTimer.Stop();
                    btnDropMenu.FillColor = normalColor;
                    if (pnlMenu.Visible)
                    {
                        lblArrow.Text = "▼";
                        guna2Transition1.HideSync(pnlMenu);
                    }
                }
            };
        }

        private void inforNV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            string colName = inforNV.Columns[e.ColumnIndex].Name;
            if (colName != "colSua" && colName != "colKhoa") return;

            e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

            Color bgColor, textColor;
            string text;

            if (colName == "colSua")
            {
                bgColor = Color.FromArgb(227, 242, 253);
                textColor = Color.FromArgb(21, 101, 192);
                text = "✏ Sửa";
            }
            else
            {
                bgColor = Color.FromArgb(255, 235, 238);
                textColor = Color.FromArgb(229, 57, 53);
                text = "🔒 Khóa";
            }

            int paddingX = 12, paddingY = 10;
            Rectangle btnRect = new Rectangle(
                e.CellBounds.X + paddingX, e.CellBounds.Y + paddingY,
                e.CellBounds.Width - paddingX * 2,
                e.CellBounds.Height - paddingY * 2);

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var path = GetRoundedPath(btnRect, 10))
            using (var bgBrush = new SolidBrush(bgColor))
            using (var txtBrush = new SolidBrush(textColor))
            {
                e.Graphics.FillPath(bgBrush, path);
                var sf = new StringFormat
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center
                };
                using (var font = new Font("Segoe UI", 8, FontStyle.Bold))
                    e.Graphics.DrawString(text, font, txtBrush, btnRect, sf);
            }
            e.Handled = true;
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            var path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}