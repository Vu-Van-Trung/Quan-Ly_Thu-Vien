using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class FormMember
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            grpPersonal = new GroupBox();
            lblMemberId = new Label();
            txtMemberId = new TextBox();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblCMND = new Label();
            txtCMND = new TextBox();
            grpContact = new GroupBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            grpMembership = new GroupBox();
            lblNgayDangKy = new Label();
            dtpNgayDangKy = new DateTimePicker();
            lblNgayHetHan = new Label();
            dtpNgayHetHan = new DateTimePicker();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            grpDanhSach = new GroupBox();
            dgvMembers = new DataGridView();
            grpChucNang = new GroupBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            grpPersonal.SuspendLayout();
            grpContact.SuspendLayout();
            grpMembership.SuspendLayout();
            grpDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            grpChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(550, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(373, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 QUẢN LÝ ĐỘC GIẢ";
            // 
            // grpPersonal
            // 
            grpPersonal.Controls.Add(lblMemberId);
            grpPersonal.Controls.Add(txtMemberId);
            grpPersonal.Controls.Add(lblFullName);
            grpPersonal.Controls.Add(txtFullName);
            grpPersonal.Controls.Add(lblNgaySinh);
            grpPersonal.Controls.Add(dtpNgaySinh);
            grpPersonal.Controls.Add(lblGioiTinh);
            grpPersonal.Controls.Add(cboGioiTinh);
            grpPersonal.Controls.Add(lblCMND);
            grpPersonal.Controls.Add(txtCMND);
            grpPersonal.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPersonal.ForeColor = Color.FromArgb(33, 150, 243);
            grpPersonal.Location = new Point(15, 60);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Size = new Size(450, 170);
            grpPersonal.TabIndex = 1;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "👤 Thông Tin Cá Nhân";
            // 
            // lblMemberId
            // 
            lblMemberId.Font = new Font("Segoe UI", 9.5F);
            lblMemberId.ForeColor = Color.FromArgb(66, 66, 66);
            lblMemberId.Location = new Point(15, 30);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(80, 22);
            lblMemberId.TabIndex = 0;
            lblMemberId.Text = "Mã ĐG:";
            // 
            // txtMemberId
            // 
            txtMemberId.BackColor = Color.FromArgb(240, 240, 240);
            txtMemberId.Font = new Font("Segoe UI", 9.5F);
            txtMemberId.Location = new Point(100, 28);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(100, 29);
            txtMemberId.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 9.5F);
            lblFullName.ForeColor = Color.FromArgb(66, 66, 66);
            lblFullName.Location = new Point(210, 30);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(70, 22);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ tên: *";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 9.5F);
            txtFullName.Location = new Point(280, 28);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(155, 29);
            txtFullName.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Segoe UI", 9.5F);
            lblNgaySinh.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgaySinh.Location = new Point(15, 65);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(80, 22);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 9.5F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(100, 63);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(120, 29);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Font = new Font("Segoe UI", 9.5F);
            lblGioiTinh.ForeColor = Color.FromArgb(66, 66, 66);
            lblGioiTinh.Location = new Point(230, 65);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(70, 22);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 9.5F);
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(300, 63);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(135, 29);
            cboGioiTinh.TabIndex = 7;
            // 
            // lblCMND
            // 
            lblCMND.Font = new Font("Segoe UI", 9.5F);
            lblCMND.ForeColor = Color.FromArgb(66, 66, 66);
            lblCMND.Location = new Point(15, 100);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(80, 22);
            lblCMND.TabIndex = 8;
            lblCMND.Text = "CMND:";
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Segoe UI", 9.5F);
            txtCMND.Location = new Point(100, 98);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(335, 29);
            txtCMND.TabIndex = 9;
            // 
            // grpContact
            // 
            grpContact.Controls.Add(lblDiaChi);
            grpContact.Controls.Add(txtDiaChi);
            grpContact.Controls.Add(lblPhoneNumber);
            grpContact.Controls.Add(txtPhoneNumber);
            grpContact.Controls.Add(lblEmail);
            grpContact.Controls.Add(txtEmail);
            grpContact.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpContact.ForeColor = Color.FromArgb(33, 150, 243);
            grpContact.Location = new Point(480, 60);
            grpContact.Name = "grpContact";
            grpContact.Size = new Size(440, 170);
            grpContact.TabIndex = 2;
            grpContact.TabStop = false;
            grpContact.Text = "📞 Thông Tin Liên Hệ";
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 9.5F);
            lblDiaChi.ForeColor = Color.FromArgb(66, 66, 66);
            lblDiaChi.Location = new Point(15, 30);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(70, 22);
            lblDiaChi.TabIndex = 0;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 9.5F);
            txtDiaChi.Location = new Point(90, 28);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(335, 29);
            txtDiaChi.TabIndex = 1;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 9.5F);
            lblPhoneNumber.ForeColor = Color.FromArgb(66, 66, 66);
            lblPhoneNumber.Location = new Point(15, 65);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(70, 22);
            lblPhoneNumber.TabIndex = 2;
            lblPhoneNumber.Text = "SĐT:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 9.5F);
            txtPhoneNumber.Location = new Point(90, 63);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 29);
            txtPhoneNumber.TabIndex = 3;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 9.5F);
            lblEmail.ForeColor = Color.FromArgb(66, 66, 66);
            lblEmail.Location = new Point(15, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 22);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9.5F);
            txtEmail.Location = new Point(90, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 29);
            txtEmail.TabIndex = 5;
            // 
            // grpMembership
            // 
            grpMembership.Controls.Add(lblNgayDangKy);
            grpMembership.Controls.Add(dtpNgayDangKy);
            grpMembership.Controls.Add(lblNgayHetHan);
            grpMembership.Controls.Add(dtpNgayHetHan);
            grpMembership.Controls.Add(lblTrangThai);
            grpMembership.Controls.Add(cboTrangThai);
            grpMembership.Controls.Add(lblGhiChu);
            grpMembership.Controls.Add(txtGhiChu);
            grpMembership.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpMembership.ForeColor = Color.FromArgb(33, 150, 243);
            grpMembership.Location = new Point(935, 60);
            grpMembership.Name = "grpMembership";
            grpMembership.Size = new Size(420, 170);
            grpMembership.TabIndex = 3;
            grpMembership.TabStop = false;
            grpMembership.Text = "📋 Thông Tin Thẻ";
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.Font = new Font("Segoe UI", 9.5F);
            lblNgayDangKy.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgayDangKy.Location = new Point(15, 30);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(75, 22);
            lblNgayDangKy.TabIndex = 0;
            lblNgayDangKy.Text = "Ngày ĐK:";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Font = new Font("Segoe UI", 9.5F);
            dtpNgayDangKy.Format = DateTimePickerFormat.Short;
            dtpNgayDangKy.Location = new Point(95, 28);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(120, 29);
            dtpNgayDangKy.TabIndex = 1;
            // 
            // lblNgayHetHan
            // 
            lblNgayHetHan.Font = new Font("Segoe UI", 9.5F);
            lblNgayHetHan.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgayHetHan.Location = new Point(225, 30);
            lblNgayHetHan.Name = "lblNgayHetHan";
            lblNgayHetHan.Size = new Size(65, 22);
            lblNgayHetHan.TabIndex = 2;
            lblNgayHetHan.Text = "Hết hạn:";
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.Font = new Font("Segoe UI", 9.5F);
            dtpNgayHetHan.Format = DateTimePickerFormat.Short;
            dtpNgayHetHan.Location = new Point(290, 28);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(115, 29);
            dtpNgayHetHan.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 9.5F);
            lblTrangThai.ForeColor = Color.FromArgb(66, 66, 66);
            lblTrangThai.Location = new Point(15, 65);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(80, 22);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 9.5F);
            cboTrangThai.Items.AddRange(new object[] { "Hoạt động", "Hết hạn", "Bị khóa" });
            cboTrangThai.Location = new Point(95, 63);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(130, 29);
            cboTrangThai.TabIndex = 5;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Segoe UI", 9.5F);
            lblGhiChu.ForeColor = Color.FromArgb(66, 66, 66);
            lblGhiChu.Location = new Point(15, 100);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(70, 22);
            lblGhiChu.TabIndex = 6;
            lblGhiChu.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Font = new Font("Segoe UI", 9.5F);
            txtGhiChu.Location = new Point(95, 98);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(310, 29);
            txtGhiChu.TabIndex = 7;
            // 
            // grpDanhSach
            // 
            grpDanhSach.Controls.Add(dgvMembers);
            grpDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDanhSach.ForeColor = Color.FromArgb(33, 150, 243);
            grpDanhSach.Location = new Point(15, 240);
            grpDanhSach.Name = "grpDanhSach";
            grpDanhSach.Size = new Size(1135, 380);
            grpDanhSach.TabIndex = 4;
            grpDanhSach.TabStop = false;
            grpDanhSach.Text = "📊 Danh Sách Độc Giả";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvMembers.ColumnHeadersHeight = 35;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMembers.Dock = DockStyle.Fill;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Location = new Point(3, 26);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.RowTemplate.Height = 30;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1129, 351);
            dgvMembers.TabIndex = 0;
            dgvMembers.CellContentClick += dgvMembers_CellContentClick;
            // 
            // grpChucNang
            // 
            grpChucNang.Controls.Add(btnThem);
            grpChucNang.Controls.Add(btnSua);
            grpChucNang.Controls.Add(btnXoa);
            grpChucNang.Controls.Add(btnLuu);
            grpChucNang.Controls.Add(btnHuy);
            grpChucNang.Controls.Add(txtTimKiem);
            grpChucNang.Controls.Add(btnTimKiem);
            grpChucNang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpChucNang.ForeColor = Color.FromArgb(33, 150, 243);
            grpChucNang.Location = new Point(1163, 248);
            grpChucNang.Name = "grpChucNang";
            grpChucNang.Size = new Size(195, 380);
            grpChucNang.TabIndex = 5;
            grpChucNang.TabStop = false;
            grpChucNang.Text = "⚙️ Chức Năng";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(76, 175, 80);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(15, 35);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(165, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(33, 150, 243);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(15, 85);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(165, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.Cursor = Cursors.Hand;

            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(15, 135);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(165, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "🗑️ Xóa";


            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(0, 150, 136);
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.Enabled = false;
            btnLuu.FlatAppearance.BorderSize = 0;
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(15, 185);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(165, 40);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "💾 Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.FromArgb(158, 158, 158);
            btnHuy.Cursor = Cursors.Hand;
            btnHuy.Enabled = false;
            btnHuy.FlatAppearance.BorderSize = 0;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(15, 235);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(165, 40);
            btnHuy.TabIndex = 4;
            btnHuy.Text = "✖️ Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 9.5F);
            txtTimKiem.Location = new Point(15, 290);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo tên, SĐT...";
            txtTimKiem.Size = new Size(165, 29);
            txtTimKiem.TabIndex = 5;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(96, 125, 139);
            btnTimKiem.Cursor = Cursors.Hand;

            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(15, 325);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(165, 35);
            btnTimKiem.TabIndex = 6;
            btnTimKiem.Text = "🔍 Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1370, 640);
            Controls.Add(lblTitle);
            Controls.Add(grpPersonal);
            Controls.Add(grpContact);
            Controls.Add(grpMembership);
            Controls.Add(grpDanhSach);
            Controls.Add(grpChucNang);
            Font = new Font("Segoe UI", 9F);
            Name = "FormMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Độc Giả";
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpContact.ResumeLayout(false);
            grpContact.PerformLayout();
            grpMembership.ResumeLayout(false);
            grpMembership.PerformLayout();
            grpDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            grpChucNang.ResumeLayout(false);
            grpChucNang.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Title
        private System.Windows.Forms.Label lblTitle;


        // GroupBoxes
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.GroupBox grpContact;
        private System.Windows.Forms.GroupBox grpMembership;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.GroupBox grpChucNang;

        // Personal Info
        private System.Windows.Forms.Label lblMemberId, lblFullName, lblNgaySinh, lblGioiTinh, lblCMND;
        private System.Windows.Forms.TextBox txtMemberId, txtFullName, txtCMND;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cboGioiTinh;

        // Contact Info
        private System.Windows.Forms.Label lblDiaChi, lblPhoneNumber, lblEmail;
        private System.Windows.Forms.TextBox txtDiaChi, txtPhoneNumber, txtEmail;

        // Membership Info
        private System.Windows.Forms.Label lblNgayDangKy, lblNgayHetHan, lblTrangThai, lblGhiChu;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy, dtpNgayHetHan;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.TextBox txtGhiChu;

        // DataGridView
        private System.Windows.Forms.DataGridView dgvMembers;

        // Buttons
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}