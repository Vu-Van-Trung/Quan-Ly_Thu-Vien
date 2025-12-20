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
        private Label lblPublisherCode;
        private TextBox txtPublisherCode;
        private Label lblPublisherName;
        private TextBox txtPublisherName;
        private Label lblPublishedYear;
        private TextBox txtPublishedYear;
        private Label lblAuthor;
        private TextBox txtAuthor;
        private Label lblCategory;
        private TextBox txtCategory; // Thay cho cbCategory

        private Label lblISBN;
        private TextBox txtISBN;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            topPanel = new Panel();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            grpDetails = new GroupBox();
            lblBookId = new Label();
            txtBookId = new TextBox();
            lblTitleBook = new Label();
            txtTitle = new TextBox();
            lblPublisherCode = new Label();
            txtPublisherCode = new TextBox();
            lblPublisherName = new Label();
            txtPublisherName = new TextBox();
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
            lblTitle.Size = new Size(1310, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SÁCH";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(33, 150, 243);
            topPanel.Controls.Add(guna2Button1);
            topPanel.Controls.Add(lblTitle);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1310, 60);
            topPanel.TabIndex = 0;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.DodgerBlue;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(1254, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(44, 36);
            guna2Button1.TabIndex = 1;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // grpDetails
            // 
            grpDetails.Controls.Add(lblBookId);
            grpDetails.Controls.Add(txtBookId);
            grpDetails.Controls.Add(lblTitleBook);
            grpDetails.Controls.Add(txtTitle);
            grpDetails.Controls.Add(lblPublisherCode);
            grpDetails.Controls.Add(txtPublisherCode);
            grpDetails.Controls.Add(lblPublisherName);
            grpDetails.Controls.Add(txtPublisherName);
            grpDetails.Controls.Add(lblPublishedYear);
            grpDetails.Controls.Add(txtPublishedYear);
            grpDetails.Controls.Add(lblAuthor);
            grpDetails.Controls.Add(txtAuthor);
            grpDetails.Controls.Add(lblCategory);
            grpDetails.Controls.Add(txtCategory);
            grpDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetails.ForeColor = Color.FromArgb(33, 150, 243);
            grpDetails.Location = new Point(12, 83);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(360, 360);
            grpDetails.TabIndex = 1;
            grpDetails.TabStop = false;
            grpDetails.Text = "📚 Thông Tin Sách";
            // 
            // lblBookId
            // 
            lblBookId.AutoSize = true;
            lblBookId.Location = new Point(15, 35);
            lblBookId.Name = "lblBookId";
            lblBookId.Size = new Size(82, 23);
            lblBookId.TabIndex = 0;
            lblBookId.Text = "Mã Sách:";
            // 
            // txtBookId
            // 
            txtBookId.BackColor = SystemColors.ControlLight;
            txtBookId.Location = new Point(110, 32);
            txtBookId.Name = "txtBookId";
            txtBookId.ReadOnly = true;
            txtBookId.Size = new Size(230, 30);
            txtBookId.TabIndex = 1;
            // 
            // lblTitleBook
            // 
            lblTitleBook.AutoSize = true;
            lblTitleBook.Location = new Point(15, 75);
            lblTitleBook.Name = "lblTitleBook";
            lblTitleBook.Size = new Size(84, 23);
            lblTitleBook.TabIndex = 2;
            lblTitleBook.Text = "Tên Sách:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(110, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(230, 30);
            txtTitle.TabIndex = 3;
            // 
            // lblPublisherCode
            // 
            lblPublisherCode.AutoSize = true;
            lblPublisherCode.Location = new Point(15, 115);
            lblPublisherCode.Name = "lblPublisherCode";
            lblPublisherCode.Size = new Size(80, 23);
            lblPublisherCode.TabIndex = 4;
            lblPublisherCode.Text = "Mã NXB:";
            // 
            // txtPublisherCode
            // 
            txtPublisherCode.Location = new Point(110, 112);
            txtPublisherCode.Name = "txtPublisherCode";
            txtPublisherCode.Size = new Size(230, 30);
            txtPublisherCode.TabIndex = 5;
            // 
            // lblPublisherName
            // 
            lblPublisherName.AutoSize = true;
            lblPublisherName.Location = new Point(15, 155);
            lblPublisherName.Name = "lblPublisherName";
            lblPublisherName.Size = new Size(82, 23);
            lblPublisherName.TabIndex = 6;
            lblPublisherName.Text = "Tên NXB:";
            // 
            // txtPublisherName
            // 
            txtPublisherName.BackColor = SystemColors.ControlLight;
            txtPublisherName.Location = new Point(110, 152);
            txtPublisherName.Name = "txtPublisherName";
            txtPublisherName.ReadOnly = true;
            txtPublisherName.Size = new Size(230, 30);
            txtPublisherName.TabIndex = 7;
            // 
            // lblPublishedYear
            // 
            lblPublishedYear.AutoSize = true;
            lblPublishedYear.Location = new Point(15, 195);
            lblPublishedYear.Name = "lblPublishedYear";
            lblPublishedYear.Size = new Size(80, 23);
            lblPublishedYear.TabIndex = 8;
            lblPublishedYear.Text = "Năm XB:";
            // 
            // txtPublishedYear
            // 
            txtPublishedYear.Location = new Point(110, 192);
            txtPublishedYear.Name = "txtPublishedYear";
            txtPublishedYear.Size = new Size(230, 30);
            txtPublishedYear.TabIndex = 9;
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(15, 235);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(72, 23);
            lblAuthor.TabIndex = 10;
            lblAuthor.Text = "Tác Giả:";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(110, 232);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(230, 30);
            txtAuthor.TabIndex = 11;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(15, 275);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(82, 23);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Thể Loại:";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(110, 272);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(230, 30);
            txtCategory.TabIndex = 13;
            // 
            // flowButtons
            // 
            flowButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            flowButtons.Controls.Add(btnAdd);
            flowButtons.Controls.Add(btnEdit);
            flowButtons.Controls.Add(btnDelete);
            flowButtons.Controls.Add(btnSave);
            flowButtons.Controls.Add(btnCancel);
            flowButtons.Location = new Point(12, 663);
            flowButtons.Name = "flowButtons";
            flowButtons.Size = new Size(360, 44);
            flowButtons.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(65, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "➕ Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(74, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(65, 34);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✏️ Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(145, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(65, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "🗑️ Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.Cursor = Cursors.Hand;
            btnSave.Enabled = false;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(216, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(65, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "💾 Lưu";
            btnSave.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(158, 158, 158);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Enabled = false;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(287, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(65, 34);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "✖️ Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(390, 82);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm kiếm theo tên sách...";
            txtSearch.Size = new Size(250, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(655, 82);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(70, 26);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm";
            // 
            // btnReload
            // 
            btnReload.Location = new Point(731, 83);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(70, 26);
            btnReload.TabIndex = 5;
            btnReload.Text = "Tải lại";
            // 
            // dgvBooks
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvBooks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBooks.BackgroundColor = Color.White;
            dgvBooks.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBooks.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvBooks.DefaultCellStyle = dataGridViewCellStyle3;
            dgvBooks.EnableHeadersVisualStyles = false;
            dgvBooks.Location = new Point(390, 126);
            dgvBooks.MultiSelect = false;
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.RowTemplate.Height = 35;
            dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBooks.Size = new Size(890, 597);
            dgvBooks.TabIndex = 6;
            // 
            // QuanLiSach
            // 
            ClientSize = new Size(1310, 743);
            Controls.Add(topPanel);
            Controls.Add(grpDetails);
            Controls.Add(flowButtons);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnReload);
            Controls.Add(dgvBooks);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
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
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}