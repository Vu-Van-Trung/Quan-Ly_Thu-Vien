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
            this.components = new Container();
            this.lblTitle = new Label();
            this.topPanel = new Panel();
            this.grpDetails = new GroupBox();

            this.lblBookId = new Label();
            this.txtBookId = new TextBox();
            this.lblTitleBook = new Label();
            this.txtTitle = new TextBox();

            // Khởi tạo TextBox cho Author và Category
            this.lblAuthor = new Label();
            this.txtAuthor = new TextBox();
            this.lblCategory = new Label();
            this.txtCategory = new TextBox();

            this.lblISBN = new Label();
            this.txtISBN = new TextBox();
            this.lblPublishedYear = new Label();
            this.txtPublishedYear = new TextBox();

            this.flowButtons = new FlowLayoutPanel();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            this.txtSearch = new TextBox();
            this.btnSearch = new Button();
            this.btnReload = new Button();

            this.dgvBooks = new DataGridView();
            this.bindingSourceBooks = new BindingSource(this.components);

            ((ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((ISupportInitialize)(this.bindingSourceBooks)).BeginInit();
            this.grpDetails.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.flowButtons.SuspendLayout();
            this.SuspendLayout();

            // 
            // topPanel & lblTitle
            // 
            this.topPanel.Dock = DockStyle.Top;
            this.topPanel.Height = 50;
            this.topPanel.BackColor = Color.Teal;
            this.topPanel.Controls.Add(this.lblTitle);

            this.lblTitle.Dock = DockStyle.Fill;
            this.lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.White;
            this.lblTitle.Text = "QUẢN LÝ SÁCH";

            // 
            // grpDetails
            // 
            this.grpDetails.Location = new Point(12, 60);
            this.grpDetails.Size = new Size(360, 260);
            this.grpDetails.Text = "Thông tin sách";

            // Layout constants
            int lblX = 15, txtX = 110, startY = 30, stepY = 35;

            // 1. Book ID
            this.lblBookId.Location = new Point(lblX, startY);
            this.lblBookId.Text = "Mã Sách:";
            this.lblBookId.AutoSize = true;

            this.txtBookId.Location = new Point(txtX, startY - 3);
            this.txtBookId.Size = new Size(230, 23);
            this.txtBookId.ReadOnly = true;
            this.txtBookId.BackColor = SystemColors.ControlLight;

            // 2. Title
            this.lblTitleBook.Location = new Point(lblX, startY + stepY);
            this.lblTitleBook.Text = "Tên Sách:";
            this.lblTitleBook.AutoSize = true;

            this.txtTitle.Location = new Point(txtX, startY + stepY - 3);
            this.txtTitle.Size = new Size(230, 23);

            // 3. ISBN
            this.lblISBN.Location = new Point(lblX, startY + stepY * 2);
            this.lblISBN.Text = "ISBN:";
            this.lblISBN.AutoSize = true;

            this.txtISBN.Location = new Point(txtX, startY + stepY * 2 - 3);
            this.txtISBN.Size = new Size(230, 23);

            // 4. Published Year
            this.lblPublishedYear.Location = new Point(lblX, startY + stepY * 3);
            this.lblPublishedYear.Text = "Năm XB:";
            this.lblPublishedYear.AutoSize = true;

            this.txtPublishedYear.Location = new Point(txtX, startY + stepY * 3 - 3);
            this.txtPublishedYear.Size = new Size(230, 23);

            // 5. Author (TextBox)
            this.lblAuthor.Location = new Point(lblX, startY + stepY * 4);
            this.lblAuthor.Text = "Tác Giả:";
            this.lblAuthor.AutoSize = true;

            this.txtAuthor.Location = new Point(txtX, startY + stepY * 4 - 3);
            this.txtAuthor.Size = new Size(230, 23);

            // 6. Category (TextBox)
            this.lblCategory.Location = new Point(lblX, startY + stepY * 5);
            this.lblCategory.Text = "Thể Loại:";
            this.lblCategory.AutoSize = true;

            this.txtCategory.Location = new Point(txtX, startY + stepY * 5 - 3);
            this.txtCategory.Size = new Size(230, 23);

            // Add controls to GroupBox
            this.grpDetails.Controls.AddRange(new Control[] {
                lblBookId, txtBookId,
                lblTitleBook, txtTitle,
                lblISBN, txtISBN,
                lblPublishedYear, txtPublishedYear,
                lblAuthor, txtAuthor,
                lblCategory, txtCategory
            });

            // 
            // flowButtons
            // 
            this.flowButtons.Location = new Point(12, 330);
            this.flowButtons.Size = new Size(360, 40);
            this.flowButtons.Controls.Add(btnAdd);
            this.flowButtons.Controls.Add(btnEdit);
            this.flowButtons.Controls.Add(btnDelete);
            this.flowButtons.Controls.Add(btnSave);
            this.flowButtons.Controls.Add(btnCancel);

            // Buttons Config
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Size = new Size(65, 30);
            this.btnAdd.BackColor = Color.ForestGreen;
            this.btnAdd.ForeColor = Color.White;

            this.btnEdit.Text = "Sửa";
            this.btnEdit.Size = new Size(65, 30);
            this.btnEdit.BackColor = Color.Orange;
            this.btnEdit.ForeColor = Color.White;

            this.btnDelete.Text = "Xóa";
            this.btnDelete.Size = new Size(65, 30);
            this.btnDelete.BackColor = Color.Firebrick;
            this.btnDelete.ForeColor = Color.White;

            this.btnSave.Text = "Lưu";
            this.btnSave.Size = new Size(65, 30);
            this.btnSave.Enabled = false;

            this.btnCancel.Text = "Hủy";
            this.btnCancel.Size = new Size(65, 30);
            this.btnCancel.Enabled = false;

            // 
            // Search Area
            // 
            this.txtSearch.Location = new Point(390, 65);
            this.txtSearch.Size = new Size(250, 23);
            this.txtSearch.PlaceholderText = "Tìm kiếm theo tên sách...";

            this.btnSearch.Location = new Point(650, 63);
            this.btnSearch.Size = new Size(70, 26);
            this.btnSearch.Text = "Tìm";

            this.btnReload.Location = new Point(730, 63);
            this.btnReload.Size = new Size(70, 26);
            this.btnReload.Text = "Tải lại";

            // 
            // dgvBooks
            // 
            this.dgvBooks.Location = new Point(390, 100);
            this.dgvBooks.Size = new Size(580, 400);
            this.dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.MultiSelect = false;

            // Form
            this.ClientSize = new Size(1000, 520);
            this.Controls.Add(topPanel);
            this.Controls.Add(grpDetails);
            this.Controls.Add(flowButtons);
            this.Controls.Add(txtSearch);
            this.Controls.Add(btnSearch);
            this.Controls.Add(btnReload);
            this.Controls.Add(dgvBooks);

            this.Name = "QuanLiSach";
            this.Text = "Quản Lý Sách";
            this.Font = new Font("Segoe UI", 9F);
            this.StartPosition = FormStartPosition.CenterScreen;

            ((ISupportInitialize)(this.dgvBooks)).EndInit();
            ((ISupportInitialize)(this.bindingSourceBooks)).EndInit();
            this.grpDetails.ResumeLayout(false);
            this.grpDetails.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.flowButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}