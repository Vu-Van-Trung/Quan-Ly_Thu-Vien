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
        }

        private void RefreshGrid()
        {
            var authors = _authorService.GetAll();
            dgvAuthors.DataSource = authors.Select(a => new
            {
                a.AuthorId,
                a.Name,
                a.QuocTich,
                NgaySinh = a.NgaySinh?.ToString("dd/MM/yyyy"),
                a.Bio
            }).ToList();

            // Hide the ID column for cleaner UI
            if (dgvAuthors.Columns.Contains("AuthorId"))
                dgvAuthors.Columns["AuthorId"].Visible = false;
        }

        private void dgvAuthors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvAuthors.Rows[e.RowIndex];
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtQuocTich.Text = row.Cells["QuocTich"].Value?.ToString();
            // Parse the date string using the exact format we used when displaying it
            if (DateTime.TryParseExact(row.Cells["NgaySinh"].Value?.ToString(), "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out var dt))
                dtpNgaySinh.Value = dt;
            else
                dtpNgaySinh.Value = DateTime.Now;
            txtBio.Text = row.Cells["Bio"].Value?.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var author = new Author
            {
                Name = txtName.Text.Trim(),
                QuocTich = txtQuocTich.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                Bio = txtBio.Text.Trim()
            };
            _authorService.Add(author);
            RefreshGrid();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dgvAuthors.CurrentRow?.Cells["AuthorId"]?.Value?.ToString(), out var id))
            {
                MessageBox.Show("Vui lòng chọn một tác giả để cập nhật.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var author = new Author
            {
                AuthorId = id,
                Name = txtName.Text.Trim(),
                QuocTich = txtQuocTich.Text.Trim(),
                NgaySinh = dtpNgaySinh.Value,
                Bio = txtBio.Text.Trim()
            };
            _authorService.Update(author);
            RefreshGrid();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(dgvAuthors.CurrentRow?.Cells["AuthorId"]?.Value?.ToString(), out var id))
            {
                MessageBox.Show("Vui lòng chọn một tác giả để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bạn có chắc muốn xóa tác giả này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                _authorService.Delete(id);
                RefreshGrid();
                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearInputs();

        private void ClearInputs()
        {
            txtName.Clear();
            txtQuocTich.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            txtBio.Clear();
            dgvAuthors.ClearSelection();
        }
    }
}
