using System;
using System.Drawing;
using System.Windows.Forms;
using LibraryManagement.Services;
using LibraryManagement.Models;
#nullable disable
using LibraryManagement.Data;
using System.Linq;
using System.Drawing.Printing;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DoAnDemoUI
{
    public partial class FormFine : Form
    {
        private FineService _fineService;
        private Loan _currentLoan;
        private PrintDocument printDocument1 = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

        // Controls
        private GroupBox grpSearch;
        private TextBox txtLoanId;
        private Button btnSearch;
        private GroupBox grpDetails;
        private DataGridView dgvBooks;
        private Button btnReturn;
        private Button btnCalculateFine;
        private GroupBox grpFines;
        private DataGridView dgvFines;
        private Button btnPay;
        private Button btnWaiver;
        private Button btnPrint;
        private Button btnReset;
        private Label lblTotalFine;

        public FormFine()
        {
            InitializeComponent();
            _fineService = new FineService();
            SetupEvents();
        }

        // New Constuctor for linking
        public FormFine(string loanId) : this()
        {
            txtLoanId.Text = loanId;
            LoadLoanDetails(loanId);
        }

        private void InitializeComponent()
        {
            this.Text = "Quản Lý Phạt & Trả Sách";
            this.Size = new Size(1000, 700);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Search Group
            grpSearch = new GroupBox { Text = "Tìm kiếm Phiếu Mượn", Location = new Point(10, 10), Size = new Size(960, 80) };
            Label lblLoanId = new Label { Text = "Mã Phiếu Mượn:", Location = new Point(20, 30), AutoSize = true };
            txtLoanId = new TextBox { Location = new Point(120, 27), Width = 200 };
            btnSearch = new Button { Text = "Kiểm tra", Location = new Point(340, 25), Width = 100, BackColor = Color.LightBlue };

            grpSearch.Controls.Add(lblLoanId);
            grpSearch.Controls.Add(txtLoanId);
            grpSearch.Controls.Add(btnSearch);

            // Details Group
            grpDetails = new GroupBox { Text = "Chi tiết Sách Mượn", Location = new Point(10, 100), Size = new Size(960, 250) };
            dgvBooks = new DataGridView { Location = new Point(20, 25), Size = new Size(920, 180), AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill, SelectionMode = DataGridViewSelectionMode.FullRowSelect, ReadOnly = true };
            btnReturn = new Button { Text = "Xác nhận Trả", Location = new Point(810, 215), Width = 130, BackColor = Color.LightGreen };
            btnCalculateFine = new Button { Text = "Tính Phạt", Location = new Point(670, 215), Width = 130, BackColor = Color.Orange };

            grpDetails.Controls.Add(dgvBooks);
            grpDetails.Controls.Add(btnReturn);
            grpDetails.Controls.Add(btnCalculateFine);

            // Fines Group
            grpFines = new GroupBox { Text = "Danh Sách Phạt", Location = new Point(10, 360), Size = new Size(960, 200) };
            dgvFines = new DataGridView { Location = new Point(20, 25), Size = new Size(920, 130), AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill };
            btnPay = new Button { Text = "Thanh toán nhanh", Location = new Point(810, 165), Width = 130, BackColor = Color.LightBlue };
            btnWaiver = new Button { Text = "Miễn giảm", Location = new Point(670, 165), Width = 130, BackColor = Color.LightPink };
            lblTotalFine = new Label { Text = "Tổng tiền phạt: 0 VNĐ", Location = new Point(20, 170), Font = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold) };

            grpFines.Controls.Add(dgvFines);
            grpFines.Controls.Add(btnPay);
            grpFines.Controls.Add(btnWaiver);
            grpFines.Controls.Add(lblTotalFine);

            // Footer
            btnReset = new Button { Text = "Làm mới", Location = new Point(10, 580), Width = 100 };
            btnPrint = new Button { Text = "In Biên Lai", Location = new Point(120, 580), Width = 100 };

            this.Controls.Add(grpSearch);
            this.Controls.Add(grpDetails);
            this.Controls.Add(grpFines);
            this.Controls.Add(btnReset);
            this.Controls.Add(btnPrint);
        }

        private void SetupEvents()
        {
            btnSearch.Click += BtnSearch_Click;
            btnReturn.Click += BtnReturn_Click;
            btnCalculateFine.Click += BtnCalculateFine_Click;
            btnPay.Click += BtnPay_Click;
            btnWaiver.Click += BtnWaiver_Click;
            btnReset.Click += BtnReset_Click;
            btnReset.Click += BtnReset_Click;
            btnPrint.Click += BtnPrint_Click;
            dgvBooks.CellDoubleClick += DgvBooks_CellDoubleClick;
            dgvFines.CellDoubleClick += DgvFines_CellDoubleClick; // Quick Pay by Double Click
            
            // Print Configuration
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
        }

        private void DgvFines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgvFines.Rows[e.RowIndex];
            ProcessPayForRows(new[] { row }); // Cleaned up call with argument
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
             if (dgvFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khoản phạt cần thanh toán!");
                return;
            }

            // Convert SelectedRows collection to list
            var rows = new System.Collections.Generic.List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvFines.SelectedRows) rows.Add(row);

            ProcessPayForRows(rows);
        }

        private void ProcessPayForRows(System.Collections.Generic.IEnumerable<DataGridViewRow> rows)
        {
            if (MessageBox.Show("Xác nhận thanh toán các khoản phạt đã chọn?", "Thanh toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int successCount = 0;
            foreach (DataGridViewRow row in rows)
            {
                // Check if already paid
                var status = row.Cells["TrangThaiThanhToan"].Value?.ToString();
                if (status == "Đã thanh toán") continue;

                int fineId = (int)row.Cells["FineId"].Value;
                _fineService.PayFine(fineId);
                successCount++;
            }

            if (successCount > 0)
            {
                MessageBox.Show("Thanh toán thành công!");
                 _currentLoan = _fineService.GetLoanWithDetails(_currentLoan.LoanId); // Refresh context
                LoadFines();
            }
            else
            {
                 MessageBox.Show("Các khoản phạt này đã được thanh toán trước đó.");
            }
        }

        private void DgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; // Header clicked
            
            // Trigger return logic for this specific row
            DataGridViewRow row = dgvBooks.Rows[e.RowIndex];
            ProcessReturnForRows(new[] { row }); // Helper method to reuse logic
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            string loanId = txtLoanId.Text.Trim();
            if (string.IsNullOrEmpty(loanId)) return;

            LoadLoanDetails(loanId);
        }

        private void LoadLoanDetails(string loanId)
        {
            _currentLoan = _fineService.GetLoanWithDetails(loanId);
            if (_currentLoan == null)
            {
                MessageBox.Show("Không tìm thấy phiếu mượn!");
                return;
            }

            // Bind Books
            dgvBooks.DataSource = _currentLoan.LoanDetails.Select(d => new
            {
                d.LoanDetailId,
                d.BookId,
                pBookName = d.Book?.Title ?? "Unknown",
                d.NgayTra,
                d.TinhTrangTra,
                Status = d.NgayTra != null ? "Đã trả" : (_currentLoan.DueDate < DateTime.Now ? "Quá hạn" : "Đang mượn")
            }).ToList();

            // Bind Fines
            LoadFines();
        }

        private void LoadFines()
        {
            if (_currentLoan == null) return;
            dgvFines.DataSource = _currentLoan.Fines.Select(f => new
            {
                f.FineId,
                f.LyDo,
                f.SoTienPhat,
                f.TrangThaiThanhToan
            }).ToList();

            decimal total = _currentLoan.Fines.Where(f => f.TrangThaiThanhToan != "Đã thanh toán").Sum(f => f.SoTienPhat);
            lblTotalFine.Text = $"Tổng tiền phạt: {total:N0} VNĐ";
        }

        private void CheckRefreshParent()
        {
            // Refresh FormLoan if open
            var frmLoan = Application.OpenForms["FormLoan"] as FormLoan;
            if (frmLoan != null)
            {
                frmLoan.LoadData();
            }
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn sách cần trả!");
                return;
            }

            // Convert SelectedRows collection to array/list
            var rows = new System.Collections.Generic.List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgvBooks.SelectedRows) rows.Add(row);

            ProcessReturnForRows(rows);
        }

        private void ProcessReturnForRows(System.Collections.Generic.IEnumerable<DataGridViewRow> rows)
        {
            int successCount = 0;
            foreach (DataGridViewRow row in rows)
            {
                // Check if already returned (Status cell check or null check logic)
                var status = row.Cells["Status"].Value?.ToString();
                if (status == "Đã trả") continue;

                int detailId = (int)row.Cells["LoanDetailId"].Value;
                bool isDamage = MessageBox.Show($"Sách '{row.Cells["pBookName"].Value}' có bị hư hỏng không?", "Kiểm tra sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
                
                _fineService.ReturnBook(detailId, isDamage ? "Hư hỏng" : "Tốt", isDamage);
                successCount++;
            }
            
            if (successCount > 0)
            {
                MessageBox.Show($"Đã cập nhật trả sách thành công cho {successCount} quyển!");
                LoadLoanDetails(_currentLoan.LoanId); // Reload
                CheckRefreshParent(); // Refresh Parent FormLoan Data
            }
            else
            {
                MessageBox.Show("Sách đã được trả trước đó hoặc không có thay đổi.");
            }
        }

        private void BtnCalculateFine_Click(object sender, EventArgs e)
        {
             if (_currentLoan == null) return;

             bool anyFine = false;
             foreach (var detail in _currentLoan.LoanDetails)
             {
                 if (detail.NgayTra == null) continue; // Only calc for returned items

                 // Overdue Check
                 if (detail.NgayTra.Value > _currentLoan.DueDate)
                 {
                     decimal amount = _fineService.CalculateFineAmount(_currentLoan.DueDate, detail.NgayTra.Value);
                     if (amount > 0)
                     {
                         var fine = _fineService.CreateOverdueFine(_currentLoan.LoanId, amount, $"Quá hạn sách {detail.BookId} ({detail.Book?.Title ?? "N/A"})");
                         if (fine != null) anyFine = true;
                     }
                 }
             }

             if (anyFine)
             {
                 MessageBox.Show("Đã tính toán và tạo phiếu phạt mới!");
                 // Reload to show fines
                  _currentLoan = _fineService.GetLoanWithDetails(_currentLoan.LoanId); // Refresh context
                 LoadFines();
             }
             else
             {
                 MessageBox.Show("Không có khoản phạt mới (hoặc đã tồn tại).");
             }
        }

        private void BtnWaiver_Click(object sender, EventArgs e)
        {
            if (dgvFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khoản phạt cần miễn giảm!");
                return;
            }

            string input = Microsoft.VisualBasic.Interaction.InputBox("Nhập phần trăm miễn giảm (0-100):", "Miễn giảm", "0");
            if (int.TryParse(input, out int percent) && percent >= 0 && percent <= 100)
            {
                 foreach (DataGridViewRow row in dgvFines.SelectedRows)
                 {
                     int fineId = (int)row.Cells["FineId"].Value;
                     _fineService.ApplyDiscount(fineId, percent);
                 }
                 MessageBox.Show("Đã áp dụng miễn giảm!");
                 _currentLoan = _fineService.GetLoanWithDetails(_currentLoan.LoanId);
                 LoadFines();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ từ 0 đến 100.");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txtLoanId.Clear();
            dgvBooks.DataSource = null;
            dgvFines.DataSource = null;
            _currentLoan = null;
            lblTotalFine.Text = "Tổng tiền phạt: 0 VNĐ";
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (_currentLoan == null)
            {
                MessageBox.Show("Vui lòng tìm kiếm thông tin phiếu mượn trước khi in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }
        private void PrintDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitle = new Font("Arial", 20, FontStyle.Bold);
            Font fontHeader = new Font("Arial", 12, FontStyle.Bold);
            Font fontBody = new Font("Arial", 11, FontStyle.Regular);
            Font fontFooter = new Font("Arial", 10, FontStyle.Italic);

            float y = 50;
            float x = e.MarginBounds.Left;

            // 1. Tiêu đề
            g.DrawString("BIÊN LAI THU PHÍ PHẠT & TRẢ SÁCH", fontTitle, Brushes.Black, x + 50, y);
            y += 60;

            // 2. Thông tin chung
            g.DrawString($"Mã phiếu mượn: {_currentLoan.LoanId}", fontBody, Brushes.Black, x, y);
            y += 25;
            g.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}", fontBody, Brushes.Black, x, y);
            y += 40;

            // 3. Danh sách sách trả (Dữ liệu từ dgvBooks)
            g.DrawString("DANH SÁCH SÁCH XỬ LÝ:", fontHeader, Brushes.Black, x, y);
            y += 30;
            foreach (var d in _currentLoan.LoanDetails)
            {
                string status = d.NgayTra != null ? $"Đã trả ({d.TinhTrangTra})" : "Chưa trả";
                g.DrawString($"- {d.Book?.Title ?? "N/A"}: {status}", fontBody, Brushes.Black, x + 20, y);
                y += 25;
            }
            y += 20;

            // 4. Chi tiết các khoản phạt (Dữ liệu từ bảng PHAT)
            if (_currentLoan.Fines != null && _currentLoan.Fines.Any())
            {
                g.DrawLine(Pens.Black, x, y, e.MarginBounds.Right, y);
                y += 10;
                g.DrawString("CHI TIẾT PHẠT:", fontHeader, Brushes.Black, x, y);
                y += 30;

                foreach (var f in _currentLoan.Fines)
                {
                    string line = $"{f.LyDo}: {f.SoTienPhat:N0} VNĐ ({f.TrangThaiThanhToan})";
                    g.DrawString(line, fontBody, Brushes.Black, x + 20, y);
                    y += 25;
                }
            }

            // 5. Tổng kết
            y += 20;
            decimal total = _currentLoan.Fines.Where(f => f.TrangThaiThanhToan != "Đã thanh toán").Sum(f => f.SoTienPhat);
            g.DrawString(lblTotalFine.Text, fontHeader, Brushes.Blue, x, y);

            // 6. Chữ ký
            y += 60;
            g.DrawString("Thủ thư", fontHeader, Brushes.Black, x + 50, y);
            g.DrawString("Người nộp", fontHeader, Brushes.Black, e.MarginBounds.Right - 150, y);
            y += 80;
            g.DrawString("(Ký và ghi rõ họ tên)", fontFooter, Brushes.Black, x + 40, y);
            g.DrawString("(Ký và ghi rõ họ tên)", fontFooter, Brushes.Black, e.MarginBounds.Right - 160, y);
        }
    }
}
