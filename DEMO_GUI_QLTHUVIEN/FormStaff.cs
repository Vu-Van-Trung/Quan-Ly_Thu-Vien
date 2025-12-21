#nullable disable
using LibraryManagement.Data;
using LibraryManagement.Models;
using LibraryManagement.Security;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    /// <summary>
    /// Form quản lý Nhân viên - Enhanced UI
    /// </summary>
    public partial class FormStaff : Form
    {
        private LibraryContext db;
        private bool isEditing = false;

        public FormStaff()
        {
            InitializeComponent();
            this.Load += FormStaff_Load;
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadChucVu();
            LoadData();
            SetControlState(false);
        }

        private void InitializeComponent()
        {
            // Initialize controls
            this.dgvStaff = new DataGridView();
            this.grpPersonal = new GroupBox();
            this.grpWork = new GroupBox();
            this.txtStaffId = new TextBox();
            this.txtHoTen = new TextBox();
            this.cboChucVu = new ComboBox();
            this.dtpNgaySinh = new DateTimePicker();
            this.cboGioiTinh = new ComboBox();
            this.txtDiaChi = new TextBox();
            this.txtSoDienThoai = new TextBox();
            this.txtEmail = new TextBox();
            this.dtpNgayVaoLam = new DateTimePicker();
            this.cboTrangThai = new ComboBox();
            
            this.lblStaffId = new Label();
            this.lblHoTen = new Label();
            this.lblChucVu = new Label();
            this.lblNgaySinh = new Label();
            this.lblGioiTinh = new Label();
            this.lblDiaChi = new Label();
            this.lblSoDienThoai = new Label();
            this.lblEmail = new Label();
            this.lblNgayVaoLam = new Label();
            this.lblTrangThai = new Label();
            
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.btnRefresh = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.grpPersonal.SuspendLayout();
            this.grpWork.SuspendLayout();
            this.SuspendLayout();

            // ========== DATAGRIDVIEW ==========
            this.dgvStaff.Location = new Point(20, 20);
            this.dgvStaff.Size = new Size(1160, 320);
            this.dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.MultiSelect = false;
            this.dgvStaff.ReadOnly = true;
            this.dgvStaff.AllowUserToAddRows = false;
            this.dgvStaff.AllowUserToDeleteRows = false;
            this.dgvStaff.SelectionChanged += DgvStaff_SelectionChanged;
            
            // Modern DataGridView styling
            this.dgvStaff.BackgroundColor = Color.White;
            this.dgvStaff.BorderStyle = BorderStyle.None;
            this.dgvStaff.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dgvStaff.EnableHeadersVisualStyles = false;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            this.dgvStaff.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvStaff.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvStaff.ColumnHeadersHeight = 40;
            this.dgvStaff.RowTemplate.Height = 35;
            this.dgvStaff.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            this.dgvStaff.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246);
            this.dgvStaff.DefaultCellStyle.SelectionForeColor = Color.White;

            // ========== GROUP BOX: THÔNG TIN CÁ NHÂN ==========
            this.grpPersonal.Text = "📋 Thông Tin Cá Nhân";
            this.grpPersonal.Location = new Point(20, 360);
            this.grpPersonal.Size = new Size(570, 240);
            this.grpPersonal.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpPersonal.ForeColor = Color.FromArgb(33, 150, 243);

            int grpY = 35;
            int grpStep = 42;
            
            // Mã NV
            this.lblStaffId.Text = "Mã NV:";
            this.lblStaffId.Location = new Point(20, grpY);
            this.lblStaffId.Size = new Size(120, 25);
            this.lblStaffId.Font = new Font("Segoe UI", 10F);
            this.lblStaffId.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtStaffId.Location = new Point(145, grpY);
            this.txtStaffId.Size = new Size(400, 28);
            this.txtStaffId.Font = new Font("Segoe UI", 10F);
            this.txtStaffId.BorderStyle = BorderStyle.FixedSingle;
            this.txtStaffId.ReadOnly = true;
            this.txtStaffId.BackColor = Color.FromArgb(240, 240, 240);

            // Họ tên
            this.lblHoTen.Text = "Họ tên: *";
            this.lblHoTen.Location = new Point(20, grpY + grpStep);
            this.lblHoTen.Size = new Size(120, 25);
            this.lblHoTen.Font = new Font("Segoe UI", 10F);
            this.lblHoTen.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtHoTen.Location = new Point(145, grpY + grpStep);
            this.txtHoTen.Size = new Size(400, 28);
            this.txtHoTen.Font = new Font("Segoe UI", 10F);
            this.txtHoTen.BorderStyle = BorderStyle.FixedSingle;

            // Ngày sinh
            this.lblNgaySinh.Text = "Ngày sinh:";
            this.lblNgaySinh.Location = new Point(20, grpY + grpStep * 2);
            this.lblNgaySinh.Size = new Size(120, 25);
            this.lblNgaySinh.Font = new Font("Segoe UI", 10F);
            this.lblNgaySinh.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.dtpNgaySinh.Location = new Point(145, grpY + grpStep * 2);
            this.dtpNgaySinh.Size = new Size(180, 28);
            this.dtpNgaySinh.Format = DateTimePickerFormat.Short;
            this.dtpNgaySinh.Font = new Font("Segoe UI", 10F);

            // Giới tính
            this.lblGioiTinh.Text = "Giới tính:";
            this.lblGioiTinh.Location = new Point(345, grpY + grpStep * 2);
            this.lblGioiTinh.Size = new Size(80, 25);
            this.lblGioiTinh.Font = new Font("Segoe UI", 10F);
            this.lblGioiTinh.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.cboGioiTinh.Location = new Point(425, grpY + grpStep * 2);
            this.cboGioiTinh.Size = new Size(120, 28);
            this.cboGioiTinh.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboGioiTinh.Font = new Font("Segoe UI", 10F);
            this.cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });

            // Địa chỉ
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.Location = new Point(20, grpY + grpStep * 3);
            this.lblDiaChi.Size = new Size(120, 25);
            this.lblDiaChi.Font = new Font("Segoe UI", 10F);
            this.lblDiaChi.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtDiaChi.Location = new Point(145, grpY + grpStep * 3);
            this.txtDiaChi.Size = new Size(400, 28);
            this.txtDiaChi.Font = new Font("Segoe UI", 10F);
            this.txtDiaChi.BorderStyle = BorderStyle.FixedSingle;

            // SĐT & Email
            this.lblSoDienThoai.Text = "Số ĐT:";
            this.lblSoDienThoai.Location = new Point(20, grpY + grpStep * 4);
            this.lblSoDienThoai.Size = new Size(120, 25);
            this.lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            this.lblSoDienThoai.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtSoDienThoai.Location = new Point(145, grpY + grpStep * 4);
            this.txtSoDienThoai.Size = new Size(160, 28);
            this.txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            this.txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;

            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new Point(315, grpY + grpStep * 4);
            this.lblEmail.Size = new Size(50, 25);
            this.lblEmail.Font = new Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtEmail.Location = new Point(365, grpY + grpStep * 4);
            this.txtEmail.Size = new Size(180, 28);
            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;

            // Add controls to GroupBox
            this.grpPersonal.Controls.Add(this.lblStaffId);
            this.grpPersonal.Controls.Add(this.txtStaffId);
            this.grpPersonal.Controls.Add(this.lblHoTen);
            this.grpPersonal.Controls.Add(this.txtHoTen);
            this.grpPersonal.Controls.Add(this.lblNgaySinh);
            this.grpPersonal.Controls.Add(this.dtpNgaySinh);
            this.grpPersonal.Controls.Add(this.lblGioiTinh);
            this.grpPersonal.Controls.Add(this.cboGioiTinh);
            this.grpPersonal.Controls.Add(this.lblDiaChi);
            this.grpPersonal.Controls.Add(this.txtDiaChi);
            this.grpPersonal.Controls.Add(this.lblSoDienThoai);
            this.grpPersonal.Controls.Add(this.txtSoDienThoai);
            this.grpPersonal.Controls.Add(this.lblEmail);
            this.grpPersonal.Controls.Add(this.txtEmail);

            // ========== GROUP BOX: THÔNG TIN CÔNG VIỆC ==========
            this.grpWork.Text = "💼 Thông Tin Công Việc";
            this.grpWork.Location = new Point(610, 360);
            this.grpWork.Size = new Size(570, 240);
            this.grpWork.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpWork.ForeColor = Color.FromArgb(33, 150, 243);

            // Chức vụ
            this.lblChucVu.Text = "Chức vụ: *";
            this.lblChucVu.Location = new Point(20, grpY);
            this.lblChucVu.Size = new Size(120, 25);
            this.lblChucVu.Font = new Font("Segoe UI", 10F);
            this.lblChucVu.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.cboChucVu.Location = new Point(145, grpY);
            this.cboChucVu.Size = new Size(400, 28);
            this.cboChucVu.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new Font("Segoe UI", 10F);

            // Ngày vào làm
            this.lblNgayVaoLam.Text = "Ngày vào làm:";
            this.lblNgayVaoLam.Location = new Point(20, grpY + grpStep);
            this.lblNgayVaoLam.Size = new Size(120, 25);
            this.lblNgayVaoLam.Font = new Font("Segoe UI", 10F);
            this.lblNgayVaoLam.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.dtpNgayVaoLam.Location = new Point(145, grpY + grpStep);
            this.dtpNgayVaoLam.Size = new Size(180, 28);
            this.dtpNgayVaoLam.Format = DateTimePickerFormat.Short;
            this.dtpNgayVaoLam.Font = new Font("Segoe UI", 10F);

            // Trạng thái
            this.lblTrangThai.Text = "Trạng thái:";
            this.lblTrangThai.Location = new Point(20, grpY + grpStep * 2);
            this.lblTrangThai.Size = new Size(120, 25);
            this.lblTrangThai.Font = new Font("Segoe UI", 10F);
            this.lblTrangThai.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.cboTrangThai.Location = new Point(145, grpY + grpStep * 2);
            this.cboTrangThai.Size = new Size(200, 28);
            this.cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new Font("Segoe UI", 10F);
            this.cboTrangThai.Items.AddRange(new string[] { "Đang làm việc", "Nghỉ việc", "Tạm nghỉ" });
            this.cboTrangThai.SelectedIndex = 0;

            this.grpWork.Controls.Add(this.lblChucVu);
            this.grpWork.Controls.Add(this.cboChucVu);
            this.grpWork.Controls.Add(this.lblNgayVaoLam);
            this.grpWork.Controls.Add(this.dtpNgayVaoLam);
            this.grpWork.Controls.Add(this.lblTrangThai);
            this.grpWork.Controls.Add(this.cboTrangThai);

            // ========== BUTTONS ==========
            int btnY = 620;
            int btnX = 20;
            int btnWidth = 110;
            int btnHeight = 40;
            int btnGap = 10;

            // Add Button (Green)
            this.btnAdd.Text = "➕ Thêm";
            this.btnAdd.Location = new Point(btnX, btnY);
            this.btnAdd.Size = new Size(btnWidth, btnHeight);
            this.btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdd.Cursor = Cursors.Hand;
            this.btnAdd.Click += BtnAdd_Click;

            // Edit Button (Blue)
            this.btnEdit.Text = "✏️ Sửa";
            this.btnEdit.Location = new Point(btnX + (btnWidth + btnGap), btnY);
            this.btnEdit.Size = new Size(btnWidth, btnHeight);
            this.btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnEdit.Cursor = Cursors.Hand;
            this.btnEdit.Click += BtnEdit_Click;

            // Delete Button (Red)
            this.btnDelete.Text = "🗑️ Xóa";
            this.btnDelete.Location = new Point(btnX + (btnWidth + btnGap) * 2, btnY);
            this.btnDelete.Size = new Size(btnWidth, btnHeight);
            this.btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.Click += BtnDelete_Click;

            // Save Button (Primary)
            this.btnSave.Text = "💾 Lưu";
            this.btnSave.Location = new Point(btnX + (btnWidth + btnGap) * 3, btnY);
            this.btnSave.Size = new Size(btnWidth, btnHeight);
            this.btnSave.BackColor = Color.FromArgb(0, 150, 136);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += BtnSave_Click;

            // Cancel Button (Gray)
            this.btnCancel.Text = "✖️ Hủy";
            this.btnCancel.Location = new Point(btnX + (btnWidth + btnGap) * 4, btnY);
            this.btnCancel.Size = new Size(btnWidth, btnHeight);
            this.btnCancel.BackColor = Color.FromArgb(158, 158, 158);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += BtnCancel_Click;

            // Refresh Button
            this.btnRefresh.Text = "🔄 Làm mới";
            this.btnRefresh.Location = new Point(btnX + (btnWidth + btnGap) * 5, btnY);
            this.btnRefresh.Size = new Size(btnWidth, btnHeight);
            this.btnRefresh.BackColor = Color.FromArgb(96, 125, 139);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.Click += (s, e) => { LoadData(); ClearInputs(); };

            // ========== FORM ==========
            this.ClientSize = new Size(1200, 690);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpWork);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản Lý Nhân Viên";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.Font = new Font("Segoe UI", 9F);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.grpPersonal.ResumeLayout(false);
            this.grpWork.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void LoadChucVu()
        {
            cboChucVu.Items.Clear();
            cboChucVu.Items.AddRange(new string[] 
            { 
                "Quản trị viên", 
                "Thủ thư trưởng", 
                "Thủ thư", 
                "Nhân viên", 
                "Thực tập sinh" 
            });
        }

        private void LoadData()
        {
            try
            {
                // Phải lấy từ db.Staff cho Form nhân viên
                var rawStaff = db.Staff.ToList();

                var displayList = rawStaff.Select(s => new
                {
                    s.StaffId, // Đây là kiểu int
                    HoTen = CryptoHelper.Decrypt(s.HoTen),
                    ChucVu = CryptoHelper.Decrypt(s.ChucVu),
                    s.NgaySinh,
                    s.GioiTinh,
                    SoDienThoai = CryptoHelper.Decrypt(s.SoDienThoai),
                    Email = CryptoHelper.Decrypt(s.Email),
                    s.NgayVaoLam,
                    s.TrangThai
                }).ToList();

                dgvStaff.DataSource = displayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị: " + ex.Message);
            }
        }
        private void FormatGridView()
        {
            if (dgvStaff.Columns.Count > 0)
            {
                dgvStaff.Columns["StaffId"].HeaderText = "Mã NV";
                dgvStaff.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvStaff.Columns["ChucVu"].HeaderText = "Chức Vụ";
                dgvStaff.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvStaff.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvStaff.Columns["SoDienThoai"].HeaderText = "Số ĐT";
                dgvStaff.Columns["Email"].HeaderText = "Email";
                dgvStaff.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
                dgvStaff.Columns["TrangThai"].HeaderText = "Trạng Thái";

                dgvStaff.Columns["StaffId"].Width = 70;
                dgvStaff.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvStaff.Columns["NgayVaoLam"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void DgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null && !isEditing)
            {
                var row = dgvStaff.CurrentRow;
                txtStaffId.Text = row.Cells["StaffId"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);

                // Địa chỉ được bảo mật cao hơn, truy vấn riêng khi cần hiển thị chi tiết
                try
                {
                    int staffId = Convert.ToInt32(row.Cells["StaffId"].Value);
                    var fullStaff = db.Staff.FirstOrDefault(s => s.StaffId == staffId);
                    if (fullStaff != null)
                    {
                        txtDiaChi.Text = CryptoHelper.Decrypt(fullStaff.DiaChi);
                    }
                }
                catch { txtDiaChi.Clear(); }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            isEditing = true;
            SetControlState(true);
            ClearInputs();
            txtStaffId.Text = "(Tự động)";
            txtHoTen.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditing = true;
            SetControlState(true);
            txtHoTen.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow == null) return;

            int staffId = Convert.ToInt32(dgvStaff.CurrentRow.Cells["StaffId"].Value);
            string name = dgvStaff.CurrentRow.Cells["HoTen"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên '{name}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var staff = db.Staff.Find(staffId);
                    if (staff != null)
                    {
                        db.Staff.Remove(staff);
                        db.SaveChanges();
                        LoadData();
                        ClearInputs();
                        MessageBox.Show("✅ Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Không thể xóa (có thể do có tài khoản hoặc phiếu mượn liên quan).\nLỗi: " + ex.Message, 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập họ tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Staff staff;
                bool isNew = false;

                if (txtStaffId.Text == "(Tự động)" || string.IsNullOrEmpty(txtStaffId.Text))
                {
                    staff = new Staff();
                    isNew = true;
                }
                else
                {
                    int id = int.Parse(txtStaffId.Text);
                    staff = db.Staff.Find(id);
                }

                if (staff != null)
                {
                    // MÃ HÓA DỮ LIỆU BẰNG AES TRƯỚC KHI LƯU XUỐNG DB
                    staff.HoTen = CryptoHelper.Encrypt(txtHoTen.Text.Trim());
                    staff.ChucVu = CryptoHelper.Encrypt(cboChucVu.Text.Trim());
                    staff.DiaChi = CryptoHelper.Encrypt(txtDiaChi.Text.Trim());
                    staff.SoDienThoai = CryptoHelper.Encrypt(txtSoDienThoai.Text.Trim());
                    staff.Email = CryptoHelper.Encrypt(txtEmail.Text.Trim());

                    staff.NgaySinh = dtpNgaySinh.Value;
                    staff.GioiTinh = cboGioiTinh.Text;
                    staff.NgayVaoLam = dtpNgayVaoLam.Value;
                    staff.TrangThai = cboTrangThai.Text;

                    if (isNew) db.Staff.Add(staff);
                    db.SaveChanges();

                    MessageBox.Show("✅ Đã mã hóa và lưu dữ liệu thành công!", "Bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi mã hóa khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isEditing = false;
            SetControlState(false);
            DgvStaff_SelectionChanged(null, null);
        }

        private void SetControlState(bool editing)
        {
            txtHoTen.ReadOnly = !editing;
            cboChucVu.Enabled = editing;
            dtpNgaySinh.Enabled = editing;
            cboGioiTinh.Enabled = editing;
            txtDiaChi.ReadOnly = !editing;
            txtSoDienThoai.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            dtpNgayVaoLam.Enabled = editing;
            cboTrangThai.Enabled = editing;

            btnAdd.Enabled = !editing;
            btnEdit.Enabled = !editing;
            btnDelete.Enabled = !editing;
            btnRefresh.Enabled = !editing;

            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;

            dgvStaff.Enabled = !editing;

            // Visual feedback
            if (editing)
            {
                grpPersonal.ForeColor = Color.FromArgb(76, 175, 80);
                grpWork.ForeColor = Color.FromArgb(76, 175, 80);
            }
            else
            {
                grpPersonal.ForeColor = Color.FromArgb(33, 150, 243);
                grpWork.ForeColor = Color.FromArgb(33, 150, 243);
            }
        }

        private void ClearInputs()
        {
            txtStaffId.Clear();
            txtHoTen.Clear();
            cboChucVu.SelectedIndex = -1;
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
            cboGioiTinh.SelectedIndex = -1;
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
            dtpNgayVaoLam.Value = DateTime.Now;
            cboTrangThai.SelectedIndex = 0;
        }

        // Controls
        private DataGridView dgvStaff;
        private GroupBox grpPersonal, grpWork;
        private TextBox txtStaffId, txtHoTen, txtDiaChi, txtSoDienThoai, txtEmail;
        private ComboBox cboChucVu, cboGioiTinh, cboTrangThai;
        private DateTimePicker dtpNgaySinh, dtpNgayVaoLam;
        private Label lblStaffId, lblHoTen, lblChucVu, lblNgaySinh, lblGioiTinh, 
                      lblDiaChi, lblSoDienThoai, lblEmail, lblNgayVaoLam, lblTrangThai;
        private Button btnAdd, btnEdit, btnDelete, btnSave, btnCancel, btnRefresh;
    }
}
