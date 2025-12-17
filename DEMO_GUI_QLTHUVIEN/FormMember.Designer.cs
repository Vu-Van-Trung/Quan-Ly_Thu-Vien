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
            lblTitle.ForeColor = Color.Navy;
            lblTitle.Location = new Point(557, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(316, 46);
            lblTitle.TabIndex = 3;
            lblTitle.Text = "QUẢN LÝ ĐỘC GIẢ";
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
            gbThongTin.Location = new Point(12, 75);
            gbThongTin.Margin = new Padding(3, 4, 3, 4);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Padding = new Padding(3, 4, 3, 4);
            gbThongTin.Size = new Size(1313, 188);
            gbThongTin.TabIndex = 2;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "Thông Tin Thành Viên";
            // 
            // dtpJoinDate
            // 
            dtpJoinDate.Format = DateTimePickerFormat.Short;
            dtpJoinDate.Location = new Point(1177, 36);
            dtpJoinDate.Margin = new Padding(3, 4, 3, 4);
            dtpJoinDate.Name = "dtpJoinDate";
            dtpJoinDate.Size = new Size(120, 27);
            dtpJoinDate.TabIndex = 0;
            // 
            // lblJoinDate
            // 
            lblJoinDate.AutoSize = true;
            lblJoinDate.Location = new Point(1049, 41);
            lblJoinDate.Name = "lblJoinDate";
            lblJoinDate.Size = new Size(113, 20);
            lblJoinDate.TabIndex = 1;
            lblJoinDate.Text = "Ngày Gia Nhập:";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(878, 35);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(150, 27);
            txtPhoneNumber.TabIndex = 2;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(822, 41);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(39, 20);
            lblPhoneNumber.TabIndex = 3;
            lblPhoneNumber.Text = "SĐT:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(580, 34);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(530, 38);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(300, 34);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(200, 27);
            txtFullName.TabIndex = 6;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(230, 38);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(59, 20);
            lblFullName.TabIndex = 7;
            lblFullName.Text = "Họ Tên:";
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(100, 34);
            txtMemberId.Margin = new Padding(3, 4, 3, 4);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.ReadOnly = true;
            txtMemberId.Size = new Size(100, 27);
            txtMemberId.TabIndex = 8;
            // 
            // lblMemberId
            // 
            lblMemberId.AutoSize = true;
            lblMemberId.Location = new Point(30, 38);
            lblMemberId.Name = "lblMemberId";
            lblMemberId.Size = new Size(58, 20);
            lblMemberId.TabIndex = 9;
            lblMemberId.Text = "Mã ĐG:";
            // 
            // gbDanhSach
            // 
            gbDanhSach.Controls.Add(dgvDanhSach);
            gbDanhSach.Location = new Point(12, 275);
            gbDanhSach.Margin = new Padding(3, 4, 3, 4);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Padding = new Padding(3, 4, 3, 4);
            gbDanhSach.Size = new Size(730, 375);
            gbDanhSach.TabIndex = 1;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "Danh Sách Độc Giả";
            // 
            // dgvDanhSach
            // 
            dgvDanhSach.AllowUserToAddRows = false;
            dgvDanhSach.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhSach.ColumnHeadersHeight = 29;
            dgvDanhSach.Dock = DockStyle.Fill;
            dgvDanhSach.Location = new Point(3, 24);
            dgvDanhSach.Margin = new Padding(3, 4, 3, 4);
            dgvDanhSach.Name = "dgvDanhSach";
            dgvDanhSach.RowHeadersWidth = 51;
            dgvDanhSach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDanhSach.Size = new Size(724, 347);
            dgvDanhSach.TabIndex = 0;
            // 
            // gbXuLy
            // 
            gbXuLy.Controls.Add(btnThoat);
            gbXuLy.Controls.Add(btnXoa);
            gbXuLy.Controls.Add(btnSua);
            gbXuLy.Controls.Add(btnThem);
            gbXuLy.Controls.Add(btnTimKiem);
            gbXuLy.Controls.Add(txtTimKiem);
            gbXuLy.Location = new Point(1105, 275);
            gbXuLy.Margin = new Padding(3, 4, 3, 4);
            gbXuLy.Name = "gbXuLy";
            gbXuLy.Padding = new Padding(3, 4, 3, 4);
            gbXuLy.Size = new Size(220, 375);
            gbXuLy.TabIndex = 0;
            gbXuLy.TabStop = false;
            gbXuLy.Text = "Chức Năng";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(120, 112);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(80, 50);
            btnThoat.TabIndex = 0;
            btnThoat.Text = "Thoát";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Firebrick;
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(20, 112);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 50);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.Orange;
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(120, 38);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 50);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.ForestGreen;
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 38);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(80, 50);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(20, 238);
            btnTimKiem.Margin = new Padding(3, 4, 3, 4);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(180, 38);
            btnTimKiem.TabIndex = 4;
            btnTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 200);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Tìm theo tên...";
            txtTimKiem.Size = new Size(180, 27);
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