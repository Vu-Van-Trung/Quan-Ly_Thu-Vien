#nullable disable
using LibraryManagement.Data;
using LibraryManagement.Models;
using LibraryManagement.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class FormMember : Form
    {
        private LibraryContext db;
        private bool isEditing = false;

        public FormMember()
        {
            InitializeComponent();
            Load += FormMember_Load;

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnLuu.Click += BtnLuu_Click;
            btnHuy.Click += BtnHuy_Click;
            btnTimKiem.Click += BtnTimKiem_Click;
            dgvMembers.SelectionChanged += DgvMembers_SelectionChanged;

            txtMemberId.ReadOnly = true;
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadData();
            SetControlState(false);
        }

        // ===== TẢI DỮ LIỆU & GIẢI MÃ =====
        private void LoadData()
        {
            try
            {
                // Sử dụng AsNoTracking để tăng hiệu suất khi chỉ đọc dữ liệu
                var rawData = db.Members.AsNoTracking().ToList();

                var data = rawData.Select(m => new
                {
                    m.MemberId,
                    FullName = DecryptOrEmpty(m.FullName),
                    m.NgaySinh,
                    m.GioiTinh,
                    CMND = DecryptOrEmpty(m.CMND), // Giải mã CCCD/CMND
                    DiaChi = DecryptOrEmpty(m.DiaChi), // Giải mã Địa chỉ
                    PhoneNumber = DecryptOrEmpty(m.PhoneNumber), // Giải mã SĐT
                    Email = DecryptOrEmpty(m.Email), // Giải mã Email
                    m.JoinDate,
                    m.NgayHetHan,
                    m.TrangThai,
                    m.GhiChu
                }).ToList();

                dgvMembers.DataSource = data;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatGrid()
        {
            if (dgvMembers.Columns.Count == 0) return;

            void SetHeader(string columnName, string header, int width = 0)
            {
                if (dgvMembers.Columns[columnName] != null)
                {
                    dgvMembers.Columns[columnName].HeaderText = header;
                    if (width > 0) dgvMembers.Columns[columnName].Width = width;
                }
            }

            SetHeader("MemberId", "Mã ĐG", 70);
            SetHeader("FullName", "Họ Tên", 150);
            SetHeader("NgaySinh", "Ngày Sinh", 90);
            SetHeader("GioiTinh", "Giới Tính", 70);
            SetHeader("CMND", "CCCD/CMND", 100);
            SetHeader("DiaChi", "Địa Chỉ", 200);
            SetHeader("PhoneNumber", "SĐT", 100);
            SetHeader("Email", "Email", 150);
            SetHeader("JoinDate", "Ngày ĐK", 90);
            SetHeader("TrangThai", "Trạng Thái", 90);
        }

        private void DgvMembers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null || isEditing) return;

            var row = dgvMembers.CurrentRow;
            txtMemberId.Text = row.Cells["MemberId"].Value?.ToString();
            txtFullName.Text = row.Cells["FullName"].Value?.ToString();
            txtCMND.Text = row.Cells["CMND"].Value?.ToString();
            txtDiaChi.Text = row.Cells["DiaChi"].Value?.ToString();
            txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            cboGioiTinh.Text = row.Cells["GioiTinh"].Value?.ToString();
            cboTrangThai.Text = row.Cells["TrangThai"].Value?.ToString();
            txtGhiChu.Text = row.Cells["GhiChu"].Value?.ToString();

            dtpNgaySinh.Value = ParseDate(row.Cells["NgaySinh"].Value, DateTime.Now.AddYears(-25));
            dtpNgayDangKy.Value = ParseDate(row.Cells["JoinDate"].Value, DateTime.Now);
            dtpNgayHetHan.Value = ParseDate(row.Cells["NgayHetHan"].Value, DateTime.Now.AddYears(1));
        }

        private static DateTime ParseDate(object value, DateTime fallback)
        {
            if (value == null || value == DBNull.Value) return fallback;
            return DateTime.TryParse(value.ToString(), out var date) ? date : fallback;
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            isEditing = true;
            SetControlState(true);
            ClearInputs();
            txtMemberId.Text = "(Tự động)";
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
            var memberId = dgvMembers.CurrentRow.Cells["MemberId"].Value?.ToString();
            if (string.IsNullOrEmpty(memberId)) return;

            if (MessageBox.Show($"Xác nhận xóa độc giả mã {memberId}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
                    }
                }
                catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
            }
        }

        private string GenerateMemberId()
        {
            var existing = db.Members.Select(m => m.MemberId).AsEnumerable()
                .Select(id => (id.StartsWith("DG") && int.TryParse(id.Substring(2), out var num)) ? num : 0)
                .DefaultIfEmpty(0).Max();
            return $"DG{existing + 1:D3}";
        }

        // ===== LƯU DỮ LIỆU & MÃ HÓA =====
        private void BtnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("⚠️ Vui lòng nhập họ tên!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool isNew = (txtMemberId.Text == "(Tự động)" || string.IsNullOrEmpty(txtMemberId.Text));
                Member member;

                if (isNew)
                {
                    member = new Member { MemberId = GenerateMemberId() };
                    db.Members.Add(member);
                }
                else
                {
                    member = db.Members.Find(txtMemberId.Text);
                }

                if (member != null)
                {
                    // Thực hiện mã hóa tất cả các trường thông tin cá nhân nhạy cảm
                    member.FullName = CryptoHelper.Encrypt(txtFullName.Text.Trim());
                    member.CMND = string.IsNullOrWhiteSpace(txtCMND.Text) ? null : CryptoHelper.Encrypt(txtCMND.Text.Trim());
                    member.DiaChi = string.IsNullOrWhiteSpace(txtDiaChi.Text) ? null : CryptoHelper.Encrypt(txtDiaChi.Text.Trim());
                    member.PhoneNumber = string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ? null : CryptoHelper.Encrypt(txtPhoneNumber.Text.Trim());
                    member.Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : CryptoHelper.Encrypt(txtEmail.Text.Trim());

                    member.NgaySinh = dtpNgaySinh.Value;
                    member.GioiTinh = cboGioiTinh.Text;
                    member.JoinDate = dtpNgayDangKy.Value;
                    member.NgayHetHan = dtpNgayHetHan.Value;
                    member.TrangThai = cboTrangThai.Text;
                    member.GhiChu = txtGhiChu.Text.Trim();

                    db.SaveChanges();
                    MessageBox.Show(isNew ? "✅ Thêm thành công!" : "✅ Cập nhật thành công!", "Thông báo");

                    isEditing = false;
                    SetControlState(false);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Lỗi khi lưu (Kiểm tra độ dài cột Database): " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            var keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword)) { LoadData(); return; }

            // Lọc dữ liệu sau khi giải mã trên RAM (AsEnumerable)
            var result = db.Members.AsEnumerable()
                .Select(m => new
                {
                    m.MemberId,
                    FullName = DecryptOrEmpty(m.FullName),
                    m.NgaySinh,
                    m.GioiTinh,
                    CMND = DecryptOrEmpty(m.CMND),
                    DiaChi = DecryptOrEmpty(m.DiaChi),
                    PhoneNumber = DecryptOrEmpty(m.PhoneNumber),
                    Email = DecryptOrEmpty(m.Email),
                    m.JoinDate,
                    m.NgayHetHan,
                    m.TrangThai,
                    m.GhiChu
                })
                .Where(m =>
                    m.FullName.ToLower().Contains(keyword) ||
                    m.PhoneNumber.Contains(keyword) ||
                    m.CMND.Contains(keyword) ||
                    m.Email.ToLower().Contains(keyword))
                .ToList();

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
        }

        private void ClearInputs()
        {
            txtMemberId.Clear();
            txtFullName.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            txtPhoneNumber.Clear();
            txtEmail.Clear();
            txtGhiChu.Clear();
            dtpNgaySinh.Value = DateTime.Now.AddYears(-25);
            dtpNgayDangKy.Value = DateTime.Now;
            dtpNgayHetHan.Value = DateTime.Now.AddYears(1);
            cboTrangThai.SelectedIndex = 0;
        }

        private static string DecryptOrEmpty(string value)
        {
            return string.IsNullOrEmpty(value) ? string.Empty : CryptoHelper.Decrypt(value);
        }

        private void lblTitle_Click(object sender, EventArgs e) { }
        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}