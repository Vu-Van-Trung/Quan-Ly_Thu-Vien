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
        private System.Collections.IEnumerable _originalData;

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
            cbMaDocGia.DisplayMember = "MemberId"; // Display ID instead of Name
            cbMaDocGia.ValueMember = "MemberId";
            
            cbMaDocGia.SelectedIndexChanged += CbMaDocGia_SelectedIndexChanged;
        }

        private void CbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaDocGia.SelectedItem != null)
            {
                // Retrieve DisplayName via reflection from the anonymous type
                dynamic item = cbMaDocGia.SelectedItem;
                string name = item.GetType().GetProperty("DisplayName")?.GetValue(item, null)?.ToString();
                txtTenDocGia.Text = name;
            }
            else
            {
                txtTenDocGia.Clear();
            }
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (_originalData == null) return;

            if (cbMaDocGia.SelectedIndex != -1 && cbMaDocGia.SelectedValue != null)
            {
                string selectedId = cbMaDocGia.SelectedValue.ToString();
                // Filter data by MemberId
                var list = ((System.Collections.IEnumerable)_originalData).Cast<dynamic>()
                           .Where(x => x.MemberId == selectedId).ToList();
                bindingSource.DataSource = list;
            }
            else
            {
                bindingSource.DataSource = _originalData;
            }
            UpdateIndex();
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
                    l.MemberId,
                    MemberName = CryptoHelper.Decrypt(l.Member.FullName),
                    l.LoanDate,
                    l.DueDate,
                    Status = l.NgayTraThucTe == null ? "Đang Mượn" : "Đã Trả",
                    BookCount = l.LoanDetails.Count
                })
                    .OrderBy(x => x.MemberName) // Sort by decrypted name
                    .ToList();

                _originalData = data;
                ApplyFilter();
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

                // --- 1. KIỂM TRA TRẠNG THÁI ĐỘC GIẢ ---
                var member = db.Members.FirstOrDefault(m => m.MemberId == memberId);
                if (member == null || member.TrangThai != "Hoạt động")
                {
                    MessageBox.Show("Thẻ độc giả đang bị khóa hoặc không hoạt động. Không thể mượn sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (member.NgayHetHan != null && member.NgayHetHan < DateTime.Now)
                {
                    MessageBox.Show($"Thẻ độc giả đã hết hạn vào ngày {member.NgayHetHan:dd/MM/yyyy}. Vui lòng gia hạn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- 1.5. KIỂM TRA PHẠT CHƯA THANH TOÁN ---
                // Chỉ chọn Phat từ các Loan của MemberId này
                // (Giả sử có bảng Fines có LoanId, Loan có MemberId)
                bool hasUnpaidFines = db.Fines.Any(f => f.Loan.MemberId == memberId && f.TrangThaiThanhToan == "Chưa thanh toán");
                if (hasUnpaidFines)
                {
                    MessageBox.Show("Độc giả có khoản phạt chưa thanh toán. Vui lòng đóng phạt trước khi mượn sách mới!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- 2. KIỂM TRA SÁCH QUÁ HẠN ---
                bool hasOverdueBooks = db.Loans.Any(l => l.MemberId == memberId 
                                                      && l.DueDate < DateTime.Now 
                                                      && l.LoanDetails.Any(ld => ld.NgayTra == null));
                if (hasOverdueBooks)
                {
                    MessageBox.Show("Độc giả đang có sách quá hạn chưa trả. Vui lòng trả sách quá hạn trước khi mượn thêm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // --- 3. KIỂM TRA GIỚI HẠN SỐ LƯỢNG (MAX 5) ---
                int currentBorrowedCount = db.LoanDetails.Count(ld => ld.Loan.MemberId == memberId && ld.NgayTra == null);
                if (currentBorrowedCount >= 5)
                {
                    MessageBox.Show($"Độc giả đã đạt giới hạn mượn 5 cuốn sách (Đang mượn: {currentBorrowedCount}).\nVui lòng trả bớt sách trước khi mượn thêm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
                    
                    // Log
                    Services.Logger.Log("Quản lý Mượn Trả", "Thêm sách", $"Thêm sách {bookId} vào phiếu {existingLoan.LoanId}");

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

                    // Log
                    Services.Logger.Log("Quản lý Mượn Trả", "Tạo phiếu mượn", $"Tạo phiếu mượn mới {newLoanId} cho độc giả {memberId}");

                    MessageBox.Show("Tạo phiếu mượn mới thành công!");
                }

                LoadData();
            }
            catch (Exception ex)
            {
                // Fix: Clear tracking state to prevent "Instance already tracked" error on retry
                // If using EF Core 5+:
                try { db.ChangeTracker.Clear(); } catch { } 
                
                // Fallback for older EF Core if Clear() missing:
                // foreach (var entry in db.ChangeTracker.Entries().ToList()) entry.State = EntityState.Detached;

                MessageBox.Show("Lỗi thêm: " + ex.Message + "\n" + ex.InnerException?.Message);
            }
        }

        // Hàm tạo mã phiếu mượn tự động
        private string GenerateLoanId()
        {
            // Lấy tất cả mã phiếu hiện có để xử lý chính xác (tránh lỗi sắp xếp chuỗi "PM9" > "PM10")
            var allIds = db.Loans.Select(l => l.LoanId).ToList();
            
            int maxId = 0;
            foreach (var id in allIds)
            {
                // Giả sử định dạng PMxxx
                if (id.Length > 2 && id.StartsWith("PM") && int.TryParse(id.Substring(2), out int num))
                {
                    if (num > maxId) maxId = num;
                }
            }
            
            // Tăng số lớn nhất lên 1
            return $"PM{maxId + 1:D3}";
        }

        // --- 4. CHỨC NĂNG SỬA ---
        // --- 4. CHỨC NĂNG SỬA ---
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
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
                    
                    // Cập nhật hạn trả = ngày mượn + 14 ngày
                    loan.DueDate = loan.LoanDate.AddDays(14);
                    // Update UI to reflect calculated date
                    dtpNgayTra.Value = loan.DueDate;

                    db.SaveChanges();
                    
                    // Log
                    Services.Logger.Log("Quản lý Mượn Trả", "Cập nhật", $"Cập nhật phiếu mượn {loan.LoanId}");

                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex)
            {
                try { db.ChangeTracker.Clear(); } catch { }
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
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

                        // Log
                        Services.Logger.Log("Quản lý Mượn Trả", "Xóa", $"Xóa phiếu mượn {loanId}");

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



        private void dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}