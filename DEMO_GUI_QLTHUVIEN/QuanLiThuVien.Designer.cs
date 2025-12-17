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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lstMenu = new System.Windows.Forms.ListBox();
            this.lblMenuHeader = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1182, 28);
            this.menuStrip1.TabIndex = 0;
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniDangXuat,
            this.mniThoat});
            this.mnuHeThong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.mnuHeThong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(88, 24);
            this.mnuHeThong.Text = "Hệ thống";
            // 
            // mniDangXuat
            // 
            this.mniDangXuat.Name = "mniDangXuat";
            this.mniDangXuat.Size = new System.Drawing.Size(166, 26);
            this.mniDangXuat.Text = "Đăng xuất";
            this.mniDangXuat.Click += new System.EventHandler(this.mniDangXuat_Click);
            // 
            // mniThoat
            // 
            this.mniThoat.Name = "mniThoat";
            this.mniThoat.Size = new System.Drawing.Size(166, 26);
            this.mniThoat.Text = "Thoát";
            this.mniThoat.Click += new System.EventHandler(this.mniThoat_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlLeft.Controls.Add(this.lstMenu);
            this.pnlLeft.Controls.Add(this.lblMenuHeader);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 28);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(260, 625);
            this.pnlLeft.TabIndex = 0;
            // 
            // lstMenu
            // 
            this.lstMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lstMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstMenu.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lstMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lstMenu.FormattingEnabled = true;
            this.lstMenu.IntegralHeight = false;
            this.lstMenu.ItemHeight = 25;
            this.lstMenu.Location = new System.Drawing.Point(0, 65);
            this.lstMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstMenu.Name = "lstMenu";
            this.lstMenu.Size = new System.Drawing.Size(260, 560);
            this.lstMenu.TabIndex = 0;
            // 
            // lblMenuHeader
            // 
            this.lblMenuHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblMenuHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMenuHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMenuHeader.ForeColor = System.Drawing.Color.White;
            this.lblMenuHeader.Location = new System.Drawing.Point(0, 0);
            this.lblMenuHeader.Name = "lblMenuHeader";
            this.lblMenuHeader.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMenuHeader.Size = new System.Drawing.Size(260, 65);
            this.lblMenuHeader.TabIndex = 1;
            this.lblMenuHeader.Text = " DANH MỤC";
            this.lblMenuHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuanLiThuVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuanLiThuVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Thư Viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLiThuVien_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}