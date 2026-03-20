namespace FormLogin
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.PnlTopBar = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCaiDat = new Guna.UI2.WinForms.Guna2Button();
            this.btonThemNV = new Guna.UI2.WinForms.Guna2Button();
            this.BoxTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.PicBoxLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbelName = new System.Windows.Forms.Label();
            this.pnlThongTinNV = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.pnlMenuCaiDat = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.btnDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.inforNV = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhongBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVaiTro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colKhoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDoiMK = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.btnKetQua = new Guna.UI2.WinForms.Guna2Button();
            this.btnThiNghiem = new Guna.UI2.WinForms.Guna2Button();
            this.btnHienTruong = new Guna.UI2.WinForms.Guna2Button();
            this.btnKeHoach = new Guna.UI2.WinForms.Guna2Button();
            this.btnKinhDoanh = new Guna.UI2.WinForms.Guna2Button();
            this.btnAllNV = new Guna.UI2.WinForms.Guna2Button();
            this.labelTenMenu = new System.Windows.Forms.Label();
            this.pnlThanhChucNag = new Guna.UI2.WinForms.Guna2Panel();
            this.btndsTatCa = new Guna.UI2.WinForms.Guna2Button();
            this.btnDSdakhoa = new Guna.UI2.WinForms.Guna2Button();
            this.lblArrow = new System.Windows.Forms.Label();
            this.btnDropMenu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
            this.hieuUngXuatHien = new Guna.UI2.WinForms.Guna2Transition();
            this.PnlTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).BeginInit();
            this.pnlThongTinNV.SuspendLayout();
            this.pnlMenuCaiDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inforNV)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.pnlThanhChucNag.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlTopBar
            // 
            this.PnlTopBar.BackColor = System.Drawing.Color.White;
            this.PnlTopBar.Controls.Add(this.btnCaiDat);
            this.PnlTopBar.Controls.Add(this.btonThemNV);
            this.PnlTopBar.Controls.Add(this.BoxTimKiem);
            this.PnlTopBar.Controls.Add(this.PicBoxLogo);
            this.PnlTopBar.Controls.Add(this.lbelName);
            this.hieuUngXuatHien.SetDecoration(this.PnlTopBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.PnlTopBar, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTopBar.Location = new System.Drawing.Point(0, 0);
            this.PnlTopBar.Name = "PnlTopBar";
            this.PnlTopBar.Padding = new System.Windows.Forms.Padding(20);
            this.PnlTopBar.ShadowDecoration.Color = System.Drawing.Color.LightGray;
            this.PnlTopBar.ShadowDecoration.Depth = 10;
            this.PnlTopBar.ShadowDecoration.Enabled = true;
            this.PnlTopBar.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.PnlTopBar.Size = new System.Drawing.Size(1338, 85);
            this.PnlTopBar.TabIndex = 0;
            this.PnlTopBar.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlMenu_Paint);
            // 
            // btnCaiDat
            // 
            this.btnCaiDat.BorderRadius = 10;
            this.hieuUngXuatHien.SetDecoration(this.btnCaiDat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnCaiDat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnCaiDat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCaiDat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCaiDat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCaiDat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCaiDat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnCaiDat.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaiDat.ForeColor = System.Drawing.Color.White;
            this.btnCaiDat.Image = global::FormLogin.Properties.Resources.BanhRang;
            this.btnCaiDat.ImageOffset = new System.Drawing.Point(1, 1);
            this.btnCaiDat.ImageSize = new System.Drawing.Size(25, 25);
            this.btnCaiDat.Location = new System.Drawing.Point(1282, 20);
            this.btnCaiDat.Name = "btnCaiDat";
            this.btnCaiDat.Size = new System.Drawing.Size(45, 45);
            this.btnCaiDat.TabIndex = 12;
            this.btnCaiDat.Click += new System.EventHandler(this.btnCaiDat_Click);
            // 
            // btonThemNV
            // 
            this.btonThemNV.BorderRadius = 13;
            this.hieuUngXuatHien.SetDecoration(this.btonThemNV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btonThemNV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btonThemNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btonThemNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btonThemNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btonThemNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btonThemNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(99)))), ((int)(((byte)(37)))));
            this.btonThemNV.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btonThemNV.ForeColor = System.Drawing.Color.White;
            this.btonThemNV.Location = new System.Drawing.Point(1102, 20);
            this.btonThemNV.Name = "btonThemNV";
            this.btonThemNV.Size = new System.Drawing.Size(174, 45);
            this.btonThemNV.TabIndex = 3;
            this.btonThemNV.Text = "Thêm nhân viên ";
            this.btonThemNV.TextOffset = new System.Drawing.Point(0, 1);
            this.btonThemNV.Click += new System.EventHandler(this.btonThemNV_Click);
            // 
            // BoxTimKiem
            // 
            this.BoxTimKiem.BackColor = System.Drawing.Color.Transparent;
            this.BoxTimKiem.BorderColor = System.Drawing.Color.DarkGray;
            this.BoxTimKiem.BorderRadius = 13;
            this.BoxTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.hieuUngXuatHien.SetDecoration(this.BoxTimKiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.BoxTimKiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.BoxTimKiem.DefaultText = "";
            this.BoxTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.BoxTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.BoxTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BoxTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.BoxTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(246)))));
            this.BoxTimKiem.FocusedState.BorderColor = System.Drawing.Color.Lime;
            this.BoxTimKiem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTimKiem.ForeColor = System.Drawing.Color.Gray;
            this.BoxTimKiem.HoverState.BorderColor = System.Drawing.Color.Lime;
            this.BoxTimKiem.IconLeft = global::FormLogin.Properties.Resources.kinhlup;
            this.BoxTimKiem.IconLeftOffset = new System.Drawing.Point(3, 1);
            this.BoxTimKiem.IconLeftSize = new System.Drawing.Size(25, 25);
            this.BoxTimKiem.IconRightSize = new System.Drawing.Size(25, 25);
            this.BoxTimKiem.Location = new System.Drawing.Point(812, 20);
            this.BoxTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BoxTimKiem.Name = "BoxTimKiem";
            this.BoxTimKiem.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.BoxTimKiem.PlaceholderText = "Tìm kiếm nhân viên ";
            this.BoxTimKiem.SelectedText = "";
            this.BoxTimKiem.Size = new System.Drawing.Size(283, 45);
            this.BoxTimKiem.TabIndex = 2;
            this.BoxTimKiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxTimKiem.TextOffset = new System.Drawing.Point(-3, 1);
            this.BoxTimKiem.TextChanged += new System.EventHandler(this.BoxTimKiem_TextChanged);
            // 
            // PicBoxLogo
            // 
            this.guna2Transition1.SetDecoration(this.PicBoxLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.hieuUngXuatHien.SetDecoration(this.PicBoxLogo, Guna.UI2.AnimatorNS.DecorationType.None);
            this.PicBoxLogo.FillColor = System.Drawing.Color.Transparent;
            this.PicBoxLogo.Image = global::FormLogin.Properties.Resources.logoapp;
            this.PicBoxLogo.ImageRotate = 0F;
            this.PicBoxLogo.Location = new System.Drawing.Point(23, 0);
            this.PicBoxLogo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.PicBoxLogo.Name = "PicBoxLogo";
            this.PicBoxLogo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.PicBoxLogo.Size = new System.Drawing.Size(85, 85);
            this.PicBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBoxLogo.TabIndex = 1;
            this.PicBoxLogo.TabStop = false;
            // 
            // lbelName
            // 
            this.guna2Transition1.SetDecoration(this.lbelName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.hieuUngXuatHien.SetDecoration(this.lbelName, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lbelName.Font = new System.Drawing.Font("Roboto", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(133)))), ((int)(((byte)(49)))));
            this.lbelName.Location = new System.Drawing.Point(114, 20);
            this.lbelName.Name = "lbelName";
            this.lbelName.Size = new System.Drawing.Size(292, 45);
            this.lbelName.TabIndex = 0;
            this.lbelName.Text = "Quản Lý Nhân Viên";
            this.lbelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlThongTinNV
            // 
            this.pnlThongTinNV.BackColor = System.Drawing.Color.Transparent;
            this.pnlThongTinNV.Controls.Add(this.pnlMenuCaiDat);
            this.pnlThongTinNV.Controls.Add(this.inforNV);
            this.pnlThongTinNV.Controls.Add(this.pnlMenu);
            this.pnlThongTinNV.Controls.Add(this.pnlThanhChucNag);
            this.hieuUngXuatHien.SetDecoration(this.pnlThongTinNV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.pnlThongTinNV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlThongTinNV.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlThongTinNV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlThongTinNV.Location = new System.Drawing.Point(0, 89);
            this.pnlThongTinNV.Name = "pnlThongTinNV";
            this.pnlThongTinNV.ShadowColor = System.Drawing.Color.Black;
            this.pnlThongTinNV.Size = new System.Drawing.Size(1338, 623);
            this.pnlThongTinNV.TabIndex = 1;
            // 
            // pnlMenuCaiDat
            // 
            this.pnlMenuCaiDat.BackColor = System.Drawing.Color.Transparent;
            this.pnlMenuCaiDat.BorderRadius = 15;
            this.pnlMenuCaiDat.Controls.Add(this.btnDangXuat);
            this.pnlMenuCaiDat.Controls.Add(this.btnDoiMK);
            this.hieuUngXuatHien.SetDecoration(this.pnlMenuCaiDat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.pnlMenuCaiDat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlMenuCaiDat.FillColor = System.Drawing.Color.LightGray;
            this.pnlMenuCaiDat.Location = new System.Drawing.Point(1134, 13);
            this.pnlMenuCaiDat.Name = "pnlMenuCaiDat";
            this.pnlMenuCaiDat.Size = new System.Drawing.Size(193, 107);
            this.pnlMenuCaiDat.TabIndex = 13;
            this.pnlMenuCaiDat.Visible = false;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BorderRadius = 10;
            this.btnDangXuat.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnDangXuat.CustomizableEdges.TopLeft = false;
            this.btnDangXuat.CustomizableEdges.TopRight = false;
            this.hieuUngXuatHien.SetDecoration(this.btnDangXuat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnDangXuat, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.Red;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDangXuat.FillColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.Red;
            this.btnDangXuat.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(232)))), ((int)(((byte)(237)))));
            this.btnDangXuat.Image = global::FormLogin.Properties.Resources.dangxuat;
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 54);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(193, 53);
            this.btnDangXuat.TabIndex = 1;
            this.btnDangXuat.Text = "Đăng xuất ";
            this.btnDangXuat.TextOffset = new System.Drawing.Point(10, 0);
            this.btnDangXuat.UseTransparentBackground = true;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // btnDoiMK
            // 
            this.btnDoiMK.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiMK.BorderRadius = 10;
            this.btnDoiMK.CustomizableEdges.BottomLeft = false;
            this.btnDoiMK.CustomizableEdges.BottomRight = false;
            this.hieuUngXuatHien.SetDecoration(this.btnDoiMK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnDoiMK, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDoiMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDoiMK.DisabledState.FillColor = System.Drawing.Color.Transparent;
            this.btnDoiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDoiMK.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiMK.FillColor = System.Drawing.Color.Transparent;
            this.btnDoiMK.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiMK.ForeColor = System.Drawing.Color.Black;
            this.btnDoiMK.Image = ((System.Drawing.Image)(resources.GetObject("btnDoiMK.Image")));
            this.btnDoiMK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDoiMK.Location = new System.Drawing.Point(0, 0);
            this.btnDoiMK.Name = "btnDoiMK";
            this.btnDoiMK.Size = new System.Drawing.Size(193, 53);
            this.btnDoiMK.TabIndex = 0;
            this.btnDoiMK.Text = " Đổi mật khẩu ";
            this.btnDoiMK.TextOffset = new System.Drawing.Point(10, 0);
            this.btnDoiMK.UseTransparentBackground = true;
            this.btnDoiMK.Click += new System.EventHandler(this.btnDoiMK_Click);
            // 
            // inforNV
            // 
            this.inforNV.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.inforNV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inforNV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.inforNV.ColumnHeadersHeight = 40;
            this.inforNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.inforNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNhanVien,
            this.colMaNV,
            this.colPhongBan,
            this.colVaiTro,
            this.colSDT,
            this.colGmail,
            this.colSua,
            this.colKhoa,
            this.colDoiMK});
            this.hieuUngXuatHien.SetDecoration(this.inforNV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.inforNV, Guna.UI2.AnimatorNS.DecorationType.None);
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.inforNV.DefaultCellStyle = dataGridViewCellStyle3;
            this.inforNV.GridColor = System.Drawing.Color.LightGray;
            this.inforNV.Location = new System.Drawing.Point(23, 92);
            this.inforNV.Name = "inforNV";
            this.inforNV.RowHeadersVisible = false;
            this.inforNV.RowHeadersWidth = 62;
            this.inforNV.RowTemplate.Height = 45;
            this.inforNV.Size = new System.Drawing.Size(1294, 514);
            this.inforNV.TabIndex = 1;
            this.inforNV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.inforNV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.inforNV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.inforNV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.inforNV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.inforNV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.inforNV.ThemeStyle.GridColor = System.Drawing.Color.LightGray;
            this.inforNV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(240)))));
            this.inforNV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.inforNV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inforNV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.DimGray;
            this.inforNV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.inforNV.ThemeStyle.HeaderStyle.Height = 40;
            this.inforNV.ThemeStyle.ReadOnly = false;
            this.inforNV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.inforNV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.inforNV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inforNV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.inforNV.ThemeStyle.RowsStyle.Height = 45;
            this.inforNV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.inforNV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.inforNV.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.inforNV_CellPainting);
            this.inforNV.SelectionChanged += new System.EventHandler(this.inforNV_SelectionChanged);
            // 
            // colNhanVien
            // 
            this.colNhanVien.HeaderText = "NHÂN VIÊN ";
            this.colNhanVien.MinimumWidth = 8;
            this.colNhanVien.Name = "colNhanVien";
            // 
            // colMaNV
            // 
            this.colMaNV.HeaderText = "MÃ NHÂN VIÊN";
            this.colMaNV.MinimumWidth = 8;
            this.colMaNV.Name = "colMaNV";
            // 
            // colPhongBan
            // 
            this.colPhongBan.HeaderText = "PHÒNG BAN";
            this.colPhongBan.MinimumWidth = 8;
            this.colPhongBan.Name = "colPhongBan";
            // 
            // colVaiTro
            // 
            this.colVaiTro.HeaderText = "VAI TRÒ";
            this.colVaiTro.MinimumWidth = 8;
            this.colVaiTro.Name = "colVaiTro";
            // 
            // colSDT
            // 
            this.colSDT.HeaderText = "SỐ ĐIỆN THOẠI ";
            this.colSDT.MinimumWidth = 8;
            this.colSDT.Name = "colSDT";
            // 
            // colGmail
            // 
            this.colGmail.HeaderText = "ĐỊA CHỈ MAIL";
            this.colGmail.MinimumWidth = 8;
            this.colGmail.Name = "colGmail";
            // 
            // colSua
            // 
            this.colSua.FillWeight = 60F;
            this.colSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colSua.HeaderText = "THAO TÁC ";
            this.colSua.MinimumWidth = 8;
            this.colSua.Name = "colSua";
            this.colSua.Text = "Sữa";
            this.colSua.UseColumnTextForButtonValue = true;
            // 
            // colKhoa
            // 
            this.colKhoa.FillWeight = 60F;
            this.colKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colKhoa.HeaderText = "";
            this.colKhoa.MinimumWidth = 8;
            this.colKhoa.Name = "colKhoa";
            this.colKhoa.Text = "Khóa ";
            this.colKhoa.UseColumnTextForButtonValue = true;
            // 
            // colDoiMK
            // 
            this.colDoiMK.FillWeight = 60F;
            this.colDoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colDoiMK.HeaderText = "";
            this.colDoiMK.MinimumWidth = 8;
            this.colDoiMK.Name = "colDoiMK";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BorderRadius = 12;
            this.pnlMenu.Controls.Add(this.btnAdmin);
            this.pnlMenu.Controls.Add(this.btnKetQua);
            this.pnlMenu.Controls.Add(this.btnThiNghiem);
            this.pnlMenu.Controls.Add(this.btnHienTruong);
            this.pnlMenu.Controls.Add(this.btnKeHoach);
            this.pnlMenu.Controls.Add(this.btnKinhDoanh);
            this.pnlMenu.Controls.Add(this.btnAllNV);
            this.pnlMenu.Controls.Add(this.labelTenMenu);
            this.hieuUngXuatHien.SetDecoration(this.pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.pnlMenu.Location = new System.Drawing.Point(103, 92);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(198, 371);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnAdmin
            // 
            this.hieuUngXuatHien.SetDecoration(this.btnAdmin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAdmin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdmin.FillColor = System.Drawing.Color.Green;
            this.btnAdmin.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.Location = new System.Drawing.Point(0, 316);
            this.btnAdmin.MaximumSize = new System.Drawing.Size(0, 45);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(198, 45);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmin.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnKetQua
            // 
            this.hieuUngXuatHien.SetDecoration(this.btnKetQua, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnKetQua, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnKetQua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKetQua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKetQua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKetQua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKetQua.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKetQua.FillColor = System.Drawing.Color.Green;
            this.btnKetQua.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetQua.ForeColor = System.Drawing.Color.White;
            this.btnKetQua.Location = new System.Drawing.Point(0, 271);
            this.btnKetQua.Name = "btnKetQua";
            this.btnKetQua.Size = new System.Drawing.Size(198, 45);
            this.btnKetQua.TabIndex = 6;
            this.btnKetQua.Text = "Kết quả ";
            this.btnKetQua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKetQua.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnThiNghiem
            // 
            this.hieuUngXuatHien.SetDecoration(this.btnThiNghiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnThiNghiem, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnThiNghiem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThiNghiem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThiNghiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThiNghiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThiNghiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThiNghiem.FillColor = System.Drawing.Color.Green;
            this.btnThiNghiem.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThiNghiem.ForeColor = System.Drawing.Color.White;
            this.btnThiNghiem.Location = new System.Drawing.Point(0, 226);
            this.btnThiNghiem.Name = "btnThiNghiem";
            this.btnThiNghiem.Size = new System.Drawing.Size(198, 45);
            this.btnThiNghiem.TabIndex = 5;
            this.btnThiNghiem.Text = "Thí nghiệm";
            this.btnThiNghiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThiNghiem.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnHienTruong
            // 
            this.hieuUngXuatHien.SetDecoration(this.btnHienTruong, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnHienTruong, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnHienTruong.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHienTruong.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHienTruong.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHienTruong.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHienTruong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHienTruong.FillColor = System.Drawing.Color.Green;
            this.btnHienTruong.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienTruong.ForeColor = System.Drawing.Color.White;
            this.btnHienTruong.Location = new System.Drawing.Point(0, 181);
            this.btnHienTruong.Name = "btnHienTruong";
            this.btnHienTruong.Size = new System.Drawing.Size(198, 45);
            this.btnHienTruong.TabIndex = 4;
            this.btnHienTruong.Text = "Hiện trường ";
            this.btnHienTruong.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHienTruong.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnKeHoach
            // 
            this.hieuUngXuatHien.SetDecoration(this.btnKeHoach, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnKeHoach, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnKeHoach.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKeHoach.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKeHoach.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKeHoach.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKeHoach.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKeHoach.FillColor = System.Drawing.Color.Green;
            this.btnKeHoach.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeHoach.ForeColor = System.Drawing.Color.White;
            this.btnKeHoach.Location = new System.Drawing.Point(0, 136);
            this.btnKeHoach.Name = "btnKeHoach";
            this.btnKeHoach.Size = new System.Drawing.Size(198, 45);
            this.btnKeHoach.TabIndex = 3;
            this.btnKeHoach.Text = "Kế hoạch";
            this.btnKeHoach.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKeHoach.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnKinhDoanh
            // 
            this.hieuUngXuatHien.SetDecoration(this.btnKinhDoanh, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnKinhDoanh, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnKinhDoanh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKinhDoanh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKinhDoanh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKinhDoanh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKinhDoanh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKinhDoanh.FillColor = System.Drawing.Color.Green;
            this.btnKinhDoanh.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKinhDoanh.ForeColor = System.Drawing.Color.White;
            this.btnKinhDoanh.Location = new System.Drawing.Point(0, 91);
            this.btnKinhDoanh.Name = "btnKinhDoanh";
            this.btnKinhDoanh.Size = new System.Drawing.Size(198, 45);
            this.btnKinhDoanh.TabIndex = 2;
            this.btnKinhDoanh.Text = "Kinh Doanh";
            this.btnKinhDoanh.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnKinhDoanh.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // btnAllNV
            // 
            this.hieuUngXuatHien.SetDecoration(this.btnAllNV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnAllNV, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnAllNV.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAllNV.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAllNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAllNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAllNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAllNV.FillColor = System.Drawing.Color.Green;
            this.btnAllNV.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllNV.ForeColor = System.Drawing.Color.White;
            this.btnAllNV.Location = new System.Drawing.Point(0, 46);
            this.btnAllNV.Name = "btnAllNV";
            this.btnAllNV.Size = new System.Drawing.Size(198, 45);
            this.btnAllNV.TabIndex = 1;
            this.btnAllNV.Text = "Tất cả nhân viên";
            this.btnAllNV.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAllNV.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // labelTenMenu
            // 
            this.guna2Transition1.SetDecoration(this.labelTenMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.hieuUngXuatHien.SetDecoration(this.labelTenMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.labelTenMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTenMenu.Font = new System.Drawing.Font("Roboto", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenMenu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelTenMenu.Location = new System.Drawing.Point(0, 0);
            this.labelTenMenu.Name = "labelTenMenu";
            this.labelTenMenu.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.labelTenMenu.Size = new System.Drawing.Size(198, 46);
            this.labelTenMenu.TabIndex = 0;
            this.labelTenMenu.Text = "PHÒNG BAN";
            this.labelTenMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlThanhChucNag
            // 
            this.pnlThanhChucNag.Controls.Add(this.btndsTatCa);
            this.pnlThanhChucNag.Controls.Add(this.btnDSdakhoa);
            this.pnlThanhChucNag.Controls.Add(this.lblArrow);
            this.pnlThanhChucNag.Controls.Add(this.btnDropMenu);
            this.hieuUngXuatHien.SetDecoration(this.pnlThanhChucNag, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.pnlThanhChucNag, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlThanhChucNag.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlThanhChucNag.Location = new System.Drawing.Point(0, 0);
            this.pnlThanhChucNag.Name = "pnlThanhChucNag";
            this.pnlThanhChucNag.Padding = new System.Windows.Forms.Padding(100, 10, 100, 10);
            this.pnlThanhChucNag.Size = new System.Drawing.Size(1338, 74);
            this.pnlThanhChucNag.TabIndex = 0;
            // 
            // btndsTatCa
            // 
            this.btndsTatCa.BorderRadius = 12;
            this.btndsTatCa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btndsTatCa.Checked = true;
            this.btndsTatCa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btndsTatCa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btndsTatCa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.hieuUngXuatHien.SetDecoration(this.btndsTatCa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btndsTatCa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btndsTatCa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndsTatCa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndsTatCa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndsTatCa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndsTatCa.FillColor = System.Drawing.Color.White;
            this.btndsTatCa.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndsTatCa.ForeColor = System.Drawing.Color.DimGray;
            this.btndsTatCa.Location = new System.Drawing.Point(967, 26);
            this.btndsTatCa.Name = "btndsTatCa";
            this.btndsTatCa.Size = new System.Drawing.Size(131, 48);
            this.btndsTatCa.TabIndex = 4;
            this.btndsTatCa.Text = "Tất cả";
            // 
            // btnDSdakhoa
            // 
            this.btnDSdakhoa.BorderRadius = 12;
            this.btnDSdakhoa.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDSdakhoa.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDSdakhoa.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnDSdakhoa.CheckedState.ForeColor = System.Drawing.Color.White;
            this.hieuUngXuatHien.SetDecoration(this.btnDSdakhoa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnDSdakhoa, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDSdakhoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDSdakhoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDSdakhoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDSdakhoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDSdakhoa.FillColor = System.Drawing.Color.White;
            this.btnDSdakhoa.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDSdakhoa.ForeColor = System.Drawing.Color.DimGray;
            this.btnDSdakhoa.Location = new System.Drawing.Point(1104, 26);
            this.btnDSdakhoa.Name = "btnDSdakhoa";
            this.btnDSdakhoa.Size = new System.Drawing.Size(131, 48);
            this.btnDSdakhoa.TabIndex = 3;
            this.btnDSdakhoa.Text = "Đã khóa";
            // 
            // lblArrow
            // 
            this.lblArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblArrow.AutoSize = true;
            this.lblArrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.guna2Transition1.SetDecoration(this.lblArrow, Guna.UI2.AnimatorNS.DecorationType.None);
            this.hieuUngXuatHien.SetDecoration(this.lblArrow, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblArrow.ForeColor = System.Drawing.Color.Transparent;
            this.lblArrow.Location = new System.Drawing.Point(265, 44);
            this.lblArrow.Name = "lblArrow";
            this.lblArrow.Size = new System.Drawing.Size(19, 20);
            this.lblArrow.TabIndex = 1;
            this.lblArrow.Text = "▼";
            this.lblArrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDropMenu
            // 
            this.btnDropMenu.BorderRadius = 12;
            this.hieuUngXuatHien.SetDecoration(this.btnDropMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this.btnDropMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDropMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDropMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDropMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDropMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDropMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(94)))), ((int)(((byte)(40)))));
            this.btnDropMenu.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDropMenu.ForeColor = System.Drawing.Color.White;
            this.btnDropMenu.Location = new System.Drawing.Point(103, 26);
            this.btnDropMenu.Name = "btnDropMenu";
            this.btnDropMenu.Size = new System.Drawing.Size(198, 48);
            this.btnDropMenu.TabIndex = 0;
            this.btnDropMenu.Text = "Tất cả nhân viên";
            this.btnDropMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDropMenu.TextOffset = new System.Drawing.Point(0, 2);
            // 
            // guna2Transition1
            // 
            this.guna2Transition1.AnimationType = Guna.UI2.AnimatorNS.AnimationType.Transparent;
            this.guna2Transition1.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.guna2Transition1.DefaultAnimation = animation2;
            // 
            // hieuUngXuatHien
            // 
            this.hieuUngXuatHien.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.hieuUngXuatHien.DefaultAnimation = animation1;
            this.hieuUngXuatHien.TimeStep = 0.3F;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1338, 712);
            this.Controls.Add(this.pnlThongTinNV);
            this.Controls.Add(this.PnlTopBar);
            this.hieuUngXuatHien.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.PnlTopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxLogo)).EndInit();
            this.pnlThongTinNV.ResumeLayout(false);
            this.pnlMenuCaiDat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inforNV)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlThanhChucNag.ResumeLayout(false);
            this.pnlThanhChucNag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PnlTopBar;
        private System.Windows.Forms.Label lbelName;
        private Guna.UI2.WinForms.Guna2PictureBox PicBoxLogo;
        private Guna.UI2.WinForms.Guna2TextBox BoxTimKiem;
        private Guna.UI2.WinForms.Guna2Button btonThemNV;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlThongTinNV;
        private Guna.UI2.WinForms.Guna2Panel pnlThanhChucNag;
        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private System.Windows.Forms.Label labelTenMenu;
        private Guna.UI2.WinForms.Guna2Button btnHienTruong;
        private Guna.UI2.WinForms.Guna2Button btnKeHoach;
        private Guna.UI2.WinForms.Guna2Button btnKinhDoanh;
        private Guna.UI2.WinForms.Guna2Button btnAllNV;
        private Guna.UI2.WinForms.Guna2Button btnThiNghiem;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button btnKetQua;
        private Guna.UI2.WinForms.Guna2Button btnDropMenu;
        private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
        private System.Windows.Forms.Label lblArrow;
        private Guna.UI2.WinForms.Guna2Button btnDSdakhoa;
        private Guna.UI2.WinForms.Guna2Button btndsTatCa;
        private Guna.UI2.WinForms.Guna2DataGridView inforNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhongBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVaiTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGmail;
        private System.Windows.Forms.DataGridViewButtonColumn colSua;
        private System.Windows.Forms.DataGridViewButtonColumn colKhoa;
        private System.Windows.Forms.DataGridViewButtonColumn colDoiMK;
        private Guna.UI2.WinForms.Guna2Button btnCaiDat;
        private Guna.UI2.WinForms.Guna2Panel pnlMenuCaiDat;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private Guna.UI2.WinForms.Guna2Button btnDoiMK;
        private Guna.UI2.WinForms.Guna2Transition hieuUngXuatHien;
    }
}