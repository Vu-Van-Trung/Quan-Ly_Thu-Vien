#nullable disable
using LibraryManagement.Data;
using LibraryManagement.Models;
using LibraryManagement.Security;
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
            // 1. Load Sách (Giữ nguyên nếu Title không mã hóa)
            var books = db.Books.ToList();
            cbMaSach.DataSource = books;
            cbMaSach.DisplayMember = "Title";
            cbMaSach.ValueMember = "BookId";

            // 2. Load Độc Giả và GIẢI MÃ tên
            var members = db.Members.ToList();
            var memberDisplayList = members.Select(m => new
            {
                m.MemberId,
                // Sử dụng CryptoHelper để giải mã tên hiển thị
                DisplayName = CryptoHelper.Decrypt(m.FullName)
            }).ToList();

            cbMaDocGia.DataSource = memberDisplayList;
            cbMaDocGia.DisplayMember = "DisplayName"; // Sử dụng tên thuộc tính mới đã giải mã
            cbMaDocGia.ValueMember = "MemberId";
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
                        MemberName = CryptoHelper.Decrypt(l.Member.FullName),
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

            // Sử dụng null-conditional để an toàn hơn
            string loanId = dgvSachMuon.CurrentRow.Cells["LoanId"].Value?.ToString();

            if (MessageBox.Show($"Bạn chắc chắn muốn xóa phiếu {loanId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    // Sử dụng Include để lấy các chi tiết liên quan nếu Database không đặt Cascade Delete
                    var loan = db.Loans
                                 .Include(l => l.LoanDetails)
                                 .FirstOrDefault(l => l.LoanId == loanId);

                    if (loan != null)
                    {
                        // Kiểm tra trạng thái: Ví dụ không cho xóa phiếu đã hoàn thành/đang mượn tùy yêu cầu
                        // if (loan.TrangThai == "Đang mượn") { ... }

                        // Xóa các chi tiết phiếu mượn trước (nếu không cấu hình Cascade Delete trong SQL)
                        if (loan.LoanDetails != null)
                        {
                            db.LoanDetails.RemoveRange(loan.LoanDetails);
                        }

                        db.Loans.Remove(loan);
                        db.SaveChanges();

                        LoadData();
                        MessageBox.Show("✅ Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị lỗi chi tiết hơn (InnerException) nếu có
                    string errorMsg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                    MessageBox.Show("❌ Không thể xóa phiếu mượn này.\nChi tiết lỗi: " + errorMsg, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvSachMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}