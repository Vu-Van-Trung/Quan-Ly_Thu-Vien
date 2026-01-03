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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();

            this.dgvLogs = new System.Windows.Forms.DataGridView();
            this.grpDetails = new System.Windows.Forms.GroupBox();
            this.rtbContent = new System.Windows.Forms.RichTextBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new Guna.UI2.WinForms.Guna2Button();
            
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblFunction = new System.Windows.Forms.Label();
            this.cboFunction = new System.Windows.Forms.ComboBox();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).BeginInit();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();

            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.topPanel.Controls.Add(this.lblTitle);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1000, 60);
            this.topPanel.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = false;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1000, 60);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ NHẬT KÝ HOẠT ĐỘNG";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BorderRadius = 5;
            this.btnClose.CustomizableEdges = customizableEdges1;
            this.btnClose.FillColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(888, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.btnClose.Size = new System.Drawing.Size(100, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Thoát";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(20, 80);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(92, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Người dùng:";

            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(100, 77);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(150, 27);
            this.txtUser.TabIndex = 3;

            // 
            // lblFunction
            // 
            this.lblFunction.AutoSize = true;
            this.lblFunction.Location = new System.Drawing.Point(270, 80);
            this.lblFunction.Name = "lblFunction";
            this.lblFunction.Size = new System.Drawing.Size(82, 20);
            this.lblFunction.TabIndex = 4;
            this.lblFunction.Text = "Chức năng:";

            // 
            // cboFunction
            // 
            this.cboFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFunction.Location = new System.Drawing.Point(340, 77);
            this.cboFunction.Name = "cboFunction";
            this.cboFunction.Size = new System.Drawing.Size(170, 28);
            this.cboFunction.TabIndex = 5;

            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(530, 80);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(29, 20);
            this.lblFrom.TabIndex = 6;
            this.lblFrom.Text = "Từ:";

            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(560, 77);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(100, 27);
            this.dtpFrom.TabIndex = 7;

            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(670, 80);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(15, 20);
            this.lblTo.TabIndex = 8;
            this.lblTo.Text = "-";

            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(690, 77);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(100, 27);
            this.dtpTo.TabIndex = 9;

            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(820, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(905, 75);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(80, 26);
            this.btnReload.TabIndex = 11;
            this.btnReload.Text = "Tải lại";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);

            // 
            // dgvLogs
            // 
            this.dgvLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLogs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLogs.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLogs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLogs.ColumnHeadersHeight = 40;
            this.dgvLogs.EnableHeadersVisualStyles = false;
            this.dgvLogs.Location = new System.Drawing.Point(20, 120);
            this.dgvLogs.Name = "dgvLogs";
            this.dgvLogs.ReadOnly = true;
            this.dgvLogs.RowHeadersVisible = false;
            this.dgvLogs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLogs.Size = new System.Drawing.Size(960, 280);
            this.dgvLogs.TabIndex = 12;

            // 
            // grpDetails
            // 
            this.grpDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDetails.Controls.Add(this.rtbContent);
            this.grpDetails.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.grpDetails.Location = new System.Drawing.Point(20, 410);
            this.grpDetails.Name = "grpDetails";
            this.grpDetails.Size = new System.Drawing.Size(960, 170);
            this.grpDetails.TabIndex = 13;
            this.grpDetails.TabStop = false;
            this.grpDetails.Text = "Chi tiết nội dung thay đổi";

            // 
            // rtbContent
            // 
            this.rtbContent.BackColor = System.Drawing.Color.White;
            this.rtbContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.rtbContent.Location = new System.Drawing.Point(3, 19);
            this.rtbContent.Name = "rtbContent";
            this.rtbContent.ReadOnly = true;
            this.rtbContent.Size = new System.Drawing.Size(954, 148);
            this.rtbContent.TabIndex = 0;
            this.rtbContent.Text = "Chọn một dòng để xem chi tiết...";

            // 
            // QuanLiNhatKy
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.grpDetails);
            this.Controls.Add(this.dgvLogs);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.cboFunction);
            this.Controls.Add(this.lblFunction);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.topPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "QuanLiNhatKy";
            this.Text = "Nhật Ký Hệ Thống";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogs)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.grpDetails.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
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
