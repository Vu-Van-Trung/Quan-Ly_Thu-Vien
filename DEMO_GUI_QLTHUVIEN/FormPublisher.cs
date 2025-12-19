using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;

namespace DoAnDemoUI
{
    /// <summary>
    /// Form quản lý Nhà xuất bản - Enhanced UI
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
            this.grpInfo = new GroupBox();
            this.txtPublisherId = new TextBox();
            this.txtTenNhaXuatBan = new TextBox();
            this.txtDiaChi = new TextBox();
            this.txtSoDienThoai = new TextBox();
            this.txtEmail = new TextBox();
            
            this.lblPublisherId = new Label();
            this.lblTenNXB = new Label();
            this.lblDiaChi = new Label();
            this.lblSoDienThoai = new Label();
            this.lblEmail = new Label();
            
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.btnRefresh = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();

            // ========== DATAGRIDVIEW ==========
            this.dgvPublishers.Location = new Point(20, 20);
            this.dgvPublishers.Size = new Size(960, 300);
            this.dgvPublishers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublishers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublishers.MultiSelect = false;
            this.dgvPublishers.ReadOnly = true;
            this.dgvPublishers.AllowUserToAddRows = false;
            this.dgvPublishers.SelectionChanged += DgvPublishers_SelectionChanged;
            
