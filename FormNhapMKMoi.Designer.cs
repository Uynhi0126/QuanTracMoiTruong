namespace FormLogin
{
    partial class FormNhapMKMoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNhapMKMoi));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnTatForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grBoxNhapOTP = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnXacNhanDoiMK = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMatKhauMoi = new Guna.UI2.WinForms.Guna2TextBox();
            this.grBoxNhapOTP.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.DragForm = false;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // btnTatForm
            // 
            this.btnTatForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTatForm.FillColor = System.Drawing.Color.Transparent;
            this.btnTatForm.IconColor = System.Drawing.Color.Black;
            this.btnTatForm.Location = new System.Drawing.Point(419, 1);
            this.btnTatForm.Name = "btnTatForm";
            this.btnTatForm.Size = new System.Drawing.Size(73, 30);
            this.btnTatForm.TabIndex = 9;
            // 
            // grBoxNhapOTP
            // 
            this.grBoxNhapOTP.BackColor = System.Drawing.Color.Transparent;
            this.grBoxNhapOTP.BorderColor = System.Drawing.Color.Transparent;
            this.grBoxNhapOTP.Controls.Add(this.tbMatKhauMoi);
            this.grBoxNhapOTP.CustomBorderColor = System.Drawing.Color.Transparent;
            this.grBoxNhapOTP.FillColor = System.Drawing.Color.Transparent;
            this.grBoxNhapOTP.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxNhapOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grBoxNhapOTP.Location = new System.Drawing.Point(29, 111);
            this.grBoxNhapOTP.Name = "grBoxNhapOTP";
            this.grBoxNhapOTP.Size = new System.Drawing.Size(454, 113);
            this.grBoxNhapOTP.TabIndex = 10;
            this.grBoxNhapOTP.Text = "Nhập vào mật khẩu mới";
            this.grBoxNhapOTP.TextOffset = new System.Drawing.Point(-10, 0);
            // 
            // btnXacNhanDoiMK
            // 
            this.btnXacNhanDoiMK.BorderRadius = 10;
            this.btnXacNhanDoiMK.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanDoiMK.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXacNhanDoiMK.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXacNhanDoiMK.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXacNhanDoiMK.FillColor = System.Drawing.Color.Green;
            this.btnXacNhanDoiMK.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhanDoiMK.ForeColor = System.Drawing.Color.White;
            this.btnXacNhanDoiMK.Location = new System.Drawing.Point(70, 241);
            this.btnXacNhanDoiMK.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.btnXacNhanDoiMK.Name = "btnXacNhanDoiMK";
            this.btnXacNhanDoiMK.Size = new System.Drawing.Size(360, 51);
            this.btnXacNhanDoiMK.TabIndex = 12;
            this.btnXacNhanDoiMK.Text = "Xác nhận ";
            this.btnXacNhanDoiMK.Click += new System.EventHandler(this.btnXacNhanDoiMK_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 74);
            this.label1.TabIndex = 11;
            this.label1.Text = "NHẬP MẬT KHẨU MỚI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbMatKhauMoi
            // 
            this.tbMatKhauMoi.BorderColor = System.Drawing.Color.LightGray;
            this.tbMatKhauMoi.BorderRadius = 10;
            this.tbMatKhauMoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMatKhauMoi.DefaultText = "";
            this.tbMatKhauMoi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbMatKhauMoi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbMatKhauMoi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhauMoi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbMatKhauMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMatKhauMoi.FillColor = System.Drawing.Color.WhiteSmoke;
            this.tbMatKhauMoi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhauMoi.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic);
            this.tbMatKhauMoi.ForeColor = System.Drawing.Color.DimGray;
            this.tbMatKhauMoi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbMatKhauMoi.IconLeftSize = new System.Drawing.Size(40, 40);
            this.tbMatKhauMoi.IconRight = ((System.Drawing.Image)(resources.GetObject("tbMatKhauMoi.IconRight")));
            this.tbMatKhauMoi.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.tbMatKhauMoi.IconRightSize = new System.Drawing.Size(30, 20);
            this.tbMatKhauMoi.Location = new System.Drawing.Point(0, 40);
            this.tbMatKhauMoi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatKhauMoi.Name = "tbMatKhauMoi";
            this.tbMatKhauMoi.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbMatKhauMoi.PlaceholderText = "Nhập vào mật khẩu mới";
            this.tbMatKhauMoi.SelectedText = "";
            this.tbMatKhauMoi.Size = new System.Drawing.Size(454, 73);
            this.tbMatKhauMoi.TabIndex = 1;
            this.tbMatKhauMoi.Tag = "";
            this.tbMatKhauMoi.UseSystemPasswordChar = true;
            this.tbMatKhauMoi.IconRightClick += new System.EventHandler(this.tbMatKhauMoi_IconRightClick);
            // 
            // FormNhapMKMoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.btnTatForm);
            this.Controls.Add(this.grBoxNhapOTP);
            this.Controls.Add(this.btnXacNhanDoiMK);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapMKMoi";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNhapMKMoi";
            this.grBoxNhapOTP.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox btnTatForm;
        private Guna.UI2.WinForms.Guna2GroupBox grBoxNhapOTP;
        private Guna.UI2.WinForms.Guna2Button btnXacNhanDoiMK;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox tbMatKhauMoi;
    }
}