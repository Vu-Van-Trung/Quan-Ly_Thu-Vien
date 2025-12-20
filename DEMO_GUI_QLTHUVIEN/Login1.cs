
using LibraryManagement.Data;
using Microsoft.EntityFrameworkCore; // Quan trọng cho EF Core
using System;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class Login1 : Form
    {
        private bool exitConfirmed = false;

        private bool dangNhapThanhCong = false;

        public Login1()
        {
            InitializeComponent();
            this.FormClosing += form1_FormClosing;
            // Cài đặt ký tự ẩn mật khẩu
            txtPassword.PasswordChar = '*';
            // Nhấn Enter thì tự động kích hoạt nút Login
            this.AcceptButton = btnLogin;
            // Đặt mặc định dấu nháy vào ô username
    this.ActiveControl = txtUsername;
        }

        // --- HÀM HASH MẬT KHẨU ---
        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password ?? string.Empty));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        // --- XỬ LÝ SỰ KIỆN ĐĂNG NHẬP ---
        // Hàm này khớp với tên trong file Designer (btnLogin_Click_1)
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            // 1. Reset thông báo lỗi
            loginError.Visible = false;
            loginError.ForeColor = Color.Red;

            string username = txtUsername.Text.Trim();
            string rawPassword = txtPassword.Text;

            // 2. Validate đầu vào
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(rawPassword))
            {
                loginError.Text = "Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu";
                loginError.Visible = true;
                return;
            }

            // 3. Hash mật khẩu để so sánh với DB
            string hashedPassword = HashPassword(rawPassword);

            try
            {
                using (var context = new LibraryContext())
                {
                    // Truy vấn DB tìm User
                    var user = context.Users
                                      .FirstOrDefault(u => u.Username == username && u.Password == hashedPassword);

                    if (user != null)
                    {
                        // --- ĐĂNG NHẬP THÀNH CÔNG ---

                        // 1. Báo hiệu kết quả OK về cho Program.cs
                        this.DialogResult = DialogResult.OK;

                        // 2. Đóng form Login lại (Lúc này Program.cs sẽ nhận được OK và mở Form chính)
                        this.Close();
                    }
                    else
                    {
                        // --- ĐĂNG NHẬP THẤT BẠI ---
                        loginError.Text = "Sai tên đăng nhập hoặc mật khẩu";
                        loginError.Visible = true;

                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối hệ thống: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // --- XỬ LÝ SỰ KIỆN THOÁT (Nút X tròn góc trái) ---
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // --- SỰ KIỆN KHI FORM ĐANG ĐÓNG ---
        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Nếu Đăng nhập thành công (OK) HOẶC bấm nút Thoát (Cancel) 
            // thì cho đóng luôn, không hiện MessageBox hỏi han gì nữa.
            if (this.DialogResult == DialogResult.OK || this.DialogResult == DialogResult.Cancel)
            {
                return;
            }

            if (exitConfirmed) return;

            var result = MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        // --- XỬ LÝ SỰ KIỆN ĐĂNG KÝ ---
        private void dktk_Click(object sender, EventArgs e)
        {
            // Mở form đăng ký, ẩn form đăng nhập
            FormRegister registerForm = new FormRegister();
            this.Hide();
            registerForm.ShowDialog(); // Chờ đăng ký xong
            this.Show(); // Hiện lại form đăng nhập
        }

        // --- HỖ TRỢ PHÍM ENTER TẠI Ô MẬT KHẨU ---
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click_1(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // --- NÚT THU NHỎ (MINIMIZE) ---
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // --- QUÊN MẬT KHẨU ---
        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản trị viên để đặt lại mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --- CÁC HÀM RỖNG (Giữ lại để tránh lỗi Designer nếu đã lỡ Double Click vào) ---
        private void Login_Load(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }
    }
}