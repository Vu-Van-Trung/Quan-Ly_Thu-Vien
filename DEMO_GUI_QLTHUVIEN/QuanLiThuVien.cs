using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using System.IO;

namespace DoAnDemoUI
{
    public partial class QuanLiThuVien : Form
    {
        // Danh sách lưu trữ các chức năng menu
        private readonly List<MenuAction> _menuActions = new List<MenuAction>();
        private string _userRole;
        private bool _isLoggingOut = false;

        public QuanLiThuVien(string userRole = "Nhân viên")
        {
            InitializeComponent();
            _userRole = userRole;

            // QUAN TRỌNG: Đặt Form này làm Form cha (MDI Container)
            this.IsMdiContainer = true;

            // Khởi tạo danh sách menu
            SetupDefaultMenuActions();
            BuildModernMenu();

            this.FormClosed += QuanLiThuVien_FormClosed;
        }

        private void QuanLiThuVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void SetupDefaultMenuActions()
        {
            _menuActions.Clear();

            // --- ĐÃ CẬP NHẬT MENU ĐỂ KHỚP VỚI MODEL ---

            string iconPath = Path.Combine(Application.StartupPath, "Resources", "ModernIcons");
            // Lưu ý: Nếu chạy trong debug, Application.StartupPath có thể là bin/Debug. 
            // Chúng ta sẽ thử cả đường dẫn tương đối từ project nếu không thấy.
            if (!Directory.Exists(iconPath))
            {
                iconPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Resources", "ModernIcons");
            }

            // Existing menu actions
            // Use Security.AccessControl to filter

            if (Security.AccessControl.CanAccess("ManageBooks", _userRole))
                AddMenuAction("ManageBooks", "Quản lý Sách", "books_v2.png", () => OpenOrActivateChild(typeof(QuanLiSach)));

            if (Security.AccessControl.CanAccess("ManageMembers", _userRole))
                AddMenuAction("ManageMembers", "Quản lý Độc giả", "member_v2.png", () => OpenOrActivateChild(typeof(FormMember)));

            if (Security.AccessControl.CanAccess("ManageLoans", _userRole))
                AddMenuAction("ManageLoans", "Quản lý Mượn/Trả", "loan_v2.png", () => OpenOrActivateChild(typeof(FormLoan)));

            if (Security.AccessControl.CanAccess("ManageStaff", _userRole))
                AddMenuAction("ManageStaff", "Quản lý Nhân viên", "staff_v2.png", () => OpenOrActivateChild(typeof(FormStaff)));

            if (Security.AccessControl.CanAccess("ManagePublishers", _userRole))
                AddMenuAction("ManagePublishers", "Quản lý Nhà XB", "publisher_v2.png", () => OpenOrActivateChild(typeof(FormPublisher)));

            if (Security.AccessControl.CanAccess("ManageAuthors", _userRole))
                AddMenuAction("ManageAuthors", "Quản lý Tác Giả", "author_v2.png", () => OpenOrActivateChild(typeof(QuanLiTacGia)));

            if (Security.AccessControl.CanAccess("ManageFines", _userRole))
                AddMenuAction("ManageFines", "Phiếu Phạt & Trả Sách", "fine_v2.png", () => OpenOrActivateChild(typeof(FormFine)));

            if (Security.AccessControl.CanAccess("Reports", _userRole))
                AddMenuAction("Reports", "Báo cáo & Thống kê", "report_v2.png", () => OpenOrActivateChild(typeof(FormReport)));

            if (Security.AccessControl.CanAccess("ManageAccounts", _userRole))
                AddMenuAction("ManageAccounts", "Quản lý Tài Khoản", "account_v2.png", () => OpenOrActivateChild(typeof(DEMO_GUI_QLTHUVIEN.QuanLyTaiKhoan)));

            if (Security.AccessControl.CanAccess("ViewLogs", _userRole))
                AddMenuAction("ViewLogs", "Nhật Ký Hệ Thống", "log_v2.png", () => OpenOrActivateChild(typeof(QuanLiNhatKy)));

            if (Security.AccessControl.CanAccess("Settings", _userRole))
                AddMenuAction("Settings", "Cài đặt & Dữ liệu", "settings_v2.png", ShowSettingsForm);
        }

        private void ShowSettingsForm()

        {
            // Close other forms
            foreach (var child in this.MdiChildren)
            {
                if (!(child is FormSettings))
                {
                    child.Close();
                }
            }

            foreach (var child in this.MdiChildren)
            {
                if (child is FormSettings)
                {
                    child.BringToFront();
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;
                    return;
                }
            }

            FormSettings frm = new FormSettings(_userRole);
            frm.MdiParent = this;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }


        // --- CÁC HÀM HỖ TRỢ XỬ LÝ MENU ---

