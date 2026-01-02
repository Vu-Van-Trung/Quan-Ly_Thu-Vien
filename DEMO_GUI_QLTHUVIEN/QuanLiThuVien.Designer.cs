using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class QuanLiThuVien
    {
        private IContainer components = null;

        private Panel pnlLeft;
        private FlowLayoutPanel pnlMenuContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlLeft = new Panel();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            pnlMenuContainer = new FlowLayoutPanel();
            lblMenuHeader = new Label();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            label1 = new Label();
            btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            pnlLeft.SuspendLayout();
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(44, 62, 80);
            pnlLeft.Controls.Add(btnLogout);
            pnlLeft.Controls.Add(pnlMenuContainer);
            pnlLeft.Controls.Add(lblMenuHeader);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 0);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(260, 761);
            pnlLeft.TabIndex = 0;
            // 
            // btnLogout
            // 
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.FromArgb(231, 76, 60);
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(260, 60);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Đăng Xuất";
            btnLogout.BorderRadius = 15;
            btnLogout.Margin = new Padding(10);
            btnLogout.Click += btnLogout_Click_1;
            // 
            // pnlMenuContainer
            // 
            pnlMenuContainer.BackColor = Color.Salmon;
            pnlMenuContainer.Dock = DockStyle.Fill;
            pnlMenuContainer.Location = new Point(0, 77);
            pnlMenuContainer.Name = "pnlMenuContainer";
            pnlMenuContainer.Size = new Size(260, 684);
            pnlMenuContainer.TabIndex = 0;
            pnlMenuContainer.AutoScroll = true;
            pnlMenuContainer.FlowDirection = FlowDirection.TopDown;
            pnlMenuContainer.WrapContents = false;
            pnlMenuContainer.Padding = new Padding(0, 10, 0, 0);
            // 
            // lblMenuHeader
            // 
            lblMenuHeader.BackColor = Color.Red;
            lblMenuHeader.Dock = DockStyle.Top;
            lblMenuHeader.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMenuHeader.ForeColor = Color.White;
            lblMenuHeader.Location = new Point(0, 0);
            lblMenuHeader.Name = "lblMenuHeader";
            lblMenuHeader.Padding = new Padding(10, 0, 0, 0);
            lblMenuHeader.Size = new Size(260, 77);
            lblMenuHeader.TabIndex = 1;
            lblMenuHeader.Text = " DANH MỤC";
            lblMenuHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.Controls.Add(label1);
            guna2CustomGradientPanel1.Controls.Add(btnMinimize);
            guna2CustomGradientPanel1.Controls.Add(btnCancel);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges5;
            guna2CustomGradientPanel1.Location = new Point(259, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel1.Size = new Size(1604, 77);
            guna2CustomGradientPanel1.TabIndex = 2;
            guna2CustomGradientPanel1.BorderRadius = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(550, 15);
            label1.Name = "label1";
            label1.Size = new Size(450, 48);
            label1.TabIndex = 24;
            label1.Text = "Quản Lý Thư Viện (Beta)";
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
            btnMinimize.DisabledState.BorderColor = Color.DarkGray;
            btnMinimize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimize.FillColor = Color.White;
            btnMinimize.Font = new Font("Segoe UI", 9F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources._786263;
            btnMinimize.ImageSize = new Size(50, 50);
            btnMinimize.Location = new Point(1325, 0);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMinimize.Size = new Size(83, 77);
            btnMinimize.TabIndex = 22;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.Transparent;
            btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            btnCancel.ImageSize = new Size(60, 60);
            btnCancel.Location = new Point(1401, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCancel.Size = new Size(88, 77);
            btnCancel.TabIndex = 11;
            btnCancel.Click += btnCancel_Click;
            // 
            // QuanLiThuVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1848, 761);
            Controls.Add(guna2CustomGradientPanel1);
            Controls.Add(pnlLeft);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLiThuVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Thư Viện";
            WindowState = FormWindowState.Maximized;
            Load += QuanLiThuVien_Load_1;
            pnlLeft.ResumeLayout(false);
            guna2CustomGradientPanel1.ResumeLayout(false);
            guna2CustomGradientPanel1.PerformLayout();
            ResumeLayout(false);

        }
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private Label lblMenuHeader;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
    }
}