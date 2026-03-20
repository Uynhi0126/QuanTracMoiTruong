using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormLogin
{
    public partial class FormAdmin : Form
    {
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
            // -----------------------------------

            lblArrow.Parent = btnDropMenu;
            lblArrow.BackColor = Color.Transparent;
            lblArrow.Location = new Point(btnDropMenu.Width - lblArrow.Width - 10, (btnDropMenu.Height - lblArrow.Height) / 2);

            btnDropMenu.Text = "Tất cả nhân viên";
            lblArrow.Text = "▼";

            SetupDropdownMenuLogic();
        }

        private void ShowModalWithOverlay(Form modalForm)
        {
            using (Form overlay = new Form())
            {
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.Opacity = 0.5; // Chỉnh độ mờ (0.5 là 50%)
                overlay.BackColor = Color.Black;
                overlay.Size = this.Size;
                overlay.Location = this.Location;
                overlay.ShowInTaskbar = false;

                overlay.Show(this); // Hiện nền đen mờ lên trước

                // Ép form pop-up dính vào cái nền đen
                modalForm.ShowDialog(overlay);

                // Ẩn nền đen trước khi dọn dẹp để tránh màn hình bị chớp
                overlay.Hide();
            }
            // Lấy lại sự tập trung (focus) cho Form Admin
            this.Activate();
        }

        // SỰ KIỆN BẤM NÚT THÊM NHÂN VIÊN
        private void btonThemNV_Click(object sender, EventArgs e)
        {
            FormThemNV popUpThem = new FormThemNV();
            ShowModalWithOverlay(popUpThem);
        }

        // SỰ KIỆN CLICK VÀO 3 NÚT TRONG BẢNG (SỬA & KHÓA & Đổi MK)
        private void inforNV_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = inforNV.Columns[e.ColumnIndex].Name;

            // THÊM colDoiMK VÀO ĐIỀU KIỆN
            if (colName == "colSua" || colName == "colKhoa" || colName == "colDoiMK")
            {
                // ... (Giữ nguyên phần tính toán vị trí btnRect)
                int paddingX = 12;
                int paddingY = 10;
                Rectangle cellRect = inforNV.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Rectangle btnRect = new Rectangle(paddingX, paddingY, cellRect.Width - (paddingX * 2), cellRect.Height - (paddingY * 2));

                int mouseX = e.X;
                int mouseY = e.Y;

                if (btnRect.Contains(mouseX, mouseY))
                {
                    string maNV = inforNV.Rows[e.RowIndex].Cells["colMaNV"].Value?.ToString();

                    if (colName == "colSua")
                    {
                        FormSuaNV popUpSua = new FormSuaNV();
                        ShowModalWithOverlay(popUpSua);
                    }
                    else if (colName == "colKhoa")
                    {
                        FormKhoaNV popUpKhoa = new FormKhoaNV();
                        ShowModalWithOverlay(popUpKhoa);
                    }
                    // THÊM ĐOẠN NÀY ĐỂ MỞ FORM ĐỔI MẬT KHẨU
                    else if (colName == "colDoiMK")
                    {
                        FormNhapMKMoi popUpDoiMK = new FormNhapMKMoi();

                        // Hiển thị form đè lên nền đen
                        ShowModalWithOverlay(popUpDoiMK);

                        // Nếu bạn muốn lấy thông báo thành công (tùy chọn)
                        // if (popUpDoiMK.DialogResult == DialogResult.OK) { ... }
                    }
                }
            }
        }

        // Test bảng dữ liệu 
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            inforNV.Rows.Add("Nguyễn Văn Admin", "NV001", "Quản Lý", "Admin", "0901 000 001", "nv001@mtrxanh.vn", "", "");
            inforNV.Rows.Add("Trần Kế Hoạch", "NV002", "Phòng Kế Hoạch", "Supervisor", "0901 000 002", "nv002@mtrxanh.vn", "", "");
            inforNV.Rows.Add("Phạm Thị D", "NV003", "Phòng Thí Nghiệm", "User", "0901 000 003", "nv003@mtrxanh.vn", "", "");
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

            btnDropMenu.MouseLeave += (s, e) => { menuTimer.Start(); };
            lblArrow.MouseLeave += (s, e) => { menuTimer.Start(); };

            pnlMenu.MouseEnter += (s, e) => { menuTimer.Stop(); };
            pnlMenu.MouseLeave += (s, e) => { menuTimer.Start(); };

            menuTimer.Tick += (s, e) =>
            {
                Point mousePos = Cursor.Position;
                Rectangle btnBounds = btnDropMenu.RectangleToScreen(btnDropMenu.ClientRectangle);
                Rectangle menuBounds = pnlMenu.RectangleToScreen(pnlMenu.ClientRectangle);

                menuBounds.Y -= 5;
                menuBounds.Height += 5;

                if (!btnBounds.Contains(mousePos) && !menuBounds.Contains(mousePos))
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

        private void ChonPhongBan(string tenPhongBan)
        {
            btnDropMenu.Text = tenPhongBan;
            lblArrow.Text = "▼";
            btnDropMenu.FillColor = normalColor;
            guna2Transition1.HideSync(pnlMenu);
        }

        private void PnlMenu_Paint(object sender, PaintEventArgs e) { }
        private void BoxTimKiem_TextChanged(object sender, EventArgs e) { }

        private void inforNV_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = inforNV.Columns[e.ColumnIndex].Name;

            if (colName == "colSua" || colName == "colKhoa" || colName == "colDoiMK")
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                Color bgColor, textColor;
                string text;

                if (colName == "colSua")
                {
                    bgColor = Color.FromArgb(227, 242, 253);
                    textColor = Color.FromArgb(21, 101, 192);
                    text = "Sửa";
                }
                else if (colName == "colKhoa")
                {
                    bgColor = Color.FromArgb(255, 235, 238);
                    textColor = Color.FromArgb(229, 57, 53);
                    text = "Khóa";
                }
                // THÊM ĐOẠN NÀY CHO NÚT ĐỔI MẬT KHẨU
                else
                {
                    bgColor = Color.FromArgb(255, 243, 224); // Nền màu cam nhạt
                    textColor = Color.FromArgb(230, 81, 0); // Chữ màu cam đậm
                    text = "Mật Khẩu";
                }

                int paddingX = 12;
                int paddingY = 10;
                Rectangle btnRect = new Rectangle(
                    e.CellBounds.X + paddingX,
                    e.CellBounds.Y + paddingY,
                    e.CellBounds.Width - (paddingX * 2),
                    e.CellBounds.Height - (paddingY * 2)
                );

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                using (System.Drawing.Drawing2D.GraphicsPath path = GetRoundedPath(btnRect, 10))
                using (SolidBrush bgBrush = new SolidBrush(bgColor))
                using (SolidBrush textBrush = new SolidBrush(textColor))
                {
                    e.Graphics.FillPath(bgBrush, path);

                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    using (Font font = new Font("Segoe UI", 8, FontStyle.Bold))
                    {
                        e.Graphics.DrawString(text, font, textBrush, btnRect, sf);
                    }
                }
                e.Handled = true;
            }
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedPath(Rectangle rect, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void inforNV_SelectionChanged(object sender, EventArgs e)
        {
            inforNV.ClearSelection();
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