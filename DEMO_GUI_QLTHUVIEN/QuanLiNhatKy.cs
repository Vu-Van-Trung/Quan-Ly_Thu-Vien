using System;
using System.Linq;
using System.Windows.Forms;
using LibraryManagement.Data;
using LibraryManagement.Models;
using System.Data;

namespace DoAnDemoUI
{
    public partial class QuanLiNhatKy : Form
    {
        private LibraryContext db;

        public QuanLiNhatKy()
        {
            InitializeComponent();
            db = new LibraryContext();
            
            // Set default date range to last 30 days
            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpTo.Value = DateTime.Now;

            SetupDataGridView();
            LoadFunctions();
            LoadData();

            dgvLogs.SelectionChanged += DgvLogs_SelectionChanged;
        }

        private void DgvLogs_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLogs.CurrentRow != null && dgvLogs.CurrentRow.DataBoundItem != null)
            {
                var log = (SystemLog)dgvLogs.CurrentRow.DataBoundItem;
                rtbContent.Text = $"[{log.ThoiGian:dd/MM/yyyy HH:mm:ss}] {log.TenDangNhap} - {log.ChucNang} ({log.HanhDong}):\n{log.NoiDung}";
            }
            else
            {
                rtbContent.Clear();
            }
        }

        private void LoadFunctions()
        {
            try
            {
                var functions = db.SystemLogs.Select(l => l.ChucNang).Distinct().ToList();
                functions.Insert(0, "Tất cả");
                cboFunction.DataSource = functions;
                cboFunction.SelectedIndex = 0;
            }
            catch { }
        }

        private void LoadData()
        {
            try
            {
                var query = db.SystemLogs.AsQueryable();

                // 1. User Filter
                if (!string.IsNullOrWhiteSpace(txtUser.Text))
                {
                    string user = txtUser.Text.Trim().ToLower();
                    query = query.Where(x => x.TenDangNhap.ToLower().Contains(user));
                }

                // 2. Function Filter
                if (cboFunction.SelectedIndex > 0)
                {
                    string func = cboFunction.SelectedItem.ToString();
                    query = query.Where(x => x.ChucNang == func);
                }

                // 3. Date Filter (inclusive)
                var fromDate = dtpFrom.Value.Date;
                var toDate = dtpTo.Value.Date.AddDays(1).AddTicks(-1); // End of day
                query = query.Where(x => x.ThoiGian >= fromDate && x.ThoiGian <= toDate);

                var logs = query.OrderByDescending(x => x.ThoiGian).ToList();
                dgvLogs.DataSource = logs;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải nhật ký: " + ex.ToString());
            }
        }

        private void SetupDataGridView()
        {
            dgvLogs.AutoGenerateColumns = false;
            dgvLogs.Columns.Clear();

            DataGridViewTextBoxColumn colId = new DataGridViewTextBoxColumn();
            colId.DataPropertyName = "LogId";
            colId.HeaderText = "ID";
            colId.Name = "LogId";
            colId.Width = 60;
            dgvLogs.Columns.Add(colId);

            DataGridViewTextBoxColumn colUser = new DataGridViewTextBoxColumn();
            colUser.DataPropertyName = "TenDangNhap";
            colUser.HeaderText = "Người Dùng";
            colUser.Name = "TenDangNhap";
            colUser.Width = 120;
            dgvLogs.Columns.Add(colUser);

            DataGridViewTextBoxColumn colFunc = new DataGridViewTextBoxColumn();
            colFunc.DataPropertyName = "ChucNang";
            colFunc.HeaderText = "Chức Năng";
            colFunc.Name = "ChucNang";
            colFunc.Width = 150;
            dgvLogs.Columns.Add(colFunc);

            DataGridViewTextBoxColumn colAction = new DataGridViewTextBoxColumn();
            colAction.DataPropertyName = "HanhDong";
            colAction.HeaderText = "Hành Động";
            colAction.Name = "HanhDong";
            colAction.Width = 150;
            dgvLogs.Columns.Add(colAction);

            DataGridViewTextBoxColumn colContent = new DataGridViewTextBoxColumn();
            colContent.DataPropertyName = "NoiDung";
            colContent.HeaderText = "Nội Dung";
            colContent.Name = "NoiDung";
            colContent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLogs.Columns.Add(colContent);

            DataGridViewTextBoxColumn colTime = new DataGridViewTextBoxColumn();
            colTime.DataPropertyName = "ThoiGian";
            colTime.HeaderText = "Thời Gian";
            colTime.Name = "ThoiGian";
            colTime.DefaultCellStyle.Format = "dd/MM/yyyy HH:mm:ss";
            colTime.Width = 160;
            dgvLogs.Columns.Add(colTime);
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            if (cboFunction.Items.Count > 0) cboFunction.SelectedIndex = 0;
            dtpFrom.Value = DateTime.Now.AddDays(-30);
            dtpTo.Value = DateTime.Now;
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
