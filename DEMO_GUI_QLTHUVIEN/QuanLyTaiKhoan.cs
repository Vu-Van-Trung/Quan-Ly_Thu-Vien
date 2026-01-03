using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryManagement.Data;
using DoAnDemoUI.Model;
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace DEMO_GUI_QLTHUVIEN
{
    public partial class QuanLyTaiKhoan : Form
    {
        private LibraryContext db;
        private int _currentUserId = 0;

        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            db = new LibraryContext();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
            ResetControls();
        }

        private void LoadComboBoxes()
        {
            // Load Roles
            cbQuyenHan.Items.Clear();
            cbQuyenHan.Items.Add("Quản trị viên");
            cbQuyenHan.Items.Add("Nhân viên");
            cbQuyenHan.SelectedIndex = 1;

            // Load Status
            cbTrangThai.Items.Clear();
            cbTrangThai.Items.Add("Hoạt động");
            cbTrangThai.Items.Add("Đã khóa");
            cbTrangThai.SelectedIndex = 0;

            // Load Staff
            try
            {
                var staffList = db.Staff.Select(s => new { s.StaffId, s.HoTen }).ToList();
                cbNhanVien.DataSource = staffList;
                cbNhanVien.DisplayMember = "HoTen";
                cbNhanVien.ValueMember = "StaffId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                var users = db.Users
                    .Include(u => u.Staff)
                    .Select(u => new
                    {
                        u.Id,
                        u.Username,
                        StaffName = u.Staff.HoTen,
                        u.Role,
                        u.TrangThai,
                        u.StaffId,
                        u.LanDangNhapCuoi
                    })
                    .ToList();

                dgvTaiKhoan.DataSource = users;
                
                // Format columns
                if (dgvTaiKhoan.Columns["Id"] != null) dgvTaiKhoan.Columns["Id"].HeaderText = "ID";
                if (dgvTaiKhoan.Columns["Username"] != null) dgvTaiKhoan.Columns["Username"].HeaderText = "Tên đăng nhập";
                if (dgvTaiKhoan.Columns["StaffName"] != null) dgvTaiKhoan.Columns["StaffName"].HeaderText = "Nhân viên";
                if (dgvTaiKhoan.Columns["Role"] != null) dgvTaiKhoan.Columns["Role"].HeaderText = "Quyền hạn";
                if (dgvTaiKhoan.Columns["TrangThai"] != null) dgvTaiKhoan.Columns["TrangThai"].HeaderText = "Trạng thái";
                if (dgvTaiKhoan.Columns["LanDangNhapCuoi"] != null) dgvTaiKhoan.Columns["LanDangNhapCuoi"].HeaderText = "Đăng nhập cuối";
                
                if (dgvTaiKhoan.Columns["StaffId"] != null) dgvTaiKhoan.Columns["StaffId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu tài khoản: " + ex.Message);
            }
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvTaiKhoan.CurrentRow != null)
            {
                var row = dgvTaiKhoan.CurrentRow;
                _currentUserId = Convert.ToInt32(row.Cells["Id"].Value);
                txtTenDangNhap.Text = row.Cells["Username"].Value.ToString();
                
                string role = row.Cells["Role"].Value.ToString();
                cbQuyenHan.SelectedItem = role;

                string status = row.Cells["TrangThai"].Value.ToString();
                cbTrangThai.SelectedItem = status;

                int staffId = Convert.ToInt32(row.Cells["StaffId"].Value);
                cbNhanVien.SelectedValue = staffId;

                // Disable Username edit on selection
                txtTenDangNhap.Enabled = false;
                cbNhanVien.Enabled = false;
                btnThem.Enabled = false;
                btnCapNhat.Enabled = true;
                btnKhoa.Enabled = true;
                btnMoKhoa.Enabled = true;
                btnDoiMatKhau.Enabled = true;
            }
        }

        private string HashPassword(string password)
        {
            if (string.IsNullOrEmpty(password)) return string.Empty;
            using (System.Security.Cryptography.SHA256 sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void ResetControls()
        {
            txtTenDangNhap.Clear();
            txtTenDangNhap.Enabled = true;
            cbNhanVien.Enabled = true;
            if (cbNhanVien.Items.Count > 0) cbNhanVien.SelectedIndex = 0;
            cbQuyenHan.SelectedIndex = 1; // Default Nhân viên
            cbTrangThai.SelectedIndex = 0; // Default Hoạt động
            
            _currentUserId = 0;
            btnThem.Enabled = true;
            btnCapNhat.Enabled = false;
            btnKhoa.Enabled = false;
            btnMoKhoa.Enabled = false;
            btnDoiMatKhau.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ResetControls();
            dgvTaiKhoan.ClearSelection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }

            int staffId = (int)cbNhanVien.SelectedValue;

            if (db.Users.Any(u => u.Username == txtTenDangNhap.Text.Trim()))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!");
                return;
            }

            if (db.Users.Any(u => u.StaffId == staffId))
            {
                MessageBox.Show("Nhân viên này đã có tài khoản!");
                return;
            }

            try
            {
                var user = new User
                {
                    Username = txtTenDangNhap.Text.Trim(),
                    Password = HashPassword("123"), // Default password hashed
                    StaffId = staffId,
                    Role = cbQuyenHan.SelectedItem.ToString(),
                    TrangThai = cbTrangThai.SelectedItem.ToString(),
                    CreatedAt = DateTime.Now
                };

                db.Users.Add(user);
                db.SaveChanges();
                
                // Log
                DoAnDemoUI.Services.Logger.Log("Quản lý Tài Khoản", "Thêm mới", $"Thêm tài khoản: {user.Username}");

                MessageBox.Show("Thêm tài khoản thành công! Mật khẩu mặc định là '123'");
                LoadData();
                ResetControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm tài khoản: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (_currentUserId == 0) return;

            try
            {
                var user = db.Users.Find(_currentUserId);
                if (user != null)
                {
                    user.Role = cbQuyenHan.SelectedItem.ToString();
                    user.TrangThai = cbTrangThai.SelectedItem.ToString();
                    
                    db.SaveChanges();
                    
                    // Log
                    DoAnDemoUI.Services.Logger.Log("Quản lý Tài Khoản", "Cập nhật", $"Cập nhật tài khoản: {user.Username}");

                    MessageBox.Show("Cập nhật thành công!");
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            UpdateStatus("Đã khóa");
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            UpdateStatus("Hoạt động");
        }

        private void UpdateStatus(string status)
        {
            if (_currentUserId == 0) return;
            try
            {
                var user = db.Users.Find(_currentUserId);
                if (user != null)
                {
                    user.TrangThai = status;
                    db.SaveChanges();
                    
                    // Log
                    DoAnDemoUI.Services.Logger.Log("Quản lý Tài Khoản", "Đổi trạng thái", $"Đổi trạng thái {user.Username} thành {status}");

                    MessageBox.Show($"Đã {status} tài khoản!");
                    LoadData();
                    ResetControls();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thay đổi trạng thái: " + ex.Message);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (_currentUserId == 0) return;

            string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Nhập mật khẩu mới:", "Đổi mật khẩu", "");
            if (string.IsNullOrWhiteSpace(newPassword)) return; 

            try
            {
                var user = db.Users.Find(_currentUserId);
                if (user != null)
                {
                    user.Password = HashPassword(newPassword);
                    db.SaveChanges();
                    
                    // Log
                    DoAnDemoUI.Services.Logger.Log("Quản lý Tài Khoản", "Đổi mật khẩu", $"Đổi mật khẩu cho: {user.Username}");

                    MessageBox.Show("Đổi mật khẩu thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đổi mật khẩu: " + ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
