// QuanLiTacGia.cs
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Models;
using DEMO_GUI_QLTHUVIEN.Services;
using Guna.UI2.WinForms;
using System.Globalization;

namespace DoAnDemoUI
{
    public partial class QuanLiTacGia : Form
    {
        private readonly AuthorService _authorService = new AuthorService();

        public QuanLiTacGia()
        {
            InitializeComponent();
        }

        private void QuanLiTacGia_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            // Attach Validation Events
            txtName.TextChanged += (s, ev) => ValidateForm();
            txtQuocTich.TextChanged += (s, ev) => ValidateForm();
            txtBio.TextChanged += (s, ev) => ValidateForm();
            dtpNgaySinh.ValueChanged += (s, ev) => ValidateForm();
        }

        private bool ValidateForm()
        {
            lblError.Text = "";
            bool isValid = true;
            string errorMsg = "";

            // 1. Tên tác giả
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                // errorMsg = "Tên tác giả không được để trống."; // Only show if interacting?
                // For real-time feedback, usually we show nothing if empty unless triggered by save
            }
            else if (!System.Text.RegularExpressions.Regex.IsMatch(name, @"^[\p{L}\s]+$"))
            {
                errorMsg = "Tên tác giả chỉ được chứa chữ cái và khoảng trắng.";
                isValid = false;
            }

            // 2. Quốc tịch
            string quocTich = txtQuocTich.Text.Trim();
            if (isValid && !string.IsNullOrEmpty(quocTich))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(quocTich, @"^[\p{L}\s]+$"))
                {
                    errorMsg = "Quốc tịch chỉ được chứa chữ cái và khoảng trắng.";
                    isValid = false;
                }
                else if (quocTich.Length > 50)
                {
                    errorMsg = "Quốc tịch tối đa 50 ký tự.";
                    isValid = false;
                }
            }

            // 3. Ngày sinh
            if (isValid)
            {
                DateTime dob = dtpNgaySinh.Value;
                if (dob > DateTime.Now)
                {
                    errorMsg = "Ngày sinh không được lớn hơn ngày hiện tại.";
                    isValid = false;
                }
                else
                {
                    int age = DateTime.Now.Year - dob.Year;
                    if (dob > DateTime.Now.AddYears(-age)) age--;
                    if (age < 18)
                    {
                        errorMsg = "Tác giả phải từ 18 tuổi trở lên.";
                        isValid = false;
                    }
                }
            }

            // 4. Tiểu sử
            if (isValid && txtBio.Text.Length > 2000)
            {
                errorMsg = "Tiểu sử không được quá 2000 ký tự.";
                isValid = false;
            }

            lblError.Text = errorMsg;
            return isValid;
        }

        private bool CheckInputsForSave()
        {
            // Initial check for required fields that might be empty
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQuocTich.Text))
            {
                 MessageBox.Show("Vui lòng nhập quốc tịch!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }

            // Re-run the validation logic to catch specific format errors
            if (!ValidateForm())
            {
                 MessageBox.Show(lblError.Text, "Lỗi Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return false;
            }
            return true;
        }

        private void RefreshGrid()
        {
            var authors = _authorService.GetAll();
            dgvAuthors.DataSource = authors.Select(a => new
            {
                a.AuthorId,
                a.Name,
                NgaySinh = a.NgaySinh?.ToString("dd/MM/yyyy"),
                a.QuocTich,
                a.Bio
            }).ToList();

            // Configure Columns
            if (dgvAuthors.Columns["AuthorId"] != null) dgvAuthors.Columns["AuthorId"].HeaderText = "Mã Tác Giả";
            if (dgvAuthors.Columns["Name"] != null) dgvAuthors.Columns["Name"].HeaderText = "Tên Tác Giả";
            if (dgvAuthors.Columns["NgaySinh"] != null) dgvAuthors.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            if (dgvAuthors.Columns["QuocTich"] != null) dgvAuthors.Columns["QuocTich"].HeaderText = "Quốc Tịch";
            if (dgvAuthors.Columns["Bio"] != null) dgvAuthors.Columns["Bio"].HeaderText = "Tiểu Sử";
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvAuthors.Rows[e.RowIndex];
            txtMa.Text = row.Cells["AuthorId"].Value?.ToString();
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtQuocTich.Text = row.Cells["QuocTich"].Value?.ToString();
            // Parse the date string using the exact format we used when displaying it
            if (DateTime.TryParseExact(row.Cells["NgaySinh"].Value?.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var dt))
                dtpNgaySinh.Value = dt;
            else
                dtpNgaySinh.Value = DateTime.Now;
            txtBio.Text = row.Cells["Bio"].Value?.ToString();
            ValidateForm(); // Reset/Check validation on load
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckInputsForSave()) return;

            var author = new Author
            {
                Name = txtName.Text.Trim(),
                QuocTich = txtQuocTich.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                Bio = txtBio.Text.Trim()
            };
            _authorService.Add(author);
            
            // Log
            DoAnDemoUI.Services.Logger.Log("Quản lý Tác Giả", "Thêm mới", $"Thêm tác giả: {author.Name}");

            RefreshGrid();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMa.Text, out var id))
            {
                MessageBox.Show("Vui lòng chọn một tác giả để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (!CheckInputsForSave()) return;

            var author = new Author
            {
                AuthorId = id,
                Name = txtName.Text.Trim(),
                QuocTich = txtQuocTich.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                Bio = txtBio.Text.Trim()
            };
            _authorService.Update(author);

            // Log
            DoAnDemoUI.Services.Logger.Log("Quản lý Tác Giả", "Cập nhật", $"Cập nhật tác giả: {author.Name} (ID: {id})");

            RefreshGrid();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMa.Text, out var id))
            {
                MessageBox.Show("Vui lòng chọn một tác giả để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _authorService.Delete(id);
                
                // Log
                DoAnDemoUI.Services.Logger.Log("Quản lý Tác Giả", "Xóa", $"Xóa tác giả ID: {id}");

                RefreshGrid();
                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();

        private void ClearInputs()
        {
            txtMa.Clear();
            txtName.Clear();
            txtQuocTich.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtBio.Clear();
            lblError.Text = "";
            dgvAuthors.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAuthors_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void txtMa_TextChanged(object sender, EventArgs e) { }
        private void lblTen_Click(object sender, EventArgs e) { }
    }
}

