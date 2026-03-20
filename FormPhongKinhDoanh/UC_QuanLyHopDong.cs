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
    public partial class UC_QuanLyHopDong : UserControl
    {
        string maHopDong; 
        public UC_QuanLyHopDong()
        {
            InitializeComponent();

            // Đăng ký các sự kiện khi UserControl khởi tạo
            this.Load -= UC_QuanLyHopDong_Load;
            this.Load += UC_QuanLyHopDong_Load;

            inforHopDong.CellPainting -= inforHopDong_CellPainting;
            inforHopDong.CellPainting += inforHopDong_CellPainting;

            inforHopDong.CellMouseClick -= inforHopDong_CellMouseClick;
            inforHopDong.CellMouseClick += inforHopDong_CellMouseClick;

            inforHopDong.SelectionChanged -= inforHopDong_SelectionChanged;
            inforHopDong.SelectionChanged += inforHopDong_SelectionChanged;
        }

        // BƯỚC 1: LOAD DỮ LIỆU TEST LÊN BẢNG
        private void UC_QuanLyHopDong_Load(object sender, EventArgs e)
        {
            // Thiết lập chiều cao dòng cho rộng rãi (giống web)
            inforHopDong.RowTemplate.Height = 45;

            // Xóa dữ liệu cũ nếu có
            inforHopDong.Rows.Clear();

            // Thêm các dòng dữ liệu mẫu y như bản thiết kế HTML
            // Chú ý: 2 cột cuối cùng là "" (rỗng) dành cho nút Sửa và Xem
            inforHopDong.Rows.Add("HD-2026-001", "Công Ty ABC", "Không khí", "Quý (3 tháng/lần)", "01/02/2026", "20/02/2026", "Quá hạn", "", "");
            inforHopDong.Rows.Add("HD-2026-002", "Công Ty XYZ", "Nước thải", "6 tháng/lần", "15/01/2026", "05/02/2026", "Quá hạn", "", "");
            inforHopDong.Rows.Add("HD-2026-003", "Nhà Máy 123", "Tổng hợp", "Năm (1 lần)", "05/02/2026", "25/02/2026", "Chờ duyệt", "", "");
            inforHopDong.Rows.Add("HD-2025-040", "Công Ty TNHH Green", "Nước mặt", "Quý (3 tháng/lần)", "15/12/2025", "15/03/2026", "Đang thực hiện", "", "");
            inforHopDong.Rows.Add("HD-2025-041", "Nhà Máy Phú Lộc", "Đất", "Quý (3 tháng/lần)", "28/12/2025", "28/03/2026", "Đang thực hiện", "", "");
        }

        // BƯỚC 2: VẼ NÚT SỬA, XEM VÀ HUY HIỆU TRẠNG THÁI BO TRÒN
        private void inforHopDong_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = inforHopDong.Columns[e.ColumnIndex].Name;

            // Nếu là cột Sửa, Xem hoặc Trạng thái thì tiến hành vẽ
            if (colName == "colSua" || colName == "colXem" || colName == "colTrangThai")
            {
                // Vẽ nền mặc định của ô trước, bỏ qua phần vẽ Text (mình sẽ tự vẽ Text)
                e.Paint(e.CellBounds, DataGridViewPaintParts.All & ~DataGridViewPaintParts.ContentForeground);

                Color bgColor = Color.White;
                Color textColor = Color.Black;
                string text = "";

                // Thiết lập màu sắc và chữ tùy theo cột
                if (colName == "colSua")
                {
                    bgColor = Color.FromArgb(227, 242, 253);     // Xanh dương nhạt
                    textColor = Color.FromArgb(21, 101, 192);    // Xanh dương đậm
                    text = "Sửa";
                }
                else if (colName == "colXem")
                {
                    bgColor = Color.FromArgb(232, 245, 233);     // Xanh lá nhạt
                    textColor = Color.FromArgb(46, 125, 50);     // Xanh lá đậm
                    text = "Xem";
                }
                else if (colName == "colTrangThai" && e.Value != null)
                {
                    text = e.Value.ToString();
                    if (text == "Quá hạn")
                    {
                        bgColor = Color.FromArgb(255, 235, 238); // Đỏ nhạt
                        textColor = Color.FromArgb(229, 57, 53); // Đỏ đậm
                    }
                    else if (text == "Chờ duyệt")
                    {
                        bgColor = Color.FromArgb(255, 243, 224); // Cam nhạt
                        textColor = Color.FromArgb(230, 81, 0);  // Cam đậm
                    }
                    else if (text == "Đang thực hiện")
                    {
                        bgColor = Color.FromArgb(232, 245, 233); // Xanh lá nhạt
                        textColor = Color.FromArgb(46, 125, 50); // Xanh lá đậm
                    }
                }

                // Tính toán kích thước nút bo tròn (Thêm padding cho nút gọn lại)
                int paddingX = 12;
                int paddingY = 8;
                Rectangle btnRect = new Rectangle(
                    e.CellBounds.X + paddingX,
                    e.CellBounds.Y + paddingY,
                    e.CellBounds.Width - (paddingX * 2),
                    e.CellBounds.Height - (paddingY * 2)
                );

                // Làm mịn nét vẽ
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                // Tiến hành vẽ khối bo tròn và chữ bên trong
                using (System.Drawing.Drawing2D.GraphicsPath path = GetRoundedPath(btnRect, 10))
                using (SolidBrush bgBrush = new SolidBrush(bgColor))
                using (SolidBrush textBrush = new SolidBrush(textColor))
                {
                    // Tô màu nền
                    e.Graphics.FillPath(bgBrush, path);

                    // Căn giữa chữ
                    StringFormat sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                    using (Font font = new Font("Segoe UI", 9, FontStyle.Bold))
                    {
                        // Viết chữ lên nút
                        e.Graphics.DrawString(text, font, textBrush, btnRect, sf);
                    }
                }

                // Đánh dấu là đã tự vẽ xong, hệ thống không cần vẽ thêm gì nữa
                e.Handled = true;
            }
        }

        // HÀM TẠO NỀN ĐEN MỜ CHO USER CONTROL
        private void ShowModalWithOverlay(Form modalForm)
        {
            // Phải lấy Form gốc (FormPhongKinhDoanh) để nền đen che kín toàn màn hình
            Form formCha = this.ParentForm;
            if (formCha == null) return;

            using (Form overlay = new Form())
            {
                overlay.StartPosition = FormStartPosition.Manual;
                overlay.FormBorderStyle = FormBorderStyle.None;
                overlay.Opacity = 0.5; // Độ mờ 50%
                overlay.BackColor = Color.Black;

                // Lấy kích thước và vị trí của Form cha áp vào nền đen
                overlay.Size = formCha.Size;
                overlay.Location = formCha.Location;
                overlay.ShowInTaskbar = false;

                overlay.Show(formCha); // Hiện nền đen lên trước

                // Hiện hộp thoại Xem Chi Tiết lên trên cái nền đen
                modalForm.ShowDialog(overlay);

                // Đóng hộp thoại thì ẩn nền đen đi
                overlay.Hide();
            }
            formCha.Activate();
        }

        // BƯỚC 3: BẮT SỰ KIỆN KHI CLICK VÀO NÚT SỬA HOẶC XEM
        private void inforHopDong_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            string colName = inforHopDong.Columns[e.ColumnIndex].Name;

            // Chỉ xử lý click cho cột Sửa và Xem (Cột Trạng thái không bấm được)
            if (colName == "colSua" || colName == "colXem")
            {
                // Tính toán lại vùng chữ nhật của nút để kiểm tra chuột có nằm trong đó không
                int paddingX = 12;
                int paddingY = 8;
                Rectangle cellRect = inforHopDong.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Rectangle btnRect = new Rectangle(paddingX, paddingY, cellRect.Width - (paddingX * 2), cellRect.Height - (paddingY * 2));

                int mouseX = e.X;
                int mouseY = e.Y;

                // Nếu click trúng vào vùng có màu của nút
                if (btnRect.Contains(mouseX, mouseY))
                {
                    // Lấy đúng mã hợp đồng ở dòng vừa bấm
                    string maHD = inforHopDong.Rows[e.RowIndex].Cells["colMaHD"].Value?.ToString();

                    if (colName == "colSua")
                    {
                        Panel pnlContainer = (Panel)this.Parent;
                        if (pnlContainer != null)
                        {
                            pnlContainer.Controls.Clear();

                            // ĐÃ SỬA LỖI: Truyền đúng biến maHD vào đây
                            UCSuaHopDong ucSua = new UCSuaHopDong(maHD);
                            ucSua.Dock = DockStyle.Fill;

                            pnlContainer.Controls.Add(ucSua);
                            ucSua.BringToFront();
                        }
                    }
                    else if (colName == "colXem")
                    {
                        FormXemHopDongChiTiet frmView = new FormXemHopDongChiTiet();

                        // 1. "Ép kiểu" ParentForm thành FormPhongKinhDoanh để thấy được hàm public
                        FormPhongKinhDoanh formCha = (FormPhongKinhDoanh)this.ParentForm;

                        if (formCha != null)
                        {
                            // 2. Nhờ Form cha mở hộp thoại và lấy kết quả trả về
                            DialogResult ketQua = formCha.ShowModalWithOverlay(frmView);

                            // 3. Nếu khách hàng bấm "Chỉnh Sửa" bên trong form Xem
                            if (ketQua == DialogResult.Yes)
                            {
                                Panel pnlContainer = (Panel)this.Parent;
                                if (pnlContainer != null)
                                {
                                    pnlContainer.Controls.Clear();
                                    UCSuaHopDong ucSua = new UCSuaHopDong(maHD);
                                    ucSua.Dock = DockStyle.Fill;
                                    pnlContainer.Controls.Add(ucSua);
                                    ucSua.BringToFront();
                                }
                            }
                        }
                    }
                }
            }
        }

        // Bỏ bôi đen màu xanh dương mặc định khi chọn dòng
        private void inforHopDong_SelectionChanged(object sender, EventArgs e)
        {
            inforHopDong.ClearSelection();
        }

        // Hàm hỗ trợ vẽ bo góc (Bạn dùng lại hàm từ Admin)
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

        // Bạn có thể xóa hàm rỗng này đi cho gọn code nếu không dùng
        private void inforHopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}