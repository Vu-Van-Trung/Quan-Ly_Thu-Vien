  // Chứa LibraryContext
using LibraryManagement.Data;
using LibraryManagement.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class FormLoan : Form
    {
        private LibraryContext db;
        private BindingSource bindingSource;

        public FormLoan()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
        }

        // --- 1. HÀM LOAD KHI MỞ FORM ---
        private void FormLoan_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadData();

            // Gắn bindingSource vào DataGridView
            dgvSachMuon.DataSource = bindingSource;

            // Xử lý sự kiện khi chọn dòng trên lưới
            dgvSachMuon.SelectionChanged += DgvSachMuon_SelectionChanged;

            // Load ComboBox Sách và Độc Giả
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            // Load Sách
            cbMaSach.DataSource = db.Books.ToList();
            cbMaSach.DisplayMember = "Title"; // Hiển thị tên sách
            cbMaSach.ValueMember = "BookId";  // Giá trị là ID sách

            // Load Độc Giả
            cbMaDocGia.DataSource = db.Members.ToList();
            cbMaDocGia.DisplayMember = "FullName"; // Hiển thị tên độc giả
            cbMaDocGia.ValueMember = "MemberId";   // Giá trị là ID độc giả
        }

        private void LoadData()
        {
            try
            {
                // Lấy dữ liệu từ bảng Loans, kèm theo thông tin Sách và Độc giả
                var data = db.Loans
                    .Include(l => l.Book)
                    .Include(l => l.Member)
                    .Select(l => new
                    {
                        l.LoanId,
                        BookName = l.Book.Title,
                        MemberName = l.Member.FullName,
                        l.LoanDate,
                        l.DueDate,
                        // Nếu ReturnDate null thì hiển thị "Chưa trả"
                        Status = l.ReturnDate == null ? "Đang Mượn" : "Đã Trả"
                    })
                    .ToList();

                bindingSource.DataSource = data;
                UpdateIndex();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // --- 2. SỰ KIỆN KHI CHỌN DÒNG TRÊN LƯỚI ---
        private void DgvSachMuon_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSachMuon.CurrentRow != null)
            {
                // Lấy ID của dòng đang chọn
                var currentLoanId = (int)dgvSachMuon.CurrentRow.Cells["LoanId"].Value;

                // Tìm trong DB để fill ngược lại lên các ô nhập liệu
                var loan = db.Loans.Find(currentLoanId);
                if (loan != null)
                {
                    cbMaSach.SelectedValue = loan.BookId;
                    cbMaDocGia.SelectedValue = loan.MemberId;
                    dtpNgayMuon.Value = loan.LoanDate;
                    dtpNgayTra.Value = loan.DueDate;
                }
                UpdateIndex();
            }
        }

        private void UpdateIndex()
        {
            if (bindingSource != null && bindingSource.Count > 0)
                txtIndex.Text = $"{bindingSource.Position + 1} / {bindingSource.Count}";
            else
                txtIndex.Text = "0 / 0";
        }

        // --- 3. CHỨC NĂNG THÊM ---
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var newLoan = new Loan
                {
                    BookId = (int)cbMaSach.SelectedValue,
                    MemberId = (int)cbMaDocGia.SelectedValue,
                    LoanDate = dtpNgayMuon.Value,
                    DueDate = dtpNgayTra.Value,
                    ReturnDate = null // Mới mượn thì chưa trả
                };

                db.Loans.Add(newLoan);
                db.SaveChanges();

                LoadData();
                MessageBox.Show("Thêm phiếu mượn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // --- 4. CHỨC NĂNG SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSachMuon.CurrentRow == null) return;
            int loanId = (int)dgvSachMuon.CurrentRow.Cells["LoanId"].Value;

            var loan = db.Loans.Find(loanId);
            if (loan != null)
            {
                loan.BookId = (int)cbMaSach.SelectedValue;
                loan.MemberId = (int)cbMaDocGia.SelectedValue;
                loan.LoanDate = dtpNgayMuon.Value;
                loan.DueDate = dtpNgayTra.Value;

                db.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công!");
            }
        }

        // --- 5. CHỨC NĂNG XÓA ---
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSachMuon.CurrentRow == null) return;
            int loanId = (int)dgvSachMuon.CurrentRow.Cells["LoanId"].Value;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var loan = db.Loans.Find(loanId);
                if (loan != null)
                {
                    db.Loans.Remove(loan);
                    db.SaveChanges();
                    LoadData();
                }
            }
        }

        // --- 6. CÁC NÚT ĐIỀU HƯỚNG ---
        private void btnDau_Click(object sender, EventArgs e) { bindingSource.MoveFirst(); }
        private void btnTruoc_Click(object sender, EventArgs e) { bindingSource.MovePrevious(); }
        private void btnSau_Click(object sender, EventArgs e) { bindingSource.MoveNext(); }
        private void btnCuoi_Click(object sender, EventArgs e) { bindingSource.MoveLast(); }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}