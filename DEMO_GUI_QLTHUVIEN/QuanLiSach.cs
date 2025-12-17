
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
            // Không cần LoadComboBoxes nữa vì ta nhập tay
            LoadData();
            SetControlState(false);
        }

        private void LoadData()
        {
            try
            {
                var books = db.Books
                    .Include(b => b.Author)
                    .Include(b => b.Category)
                    .Select(b => new
                    {
                        b.BookId,
                        b.Title,
                        b.ISBN,
                        b.PublishedYear,
                        AuthorName = b.Author.Name,     // Tên tác giả
                        CategoryName = b.Category.Name, // Tên thể loại
                        // Các ID ẩn (dù không dùng để chọn trên combo nữa nhưng vẫn cần để logic)
                        b.AuthorId,
                        b.CategoryId
                    })
                    .ToList();

                dgvBooks.DataSource = books;

                dgvBooks.Columns["BookId"].HeaderText = "Mã Sách";
                dgvBooks.Columns["Title"].HeaderText = "Tên Sách";
                dgvBooks.Columns["PublishedYear"].HeaderText = "Năm XB";
                dgvBooks.Columns["AuthorName"].HeaderText = "Tác Giả";
                dgvBooks.Columns["CategoryName"].HeaderText = "Thể Loại";

                dgvBooks.Columns["AuthorId"].Visible = false;
                dgvBooks.Columns["CategoryId"].Visible = false;
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

                txtBookId.Text = row.Cells["BookId"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value?.ToString();
                txtISBN.Text = row.Cells["ISBN"].Value?.ToString();
                txtPublishedYear.Text = row.Cells["PublishedYear"].Value?.ToString();

                // Hiển thị tên Tác giả và Thể loại vào TextBox
                txtAuthor.Text = row.Cells["AuthorName"].Value?.ToString();
                txtCategory.Text = row.Cells["CategoryName"].Value?.ToString();
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

            int bookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells["BookId"].Value);
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
        private int GetOrCreateAuthorId(string authorName)
        {
            authorName = authorName.Trim();
            // Tìm xem tác giả đã có chưa
            var author = db.Authors.FirstOrDefault(a => a.Name == authorName);
            if (author != null)
            {
                return author.AuthorId;
            }
            else
            {
                // Chưa có thì tạo mới
                var newAuthor = new Author { Name = authorName };
                db.Authors.Add(newAuthor);
                db.SaveChanges(); // Lưu để sinh ra ID
                return newAuthor.AuthorId;
            }
        }

        private int GetOrCreateCategoryId(string categoryName)
        {
            categoryName = categoryName.Trim();
            // Tìm xem thể loại đã có chưa
            var category = db.Categories.FirstOrDefault(c => c.Name == categoryName);
            if (category != null)
            {
                return category.CategoryId;
            }
            else
            {
                // Chưa có thì tạo mới
                var newCategory = new Category { Name = categoryName };
                db.Categories.Add(newCategory);
                db.SaveChanges(); // Lưu để sinh ra ID
                return newCategory.CategoryId;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên sách, Tác giả và Thể loại!");
                return;
            }

            int pubYear = 0;
            int.TryParse(txtPublishedYear.Text, out pubYear);

            try
            {
                // 1. Xử lý Tác giả và Thể loại (Tìm hoặc Tạo mới)
                int authorId = GetOrCreateAuthorId(txtAuthor.Text);
                int categoryId = GetOrCreateCategoryId(txtCategory.Text);

                // 2. Lưu Sách
                // THÊM MỚI
                if (txtBookId.Text == "(Tự động)" || string.IsNullOrEmpty(txtBookId.Text))
                {
                    var newBook = new Book
                    {
                        Title = txtTitle.Text.Trim(),
                        ISBN = txtISBN.Text.Trim(),
                        PublishedYear = pubYear,
                        AuthorId = authorId,     // Dùng ID vừa lấy được
                        CategoryId = categoryId  // Dùng ID vừa lấy được
                    };
                    db.Books.Add(newBook);
                    db.SaveChanges();
                    MessageBox.Show("Thêm sách thành công!");
                }
                // CẬP NHẬT
                else
                {
                    int bookId = int.Parse(txtBookId.Text);
                    var book = db.Books.Find(bookId);
                    if (book != null)
                    {
                        book.Title = txtTitle.Text.Trim();
                        book.ISBN = txtISBN.Text.Trim();
                        book.PublishedYear = pubYear;
                        book.AuthorId = authorId;
                        book.CategoryId = categoryId;

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
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
                .Where(b => b.Title.Contains(keyword) || b.ISBN.Contains(keyword))
                .Select(b => new
                {
                    b.BookId,
                    b.Title,
                    b.ISBN,
                    b.PublishedYear,
                    AuthorName = b.Author.Name,
                    CategoryName = b.Category.Name,
                    b.AuthorId,
                    b.CategoryId
                })
                .ToList();

            dgvBooks.DataSource = result;
        }

        private void SetControlState(bool editing)
        {
            txtTitle.ReadOnly = !editing;
            txtISBN.ReadOnly = !editing;
            txtPublishedYear.ReadOnly = !editing;
            txtAuthor.ReadOnly = !editing;   // Giờ là TextBox nên dùng ReadOnly
            txtCategory.ReadOnly = !editing; // Giờ là TextBox nên dùng ReadOnly

            btnAdd.Enabled = !editing;
            btnEdit.Enabled = !editing;
            btnDelete.Enabled = !editing;

            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;

            dgvBooks.Enabled = !editing;
        }

        private void ClearInputs()
        {
            txtBookId.Clear();
            txtTitle.Clear();
            txtISBN.Clear();
            txtPublishedYear.Clear();
            txtAuthor.Clear();
            txtCategory.Clear();
        }
    }
}