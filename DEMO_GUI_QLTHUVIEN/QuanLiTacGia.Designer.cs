// QuanLiTacGia.Designer.cs
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoAnDemoUI
{
    partial class QuanLiTacGia
    {
        private IContainer components = null;
        private Guna2DataGridView dgvAuthors;
        private Guna2TextBox txtName;
        private Guna2TextBox txtQuocTich;
        private Guna2DateTimePicker dtpNgaySinh;
        private Guna2TextBox txtBio;
        private Guna2Button btnAdd;
        private Guna2Button btnUpdate;
        private Guna2Button btnDelete;
        private Guna2Button btnClear;
        
        // New controls
        private Label lblTitle;
        private GroupBox grpInfo;
        private Label lblMa; // New Label
        private Guna2TextBox txtMa; // New TextBox
        private Label lblTen;
        private Label lblQuocTich;
        private Label lblNgaySinh;
        private Label lblBio;
        private Label lblError; // New Error Label
        private Guna2Button btnClose;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvAuthors = new Guna2DataGridView();
            lblMa = new Label();
            txtMa = new Guna2TextBox();
            txtName = new Guna2TextBox();
            txtQuocTich = new Guna2TextBox();
            dtpNgaySinh = new Guna2DateTimePicker();
            txtBio = new Guna2TextBox();
            btnAdd = new Guna2Button();
            btnUpdate = new Guna2Button();
            btnDelete = new Guna2Button();
            btnClear = new Guna2Button();
            lblTitle = new Label();
            grpInfo = new GroupBox();
            lblTen = new Label();
            lblQuocTich = new Label();
            lblNgaySinh = new Label();
            lblBio = new Label();
            lblError = new Label();
            btnClose = new Guna2Button();
            ((ISupportInitialize)dgvAuthors).BeginInit();
            grpInfo.SuspendLayout();
            SuspendLayout();
            // 
            // dgvAuthors
            // 
            dgvAuthors.AllowUserToAddRows = false;
            dgvAuthors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAuthors.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAuthors.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAuthors.GridColor = Color.FromArgb(231, 229, 255);
            dgvAuthors.Location = new Point(29, 74);
            dgvAuthors.Name = "dgvAuthors";
            dgvAuthors.ReadOnly = true;
            dgvAuthors.RowHeadersVisible = false;
            dgvAuthors.RowHeadersWidth = 51;
            dgvAuthors.Size = new Size(1249, 362);
            dgvAuthors.TabIndex = 1;
            dgvAuthors.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvAuthors.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvAuthors.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvAuthors.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvAuthors.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvAuthors.ThemeStyle.BackColor = Color.White;
            dgvAuthors.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvAuthors.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvAuthors.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAuthors.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvAuthors.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvAuthors.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAuthors.ThemeStyle.HeaderStyle.Height = 40;
            dgvAuthors.ThemeStyle.ReadOnly = true;
            dgvAuthors.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvAuthors.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAuthors.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9.5F);
            dgvAuthors.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvAuthors.ThemeStyle.RowsStyle.Height = 29;
            dgvAuthors.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvAuthors.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvAuthors.CellClick += dgvAuthors_CellClick;
            dgvAuthors.CellContentClick += dgvAuthors_CellContentClick;
            // 
            // lblMa
            // 
            lblMa.Font = new Font("Segoe UI", 10F);
            lblMa.ForeColor = Color.FromArgb(66, 66, 66);
            lblMa.Location = new Point(90, 40);
            lblMa.Name = "lblMa";
            lblMa.Size = new Size(130, 25);
            lblMa.TabIndex = 10;
            lblMa.Text = "Mã tác giả:";
            // 
            // txtMa
            // 
            txtMa.BorderRadius = 2;
            txtMa.Cursor = Cursors.IBeam;
            txtMa.CustomizableEdges = customizableEdges1;
            txtMa.DefaultText = "";
            txtMa.Font = new Font("Segoe UI", 10F);
            txtMa.Location = new Point(240, 35);
            txtMa.Margin = new Padding(3, 4, 3, 4);
            txtMa.Name = "txtMa";
            txtMa.PlaceholderText = "Tự động";
            txtMa.Enabled = false;
            txtMa.ReadOnly = true;
            txtMa.SelectedText = "";
            txtMa.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtMa.Size = new Size(329, 30);
            txtMa.TabIndex = 0;
            txtMa.TextChanged += txtMa_TextChanged;
            // 
            // txtName
            // 
            txtName.BorderRadius = 2;
            txtName.Cursor = Cursors.IBeam;
            txtName.CustomizableEdges = customizableEdges3;
            txtName.DefaultText = "";
            txtName.Font = new Font("Segoe UI", 10F);
            txtName.Location = new Point(706, 32);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "";
            txtName.SelectedText = "";
            txtName.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtName.Size = new Size(520, 30);
            txtName.TabIndex = 1;
            // 
            // txtQuocTich
            // 
            txtQuocTich.BorderRadius = 2;
            txtQuocTich.Cursor = Cursors.IBeam;
            txtQuocTich.CustomizableEdges = customizableEdges5;
            txtQuocTich.DefaultText = "";
            txtQuocTich.Font = new Font("Segoe UI", 10F);
            txtQuocTich.Location = new Point(706, 81);
            txtQuocTich.Margin = new Padding(3, 4, 3, 4);
            txtQuocTich.Name = "txtQuocTich";
            txtQuocTich.PlaceholderText = "";
            txtQuocTich.SelectedText = "";
            txtQuocTich.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtQuocTich.Size = new Size(520, 30);
            txtQuocTich.TabIndex = 3;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.BorderRadius = 2;
            dtpNgaySinh.Checked = true;
            dtpNgaySinh.CustomizableEdges = customizableEdges7;
            dtpNgaySinh.FillColor = Color.White;
            dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(240, 81);
            dtpNgaySinh.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpNgaySinh.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.ShadowDecoration.CustomizableEdges = customizableEdges8;
            dtpNgaySinh.Size = new Size(329, 30);
            dtpNgaySinh.TabIndex = 5;
            dtpNgaySinh.Value = new DateTime(2026, 1, 3, 0, 23, 40, 757);
            // 
            // txtBio
            // 
            txtBio.BorderRadius = 2;
            txtBio.Cursor = Cursors.IBeam;
            txtBio.CustomizableEdges = customizableEdges9;
            txtBio.DefaultText = "";
            txtBio.Font = new Font("Segoe UI", 10F);
            txtBio.Location = new Point(240, 127);
            txtBio.Margin = new Padding(3, 4, 3, 4);
            txtBio.Multiline = true;
            txtBio.Name = "txtBio";
            txtBio.PlaceholderText = "";
            txtBio.SelectedText = "";
            txtBio.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtBio.Size = new Size(986, 60);
            txtBio.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.CustomizableEdges = customizableEdges11;
            btnAdd.FillColor = Color.FromArgb(76, 175, 80);
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(29, 676);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAdd.Size = new Size(110, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "+ Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.CustomizableEdges = customizableEdges13;
            btnUpdate.FillColor = Color.FromArgb(33, 150, 243);
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(149, 676);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnUpdate.Size = new Size(110, 40);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "✎ Sửa";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.CustomizableEdges = customizableEdges15;
            btnDelete.FillColor = Color.FromArgb(244, 67, 54);
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(269, 676);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnDelete.Size = new Size(110, 40);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "🗑 Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.CustomizableEdges = customizableEdges17;
            btnClear.FillColor = Color.FromArgb(158, 158, 158);
            btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(389, 676);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnClear.Size = new Size(110, 40);
            btnClear.TabIndex = 6;
            btnClear.Text = "🚫 Xóa trắng";
            btnClear.Click += btnClear_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(459, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(364, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "👥 QUẢN LÝ TÁC GIẢ";
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblMa);
            grpInfo.Controls.Add(txtMa);
            grpInfo.Controls.Add(lblTen);
            grpInfo.Controls.Add(txtName);
            grpInfo.Controls.Add(lblQuocTich);
            grpInfo.Controls.Add(txtQuocTich);
            grpInfo.Controls.Add(lblNgaySinh);
            grpInfo.Controls.Add(dtpNgaySinh);
            grpInfo.Controls.Add(lblBio);
            grpInfo.Controls.Add(txtBio);

            grpInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            grpInfo.Location = new Point(29, 456);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new Size(1249, 200);
            grpInfo.TabIndex = 2;
            grpInfo.TabStop = false;
            grpInfo.Text = "📝 Thông Tin Tác Giả";
            // 
            // lblTen
            // 
            lblTen.Font = new Font("Segoe UI", 10F);
            lblTen.ForeColor = Color.FromArgb(66, 66, 66);
            lblTen.Location = new Point(600, 32);
            lblTen.Name = "lblTen";
            lblTen.Size = new Size(100, 25);
            lblTen.TabIndex = 0;
            lblTen.Text = "Tên tác giả:";
            lblTen.Click += lblTen_Click;
            // 
            // lblQuocTich
            // 
            lblQuocTich.Font = new Font("Segoe UI", 10F);
            lblQuocTich.ForeColor = Color.FromArgb(66, 66, 66);
            lblQuocTich.Location = new Point(600, 86);
            lblQuocTich.Name = "lblQuocTich";
            lblQuocTich.Size = new Size(100, 25);
            lblQuocTich.TabIndex = 2;
            lblQuocTich.Text = "Quốc tịch:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.Font = new Font("Segoe UI", 10F);
            lblNgaySinh.ForeColor = Color.FromArgb(66, 66, 66);
            lblNgaySinh.Location = new Point(90, 86);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(130, 25);
            lblNgaySinh.TabIndex = 4;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblBio
            // 
            lblBio.Font = new Font("Segoe UI", 10F);
            lblBio.ForeColor = Color.FromArgb(66, 66, 66);
            lblBio.Location = new Point(90, 132);
            lblBio.Name = "lblBio";
            lblBio.Size = new Size(130, 25);
            lblBio.TabIndex = 6;
            lblBio.Text = "Tiểu sử:";
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(520, 685); 
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 20);
            lblError.TabIndex = 8;
            //
            Controls.Add(lblError);
            // 
            // btnClose
            // 
            btnClose.CustomizableEdges = customizableEdges19;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = SystemColors.ButtonHighlight;
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            btnClose.ImageSize = new Size(40, 40);
            btnClose.Location = new Point(1254, 12);
            btnClose.Name = "btnClose";
            btnClose.PressedColor = SystemColors.ButtonFace;
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnClose.Size = new Size(44, 36);
            btnClose.TabIndex = 10;
            btnClose.Click += btnClose_Click;
            // 
            // QuanLiTacGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 250, 250);
            ClientSize = new Size(1310, 743);
            Controls.Add(btnClose);
            Controls.Add(lblTitle);
            Controls.Add(dgvAuthors);
            Controls.Add(grpInfo);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnClear);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLiTacGia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Tác Giả";
            Load += QuanLiTacGia_Load;
            ((ISupportInitialize)dgvAuthors).EndInit();
            grpInfo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
