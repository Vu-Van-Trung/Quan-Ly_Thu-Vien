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
        private Label lblTen;
        private Label lblQuocTich;
        private Label lblNgaySinh;
        private Label lblBio;
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.components = new Container();
            this.dgvAuthors = new Guna2DataGridView();
            this.txtName = new Guna2TextBox();
            this.txtQuocTich = new Guna2TextBox();
            this.dtpNgaySinh = new Guna2DateTimePicker();
            this.txtBio = new Guna2TextBox();
            this.btnAdd = new Guna2Button();
            this.btnUpdate = new Guna2Button();
            this.btnDelete = new Guna2Button();
            this.btnClear = new Guna2Button();
            this.lblTitle = new Label();
            this.grpInfo = new GroupBox();
            this.lblTen = new Label();
            this.lblQuocTich = new Label();
            this.lblNgaySinh = new Label();
            this.lblBio = new Label();
            this.btnClose = new Guna2Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            this.lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            this.lblTitle.Location = new Point(459, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new Size(492, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "👥 QUẢN LÝ TÁC GIẢ";

            // 
            // btnClose
            // 
            this.btnClose.CustomizableEdges = customizableEdges1;
            this.btnClose.DisabledState.BorderColor = Color.DarkGray;
            this.btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            this.btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            this.btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            this.btnClose.FillColor = SystemColors.ButtonHighlight;
            this.btnClose.Font = new Font("Segoe UI", 9F);
            this.btnClose.ForeColor = Color.White;
            this.btnClose.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            this.btnClose.ImageSize = new Size(40, 40);
            this.btnClose.Location = new Point(1254, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedColor = SystemColors.ButtonFace;
            this.btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnClose.Size = new Size(44, 36);
            this.btnClose.TabIndex = 10;
            this.btnClose.Click += new EventHandler(this.btnClose_Click);

            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 245, 245);
            this.dgvAuthors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthors.BackgroundColor = Color.White;
            this.dgvAuthors.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            this.dgvAuthors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAuthors.ColumnHeadersHeight = 40;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(100, 181, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            this.dgvAuthors.DefaultCellStyle = dataGridViewCellStyle3;
            
            this.dgvAuthors.EnableHeadersVisualStyles = false;
            this.dgvAuthors.Location = new Point(29, 74);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.RowHeadersVisible = false;
            this.dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthors.Size = new Size(1249, 362);
            this.dgvAuthors.TabIndex = 1;
            this.dgvAuthors.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvAuthors.CellClick += new DataGridViewCellEventHandler(this.dgvAuthors_CellClick);

            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.lblTen);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.lblQuocTich);
            this.grpInfo.Controls.Add(this.txtQuocTich);
            this.grpInfo.Controls.Add(this.lblNgaySinh);
            this.grpInfo.Controls.Add(this.dtpNgaySinh);
            this.grpInfo.Controls.Add(this.lblBio);
            this.grpInfo.Controls.Add(this.txtBio);
            this.grpInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            this.grpInfo.Location = new Point(29, 456);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new Size(1249, 200);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "📝 Thông Tin Tác Giả";

            // 
            // lblTen
            // 
            this.lblTen.Font = new Font("Segoe UI", 10F);
            this.lblTen.ForeColor = Color.FromArgb(66, 66, 66);
            this.lblTen.Location = new Point(90, 40);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new Size(130, 25);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên tác giả:";

            // 
            // txtName
            // 
            this.txtName.BorderRadius = 2; // Reduced radius to look more square like reference, or keep 8? formPublisher uses straight box. I'll use 2 for slight rounding or 0.
            this.txtName.Cursor = Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.Font = new Font("Segoe UI", 10F);
            this.txtName.Location = new Point(240, 35);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "";
            this.txtName.Size = new Size(329, 30);
            this.txtName.TabIndex = 1;

            // 
            // lblQuocTich
            // 
            this.lblQuocTich.Font = new Font("Segoe UI", 10F);
            this.lblQuocTich.ForeColor = Color.FromArgb(66, 66, 66);
            this.lblQuocTich.Location = new Point(600, 40);
            this.lblQuocTich.Name = "lblQuocTich";
            this.lblQuocTich.Size = new Size(100, 25);
            this.lblQuocTich.TabIndex = 2;
            this.lblQuocTich.Text = "Quốc tịch:";

            // 
            // txtQuocTich
            // 
            this.txtQuocTich.BorderRadius = 2;
            this.txtQuocTich.Cursor = Cursors.IBeam;
            this.txtQuocTich.DefaultText = "";
            this.txtQuocTich.Font = new Font("Segoe UI", 10F);
            this.txtQuocTich.Location = new Point(706, 35);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.PlaceholderText = "";
            this.txtQuocTich.Size = new Size(520, 30);
            this.txtQuocTich.TabIndex = 3;

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new Font("Segoe UI", 10F);
            this.lblNgaySinh.ForeColor = Color.FromArgb(66, 66, 66);
            this.lblNgaySinh.Location = new Point(90, 86);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new Size(130, 25);
            this.lblNgaySinh.TabIndex = 4;
            this.lblNgaySinh.Text = "Ngày sinh:";

            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderRadius = 2;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            this.dtpNgaySinh.Format = DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new Point(240, 81);
            this.dtpNgaySinh.MaxDate = new DateTime(2100, 12, 31);
            this.dtpNgaySinh.MinDate = new DateTime(1900, 1, 1);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new Size(329, 30);
            this.dtpNgaySinh.TabIndex = 5;
            this.dtpNgaySinh.FillColor = Color.White; // Match textbox style

            // 
            // lblBio
            // 
            this.lblBio.Font = new Font("Segoe UI", 10F);
            this.lblBio.ForeColor = Color.FromArgb(66, 66, 66);
            this.lblBio.Location = new Point(90, 132); // Slightly lower
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new Size(130, 25);
            this.lblBio.TabIndex = 6;
            this.lblBio.Text = "Tiểu sử:";

            // 
            // txtBio
            // 
            this.txtBio.BorderRadius = 2;
            this.txtBio.Cursor = Cursors.IBeam;
            this.txtBio.DefaultText = "";
            this.txtBio.Font = new Font("Segoe UI", 10F);
            this.txtBio.Location = new Point(240, 127);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.PlaceholderText = "";
            this.txtBio.Size = new Size(986, 60); // Wider box for Bio
            this.txtBio.TabIndex = 7;

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = Color.Empty;
            this.btnAdd.BorderRadius = 0; // Flat style preferred for this design
            this.btnAdd.FillColor = Color.FromArgb(76, 175, 80);
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Location = new Point(29, 676);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(110, 40);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+ Thêm";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 0;
            this.btnUpdate.FillColor = Color.FromArgb(33, 150, 243);
            this.btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.Location = new Point(149, 676);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(110, 40);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "✎ Sửa";
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);

            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.FillColor = Color.FromArgb(244, 67, 54);
            this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Location = new Point(269, 676);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(110, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "🗑 Xóa";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);

            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 0;
            this.btnClear.FillColor = Color.FromArgb(158, 158, 158);
            this.btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(389, 676);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(110, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "🚫 Xóa trắng";
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            // 
            // QuanLiTacGia
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.ClientSize = new Size(1310, 743);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgvAuthors);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "QuanLiTacGia";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tác Giả";
            this.Load += new EventHandler(this.QuanLiTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
