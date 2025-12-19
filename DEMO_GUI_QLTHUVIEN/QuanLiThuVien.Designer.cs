using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class QuanLiThuVien
    {
        private IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mniDangXuat;
        private ToolStripMenuItem mniThoat;

        private Panel pnlLeft;
        private Label lblMenuHeader;
        private ListBox lstMenu;

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
            menuStrip1 = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mniDangXuat = new ToolStripMenuItem();
            mniThoat = new ToolStripMenuItem();
            pnlLeft = new Panel();
            lstMenu = new ListBox();
            lblMenuHeader = new Label();
            menuStrip1.SuspendLayout();
            pnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.White;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuHeThong });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1848, 28);
            menuStrip1.TabIndex = 0;
            // 
            // mnuHeThong
            // 
            mnuHeThong.Alignment = ToolStripItemAlignment.Right;
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mniDangXuat, mniThoat });
            mnuHeThong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            mnuHeThong.ForeColor = Color.FromArgb(64, 64, 64);
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(88, 24);
            mnuHeThong.Text = "Hệ thống";
            // 
            // mniDangXuat
            // 
            mniDangXuat.Name = "mniDangXuat";
            mniDangXuat.Size = new Size(224, 26);
            mniDangXuat.Text = "Đăng xuất";
            mniDangXuat.Click += mniDangXuat_Click;
            // 
            // mniThoat
            // 
            mniThoat.Name = "mniThoat";
            mniThoat.Size = new Size(224, 26);
            mniThoat.Text = "Thoát";
            mniThoat.Click += mniThoat_Click;
            // 
            // pnlLeft
            // 
            pnlLeft.BackColor = Color.FromArgb(44, 62, 80);
            pnlLeft.Controls.Add(lstMenu);
            pnlLeft.Controls.Add(lblMenuHeader);
            pnlLeft.Dock = DockStyle.Left;
            pnlLeft.Location = new Point(0, 28);
            pnlLeft.Margin = new Padding(3, 4, 3, 4);
            pnlLeft.Name = "pnlLeft";
            pnlLeft.Size = new Size(260, 733);
            pnlLeft.TabIndex = 0;
            // 
            // lstMenu
            // 
            lstMenu.BackColor = Color.FromArgb(44, 62, 80);
            lstMenu.BorderStyle = BorderStyle.None;
            lstMenu.Cursor = Cursors.Hand;
            lstMenu.Dock = DockStyle.Fill;
            lstMenu.Font = new Font("Segoe UI", 11F);
            lstMenu.ForeColor = Color.WhiteSmoke;
            lstMenu.FormattingEnabled = true;
            lstMenu.IntegralHeight = false;
            lstMenu.Location = new Point(0, 65);
            lstMenu.Margin = new Padding(3, 4, 3, 4);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(260, 668);
            lstMenu.TabIndex = 0;
            // 
            // lblMenuHeader
            // 
            lblMenuHeader.BackColor = Color.FromArgb(52, 73, 94);
            lblMenuHeader.Dock = DockStyle.Top;
            lblMenuHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMenuHeader.ForeColor = Color.White;
            lblMenuHeader.Location = new Point(0, 0);
            lblMenuHeader.Name = "lblMenuHeader";
            lblMenuHeader.Padding = new Padding(10, 0, 0, 0);
            lblMenuHeader.Size = new Size(260, 65);
            lblMenuHeader.TabIndex = 1;
            lblMenuHeader.Text = " DANH MỤC";
            lblMenuHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // QuanLiThuVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1848, 761);
            Controls.Add(pnlLeft);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLiThuVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hệ thống Quản lý Thư Viện";
            WindowState = FormWindowState.Maximized;
            Load += QuanLiThuVien_Load_1;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlLeft.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }
    }
}