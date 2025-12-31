using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Data;
using Microsoft.EntityFrameworkCore;
using System.IO;

namespace DoAnDemoUI
{
    public partial class FormSettings : Form
    {
        private string _userRole;

        public FormSettings(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            // Chỉ Admin mới được phép thao tác nút Backup/Restore
            bool isAdmin = !string.IsNullOrEmpty(_userRole) &&
                           (_userRole.Equals("Admin", StringComparison.OrdinalIgnoreCase) ||
                            _userRole.Equals("Quản trị viên", StringComparison.OrdinalIgnoreCase));

            btnBackup.Enabled = isAdmin;
            btnRestore.Enabled = isAdmin;
            grpData.Visible = isAdmin; // Ẩn luôn nếu không phải Admin, hoặc chỉ Disable tùy ý user. Chọn ẩn cho gọn.

            if (!isAdmin)
            {
                MessageBox.Show("Bạn không có quyền truy cập vào các cài đặt nâng cao này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Đóng form nếu không có quyền gì cả (hiện tại form chỉ có Data)
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog svf = new SaveFileDialog())
            {
                svf.Filter = "Backup Files (*.bak)|*.bak";
                svf.Title = "Sao lưu dữ liệu";
                if (svf.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var context = new LibraryContext())
                        {
                            string dbName = context.Database.GetDbConnection().Database;
                            string sql = $"BACKUP DATABASE [{dbName}] TO DISK = '{svf.FileName}'";
                            context.Database.ExecuteSqlRaw(sql);
                        }
                        MessageBox.Show("Sao lưu dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Sao lưu thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Cảnh báo: Phục hồi dữ liệu sẽ ghi đè toàn bộ dữ liệu hiện tại. Bạn có chắc chắn muốn tiếp tục?", "Xác nhận phục hồi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
            {
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Backup Files (*.bak)|*.bak";
                ofd.Title = "Phục hồi dữ liệu";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var context = new LibraryContext())
                        {
                            string dbName = context.Database.GetDbConnection().Database;
                            // Chuyển sang Master để restore
                            string sql = $@"
                                USE master;
                                ALTER DATABASE [{dbName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
                                RESTORE DATABASE [{dbName}] FROM DISK = '{ofd.FileName}' WITH REPLACE;
                                ALTER DATABASE [{dbName}] SET MULTI_USER;
                            ";
                            context.Database.ExecuteSqlRaw(sql);
                        }
                        MessageBox.Show("Phục hồi dữ liệu thành công! Ứng dụng sẽ khởi động lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Restart();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Phục hồi thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Mở lại form đăng nhập
                Login1 loginForm = new Login1();
                loginForm.Show();
                this.Close(); // Đóng form chính
            }
        }
    }
}
