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
            this.dgvAuthors = new Guna2DataGridView();
            this.txtName = new Guna2TextBox();
            this.txtQuocTich = new Guna2TextBox();
            this.dtpNgaySinh = new Guna2DateTimePicker();
            this.txtBio = new Guna2TextBox();
            this.btnAdd = new Guna2Button();
            this.btnUpdate = new Guna2Button();
            this.btnDelete = new Guna2Button();
            this.btnClear = new Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.AllowUserToAddRows = false;
            this.dgvAuthors.AllowUserToDeleteRows = false;
            this.dgvAuthors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuthors.BackgroundColor = Color.White;
            this.dgvAuthors.BorderStyle = BorderStyle.None;
            this.dgvAuthors.ColumnHeadersHeight = 30;
            this.dgvAuthors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAuthors.Location = new Point(20, 20);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.RowHeadersVisible = false;
            this.dgvAuthors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAuthors.Size = new Size(800, 300);
            this.dgvAuthors.TabIndex = 0;
            this.dgvAuthors.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvAuthors.CellClick += new DataGridViewCellEventHandler(this.dgvAuthors_CellClick);
            // 
            // txtName
            // 
            this.txtName.BorderRadius = 8;
            this.txtName.Cursor = Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            this.txtName.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            this.txtName.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            this.txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            this.txtName.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            this.txtName.Font = new Font("Segoe UI", 10F);
            this.txtName.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            this.txtName.Location = new Point(850, 30);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Tên tác giả";
            this.txtName.Size = new Size(250, 40);
            this.txtName.TabIndex = 1;
            // 
            // txtQuocTich
            // 
            this.txtQuocTich.BorderRadius = 8;
            this.txtQuocTich.Cursor = Cursors.IBeam;
            this.txtQuocTich.DefaultText = "";
            this.txtQuocTich.Font = new Font("Segoe UI", 10F);
            this.txtQuocTich.Location = new Point(850, 90);
            this.txtQuocTich.Name = "txtQuocTich";
            this.txtQuocTich.PlaceholderText = "Quốc tịch";
            this.txtQuocTich.Size = new Size(250, 40);
            this.txtQuocTich.TabIndex = 2;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BorderRadius = 8;
            this.dtpNgaySinh.Checked = true;
            this.dtpNgaySinh.Font = new Font("Segoe UI", 10F);
            this.dtpNgaySinh.Format = DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new Point(850, 150);
            this.dtpNgaySinh.MaxDate = new DateTime(2100, 12, 31);
            this.dtpNgaySinh.MinDate = new DateTime(1900, 1, 1);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new Size(250, 40);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // txtBio
            // 
            this.txtBio.BorderRadius = 8;
            this.txtBio.Cursor = Cursors.IBeam;
            this.txtBio.DefaultText = "";
            this.txtBio.Font = new Font("Segoe UI", 10F);
            this.txtBio.Location = new Point(850, 210);
            this.txtBio.Multiline = true;
            this.txtBio.Name = "txtBio";
            this.txtBio.PlaceholderText = "Tiểu sử (tùy chọn)";
            this.txtBio.Size = new Size(250, 110);
            this.txtBio.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 12;
            this.btnAdd.FillColor = Color.FromArgb(46, 204, 113);
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.Location = new Point(850, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new Size(115, 45);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 12;
            this.btnUpdate.FillColor = Color.FromArgb(52, 152, 219);
            this.btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnUpdate.ForeColor = Color.White;
            this.btnUpdate.Location = new Point(985, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new Size(115, 45);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 12;
            this.btnDelete.FillColor = Color.FromArgb(231, 76, 60);
            this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.Location = new Point(850, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new Size(115, 45);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 12;
            this.btnClear.FillColor = Color.FromArgb(149, 165, 166);
            this.btnClear.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnClear.ForeColor = Color.White;
            this.btnClear.Location = new Point(985, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(115, 45);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Xóa trắng";
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // QuanLiTacGia
            // 
            this.AutoScaleDimensions = new SizeF(8F, 20F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1120, 470);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBio);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.txtQuocTich);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dgvAuthors);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Name = "QuanLiTacGia";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tác Giả";
            this.Load += new EventHandler(this.QuanLiTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.ResumeLayout(false);
        }
    }
}
