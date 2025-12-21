#nullable disable
namespace DoAnDemoUI
{
    partial class FormMember
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblTitle = new Label();
            gbThongTin = new GroupBox();
            dtpJoinDate = new DateTimePicker();
            lblJoinDate = new Label();
            txtPhoneNumber = new TextBox();
            lblPhoneNumber = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            txtFullName = new TextBox();
            lblFullName = new Label();
            txtMemberId = new TextBox();
            lblMemberId = new Label();
            gbDanhSach = new GroupBox();
            dgvDanhSach = new DataGridView();
            gbXuLy = new GroupBox();
            btnThoat = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnTimKiem = new Button();
            txtTimKiem = new TextBox();
            gbThongTin.SuspendLayout();
            gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).BeginInit();
            gbXuLy.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(557, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(373, 46);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "👥 QUẢN LÝ ĐỘC GIẢ";
            lblTitle.Click += lblTitle_Click;
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(dtpJoinDate);
            gbThongTin.Controls.Add(lblJoinDate);
            gbThongTin.Controls.Add(txtPhoneNumber);
            gbThongTin.Controls.Add(lblPhoneNumber);
            gbThongTin.Controls.Add(txtEmail);
            gbThongTin.Controls.Add(lblEmail);
            gbThongTin.Controls.Add(txtFullName);
            gbThongTin.Controls.Add(lblFullName);
            gbThongTin.Controls.Add(txtMemberId);
            gbThongTin.Controls.Add(lblMemberId);
            gbThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbThongTin.ForeColor = Color.FromArgb(33, 150, 243);
            gbThongTin.Location = new Point(12, 75);
            gbThongTin.Margin = new Padding(3, 4, 3, 4);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Padding = new Padding(3, 4, 3, 4);
            gbThongTin.Size = new Size(1313, 188);
            gbThongTin.TabIndex = 2;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "📝 Thông Tin Thành Viên";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Format = DateTimePickerFormat.Short;
            dtpJoinDate.Location = new Point(1177, 36);
            dtpJoinDate.Margin = new Padding(3, 4, 3, 4);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(120, 30);
            dtpJoinDate.TabIndex = 0;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(1049, 41);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(136, 23);
            lblJoinDate.TabIndex = 1;
            lblJoinDate.Text = "Ngày Gia Nhập:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(878, 35);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 30);
            txtPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(822, 41);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(48, 23);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "SĐT:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(580, 34);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 30);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(530, 38);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(300, 34);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 30);
            txtFullName.TabIndex = 6;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(230, 38);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(70, 23);
            lblFullName.TabIndex = 7;
            lblFullName.Text = "Họ Tên:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(100, 34);
            txtMemberId.Margin = new Padding(3, 4, 3, 4);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(100, 30);
            txtMemberId.TabIndex = 8;
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(30, 38);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(70, 23);
            lblMemberId.TabIndex = 9;
            lblMemberId.Text = "Mã ĐG:";
            // 
            // gbDanhSach
            // 
            gbDanhSach.Controls.Add(dgvDanhSach);
            gbDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbDanhSach.ForeColor = Color.FromArgb(33, 150, 243);
            gbDanhSach.Location = new Point(12, 275);
            gbDanhSach.Margin = new Padding(3, 4, 3, 4);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Padding = new Padding(3, 4, 3, 4);
            gbDanhSach.Size = new Size(730, 375);
            gbDanhSach.TabIndex = 1;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "📊 Danh Sách Độc Giả";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvDanhSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.BackgroundColor = Color.White;
            dgvDanhSach.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSach.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.EnableHeadersVisualStyles = false;
            dgvDanhSach.Location = new Point(3, 27);
            dgvDanhSach.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 51;
            dgvDanhSach.RowTemplate.Height = 35;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.Size = new Size(724, 344);
            dgvDanhSach.TabIndex = 0;
            dgvDanhSach.CellContentClick += dgvDanhSach_CellContentClick;
            // 
            // gbXuLy
            // 
            gbXuLy.Controls.Add(btnThoat);
            gbXuLy.Controls.Add(btnXoa);
            gbXuLy.Controls.Add(btnSua);
            gbXuLy.Controls.Add(btnThem);
            gbXuLy.Controls.Add(btnTimKiem);
            gbXuLy.Controls.Add(txtTimKiem);
            gbXuLy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbXuLy.ForeColor = Color.FromArgb(33, 150, 243);
            gbXuLy.Location = new Point(1105, 275);
            gbXuLy.Margin = new Padding(3, 4, 3, 4);
            gbXuLy.Name = "gbXuLy";
            gbXuLy.Padding = new Padding(3, 4, 3, 4);
            gbXuLy.Size = new Size(220, 375);
            gbXuLy.TabIndex = 0;
            gbXuLy.TabStop = false;
            gbXuLy.Text = "⚙️ Chức Năng";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(158, 158, 158);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(120, 112);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 50);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "❌ Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(20, 112);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 50);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(33, 150, 243);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(120, 38);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 50);
            btnSua.TabIndex = 2;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(76, 175, 80);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 38);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 50);
            btnThem.TabIndex = 3;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(33, 150, 243);
            btnTimKiem.Cursor = Cursors.Hand;
            btnTimKiem.FlatAppearance.BorderSize = 0;
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(20, 238);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(180, 38);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "🔍 Tìm Kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 200);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo tên...";
            txtTimKiem.Size = new Size(180, 30);
            txtTimKiem.TabIndex = 5;
            // 
            // FormMember
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 676);
            Controls.Add(gbXuLy);
            Controls.Add(gbDanhSach);
            Controls.Add(gbThongTin);
            Controls.Add(lblTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Độc Giả";
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSach).EndInit();
            gbXuLy.ResumeLayout(false);
            gbXuLy.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbThongTin;

        private System.Windows.Forms.Label lblMemberId, lblFullName, lblEmail, lblPhoneNumber, lblJoinDate;
        private System.Windows.Forms.TextBox txtMemberId, txtFullName, txtEmail, txtPhoneNumber;
        private System.Windows.Forms.DateTimePicker dtpJoinDate;

        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvDanhSach;

        private System.Windows.Forms.GroupBox gbXuLy;
        private System.Windows.Forms.Button btnThem, btnThoat, btnXoa, btnSua, btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}