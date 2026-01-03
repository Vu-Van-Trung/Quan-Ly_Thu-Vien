using DoAnDemoUI.Model;
using LibraryManagement.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions; // Thêm thư viện để dùng Regex
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class FormRegister : Form
    {
        private const bool USE_HASH = true; // Theo yêu cầu hiện tại của bạn

        public FormRegister()
        {
            InitializeComponent();
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            this.AcceptButton = create;
        }

        private async void create_Click_1(object sender, EventArgs e)
        {
            loginError.Visible = false;

            string username = txtNewUsername.Text.Trim();
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            // 1. Kiểm tra rỗng
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(newPass) || string.IsNullOrEmpty(confirmPass))
            {
                ShowError("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // 2. Kiểm tra định dạng mật khẩu (8 ký tự, 1 chữ hoa, 1 ký tự đặc biệt)
            // Biểu thức Regex kiểm tra:
            // ^(?=.*[A-Z]) : Có ít nhất 1 chữ hoa
            // (?=.*[!@#$%^&*(),.?":{}|<>]) : Có ít nhất 1 ký tự đặc biệt
            // .{8,} : Độ dài ít nhất 8
            var passwordRegex = new Regex(@"^(?=.*[A-Z])(?=.*[!@#$%^&*(),.?#@"":{}|<>]).{8,}$");

            if (!passwordRegex.IsMatch(newPass))
            {
                ShowError("Mật khẩu phải từ 8 ký tự, có chữ hoa và ký tự đặc biệt!");
                txtNewPassword.Focus();
                return;
            }

            // 3. Kiểm tra khớp mật khẩu
            if (newPass != confirmPass)
            {
                ShowError("Mật khẩu xác nhận không khớp!");
                txtConfirmPassword.Clear();
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                using (var context = new LibraryContext())
                {
                    // 4. Kiểm tra trùng tên đăng nhập
                    bool isExist = await context.Users.AnyAsync(u => u.Username == username);
                    if (isExist)
                    {
                        ShowError("Tên đăng nhập đã tồn tại!");
                        txtNewUsername.Focus();
                        return;
                    }

                    string finalPassword = USE_HASH ? HashPassword(newPass) : newPass;

                    var newUser = new User()
                    {
                        Username = username,
                        Password = finalPassword,
                        StaffId = 1, // Tạm thời để 1 theo logic hiện tại
                        Role = "Nhân viên",
                        TrangThai = "Hoạt động",
                        CreatedAt = DateTime.Now
                    };

                    context.Users.Add(newUser);
                    await context.SaveChangesAsync();

                    // Log
                    DoAnDemoUI.Services.Logger.Log("Hệ Thống", "Đăng ký", $"Đăng ký tài khoản mới: {username}");

                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.InnerException?.Message ?? ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowError(string message)
        {
            loginError.Text = message;
            loginError.Visible = true;
            loginError.ForeColor = Color.Red;
        }

        private static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void Cancel_Click_1(object sender, EventArgs e) => this.Close();

        // Event rỗng cho Designer
        private void label1_Click(object sender, EventArgs e) { }
        private void txtNewUsername_TextChanged(object sender, EventArgs e) { }
        private void txtPassword_TextChanged(object sender, EventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
    }
}