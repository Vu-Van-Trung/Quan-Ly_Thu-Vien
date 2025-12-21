#nullable disable
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
        private int defaultStaffId = 1; // ID nhân viên mặc định - thay đổi theo nhu cầu

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
            var books = db.Books.ToList();
            cbMaSach.DataSource = books;
            cbMaSach.DisplayMember = "Title"; // Hiển thị tên sách
            cbMaSach.ValueMember = "BookId";  // Giá trị là ID sách (string)

            // Load Độc Giả
            var members = db.Members.ToList();
            cbMaDocGia.DataSource = members;
            cbMaDocGia.DisplayMember = "FullName"; // Hiển thị tên độc giả
            cbMaDocGia.ValueMember = "MemberId";   // Giá trị là ID độc giả (string)
        }

        public void LoadData()
        {
            try
            {
                // Lấy dữ liệu từ bảng Loans, kèm theo thông tin Sách và Độc giả
                var data = db.Loans
                    .Include(l => l.Member)
                    .Include(l => l.LoanDetails)
                        .ThenInclude(ld => ld.Book)
                    .Select(l => new
                    {
                        l.LoanId,
                        MemberName = l.Member.FullName,
                        l.LoanDate,
                        l.DueDate,
                        // Sử dụng NgayTraThucTe thay vì ReturnDate
                        Status = l.NgayTraThucTe == null ? "Đang Mượn" : "Đã Trả",
                        BookCount = l.LoanDetails.Count
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
            if (dgvSachMuon.CurrentRow != null && dgvSachMuon.CurrentRow.Cells["LoanId"].Value != null)
            {
                // Lấy ID của dòng đang chọn (LoanId là string)
                var currentLoanId = dgvSachMuon.CurrentRow.Cells["LoanId"].Value.ToString();

                // Tìm trong DB để fill ngược lại lên các ô nhập liệu
                var loan = db.Loans
                    .Include(l => l.LoanDetails)
                    .FirstOrDefault(l => l.LoanId == currentLoanId);

                if (loan != null)
                {
                    cbMaDocGia.SelectedValue = loan.MemberId;
                    dtpNgayMuon.Value = loan.LoanDate;
                    dtpNgayTra.Value = loan.DueDate;

                    // Nếu có sách trong chi tiết, chọn sách đầu tiên
                    if (loan.LoanDetails != null && loan.LoanDetails.Any())
                    {
                        var firstBook = loan.LoanDetails.First();
                        cbMaSach.SelectedValue = firstBook.BookId;
                    }
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
                // Tạo mã phiếu mượn tự động
                string newLoanId = GenerateLoanId();

                var newLoan = new Loan
                {
                    LoanId = newLoanId,
                    MemberId = cbMaDocGia.SelectedValue.ToString(),
                    StaffId = defaultStaffId, // Sử dụng staff ID mặc định
                    LoanDate = dtpNgayMuon.Value,
                    DueDate = dtpNgayTra.Value,
                    NgayTraThucTe = null, // Mới mượn thì chưa trả
                    TrangThai = "Đang mượn"
                };

                db.Loans.Add(newLoan);

                // Thêm chi tiết phiếu mượn cho sách được chọn
                var loanDetail = new LoanDetail
                {
                    LoanId = newLoanId,
                    BookId = cbMaSach.SelectedValue.ToString(),
                    SoLuong = 1,
                    TinhTrangMuon = "Tốt"
                };
                db.LoanDetails.Add(loanDetail);

                db.SaveChanges();

                LoadData();
                MessageBox.Show("Thêm phiếu mượn thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        // Hàm tạo mã phiếu mượn tự động
        private string GenerateLoanId()
        {
            var lastLoan = db.Loans.OrderByDescending(l => l.LoanId).FirstOrDefault();
            if (lastLoan == null)
            {
                return "PM001";
            }

            // Lấy số từ mã cuối cùng và tăng lên 1
            string lastId = lastLoan.LoanId;
            int number = int.Parse(lastId.Substring(2)) + 1;
            return $"PM{number:D3}";
        }

        // --- 4. CHỨC NĂNG SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSachMuon.CurrentRow == null || dgvSachMuon.CurrentRow.Cells["LoanId"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần sửa!");
                return;
            }

            string loanId = dgvSachMuon.CurrentRow.Cells["LoanId"].Value.ToString();

            var loan = db.Loans.Find(loanId);
            if (loan != null)
            {
                loan.MemberId = cbMaDocGia.SelectedValue.ToString();
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
            if (dgvSachMuon.CurrentRow == null || dgvSachMuon.CurrentRow.Cells["LoanId"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần xóa!");
                return;
            }

            string loanId = dgvSachMuon.CurrentRow.Cells["LoanId"].Value.ToString();

            if (MessageBox.Show("Bạn chắc chắn muốn xóa phiếu này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    var loan = db.Loans.Find(loanId);
                    if (loan != null)
                    {
                        db.Loans.Remove(loan);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa phiếu mượn này.\nLỗi: " + ex.Message);
                }
            }
        }

        // --- NEW: CHỨC NĂNG TRẢ SÁCH (Link to FormFine) ---
        private void btnTraSach_Click(object sender, EventArgs e)
        {
            if (dgvSachMuon.CurrentRow == null || dgvSachMuon.CurrentRow.Cells["LoanId"].Value == null)
            {
                MessageBox.Show("Vui lòng chọn phiếu mượn cần trả!");
                return;
            }

            string loanId = dgvSachMuon.CurrentRow.Cells["LoanId"].Value.ToString();

            // Mở FormFine và truyền ID
            FormFine frmFine = new FormFine(loanId);
            frmFine.MdiParent = this.MdiParent; // Set same parent if MDI
            frmFine.Show();
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