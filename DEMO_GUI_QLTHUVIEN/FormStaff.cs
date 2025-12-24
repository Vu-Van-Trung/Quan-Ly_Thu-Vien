using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
#nullable disable
using LibraryManagement.Data;
using LibraryManagement.Models;
using LibraryManagement.Security;

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
            ClearInputs(); // Xóa dữ liệu mẫu khi chạy lên
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
                // QUAN TRỌNG: Chặn code tự động sinh cột để dùng cột đã tạo trong Designer
                dgvStaff.AutoGenerateColumns = false;

                // Phải lấy từ db.Staff cho Form nhân viên
                var rawStaff = db.Staff.ToList();

                var displayList = rawStaff.Select(s => new
                {
                    s.StaffId,
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

        private void DgvStaff_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvStaff.CurrentRow != null && !isEditing)
            {
                var row = dgvStaff.CurrentRow;
                // Dùng tên cột (colId...) để lấy dữ liệu, an toàn hơn
                txtStaffId.Text = row.Cells["colId"].Value?.ToString();
                txtHoTen.Text = row.Cells["colHoTen"].Value?.ToString();
                cboChucVu.Text = row.Cells["colChucVu"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["colSDT"].Value?.ToString();
                txtEmail.Text = row.Cells["colEmail"].Value?.ToString();

                if (row.Cells["colNgaySinh"].Value != null)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["colNgaySinh"].Value);
                if (row.Cells["colGioiTinh"].Value != null)
                    cboGioiTinh.Text = row.Cells["colGioiTinh"].Value.ToString();
                if (row.Cells["colNgayVao"].Value != null)
                    dtpNgayVaoLam.Value = Convert.ToDateTime(row.Cells["colNgayVao"].Value);
                if (row.Cells["colTrangThai"].Value != null)
                    cboTrangThai.Text = row.Cells["colTrangThai"].Value.ToString();

                // Địa chỉ bảo mật cao
                try
                {
                    int staffId = Convert.ToInt32(row.Cells["colId"].Value);
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

            int staffId = Convert.ToInt32(dgvStaff.CurrentRow.Cells["colId"].Value);
            string name = dgvStaff.CurrentRow.Cells["colHoTen"].Value.ToString();

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

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
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
    }
}