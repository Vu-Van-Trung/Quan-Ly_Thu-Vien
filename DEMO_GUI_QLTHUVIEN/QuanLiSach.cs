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
                        b.GiaTien
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên sách!");
                return;
            }
            if (cboAuthor.SelectedIndex == -1 || cboCategory.SelectedIndex == -1 || cboPublisher.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Tác giả, Thể loại và Nhà xuất bản!");
                return;
            }

            // Get IDs
            int authorId = (int)cboAuthor.SelectedValue;
            int categoryId = (int)cboCategory.SelectedValue;
            int publisherId = (int)cboPublisher.SelectedValue;

            int? pubYear = null;
            if (int.TryParse(txtPublishedYear.Text, out int year))
            {
                pubYear = year;
            }

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
                        TrangThai = "Có sẵn",
                        NgayNhap = DateTime.Now
                    };

                    db.Books.Add(newBook);
                    db.SaveChanges();
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
            txtPublishedYear.Clear();
            if (cboAuthor.Items.Count > 0) cboAuthor.SelectedIndex = 0;
            if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
            if (cboPublisher.Items.Count > 0) cboPublisher.SelectedIndex = 0;
            txtLocation.Clear();
            numQuantity.Value = 0;
            numPrice.Value = 0;
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