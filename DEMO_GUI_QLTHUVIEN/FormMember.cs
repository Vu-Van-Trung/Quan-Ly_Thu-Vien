using LibraryManagement.Data;
using LibraryManagement.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    /// <summary>
    /// Form Quản lý Độc giả - Logic handling
    /// </summary>
    public partial class FormMember : Form
    {
        private LibraryContext db;
        private bool isEditing = false;

        public FormMember()
        {
            InitializeComponent();
            this.Load += FormMember_Load;

            // Gán sự kiện
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            btnTimKiem.Click += BtnTimKiem_Click;
            dgvMembers.SelectionChanged += DgvMembers_SelectionChanged;
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadData();
            SetControlState(false);
        }

        private void LoadData()
        {
            try
            {
                var data = db.Members.Select(m => new
                {
                    m.MemberId,
                    m.FullName,
                    m.NgaySinh,
                    m.GioiTinh,
                    m.CMND,
                    m.DiaChi,
                    m.PhoneNumber,
                    m.Email,
                    m.JoinDate,
                    m.NgayHetHan,
                    m.TrangThai,
                    m.GhiChu
                }).ToList();

                dgvMembers.DataSource = data;

                // Đặt tên cột tiếng Việt
                dgvMembers.Columns["MemberId"].HeaderText = "Mã ĐG";
                dgvMembers.Columns["FullName"].HeaderText = "Họ Tên";
                dgvMembers.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
                dgvMembers.Columns["GioiTinh"].HeaderText = "Giới Tính";
                dgvMembers.Columns["CMND"].HeaderText = "CMND";
                dgvMembers.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvMembers.Columns["PhoneNumber"].HeaderText = "SĐT";
                dgvMembers.Columns["Email"].HeaderText = "Email";
                dgvMembers.Columns["JoinDate"].HeaderText = "Ngày ĐK";
                dgvMembers.Columns["NgayHetHan"].HeaderText = "Hết Hạn";
                dgvMembers.Columns["TrangThai"].HeaderText = "Trạng Thái";
                dgvMembers.Columns["GhiChu"].HeaderText = "Ghi Chú";

                // Điều chỉnh width
                dgvMembers.Columns["MemberId"].Width = 70;
                dgvMembers.Columns["NgaySinh"].Width = 90;
                dgvMembers.Columns["GioiTinh"].Width = 70;
                dgvMembers.Columns["JoinDate"].Width = 90;
                dgvMembers.Columns["NgayHetHan"].Width = 90;
                dgvMembers.Columns["TrangThai"].Width = 90;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow != null && !isEditing)
            {
                var row = dgvMembers.CurrentRow;

                txtMemberId.Text = row.Cells["MemberId"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();

                if (row.Cells["NgaySinh"].Value != null && row.Cells["NgaySinh"].Value != DBNull.Value)
                    dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["NgaySinh"].Value);
                else
                    dtpNgaySinh.Value = DateTime.Now.AddYears(-25);

                cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
                txtCMND.Text = row.Cells["CMND"].Value?.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();

                if (row.Cells["JoinDate"].Value != null && row.Cells["JoinDate"].Value != DBNull.Value)
                    dtpNgayDangKy.Value = Convert.ToDateTime(row.Cells["JoinDate"].Value);
                else
                    dtpNgayDangKy.Value = DateTime.Now;

                if (row.Cells["NgayHetHan"].Value != null && row.Cells["NgayHetHan"].Value != DBNull.Value)
                    dtpNgayHetHan.Value = Convert.ToDateTime(row.Cells["NgayHetHan"].Value);
                else
                    dtpNgayHetHan.Value = DateTime.Now.AddYears(1);

                cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
                txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isEditing = true;
            SetControlState(true);
            ClearInputs();
            txtMemberId.Text = "(Tự động)";
            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now.AddYears(1);
            cboTrangThai.SelectedIndex = 0;
            txtFullName.Focus();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn độc giả cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            isEditing = true;
            SetControlState(true);
            txtFullName.Focus();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null) return;

            string memberId = dgvMembers.CurrentRow.Cells["MemberId"].Value?.ToString();
            string name = dgvMembers.CurrentRow.Cells["FullName"].Value?.ToString();

            if (MessageBox.Show($"Bạn có chắc muốn xóa độc giả '{name}'?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    var member = db.Members.Find(memberId);
                    if (member != null)
                    {
                        db.Members.Remove(member);
                        db.SaveChanges();
                        LoadData();
                        ClearInputs();
                        MessageBox.Show("✅ Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Không thể xóa (có thể do đang mượn sách).\nLỗi: " + ex.Message,
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GenerateMemberId()
        {
            var existing = db.Members
                .Select(m => m.MemberId)
                .AsEnumerable()
                .Select(id =>
                {
                    if (id != null && id.StartsWith("DG") && int.TryParse(id.Substring(2), out int num))
                        return num;
                    return 0;
                })
                .DefaultIfEmpty(0)
                .Max();
            return $"DG{existing + 1:D3}";
        }

        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập họ tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (txtMemberId.Text == "(Tự động)" || string.IsNullOrEmpty(txtMemberId.Text))
                {
                    // Thêm mới
                    var newMember = new Member
                    {
                        MemberId = GenerateMemberId(),
                        FullName = txtFullName.Text.Trim(),
                        NgaySinh = dtpNgaySinh.Value,
                        GioiTinh = cboGioiTinh.Text,
                        CMND = txtCMND.Text.Trim(),
                        DiaChi = txtDiaChi.Text.Trim(),
                        PhoneNumber = txtPhoneNumber.Text.Trim(),
                        Email = txtEmail.Text.Trim(),
                        JoinDate = dtpNgayDangKy.Value,
                        NgayHetHan = dtpNgayHetHan.Value,
                        TrangThai = cboTrangThai.Text,
                        GhiChu = txtGhiChu.Text.Trim()
                    };
                    db.Members.Add(newMember);
                    db.SaveChanges();
                    MessageBox.Show("✅ Thêm độc giả thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Cập nhật
                    string memberId = txtMemberId.Text;
                    var member = db.Members.Find(memberId);
                    if (member != null)
                    {
                        member.FullName = txtFullName.Text.Trim();
                        member.NgaySinh = dtpNgaySinh.Value;
                        member.GioiTinh = cboGioiTinh.Text;
                        member.CMND = txtCMND.Text.Trim();
                        member.DiaChi = txtDiaChi.Text.Trim();
                        member.PhoneNumber = txtPhoneNumber.Text.Trim();
                        member.Email = txtEmail.Text.Trim();
                        member.JoinDate = dtpNgayDangKy.Value;
                        member.NgayHetHan = dtpNgayHetHan.Value;
                        member.TrangThai = cboTrangThai.Text;
                        member.GhiChu = txtGhiChu.Text.Trim();

                        db.SaveChanges();
                        MessageBox.Show("✅ Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                isEditing = false;
                SetControlState(false);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            isEditing = false;
            SetControlState(false);
            DgvMembers_SelectionChanged(null, null);
        }

        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            var result = db.Members.Where(m =>
                m.FullName.ToLower().Contains(keyword) ||
                (m.PhoneNumber != null && m.PhoneNumber.Contains(keyword)) ||
                (m.Email != null && m.Email.ToLower().Contains(keyword)) ||
                (m.CMND != null && m.CMND.Contains(keyword)))
                .Select(m => new
                {
                    m.MemberId,
                    m.FullName,
                    m.NgaySinh,
                    m.GioiTinh,
                    m.CMND,
                    m.DiaChi,
                    m.PhoneNumber,
                    m.Email,
                    m.JoinDate,
                    m.NgayHetHan,
                    m.TrangThai,
                    m.GhiChu
                }).ToList();

            dgvMembers.DataSource = result;
        }

        private void SetControlState(bool editing)
        {
            txtFullName.ReadOnly = !editing;
            dtpNgaySinh.Enabled = editing;
            cboGioiTinh.Enabled = editing;
            txtCMND.ReadOnly = !editing;
            txtDiaChi.ReadOnly = !editing;
            txtPhoneNumber.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            dtpNgayDangKy.Enabled = editing;
            dtpNgayHetHan.Enabled = editing;
            cboTrangThai.Enabled = editing;
            txtGhiChu.ReadOnly = !editing;

            btnThem.Enabled = !editing;
            btnSua.Enabled = !editing;
            btnXoa.Enabled = !editing;
            btnTimKiem.Enabled = !editing;

            btnLuu.Enabled = editing;
            btnHuy.Enabled = editing;

            dgvMembers.Enabled = !editing;

            // Visual feedback
            if (editing)
            {
                grpPersonal.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
                grpContact.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
                grpMembership.ForeColor = System.Drawing.Color.FromArgb(76, 175, 80);
            }
            else
            {
                grpPersonal.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
                grpContact.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
                grpMembership.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            }
        }

        private void ClearInputs()
        {
            txtMemberId.Clear();
            txtFullName.Clear();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
            cboGioiTinh.SelectedIndex = -1;
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now.AddYears(1);
            cboTrangThai.SelectedIndex = 0;
            txtGhiChu.Clear();
        }

        private void lblTitle_Click(object sender, EventArgs e) { }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}