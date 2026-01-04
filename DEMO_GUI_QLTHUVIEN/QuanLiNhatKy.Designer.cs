using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class QuanLiNhatKy
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

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvLogs = new DataGridView();
            grpDetails = new GroupBox();
            rtbContent = new RichTextBox();
            topPanel = new Panel();
            lblTitle = new Label();
            btnClose = new Guna.UI2.WinForms.Guna2Button();
            lblUser = new Label();
            txtUser = new TextBox();
            lblFunction = new Label();
            cboFunction = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            btnSearch = new Button();
            btnReload = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            grpDetails.SuspendLayout();
            topPanel.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLogs
            // 
            dgvLogs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvLogs.ColumnHeadersHeight = 40;
            dgvLogs.EnableHeadersVisualStyles = false;
            dgvLogs.Location = new Point(20, 120);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersVisible = false;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(1270, 423);
            dgvLogs.TabIndex = 12;
            // 
            // grpDetails
            // 
            grpDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpDetails.Controls.Add(rtbContent);
            grpDetails.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpDetails.Location = new Point(20, 553);
            grpDetails.Name = "grpDetails";
            grpDetails.Size = new Size(1270, 170);
            grpDetails.TabIndex = 13;
            grpDetails.TabStop = false;
            grpDetails.Text = "Chi tiết nội dung thay đổi";
            // 
            // rtbContent
            // 
            rtbContent.BackColor = Color.White;
            rtbContent.BorderStyle = BorderStyle.None;
            rtbContent.Dock = DockStyle.Fill;
            rtbContent.Font = new Font("Segoe UI", 10F);
            rtbContent.Location = new Point(3, 23);
            rtbContent.Name = "rtbContent";
            rtbContent.ReadOnly = true;
            rtbContent.Size = new Size(1264, 144);
            rtbContent.TabIndex = 0;
            rtbContent.Text = "Chọn một dòng để xem chi tiết...";
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.FromArgb(33, 150, 243);
            topPanel.Controls.Add(lblTitle);
            topPanel.Controls.Add(btnClose);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1310, 60);
            topPanel.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1310, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ NHẬT KÝ HOẠT ĐỘNG";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BorderRadius = 5;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.FillColor = Color.FromArgb(231, 76, 60);
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1198, 12);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(100, 36);
            btnClose.TabIndex = 1;
            btnClose.Text = "Thoát";
            btnClose.Click += btnClose_Click;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(20, 80);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(92, 20);
            lblUser.TabIndex = 2;
            lblUser.Text = "Người dùng:";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(100, 77);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(150, 27);
            txtUser.TabIndex = 3;
            // 
            // lblFunction
            // 
            lblFunction.AutoSize = true;
            lblFunction.Location = new Point(270, 80);
            lblFunction.Name = "lblFunction";
            lblFunction.Size = new Size(82, 20);
            lblFunction.TabIndex = 4;
            lblFunction.Text = "Chức năng:";
            // 
            // cboFunction
            // 
            cboFunction.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFunction.Location = new Point(340, 77);
            cboFunction.Name = "cboFunction";
            cboFunction.Size = new Size(170, 28);
            cboFunction.TabIndex = 5;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(530, 80);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(29, 20);
            lblFrom.TabIndex = 6;
            lblFrom.Text = "Từ:";
            // 
            // dtpFrom
            // 
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(560, 77);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(100, 27);
            dtpFrom.TabIndex = 7;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(670, 80);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(15, 20);
            lblTo.TabIndex = 8;
            lblTo.Text = "-";
            // 
            // dtpTo
            // 
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(690, 77);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(100, 27);
            dtpTo.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(820, 75);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(80, 26);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(905, 75);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(80, 26);
            btnReload.TabIndex = 11;
            btnReload.Text = "Tải lại";
            btnReload.Click += btnReload_Click;
            // 
            // QuanLiNhatKy
            // 
            ClientSize = new Size(1310, 743);
            Controls.Add(grpDetails);
            Controls.Add(dgvLogs);
            Controls.Add(btnReload);
            Controls.Add(btnSearch);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(cboFunction);
            Controls.Add(lblFunction);
            Controls.Add(txtUser);
            Controls.Add(lblUser);
            Controls.Add(topPanel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuanLiNhatKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhật Ký Hệ Thống";
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            grpDetails.ResumeLayout(false);
            topPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvLogs;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel topPanel;
        private Guna.UI2.WinForms.Guna2Button btnClose;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox cboFunction;
        private System.Windows.Forms.Label lblFunction;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.GroupBox grpDetails;
        private System.Windows.Forms.RichTextBox rtbContent;
    }
}
