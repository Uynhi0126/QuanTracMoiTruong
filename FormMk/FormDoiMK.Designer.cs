namespace FormLogin
{
    partial class FormDoiMK
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoiMK));
            this.mauForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.anhKey = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTenChucNang = new System.Windows.Forms.Label();
            this.lblGhiChu = new System.Windows.Forms.Label();
            this.gbmkHienTai = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbmkHienTai = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbmkMoi = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbmkMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.gbXacNhanMK = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbXacNhanMK = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnXacNhanDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.anhKey)).BeginInit();
            this.gbmkHienTai.SuspendLayout();
            this.gbmkMoi.SuspendLayout();
            this.gbXacNhanMK.SuspendLayout();
            this.SuspendLayout();
            // 
            // mauForm
            // 
            this.mauForm.BorderRadius = 40;
            this.mauForm.ContainerControl = this;
            this.mauForm.DockIndicatorTransparencyValue = 0.6D;
            this.mauForm.DragForm = false;
            this.mauForm.TransparentWhileDrag = true;
            // 
            // anhKey
            // 
            this.anhKey.FillColor = System.Drawing.Color.Transparent;
            this.anhKey.Image = global::FormLogin.Properties.Resources.Key;
            this.anhKey.ImageRotate = 0F;
            this.anhKey.Location = new System.Drawing.Point(23, 23);
            this.anhKey.Name = "anhKey";
            this.anhKey.Size = new System.Drawing.Size(35, 35);
            this.anhKey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.anhKey.TabIndex = 3;
            this.anhKey.TabStop = false;
            // 
            // lblTenChucNang
            // 
            this.lblTenChucNang.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChucNang.ForeColor = System.Drawing.Color.Black;
            this.lblTenChucNang.Location = new System.Drawing.Point(64, 23);
            this.lblTenChucNang.Name = "lblTenChucNang";
            this.lblTenChucNang.Size = new System.Drawing.Size(219, 33);
            this.lblTenChucNang.TabIndex = 4;
            this.lblTenChucNang.Text = "Đổi mật khẩu \r\n";
            this.lblTenChucNang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGhiChu.Location = new System.Drawing.Point(19, 72);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(458, 49);
            this.lblGhiChu.TabIndex = 34;
            this.lblGhiChu.Text = "Vui lòng nhập mật khẩu hiện tại và mật khẩu mới để cập nhật.\r\n";
            this.lblGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbmkHienTai
            // 
            this.gbmkHienTai.BorderColor = System.Drawing.Color.Transparent;
            this.gbmkHienTai.Controls.Add(this.tbmkHienTai);
            this.gbmkHienTai.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbmkHienTai.FillColor = System.Drawing.Color.Transparent;
            this.gbmkHienTai.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmkHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.gbmkHienTai.Location = new System.Drawing.Point(23, 124);
            this.gbmkHienTai.Name = "gbmkHienTai";
            this.gbmkHienTai.Size = new System.Drawing.Size(454, 97);
            this.gbmkHienTai.TabIndex = 35;
            this.gbmkHienTai.Text = "Mật Khẩu Hiện Tại";
            this.gbmkHienTai.TextOffset = new System.Drawing.Point(-12, 0);
            // 
            // tbmkHienTai
            // 
            this.tbmkHienTai.BorderColor = System.Drawing.Color.LightGray;
            this.tbmkHienTai.BorderRadius = 10;
            this.tbmkHienTai.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbmkHienTai.DefaultText = "";
            this.tbmkHienTai.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbmkHienTai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbmkHienTai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmkHienTai.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmkHienTai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbmkHienTai.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbmkHienTai.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.tbmkHienTai.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmkHienTai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.tbmkHienTai.HoverState.BorderColor = System.Drawing.Color.Green;
            this.tbmkHienTai.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tbmkHienTai.IconRight = ((System.Drawing.Image)(resources.GetObject("tbmkHienTai.IconRight")));
            this.tbmkHienTai.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.tbmkHienTai.IconRightSize = new System.Drawing.Size(30, 20);
            this.tbmkHienTai.Location = new System.Drawing.Point(0, 40);
            this.tbmkHienTai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbmkHienTai.Name = "tbmkHienTai";
            this.tbmkHienTai.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.tbmkHienTai.PlaceholderText = "Nhập mật khẩu hiện tại ";
            this.tbmkHienTai.SelectedText = "";
            this.tbmkHienTai.Size = new System.Drawing.Size(454, 57);
            this.tbmkHienTai.TabIndex = 1;
            this.tbmkHienTai.Tag = "";
            this.tbmkHienTai.TextOffset = new System.Drawing.Point(5, 0);
            this.tbmkHienTai.UseSystemPasswordChar = true;
            this.tbmkHienTai.IconRightClick += new System.EventHandler(this.tbmkHienTai_IconRightClick);
            // 
            // gbmkMoi
            // 
            this.gbmkMoi.BorderColor = System.Drawing.Color.Transparent;
            this.gbmkMoi.Controls.Add(this.tbmkMoi);
            this.gbmkMoi.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbmkMoi.FillColor = System.Drawing.Color.Transparent;
            this.gbmkMoi.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbmkMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.gbmkMoi.Location = new System.Drawing.Point(23, 227);
            this.gbmkMoi.Name = "gbmkMoi";
            this.gbmkMoi.Size = new System.Drawing.Size(454, 97);
            this.gbmkMoi.TabIndex = 36;
            this.gbmkMoi.Text = "Mật Khẩu Mới";
            this.gbmkMoi.TextOffset = new System.Drawing.Point(-12, 0);
            // 
            // tbmkMoi
            // 
            this.tbmkMoi.BorderColor = System.Drawing.Color.LightGray;
            this.tbmkMoi.BorderRadius = 10;
            this.tbmkMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbmkMoi.DefaultText = "";
            this.tbmkMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbmkMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbmkMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmkMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbmkMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbmkMoi.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbmkMoi.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.tbmkMoi.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbmkMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.tbmkMoi.HoverState.BorderColor = System.Drawing.Color.Green;
            this.tbmkMoi.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tbmkMoi.IconRight = ((System.Drawing.Image)(resources.GetObject("tbmkMoi.IconRight")));
            this.tbmkMoi.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.tbmkMoi.IconRightSize = new System.Drawing.Size(30, 20);
            this.tbmkMoi.Location = new System.Drawing.Point(0, 40);
            this.tbmkMoi.Margin = new System.Windows.Forms.Padding(4);
            this.tbmkMoi.Name = "tbmkMoi";
            this.tbmkMoi.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.tbmkMoi.PlaceholderText = "Tối thiểu 6 ký tự ";
            this.tbmkMoi.SelectedText = "";
            this.tbmkMoi.Size = new System.Drawing.Size(454, 57);
            this.tbmkMoi.TabIndex = 1;
            this.tbmkMoi.Tag = "";
            this.tbmkMoi.TextOffset = new System.Drawing.Point(5, 0);
            this.tbmkMoi.UseSystemPasswordChar = true;
            this.tbmkMoi.IconRightClick += new System.EventHandler(this.tbmkMoi_IconRightClick);
            // 
            // gbXacNhanMK
            // 
            this.gbXacNhanMK.BorderColor = System.Drawing.Color.Transparent;
            this.gbXacNhanMK.Controls.Add(this.tbXacNhanMK);
            this.gbXacNhanMK.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gbXacNhanMK.FillColor = System.Drawing.Color.Transparent;
            this.gbXacNhanMK.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbXacNhanMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(95)))), ((int)(((byte)(80)))));
            this.gbXacNhanMK.Location = new System.Drawing.Point(23, 330);
            this.gbXacNhanMK.Name = "gbXacNhanMK";
            this.gbXacNhanMK.Size = new System.Drawing.Size(454, 97);
            this.gbXacNhanMK.TabIndex = 37;
            this.gbXacNhanMK.Text = "Xác Nhận Mật Khẩu Mới ";
            this.gbXacNhanMK.TextOffset = new System.Drawing.Point(-12, 0);
            // 
            // tbXacNhanMK
            // 
            this.tbXacNhanMK.BorderColor = System.Drawing.Color.LightGray;
            this.tbXacNhanMK.BorderRadius = 10;
            this.tbXacNhanMK.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbXacNhanMK.DefaultText = "";
            this.tbXacNhanMK.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbXacNhanMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbXacNhanMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbXacNhanMK.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbXacNhanMK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbXacNhanMK.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbXacNhanMK.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.tbXacNhanMK.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbXacNhanMK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.tbXacNhanMK.HoverState.BorderColor = System.Drawing.Color.Green;
            this.tbXacNhanMK.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tbXacNhanMK.IconRight = ((System.Drawing.Image)(resources.GetObject("tbXacNhanMK.IconRight")));
            this.tbXacNhanMK.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.tbXacNhanMK.IconRightSize = new System.Drawing.Size(30, 20);
            this.tbXacNhanMK.Location = new System.Drawing.Point(0, 40);
            this.tbXacNhanMK.Margin = new System.Windows.Forms.Padding(4);
            this.tbXacNhanMK.Name = "tbXacNhanMK";
            this.tbXacNhanMK.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.tbXacNhanMK.PlaceholderText = "Nhập lại mật khẩu mới";
            this.tbXacNhanMK.SelectedText = "";
            this.tbXacNhanMK.Size = new System.Drawing.Size(454, 57);
            this.tbXacNhanMK.TabIndex = 1;
            this.tbXacNhanMK.Tag = "";
            this.tbXacNhanMK.TextOffset = new System.Drawing.Point(5, 0);
            this.tbXacNhanMK.UseSystemPasswordChar = true;
            this.tbXacNhanMK.IconRightClick += new System.EventHandler(this.tbXacNhanMK_IconRightClick);
            // 
            // btnXacNhanDoiMK
            // 
            this.btnXacNhanDoiMK.BorderRadius = 10;
            this.btnXacNhanDoiMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanDoiMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanDoiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhanDoiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhanDoiMK.FillColor = System.Drawing.Color.Green;
            this.btnXacNhanDoiMK.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDoiMK.Image = global::FormLogin.Properties.Resources.tick;
            this.btnXacNhanDoiMK.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnXacNhanDoiMK.Location = new System.Drawing.Point(23, 456);
            this.btnXacNhanDoiMK.Name = "btnXacNhanDoiMK";
            this.btnXacNhanDoiMK.Size = new System.Drawing.Size(222, 50);
            this.btnXacNhanDoiMK.TabIndex = 38;
            this.btnXacNhanDoiMK.Text = "Xác Nhận Đổi";
            this.btnXacNhanDoiMK.Click += new System.EventHandler(this.btnXacNhanDoiMK_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.Red;
            this.btnHuy.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::FormLogin.Properties.Resources.Huy;
            this.btnHuy.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnHuy.Location = new System.Drawing.Point(251, 456);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(226, 50);
            this.btnHuy.TabIndex = 39;
            this.btnHuy.Text = "Hủy ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 529);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhanDoiMK);
            this.Controls.Add(this.gbXacNhanMK);
            this.Controls.Add(this.gbmkMoi);
            this.Controls.Add(this.gbmkHienTai);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.lblTenChucNang);
            this.Controls.Add(this.anhKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDoiMK";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormDoiMK";
            ((System.ComponentModel.ISupportInitialize)(this.anhKey)).EndInit();
            this.gbmkHienTai.ResumeLayout(false);
            this.gbmkMoi.ResumeLayout(false);
            this.gbXacNhanMK.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm mauForm;
        private Guna.UI2.WinForms.Guna2PictureBox anhKey;
        private System.Windows.Forms.Label lblTenChucNang;
        private System.Windows.Forms.Label lblGhiChu;
        private Guna.UI2.WinForms.Guna2GroupBox gbmkHienTai;
        private Guna.UI2.WinForms.Guna2GroupBox gbXacNhanMK;
        private Guna.UI2.WinForms.Guna2TextBox tbXacNhanMK;
        private Guna.UI2.WinForms.Guna2GroupBox gbmkMoi;
        private Guna.UI2.WinForms.Guna2TextBox tbmkMoi;
        private Guna.UI2.WinForms.Guna2TextBox tbmkHienTai;
        private Guna.UI2.WinForms.Guna2Button btnXacNhanDoiMK;
        private Guna.UI2.WinForms.Guna2Button btnHuy;
    }
}