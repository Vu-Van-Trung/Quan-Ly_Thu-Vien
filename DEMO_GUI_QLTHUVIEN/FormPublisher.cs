using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace DoAnDemoUI
{
    /// <summary>
    /// Form quản lý Nhà xuất bản
    /// </summary>
    public partial class FormPublisher : Form
    {
        private LibraryContext db;
        private bool isEditing = false;

        public FormPublisher()
        {
            InitializeComponent();
            this.Load += FormPublisher_Load;
        }

        private void FormPublisher_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadData();
            SetControlState(false);
        }

        private void InitializeComponent()
        {
            this.dgvPublishers = new DataGridView();
            this.txtPublisherId = new TextBox();
            this.txtTenNhaXuatBan = new TextBox();
            this.txtDiaChi = new TextBox();
            this.txtSoDienThoai = new TextBox();
            this.txtEmail = new TextBox();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dgvPublishers.Location = new System.Drawing.Point(20, 20);
            this.dgvPublishers.Size = new System.Drawing.Size(750, 300);
            this.dgvPublishers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublishers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublishers.SelectionChanged += DgvPublishers_SelectionChanged;

            // Labels and TextBoxes
            int startY = 340;
            int labelX = 30;
            int textX = 200;
            int stepY = 40;

            AddLabelAndTextBox("Mã NXB:", txtPublisherId, labelX, textX, startY, 0);
            txtPublisherId.ReadOnly = true;

            AddLabelAndTextBox("Tên NXB:", txtTenNhaXuatBan, labelX, textX, startY, 1);
            AddLabelAndTextBox("Địa chỉ:", txtDiaChi, labelX, textX, startY, 2);
            AddLabelAndTextBox("Số ĐT:", txtSoDienThoai, labelX, textX, startY, 3);
            AddLabelAndTextBox("Email:", txtEmail, labelX, textX, startY, 4);

            // Buttons
            int btnY = startY + stepY * 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Location = new System.Drawing.Point(30, btnY);
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.Click += BtnAdd_Click;

            this.btnEdit.Text = "Sửa";
            this.btnEdit.Location = new System.Drawing.Point(120, btnY);
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.Click += BtnEdit_Click;

            this.btnDelete.Text = "Xóa";
            this.btnDelete.Location = new System.Drawing.Point(210, btnY);
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.Click += BtnDelete_Click;

            this.btnSave.Text = "Lưu";
            this.btnSave.Location = new System.Drawing.Point(300, btnY);
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.Click += BtnSave_Click;

            this.btnCancel.Text = "Hủy";
            this.btnCancel.Location = new System.Drawing.Point(390, btnY);
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.Click += BtnCancel_Click;

            // Form
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvPublishers);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Text = "Quản Lý Nhà Xuất Bản";
            this.StartPosition = FormStartPosition.CenterScreen;

            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).EndInit();
            this.ResumeLayout(false);
        }

        private void AddLabelAndTextBox(string labelText, TextBox textBox, int labelX, int textX, int startY, int index)
        {
            var label = new Label();
            label.Text = labelText;
            label.Location = new System.Drawing.Point(labelX, startY + index * 40);
            label.AutoSize = true;

            textBox.Location = new System.Drawing.Point(textX, startY + index * 40 - 3);
            textBox.Size = new System.Drawing.Size(300, 23);

            this.Controls.Add(label);
            this.Controls.Add(textBox);
        }

        private void LoadData()
        {
            try
            {
                var publishers = db.Publishers
                    .Select(p => new
                    {
                        p.PublisherId,
                        p.TenNhaXuatBan,
                        p.DiaChi,
                        p.SoDienThoai,
                        p.Email
                    })
                    .ToList();

                dgvPublishers.DataSource = publishers;
                dgvPublishers.Columns["PublisherId"].HeaderText = "Mã NXB";
                dgvPublishers.Columns["TenNhaXuatBan"].HeaderText = "Tên Nhà Xuất Bản";
                dgvPublishers.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvPublishers.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
                dgvPublishers.Columns["Email"].HeaderText = "Email";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DgvPublishers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPublishers.CurrentRow != null && !isEditing)
            {
                var row = dgvPublishers.CurrentRow;
                txtPublisherId.Text = row.Cells["PublisherId"].Value?.ToString();
                txtTenNhaXuatBan.Text = row.Cells["TenNhaXuatBan"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtSoDienThoai.Text = row.Cells["SoDienThoai"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            isEditing = true;
            SetControlState(true);
            ClearInputs();
            txtPublisherId.Text = "(Tự động)";
            txtTenNhaXuatBan.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dgvPublishers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần sửa!");
                return;
            }
            isEditing = true;
            SetControlState(true);
            txtTenNhaXuatBan.Focus();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPublishers.CurrentRow == null) return;

            int publisherId = Convert.ToInt32(dgvPublishers.CurrentRow.Cells["PublisherId"].Value);
            string name = dgvPublishers.CurrentRow.Cells["TenNhaXuatBan"].Value.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhà xuất bản '{name}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var publisher = db.Publishers.Find(publisherId);
                    if (publisher != null)
                    {
                        db.Publishers.Remove(publisher);
                        db.SaveChanges();
                        LoadData();
                        MessageBox.Show("Xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa (có thể do có sách liên quan).\\nLỗi: " + ex.Message);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaXuatBan.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà xuất bản!");
                return;
            }

            try
            {
                if (txtPublisherId.Text == "(Tự động)" || string.IsNullOrEmpty(txtPublisherId.Text))
                {
                    // Thêm mới
                    var newPublisher = new Publisher
                    {
                        TenNhaXuatBan = txtTenNhaXuatBan.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        SoDienThoai = txtSoDienThoai.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    };
                    db.Publishers.Add(newPublisher);
                    db.SaveChanges();
                    MessageBox.Show("Thêm nhà xuất bản thành công!");
                }
                else
                {
                    // Cập nhật
                    int publisherId = int.Parse(txtPublisherId.Text);
                    var publisher = db.Publishers.Find(publisherId);
                    if (publisher != null)
                    {
                        publisher.TenNhaXuatBan = txtTenNhaXuatBan.Text.Trim();
                        publisher.DiaChi = txtDiaChi.Text.Trim();
                        publisher.SoDienThoai = txtSoDienThoai.Text.Trim();
                        publisher.Email = txtEmail.Text.Trim();
                        publisher.NgayCapNhat = DateTime.Now;

                        db.SaveChanges();
                        MessageBox.Show("Cập nhật thành công!");
                    }
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu: " + ex.Message);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isEditing = false;
            SetControlState(false);
            DgvPublishers_SelectionChanged(null, null);
        }

        private void SetControlState(bool editing)
        {
            txtTenNhaXuatBan.ReadOnly = !editing;
            txtDiaChi.ReadOnly = !editing;
            txtSoDienThoai.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;

            btnAdd.Enabled = !editing;
            btnEdit.Enabled = !editing;
            btnDelete.Enabled = !editing;

            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;

            dgvPublishers.Enabled = !editing;
        }

        private void ClearInputs()
        {
            txtPublisherId.Clear();
            txtTenNhaXuatBan.Clear();
            txtDiaChi.Clear();
            txtSoDienThoai.Clear();
            txtEmail.Clear();
        }

        // Controls
        private DataGridView dgvPublishers;
        private TextBox txtPublisherId;
        private TextBox txtTenNhaXuatBan;
        private TextBox txtDiaChi;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
    }
}
