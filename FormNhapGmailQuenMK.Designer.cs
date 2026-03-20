namespace FormLogin
{
    partial class FormNhapGmailQuenMK
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
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnTatForm = new Guna.UI2.WinForms.Guna2ControlBox();
            this.grBoxNhapMail = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tbEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblQuenMK = new System.Windows.Forms.Label();
            this.btnTiepTuc = new Guna.UI2.WinForms.Guna2Button();
            this.grBoxNhapMail.SuspendLayout();
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
            this.btnTatForm.Location = new System.Drawing.Point(421, 3);
            this.btnTatForm.Name = "btnTatForm";
            this.btnTatForm.Size = new System.Drawing.Size(73, 30);
            this.btnTatForm.TabIndex = 0;
            // 
            // grBoxNhapMail
            // 
            this.grBoxNhapMail.BackColor = System.Drawing.Color.Transparent;
            this.grBoxNhapMail.BorderColor = System.Drawing.Color.Transparent;
            this.grBoxNhapMail.Controls.Add(this.tbEmail);
            this.grBoxNhapMail.CustomBorderColor = System.Drawing.Color.Transparent;
            this.grBoxNhapMail.FillColor = System.Drawing.Color.Transparent;
            this.grBoxNhapMail.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBoxNhapMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.grBoxNhapMail.Location = new System.Drawing.Point(23, 115);
            this.grBoxNhapMail.Name = "grBoxNhapMail";
            this.grBoxNhapMail.Size = new System.Drawing.Size(454, 112);
            this.grBoxNhapMail.TabIndex = 2;
            this.grBoxNhapMail.Text = "Hãy nhập vào Email của bạn ";
            this.grBoxNhapMail.TextOffset = new System.Drawing.Point(-10, 0);
            // 
            // tbEmail
            // 
            this.tbEmail.BorderRadius = 10;
            this.tbEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEmail.DefaultText = "";
            this.tbEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbEmail.FocusedState.BorderColor = System.Drawing.Color.Green;
            this.tbEmail.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.Color.DimGray;
            this.tbEmail.HoverState.BorderColor = System.Drawing.Color.Green;
            this.tbEmail.Location = new System.Drawing.Point(0, 40);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(5);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.tbEmail.PlaceholderText = "Nhập vào Email ";
            this.tbEmail.SelectedText = "";
            this.tbEmail.Size = new System.Drawing.Size(454, 72);
            this.tbEmail.TabIndex = 2;
            // 
            // lblQuenMK
            // 
            this.lblQuenMK.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuenMK.ForeColor = System.Drawing.Color.Green;
            this.lblQuenMK.Location = new System.Drawing.Point(23, 29);
            this.lblQuenMK.Name = "lblQuenMK";
            this.lblQuenMK.Size = new System.Drawing.Size(454, 74);
            this.lblQuenMK.TabIndex = 3;
            this.lblQuenMK.Text = "QUÊN MẬT KHẨU ";
            this.lblQuenMK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.BorderRadius = 10;
            this.btnTiepTuc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTiepTuc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTiepTuc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTiepTuc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTiepTuc.FillColor = System.Drawing.Color.Green;
            this.btnTiepTuc.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTiepTuc.ForeColor = System.Drawing.Color.White;
            this.btnTiepTuc.Location = new System.Drawing.Point(70, 245);
            this.btnTiepTuc.Margin = new System.Windows.Forms.Padding(50, 3, 50, 3);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(360, 51);
            this.btnTiepTuc.TabIndex = 4;
            this.btnTiepTuc.Text = "Tiếp tục ";
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // FormNhapGmailQuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 315);
            this.Controls.Add(this.btnTiepTuc);
            this.Controls.Add(this.lblQuenMK);
            this.Controls.Add(this.grBoxNhapMail);
            this.Controls.Add(this.btnTatForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNhapGmailQuenMK";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormNhapGmailQuenMK";
            this.Load += new System.EventHandler(this.FormNhapGmailQuenMK_Load);
            this.grBoxNhapMail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox btnTatForm;
        private Guna.UI2.WinForms.Guna2GroupBox grBoxNhapMail;
        private System.Windows.Forms.Label lblQuenMK;
        private Guna.UI2.WinForms.Guna2Button btnTiepTuc;
        private Guna.UI2.WinForms.Guna2TextBox tbEmail;
    }
}