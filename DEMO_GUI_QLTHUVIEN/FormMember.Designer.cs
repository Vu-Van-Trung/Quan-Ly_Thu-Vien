// FormMember.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoAnDemoUI
{
    partial class FormMember
    {
        private IContainer components = null;
        private Guna2HtmlLabel lblTitle;
        private Guna2GroupBox grpPersonal;
        private Guna2TextBox txtMemberId;
        private Guna2TextBox txtFullName;
        private Guna2DateTimePicker dtpNgaySinh;
        private Guna2ComboBox cboGioiTinh;
        private Guna2TextBox txtCMND;
        private Guna2GroupBox grpContact;
        private Guna2TextBox txtDiaChi;
        private Guna2TextBox txtPhoneNumber;
        private Guna2TextBox txtEmail;
        private Guna2GroupBox grpMembership;
        private Guna2DateTimePicker dtpNgayDangKy;
        private Guna2DateTimePicker dtpNgayHetHan;
        private Guna2ComboBox cboTrangThai;
        private Guna2TextBox txtGhiChu;
        private Guna2GroupBox grpDanhSach;
        private Guna2DataGridView dgvMembers;
        private Guna2GroupBox grpChucNang;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnLuu;
        private Guna2Button btnHuy;
        private Guna2TextBox txtTimKiem;
        private Guna2Button btnTimKiem;
        private Guna2Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new Container();
            // Title
            this.lblTitle = new Guna2HtmlLabel();
            this.lblTitle.AutoSize = false;
            this.lblTitle.BackColor = Color.Transparent;
            this.lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            this.lblTitle.Text = "👥 QUẢN LÝ ĐỘC GIẢ";
            this.lblTitle.TextAlignment = ContentAlignment.MiddleCenter;
            this.lblTitle.Size = new Size(400, 50);
            this.lblTitle.Location = new Point(550, 10);

            // Personal Group
            this.grpPersonal = new Guna2GroupBox();
            this.grpPersonal.Text = "👤 Thông Tin Cá Nhân";
            this.grpPersonal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpPersonal.ForeColor = Color.FromArgb(33, 150, 243);
            this.grpPersonal.Size = new Size(460, 210);
            this.grpPersonal.Location = new Point(15, 70);

            // Member ID (read‑only)
            this.txtMemberId = new Guna2TextBox();
            this.txtMemberId.PlaceholderText = "Mã ĐG";
            this.txtMemberId.ReadOnly = true;
            this.txtMemberId.Size = new Size(120, 36);
            this.txtMemberId.Location = new Point(15, 40);

            // Full Name
            this.txtFullName = new Guna2TextBox();
            this.txtFullName.PlaceholderText = "Họ tên *";
            this.txtFullName.Size = new Size(200, 36);
            this.txtFullName.Location = new Point(150, 40);

            // Ngày sinh
            this.dtpNgaySinh = new Guna2DateTimePicker();
            this.dtpNgaySinh.Format = DateTimePickerFormat.Short;
            this.dtpNgaySinh.Size = new Size(150, 36);
            this.dtpNgaySinh.Location = new Point(15, 90);

            // Giới tính
            this.cboGioiTinh = new Guna2ComboBox();
            this.cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            this.cboGioiTinh.Size = new Size(120, 36);
            this.cboGioiTinh.Location = new Point(180, 90);

            // CMND
            this.txtCMND = new Guna2TextBox();
            this.txtCMND.PlaceholderText = "CMND";
            this.txtCMND.Size = new Size(260, 36);
            this.txtCMND.Location = new Point(15, 140);

            // Add controls to Personal group
            this.grpPersonal.Controls.Add(this.txtMemberId);
            this.grpPersonal.Controls.Add(this.txtFullName);
            this.grpPersonal.Controls.Add(this.dtpNgaySinh);
            this.grpPersonal.Controls.Add(this.cboGioiTinh);
            this.grpPersonal.Controls.Add(this.txtCMND);

            // Contact Group
            this.grpContact = new Guna2GroupBox();
            this.grpContact.Text = "📞 Thông Tin Liên Hệ";
            this.grpContact.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpContact.ForeColor = Color.FromArgb(33, 150, 243);
            this.grpContact.Size = new Size(380, 210);
            this.grpContact.Location = new Point(490, 70);

            this.txtDiaChi = new Guna2TextBox();
            this.txtDiaChi.PlaceholderText = "Địa chỉ";
            this.txtDiaChi.Size = new Size(340, 36);
            this.txtDiaChi.Location = new Point(20, 40);

            this.txtPhoneNumber = new Guna2TextBox();
            this.txtPhoneNumber.PlaceholderText = "SĐT";
            this.txtPhoneNumber.Size = new Size(340, 36);
            this.txtPhoneNumber.Location = new Point(20, 90);

            this.txtEmail = new Guna2TextBox();
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new Size(340, 36);
            this.txtEmail.Location = new Point(20, 140);

            this.grpContact.Controls.Add(this.txtDiaChi);
            this.grpContact.Controls.Add(this.txtPhoneNumber);
            this.grpContact.Controls.Add(this.txtEmail);

            // Membership Group
            this.grpMembership = new Guna2GroupBox();
            this.grpMembership.Text = "📋 Thông Tin Thẻ";
            this.grpMembership.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpMembership.ForeColor = Color.FromArgb(33, 150, 243);
            this.grpMembership.Size = new Size(420, 210);
            this.grpMembership.Location = new Point(890, 70);

            this.dtpNgayDangKy = new Guna2DateTimePicker();
            this.dtpNgayDangKy.Format = DateTimePickerFormat.Short;
            this.dtpNgayDangKy.Size = new Size(150, 36);
            this.dtpNgayDangKy.Location = new Point(20, 40);

            this.dtpNgayHetHan = new Guna2DateTimePicker();
            this.dtpNgayHetHan.Format = DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Size = new Size(150, 36);
            this.dtpNgayHetHan.Location = new Point(200, 40);

            this.cboTrangThai = new Guna2ComboBox();
            this.cboTrangThai.Items.AddRange(new object[] { "Hoạt động", "Hết hạn", "Bị khóa" });
            this.cboTrangThai.Size = new Size(180, 36);
            this.cboTrangThai.Location = new Point(20, 90);

            this.txtGhiChu = new Guna2TextBox();
            this.txtGhiChu.PlaceholderText = "Ghi chú";
            this.txtGhiChu.Size = new Size(360, 36);
            this.txtGhiChu.Location = new Point(20, 140);

            this.grpMembership.Controls.Add(this.dtpNgayDangKy);
            this.grpMembership.Controls.Add(this.dtpNgayHetHan);
            this.grpMembership.Controls.Add(this.cboTrangThai);
            this.grpMembership.Controls.Add(this.txtGhiChu);

            // Data Grid Group
            this.grpDanhSach = new Guna2GroupBox();
            this.grpDanhSach.Text = "📊 Danh Sách Độc Giả";
            this.grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpDanhSach.ForeColor = Color.FromArgb(33, 150, 243);
            this.grpDanhSach.Size = new Size(1080, 380);
            this.grpDanhSach.Location = new Point(15, 300);

            this.dgvMembers = new Guna2DataGridView();
            this.dgvMembers.Dock = DockStyle.Fill;
            this.dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvMembers.ColumnHeadersHeight = 35;
            this.dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvMembers.RowHeadersVisible = false;
            this.grpDanhSach.Controls.Add(this.dgvMembers);

            // Function Buttons Group
            this.grpChucNang = new Guna2GroupBox();
            this.grpChucNang.Text = "⚙️ Chức Năng";
            this.grpChucNang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.grpChucNang.ForeColor = Color.FromArgb(33, 150, 243);
            this.grpChucNang.Size = new Size(200, 380);
            this.grpChucNang.Location = new Point(1110, 300);

            this.btnThem = new Guna2Button();
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.FillColor = Color.FromArgb(76, 175, 80);
            this.btnThem.ForeColor = Color.White;
            this.btnThem.BorderRadius = 12;
            this.btnThem.Size = new Size(165, 45);
            this.btnThem.Location = new Point(15, 30);

            this.btnSua = new Guna2Button();
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.FillColor = Color.FromArgb(33, 150, 243);
            this.btnSua.ForeColor = Color.White;
            this.btnSua.BorderRadius = 12;
            this.btnSua.Size = new Size(165, 45);
            this.btnSua.Location = new Point(15, 90);

            this.btnXoa = new Guna2Button();
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.FillColor = Color.FromArgb(244, 67, 54);
            this.btnXoa.ForeColor = Color.White;
            this.btnXoa.BorderRadius = 12;
            this.btnXoa.Size = new Size(165, 45);
            this.btnXoa.Location = new Point(15, 150);

            this.btnLuu = new Guna2Button();
            this.btnLuu.Text = "💾 Lưu";
            this.btnLuu.FillColor = Color.FromArgb(0, 150, 136);
            this.btnLuu.ForeColor = Color.White;
            this.btnLuu.BorderRadius = 12;
            this.btnLuu.Size = new Size(165, 45);
            this.btnLuu.Location = new Point(15, 210);
            this.btnLuu.Enabled = false;

            this.btnHuy = new Guna2Button();
            this.btnHuy.Text = "✖️ Hủy";
            this.btnHuy.FillColor = Color.FromArgb(158, 158, 158);
            this.btnHuy.ForeColor = Color.White;
            this.btnHuy.BorderRadius = 12;
            this.btnHuy.Size = new Size(165, 45);
            this.btnHuy.Location = new Point(15, 270);
            this.btnHuy.Enabled = false;

            this.txtTimKiem = new Guna2TextBox();
            this.txtTimKiem.PlaceholderText = "Tìm theo tên, SĐT...";
            this.txtTimKiem.Size = new Size(165, 36);
            this.txtTimKiem.Location = new Point(15, 330);

            this.btnTimKiem = new Guna2Button();
            this.btnTimKiem.Text = "🔍 Tìm Kiếm";
            this.btnTimKiem.FillColor = Color.FromArgb(96, 125, 139);
            this.btnTimKiem.ForeColor = Color.White;
            this.btnTimKiem.BorderRadius = 12;
            this.btnTimKiem.Size = new Size(165, 36);
            this.btnTimKiem.Location = new Point(15, 380);

            this.grpChucNang.Controls.Add(this.btnThem);
            this.grpChucNang.Controls.Add(this.btnSua);
            this.grpChucNang.Controls.Add(this.btnXoa);
            this.grpChucNang.Controls.Add(this.btnLuu);
            this.grpChucNang.Controls.Add(this.btnHuy);
            this.grpChucNang.Controls.Add(this.txtTimKiem);
            this.grpChucNang.Controls.Add(this.btnTimKiem);

            // Close button (top‑right)
            this.btnClose = new Guna2Button();
            this.btnClose.Text = "X";
            this.btnClose.FillColor = Color.FromArgb(231, 76, 60);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.BorderRadius = 12;
            this.btnClose.Size = new Size(30, 30);
            this.btnClose.Location = new Point(1380, 10);

            // Form
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.ClientSize = new Size(1440, 720);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpContact);
            this.Controls.Add(this.grpMembership);
            this.Controls.Add(this.grpDanhSach);
            this.Controls.Add(this.grpChucNang);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.Load += new EventHandler(this.FormMember_Load);
        }
    }
}
