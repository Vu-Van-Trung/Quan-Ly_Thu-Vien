    #nullable disable
using LibraryManagement.Data;
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class QuanLiSach : Form
    {
        private LibraryContext db;
        private bool isEditing = false;

        public QuanLiSach()
        {
            InitializeComponent();

            this.Load += QuanLiSach_Load;
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSave.Click += BtnSave_Click;
            btnCancel.Click += BtnCancel_Click;
            btnSearch.Click += BtnSearch_Click;
            btnReload.Click += (s, e) => { LoadData(); txtSearch.Clear(); };
            dgvBooks.SelectionChanged += DgvBooks_SelectionChanged;

        }

        private void QuanLiSach_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadComboBoxes();
            LoadData();
            SetControlState(false);

            // Hook up validation events
            txtTitle.TextChanged += (s, ev) => ValidateForm(false);
            txtPublishedYear.TextChanged += (s, ev) => ValidateForm(false);
            cboAuthor.SelectedIndexChanged += (s, ev) => ValidateForm(false);
            cboCategory.SelectedIndexChanged += (s, ev) => ValidateForm(false);
            cboPublisher.SelectedIndexChanged += (s, ev) => ValidateForm(false);
            txtLocation.TextChanged += (s, ev) => ValidateForm(false);
            numQuantity.ValueChanged += (s, ev) => ValidateForm(false);
            numPrice.ValueChanged += (s, ev) => ValidateForm(false);
        }


        private void LoadComboBoxes()
        {
            cboAuthor.DataSource = db.Authors.ToList();
            cboAuthor.DisplayMember = "Name";
            cboAuthor.ValueMember = "AuthorId";

            cboCategory.DataSource = db.Categories.ToList();
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember = "CategoryId";

            cboPublisher.DataSource = db.Publishers.ToList();
            cboPublisher.DisplayMember = "TenNhaXuatBan";
            cboPublisher.ValueMember = "PublisherId";

            // Status
            cboStatus.Items.Clear();
            cboStatus.Items.Add("Có sẵn");
            cboStatus.Items.Add("Hết sách");
            cboStatus.Items.Add("Ngừng lưu hành");
            cboStatus.SelectedIndex = 0;
        }

        private void LoadData()
        {
            try
            {
                var books = db.Books
                    .AsNoTracking()
                    .Include(b => b.Author)
                    .Include(b => b.Category)
                    .Include(b => b.Publisher)
                    .Select(b => new
                    {
                        b.BookId,
                        b.Title,
                        b.PublishedYear,
                        AuthorName = b.Author.Name,
                        CategoryName = b.Category.Name,
                        PublisherName = b.Publisher.TenNhaXuatBan,
                        b.AuthorId,
                        b.CategoryId,
                        b.PublisherId,
                        b.ViTri,
                        b.SoLuongTon,
                        b.GiaTien,
                        b.TrangThai
                    })
                    .ToList();

                dgvBooks.DataSource = books;

                dgvBooks.Columns["BookId"].HeaderText = "Mã Sách";
                dgvBooks.Columns["Title"].HeaderText = "Tên Sách";
                dgvBooks.Columns["PublishedYear"].HeaderText = "Năm XB";
                dgvBooks.Columns["AuthorName"].HeaderText = "Tác Giả";
                dgvBooks.Columns["CategoryName"].HeaderText = "Thể Loại";
                dgvBooks.Columns["PublisherName"].HeaderText = "NXB";
                dgvBooks.Columns["ViTri"].HeaderText = "Vị Trí";
                dgvBooks.Columns["SoLuongTon"].HeaderText = "Số Lượng";
                dgvBooks.Columns["GiaTien"].HeaderText = "Giá Tiền";
                dgvBooks.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvBooks.Columns["GiaTien"].DefaultCellStyle.Format = "N0";

                dgvBooks.Columns["AuthorId"].Visible = false;
                dgvBooks.Columns["CategoryId"].Visible = false;
                dgvBooks.Columns["PublisherId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null && !isEditing)
            {
                var row = dgvBooks.CurrentRow;

                txtBookId.Text = row.Cells["BookId"].Value?.ToString();
                txtTitle.Text = row.Cells["Title"].Value?.ToString();
                txtPublishedYear.Text = row.Cells["PublishedYear"].Value?.ToString();

                // Bind ComboBoxes
                if (row.Cells["AuthorId"].Value != null)
                    cboAuthor.SelectedValue = row.Cells["AuthorId"].Value;
                
                if (row.Cells["CategoryId"].Value != null)
                    cboCategory.SelectedValue = row.Cells["CategoryId"].Value;

                if (row.Cells["PublisherId"].Value != null)
                    cboPublisher.SelectedValue = row.Cells["PublisherId"].Value;

                // Bind new fields
                txtLocation.Text = row.Cells["ViTri"].Value?.ToString();
                
                if (row.Cells["SoLuongTon"].Value != null && int.TryParse(row.Cells["SoLuongTon"].Value.ToString(), out int qty))
                    numQuantity.Value = qty;
                else
                    numQuantity.Value = 0;

                if (row.Cells["GiaTien"].Value != null && decimal.TryParse(row.Cells["GiaTien"].Value.ToString(), out decimal price))
                    numPrice.Value = price;
                else
                    numPrice.Value = 0;

                if (row.Cells["TrangThai"].Value != null)
                    cboStatus.SelectedItem = row.Cells["TrangThai"].Value.ToString();

            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            isEditing = true;
            SetControlState(true);
            ClearInputs();
            txtBookId.Text = "(Tự động)";
            txtTitle.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sách cần sửa!");
                return;
            }
            isEditing = true;
            SetControlState(true);
            txtTitle.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null) return;

            string bookId = dgvBooks.CurrentRow.Cells["BookId"].Value.ToString();
            string title = dgvBooks.CurrentRow.Cells["Title"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa sách '{title}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var book = db.Books.Find(bookId);
                    if (book != null)
                    {
                        db.Books.Remove(book);
                        db.SaveChanges();
                        
                        // Log
                        Services.Logger.Log("Quản lý Sách", "Xóa", $"Xóa sách: {book.Title} ({book.BookId})");

                        LoadData();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa sách này (có thể do đang được mượn).\nLỗi: " + ex.Message);
                }
            }
        }

        // --- HÀM QUAN TRỌNG: LẤY HOẶC TẠO ID MỚI ---


        // Hàm tạo mã sách tự động
        private string GenerateBookId()
        {
            var maxNumber = db.Books
                .AsNoTracking()
                .Select(b => b.BookId)
                .AsEnumerable()
                .Select(ParseBookNumber)
                .DefaultIfEmpty(0)
                .Max();

            return $"S{maxNumber + 1:D3}";
        }

        private static int ParseBookNumber(string bookId)
        {
            if (string.IsNullOrWhiteSpace(bookId) || bookId.Length <= 1)
            {
                return 0;
            }

            return int.TryParse(bookId.Substring(1), out var number) ? number : 0;
        }

        private bool ValidateForm(bool showMessageBox)
        {
            lblError.Text = "";
            string error = "";

            // 1. Tên sách
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
                error = "Tên sách là bắt buộc!";
            else if (txtTitle.Text.Length < 3 || txtTitle.Text.Length > 200)
                error = "Tên sách phải từ 3 đến 200 ký tự!";
            else if (!System.Text.RegularExpressions.Regex.IsMatch(txtTitle.Text, @"^[\p{L}\p{N}\s]+$"))
                error = "Tên sách chỉ được chứa chữ, số và khoảng trắng!";

            // 2. Tác giả
            else if (cboAuthor.SelectedIndex == -1)
                error = "Vui lòng chọn tác giả!";

            // 3. Thể loại
            else if (cboCategory.SelectedIndex == -1)
                error = "Vui lòng chọn thể loại!";

            // 4. Nhà xuất bản
            else if (cboPublisher.SelectedIndex == -1)
                error = "Vui lòng chọn nhà xuất bản!";

            // 5. Năm xuất bản
            else if (!int.TryParse(txtPublishedYear.Text, out int year))
                 error = "Năm xuất bản không hợp lệ!";
            else if (year > DateTime.Now.Year + 1)
                error = "Năm xuất bản không được lớn hơn năm sau!";
            else if (year < 1000)
                error = "Năm xuất bản phải lớn hơn hoặc bằng 1000!";

            // 6. Số lượng tồn
            else if (numQuantity.Value < 0)
                error = "Số lượng tồn không được âm!";

            // 7. Vị trí
            else if (!string.IsNullOrEmpty(txtLocation.Text) && !System.Text.RegularExpressions.Regex.IsMatch(txtLocation.Text, @"^[\p{L}\p{N}]+$"))
                error = "Vị trí chỉ được chứa chữ và số!";

            // 8. Giá tiền
            else if (numPrice.Value < 0)
                 error = "Giá tiền không được âm!";

            if (!string.IsNullOrEmpty(error))
            {
                lblError.Text = error;
                if (showMessageBox) MessageBox.Show(error, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm(true)) return;
            
            // Get IDs
            int authorId = (int)cboAuthor.SelectedValue;
            int categoryId = (int)cboCategory.SelectedValue;
            int publisherId = (int)cboPublisher.SelectedValue;

            int? pubYear = null;
            if (int.TryParse(txtPublishedYear.Text, out int year))
            {
                pubYear = year;
            }

            string selectedStatus = cboStatus.SelectedItem?.ToString() ?? "Có sẵn";

            try
            {
                // 2. Lưu Sách
                // THÊM MỚI
                if (txtBookId.Text == "(Tự động)" || string.IsNullOrEmpty(txtBookId.Text))
                {
                    db.ChangeTracker.Clear();
                    var newId = GenerateBookId();
                    var newBook = new Book
                    {
                        BookId = newId,
                        Title = txtTitle.Text.Trim(),
                        PublishedYear = pubYear,
                        AuthorId = authorId,
                        CategoryId = categoryId,
                        PublisherId = publisherId,
                        ViTri = txtLocation.Text.Trim(),
                        SoLuongTon = (int)numQuantity.Value,
                        GiaTien = numPrice.Value,
                        TrangThai = selectedStatus,
                        NgayNhap = DateTime.Now
                    };

                    db.Books.Add(newBook);
                    db.SaveChanges();
                    
                    // Log
                    Services.Logger.Log("Quản lý Sách", "Thêm mới", $"Thêm sách: {newBook.Title} ({newBook.BookId})");
                    MessageBox.Show("Thêm sách thành công!");
                }
                // CẬP NHẬT
                else
                {
                    string bookId = txtBookId.Text;
                    var book = db.Books.Find(bookId);
                    if (book != null)
                    {
                        book.Title = txtTitle.Text.Trim();
                        book.PublishedYear = pubYear;
                        book.AuthorId = authorId;
                        book.CategoryId = categoryId;
                        book.PublisherId = publisherId;
                        book.ViTri = txtLocation.Text.Trim();
                        book.SoLuongTon = (int)numQuantity.Value;
                        book.GiaTien = numPrice.Value;
                        book.TrangThai = selectedStatus;

                        db.SaveChanges();

                        // Log
                        Services.Logger.Log("Quản lý Sách", "Cập nhật", $"Cập nhật sách: {book.Title} ({book.BookId})");
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isEditing = false;
            SetControlState(false);
            DgvBooks_SelectionChanged(null, null);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            var result = db.Books
                .Include(b => b.Author)
                .Include(b => b.Category)
                .Include(b => b.Publisher)
                .Where(b => b.Title.ToLower().Contains(keyword) ||
                           b.BookId.ToLower().Contains(keyword))
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.PublishedYear,
                    AuthorName = b.Author.Name,
                    CategoryName = b.Category.Name,
                    PublisherName = b.Publisher.TenNhaXuatBan,
                    b.AuthorId,
                    b.CategoryId,
                    b.PublisherId
                })
                .ToList();

            dgvBooks.DataSource = result;
        }

        private void SetControlState(bool editing)
        {
            txtTitle.ReadOnly = !editing;
            txtPublishedYear.ReadOnly = !editing;
            
            cboAuthor.Enabled = editing;
            cboCategory.Enabled = editing;
            cboPublisher.Enabled = editing;

            txtLocation.ReadOnly = !editing;
            numQuantity.Enabled = editing;
            numPrice.Enabled = editing;
            cboStatus.Enabled = editing;

            bool isStaff = DoAnDemoUI.Services.Session.CurrentRole == DoAnDemoUI.Security.AccessControl.RoleStaff;

            btnAdd.Enabled = !editing && !isStaff;
            btnEdit.Enabled = !editing && !isStaff;
            btnDelete.Enabled = !editing && !isStaff;

            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;

            dgvBooks.Enabled = !editing;
        }

        private void ClearInputs()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtPublishedYear.Clear();
            if (cboAuthor.Items.Count > 0) cboAuthor.SelectedIndex = 0;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            if (cboPublisher.Items.Count > 0) cboPublisher.SelectedIndex = 0;
            txtLocation.Clear();
            numQuantity.Value = 0;
            numPrice.Value = 0;
            if (cboStatus.Items.Count > 0) cboStatus.SelectedIndex = 0;
        }

        private void QuanLiSach_Load_1(object sender, EventArgs e)
        {

        }



        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}