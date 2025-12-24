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
                // 1. Fetch raw data first (Server Side)
                var rawData = db.Loans
                    .Include(l => l.Member)
                    .Include(l => l.LoanDetails)
                        .ThenInclude(ld => ld.Book)
                    .ToList(); // Execute SQL here

                // 2. Process data in memory (Client Side)
                var data = rawData.Select(l => new
                {
                    l.LoanId,
                    MemberName = CryptoHelper.Decrypt(l.Member.FullName),
                    l.LoanDate,
                    l.DueDate,
                    Status = l.NgayTraThucTe == null ? "Đang Mượn" : "Đã Trả",
                    BookCount = l.LoanDetails.Count
                })
                    .OrderBy(x => x.MemberName) // Sort by decrypted name
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
                var currentLoanId = dgvSachMuon.CurrentRow.Cells["LoanId"].Value.ToString();
                var loan = db.Loans
                    .Include(l => l.LoanDetails)
                    .ThenInclude(ld => ld.Book)
                    .FirstOrDefault(l => l.LoanId == currentLoanId);

                if (loan != null && dgvChiTiet != null)
                {
                    // 1. Cấu hình chung cho DataGridView đẹp hơn
                    ConfigureBeautifulGrid(dgvChiTiet);

                    // 2. Gán dữ liệu với tên thuộc tính rõ ràng
                    dgvChiTiet.DataSource = loan.LoanDetails.Select(d => new
                    {
                        STT = loan.LoanDetails.ToList().IndexOf(d) + 1,
                        MaSach = d.BookId,
                        TenSach = d.Book?.Title,
                        TinhTrang = d.TinhTrangMuon,
                        TrangThai = d.NgayTra != null ? "✅ Đã trả" : "📖 Đang mượn"
                    }).ToList();

                    // 3. Định dạng chi tiết từng cột
                    if (dgvChiTiet.Columns.Count > 0)
                    {
                        dgvChiTiet.Columns["STT"].Width = 40;
                        dgvChiTiet.Columns["STT"].HeaderText = "No.";

                        dgvChiTiet.Columns["MaSach"].HeaderText = "Mã Sách";
                        dgvChiTiet.Columns["MaSach"].Width = 90;

                        dgvChiTiet.Columns["TenSach"].HeaderText = "Tên Cuốn Sách";
                        dgvChiTiet.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                        dgvChiTiet.Columns["TinhTrang"].HeaderText = "Tình Trạng";
                        dgvChiTiet.Columns["TinhTrang"].Width = 110;

                        dgvChiTiet.Columns["TrangThai"].HeaderText = "Trạng Thái";
                        dgvChiTiet.Columns["TrangThai"].Width = 120;

                        // Căn giữa các cột mã và trạng thái
                        dgvChiTiet.Columns["STT"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvChiTiet.Columns["MaSach"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        dgvChiTiet.Columns["TrangThai"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    }
                }
                UpdateIndex();
            }
        }
        private void ConfigureBeautifulGrid(DataGridView dgv)
        {
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgv.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgv.BackgroundColor = Color.White;

            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 30;

            dgv.RowHeadersVisible = false; // Ẩn cột thừa bên trái
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
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
                string memberId = cbMaDocGia.SelectedValue.ToString();
                string bookId = cbMaSach.SelectedValue.ToString();

                // Check for existing active loan for this member
                var existingLoan = db.Loans
                    .Include(l => l.LoanDetails)
                    .FirstOrDefault(l => l.MemberId == memberId && l.TrangThai == "Đang mượn");

                if (existingLoan != null)
                {
                    // Add to existing loan
                    if (existingLoan.LoanDetails.Any(d => d.BookId == bookId && d.NgayTra == null))
                    {
                        MessageBox.Show("Thành viên này đang mượn cuốn sách này rồi!");
                        return;
                    }

                    var loanDetail = new LoanDetail
                    {
                        LoanId = existingLoan.LoanId,
                        BookId = bookId,
                        SoLuong = 1,
                        TinhTrangMuon = "Tốt"
                    };
                    db.LoanDetails.Add(loanDetail);
                    db.SaveChanges();
                    MessageBox.Show($"Đã thêm sách vào phiếu mượn hiện tại ({existingLoan.LoanId})!");
                }
                else
                {
                    // Create new Loan
                    string newLoanId = GenerateLoanId();
                    var newLoan = new Loan
                    {
                        LoanId = newLoanId,
                        MemberId = memberId,
                        StaffId = defaultStaffId,
                        LoanDate = dtpNgayMuon.Value,
                        DueDate = dtpNgayTra.Value,
                        NgayTraThucTe = null,
                        TrangThai = "Đang mượn"
                    };

                    db.Loans.Add(newLoan);

                    var loanDetail = new LoanDetail
                    {
                        LoanId = newLoanId,
                        BookId = bookId,
                        SoLuong = 1,
                        TinhTrangMuon = "Tốt"
                    };
                    db.LoanDetails.Add(loanDetail);
                    db.SaveChanges();
                    MessageBox.Show("Tạo phiếu mượn mới thành công!");
                }

                LoadData();
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

        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}