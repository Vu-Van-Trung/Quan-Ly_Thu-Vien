#nullable disable
using LibraryManagement.Data;
using Microsoft.EntityFrameworkCore;
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

        // Cấu hình bật/tắt mã hóa: Phải trùng với cấu hình bên FormRegister
        private const bool USE_HASH = true;

        public Login1()
        {
            InitializeComponent();
            this.FormClosing += form1_FormClosing;
            txtPassword.PasswordChar = '*';
            this.AcceptButton = btnLogin;
            // Đặt con trỏ vào ô Username khi form load
            this.ActiveControl = txtUsername;
        }

        public static string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            loginError.Visible = false;
            string username = txtUsername.Text.Trim();
            string rawPassword = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(rawPassword))
            {
                ShowError("Vui lòng nhập đầy đủ thông tin!");
                return;
            }

            // Xử lý mật khẩu dựa trên cấu hình USE_HASH
            string passwordToCompare = USE_HASH ? HashPassword(rawPassword) : rawPassword;

            try
            {
                using (var context = new LibraryContext())
                {
                    // Truy vấn kiểm tra thông tin đăng nhập
                    var user = context.Users
                                      .FirstOrDefault(u => u.Username == username && u.Password == passwordToCompare);

                    if (user != null)
                    {
                        if (user.TrangThai != "Hoạt động")
                        {
                            ShowError("Tài khoản bị khóa!");
                            return;
                        }

                        // Cập nhật thời gian đăng nhập cuối (nếu cần)
                        user.LanDangNhapCuoi = DateTime.Now;
                        context.SaveChanges();

                        // Cập nhật thông tin Session
                        Services.Session.CurrentUserId = user.Id;
                        Services.Session.CurrentUsername = user.Username;
                        Services.Session.CurrentRole = user.Role;

                        // Log đăng nhập
                        Services.Logger.Log("Hệ thống", "Đăng nhập", $"Người dùng {user.Username} đã đăng nhập.");

                        QuanLiThuVien mainForm = new QuanLiThuVien(user.Role);
                        this.Hide();
                        mainForm.Show();
                    }
                    else
                    {
                        ShowError("Sai tên đăng nhập hoặc mật khẩu!");
                        txtPassword.Clear();
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.InnerException?.Message ?? ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowError(string message)
        {
            loginError.Text = message;
            loginError.Visible = true;
            loginError.ForeColor = Color.Red;
        }

        // --- CÁC SỰ KIỆN KHÁC GIỮ NGUYÊN ---
        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            //    if (MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //    {
            //        exitConfirmed = true;
            //        Application.Exit();
            //    }
            this.Close();
        }

        private void form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!exitConfirmed && MessageBox.Show("Thoát ứng dụng?", "Xác nhận", MessageBoxButtons.YesNo) != DialogResult.Yes)
                e.Cancel = true;
        }

        private void dktk_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            this.Hide();
            registerForm.ShowDialog();
            this.Show();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click_1(this, EventArgs.Empty);
        }
        private void Login_Load(object sender, EventArgs e) { }
        private void guna2TextBox1_TextChanged(object sender, EventArgs e) { }
        private void guna2TextBox2_TextChanged(object sender, EventArgs e) { }

        private void guna2CircleButton1_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => MessageBox.Show("Liên hệ Admin.");

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}