using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class QuanLiThuVien : Form
    {
        // Danh sách lưu trữ các chức năng menu
        private readonly List<MenuAction> _menuActions = new List<MenuAction>();
        private string _userRole;

        public QuanLiThuVien(string userRole = "Nhân viên")
        {
            InitializeComponent();
            _userRole = userRole;

            // QUAN TRỌNG: Đặt Form này làm Form cha (MDI Container)
            this.IsMdiContainer = true;

            // Cấu hình hiển thị cho ListBox Menu
            lstMenu.DisplayMember = nameof(MenuAction.DisplayName);
            lstMenu.ValueMember = nameof(MenuAction.Key);

            // Gán sự kiện cho ListBox
            lstMenu.DoubleClick += lstMenu_DoubleClick;
            lstMenu.KeyDown += lstMenu_KeyDown;

            // Khởi tạo danh sách menu
            SetupDefaultMenuActions();
            RefreshMenuList();
        }

        private void SetupDefaultMenuActions()
        {
            _menuActions.Clear();

            // --- ĐÃ CẬP NHẬT MENU ĐỂ KHỚP VỚI MODEL ---

            AddMenuAction("ManageBooks", "Quản lý Sách", () => OpenOrActivateChild(typeof(QuanLiSach)));
            //AddMenuAction("ManageAuthors", "Quản lý Tác giả", () => OpenOrActivateChild(typeof(FormAuthor)));
            //AddMenuAction("ManageCategories", "Quản lý Thể loại", () => OpenOrActivateChild(typeof(FormCategory)));
            AddMenuAction("ManageMembers", "Quản lý Độc giả", () => OpenOrActivateChild(typeof(FormMember)));
            AddMenuAction("ManageLoans", "Quản lý Mượn/Trả", () => OpenOrActivateChild(typeof(FormLoan)));
            AddMenuAction("ManageStaff", "Quản lý Nhân viên", () => OpenOrActivateChild(typeof(FormStaff)));
            AddMenuAction("ManagePublishers", "Quản lý Nhà XB", () => OpenOrActivateChild(typeof(FormPublisher)));
            AddMenuAction("Reports", "Báo cáo & Thống kê", () => OpenOrActivateChild(typeof(FormReport)));
            AddMenuAction("ManageFines", "Phiếu Phạt & Trả Sách", () => OpenOrActivateChild(typeof(FormFine)));

            // Thêm mục Cài đặt (chung cho mọi người, nhưng FormSettings sẽ tự kiểm tra quyền)
            AddMenuAction("Settings", "Cài đặt & Dữ liệu", ShowSettingsForm);
        }

        private void ShowSettingsForm()
        {
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

        public void AddMenuAction(string key, string displayName, Action action)
        {
            if (string.IsNullOrWhiteSpace(key)) throw new ArgumentNullException(nameof(key));
            if (_menuActions.Any(a => string.Equals(a.Key, key, StringComparison.OrdinalIgnoreCase))) return;

            _menuActions.Add(new MenuAction { Key = key, DisplayName = displayName ?? key, Action = action });
            RefreshMenuList();
        }

        private void RefreshMenuList()
        {
            var selectedKey = (lstMenu.SelectedItem as MenuAction)?.Key;
            lstMenu.DataSource = null;
            lstMenu.DataSource = _menuActions.ToList();
            lstMenu.DisplayMember = nameof(MenuAction.DisplayName);
            lstMenu.ValueMember = nameof(MenuAction.Key);

            if (!string.IsNullOrEmpty(selectedKey))
            {
                var toSelect = _menuActions.FirstOrDefault(a => string.Equals(a.Key, selectedKey, StringComparison.OrdinalIgnoreCase));
                if (toSelect != null) lstMenu.SelectedItem = toSelect;
            }
        }

        private void ExecuteSelectedAction()
        {
            var sel = lstMenu.SelectedItem as MenuAction;
            if (sel == null) return;

            try
            {
                sel.Action?.Invoke();
            }
            catch (Exception ex)
            {
                // Thông báo lỗi nếu chưa tạo Form con
                MessageBox.Show($"Chức năng '{sel.DisplayName}' chưa được cài đặt hoặc Form chưa được tạo!\nChi tiết: {ex.Message}",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstMenu_DoubleClick(object sender, EventArgs e)
        {
            ExecuteSelectedAction();
        }

        private void lstMenu_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteSelectedAction();
                e.Handled = true;
            }
        }

        // --- HÀM MỞ FORM CON (QUAN TRỌNG) ---
        private void OpenOrActivateChild(Type childType)
        {
            // 1. Kiểm tra xem Form đó đã mở chưa (để tránh mở nhiều lần)
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

            // 2. Nếu chưa mở thì khởi tạo mới
            // Sử dụng Activator.CreateInstance để tạo form động mà không cần if/else quá dài
            try
            {
                Form frm = (Form)Activator.CreateInstance(childType);

                // Thiết lập Form cha
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
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
                Application.Exit();
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
            public Action Action { get; set; }

            public override string ToString() => DisplayName;
        }

        private void lstMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!lstMenu.Focused)
            {
                return;
            }

            // future: preview info based on selection
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
