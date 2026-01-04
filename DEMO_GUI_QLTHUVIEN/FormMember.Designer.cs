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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTitle = new Label();
            dgvMembers = new DataGridView();
            grpInfo = new GroupBox();
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
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblPhoneNumber = new Label();
            txtPhoneNumber = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblNgayDangKy = new Label();
            dtpNgayDangKy = new DateTimePicker();
            lblNgayHetHan = new Label();
            dtpNgayHetHan = new DateTimePicker();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            lblLoiHoTen = new Label();
            lblLoiEmail = new Label();
            lblLoiDiaChi = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLuu = new Button();
            btnHuy = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(480, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(373, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 QUẢN LÝ ĐỘC GIẢ";
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AllowUserToResizeColumns = false;
            dgvMembers.AllowUserToResizeRows = false;
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
            dgvMembers.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Location = new Point(29, 74);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.RowTemplate.Height = 35;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(1304, 320);
            dgvMembers.TabIndex = 1;
            dgvMembers.CellContentClick += dgvMembers_CellContentClick;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblMemberId);
            grpInfo.Controls.Add(txtMemberId);
            grpInfo.Controls.Add(lblFullName);
            grpInfo.Controls.Add(txtFullName);
            grpInfo.Controls.Add(lblNgaySinh);
            grpInfo.Controls.Add(dtpNgaySinh);
            grpInfo.Controls.Add(lblGioiTinh);
            grpInfo.Controls.Add(cboGioiTinh);
            grpInfo.Controls.Add(lblCMND);
            grpInfo.Controls.Add(txtCMND);
            grpInfo.Controls.Add(lblDiaChi);
            grpInfo.Controls.Add(txtDiaChi);
            grpInfo.Controls.Add(lblPhoneNumber);
            grpInfo.Controls.Add(txtPhoneNumber);
            grpInfo.Controls.Add(lblEmail);
            grpInfo.Controls.Add(txtEmail);
            grpInfo.Controls.Add(lblNgayDangKy);
            grpInfo.Controls.Add(dtpNgayDangKy);
            grpInfo.Controls.Add(lblNgayHetHan);
            grpInfo.Controls.Add(dtpNgayHetHan);
            grpInfo.Controls.Add(lblTrangThai);
            grpInfo.Controls.Add(cboTrangThai);
            grpInfo.Controls.Add(lblGhiChu);
            grpInfo.Controls.Add(txtGhiChu);
            grpInfo.Controls.Add(lblLoiHoTen);
            grpInfo.Controls.Add(lblLoiEmail);
            grpInfo.Controls.Add(lblLoiDiaChi);
            grpInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            grpInfo.Location = new Point(29, 410);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(1304, 260);
            grpInfo.TabIndex = 2;
            grpInfo.TabStop = false;
            grpInfo.Text = "� Thông Tin Độc Giả";
            // 
            // lblMemberId
            // 
            lblMemberId.Font = new Font("Segoe UI", 10F);
            lblMemberId.ForeColor = Color.FromArgb(66, 66, 66);
            lblMemberId.Location = new Point(30, 35);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(60, 25);
            lblMemberId.TabIndex = 0;
            lblMemberId.Text = "Mã ĐG:";
            // 
            // txtMemberId
            // 
            txtMemberId.BackColor = Color.FromArgb(240, 240, 240);
            txtMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtMemberId.Font = new Font("Segoe UI", 10F);
            txtMemberId.Location = new Point(95, 32);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(100, 30);
            txtMemberId.TabIndex = 1;
            // 
            // lblFullName
            // 
            lblFullName.Font = new Font("Segoe UI", 10F);
            lblFullName.ForeColor = Color.FromArgb(66, 66, 66);
            lblFullName.Location = new Point(210, 35);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(70, 25);
            lblFullName.TabIndex = 2;
            lblFullName.Text = "Họ tên: *";
            // 
            // txtFullName
            // 
            txtFullName.BorderStyle = BorderStyle.FixedSingle;
            txtFullName.Font = new Font("Segoe UI", 10F);
            txtFullName.Location = new Point(285, 32);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 30);
            txtFullName.TabIndex = 3;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Segoe UI", 10F);
            lblNgaySinh.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgaySinh.Location = new Point(650, 35);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(80, 25);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(735, 32);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(130, 30);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Font = new Font("Segoe UI", 10F);
            lblGioiTinh.ForeColor = Color.FromArgb(66, 66, 66);
            lblGioiTinh.Location = new Point(880, 35);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(70, 25);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 10F);
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(955, 32);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(270, 31);
            cboGioiTinh.TabIndex = 7;
            // 
            // lblCMND
            // 
            lblCMND.Font = new Font("Segoe UI", 10F);
            lblCMND.ForeColor = Color.FromArgb(66, 66, 66);
            lblCMND.Location = new Point(30, 75);
            lblCMND.Name = "lblCMND";
            lblCMND.Size = new Size(60, 25);
            lblCMND.TabIndex = 8;
            lblCMND.Text = "CMND:";
            // 
            // txtCMND
            // 
            txtCMND.BorderStyle = BorderStyle.FixedSingle;
            txtCMND.Font = new Font("Segoe UI", 10F);
            txtCMND.Location = new Point(95, 72);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(200, 30);
            txtCMND.TabIndex = 9;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = Color.FromArgb(66, 66, 66);
            lblDiaChi.Location = new Point(310, 75);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(60, 25);
            lblDiaChi.TabIndex = 10;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(375, 72);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(850, 30);
            txtDiaChi.TabIndex = 11;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.Font = new Font("Segoe UI", 10F);
            lblPhoneNumber.ForeColor = Color.FromArgb(66, 66, 66);
            lblPhoneNumber.Location = new Point(30, 115);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(60, 25);
            lblPhoneNumber.TabIndex = 12;
            lblPhoneNumber.Text = "SĐT:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Font = new Font("Segoe UI", 10F);
            txtPhoneNumber.Location = new Point(95, 112);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(200, 30);
            txtPhoneNumber.TabIndex = 13;
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(66, 66, 66);
            lblEmail.Location = new Point(310, 115);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 25);
            lblEmail.TabIndex = 14;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(375, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(850, 30);
            txtEmail.TabIndex = 15;
            // 
            // lblNgayDangKy
            // 
            lblNgayDangKy.Font = new Font("Segoe UI", 10F);
            lblNgayDangKy.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgayDangKy.Location = new Point(30, 155);
            lblNgayDangKy.Name = "lblNgayDangKy";
            lblNgayDangKy.Size = new Size(60, 25);
            lblNgayDangKy.TabIndex = 16;
            lblNgayDangKy.Text = "Ngày:";
            // 
            // dtpNgayDangKy
            // 
            dtpNgayDangKy.Font = new Font("Segoe UI", 10F);
            dtpNgayDangKy.Format = DateTimePickerFormat.Short;
            dtpNgayDangKy.Location = new Point(95, 152);
            dtpNgayDangKy.Name = "dtpNgayDangKy";
            dtpNgayDangKy.Size = new Size(130, 30);
            dtpNgayDangKy.TabIndex = 17;
            // 
            // lblNgayHetHan
            // 
            lblNgayHetHan.Font = new Font("Segoe UI", 10F);
            lblNgayHetHan.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgayHetHan.Location = new Point(240, 155);
            lblNgayHetHan.Name = "lblNgayHetHan";
            lblNgayHetHan.Size = new Size(35, 25);
            lblNgayHetHan.TabIndex = 18;
            lblNgayHetHan.Text = "Hết:";
            // 
            // dtpNgayHetHan
            // 
            dtpNgayHetHan.Font = new Font("Segoe UI", 10F);
            dtpNgayHetHan.Format = DateTimePickerFormat.Short;
            dtpNgayHetHan.Location = new Point(280, 152);
            dtpNgayHetHan.Name = "dtpNgayHetHan";
            dtpNgayHetHan.Size = new Size(130, 30);
            dtpNgayHetHan.TabIndex = 19;
            dtpNgayHetHan.ValueChanged += dtpNgayHetHan_ValueChanged;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.ForeColor = Color.FromArgb(66, 66, 66);
            lblTrangThai.Location = new Point(425, 155);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(55, 25);
            lblTrangThai.TabIndex = 20;
            lblTrangThai.Text = "Trạng:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 10F);
            cboTrangThai.Items.AddRange(new object[] { "Hoạt động", "Hết hạn", "Bị khóa" });
            cboTrangThai.Location = new Point(485, 152);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(130, 31);
            cboTrangThai.TabIndex = 21;
            // 
            // lblGhiChu
            // 
            lblGhiChu.Font = new Font("Segoe UI", 10F);
            lblGhiChu.ForeColor = Color.FromArgb(66, 66, 66);
            lblGhiChu.Location = new Point(630, 155);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(35, 25);
            lblGhiChu.TabIndex = 22;
            lblGhiChu.Text = "Ghi:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.BorderStyle = BorderStyle.FixedSingle;
            txtGhiChu.Font = new Font("Segoe UI", 10F);
            txtGhiChu.Location = new Point(670, 152);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(555, 30);
            txtGhiChu.TabIndex = 23;
            // 
            // lblLoiHoTen
            // 
            lblLoiHoTen.AutoSize = true;
            lblLoiHoTen.Font = new Font("Segoe UI", 8F);
            lblLoiHoTen.ForeColor = Color.Red;
            lblLoiHoTen.Location = new Point(300, 195);
            lblLoiHoTen.Name = "lblLoiHoTen";
            lblLoiHoTen.Size = new Size(0, 19);
            lblLoiHoTen.TabIndex = 24;
            // 
            // lblLoiEmail
            // 
            lblLoiEmail.AutoSize = true;
            lblLoiEmail.Font = new Font("Segoe UI", 8F);
            lblLoiEmail.ForeColor = Color.Red;
            lblLoiEmail.Location = new Point(390, 195);
            lblLoiEmail.Name = "lblLoiEmail";
            lblLoiEmail.Size = new Size(0, 19);
            lblLoiEmail.TabIndex = 25;
            // 
            // lblLoiDiaChi
            // 
            lblLoiDiaChi.AutoSize = true;
            lblLoiDiaChi.Font = new Font("Segoe UI", 8F);
            lblLoiDiaChi.ForeColor = Color.Red;
            lblLoiDiaChi.Location = new Point(600, 195);
            lblLoiDiaChi.Name = "lblLoiDiaChi";
            lblLoiDiaChi.Size = new Size(0, 19);
            lblLoiDiaChi.TabIndex = 26;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(76, 175, 80);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(29, 686);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "+ Thêm";
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
            btnSua.Location = new Point(149, 686);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 4;
            btnSua.Text = "✎ Sửa";
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
            btnXoa.Location = new Point(269, 686);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "🗑 Xóa";
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
            btnLuu.Location = new Point(389, 686);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(110, 40);
            btnLuu.TabIndex = 6;
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
            btnHuy.Location = new Point(509, 686);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(110, 40);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "🚫 Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(96, 125, 139);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(1195, 683);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(138, 40);
            btnTimKiem.TabIndex = 9;
            btnTimKiem.Text = "� Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.BorderStyle = BorderStyle.FixedSingle;
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(959, 690);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo tên, SĐT...";
            txtTimKiem.Size = new Size(230, 30);
            txtTimKiem.TabIndex = 8;
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = SystemColors.ButtonHighlight;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            btnClose.ImageSize = new Size(40, 40);
            btnClose.Location = new Point(1354, 12);
            btnClose.Name = "btnClose";
            btnClose.PressedColor = SystemColors.ButtonFace;
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(44, 36);
            btnClose.TabIndex = 10;
            btnClose.Click += btnClose_Click;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1426, 863);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(dgvMembers);
            Controls.Add(grpInfo);
            Controls.Add(btnThem);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnLuu);
            Controls.Add(btnHuy);
            Controls.Add(txtTimKiem);
            Controls.Add(btnTimKiem);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Độc Giả";
            Load += FormMember_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        // Title
        private System.Windows.Forms.Label lblTitle;

        // DataGridView
        private System.Windows.Forms.DataGridView dgvMembers;

        // GroupBox
        private System.Windows.Forms.GroupBox grpInfo;

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

        // Validation Labels
        private System.Windows.Forms.Label lblLoiHoTen, lblLoiEmail, lblLoiDiaChi;

        // Buttons
        private System.Windows.Forms.Button btnThem, btnSua, btnXoa, btnLuu, btnHuy, btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        
        // Close button
        private Guna.UI2.WinForms.Guna2Button btnClose;
    }
}