namespace DoAnDemoUI
{
    partial class FormLoan
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
            lblTitle = new Label();
            gbThongTin = new GroupBox();
            dtpNgayTra = new DateTimePicker();
            dtpNgayMuon = new DateTimePicker();
            cbMaDocGia = new ComboBox();
            cbMaSach = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            gbDanhSach = new GroupBox();
            dgvSachMuon = new DataGridView();
            gbXuLy = new GroupBox();
            btnSua = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnThem = new Button();
            btnTraSach = new Button();
            gbDieuKhien = new GroupBox();
            txtIndex = new TextBox();
            btnCuoi = new Button();
            btnSau = new Button();
            btnTruoc = new Button();
            btnDau = new Button();
            gbChiTiet = new GroupBox();
            dgvChiTiet = new DataGridView();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            gbThongTin.SuspendLayout();
            gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSachMuon).BeginInit();
            gbXuLy.SuspendLayout();
            gbDieuKhien.SuspendLayout();
            gbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(411, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(565, 50);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "📚 QUẢN LÝ MƯỢN TRẢ SÁCH";
            // 
            // gbThongTin
            // 
            gbThongTin.Controls.Add(dtpNgayTra);
            gbThongTin.Controls.Add(dtpNgayMuon);
            gbThongTin.Controls.Add(cbMaDocGia);
            gbThongTin.Controls.Add(cbMaSach);
            gbThongTin.Controls.Add(label5);
            gbThongTin.Controls.Add(label4);
            gbThongTin.Controls.Add(label2);
            gbThongTin.Controls.Add(label1);
            gbThongTin.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbThongTin.ForeColor = Color.FromArgb(33, 150, 243);
            gbThongTin.Location = new Point(16, 92);
            gbThongTin.Margin = new Padding(3, 4, 3, 4);
            gbThongTin.Name = "gbThongTin";
            gbThongTin.Padding = new Padding(3, 4, 3, 4);
            gbThongTin.Size = new Size(467, 325);
            gbThongTin.TabIndex = 1;
            gbThongTin.TabStop = false;
            gbThongTin.Text = "📄 Thông Tin Phiếu Mượn";
            // 
            // dtpNgayTra
            // 
            dtpNgayTra.Format = DateTimePickerFormat.Short;
            dtpNgayTra.Location = new Point(152, 250);
            dtpNgayTra.Margin = new Padding(3, 4, 3, 4);
            dtpNgayTra.Name = "dtpNgayTra";
            dtpNgayTra.Size = new Size(284, 30);
            dtpNgayTra.TabIndex = 9;
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayMuon.Location = new Point(152, 182);
            dtpNgayMuon.Margin = new Padding(3, 4, 3, 4);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(284, 30);
            dtpNgayMuon.TabIndex = 8;
            // 
            // cbMaDocGia
            // 
            cbMaDocGia.FormattingEnabled = true;
            cbMaDocGia.Location = new Point(152, 118);
            cbMaDocGia.Margin = new Padding(3, 4, 3, 4);
            cbMaDocGia.Name = "cbMaDocGia";
            cbMaDocGia.Size = new Size(284, 31);
            cbMaDocGia.TabIndex = 6;
            // 
            // cbMaSach
            // 
            cbMaSach.FormattingEnabled = true;
            cbMaSach.Location = new Point(152, 52);
            cbMaSach.Margin = new Padding(3, 4, 3, 4);
            cbMaSach.Name = "cbMaSach";
            cbMaSach.Size = new Size(284, 31);
            cbMaSach.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 256);
            label5.Name = "label5";
            label5.Size = new Size(126, 23);
            label5.TabIndex = 4;
            label5.Text = "Hạn Trả (Due):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 189);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 3;
            label4.Text = "Ngày Mượn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 121);
            label2.Name = "label2";
            label2.Size = new Size(77, 23);
            label2.TabIndex = 1;
            label2.Text = "Độc Giả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 58);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 0;
            label1.Text = "Sách:";
            // 
            // gbDanhSach
            // 
            gbDanhSach.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            gbDanhSach.Controls.Add(dgvSachMuon);
            gbDanhSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbDanhSach.ForeColor = Color.FromArgb(33, 150, 243);
            gbDanhSach.Location = new Point(507, 92);
            gbDanhSach.Margin = new Padding(3, 4, 3, 4);
            gbDanhSach.Name = "gbDanhSach";
            gbDanhSach.Padding = new Padding(3, 4, 3, 4);
            gbDanhSach.Size = new Size(780, 300);
            gbDanhSach.TabIndex = 2;
            gbDanhSach.TabStop = false;
            gbDanhSach.Text = "📊 Danh Sách Phiếu Mượn";
            // 
            // dgvSachMuon
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            dgvSachMuon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSachMuon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSachMuon.BackgroundColor = Color.White;
            dgvSachMuon.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSachMuon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSachMuon.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSachMuon.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSachMuon.Dock = DockStyle.Fill;
            dgvSachMuon.EnableHeadersVisualStyles = false;
            dgvSachMuon.Location = new Point(3, 27);
            dgvSachMuon.Margin = new Padding(3, 4, 3, 4);
            dgvSachMuon.Name = "dgvSachMuon";
            dgvSachMuon.RowHeadersWidth = 51;
            dgvSachMuon.RowTemplate.Height = 35;
            dgvSachMuon.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSachMuon.Size = new Size(774, 269);
            dgvSachMuon.TabIndex = 0;
            dgvSachMuon.CellContentClick += dgvSachMuon_CellContentClick;
            // 
            // gbXuLy
            // 
            gbXuLy.Controls.Add(btnSua);
            gbXuLy.Controls.Add(btnXoa);
            gbXuLy.Controls.Add(btnThoat);
            gbXuLy.Controls.Add(btnThem);
            gbXuLy.Controls.Add(btnTraSach);
            gbXuLy.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbXuLy.ForeColor = Color.FromArgb(33, 150, 243);
            gbXuLy.Location = new Point(16, 438);
            gbXuLy.Margin = new Padding(3, 4, 3, 4);
            gbXuLy.Name = "gbXuLy";
            gbXuLy.Padding = new Padding(3, 4, 3, 4);
            gbXuLy.Size = new Size(467, 162);
            gbXuLy.TabIndex = 3;
            gbXuLy.TabStop = false;
            gbXuLy.Text = "⚙️ Chức Năng";
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(33, 150, 243);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(130, 46);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(90, 50);
            btnSua.TabIndex = 5;
            btnSua.Text = "✏️ Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(244, 67, 54);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(240, 46);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(90, 50);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "🗑️ Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(158, 158, 158);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatAppearance.BorderSize = 0;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(350, 46);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(90, 50);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "❌ Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(76, 175, 80);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(20, 46);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 50);
            btnThem.TabIndex = 0;
            btnThem.Text = "➕ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnTraSach
            // 
            btnTraSach.BackColor = Color.FromArgb(255, 152, 0);
            btnTraSach.Cursor = Cursors.Hand;
            btnTraSach.FlatAppearance.BorderSize = 0;
            btnTraSach.FlatStyle = FlatStyle.Flat;
            btnTraSach.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTraSach.ForeColor = Color.White;
            btnTraSach.Location = new Point(20, 104);
            btnTraSach.Margin = new Padding(3, 4, 3, 4);
            btnTraSach.Name = "btnTraSach";
            btnTraSach.Size = new Size(120, 50);
            btnTraSach.TabIndex = 6;
            btnTraSach.Text = "📖 Trả Sách";
            btnTraSach.UseVisualStyleBackColor = false;
            btnTraSach.Click += btnTraSach_Click;
            // 
            // gbDieuKhien
            // 
            gbDieuKhien.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            gbDieuKhien.Controls.Add(txtIndex);
            gbDieuKhien.Controls.Add(btnCuoi);
            gbDieuKhien.Controls.Add(btnSau);
            gbDieuKhien.Controls.Add(btnTruoc);
            gbDieuKhien.Controls.Add(btnDau);
            gbDieuKhien.Location = new Point(484, 620);
            gbDieuKhien.Margin = new Padding(3, 4, 3, 4);
            gbDieuKhien.Name = "gbDieuKhien";
            gbDieuKhien.Padding = new Padding(3, 4, 3, 4);
            gbDieuKhien.Size = new Size(803, 92);
            gbDieuKhien.TabIndex = 4;
            gbDieuKhien.TabStop = false;
            gbDieuKhien.Text = "Điều Khiển";
            // 
            // txtIndex
            // 
            txtIndex.Location = new Point(307, 39);
            txtIndex.Margin = new Padding(3, 4, 3, 4);
            txtIndex.Name = "txtIndex";
            txtIndex.Size = new Size(185, 27);
            txtIndex.TabIndex = 4;
            txtIndex.TextAlign = HorizontalAlignment.Center;
            // 
            // btnCuoi
            // 
            btnCuoi.Location = new Point(653, 31);
            btnCuoi.Margin = new Padding(3, 4, 3, 4);
            btnCuoi.Name = "btnCuoi";
            btnCuoi.Size = new Size(100, 46);
            btnCuoi.TabIndex = 3;
            btnCuoi.Text = ">>|";
            btnCuoi.UseVisualStyleBackColor = true;
            btnCuoi.Click += btnCuoi_Click;
            // 
            // btnSau
            // 
            btnSau.Location = new Point(520, 31);
            btnSau.Margin = new Padding(3, 4, 3, 4);
            btnSau.Name = "btnSau";
            btnSau.Size = new Size(100, 46);
            btnSau.TabIndex = 2;
            btnSau.Text = ">>";
            btnSau.UseVisualStyleBackColor = true;
            btnSau.Click += btnSau_Click;
            // 
            // btnTruoc
            // 
            btnTruoc.Location = new Point(173, 31);
            btnTruoc.Margin = new Padding(3, 4, 3, 4);
            btnTruoc.Name = "btnTruoc";
            btnTruoc.Size = new Size(100, 46);
            btnTruoc.TabIndex = 1;
            btnTruoc.Text = "<<";
            btnTruoc.UseVisualStyleBackColor = true;
            btnTruoc.Click += btnTruoc_Click;
            // 
            // btnDau
            // 
            btnDau.Location = new Point(40, 31);
            btnDau.Margin = new Padding(3, 4, 3, 4);
            btnDau.Name = "btnDau";
            btnDau.Size = new Size(100, 46);
            btnDau.TabIndex = 0;
            btnDau.Text = "|<<";
            btnDau.UseVisualStyleBackColor = true;
            btnDau.Click += btnDau_Click;
            // 
            // gbChiTiet
            // 
            gbChiTiet.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            gbChiTiet.Controls.Add(dgvChiTiet);
            gbChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            gbChiTiet.ForeColor = Color.Red;
            gbChiTiet.Location = new Point(507, 400);
            gbChiTiet.Name = "gbChiTiet";
            gbChiTiet.Size = new Size(780, 208);
            gbChiTiet.TabIndex = 10;
            gbChiTiet.TabStop = false;
            gbChiTiet.Text = "📕 Chi Tiết Sách Đang Mượn";
            // 
            // dgvChiTiet
            // 
            dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvChiTiet.BackgroundColor = Color.White;
            dgvChiTiet.ColumnHeadersHeight = 30;
            dgvChiTiet.Dock = DockStyle.Fill;
            dgvChiTiet.Location = new Point(3, 26);
            dgvChiTiet.Name = "dgvChiTiet";
            dgvChiTiet.ReadOnly = true;
            dgvChiTiet.RowHeadersWidth = 51;
            dgvChiTiet.RowTemplate.Height = 30;
            dgvChiTiet.Size = new Size(774, 179);
            dgvChiTiet.TabIndex = 0;
            dgvChiTiet.CellContentClick += dgvChiTiet_CellContentClick;
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
            guna2Button1.Location = new Point(1254, 14);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(44, 36);
            guna2Button1.TabIndex = 11;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FormLoan
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1310, 743);
            Controls.Add(guna2Button1);
            Controls.Add(gbChiTiet);
            Controls.Add(gbDieuKhien);
            Controls.Add(gbXuLy);
            Controls.Add(gbDanhSach);
            Controls.Add(gbThongTin);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Mượn Trả";
            Load += FormLoan_Load;
            gbThongTin.ResumeLayout(false);
            gbThongTin.PerformLayout();
            gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSachMuon).EndInit();
            gbXuLy.ResumeLayout(false);
            gbDieuKhien.ResumeLayout(false);
            gbDieuKhien.PerformLayout();
            gbChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvChiTiet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox gbThongTin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.ComboBox cbMaDocGia;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.GroupBox gbDanhSach;
        private System.Windows.Forms.DataGridView dgvSachMuon;
        private System.Windows.Forms.GroupBox gbXuLy;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnTraSach;
        private System.Windows.Forms.GroupBox gbDieuKhien;
        private System.Windows.Forms.Button btnCuoi;
        private System.Windows.Forms.Button btnSau;
        private System.Windows.Forms.Button btnTruoc;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.GroupBox gbChiTiet;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.TextBox txtIndex;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;

        // ... existing controls ...
    }
}