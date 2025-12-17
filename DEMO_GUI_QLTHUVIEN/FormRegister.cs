
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
            // Cấu hình ẩn mật khẩu
            txtNewPassword.PasswordChar = '*';
            txtConfirmPassword.PasswordChar = '*';
            // Nhấn Enter là kích hoạt nút Đăng ký
            this.AcceptButton = create;
        }

        // --- XỬ LÝ SỰ KIỆN CLICK NÚT ĐĂNG KÝ ---
        private async void create_Click_1(object sender, EventArgs e)
        {
            // 1. Reset thông báo lỗi
            loginError.Visible = false;

            string username = txtNewUsername.Text.Trim();
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirmPassword.Text;

            // 2. Validate dữ liệu đầu vào
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

            // 3. Xử lý logic với Database
            try
            {
                // Sử dụng 'using' để tự động đóng kết nối khi xong
                using (var context = new LibraryContext())
                {
                    // Kiểm tra username đã tồn tại chưa (Dùng AnyAsync của EF Core)
                    bool isExist = await context.Users.AnyAsync(u => u.Username == username);

                    if (isExist)
                    {
                        ShowError("Tên đăng nhập đã tồn tại, vui lòng chọn tên khác!");
                        txtNewUsername.Focus();
                        return;
                    }

                    // Mã hóa mật khẩu
                    string hashedPassword = HashPassword(newPass);

                    // Tạo User mới
                    var newUser = new User()
                    {
                        Username = username,
                        Password = hashedPassword,
                        Role = "User" // Mặc định quyền User
                    };

                    // Thêm và Lưu
                    context.Users.Add(newUser);
                    await context.SaveChangesAsync();

                    MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Đóng form đăng ký để quay về đăng nhập
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }
                return sb.ToString();
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
    }
}