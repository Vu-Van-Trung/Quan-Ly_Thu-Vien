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
        private GroupBox grpDetails;
        private DataGridView dgvBooks;
        private Button btnReturn;
        private Button btnCalculateFine;
        private GroupBox grpFines;
        private DataGridView dgvFines;
        private Button btnPay;
        private Button btnWaiver;
        private Label lblLoanId;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private Guna.UI2.WinForms.Guna2Button btnReset;

        // private Guna.UI2.WinForms.Guna2Button btnSearch; // REMOVED
        // private Guna.UI2.WinForms.Guna2TextBox txtLoanId2; // REMOVED
        private ComboBox cboLoanId; // ADDED
        private Label lblTotalFine;

        public FormFine()
        {
            InitializeComponent();
            _fineService = new FineService();
            SetupEvents();
            this.Load += FormFine_Load;
        }

        // New Constuctor for linking
        public FormFine(string loanId) : this()
        {
            // Will be handled in Load
            this.Tag = loanId; 
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            grpSearch = new GroupBox();
            dgvBooks = new DataGridView();
            btnPay = new Button();
            btnCalculateFine = new Button();
            lblLoanId = new Label();
            grpDetails = new GroupBox();
            cboLoanId = new ComboBox();
            lblTotalFine = new Label();
            btnReturn = new Button();
            grpFines = new GroupBox();
            btnWaiver = new Button();
            dgvFines = new DataGridView();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            lblTitle = new Label();
            btnPrint = new Guna.UI2.WinForms.Guna2Button();
            btnReset = new Guna.UI2.WinForms.Guna2Button();
            grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            grpDetails.SuspendLayout();
            grpFines.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFines).BeginInit();
            SuspendLayout();
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(dgvBooks);
            grpSearch.Controls.Add(btnPay);
            grpSearch.Location = new Point(25, 143);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(1273, 264);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "Chi tiết Sách mượn";
            // 
            // dgvBooks
            // 
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.ColumnHeadersHeight = 29;
            dgvBooks.Location = new Point(26, 26);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(1199, 195);
            dgvBooks.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(192, 255, 192);
            btnPay.Location = new Point(1134, 227);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(81, 31);
            btnPay.TabIndex = 1;
            btnPay.Text = "Trả Sách";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnCalculateFine
            // 
            btnCalculateFine.Location = new Point(1015, 227);
            btnCalculateFine.Name = "btnCalculateFine";
            btnCalculateFine.Size = new Size(103, 31);
            btnCalculateFine.TabIndex = 2;
            btnCalculateFine.Text = "Tính phạt";
            btnCalculateFine.UseVisualStyleBackColor = false;
            // 
            // lblLoanId
            // 
            lblLoanId.Location = new Point(179, 36);
            lblLoanId.Name = "lblLoanId";
            lblLoanId.Size = new Size(123, 23);
            lblLoanId.TabIndex = 0;
            lblLoanId.Text = "Mã Phiếu Mượn :";
            lblLoanId.Click += lblLoanId_Click;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblLoanId);
            grpDetails.Controls.Add(cboLoanId);
            grpDetails.Location = new Point(35, 65);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(1273, 72);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Tìm kiếm phiếu mượn";
            // 
            // cboLoanId
            // 
            cboLoanId.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboLoanId.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboLoanId.Font = new Font("Segoe UI", 12F);
            cboLoanId.FormattingEnabled = true;
            cboLoanId.Location = new Point(309, 28);
            cboLoanId.Name = "cboLoanId";
            cboLoanId.Size = new Size(363, 36);
            cboLoanId.TabIndex = 15;
            // 
            // lblTotalFine
            // 
            lblTotalFine.Location = new Point(10, 232);
            lblTotalFine.Name = "lblTotalFine";
            lblTotalFine.Size = new Size(100, 23);
            lblTotalFine.TabIndex = 3;
            lblTotalFine.Text = "Tổng tiền";
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(192, 255, 192);
            btnReturn.Location = new Point(1121, 227);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(94, 31);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Thanh toán";
            btnReturn.UseVisualStyleBackColor = false;
            // 
            // grpFines
            // 
            grpFines.Controls.Add(btnReturn);
            grpFines.Controls.Add(btnWaiver);
            grpFines.Controls.Add(lblTotalFine);
            grpFines.Controls.Add(dgvFines);
            grpFines.Location = new Point(25, 413);
            grpFines.Name = "grpFines";
            grpFines.Size = new Size(1273, 264);
            grpFines.TabIndex = 2;
            grpFines.TabStop = false;
            grpFines.Text = "Danh sách phạt";
            // 
            // btnWaiver
            // 
            btnWaiver.Location = new Point(986, 224);
            btnWaiver.Name = "btnWaiver";
            btnWaiver.Size = new Size(103, 31);
            btnWaiver.TabIndex = 2;
            btnWaiver.Text = "Miễn trừ";
            // 
            // dgvFines
            // 
            dgvFines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFines.ColumnHeadersHeight = 29;
            dgvFines.Location = new Point(10, 26);
            dgvFines.Name = "dgvFines";
            dgvFines.RowHeadersWidth = 51;
            dgvFines.Size = new Size(1215, 195);
            dgvFines.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ButtonFace;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(1219, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(44, 36);
            guna2Button1.TabIndex = 12;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(410, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(502, 50);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "$ CHI TIẾT MƯỢN VÀ PHẠT";
            // 
            // btnPrint
            // 
            btnPrint.BorderRadius = 18;
            btnPrint.CustomizableEdges = customizableEdges9;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.FillColor = Color.FromArgb(128, 128, 255);
            btnPrint.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(184, 693);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnPrint.Size = new Size(132, 42);
            btnPrint.TabIndex = 14;
            btnPrint.Text = "In biên lai";
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnReset
            // 
            btnReset.BorderRadius = 18;
            btnReset.CustomizableEdges = customizableEdges11;
            btnReset.DisabledState.BorderColor = Color.DarkGray;
            btnReset.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReset.FillColor = Color.FromArgb(255, 192, 128);
            btnReset.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(32, 693);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnReset.Size = new Size(124, 42);
            btnReset.TabIndex = 15;
            btnReset.Text = "Làm mới";
            btnReset.Click += BtnReset_Click;
            // 
            // FormFine
            // 
            ClientSize = new Size(1288, 743);
            Controls.Add(btnReset);
            Controls.Add(btnPrint);
            Controls.Add(lblTitle);
            Controls.Add(guna2Button1);
            Controls.Add(grpSearch);
            Controls.Add(grpDetails);
            Controls.Add(grpFines);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormFine";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phạt & Trả Sách";
            grpSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            grpDetails.ResumeLayout(false);
            grpFines.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFines).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetupEvents()
        {

            
            // Fix: btnPay (in Books Group) should trigger Return Book logic
            btnPay.Click += BtnReturn_Click; 
            
            // btnCalculateFine.Click += BtnCalculateFine_Click; // REMOVED
            
            // Fix: btnReturn (in Fines Group) should trigger Pay Fine logic
            btnReturn.Click += BtnPay_Click; 
            
            btnWaiver.Click += BtnWaiver_Click;
            btnReset.Click += BtnReset_Click;
            btnPrint.Click += BtnPrint_Click;
            
            dgvBooks.CellDoubleClick += DgvBooks_CellDoubleClick;
            dgvFines.CellDoubleClick += DgvFines_CellDoubleClick; // Quick Pay by Double Click

            // Print Configuration
            printDocument1.PrintPage += PrintDocument1_PrintPage;
            printPreviewDialog1.Document = printDocument1;
            
            cboLoanId.SelectedIndexChanged += CboLoanId_SelectedIndexChanged;
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

        private void FormFine_Load(object sender, EventArgs e)
        {
            LoadLoanIds();

            // Handle passed LoanId from Link
            if (this.Tag != null && this.Tag is string passedLoanId)
            {
                cboLoanId.SelectedItem = passedLoanId;
            }
        }

        private void LoadLoanIds()
        {
            var loanIds = _fineService.GetAllLoanIds();
            cboLoanId.DataSource = loanIds;
            cboLoanId.SelectedIndex = -1; // Default no selection
        }

        private void CboLoanId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoanId.SelectedItem == null) return;
            string loanId = cboLoanId.SelectedItem.ToString();
            LoadLoanDetails(loanId);
        }

        // REMOVED BtnSearch_Click and LoadLoanDetails(txtLoanId2.Text) call

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
                string bookName = row.Cells["pBookName"].Value.ToString();
                string condition = "Tốt"; // Default

                // Use FormConditionCheck Dialog
                using (var frmCondition = new FormConditionCheck(bookName))
                {
                    if (frmCondition.ShowDialog() == DialogResult.OK)
                    {
                        condition = frmCondition.SelectedCondition;
                    }
                    else
                    {
                         // Cancelled whole operation or just skip this book? 
                         // Let's assume skip this row if cancelled
                         continue; 
                    }
                }

                _fineService.ReturnBook(detailId, condition);
                
                // Auto calculate overdue fine if applicable (Logic inside FineService or here?)
                // Assuming ReturnBook handles condition fines, let's explicitly add Overdue Logic here also if simpler
                // Or ensure FineService.ReturnBook handles it. Code view shows FineService only handles Condition Fine.
                // We should add logic to calculate OVERDUE fine automatically upon return here.
                
                // Check Overdue
                var loanDetail = _currentLoan.LoanDetails.FirstOrDefault(ld => ld.LoanDetailId == detailId);
                // Note: detail object might be stale if _fineService.ReturnBook commits updates. 
                // However, dates shouldn't change.
                if (DateTime.Now > _currentLoan.DueDate)
                {
                     decimal overdueAmount = _fineService.CalculateFineAmount(_currentLoan.DueDate, DateTime.Now);
                     if (overdueAmount > 0)
                     {
                         _fineService.CreateOverdueFine(_currentLoan.LoanId, overdueAmount, $"Quá hạn sách {bookName}");
                     }
                }
                
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
            cboLoanId.SelectedIndex = -1; // Reset Combo
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLoanId_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