        public void AddMenuAction(string key, string displayName, string iconFileName, Action action)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));
            if (_menuActions.Any(a => string.Equals(a.Key, key, StringComparison.OrdinalIgnoreCase))) return;

            _menuActions.Add(new MenuAction
            {
                Key = key,
                DisplayName = displayName ?? key,
                IconFileName = iconFileName,
                Action = action
            });
        }

        private void BuildModernMenu()
        {
            pnlMenuContainer.Controls.Clear();

            foreach (var item in _menuActions)
            {
                Guna2Button btn = new Guna2Button();
                btn.Text = item.DisplayName;
                btn.Tag = item;
                btn.Width = pnlMenuContainer.Width - 30;
                btn.Height = 55;
                btn.Margin = new Padding(15, 10, 15, 10); // Better spacing
                btn.FillColor = Color.Transparent;
                btn.ForeColor = Color.White;
                btn.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                btn.TextAlign = HorizontalAlignment.Left;
                btn.TextOffset = new Point(15, 0);
                btn.BorderRadius = 12; // Rounded corners 12px
                btn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;

                // Hiệu ứng Indicator (Đường kẻ bên trái)
                btn.CustomBorderThickness = new Padding(5, 0, 0, 0);
                btn.BorderColor = Color.Transparent; // Mặc định không hiện

                btn.CheckedState.CustomBorderColor = Color.White;
                btn.CheckedState.FillColor = Color.FromArgb(192, 57, 43); // Darker Red for active

                // Hover Effects
                btn.HoverState.FillColor = Color.FromArgb(231, 76, 60);   // Brighter Red for hover
                btn.HoverState.CustomBorderColor = Color.FromArgb(255, 200, 200);

                btn.Cursor = Cursors.Hand;

                // Load Icon
                try
                {
                    string resourcePath = Path.Combine(Application.StartupPath, "Resources", "ModernIcons", item.IconFileName);
                    if (!File.Exists(resourcePath))
                    {
                        // Fallback for development/debug environments
                        resourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "Resources", "ModernIcons", item.IconFileName);
                    }

                    if (File.Exists(resourcePath))
                    {
                        btn.Image = Image.FromFile(resourcePath);
                        btn.ImageSize = new Size(35, 35);
                        btn.ImageAlign = HorizontalAlignment.Left;
                        btn.ImageOffset = new Point(5, 0);
                        btn.TextOffset = new Point(15, 0);
                    }
                }
                catch { /* Ignore icon load errors */ }

                btn.Click += (s, e) =>
                {
                    item.Action?.Invoke();
                };

                pnlMenuContainer.Controls.Add(btn);
            }
        }

        // --- HÀM MỞ FORM CON (QUAN TRỌNG) ---
        private void OpenOrActivateChild(Type childType)
        {
            // 1. Đóng tất cả các form con khác
            foreach (var child in this.MdiChildren)
            {
                if (child.GetType() != childType)
                {
                    child.Close();
                }
            }

            // 2. Kiểm tra xem Form cần mở dã tồn tại chưa (sau khi đã đóng các form khác)
            foreach (var child in this.MdiChildren)
            {
                if (child.GetType() == childType)
                {
                    child.BringToFront();
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;      
                    return;
                }
            }

            // 3. Nếu chưa mở thì khởi tạo mới
            try
            {
                Form frm = (Form)Activator.CreateInstance(childType);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.Manual;
                frm.WindowState = FormWindowState.Normal;
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show($"Không thể mở Form: {childType.Name}. Hãy chắc chắn bạn đã tạo Form này trong Project.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // --- CÁC SỰ KIỆN HỆ THỐNG ---

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _isLoggingOut = true;
                // Mở lại form đăng nhập
                Login1 loginForm = new Login1();
                loginForm.Show();
                this.Close(); // Đóng form chính
            }
        }

        private void mniThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ứng dụng?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void QuanLiThuVien_Load_1(object sender, EventArgs e)
        {
            // Đổi màu nền vùng chứa MDI Client cho đẹp hơn (màu xám nhạt)
            foreach (Control ctl in this.Controls)
            {
                if (ctl is MdiClient)
                {
                    ctl.BackColor = Color.FromArgb(240, 242, 245);
                }
            }
        }

        // Class nội bộ để lưu trữ thông tin Menu
        private class MenuAction
        {
            public string Key { get; set; }
            public string DisplayName { get; set; }
            public string IconFileName { get; set; }
            public Action Action { get; set; }

            public override string ToString() => DisplayName;
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Removed - using buttons now
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _isLoggingOut = true;
                // Mở lại form đăng nhập
                Login1 loginForm = new Login1();
                loginForm.Show();
                this.Close(); // Đóng form chính
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                _isLoggingOut = true;
                // Mở lại form đăng nhập
                Login1 loginForm = new Login1();
                loginForm.Show();
                this.Close(); // Đóng form chính
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _isLoggingOut = true;
                    // Mở lại form đăng nhập
                    Login1 loginForm = new Login1();
                    loginForm.Show();
                    this.Close(); // Đóng form chính
                }
            }
        }

        private void btnLogout_Click_2(object sender, EventArgs e)
        {
            {
                var result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    _isLoggingOut = true;
                    // Mở lại form đăng nhập
                    Login1 loginForm = new Login1();
                    loginForm.Show();
                    this.Close(); // Đóng form chính
                }
            }
        }
    }
}
