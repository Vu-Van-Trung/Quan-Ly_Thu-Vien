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
    /// Form quản lý Nhà xuất bản - Enhanced UI
    /// </summary>
    public partial class FormPublisher : Form
    {
        private LibraryContext db;
        private bool isEditing = false;

        public FormPublisher()
        {
            InitializeComponent();
            this.Load += FormPublisher_Load;

            txtSoDienThoai.KeyPress += txtSoDienThoai_KeyPress;
            txtSoDienThoai.MaxLength = 11;
            
            txtTenNhaXuatBan.TextChanged += txtTenNhaXuatBan_TextChanged;
            txtTenNhaXuatBan.Leave += txtTenNhaXuatBan_Leave;

            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.Leave += txtEmail_Leave;

            txtDiaChi.TextChanged += txtDiaChi_TextChanged;
            txtDiaChi.Leave += txtDiaChi_Leave;
        }

        private void FormPublisher_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadData();
            SetControlState(false);
            // Xóa dữ liệu mẫu khi chạy thật
            ClearInputs();
        }

        private void LoadData()
        {
            try
            {
                // QUAN TRỌNG: Chặn code tự động sinh cột để dùng cột đã tạo trong Designer
                dgvPublishers.AutoGenerateColumns = false;

                // Sử dụng AsEnumerable() để giải mã dữ liệu trong bộ nhớ RAM
                var publishers = db.Publishers.AsEnumerable()
                    .Select(p => new
                    {
                        p.PublisherId,
                        TenNhaXuatBan = CryptoHelper.Decrypt(p.TenNhaXuatBan),
                        DiaChi = CryptoHelper.Decrypt(p.DiaChi),
                        SoDienThoai = CryptoHelper.Decrypt(p.SoDienThoai),
                        Email = CryptoHelper.Decrypt(p.Email)
                    })
                    .ToList();

                dgvPublishers.DataSource = publishers;

                // Vì đã định nghĩa cột ở Designer, ta chỉ cần set lại Width nếu cần
                // Các dòng set HeaderText ở đây không cần thiết nữa nhưng để lại cũng không sao
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu bảo mật: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvPublishers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPublishers.CurrentRow != null && !isEditing)
            {
                var row = dgvPublishers.CurrentRow;
                // Dữ liệu trên Grid đã được giải mã từ hàm LoadData()
                txtPublisherId.Text = row.Cells["colId"].Value?.ToString(); // Lưu ý: dùng tên biến cột colId hoặc DataPropertyName
                txtTenNhaXuatBan.Text = row.Cells["colTen"].Value?.ToString();
                txtDiaChi.Text = row.Cells["colDiaChi"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["colSDT"].Value?.ToString();
                txtEmail.Text = row.Cells["colEmail"].Value?.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            isEditing = true;
            SetControlState(true);
            ClearInputs();
            txtPublisherId.Text = "(Tự động)";
            txtTenNhaXuatBan.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPublishers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditing = true;
            SetControlState(true);
            txtTenNhaXuatBan.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPublishers.CurrentRow == null) return;

            // Lấy ID từ cột ẩn hoặc DataBoundItem
            int publisherId = Convert.ToInt32(dgvPublishers.CurrentRow.Cells["colId"].Value);
            string name = dgvPublishers.CurrentRow.Cells["colTen"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhà xuất bản '{name}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var publisher = db.Publishers.Find(publisherId);
                    if (publisher != null)
                    {
                        db.Publishers.Remove(publisher);
                        db.SaveChanges();
                         // Log
                        DoAnDemoUI.Services.Logger.Log("Quản lý Nhà Xuất Bản", "Xóa", $"Xóa NXB: {name} (ID: {publisherId})");

                        LoadData();
                        ClearInputs();
                        MessageBox.Show("✅ Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Không thể xóa (có thể do có sách liên quan).\nLỗi: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaXuatBan.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên, email và địa chỉ!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation Name (Regex)
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTenNhaXuatBan.Text.Trim(), @"^[\p{L}\s]+$"))
            {
                MessageBox.Show("Tên nhà xuất bản không được chứa số hoặc ký tự đặc biệt", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation Email
            if (!KiemTraEmail(txtEmail.Text))
            {
                 MessageBox.Show("Email không đúng định dạng", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
            }

            // Validation Address
            if (!KiemTraDiaChi(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không hợp lệ", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (txtPublisherId.Text == "(Tự động)" || string.IsNullOrEmpty(txtPublisherId.Text))
                {
                    var newPublisher = new Publisher
                    {
                        TenNhaXuatBan = CryptoHelper.Encrypt(txtTenNhaXuatBan.Text.Trim()),
                        DiaChi = CryptoHelper.Encrypt(txtDiaChi.Text.Trim()),
                        SoDienThoai = CryptoHelper.Encrypt(txtSoDienThoai.Text.Trim()),
                        Email = CryptoHelper.Encrypt(txtEmail.Text.Trim())
                    };
                    db.Publishers.Add(newPublisher);
                    db.SaveChanges();
                    
                    // Log
                    DoAnDemoUI.Services.Logger.Log("Quản lý Nhà Xuất Bản", "Thêm mới", $"Thêm NXB: {txtTenNhaXuatBan.Text.Trim()}");

                    MessageBox.Show("✅ Thêm và mã hóa dữ liệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    int publisherId = int.Parse(txtPublisherId.Text);
                    var publisher = db.Publishers.Find(publisherId);
                    if (publisher != null)
                    {
                        publisher.TenNhaXuatBan = CryptoHelper.Encrypt(txtTenNhaXuatBan.Text.Trim());
                        publisher.DiaChi = CryptoHelper.Encrypt(txtDiaChi.Text.Trim());
                        publisher.SoDienThoai = CryptoHelper.Encrypt(txtSoDienThoai.Text.Trim());
                        publisher.Email = CryptoHelper.Encrypt(txtEmail.Text.Trim());

                        db.SaveChanges();
                         // Log
                        DoAnDemoUI.Services.Logger.Log("Quản lý Nhà Xuất Bản", "Cập nhật", $"Cập nhật NXB: {txtTenNhaXuatBan.Text.Trim()} (ID: {publisherId})");

                        MessageBox.Show("✅ Cập nhật dữ liệu mã hóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                var detail = ex.InnerException?.GetBaseException()?.Message ?? ex.Message;
                MessageBox.Show("Lỗi khi lưu: " + detail, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isEditing = false;
            SetControlState(false);
            // Nếu muốn sau khi hủy thì quay lại dòng đang chọn:
            DgvPublishers_SelectionChanged(null, null);
        }

        private void SetControlState(bool editing)
        {
            txtTenNhaXuatBan.ReadOnly = !editing;
            txtDiaChi.ReadOnly = !editing;
            txtSoDienThoai.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;

            btnAdd.Enabled = !editing;
            btnEdit.Enabled = !editing;
            btnDelete.Enabled = !editing;
            btnRefresh.Enabled = !editing;

            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;

            dgvPublishers.Enabled = !editing;

            if (editing)
            {
                grpInfo.ForeColor = Color.FromArgb(76, 175, 80);
            }
            else
            {
                grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtPublisherId.Clear();
            txtTenNhaXuatBan.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
        }

        private void FormPublisher_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ===== Helper Methods =====
        bool KiemTraEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(
                email.Trim(),
                @"^[^@\s]+@[^@\s]+\.[^@\s]+$"
            );
        }

        bool KiemTraDiaChi(string diaChi)
        {
             return System.Text.RegularExpressions.Regex.IsMatch(
                diaChi.Trim(),
                @"^[\p{L}0-9\s,./\-]{5,}$"
            );
        }

        // ===== Event Handlers =====
        private void txtSoDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0 && !KiemTraEmail(txtEmail.Text))
                lblThongBao.Text = "Email không đúng định dạng";
            else if (lblThongBao.Text == "Email không đúng định dạng")
                lblThongBao.Text = "";
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text.Length > 0 && !KiemTraEmail(txtEmail.Text))
            {
                lblThongBao.Text = "Email không đúng định dạng";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length > 0 && !KiemTraDiaChi(txtDiaChi.Text))
                lblThongBao.Text = "Địa chỉ chứa ký tự không hợp lệ";
            else if (lblThongBao.Text == "Địa chỉ chứa ký tự không hợp lệ")
                lblThongBao.Text = "";
        }

        private void txtDiaChi_Leave(object sender, EventArgs e)
        {
            if (txtDiaChi.Text.Length > 0 && !KiemTraDiaChi(txtDiaChi.Text))
            {
                 lblThongBao.Text = "Địa chỉ không hợp lệ (phải từ 5 ký tự)";
                 lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void txtTenNhaXuatBan_TextChanged(object sender, EventArgs e)
        {
            string name = txtTenNhaXuatBan.Text.Trim();
            if (name.Length > 0)
            {
                 // Clear "empty" error if typing
                 if (lblThongBao.Text == "Tên nhà xuất bản không được để trống")
                     lblThongBao.Text = "";

                 // Check regex
                 if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L}\s]+$"))
                 {
                     lblThongBao.Text = "Tên nhà xuất bản không được chứa số hoặc ký tự đặc biệt";
                 }
                 else if (lblThongBao.Text == "Tên nhà xuất bản không được chứa số hoặc ký tự đặc biệt")
                 {
                     lblThongBao.Text = "";
                 }
            }
        }

        private void txtTenNhaXuatBan_Leave(object sender, EventArgs e)
        {
            string name = txtTenNhaXuatBan.Text.Trim();
            if (string.IsNullOrWhiteSpace(name))
            {
                lblThongBao.Text = "Tên nhà xuất bản không được để trống";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L}\s]+$"))
            {
                lblThongBao.Text = "Tên nhà xuất bản không được chứa số hoặc ký tự đặc biệt";
                lblThongBao.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}