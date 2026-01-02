// QuanLyTaiKhoan.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DEMO_GUI_QLTHUVIEN
{
    partial class QuanLyTaiKhoan
    {
        private IContainer components = null;
        private Guna2DataGridView dgvTaiKhoan;
        private Guna2TextBox txtTenDangNhap;
        private Guna2ComboBox cbNhanVien;
        private Guna2ComboBox cbQuyenHan;
        private Guna2ComboBox cbTrangThai;
        private Guna2Button btnThem;
        private Guna2Button btnCapNhat;
        private Guna2Button btnKhoa;
        private Guna2Button btnMoKhoa;
        private Guna2Button btnDoiMatKhau;
        private Guna2Button btnClose;
        
        private Label lblTitle;
        private GroupBox grpInfo;
        private Label lblTenDangNhap;
        private Label lblNhanVien;
        private Label lblQuyenHan;
        private Label lblTrangThai;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            
            dgvTaiKhoan = new Guna2DataGridView();
            txtTenDangNhap = new Guna2TextBox();
            cbNhanVien = new Guna2ComboBox();
            cbQuyenHan = new Guna2ComboBox();
            cbTrangThai = new Guna2ComboBox();
            btnThem = new Guna2Button();
            btnCapNhat = new Guna2Button();
            btnKhoa = new Guna2Button();
            btnMoKhoa = new Guna2Button();
            btnDoiMatKhau = new Guna2Button();
            btnClose = new Guna2Button();
            lblTitle = new Label();
            grpInfo = new GroupBox();
            lblTenDangNhap = new Label();
            lblNhanVien = new Label();
            lblQuyenHan = new Label();
            lblTrangThai = new Label();
            
            ((ISupportInitialize)dgvTaiKhoan).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.AllowUserToAddRows = false;
            dgvTaiKhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTaiKhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTaiKhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTaiKhoan.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTaiKhoan.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTaiKhoan.GridColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.Location = new Point(29, 74);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.ReadOnly = true;
            dgvTaiKhoan.RowHeadersVisible = false;
            dgvTaiKhoan.RowHeadersWidth = 51;
            dgvTaiKhoan.Size = new Size(1249, 362);
            dgvTaiKhoan.TabIndex = 1;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTaiKhoan.ThemeStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvTaiKhoan.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTaiKhoan.ThemeStyle.HeaderStyle.Height = 40;
            dgvTaiKhoan.ThemeStyle.ReadOnly = true;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTaiKhoan.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTaiKhoan.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.5F);
            dgvTaiKhoan.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTaiKhoan.ThemeStyle.RowsStyle.Height = 29;
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTaiKhoan.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTaiKhoan.CellClick += dgvTaiKhoan_CellClick;
            // 
            // txtTenDangNhap
            // 
            txtTenDangNhap.BorderRadius = 2;
            txtTenDangNhap.Cursor = Cursors.IBeam;
            txtTenDangNhap.CustomizableEdges = customizableEdges1;
            txtTenDangNhap.DefaultText = "";
            txtTenDangNhap.Font = new Font("Segoe UI", 10F);
            txtTenDangNhap.Location = new Point(240, 35);
            txtTenDangNhap.Margin = new Padding(3, 4, 3, 4);
            txtTenDangNhap.Name = "txtTenDangNhap";
            txtTenDangNhap.PlaceholderText = "";
            txtTenDangNhap.SelectedText = "";
            txtTenDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTenDangNhap.Size = new Size(329, 30);
            txtTenDangNhap.TabIndex = 1;
            // 
            // cbNhanVien
            // 
            cbNhanVien.BackColor = Color.Transparent;
            cbNhanVien.BorderRadius = 2;
            cbNhanVien.CustomizableEdges = customizableEdges3;
            cbNhanVien.DrawMode = DrawMode.OwnerDrawFixed;
            cbNhanVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNhanVien.FocusedColor = Color.FromArgb(94, 148, 255);
            cbNhanVien.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbNhanVien.Font = new Font("Segoe UI", 10F);
            cbNhanVien.ForeColor = Color.FromArgb(68, 88, 112);
            cbNhanVien.ItemHeight = 24;
            cbNhanVien.Location = new Point(706, 35);
            cbNhanVien.Name = "cbNhanVien";
            cbNhanVien.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbNhanVien.Size = new Size(520, 30);
            cbNhanVien.TabIndex = 2;
            // 
            // cbQuyenHan
            // 
            cbQuyenHan.BackColor = Color.Transparent;
            cbQuyenHan.BorderRadius = 2;
            cbQuyenHan.CustomizableEdges = customizableEdges5;
            cbQuyenHan.DrawMode = DrawMode.OwnerDrawFixed;
            cbQuyenHan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuyenHan.FocusedColor = Color.FromArgb(94, 148, 255);
            cbQuyenHan.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbQuyenHan.Font = new Font("Segoe UI", 10F);
            cbQuyenHan.ForeColor = Color.FromArgb(68, 88, 112);
            cbQuyenHan.ItemHeight = 24;
            cbQuyenHan.Location = new Point(240, 81);
            cbQuyenHan.Name = "cbQuyenHan";
            cbQuyenHan.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbQuyenHan.Size = new Size(329, 30);
            cbQuyenHan.TabIndex = 3;
            // 
            // cbTrangThai
            // 
            cbTrangThai.BackColor = Color.Transparent;
            cbTrangThai.BorderRadius = 2;
            cbTrangThai.CustomizableEdges = customizableEdges7;
            cbTrangThai.DrawMode = DrawMode.OwnerDrawFixed;
            cbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTrangThai.FocusedColor = Color.FromArgb(94, 148, 255);
            cbTrangThai.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTrangThai.Font = new Font("Segoe UI", 10F);
            cbTrangThai.ForeColor = Color.FromArgb(68, 88, 112);
            cbTrangThai.ItemHeight = 24;
            cbTrangThai.Location = new Point(706, 81);
            cbTrangThai.Name = "cbTrangThai";
            cbTrangThai.ShadowDecoration.CustomizableEdges = customizableEdges8;
            cbTrangThai.Size = new Size(520, 30);
            cbTrangThai.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.CustomizableEdges = customizableEdges9;
            btnThem.FillColor = Color.FromArgb(76, 175, 80);
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(29, 676);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "+ Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.CustomizableEdges = customizableEdges11;
            btnCapNhat.FillColor = Color.FromArgb(33, 150, 243);
            btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(149, 676);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCapNhat.Size = new Size(110, 40);
            btnCapNhat.TabIndex = 4;
            btnCapNhat.Text = "✎ Cập nhật";
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnKhoa
            // 
            btnKhoa.CustomizableEdges = customizableEdges13;
            btnKhoa.FillColor = Color.FromArgb(244, 67, 54);
            btnKhoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnKhoa.ForeColor = Color.White;
            btnKhoa.Location = new Point(269, 676);
            btnKhoa.Name = "btnKhoa";
            btnKhoa.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnKhoa.Size = new Size(110, 40);
            btnKhoa.TabIndex = 5;
            btnKhoa.Text = "🔒 Khóa";
            btnKhoa.Click += btnKhoa_Click;
            // 
            // btnMoKhoa
            // 
            btnMoKhoa.CustomizableEdges = customizableEdges15;
            btnMoKhoa.FillColor = Color.FromArgb(255, 152, 0);
            btnMoKhoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMoKhoa.ForeColor = Color.White;
            btnMoKhoa.Location = new Point(389, 676);
            btnMoKhoa.Name = "btnMoKhoa";
            btnMoKhoa.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnMoKhoa.Size = new Size(110, 40);
            btnMoKhoa.TabIndex = 6;
            btnMoKhoa.Text = "🔓 Mở khóa";
            btnMoKhoa.Click += btnMoKhoa_Click;
            // 
            // btnDoiMatKhau
            // 
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnDoiMatKhau.CustomizableEdges = customizableEdges17;
            btnDoiMatKhau.FillColor = Color.FromArgb(158, 158, 158);
            btnDoiMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(509, 676);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnDoiMatKhau.Size = new Size(130, 40);
            btnDoiMatKhau.TabIndex = 7;
            btnDoiMatKhau.Text = "🔑 Đổi mật khẩu";
            btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(459, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(390, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👤 QUẢN LÝ TÀI KHOẢN";
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblTenDangNhap);
            grpInfo.Controls.Add(txtTenDangNhap);
            grpInfo.Controls.Add(lblNhanVien);
            grpInfo.Controls.Add(cbNhanVien);
            grpInfo.Controls.Add(lblQuyenHan);
            grpInfo.Controls.Add(cbQuyenHan);
            grpInfo.Controls.Add(lblTrangThai);
            grpInfo.Controls.Add(cbTrangThai);
            grpInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            grpInfo.Location = new Point(29, 456);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(1249, 140);
            grpInfo.TabIndex = 2;
            grpInfo.TabStop = false;
            grpInfo.Text = "📝 Thông Tin Tài Khoản";
            // 
            // lblTenDangNhap
            // 
            lblTenDangNhap.Font = new Font("Segoe UI", 10F);
            lblTenDangNhap.ForeColor = Color.FromArgb(66, 66, 66);
            lblTenDangNhap.Location = new Point(90, 40);
            lblTenDangNhap.Name = "lblTenDangNhap";
            lblTenDangNhap.Size = new Size(130, 25);
            lblTenDangNhap.TabIndex = 0;
            lblTenDangNhap.Text = "Tên đăng nhập:";
            // 
            // lblNhanVien
            // 
            lblNhanVien.Font = new Font("Segoe UI", 10F);
            lblNhanVien.ForeColor = Color.FromArgb(66, 66, 66);
            lblNhanVien.Location = new Point(600, 40);
            lblNhanVien.Name = "lblNhanVien";
            lblNhanVien.Size = new Size(100, 25);
            lblNhanVien.TabIndex = 2;
            lblNhanVien.Text = "Nhân viên:";
            // 
            // lblQuyenHan
            // 
            lblQuyenHan.Font = new Font("Segoe UI", 10F);
            lblQuyenHan.ForeColor = Color.FromArgb(66, 66, 66);
            lblQuyenHan.Location = new Point(90, 86);
            lblQuyenHan.Name = "lblQuyenHan";
            lblQuyenHan.Size = new Size(130, 25);
            lblQuyenHan.TabIndex = 4;
            lblQuyenHan.Text = "Quyền hạn:";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.ForeColor = Color.FromArgb(66, 66, 66);
            lblTrangThai.Location = new Point(600, 86);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 25);
            lblTrangThai.TabIndex = 6;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // btnClose
            // 
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnClose.CustomizableEdges = customizableEdges19;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = SystemColors.ButtonHighlight;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = Properties.Resources.cancel_50px;
            btnClose.ImageSize = new Size(40, 40);
            btnClose.Location = new Point(1254, 12);
            btnClose.Name = "btnClose";
            btnClose.PressedColor = SystemColors.ButtonFace;
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnClose.Size = new Size(44, 36);
            btnClose.TabIndex = 10;
            btnClose.Click += btnClose_Click;
            // 
            // QuanLyTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1310, 743);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(dgvTaiKhoan);
            Controls.Add(grpInfo);
            Controls.Add(btnThem);
            Controls.Add(btnCapNhat);
            Controls.Add(btnKhoa);
            Controls.Add(btnMoKhoa);
            Controls.Add(btnDoiMatKhau);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLyTaiKhoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tài Khoản";
            Load += QuanLyTaiKhoan_Load;
            ((ISupportInitialize)dgvTaiKhoan).EndInit();
            grpInfo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}