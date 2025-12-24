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
            this.dgvPublishers = new DataGridView();
            this.grpInfo = new GroupBox();
            this.txtPublisherId = new TextBox();
            this.txtTenNhaXuatBan = new TextBox();
            this.txtDiaChi = new TextBox();
            this.txtSoDienThoai = new TextBox();
            this.txtEmail = new TextBox();
            this.lblPublisherId = new Label();
            this.lblTenNXB = new Label();
            this.lblDiaChi = new Label();
            this.lblSoDienThoai = new Label();
            this.lblEmail = new Label();
            this.btnAdd = new Button();
            this.btnEdit = new Button();
            this.btnDelete = new Button();
            this.btnSave = new Button();
            this.btnCancel = new Button();
            this.btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).BeginInit();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPublishers
            // 
            this.dgvPublishers.Location = new Point(20, 20);
            this.dgvPublishers.Size = new Size(960, 300);
            this.dgvPublishers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPublishers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvPublishers.MultiSelect = false;
            this.dgvPublishers.ReadOnly = true;
            this.dgvPublishers.AllowUserToAddRows = false;
            this.dgvPublishers.SelectionChanged += DgvPublishers_SelectionChanged;
            this.dgvPublishers.BackgroundColor = Color.White;
            this.dgvPublishers.BorderStyle = BorderStyle.None;
            this.dgvPublishers.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);
            this.dgvPublishers.EnableHeadersVisualStyles = false;
            this.dgvPublishers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(33, 150, 243);
            this.dgvPublishers.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            this.dgvPublishers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.dgvPublishers.ColumnHeadersHeight = 40;
            this.dgvPublishers.RowTemplate.Height = 35;
            this.dgvPublishers.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
            this.dgvPublishers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(100, 181, 246);
            this.dgvPublishers.DefaultCellStyle.SelectionForeColor = Color.White;
            // 
            // grpInfo
            // 
            this.grpInfo.Text = "?? Thông Tin Nhà Xu?t B?n";
            this.grpInfo.Location = new Point(20, 340);
            this.grpInfo.Size = new Size(960, 200);
            this.grpInfo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            this.grpInfo.ForeColor = Color.FromArgb(33, 150, 243);
            int grpY = 35;
            int grpStep = 42;
            // 
            // lblPublisherId
            // 
            this.lblPublisherId.Text = "Mã NXB:";
            this.lblPublisherId.Location = new Point(20, grpY);
            this.lblPublisherId.Size = new Size(130, 25);
            this.lblPublisherId.Font = new Font("Segoe UI", 10F);
            this.lblPublisherId.ForeColor = Color.FromArgb(66, 66, 66);
            // 
            // txtPublisherId
            // 
            this.txtPublisherId.Location = new Point(155, grpY);
            this.txtPublisherId.Size = new Size(350, 28);
            this.txtPublisherId.Font = new Font("Segoe UI", 10F);
            this.txtPublisherId.BorderStyle = BorderStyle.FixedSingle;
            this.txtPublisherId.ReadOnly = true;
            this.txtPublisherId.BackColor = Color.FromArgb(240, 240, 240);
            // 
            // lblTenNXB
            // 
            this.lblTenNXB.Text = "Tên NXB: *";
            this.lblTenNXB.Location = new Point(530, grpY);
            this.lblTenNXB.Size = new Size(100, 25);
            this.lblTenNXB.Font = new Font("Segoe UI", 10F);
            this.lblTenNXB.ForeColor = Color.FromArgb(66, 66, 66);
            // 
            // txtTenNhaXuatBan
            // 
            this.txtTenNhaXuatBan.Location = new Point(635, grpY);
            this.txtTenNhaXuatBan.Size = new Size(300, 28);
            this.txtTenNhaXuatBan.Font = new Font("Segoe UI", 10F);
            this.txtTenNhaXuatBan.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Text = "??a ch?:";
            this.lblDiaChi.Location = new Point(20, grpY + grpStep);
            this.lblDiaChi.Size = new Size(130, 25);
            this.lblDiaChi.Font = new Font("Segoe UI", 10F);
            this.lblDiaChi.ForeColor = Color.FromArgb(66, 66, 66);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new Point(155, grpY + grpStep);
            this.txtDiaChi.Size = new Size(780, 28);
            this.txtDiaChi.Font = new Font("Segoe UI", 10F);
            this.txtDiaChi.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.Text = "S? ?T:";
            this.lblSoDienThoai.Location = new Point(20, grpY + grpStep * 2);
            this.lblSoDienThoai.Size = new Size(130, 25);
            this.lblSoDienThoai.Font = new Font("Segoe UI", 10F);
            this.lblSoDienThoai.ForeColor = Color.FromArgb(66, 66, 66);
            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Location = new Point(155, grpY + grpStep * 2);
            this.txtSoDienThoai.Size = new Size(200, 28);
            this.txtSoDienThoai.Font = new Font("Segoe UI", 10F);
            this.txtSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            // 
            // lblEmail
            // 
            this.lblEmail.Text = "Email:";
            this.lblEmail.Location = new Point(380, grpY + grpStep * 2);
            this.lblEmail.Size = new Size(70, 25);
            this.lblEmail.Font = new Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = Color.FromArgb(66, 66, 66);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new Point(450, grpY + grpStep * 2);
            this.txtEmail.Size = new Size(485, 28);
            this.txtEmail.Font = new Font("Segoe UI", 10F);
            this.txtEmail.BorderStyle = BorderStyle.FixedSingle;
            // 
            // grpInfo Controls
            // 
            this.grpInfo.Controls.Add(this.lblPublisherId);
            this.grpInfo.Controls.Add(this.txtPublisherId);
            this.grpInfo.Controls.Add(this.lblTenNXB);
            this.grpInfo.Controls.Add(this.txtTenNhaXuatBan);
            this.grpInfo.Controls.Add(this.lblDiaChi);
            this.grpInfo.Controls.Add(this.txtDiaChi);
            this.grpInfo.Controls.Add(this.lblSoDienThoai);
            this.grpInfo.Controls.Add(this.txtSoDienThoai);
            this.grpInfo.Controls.Add(this.lblEmail);
            this.grpInfo.Controls.Add(this.txtEmail);
            // 
            // Buttons
            // 
            int btnY = 560;
            int btnX = 20;
            int btnWidth = 110;
            int btnHeight = 40;
            int btnGap = 10;
            this.btnAdd.Text = "? Thêm";
            this.btnAdd.Location = new Point(btnX, btnY);
            this.btnAdd.Size = new Size(btnWidth, btnHeight);
            this.btnAdd.BackColor = Color.FromArgb(76, 175, 80);
            this.btnAdd.ForeColor = Color.White;
            this.btnAdd.FlatStyle = FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnAdd.Cursor = Cursors.Hand;
            this.btnAdd.Click += BtnAdd_Click;
            this.btnEdit.Text = "?? S?a";
            this.btnEdit.Location = new Point(btnX + (btnWidth + btnGap), btnY);
            this.btnEdit.Size = new Size(btnWidth, btnHeight);
            this.btnEdit.BackColor = Color.FromArgb(33, 150, 243);
            this.btnEdit.ForeColor = Color.White;
            this.btnEdit.FlatStyle = FlatStyle.Flat;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnEdit.Cursor = Cursors.Hand;
            this.btnEdit.Click += BtnEdit_Click;
            this.btnDelete.Text = "??? Xóa";
            this.btnDelete.Location = new Point(btnX + (btnWidth + btnGap) * 2, btnY);
            this.btnDelete.Size = new Size(btnWidth, btnHeight);
            this.btnDelete.BackColor = Color.FromArgb(244, 67, 54);
            this.btnDelete.ForeColor = Color.White;
            this.btnDelete.FlatStyle = FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnDelete.Cursor = Cursors.Hand;
            this.btnDelete.Click += BtnDelete_Click;
            this.btnSave.Text = "?? L?u";
            this.btnSave.Location = new Point(btnX + (btnWidth + btnGap) * 3, btnY);
            this.btnSave.Size = new Size(btnWidth, btnHeight);
            this.btnSave.BackColor = Color.FromArgb(0, 150, 136);
            this.btnSave.ForeColor = Color.White;
            this.btnSave.FlatStyle = FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnSave.Cursor = Cursors.Hand;
            this.btnSave.Click += BtnSave_Click;
            this.btnCancel.Text = "?? H?y";
            this.btnCancel.Location = new Point(btnX + (btnWidth + btnGap) * 4, btnY);
            this.btnCancel.Size = new Size(btnWidth, btnHeight);
            this.btnCancel.BackColor = Color.FromArgb(158, 158, 158);
            this.btnCancel.ForeColor = Color.White;
            this.btnCancel.FlatStyle = FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnCancel.Cursor = Cursors.Hand;
            this.btnCancel.Click += BtnCancel_Click;
            this.btnRefresh.Text = "?? Làm m?i";
            this.btnRefresh.Location = new Point(btnX + (btnWidth + btnGap) * 5, btnY);
            this.btnRefresh.Size = new Size(btnWidth, btnHeight);
            this.btnRefresh.BackColor = Color.FromArgb(96, 125, 139);
            this.btnRefresh.ForeColor = Color.White;
            this.btnRefresh.FlatStyle = FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            this.btnRefresh.Cursor = Cursors.Hand;
            this.btnRefresh.Click += (s, e) => { LoadData(); ClearInputs(); };
            // 
            // FormPublisher
            // 
            this.ClientSize = new Size(1000, 630);
            this.Controls.Add(this.dgvPublishers);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRefresh);
            this.Text = "Qu?n Lý Nhà Xu?t B?n";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.FromArgb(250, 250, 250);
            this.Font = new Font("Segoe UI", 9F);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPublishers)).EndInit();
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private DataGridView dgvPublishers;
        private GroupBox grpInfo;
        private TextBox txtPublisherId;
        private TextBox txtTenNhaXuatBan;
        private TextBox txtDiaChi;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
        private Label lblPublisherId;
        private Label lblTenNXB;
        private Label lblDiaChi;
        private Label lblSoDienThoai;
        private Label lblEmail;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnSave;
        private Button btnCancel;
        private Button btnRefresh;
    }
}