            // Modern DataGridView styling
            this.dgvPublishers.BackgroundColor = Color.White;
            this.dgvPublishers.BorderStyle = BorderStyle.None;
            this.dgvPublishers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dgvPublishers.EnableHeadersVisualStyles = false;
            this.dgvPublishers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            this.dgvPublishers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvPublishers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvPublishers.ColumnHeadersHeight = 40;
            this.dgvPublishers.RowTemplate.Height = 35;
            this.dgvPublishers.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            this.dgvPublishers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246);
            this.dgvPublishers.DefaultCellStyle.SelectionForeColor = Color.White;

            // ========== GROUP BOX ==========
            this.grpInfo.Text = "📋 Thông Tin Nhà Xuất Bản";
            this.grpInfo.Location = new Point(20, 340);
            this.grpInfo.Size = new Size(960, 200);
            this.grpInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpInfo.ForeColor = Color.FromArgb(33, 150, 243);

            int grpY = 35;
            int grpStep = 42;
            
            // Mã NXB
            this.lblPublisherId.Text = "Mã NXB:";
            this.lblPublisherId.Location = new Point(20, grpY);
            this.lblPublisherId.Size = new Size(130, 25);
            this.lblPublisherId.Font = new Font("Segoe UI", 10F);
            this.lblPublisherId.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtPublisherId.Location = new Point(155, grpY);
            this.txtPublisherId.Size = new Size(350, 28);
            this.txtPublisherId.Font = new Font("Segoe UI", 10F);
            this.txtPublisherId.BorderStyle = BorderStyle.FixedSingle;
            this.txtPublisherId.ReadOnly = true;
            this.txtPublisherId.BackColor = Color.FromArgb(240, 240, 240);

            // Tên NXB
            this.lblTenNXB.Text = "Tên NXB: *";
            this.lblTenNXB.Location = new Point(530, grpY);
            this.lblTenNXB.Size = new Size(100, 25);
            this.lblTenNXB.Font = new Font("Segoe UI", 10F);
            this.lblTenNXB.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtTenNhaXuatBan.Location = new Point(635, grpY);
            this.txtTenNhaXuatBan.Size = new Size(300, 28);
            this.txtTenNhaXuatBan.Font = new Font("Segoe UI", 10F);
            this.txtTenNhaXuatBan.BorderStyle = BorderStyle.FixedSingle;

            // Địa chỉ
            this.lblDiaChi.Text = "Địa chỉ:";
            this.lblDiaChi.Location = new Point(20, grpY + grpStep);
            this.lblDiaChi.Size = new Size(130, 25);
            this.lblDiaChi.Font = new Font("Segoe UI", 10F);
            this.lblDiaChi.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtDiaChi.Location = new Point(155, grpY + grpStep);
            this.txtDiaChi.Size = new Size(780, 28);
            this.txtDiaChi.Font = new Font("Segoe UI", 10F);
            this.txtDiaChi.BorderStyle = BorderStyle.FixedSingle;

            // SĐT
            this.lblSoDienThoai.Text = "Số ĐT:";
            this.lblSoDienThoai.Location = new Point(20, grpY + grpStep * 2);
            this.lblSoDienThoai.Size = new Size(130, 25);
            this.lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            this.lblSoDienThoai.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtSoDienThoai.Location = new Point(155, grpY + grpStep * 2);
            this.txtSoDienThoai.Size = new Size(200, 28);
            this.txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            this.txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;

            // Email
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new Point(380, grpY + grpStep * 2);
            this.lblEmail.Size = new Size(70, 25);
            this.lblEmail.Font = new Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = Color.FromArgb(66, 66, 66);
            
            this.txtEmail.Location = new Point(450, grpY + grpStep * 2);
            this.txtEmail.Size = new Size(485, 28);
            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;

            this.grpInfo.Controls.Add(this.lblPublisherId);
            this.grpInfo.Controls.Add(this.txtPublisherId);
            this.grpInfo.Controls.Add(this.lblTenNXB);
            this.grpInfo.Controls.Add(this.txtTenNhaXuatBan);
            this.grpInfo.Controls.Add(this.lblDiaChi);
            this.grpInfo.Controls.Add(this.txtDiaChi);
            this.grpInfo.Controls.Add(this.lblSoDienThoai);
            this.grpInfo.Controls.Add(this.txtSoDienThoai);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.txtEmail);

            // ========== BUTTONS ==========
            int btnY = 560;
            int btnX = 20;
            int btnWidth = 110;
            int btnHeight = 40;
            int btnGap = 10;

            this.btnAdd.Text = "➕ Thêm";
            this.btnAdd.Location = new Point(btnX, btnY);
            this.btnAdd.Size = new Size(btnWidth, btnHeight);
            this.btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdd.Cursor = Cursors.Hand;
            this.btnAdd.Click += BtnAdd_Click;

            this.btnEdit.Text = "✏️ Sửa";
            this.btnEdit.Location = new Point(btnX + (btnWidth + btnGap), btnY);
            this.btnEdit.Size = new Size(btnWidth, btnHeight);
            this.btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnEdit.Cursor = Cursors.Hand;
            this.btnEdit.Click += BtnEdit_Click;

            this.btnDelete.Text = "🗑️ Xóa";
            this.btnDelete.Location = new Point(btnX + (btnWidth + btnGap) * 2, btnY);
            this.btnDelete.Size = new Size(btnWidth, btnHeight);
            this.btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.Click += BtnDelete_Click;

            this.btnSave.Text = "💾 Lưu";
            this.btnSave.Location = new Point(btnX + (btnWidth + btnGap) * 3, btnY);
            this.btnSave.Size = new Size(btnWidth, btnHeight);
            this.btnSave.BackColor = Color.FromArgb(0, 150, 136);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += BtnSave_Click;

            this.btnCancel.Text = "✖️ Hủy";
            this.btnCancel.Location = new Point(btnX + (btnWidth + btnGap) * 4, btnY);
            this.btnCancel.Size = new Size(btnWidth, btnHeight);
            this.btnCancel.BackColor = Color.FromArgb(158, 158, 158);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += BtnCancel_Click;

            this.btnRefresh.Text = "🔄 Làm mới";
            this.btnRefresh.Location = new Point(btnX + (btnWidth + btnGap) * 5, btnY);
            this.btnRefresh.Size = new Size(btnWidth, btnHeight);
            this.btnRefresh.BackColor = Color.FromArgb(96, 125, 139);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.Click += (s, e) => { LoadData(); ClearInputs(); };

            // ========== FORM ==========
            this.ClientSize = new Size(1000, 630);
            this.Controls.Add(this.dgvPublishers);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Quản Lý Nhà Xuất Bản";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.Font = new Font("Segoe UI", 9F);

            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
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
                
                dgvPublishers.Columns["PublisherId"].Width = 80;
                dgvPublishers.Columns["SoDienThoai"].Width = 120;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Vui lòng chọn nhà xuất bản cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        ClearInputs();
                        MessageBox.Show("✅ Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Không thể xóa (có thể do có sách liên quan).\nLỗi: " + ex.Message, 
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenNhaXuatBan.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập tên nhà xuất bản!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (txtPublisherId.Text == "(Tự động)" || string.IsNullOrEmpty(txtPublisherId.Text))
                {
                    var newPublisher = new Publisher
                    {
                        TenNhaXuatBan = txtTenNhaXuatBan.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        SoDienThoai = txtSoDienThoai.Text.Trim(),
                        Email = txtEmail.Text.Trim()
                    };
                    db.Publishers.Add(newPublisher);
                    db.SaveChanges();
                    MessageBox.Show("✅ Thêm nhà xuất bản thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
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
                        MessageBox.Show("✅ Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            btnRefresh.Enabled = !editing;

            btnSave.Enabled = editing;
            btnCancel.Enabled = editing;

            dgvPublishers.Enabled = !editing;

            if (editing)
            {
                grpInfo.ForeColor = Color.FromArgb(76, 175, 80);
            }
            else
            {
                grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            }
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
        private GroupBox grpInfo;
        private TextBox txtPublisherId, txtTenNhaXuatBan, txtDiaChi, txtSoDienThoai, txtEmail;
        private Label lblPublisherId, lblTenNXB, lblDiaChi, lblSoDienThoai, lblEmail;
        private Button btnAdd, btnEdit, btnDelete, btnSave, btnCancel, btnRefresh;
    }
}
