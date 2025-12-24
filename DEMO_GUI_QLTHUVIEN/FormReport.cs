#nullable disable
using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Data;
using Microsoft.EntityFrameworkCore;

namespace DoAnDemoUI
{
    /// <summary>
    /// Form Báo cáo và Thống kê
    /// </summary>
    public partial class FormReport : Form
    {
        private LibraryContext db;

        public FormReport()
        {
            InitializeComponent();
            this.Load += FormReport_Load;
        }

        private void FormReport_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            dtpFrom.Value = DateTime.Now.AddMonths(-1);
            dtpTo.Value = DateTime.Now;
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tabControl = new TabControl();
            tabMostBorrowed = new TabPage();
            tabActiveMembers = new TabPage();
            tabCategoryStats = new TabPage();
            tabFineRevenue = new TabPage();
            tabInventory = new TabPage();
            dgvReport = new DataGridView();
            btnGenerate = new Button();
            btnExport = new Button();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            lblFrom = new Label();
            lblTo = new Label();
            lblTotal = new Label();
            lblTitle = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMostBorrowed);
            tabControl.Controls.Add(tabActiveMembers);
            tabControl.Controls.Add(tabCategoryStats);
            tabControl.Controls.Add(tabFineRevenue);
            tabControl.Controls.Add(tabInventory);
            tabControl.Location = new Point(1, 82);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1310, 50);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabMostBorrowed
            // 
            tabMostBorrowed.Location = new Point(4, 29);
            tabMostBorrowed.Name = "tabMostBorrowed";
            tabMostBorrowed.Size = new Size(1302, 17);
            tabMostBorrowed.TabIndex = 0;
            tabMostBorrowed.Text = "Sách Mượn Nhiều";
            // 
            // tabActiveMembers
            // 
            tabActiveMembers.Location = new Point(4, 29);
            tabActiveMembers.Name = "tabActiveMembers";
            tabActiveMembers.Size = new Size(752, 17);
            tabActiveMembers.TabIndex = 1;
            tabActiveMembers.Text = "Độc Giả Tích Cực";
            // 
            // tabCategoryStats
            // 
            tabCategoryStats.Location = new Point(4, 29);
            tabCategoryStats.Name = "tabCategoryStats";
            tabCategoryStats.Size = new Size(752, 17);
            tabCategoryStats.TabIndex = 2;
            tabCategoryStats.Text = "Thống Kê Thể Loại";
            // 
            // tabFineRevenue
            // 
            tabFineRevenue.Location = new Point(4, 29);
            tabFineRevenue.Name = "tabFineRevenue";
            tabFineRevenue.Size = new Size(752, 17);
            tabFineRevenue.TabIndex = 3;
            tabFineRevenue.Text = "Doanh Thu Phạt";
            // 
            // tabInventory
            // 
            tabInventory.Location = new Point(4, 29);
            tabInventory.Name = "tabInventory";
            tabInventory.Size = new Size(752, 17);
            tabInventory.TabIndex = 4;
            tabInventory.Text = "Tồn Kho";
            // 
            // dgvReport
            // 
            dgvReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReport.ColumnHeadersHeight = 29;
            dgvReport.Location = new Point(12, 192);
            dgvReport.Name = "dgvReport";
            dgvReport.ReadOnly = true;
            dgvReport.RowHeadersWidth = 51;
            dgvReport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReport.Size = new Size(1286, 539);
            dgvReport.TabIndex = 7;
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(794, 139);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(100, 30);
            btnGenerate.TabIndex = 5;
            btnGenerate.Text = "Tạo Báo Cáo";
            btnGenerate.Click += BtnGenerate_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(904, 139);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(100, 30);
            btnExport.TabIndex = 6;
            btnExport.Text = "Xuất Excel";
            btnExport.Click += BtnExport_Click;
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(374, 141);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(150, 27);
            dtpFrom.TabIndex = 2;
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(624, 141);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(150, 27);
            dtpTo.TabIndex = 4;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(304, 144);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(65, 20);
            lblFrom.TabIndex = 1;
            lblFrom.Text = "Từ ngày:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(544, 144);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(75, 20);
            lblTo.TabIndex = 3;
            lblTo.Text = "Đến ngày:";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Arial", 10F, FontStyle.Bold);
            lblTotal.Location = new Point(187, 566);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 19);
            lblTotal.TabIndex = 8;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 128, 128);
            lblTitle.Location = new Point(374, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(530, 50);
            lblTitle.TabIndex = 9;
            lblTitle.Text = "📚 DANH SÁCH PHIẾU PHẠT";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ButtonFace;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(1254, 9);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(44, 36);
            guna2Button1.TabIndex = 12;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FormReport
            // 
            ClientSize = new Size(1310, 743);
            Controls.Add(guna2Button1);
            Controls.Add(lblTitle);
            Controls.Add(tabControl);
            Controls.Add(lblFrom);
            Controls.Add(dtpFrom);
            Controls.Add(lblTo);
            Controls.Add(dtpTo);
            Controls.Add(btnGenerate);
            Controls.Add(btnExport);
            Controls.Add(dgvReport);
            Controls.Add(lblTotal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo và Thống Kê";
            Load += FormReport_Load_1;
            tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvReport.DataSource = null;
            lblTotal.Text = "";
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dtpFrom.Value.Date;
                DateTime toDate = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);

                switch (tabControl.SelectedIndex)
                {
                    case 0: // Sách mượn nhiều nhất
                        GenerateMostBorrowedBooksReport(fromDate, toDate);
                        break;
                    case 1: // Độc giả tích cực
                        GenerateActiveMembersReport(fromDate, toDate);
                        break;
                    case 2: // Thống kê thể loại
                        GenerateCategoryStatsReport();
                        break;
                    case 3: // Doanh thu phạt
                        GenerateFineRevenueReport(fromDate, toDate);
                        break;
                    case 4: // Tồn kho
                        GenerateInventoryReport();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo báo cáo: " + ex.Message);
            }
        }

        private void GenerateMostBorrowedBooksReport(DateTime from, DateTime to)
        {
            var report = db.LoanDetails
                .Include(ld => ld.Book)
                .ThenInclude(b => b.Author)
                .Include(ld => ld.Book.Category)
                .Include(ld => ld.Loan)
                .Where(ld => ld.Loan.LoanDate >= from && ld.Loan.LoanDate <= to)
                .GroupBy(ld => new
                {
                    ld.BookId,
                    ld.Book.Title,
                    AuthorName = ld.Book.Author.Name,
                    CategoryName = ld.Book.Category.Name
                })
                .Select(g => new
                {
                    MaSach = g.Key.BookId,
                    TenSach = g.Key.Title,
                    TacGia = g.Key.AuthorName,
                    TheLoai = g.Key.CategoryName,
                    SoLanMuon = g.Count(),
                    TongSoLuong = g.Sum(ld => ld.SoLuong)
                })
                .OrderByDescending(x => x.SoLanMuon)
                .Take(20)
                .ToList();

            dgvReport.DataSource = report;
            lblTotal.Text = $"Tổng số đầu sách được mượn: {report.Count}";

            dgvReport.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvReport.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvReport.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvReport.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvReport.Columns["SoLanMuon"].HeaderText = "Số Lần Mượn";
            dgvReport.Columns["TongSoLuong"].HeaderText = "Tổng SL Mượn";
        }

        private void GenerateActiveMembersReport(DateTime from, DateTime to)
        {
            var report = db.Loans
                .Include(l => l.Member)
                .Include(l => l.LoanDetails)
                .Where(l => l.LoanDate >= from && l.LoanDate <= to)
                .GroupBy(l => new
                {
                    l.MemberId,
                    l.Member.FullName,
                    l.Member.PhoneNumber,
                    l.Member.Email
                })
                .Select(g => new
                {
                    MaDocGia = g.Key.MemberId,
                    HoTen = g.Key.FullName,
                    SoDienThoai = g.Key.PhoneNumber,
                    Email = g.Key.Email,
                    SoPhieuMuon = g.Count(),
                    TongSachMuon = g.Sum(l => l.LoanDetails.Sum(ld => ld.SoLuong))
                })
                .OrderByDescending(x => x.TongSachMuon)
                .Take(20)
                .ToList();

            dgvReport.DataSource = report;
            lblTotal.Text = $"Top {report.Count} độc giả tích cực nhất";

            dgvReport.Columns["MaDocGia"].HeaderText = "Mã Độc Giả";
            dgvReport.Columns["HoTen"].HeaderText = "Họ Tên";
            dgvReport.Columns["SoDienThoai"].HeaderText = "Số ĐT";
            dgvReport.Columns["Email"].HeaderText = "Email";
            dgvReport.Columns["SoPhieuMuon"].HeaderText = "Số Phiếu Mượn";
            dgvReport.Columns["TongSachMuon"].HeaderText = "Tổng Sách Mượn";
        }

        private void GenerateCategoryStatsReport()
        {
            var report = db.Categories
                .Select(c => new
                {
                    TheLoai = c.Name,
                    SoLuongSach = c.Books.Count(),
                    TongTonKho = c.Books.Sum(b => b.SoLuongTon),
                    SoLanMuon = c.Books.SelectMany(b => b.LoanDetails).Count()
                })
                .OrderByDescending(x => x.SoLuongSach)
                .ToList();

            dgvReport.DataSource = report;
            lblTotal.Text = $"Tổng số thể loại: {report.Count}";

            dgvReport.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvReport.Columns["SoLuongSach"].HeaderText = "Số Lượng Sách";
            dgvReport.Columns["TongTonKho"].HeaderText = "Tổng Tồn Kho";
            dgvReport.Columns["SoLanMuon"].HeaderText = "Số Lần Mượn";
        }

        private void GenerateFineRevenueReport(DateTime from, DateTime to)
        {
            var report = db.Fines
                .Include(f => f.Loan)
                .ThenInclude(l => l.Member)
                .Where(f => f.NgayPhat >= from && f.NgayPhat <= to)
                .Select(f => new
                {
                    MaPhat = f.FineId,
                    MaPhieuMuon = f.LoanId,
                    DocGia = f.Loan.Member.FullName,
                    LyDo = f.LyDo,
                    SoTienPhat = f.SoTienPhat,
                    NgayPhat = f.NgayPhat,
                    TrangThai = f.TrangThaiThanhToan
                })
                .OrderByDescending(x => x.NgayPhat)
                .ToList();

            dgvReport.DataSource = report;

            decimal totalFines = report.Sum(r => r.SoTienPhat);
            decimal paidFines = report.Where(r => r.TrangThai == "Đã thanh toán").Sum(r => r.SoTienPhat);
            decimal unpaidFines = totalFines - paidFines;

            lblTotal.Text = $"Tổng phạt: {totalFines:N0} VNĐ | Đã thu: {paidFines:N0} VNĐ | Chưa thu: {unpaidFines:N0} VNĐ";

            dgvReport.Columns["MaPhat"].HeaderText = "Mã Phạt";
            dgvReport.Columns["MaPhieuMuon"].HeaderText = "Mã Phiếu Mượn";
            dgvReport.Columns["DocGia"].HeaderText = "Độc Giả";
            dgvReport.Columns["LyDo"].HeaderText = "Lý Do";
            dgvReport.Columns["SoTienPhat"].HeaderText = "Số Tiền";
            dgvReport.Columns["NgayPhat"].HeaderText = "Ngày Phạt";
            dgvReport.Columns["TrangThai"].HeaderText = "Trạng Thái";
        }

        private void GenerateInventoryReport()
        {
            var report = db.Books
                .Include(b => b.Category)
                .Include(b => b.Author)
                .Include(b => b.Publisher)
                .Select(b => new
                {
                    MaSach = b.BookId,
                    TenSach = b.Title,
                    TacGia = b.Author.Name,
                    TheLoai = b.Category.Name,
                    NhaXuatBan = b.Publisher.TenNhaXuatBan,
                    SoLuongTon = b.SoLuongTon,
                    ViTri = b.ViTri,
                    TrangThai = b.TrangThai,
                    CanhBao = b.SoLuongTon == 0 ? "Hết sách" :
                              b.SoLuongTon <= 5 ? "Sắp hết" : "Đủ"
                })
                .OrderBy(x => x.SoLuongTon)
                .ToList();

            dgvReport.DataSource = report;

            int totalBooks = report.Count;
            int outOfStock = report.Count(r => r.SoLuongTon == 0);
            int lowStock = report.Count(r => r.SoLuongTon > 0 && r.SoLuongTon <= 5);

            lblTotal.Text = $"Tổng: {totalBooks} đầu sách | Hết: {outOfStock} | Sắp hết: {lowStock}";

            dgvReport.Columns["MaSach"].HeaderText = "Mã Sách";
            dgvReport.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvReport.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvReport.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvReport.Columns["NhaXuatBan"].HeaderText = "NXB";
            dgvReport.Columns["SoLuongTon"].HeaderText = "Tồn Kho";
            dgvReport.Columns["ViTri"].HeaderText = "Vị Trí";
            dgvReport.Columns["TrangThai"].HeaderText = "Trạng Thái";
            dgvReport.Columns["CanhBao"].HeaderText = "Cảnh Báo";

            // Highlight rows
            foreach (DataGridViewRow row in dgvReport.Rows)
            {
                if (row.Cells["CanhBao"].Value?.ToString() == "Hết sách")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightPink;
                }
                else if (row.Cells["CanhBao"].Value?.ToString() == "Sắp hết")
                {
                    row.DefaultCellStyle.BackColor = System.Drawing.Color.LightYellow;
                }
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng xuất Excel đang được phát triển!\n\nBạn có thể copy dữ liệu từ bảng và paste vào Excel.",
                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Controls
        private TabControl tabControl;
        private TabPage tabMostBorrowed;
        private TabPage tabActiveMembers;
        private TabPage tabCategoryStats;
        private TabPage tabFineRevenue;
        private TabPage tabInventory;
        private DataGridView dgvReport;
        private Button btnGenerate;
        private Button btnExport;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lblFrom;
        private Label lblTo;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Label lblTotal;

        private void FormReport_Load_1(object? sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
