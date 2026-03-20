namespace FormLogin
{
    partial class FormNhacKyLaiHopDong
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
            this.mauForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.hinhbutchi = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblNameForm = new System.Windows.Forms.Label();
            this.flpDanhSach = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDaHieu = new Guna.UI2.WinForms.Guna2Button();
            this.lblGhiChu = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hinhbutchi)).BeginInit();
            this.SuspendLayout();
            // 
            // mauForm
            // 
            this.mauForm.BorderRadius = 40;
            this.mauForm.ContainerControl = this;
            this.mauForm.DockIndicatorTransparencyValue = 0.6D;
            this.mauForm.DragForm = false;
            this.mauForm.ResizeForm = false;
            this.mauForm.TransparentWhileDrag = true;
            // 
            // hinhbutchi
            // 
            this.hinhbutchi.Image = global::FormLogin.Properties.Resources.Chuong;
            this.hinhbutchi.ImageRotate = 0F;
            this.hinhbutchi.Location = new System.Drawing.Point(23, 23);
            this.hinhbutchi.Name = "hinhbutchi";
            this.hinhbutchi.Size = new System.Drawing.Size(25, 25);
            this.hinhbutchi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hinhbutchi.TabIndex = 26;
            this.hinhbutchi.TabStop = false;
            // 
            // lblNameForm
            // 
            this.lblNameForm.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNameForm.Location = new System.Drawing.Point(54, 20);
            this.lblNameForm.Name = "lblNameForm";
            this.lblNameForm.Size = new System.Drawing.Size(299, 32);
            this.lblNameForm.TabIndex = 30;
            this.lblNameForm.Text = "Nhắc Lại Hợp Đồng Quý ";
            this.lblNameForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpDanhSach
            // 
            this.flpDanhSach.AutoScroll = true;
            this.flpDanhSach.Location = new System.Drawing.Point(23, 130);
            this.flpDanhSach.Name = "flpDanhSach";
            this.flpDanhSach.Size = new System.Drawing.Size(654, 291);
            this.flpDanhSach.TabIndex = 31;
            // 
            // btnDaHieu
            // 
            this.btnDaHieu.BorderRadius = 10;
            this.btnDaHieu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDaHieu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDaHieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDaHieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDaHieu.FillColor = System.Drawing.Color.Green;
            this.btnDaHieu.Font = new System.Drawing.Font("Roboto", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaHieu.ForeColor = System.Drawing.Color.White;
            this.btnDaHieu.Image = global::FormLogin.Properties.Resources.tick;
            this.btnDaHieu.ImageOffset = new System.Drawing.Point(-5, 0);
            this.btnDaHieu.Location = new System.Drawing.Point(206, 427);
            this.btnDaHieu.Name = "btnDaHieu";
            this.btnDaHieu.Size = new System.Drawing.Size(287, 50);
            this.btnDaHieu.TabIndex = 32;
            this.btnDaHieu.Text = "Đã hiểu ";
            // 
            // lblGhiChu
            // 
            this.lblGhiChu.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhiChu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGhiChu.Location = new System.Drawing.Point(23, 64);
            this.lblGhiChu.Name = "lblGhiChu";
            this.lblGhiChu.Size = new System.Drawing.Size(654, 54);
            this.lblGhiChu.TabIndex = 33;
            this.lblGhiChu.Text = "Các hợp đồng chu kỳ Quý sắp hết hạn trong 30 ngày tới – nhấn 📧 để gửi email nhắc" +
    " tái ký cho khách hàng:\r\n";
            this.lblGhiChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormNhacKyLaiHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.lblGhiChu);
            this.Controls.Add(this.btnDaHieu);
            this.Controls.Add(this.flpDanhSach);
            this.Controls.Add(this.lblNameForm);
            this.Controls.Add(this.hinhbutchi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhacKyLaiHopDong";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.hinhbutchi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm mauForm;
        private Guna.UI2.WinForms.Guna2PictureBox hinhbutchi;
        private System.Windows.Forms.FlowLayoutPanel flpDanhSach;
        private System.Windows.Forms.Label lblNameForm;
        private System.Windows.Forms.Label lblGhiChu;
        private Guna.UI2.WinForms.Guna2Button btnDaHieu;
    }
}