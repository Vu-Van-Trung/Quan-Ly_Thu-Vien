using DoAnDemoUI.Model;
using LibraryManagement.Data;
using Microsoft.EntityFrameworkCore; // QUAN TRỌNG: Dùng cái này thay cho System.Data.Entity
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
            this.Load += FormRegister_Load;
            // Cấu hình ẩn mật khẩu
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            // Nhấn Enter là kích hoạt nút Đăng ký
            this.AcceptButton = create;
        }

        private async void FormRegister_Load(object sender, EventArgs e)
        {
            await LoadAvailableStaffAsync();
        }

        // --- XỬ LÝ SỰ KIỆN CLICK NÚT ĐĂNG KÝ ---
        private async void create_Click_1(object sender, EventArgs e)
        {
            loginError.Visible = false;

            string username = txtNewUsername.Text.Trim();
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                ShowError("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            if (newPass != confirmPass)
            {
                ShowError("Mật khẩu xác nhận không khớp!");
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            if (cboStaff.SelectedIndex < 0 || cboStaff.SelectedValue == null)
            {
                ShowError("Vui lòng chọn nhân viên cần cấp tài khoản!");
                cboStaff.Focus();
                return;
            }

            int staffId = (int)cboStaff.SelectedValue;

            try
            {
                using (var context = new LibraryContext())
                {
                    bool isExist = await context.Users.AnyAsync(u => u.Username == username);

                    if (isExist)
                    {
                        ShowError("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                        txtNewUsername.Focus();
                        return;
                    }

                    bool staffAlreadyLinked = await context.Users.AnyAsync(u => u.StaffId == staffId);
                    if (staffAlreadyLinked)
                    {
                        ShowError("Nhân viên này đã có tài khoản, vui lòng chọn nhân viên khác!");
                        await LoadAvailableStaffAsync();
                        return;
                    }

                    var newUser = new User
                    {
                        Username = username,
                        Password = HashPassword(newPass),
                        Role = "User",
                        StaffId = staffId
                    };

                    context.Users.Add(newUser);
                    await context.SaveChangesAsync();

                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            catch (DbUpdateException ex)
            {
                var details = ex.InnerException?.Message ?? ex.Message;
                MessageBox.Show($"Không thể lưu tài khoản mới.\nChi tiết: {details}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task LoadAvailableStaffAsync()
        {
            try
            {
                using var context = new LibraryContext();
                var staffOptions = await context.Staff
                    .Where(s => !context.Users.Any(u => u.StaffId == s.StaffId))
                    .OrderBy(s => s.StaffId)
                    .Select(s => new StaffOption
                    {
                        Id = s.StaffId,
                        Display = $"{s.StaffId} - {s.HoTen} ({s.ChucVu})"
                    })
                    .ToListAsync();

                cboStaff.DataSource = staffOptions;
                cboStaff.DisplayMember = nameof(StaffOption.Display);
                cboStaff.ValueMember = nameof(StaffOption.Id);
                cboStaff.SelectedIndex = staffOptions.Count > 0 ? 0 : -1;
                cboStaff.Enabled = staffOptions.Count > 0;
                create.Enabled = staffOptions.Count > 0;

                if (staffOptions.Count == 0)
                {
                    ShowError("Chưa có nhân viên nào chưa có tài khoản. Vui lòng thêm nhân viên trước!");
                }
                else
                {
                    loginError.Visible = false;
                }
            }
            catch (Exception ex)
            {
                cboStaff.DataSource = null;
                cboStaff.Enabled = false;
                create.Enabled = false;
                ShowError($"Không thể tải danh sách nhân viên: {ex.Message}");
            }
        }

        // --- HÀM HỖ TRỢ HIỂN THỊ LỖI ---
        private void ShowError(string message)
        {
            loginError.Text = message;
            loginError.Visible = true;
            loginError.ForeColor = Color.Red;
        }

        // --- HÀM MÃ HÓA MẬT KHẨU (SHA256) ---
        private static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;

            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes); // 44 ký tự => không bị cắt nếu cột Password nvarchar(50)
            }
        }

        // --- SỰ KIỆN NÚT HỦY / TRỞ VỀ ---
        private void Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        // --- CÁC SỰ KIỆN RỖNG (GIỮ LẠI ĐỂ TRÁNH LỖI DESIGNER) ---
        // Nếu bạn xóa các dòng này, Designer bên kia sẽ báo lỗi đỏ vì không tìm thấy hàm
        private void label1_Click(object sender, EventArgs e) { }
        private void txtNewUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }

        private sealed class StaffOption
        {
            public int Id { get; set; }
            public string Display { get; set; }
        }
    }
}