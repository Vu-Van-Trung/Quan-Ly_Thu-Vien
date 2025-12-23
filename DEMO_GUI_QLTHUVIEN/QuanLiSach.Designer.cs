#nullable disable
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class QuanLiSach
    {
        private IContainer components = null;

        private Label lblTitle;
        private Panel topPanel;

        private GroupBox grpDetails;
        private Label lblBookId;
        private TextBox txtBookId;
        private Label lblTitleBook;
        private TextBox txtTitle;
        
        private Label lblPublishedYear;
        private TextBox txtPublishedYear;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblCategory;
        private TextBox txtCategory;
        private Label lblPublisherCode;
        private TextBox txtPublisherCode;
        private Label lblPublisherName;
        private TextBox txtPublisherName;
        private TableLayoutPanel buttonPanel;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;

        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnReload;

        private DataGridView dgvBooks;
        private BindingSource bindingSourceBooks;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            lblTitle = new Label();
            topPanel = new Panel();
            grpDetails = new GroupBox();
            lblBookId = new Label();
            txtBookId = new TextBox();
            lblTitleBook = new Label();
            txtTitle = new TextBox();
            lblPublishedYear = new Label();
            txtPublishedYear = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            lblPublisherCode = new Label();
            txtPublisherCode = new TextBox();
            lblPublisherName = new Label();
            txtPublisherName = new TextBox();
            buttonPanel = new TableLayoutPanel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnReload = new Button();
            dgvBooks = new DataGridView();
            bindingSourceBooks = new BindingSource(components);
            topPanel.SuspendLayout();
            grpDetails.SuspendLayout();
            buttonPanel.SuspendLayout();
            ((ISupportInitialize)dgvBooks).BeginInit();
            ((ISupportInitialize)bindingSourceBooks).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1000, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SÁCH";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(33, 150, 243);
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1000, 60);
            topPanel.TabIndex = 0;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblBookId);
            grpDetails.Controls.Add(txtBookId);
            grpDetails.Controls.Add(lblTitleBook);
            grpDetails.Controls.Add(txtTitle);
            grpDetails.Controls.Add(lblPublishedYear);
            grpDetails.Controls.Add(txtPublishedYear);
            grpDetails.Controls.Add(lblAuthor);
            grpDetails.Controls.Add(txtAuthor);
            grpDetails.Controls.Add(lblCategory);
            grpDetails.Controls.Add(txtCategory);
            grpDetails.Controls.Add(lblPublisherCode);
            grpDetails.Controls.Add(txtPublisherCode);
            grpDetails.Controls.Add(lblPublisherName);
            grpDetails.Controls.Add(txtPublisherName);
            grpDetails.Location = new Point(12, 70);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(360, 330);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "📚 Thông Tin Sách";
            grpDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetails.ForeColor = Color.FromArgb(33, 150, 243);
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(15, 35);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(68, 20);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Mã Sách:";
            // 
            // txtBookId
            // 
            txtBookId.BackColor = SystemColors.ControlLight;
            txtBookId.Location = new Point(110, 32);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(230, 27);
            txtBookId.TabIndex = 1;
            // 
            // lblTitleBook
            // 
            lblTitleBook.AutoSize = true;
            lblTitleBook.Location = new Point(15, 75);
            lblTitleBook.Name = "lblTitleBook";
            lblTitleBook.Size = new Size(70, 20);
            lblTitleBook.TabIndex = 2;
            lblTitleBook.Text = "Tên Sách:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(110, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(230, 27);
            txtTitle.TabIndex = 3;
            // 
            // lblPublishedYear
            // 
            lblPublishedYear.AutoSize = true;
            lblPublishedYear.Location = new Point(15, 115);
            lblPublishedYear.Name = "lblPublishedYear";
            lblPublishedYear.Size = new Size(66, 20);
            lblPublishedYear.TabIndex = 6;
            lblPublishedYear.Text = "Năm XB:";
            // 
            // txtPublishedYear
            // 
            txtPublishedYear.Location = new Point(110, 112);
            txtPublishedYear.Name = "txtPublishedYear";
            txtPublishedYear.Size = new Size(230, 27);
            txtPublishedYear.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(15, 155);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(59, 20);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Tác Giả:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(110, 152);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(230, 27);
            txtAuthor.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 195);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 20);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Thể Loại:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(110, 192);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(230, 27);
            txtCategory.TabIndex = 11;
            // 
            // lblPublisherCode
            // 
            lblPublisherCode.AutoSize = true;
            lblPublisherCode.Location = new Point(15, 235);
            lblPublisherCode.Name = "lblPublisherCode";
            lblPublisherCode.Size = new Size(86, 20);
            lblPublisherCode.TabIndex = 12;
            lblPublisherCode.Text = "Mã NXB (#):";
            // 
            // txtPublisherCode
            // 
            txtPublisherCode.Location = new Point(110, 232);
            txtPublisherCode.Name = "txtPublisherCode";
            txtPublisherCode.ReadOnly = true;
            txtPublisherCode.Size = new Size(230, 27);
            txtPublisherCode.TabIndex = 13;
            // 
            // lblPublisherName
            // 
            lblPublisherName.AutoSize = true;
            lblPublisherName.Location = new Point(15, 275);
            lblPublisherName.Name = "lblPublisherName";
            lblPublisherName.Size = new Size(78, 20);
            lblPublisherName.TabIndex = 14;
            lblPublisherName.Text = "Tên NXB:";
            // 
            // txtPublisherName
            // 
            txtPublisherName.BackColor = SystemColors.ControlLight;
            txtPublisherName.Location = new Point(110, 272);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.ReadOnly = true;
            txtPublisherName.Size = new Size(230, 27);
            txtPublisherName.TabIndex = 15;
            txtPublisherName.TabStop = false;
            // 
            // buttonPanel
            // 
            buttonPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPanel.ColumnCount = 5;
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            buttonPanel.Controls.Add(btnAdd, 0, 0);
            buttonPanel.Controls.Add(btnEdit, 1, 0);
            buttonPanel.Controls.Add(btnDelete, 2, 0);
            buttonPanel.Controls.Add(btnSave, 3, 0);
            buttonPanel.Controls.Add(btnCancel, 4, 0);
            buttonPanel.Location = new Point(12, 410);
            buttonPanel.Name = "buttonPanel";
            buttonPanel.RowCount = 1;
            buttonPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            buttonPanel.Size = new Size(360, 44);
            buttonPanel.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.ForeColor = Color.White;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Margin = new Padding(5, 0, 5, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(62, 44);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Thêm";
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            btnEdit.ForeColor = Color.White;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Margin = new Padding(5, 0, 5, 0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(62, 44);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ Sửa";
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.ForeColor = Color.White;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Margin = new Padding(5, 0, 5, 0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(62, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑️ Xóa";
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.ForeColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Enabled = false;
            btnSave.Dock = DockStyle.Fill;
            btnSave.Margin = new Padding(5, 0, 5, 0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(62, 44);
            btnSave.TabIndex = 3;
            btnSave.Text = "💾 Lưu";
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.Cursor = Cursors.Hand;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(158, 158, 158);
            btnCancel.ForeColor = Color.White;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Enabled = false;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Margin = new Padding(5, 0, 5, 0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(63, 44);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "✖️ Hủy";
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.Cursor = Cursors.Hand;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(390, 65);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm theo tên sách...";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(650, 63);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 26);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(730, 63);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(70, 26);
            btnReload.TabIndex = 5;
            btnReload.Text = "Tải lại";
            // 
            // dgvBooks
            // 
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dgvBooks.ColumnHeadersHeight = 40;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            dgvBooks.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBooks.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvBooks.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            dgvBooks.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dgvBooks.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvBooks.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            dgvBooks.RowTemplate.Height = 35;
            dgvBooks.Location = new Point(390, 100);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(580, 400);
            dgvBooks.TabIndex = 6;
            // 
            // QuanLiSach
            // 
            ClientSize = new Size(1000, 520);
            Controls.Add(topPanel);
            Controls.Add(grpDetails);
            Controls.Add(buttonPanel);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnReload);
            Controls.Add(dgvBooks);
            Font = new Font("Segoe UI", 9F);
            Name = "QuanLiSach";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Sách";
            Load += QuanLiSach_Load_1;
            topPanel.ResumeLayout(false);
            grpDetails.ResumeLayout(false);
            grpDetails.PerformLayout();
            buttonPanel.ResumeLayout(false);
            ((ISupportInitialize)dgvBooks).EndInit();
            ((ISupportInitialize)bindingSourceBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}