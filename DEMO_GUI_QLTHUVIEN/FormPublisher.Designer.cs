using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class FormPublisher
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvPublishers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTen = new DataGridViewTextBoxColumn();
            colDiaChi = new DataGridViewTextBoxColumn();
            colSDT = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            grpInfo = new GroupBox();
            lblPublisherId = new Label();
            txtPublisherId = new TextBox();
            lblTenNXB = new Label();
            txtTenNhaXuatBan = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblThongBao = new Label();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            btnRefresh = new Button();
            lblTitle = new Label();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvPublishers).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPublishers
            // 
            dgvPublishers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvPublishers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPublishers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPublishers.BackgroundColor = Color.White;
            dgvPublishers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPublishers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPublishers.ColumnHeadersHeight = 40;
            dgvPublishers.Columns.AddRange(new DataGridViewColumn[] { colId, colTen, colDiaChi, colSDT, colEmail });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPublishers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPublishers.EnableHeadersVisualStyles = false;
            dgvPublishers.Location = new Point(29, 74);
            dgvPublishers.MultiSelect = false;
            dgvPublishers.Name = "dgvPublishers";
            dgvPublishers.ReadOnly = true;
            dgvPublishers.RowHeadersWidth = 51;
            dgvPublishers.RowTemplate.Height = 35;
            dgvPublishers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPublishers.Size = new Size(1249, 362);
            dgvPublishers.TabIndex = 0;
            dgvPublishers.SelectionChanged += DgvPublishers_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "PublisherId";
            colId.HeaderText = "Mã NXB";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colTen
            // 
            colTen.DataPropertyName = "TenNhaXuatBan";
            colTen.HeaderText = "Tên Nhà Xuất Bản";
            colTen.MinimumWidth = 6;
            colTen.Name = "colTen";
            colTen.ReadOnly = true;
            // 
            // colDiaChi
            // 
            colDiaChi.DataPropertyName = "DiaChi";
            colDiaChi.HeaderText = "Địa Chỉ";
            colDiaChi.MinimumWidth = 6;
            colDiaChi.Name = "colDiaChi";
            colDiaChi.ReadOnly = true;
            // 
            // colSDT
            // 
            colSDT.DataPropertyName = "SoDienThoai";
            colSDT.HeaderText = "Số Điện Thoại";
            colSDT.MinimumWidth = 6;
            colSDT.Name = "colSDT";
            colSDT.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblPublisherId);
            grpInfo.Controls.Add(txtPublisherId);
            grpInfo.Controls.Add(lblTenNXB);
            grpInfo.Controls.Add(txtTenNhaXuatBan);
            grpInfo.Controls.Add(lblDiaChi);
            grpInfo.Controls.Add(txtDiaChi);
            grpInfo.Controls.Add(lblSoDienThoai);
            grpInfo.Controls.Add(txtSoDienThoai);
            grpInfo.Controls.Add(lblEmail);
            grpInfo.Controls.Add(txtEmail);
            grpInfo.Controls.Add(lblThongBao);
            grpInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            grpInfo.Location = new Point(29, 456);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(1249, 210);
            grpInfo.TabIndex = 1;
            grpInfo.TabStop = false;
            grpInfo.Text = "📝 Thông Tin Nhà Xuất Bản";
            // 
            // lblPublisherId
            // 
            lblPublisherId.Font = new Font("Segoe UI", 10F);
            lblPublisherId.ForeColor = Color.FromArgb(66, 66, 66);
            lblPublisherId.Location = new Point(90, 32);
            lblPublisherId.Name = "lblPublisherId";
            lblPublisherId.Size = new Size(130, 25);
            lblPublisherId.TabIndex = 0;
            lblPublisherId.Text = "Mã NXB:";
            // 
            // txtPublisherId
            // 
            txtPublisherId.BackColor = Color.FromArgb(240, 240, 240);
            txtPublisherId.BorderStyle = BorderStyle.FixedSingle;
            txtPublisherId.Font = new Font("Segoe UI", 10F);
            txtPublisherId.Location = new Point(240, 30);
            txtPublisherId.Name = "txtPublisherId";
            txtPublisherId.ReadOnly = true;
            txtPublisherId.Size = new Size(329, 30);
            txtPublisherId.TabIndex = 1;
            txtPublisherId.Text = "1";
            // 
            // lblTenNXB
            // 
            lblTenNXB.Font = new Font("Segoe UI", 10F);
            lblTenNXB.ForeColor = Color.FromArgb(66, 66, 66);
            lblTenNXB.Location = new Point(600, 32);
            lblTenNXB.Name = "lblTenNXB";
            lblTenNXB.Size = new Size(100, 25);
            lblTenNXB.TabIndex = 2;
            lblTenNXB.Text = "Tên NXB: *";
            // 
            // txtTenNhaXuatBan
            // 
            txtTenNhaXuatBan.BorderStyle = BorderStyle.FixedSingle;
            txtTenNhaXuatBan.Font = new Font("Segoe UI", 10F);
            txtTenNhaXuatBan.Location = new Point(706, 30);
            txtTenNhaXuatBan.Name = "txtTenNhaXuatBan";
            txtTenNhaXuatBan.Size = new Size(520, 30);
            txtTenNhaXuatBan.TabIndex = 3;
            txtTenNhaXuatBan.Text = "NXB Trẻ";
            // 
            // lblDiaChi
            // 
            lblDiaChi.Font = new Font("Segoe UI", 10F);
            lblDiaChi.ForeColor = Color.FromArgb(66, 66, 66);
            lblDiaChi.Location = new Point(90, 86);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(130, 25);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            txtDiaChi.Font = new Font("Segoe UI", 10F);
            txtDiaChi.Location = new Point(240, 81);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(986, 30);
            txtDiaChi.TabIndex = 5;
            txtDiaChi.Text = "161B Lý Chính Thắng, Q.3, TP.HCM";
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            lblSoDienThoai.ForeColor = Color.FromArgb(66, 66, 66);
            lblSoDienThoai.Location = new Point(90, 142);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(130, 25);
            lblSoDienThoai.TabIndex = 6;
            lblSoDienThoai.Text = "Số ĐT:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            txtSoDienThoai.Location = new Point(240, 137);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(329, 30);
            txtSoDienThoai.TabIndex = 7;
            txtSoDienThoai.Text = "028-39316211";
            // 
            // lblEmail
            // 
            lblEmail.Font = new Font("Segoe UI", 10F);
            lblEmail.ForeColor = Color.FromArgb(66, 66, 66);
            lblEmail.Location = new Point(600, 139);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 10F);
            txtEmail.Location = new Point(706, 137);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(520, 30);
            txtEmail.TabIndex = 9;
            txtEmail.Text = "info@nxbtre.com.vn";
            // 
            // lblThongBao
            // 
            lblThongBao.AutoSize = true;
            lblThongBao.Font = new Font("Segoe UI", 8F);
            lblThongBao.ForeColor = Color.Red;
            lblThongBao.Location = new Point(706, 175);
            lblThongBao.Name = "lblThongBao";
            lblThongBao.Size = new Size(0, 19);
            lblThongBao.TabIndex = 11;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(29, 676);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(110, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "+ Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(149, 676);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 40);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "✎ Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(269, 676);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 40);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "🗑 Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(0, 150, 136);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(389, 676);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 40);
            btnSave.TabIndex = 5;
            btnSave.Text = "💾 Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(158, 158, 158);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(509, 676);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 40);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "🚫 Hủy";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(96, 125, 139);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(629, 676);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 40);
            btnRefresh.TabIndex = 7;
            btnRefresh.Text = "🔄 Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(459, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(492, 46);
            lblTitle.TabIndex = 8;
            lblTitle.Text = "👥 QUẢN LÝ NHÀ XUẤT BẢN";
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ButtonHighlight;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(1254, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(44, 36);
            guna2Button1.TabIndex = 9;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FormPublisher
            // 
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1310, 743);
            Controls.Add(guna2Button1);
            Controls.Add(lblTitle);
            Controls.Add(dgvPublishers);
            Controls.Add(grpInfo);
            Controls.Add(btnAdd);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnRefresh);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPublisher";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Nhà Xuất Bản";
            Load += FormPublisher_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvPublishers).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPublishers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtPublisherId;
        private System.Windows.Forms.TextBox txtTenNhaXuatBan;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPublisherId;
        private System.Windows.Forms.Label lblTenNXB;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRefresh;
        private Label lblTitle;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        
        // Validation Labels
        private System.Windows.Forms.Label lblThongBao;
    }
}