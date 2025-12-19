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

        // Đã sửa: Dùng TextBox thay vì ComboBox để nhập liệu trực tiếp
        private Label lblAuthor;
        private TextBox txtAuthor; // Thay cho cbAuthor

        private Label lblCategory;
        private TextBox txtCategory; // Thay cho cbCategory

        private Label lblISBN;
        private TextBox txtISBN;

        private Label lblPublishedYear;
        private TextBox txtPublishedYear;

        private FlowLayoutPanel flowButtons;
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
            lblISBN = new Label();
            txtISBN = new TextBox();
            lblPublishedYear = new Label();
            txtPublishedYear = new TextBox();
            lblAuthor = new Label();
            txtAuthor = new TextBox();
            lblCategory = new Label();
            txtCategory = new TextBox();
            flowButtons = new FlowLayoutPanel();
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
            flowButtons.SuspendLayout();
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
            topPanel.BackColor = Color.Teal;
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1000, 50);
            topPanel.TabIndex = 0;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblBookId);
            grpDetails.Controls.Add(txtBookId);
            grpDetails.Controls.Add(lblTitleBook);
            grpDetails.Controls.Add(txtTitle);
            grpDetails.Controls.Add(lblISBN);
            grpDetails.Controls.Add(txtISBN);
            grpDetails.Controls.Add(lblPublishedYear);
            grpDetails.Controls.Add(txtPublishedYear);
            grpDetails.Controls.Add(lblAuthor);
            grpDetails.Controls.Add(txtAuthor);
            grpDetails.Controls.Add(lblCategory);
            grpDetails.Controls.Add(txtCategory);
            grpDetails.Location = new Point(12, 60);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(360, 320);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "Thông tin sách";
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
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Location = new Point(15, 115);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(44, 20);
            lblISBN.TabIndex = 4;
            lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(110, 112);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(230, 27);
            txtISBN.TabIndex = 5;
            // 
            // lblPublishedYear
            // 
            lblPublishedYear.AutoSize = true;
            lblPublishedYear.Location = new Point(15, 155);
            lblPublishedYear.Name = "lblPublishedYear";
            lblPublishedYear.Size = new Size(66, 20);
            lblPublishedYear.TabIndex = 6;
            lblPublishedYear.Text = "Năm XB:";
            // 
            // txtPublishedYear
            // 
            txtPublishedYear.Location = new Point(110, 152);
            txtPublishedYear.Name = "txtPublishedYear";
            txtPublishedYear.Size = new Size(230, 27);
            txtPublishedYear.TabIndex = 7;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(15, 195);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(59, 20);
            lblAuthor.TabIndex = 8;
            lblAuthor.Text = "Tác Giả:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(110, 192);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(230, 27);
            txtAuthor.TabIndex = 9;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 235);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(68, 20);
            lblCategory.TabIndex = 10;
            lblCategory.Text = "Thể Loại:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(110, 232);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(230, 27);
            txtCategory.TabIndex = 11;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowButtons.Controls.Add(btnAdd);
            flowButtons.Controls.Add(btnEdit);
            flowButtons.Controls.Add(btnDelete);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Controls.Add(btnCancel);
            flowButtons.Location = new Point(12, 400);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(360, 44);
            flowButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.ForestGreen;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 30);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Orange;
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(74, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(65, 30);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(145, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.Location = new Point(216, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 30);
            btnSave.TabIndex = 3;
            btnSave.Text = "Lưu";
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Location = new Point(287, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 30);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Hủy";
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
            dgvBooks.ColumnHeadersHeight = 29;
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
            Controls.Add(flowButtons);
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
            flowButtons.ResumeLayout(false);
            ((ISupportInitialize)dgvBooks).EndInit();
            ((ISupportInitialize)bindingSourceBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}