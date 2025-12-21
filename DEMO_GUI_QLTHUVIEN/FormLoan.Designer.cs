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
            this.lblTitle = new System.Windows.Forms.Label();
            this.gbThongTin = new System.Windows.Forms.GroupBox();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cbMaDocGia = new System.Windows.Forms.ComboBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDanhSach = new System.Windows.Forms.GroupBox();
            this.dgvSachMuon = new System.Windows.Forms.DataGridView();
            this.gbXuLy = new System.Windows.Forms.GroupBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTraSach = new System.Windows.Forms.Button();
            this.gbDieuKhien = new System.Windows.Forms.GroupBox();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnCuoi = new System.Windows.Forms.Button();
            this.btnSau = new System.Windows.Forms.Button();
            this.btnTruoc = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.gbThongTin.SuspendLayout();
            this.gbDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).BeginInit();
            this.gbXuLy.SuspendLayout();
            this.gbDieuKhien.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.lblTitle.Location = new System.Drawing.Point(411, 11);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(505, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📚 QUẢN LÝ MƯỢN TRẢ SÁCH";
            // 
            // gbThongTin
            // 
            this.gbThongTin.Controls.Add(this.dtpNgayTra);
            this.gbThongTin.Controls.Add(this.dtpNgayMuon);
            this.gbThongTin.Controls.Add(this.cbMaDocGia);
            this.gbThongTin.Controls.Add(this.cbMaSach);
            this.gbThongTin.Controls.Add(this.label5);
            this.gbThongTin.Controls.Add(this.label4);
            this.gbThongTin.Controls.Add(this.label2);
            this.gbThongTin.Controls.Add(this.label1);
            this.gbThongTin.Location = new System.Drawing.Point(16, 74);
            this.gbThongTin.Name = "gbThongTin";
            this.gbThongTin.Size = new System.Drawing.Size(467, 260);
            this.gbThongTin.TabIndex = 1;
            this.gbThongTin.TabStop = false;
            this.gbThongTin.Text = "📄 Thông Tin Phiếu Mượn";
            this.gbThongTin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbThongTin.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTra.Location = new System.Drawing.Point(152, 200);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(284, 22);
            this.dtpNgayTra.TabIndex = 9;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayMuon.Location = new System.Drawing.Point(152, 146);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(284, 22);
            this.dtpNgayMuon.TabIndex = 8;
            // 
            // cbMaDocGia
            // 
            this.cbMaDocGia.FormattingEnabled = true;
            this.cbMaDocGia.Location = new System.Drawing.Point(152, 94);
            this.cbMaDocGia.Name = "cbMaDocGia";
            this.cbMaDocGia.Size = new System.Drawing.Size(284, 24);
            this.cbMaDocGia.TabIndex = 6;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(152, 42);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(284, 24);
            this.cbMaSach.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn Trả (Due):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Độc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sách:";
            // 
            // gbDanhSach
            // 
            this.gbDanhSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDanhSach.Controls.Add(this.dgvSachMuon);
            this.gbDanhSach.Location = new System.Drawing.Point(507, 74);
            this.gbDanhSach.Name = "gbDanhSach";
            this.gbDanhSach.Size = new System.Drawing.Size(803, 468);
            this.gbDanhSach.TabIndex = 2;
            this.gbDanhSach.TabStop = false;
            this.gbDanhSach.Text = "📊 Danh Sách Đang Mượn";
            this.gbDanhSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbDanhSach.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            // 
            // dgvSachMuon
            // 
            this.dgvSachMuon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSachMuon.BackgroundColor = System.Drawing.Color.White;
            this.dgvSachMuon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSachMuon.ColumnHeadersHeight = 40;
            this.dgvSachMuon.EnableHeadersVisualStyles = false;
            this.dgvSachMuon.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.dgvSachMuon.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSachMuon.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dgvSachMuon.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvSachMuon.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(100, 181, 246);
            this.dgvSachMuon.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvSachMuon.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.dgvSachMuon.RowTemplate.Height = 35;
            this.dgvSachMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSachMuon.Location = new System.Drawing.Point(3, 18);
            this.dgvSachMuon.Name = "dgvSachMuon";
            this.dgvSachMuon.RowHeadersWidth = 51;
            this.dgvSachMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSachMuon.Size = new System.Drawing.Size(797, 447);
            this.dgvSachMuon.TabIndex = 0;
            // 
            // gbXuLy
            // 
            this.gbXuLy.Controls.Add(this.btnSua);
            this.gbXuLy.Controls.Add(this.btnXoa);
            this.gbXuLy.Controls.Add(this.btnThoat);
            this.gbXuLy.Controls.Add(this.btnThem);
            this.gbXuLy.Controls.Add(this.btnTraSach);
            this.gbXuLy.Location = new System.Drawing.Point(16, 350);
            this.gbXuLy.Name = "gbXuLy";
            this.gbXuLy.Size = new System.Drawing.Size(467, 130);
            this.gbXuLy.TabIndex = 3;
            this.gbXuLy.TabStop = false;
            this.gbXuLy.Text = "⚙️ Chức Năng";
            this.gbXuLy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gbXuLy.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSua.Location = new System.Drawing.Point(130, 37);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(90, 40);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "✏️ Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(244, 67, 54);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnXoa.Location = new System.Drawing.Point(240, 37);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(90, 40);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "🗑️ Xóa";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(158, 158, 158);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThoat.Location = new System.Drawing.Point(350, 37);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(90, 40);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "❌ Thoát";
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnThem.Location = new System.Drawing.Point(20, 37);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(90, 40);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "➕ Thêm";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTraSach
            // 
            this.btnTraSach.BackColor = System.Drawing.Color.FromArgb(255, 152, 0); // Orange
            this.btnTraSach.ForeColor = System.Drawing.Color.White;
            this.btnTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraSach.FlatAppearance.BorderSize = 0;
            this.btnTraSach.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnTraSach.Location = new System.Drawing.Point(20, 83); // Lower row
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(120, 40);
            this.btnTraSach.TabIndex = 6;
            this.btnTraSach.Text = "📖 Trả Sách";
            this.btnTraSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTraSach.UseVisualStyleBackColor = false;
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // gbDieuKhien
            // 
            this.gbDieuKhien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDieuKhien.Controls.Add(this.txtIndex);
            this.gbDieuKhien.Controls.Add(this.btnCuoi);
            this.gbDieuKhien.Controls.Add(this.btnSau);
            this.gbDieuKhien.Controls.Add(this.btnTruoc);
            this.gbDieuKhien.Controls.Add(this.btnDau);
            this.gbDieuKhien.Location = new System.Drawing.Point(507, 554);
            this.gbDieuKhien.Name = "gbDieuKhien";
            this.gbDieuKhien.Size = new System.Drawing.Size(803, 74);
            this.gbDieuKhien.TabIndex = 4;
            this.gbDieuKhien.TabStop = false;
            this.gbDieuKhien.Text = "Điều Khiển";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(307, 31);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(185, 22);
            this.txtIndex.TabIndex = 4;
            this.txtIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCuoi
            // 
            this.btnCuoi.Location = new System.Drawing.Point(653, 25);
            this.btnCuoi.Name = "btnCuoi";
            this.btnCuoi.Size = new System.Drawing.Size(100, 37);
            this.btnCuoi.TabIndex = 3;
            this.btnCuoi.Text = ">>|";
            this.btnCuoi.UseVisualStyleBackColor = true;
            this.btnCuoi.Click += new System.EventHandler(this.btnCuoi_Click);
            // 
            // btnSau
            // 
            this.btnSau.Location = new System.Drawing.Point(520, 25);
            this.btnSau.Name = "btnSau";
            this.btnSau.Size = new System.Drawing.Size(100, 37);
            this.btnSau.TabIndex = 2;
            this.btnSau.Text = ">>";
            this.btnSau.UseVisualStyleBackColor = true;
            this.btnSau.Click += new System.EventHandler(this.btnSau_Click);
            // 
            // btnTruoc
            // 
            this.btnTruoc.Location = new System.Drawing.Point(173, 25);
            this.btnTruoc.Name = "btnTruoc";
            this.btnTruoc.Size = new System.Drawing.Size(100, 37);
            this.btnTruoc.TabIndex = 1;
            this.btnTruoc.Text = "<<";
            this.btnTruoc.UseVisualStyleBackColor = true;
            this.btnTruoc.Click += new System.EventHandler(this.btnTruoc_Click);
            // 
            // btnDau
            // 
            this.btnDau.Location = new System.Drawing.Point(40, 25);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(100, 37);
            this.btnDau.TabIndex = 0;
            this.btnDau.Text = "|<<";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // FormLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 652);
            this.Controls.Add(this.gbDieuKhien);
            this.Controls.Add(this.gbXuLy);
            this.Controls.Add(this.gbDanhSach);
            this.Controls.Add(this.gbThongTin);
            this.Controls.Add(this.lblTitle);
            this.Name = "FormLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Mượn Trả";
            this.Load += new System.EventHandler(this.FormLoan_Load);
            this.gbThongTin.ResumeLayout(false);
            this.gbThongTin.PerformLayout();
            this.gbDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSachMuon)).EndInit();
            this.gbXuLy.ResumeLayout(false);
            this.gbDieuKhien.ResumeLayout(false);
            this.gbDieuKhien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIndex;
    }
}