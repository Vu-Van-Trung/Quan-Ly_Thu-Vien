using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace DoAnDemoUI
{
    /// <summary>
    /// Form quản lý Nhân viên
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
            this.dgvStaff = new DataGridView();
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
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dgvStaff.Location = new System.Drawing.Point(20, 20);
            this.dgvStaff.Size = new System.Drawing.Size(950, 300);
            this.dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvStaff.SelectionChanged += DgvStaff_SelectionChanged;

            // Labels and Controls
            int startY = 340;
            int col1X = 30, col2X = 500;
            int labelX1 = col1X, textX1 = col1X + 120;
            int labelX2 = col2X, textX2 = col2X + 120;
            int stepY = 40;

            // Column 1
            AddLabelAndTextBox("Mã NV:", txtStaffId, labelX1, textX1, startY, 0);
            txtStaffId.ReadOnly = true;

            AddLabelAndTextBox("Họ tên:", txtHoTen, labelX1, textX1, startY, 1);

            AddLabelAndComboBox("Chức vụ:", cboChucVu, labelX1, textX1, startY, 2);

            AddLabelAndDatePicker("Ngày sinh:", dtpNgaySinh, labelX1, textX1, startY, 3);

            AddLabelAndComboBox("Giới tính:", cboGioiTinh, labelX1, textX1, startY, 4);
            cboGioiTinh.Items.AddRange(new string[] { "Nam", "Nữ", "Khác" });

            // Column 2
            AddLabelAndTextBox("Địa chỉ:", txtDiaChi, labelX2, textX2, startY, 0);
            
            AddLabelAndTextBox("Số ĐT:", txtSoDienThoai, labelX2, textX2, startY, 1);

            AddLabelAndTextBox("Email:", txtEmail, labelX2, textX2, startY, 2);

            AddLabelAndDatePicker("Ngày vào làm:", dtpNgayVaoLam, labelX2, textX2, startY, 3);

            AddLabelAndComboBox("Trạng thái:", cboTrangThai, labelX2, textX2, startY, 4);
            cboTrangThai.Items.AddRange(new string[] { "Đang làm việc", "Nghỉ việc", "Tạm nghỉ" });
            cboTrangThai.SelectedIndex = 0;

            // Buttons
            int btnY = startY + stepY * 5 + 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(30, btnY);
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Click += BtnAdd_Click;

            this.btnEdit.Text = "Sửa";
            this.btnEdit.Location = new System.Drawing.Point(120, btnY);
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Click += BtnEdit_Click;

            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(210, btnY);
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Click += BtnDelete_Click;

            this.btnSave.Text = "Lưu";
            this.btnSave.Location = new System.Drawing.Point(300, btnY);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Click += BtnSave_Click;

            this.btnCancel.Text = "Hủy";
            this.btnCancel.Location = new System.Drawing.Point(390, btnY);
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Click += BtnCancel_Click;

            // Form
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Text = "Quản Lý Nhân Viên";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            this.ResumeLayout(false);
        }

        private void AddLabelAndTextBox(string labelText, TextBox textBox, int labelX, int textX, int startY, int index)
        {
            var label = new Label();
            label.Text = labelText;
            label.Location = new System.Drawing.Point(labelX, startY + index * 40);
            label.AutoSize = true;

            textBox.Location = new System.Drawing.Point(textX, startY + index * 40 - 3);
            textBox.Size = new System.Drawing.Size(300, 23);

            this.Controls.Add(label);
            this.Controls.Add(textBox);
        }

        private void AddLabelAndComboBox(string labelText, ComboBox comboBox, int labelX, int cbX, int startY, int index)
        {
            var label = new Label();
            label.Text = labelText;
            label.Location = new System.Drawing.Point(labelX, startY + index * 40);
            label.AutoSize = true;

            comboBox.Location = new System.Drawing.Point(cbX, startY + index * 40 - 3);
            comboBox.Size = new System.Drawing.Size(300, 23);
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            this.Controls.Add(label);
            this.Controls.Add(comboBox);
        }

        private void AddLabelAndDatePicker(string labelText, DateTimePicker dtp, int labelX, int dtpX, int startY, int index)
        {
            var label = new Label();
            label.Text = labelText;
            label.Location = new System.Drawing.Point(labelX, startY + index * 40);
            label.AutoSize = true;

            dtp.Location = new System.Drawing.Point(dtpX, startY + index * 40 - 3);
            dtp.Size = new System.Drawing.Size(300, 23);
            dtp.Format = DateTimePickerFormat.Short;

            this.Controls.Add(label);
            this.Controls.Add(dtp);
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
                var staff = db.Staff
                    .Select(s => new
                    {
                        s.StaffId,
                        s.HoTen,
                        s.ChucVu,
                        s.NgaySinh,
                        s.GioiTinh,
                        s.DiaChi,
                        s.SoDienThoai,
                        s.Email,
                        s.NgayVaoLam,
                        s.TrangThai
                    })
                    .ToList();

                dgvStaff.DataSource = staff;
                
                dgvStaff.Columns["StaffId"].HeaderText = "Mã NV";
                dgvStaff.Columns["HoTen"].HeaderText = "Họ Tên";
                dgvStaff.Columns["ChucVu"].HeaderText = "Chức Vụ";
                dgvStaff.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvStaff.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvStaff.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvStaff.Columns["SoDienThoai"].HeaderText = "Số ĐT";
                dgvStaff.Columns["Email"].HeaderText = "Email";
                dgvStaff.Columns["NgayVaoLam"].HeaderText = "Ngày Vào Làm";
                dgvStaff.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null && !isEditing)
            {
                var row = dgvStaff.CurrentRow;
                txtStaffId.Text = row.Cells["StaffId"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                cboChucVu.Text = row.Cells["ChucVu"].Value?.ToString();
                
                if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                else
                    dtpNgaySinh.Value = DateTime.Now.AddYears(-25);

                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                if (row.Cells["NgayVaoLam"].Value != null && row.Cells["NgayVaoLam"].Value != DBNull.Value)
                    dtpNgayVaoLam.Value = Convert.ToDateTime(row.Cells["NgayVaoLam"].Value);
                else
                    dtpNgayVaoLam.Value = DateTime.Now;

                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
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
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa!");
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
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa (có thể do có tài khoản hoặc phiếu mượn liên quan).\nLỗi: " + ex.Message);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || 
                string.IsNullOrWhiteSpace(cboChucVu.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên và chức vụ!");
                return;
            }

            try
            {
                if (txtStaffId.Text == "(Tự động)" || string.IsNullOrEmpty(txtStaffId.Text))
                {
                    // Thêm mới
                    var newStaff = new Staff
                    {
                        HoTen = txtHoTen.Text.Trim(),
                        ChucVu = cboChucVu.Text.Trim(),
                        NgaySinh = dtpNgaySinh.Value,
                        GioiTinh = cboGioiTinh.Text,
                        DiaChi = txtDiaChi.Text.Trim(),
                        SoDienThoai = txtSoDienThoai.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        NgayVaoLam = dtpNgayVaoLam.Value,
                        TrangThai = cboTrangThai.Text
                    };
                    db.Staff.Add(newStaff);
                    db.SaveChanges();
                    MessageBox.Show("Thêm nhân viên thành công!");
                }
                else
                {
                    // Cập nhật
                    int staffId = int.Parse(txtStaffId.Text);
                    var staff = db.Staff.Find(staffId);
                    if (staff != null)
                    {
                        staff.HoTen = txtHoTen.Text.Trim();
                        staff.ChucVu = cboChucVu.Text.Trim();
                        staff.NgaySinh = dtpNgaySinh.Value;
                        staff.GioiTinh = cboGioiTinh.Text;
                        staff.DiaChi = txtDiaChi.Text.Trim();
                        staff.SoDienThoai = txtSoDienThoai.Text.Trim();
                        staff.Email = txtEmail.Text.Trim();
                        staff.NgayVaoLam = dtpNgayVaoLam.Value;
                        staff.TrangThai = cboTrangThai.Text;

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
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

            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;

            dgvStaff.Enabled = !editing;
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
        private TextBox txtStaffId;
        private TextBox txtHoTen;
        private ComboBox cboChucVu;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGioiTinh;
        private TextBox txtDiaChi;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
        private DateTimePicker dtpNgayVaoLam;
        private ComboBox cboTrangThai;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
    }
}
