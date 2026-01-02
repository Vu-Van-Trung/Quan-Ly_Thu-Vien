using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class FormStaff
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvStaff = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colHoTen = new DataGridViewTextBoxColumn();
            colChucVu = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colNgayVao = new DataGridViewTextBoxColumn();
            colTrangThai = new DataGridViewTextBoxColumn();
            grpPersonal = new GroupBox();
            lblStaffId = new Label();
            txtStaffId = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblGioiTinh = new Label();
            cboGioiTinh = new ComboBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            grpWork = new GroupBox();
            lblChucVu = new Label();
            cboChucVu = new ComboBox();
            lblNgayVaoLam = new Label();
            dtpNgayVaoLam = new DateTimePicker();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnRefresh = new Button();
            lblTitle = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvStaff).BeginInit();
            grpPersonal.SuspendLayout();
            grpWork.SuspendLayout();
            SuspendLayout();
            // 
            // dgvStaff
            // 
            dgvStaff.AllowUserToAddRows = false;
            dgvStaff.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(245, 245, 245);
            dgvStaff.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStaff.BackgroundColor = Color.White;
            dgvStaff.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvStaff.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvStaff.ColumnHeadersHeight = 40;
            dgvStaff.Columns.AddRange(new DataGridViewColumn[] { colId, colHoTen, colChucVu, colNgaySinh, colGioiTinh, colSDT, colEmail, colNgayVao, colTrangThai });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvStaff.DefaultCellStyle = dataGridViewCellStyle6;
            dgvStaff.EnableHeadersVisualStyles = false;
            dgvStaff.Location = new Point(71, 78);
            dgvStaff.MultiSelect = false;
            dgvStaff.Name = "dgvStaff";
            dgvStaff.ReadOnly = true;
            dgvStaff.RowHeadersWidth = 51;
            dgvStaff.RowTemplate.Height = 35;
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.Size = new Size(1160, 320);
            dgvStaff.TabIndex = 0;
            dgvStaff.SelectionChanged += DgvStaff_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "StaffId";
            colId.HeaderText = "Mã NV";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colHoTen
            // 
            colHoTen.DataPropertyName = "HoTen";
            colHoTen.HeaderText = "Họ Tên";
            colHoTen.MinimumWidth = 6;
            colHoTen.Name = "colHoTen";
            colHoTen.ReadOnly = true;
            // 
            // colChucVu
            // 
            colChucVu.DataPropertyName = "ChucVu";
            colChucVu.HeaderText = "Chức Vụ";
            colChucVu.MinimumWidth = 6;
            colChucVu.Name = "colChucVu";
            colChucVu.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            colNgaySinh.HeaderText = "Ngày Sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới Tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SoDienThoai";
            colSDT.HeaderText = "Số ĐT";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colNgayVao
            // 
            colNgayVao.DataPropertyName = "NgayVaoLam";
            colNgayVao.HeaderText = "Ngày Vào";
            colNgayVao.MinimumWidth = 6;
            colNgayVao.Name = "colNgayVao";
            colNgayVao.ReadOnly = true;
            // 
            // colTrangThai
            // 
            colTrangThai.DataPropertyName = "TrangThai";
            colTrangThai.HeaderText = "Trạng Thái";
            colTrangThai.MinimumWidth = 6;
            colTrangThai.Name = "colTrangThai";
            colTrangThai.ReadOnly = true;
            // 
            // grpPersonal
            // 
            grpPersonal.Controls.Add(lblStaffId);
            grpPersonal.Controls.Add(txtStaffId);
            grpPersonal.Controls.Add(lblHoTen);
            grpPersonal.Controls.Add(txtHoTen);
            grpPersonal.Controls.Add(lblNgaySinh);
            grpPersonal.Controls.Add(dtpNgaySinh);
            grpPersonal.Controls.Add(lblGioiTinh);
            grpPersonal.Controls.Add(cboGioiTinh);
            grpPersonal.Controls.Add(lblDiaChi);
            grpPersonal.Controls.Add(txtDiaChi);
            grpPersonal.Controls.Add(lblSoDienThoai);
            grpPersonal.Controls.Add(txtSoDienThoai);
            grpPersonal.Controls.Add(lblEmail);
            grpPersonal.Controls.Add(txtEmail);
            grpPersonal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpPersonal.ForeColor = Color.FromArgb(33, 150, 243);
            grpPersonal.Location = new Point(66, 404);
            grpPersonal.Name = "grpPersonal";
            grpPersonal.Size = new Size(570, 240);
            grpPersonal.TabIndex = 1;
            grpPersonal.TabStop = false;
            grpPersonal.Text = "📋 Thông Tin Cá Nhân";
            // 
            // lblStaffId
            // 
            lblStaffId.Font = new Font("Segoe UI", 10F);
            lblStaffId.ForeColor = Color.FromArgb(66, 66, 66);
            lblStaffId.Location = new Point(20, 35);
            lblStaffId.Name = "lblStaffId";
            lblStaffId.Size = new Size(120, 25);
            lblStaffId.TabIndex = 0;
            lblStaffId.Text = "Mã NV:";
            // 
            // txtStaffId
            // 
            txtStaffId.BackColor = Color.FromArgb(240, 240, 240);
            txtStaffId.BorderStyle = BorderStyle.FixedSingle;
            txtStaffId.Font = new Font("Segoe UI", 10F);
            txtStaffId.Location = new Point(145, 35);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.ReadOnly = true;
            txtStaffId.Size = new Size(400, 30);
            txtStaffId.TabIndex = 1;
            txtStaffId.Text = "1";
            // 
            // lblHoTen
            // 
            lblHoTen.Font = new Font("Segoe UI", 10F);
            lblHoTen.ForeColor = Color.FromArgb(66, 66, 66);
            lblHoTen.Location = new Point(20, 77);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(120, 25);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên: *";
            // 
            // txtHoTen
            // 
            txtHoTen.BorderStyle = BorderStyle.FixedSingle;
            txtHoTen.Font = new Font("Segoe UI", 10F);
            txtHoTen.Location = new Point(145, 77);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(400, 30);
            txtHoTen.TabIndex = 3;
            txtHoTen.Text = "Nguyễn Văn A";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Segoe UI", 10F);
            lblNgaySinh.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgaySinh.Location = new Point(20, 119);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(120, 25);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(145, 119);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(180, 30);
            dtpNgaySinh.TabIndex = 5;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.Font = new Font("Segoe UI", 10F);
            lblGioiTinh.ForeColor = Color.FromArgb(66, 66, 66);
            lblGioiTinh.Location = new Point(345, 119);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(80, 25);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // cboGioiTinh
            // 
            cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            cboGioiTinh.Font = new Font("Segoe UI", 10F);
            cboGioiTinh.FormattingEnabled = true;
            cboGioiTinh.Items.AddRange(new object[] { "Nam", "Nữ", "Khác" });
            cboGioiTinh.Location = new Point(425, 119);
            cboGioiTinh.Name = "cboGioiTinh";
            cboGioiTinh.Size = new Size(120, 31);
            cboGioiTinh.TabIndex = 7;
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = Color.FromArgb(66, 66, 66);
            lblDiaChi.Location = new Point(20, 161);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(120, 25);
            lblDiaChi.TabIndex = 8;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(145, 161);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(400, 30);
            txtDiaChi.TabIndex = 9;
            txtDiaChi.Text = "Hà Nội";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            lblSoDienThoai.ForeColor = Color.FromArgb(66, 66, 66);
            lblSoDienThoai.Location = new Point(20, 203);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(120, 25);
            lblSoDienThoai.TabIndex = 10;
            lblSoDienThoai.Text = "Số ĐT:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new Point(145, 203);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(160, 30);
            txtSoDienThoai.TabIndex = 11;
            txtSoDienThoai.Text = "0912345678";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(66, 66, 66);
            lblEmail.Location = new Point(315, 203);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(50, 25);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(365, 203);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 30);
            txtEmail.TabIndex = 13;
            txtEmail.Text = "nhanvien@example.com";
            // lblThongBao
            // 
            lblThongBao = new Label();
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Segoe UI", 8F);
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Location = new Point(145, 160); // Below cboTrangThai in grpWork
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 19);
            lblThongBao.TabIndex = 14;
            // 

            // 
            // grpWork
            // 
            grpWork.Controls.Add(lblChucVu);
            grpWork.Controls.Add(cboChucVu);
            grpWork.Controls.Add(lblNgayVaoLam);
            grpWork.Controls.Add(dtpNgayVaoLam);
            grpWork.Controls.Add(lblTrangThai);
            grpWork.Controls.Add(cboTrangThai);
            grpWork.Controls.Add(lblThongBao);
            grpWork.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpWork.ForeColor = Color.FromArgb(33, 150, 243);
            grpWork.Location = new Point(656, 404);
            grpWork.Name = "grpWork";
            grpWork.Size = new Size(570, 240);
            grpWork.TabIndex = 2;
            grpWork.TabStop = false;
            grpWork.Text = "💼 Thông Tin Công Việc";
            // 
            // lblChucVu
            // 
            lblChucVu.Font = new Font("Segoe UI", 10F);
            lblChucVu.ForeColor = Color.FromArgb(66, 66, 66);
            lblChucVu.Location = new Point(20, 35);
            lblChucVu.Name = "lblChucVu";
            lblChucVu.Size = new Size(120, 25);
            lblChucVu.TabIndex = 0;
            lblChucVu.Text = "Chức vụ: *";
            // 
            // cboChucVu
            // 
            cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            cboChucVu.Font = new Font("Segoe UI", 10F);
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(145, 35);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(400, 31);
            cboChucVu.TabIndex = 1;
            // 
            // lblNgayVaoLam
            // 
            lblNgayVaoLam.Font = new Font("Segoe UI", 10F);
            lblNgayVaoLam.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgayVaoLam.Location = new Point(20, 77);
            lblNgayVaoLam.Name = "lblNgayVaoLam";
            lblNgayVaoLam.Size = new Size(120, 25);
            lblNgayVaoLam.TabIndex = 2;
            lblNgayVaoLam.Text = "Ngày vào làm:";
            // 
            // dtpNgayVaoLam
            // 
            dtpNgayVaoLam.Font = new Font("Segoe UI", 10F);
            dtpNgayVaoLam.Format = DateTimePickerFormat.Short;
            dtpNgayVaoLam.Location = new Point(145, 77);
            dtpNgayVaoLam.Name = "dtpNgayVaoLam";
            dtpNgayVaoLam.Size = new Size(180, 30);
            dtpNgayVaoLam.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Font = new Font("Segoe UI", 10F);
            lblTrangThai.ForeColor = Color.FromArgb(66, 66, 66);
            lblTrangThai.Location = new Point(20, 119);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(120, 25);
            lblTrangThai.TabIndex = 4;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 10F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Đang làm việc", "Nghỉ việc", "Tạm nghỉ" });
            cboTrangThai.Location = new Point(145, 119);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(200, 31);
            cboTrangThai.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(68, 665);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "➕ Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(188, 665);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 40);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "✏️ Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(308, 665);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "🗑️ Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(428, 665);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "💾 Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(158, 158, 158);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(548, 665);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "✖️ Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(96, 125, 139);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(668, 665);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 40);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "🔄 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(448, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(425, 46);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "👥 QUẢN LÝ NHÂN VIÊN";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges3;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ButtonHighlight;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(1254, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Button1.Size = new Size(44, 36);
            guna2Button1.TabIndex = 10;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FormStaff
            // 
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1310, 743);
            Controls.Add(guna2Button1);
            Controls.Add(lblTitle);
            Controls.Add(dgvStaff);
            Controls.Add(grpPersonal);
            Controls.Add(grpWork);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresh);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "                                                                                                                                                                          ";
            ((System.ComponentModel.ISupportInitialize)dgvStaff).EndInit();
            grpPersonal.ResumeLayout(false);
            grpPersonal.PerformLayout();
            grpWork.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayVao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrangThai;
        private System.Windows.Forms.GroupBox grpPersonal;
        private System.Windows.Forms.GroupBox grpWork;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgayVaoLam;
        private System.Windows.Forms.Label lblStaffId;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNgayVaoLam;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        
        // Validation Labels
        private System.Windows.Forms.Label lblThongBao;
    }
}