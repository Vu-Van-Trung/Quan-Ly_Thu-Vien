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
        private Guna.UI2.WinForms.Guna2Button btnReturn;
        private Guna.UI2.WinForms.Guna2Button btnCalculateFine;
        private GroupBox grpFines;
        private DataGridView dgvFines;
        private Guna.UI2.WinForms.Guna2Button btnPay;
        private Guna.UI2.WinForms.Guna2Button btnWaiver;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            grpSearch = new GroupBox();
            dgvBooks = new DataGridView();
            btnPay = new Guna.UI2.WinForms.Guna2Button();
            btnCalculateFine = new Guna.UI2.WinForms.Guna2Button();
            lblLoanId = new Label();
            grpDetails = new GroupBox();
            cboLoanId = new ComboBox();
            lblTotalFine = new Label();
            btnReturn = new Guna.UI2.WinForms.Guna2Button();
            grpFines = new GroupBox();
            btnWaiver = new Guna.UI2.WinForms.Guna2Button();
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
            grpSearch.Size = new Size(1240, 264);
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
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(1199, 195);
            dgvBooks.TabIndex = 0;
            // 
            // btnPay
            // 
            btnPay.BorderRadius = 15;
            btnPay.CustomizableEdges = customizableEdges1;
            btnPay.FillColor = Color.FromArgb(46, 204, 113);
            btnPay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(1114, 227);
            btnPay.Name = "btnPay";
            btnPay.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPay.Size = new Size(111, 31);
            btnPay.TabIndex = 1;
            btnPay.Text = "Trả Sách";
            // 
            // btnCalculateFine
            // 
            btnCalculateFine.BorderRadius = 15;
            btnCalculateFine.CustomizableEdges = customizableEdges3;
            btnCalculateFine.FillColor = Color.FromArgb(52, 152, 219);
            btnCalculateFine.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCalculateFine.ForeColor = Color.White;
            btnCalculateFine.Location = new Point(995, 227);
            btnCalculateFine.Name = "btnCalculateFine";
            btnCalculateFine.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnCalculateFine.Size = new Size(113, 31);
            btnCalculateFine.TabIndex = 2;
            btnCalculateFine.Text = "Tính phạt";
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
            grpDetails.Size = new Size(1230, 72);
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
            lblTotalFine.Size = new Size(250, 23);
            lblTotalFine.TabIndex = 3;
            lblTotalFine.Text = "Tổng tiền";
            // 
            // btnReturn
            // 
            btnReturn.BorderRadius = 15;
            btnReturn.CustomizableEdges = customizableEdges5;
            btnReturn.FillColor = Color.FromArgb(46, 204, 113);
            btnReturn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(1111, 224);
            btnReturn.Name = "btnReturn";
            btnReturn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnReturn.Size = new Size(114, 31);
            btnReturn.TabIndex = 1;
            btnReturn.Text = "Thanh toán";
            // 
            // grpFines
            // 
            grpFines.Controls.Add(btnReturn);
            grpFines.Controls.Add(btnWaiver);
            grpFines.Controls.Add(lblTotalFine);
            grpFines.Controls.Add(dgvFines);
            grpFines.Location = new Point(25, 413);
            grpFines.Name = "grpFines";
            grpFines.Size = new Size(1240, 264);
            grpFines.TabIndex = 2;
            grpFines.TabStop = false;
            grpFines.Text = "Danh sách phạt";
            // 
            // btnWaiver
            // 
            btnWaiver.BorderRadius = 15;
            btnWaiver.CustomizableEdges = customizableEdges7;
            btnWaiver.FillColor = Color.FromArgb(230, 126, 34);
            btnWaiver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnWaiver.ForeColor = Color.White;
            btnWaiver.Location = new Point(992, 224);
            btnWaiver.Name = "btnWaiver";
            btnWaiver.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnWaiver.Size = new Size(113, 31);
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
            dgvFines.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFines.Size = new Size(1215, 195);
            dgvFines.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges9;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ButtonFace;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(1221, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            btnPrint.CustomizableEdges = customizableEdges11;
            btnPrint.DisabledState.BorderColor = Color.DarkGray;
            btnPrint.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPrint.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPrint.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPrint.FillColor = Color.FromArgb(128, 128, 255);
            btnPrint.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(184, 693);
            btnPrint.Name = "btnPrint";
            btnPrint.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnPrint.Size = new Size(132, 42);
            btnPrint.TabIndex = 14;
            btnPrint.Text = "In biên lai";
            btnPrint.Click += BtnPrint_Click;
            // 
            // btnReset
            // 
            btnReset.BorderRadius = 18;
            btnReset.CustomizableEdges = customizableEdges13;
            btnReset.DisabledState.BorderColor = Color.DarkGray;
            btnReset.DisabledState.CustomBorderColor = Color.DarkGray;
            btnReset.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnReset.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnReset.FillColor = Color.FromArgb(255, 192, 128);
            btnReset.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold);
            btnReset.ForeColor = Color.White;
            btnReset.Location = new Point(32, 693);
            btnReset.Name = "btnReset";
            btnReset.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnReset.Size = new Size(124, 42);
            btnReset.TabIndex = 15;
            btnReset.Text = "Làm mới";
            btnReset.Click += BtnReset_Click;
            // 
            // FormFine
            // 
            ClientSize = new Size(1277, 743);
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
            // btnPrint.Click += BtnPrint_Click; // REMOVED duplicate
            
            dgvBooks.CellDoubleClick += DgvBooks_CellDoubleClick;
            dgvBooks.SelectionChanged += DgvBooks_SelectionChanged; // Cross-Highlight
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
                CheckRefreshParent(); // Refresh UI to unblock borrowing if fines are cleared
            }
            else
            {
                MessageBox.Show("Các khoản phạt này đã được thanh toán trước đó.");
            }
        }

        private void DgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow == null) return;
            
            // Cross-Highlight: Select corresponding fines
            string bookTitle = dgvBooks.CurrentRow.Cells["pBookName"].Value?.ToString();
            if (string.IsNullOrEmpty(bookTitle)) return;

            dgvFines.ClearSelection();
            bool found = false;
            foreach (DataGridViewRow row in dgvFines.Rows)
            {
                string reason = row.Cells["LyDo"].Value?.ToString();
                // Simple containment check: Reason usually contains book name (e.g. "Quá hạn sách ABC")
                if (!string.IsNullOrEmpty(reason) && reason.Contains(bookTitle, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    found = true;
                }
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

            // Style Grids
            ConfigureBeautifulGrid(dgvBooks);
            ConfigureBeautifulGrid(dgvFines);
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

            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
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
            lblTotalFine.Text = "Tổng tiền phạt: " + total.ToString("C0", new System.Globalization.CultureInfo("vi-VN"));
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
            decimal totalOverdueGenerated = 0;
            decimal totalConditionGenerated = 0;

            foreach (DataGridViewRow row in rows)
            {
                var status = row.Cells["Status"].Value?.ToString();
                if (status == "Đã trả") continue;

                int detailId = (int)row.Cells["LoanDetailId"].Value;
                string bookName = row.Cells["pBookName"].Value.ToString();
                string condition = "Tốt"; // Default

                using (var frmCondition = new FormConditionCheck(bookName))
                {
                    if (frmCondition.ShowDialog() == DialogResult.OK)
                    {
                        condition = frmCondition.SelectedCondition;
                    }
                    else
                    {
                         continue; 
                    }
                }

                // Capture condition fine amount
                decimal conditionFine = _fineService.ReturnBook(detailId, condition);
                totalConditionGenerated += conditionFine;

                if (DateTime.Now > _currentLoan.DueDate)
                {
                     decimal overdueAmount = _fineService.CalculateFineAmount(_currentLoan.DueDate, DateTime.Now);
                     if (overdueAmount > 0)
                     {
                         var fine = _fineService.CreateOverdueFine(_currentLoan.LoanId, overdueAmount, $"Quá hạn sách {bookName}");
                         if (fine != null) totalOverdueGenerated += overdueAmount;
                     }
                }
                
                successCount++;
            }

            if (successCount > 0)
            {
                LoadLoanDetails(_currentLoan.LoanId); // Reload
                CheckRefreshParent(); // Refresh Parent
                
                string msg = $"Đã cập nhật trả sách thành công cho {successCount} quyển!";
                
                // Calculate Total Unpaid Balance for the Loan
                decimal totalUnpaid = _currentLoan.Fines
                    .Where(f => f.TrangThaiThanhToan == "Chưa thanh toán")
                    .Sum(f => f.SoTienPhat);

                if (totalUnpaid > 0)
                {
                    // Update: Prompt for immediate action if ANY unpaid balance exists
                    msg += $"\n\nLƯU Ý: Hiện tại phiếu mượn này có khoản phạt chưa thanh toán: {totalUnpaid:N0} VNĐ.";
                    msg += "\n(Bao gồm phạt cũ và phạt mới tạo nếu có)";
                    
                    msg += "\n\nBạn có muốn xử lý MIỄN GIẢM / THANH TOÁN ngay không?";

                    if (MessageBox.Show(msg, "Thông báo & Xử lý phạt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Auto-select unpaid fines
                        HighlightUnpaidFines();
                        
                        // Open Waiver Form directly
                        BtnWaiver_Click(null, null); 
                    }
                }
                else
                {
                     MessageBox.Show(msg, "Thông báo trả sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Sách đã được trả trước đó hoặc không có thay đổi.");
            }
        }
        
        private void HighlightUnpaidFines()
        {
            // Helper to select unpaid fines
            dgvFines.ClearSelection();
            foreach(DataGridViewRow r in dgvFines.Rows)
            {
                if (r.Cells["TrangThaiThanhToan"].Value?.ToString() == "Chưa thanh toán")
                {
                    r.Selected = true;
                }
            }
        }



        private void BtnWaiver_Click(object sender, EventArgs e)
        {
            // Auto-select if nothing selected but rows exist
            if (dgvFines.SelectedRows.Count == 0 && dgvFines.Rows.Count > 0)
            {
                // Find unpaid ones preferably
                bool found = false;
                foreach (DataGridViewRow r in dgvFines.Rows)
                {
                    if (r.Cells["TrangThaiThanhToan"].Value?.ToString() == "Chưa thanh toán")
                    {
                        r.Selected = true;
                        found = true;
                    }
                }
                
                // If no unpaid ones found (all paid?), just select all or first?
                // If all paid, Waiver checks technically useless but user might want to see history or something (though waiver applies to amount).
                // Let's just select all if nothing specific found, to allow user to see the form (though it might not do anything useful if balance is 0).
                if (!found)
                {
                     dgvFines.Rows[0].Selected = true;
                }
            }

            if (dgvFines.SelectedRows.Count == 0)
            {
                MessageBox.Show("Không có khoản phạt nào để xử lý!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var frm = new FormWaiver())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string performer = Services.Session.CurrentUsername ?? "Unknown User";
                    
                    foreach (DataGridViewRow row in dgvFines.SelectedRows)
                    {
                        int fineId = (int)row.Cells["FineId"].Value;
                        // Use updated ApplyWaiver logic
                        _fineService.ApplyWaiver(fineId, frm.WaiverValue, frm.IsPercentage, frm.Reason, performer);
                    }
                    MessageBox.Show("Đã áp dụng miễn giảm thành công!");
                    _currentLoan = _fineService.GetLoanWithDetails(_currentLoan.LoanId);
                    LoadFines();
                }
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
                    // Clean up Reason string
                    string cleanReason = f.LyDo;
                    // Format: "Original Reason (Miễn giảm: X% - By: User - Reason: Text)"
                    int idx = cleanReason.IndexOf("(Miễn giảm:");
                    if (idx >= 0)
                    {
                        // Extract "Miễn giảm: X%" part, discard " - By: ..."
                        // Find " - By:"
                        int endIdx = cleanReason.IndexOf(" - By:", idx);
                        if (endIdx > idx)
                        {
                            string discountPart = cleanReason.Substring(idx, endIdx - idx);
                            // Append closing parenthesis
                            discountPart += ")"; 
                            // Reconstruct: "Original Reason (Miễn giảm: 50%)"
                            cleanReason = cleanReason.Substring(0, idx) + discountPart;
                        }
                    }

                    string line = $"{cleanReason}: {f.SoTienPhat:N0} VNĐ ({f.TrangThaiThanhToan})";
                    g.DrawString(line, fontBody, Brushes.Black, x + 20, y);
                    y += 25;
                }
            }

            // 5. Tổng kết
            y += 20;
            decimal total = _currentLoan.Fines.Sum(f => f.SoTienPhat);
            g.DrawString("Tổng thanh toán: " + total.ToString("C0", new System.Globalization.CultureInfo("vi-VN")), fontHeader, Brushes.Blue, x, y);

            // 6. Chữ ký
            y += 60;
            g.DrawString("Thủ thư", fontHeader, Brushes.Black, x + 50, y);
            g.DrawString("Người nộp", fontHeader, Brushes.Black, e.MarginBounds.Right - 150, y);
            
            // Adjust spacing for Signature line
            y += 25; // Move closer to header
            g.DrawString("(Ký và ghi rõ họ tên)", fontFooter, Brushes.Black, x + 40, y);
            g.DrawString("(Ký và ghi rõ họ tên)", fontFooter, Brushes.Black, e.MarginBounds.Right - 160, y);

            // Auto-fill Librarian Name (Full Name)
            y += 100; // Space for signature
            string currentUsername = DoAnDemoUI.Services.Session.CurrentUsername;
            string librarianName = _fineService.GetStaffFullName(currentUsername); 
            
            // Draw Librarian Name centered roughly under the header
            // Header is at x + 50
            // Draw name at x + 50 or slightly adjusted depending on length? 
            // Left aligning at x + 50 matches the header alignment.
            g.DrawString(librarianName, fontHeader, Brushes.Black, x + 50, y);
            
            // Payer name removed as requested.
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
