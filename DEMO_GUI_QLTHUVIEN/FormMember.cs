using LibraryManagement.Data;
using LibraryManagement.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class FormMember : Form
    {
        private LibraryContext db;

        public FormMember()
        {
            InitializeComponent();
            this.Load += FormMember_Load;

            // Gán sự kiện
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnThoat.Click += (s, e) => this.Close();
            btnTimKiem.Click += BtnTimKiem_Click;
            dgvDanhSach.SelectionChanged += DgvDanhSach_SelectionChanged;
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            db = new LibraryContext();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var data = db.Members.Select(m => new
                {
                    m.MemberId,
                    m.FullName,
                    m.Email,
                    m.PhoneNumber,
                    m.JoinDate
                }).ToList();

                dgvDanhSach.DataSource = data;

                // Đặt tên cột tiếng Việt
                dgvDanhSach.Columns["MemberId"].HeaderText = "Mã ĐG";
                dgvDanhSach.Columns["FullName"].HeaderText = "Họ Tên";
                dgvDanhSach.Columns["Email"].HeaderText = "Email";
                dgvDanhSach.Columns["PhoneNumber"].HeaderText = "SĐT";
                dgvDanhSach.Columns["JoinDate"].HeaderText = "Ngày Gia Nhập";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                var row = dgvDanhSach.CurrentRow;
                txtMemberId.Text = row.Cells["MemberId"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();

                if (row.Cells["JoinDate"].Value != null)
                    dtpJoinDate.Value = Convert.ToDateTime(row.Cells["JoinDate"].Value);
            }
        }

        // --- CHỨC NĂNG THÊM ---
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên!");
                return;
            }

            try
            {
                var newMember = new Member
                {
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhoneNumber.Text.Trim(),
                    JoinDate = dtpJoinDate.Value
                };

                db.Members.Add(newMember);
                db.SaveChanges();

                LoadData();
                ClearInputs();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }
        }

        // --- CHỨC NĂNG SỬA ---
        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberId.Text)) return;

            try
            {
                int id = int.Parse(txtMemberId.Text);
                var member = db.Members.Find(id);

                if (member != null)
                {
                    member.FullName = txtFullName.Text.Trim();
                    member.Email = txtEmail.Text.Trim();
                    member.PhoneNumber = txtPhoneNumber.Text.Trim();
                    member.JoinDate = dtpJoinDate.Value;

                    db.SaveChanges();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        // --- CHỨC NĂNG XÓA ---
        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberId.Text)) return;

            if (MessageBox.Show("Bạn chắc chắn muốn xóa độc giả này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int id = int.Parse(txtMemberId.Text);
                    var member = db.Members.Find(id);

                    if (member != null)
                    {
                        db.Members.Remove(member);
                        db.SaveChanges();
                        LoadData();
                        ClearInputs();
                        MessageBox.Show("Đã xóa thành công!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa độc giả này (có thể do đang mượn sách).\nLỗi: " + ex.Message);
                }
            }
        }

        // --- TÌM KIẾM ---
        private void BtnTimKiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                LoadData();
                return;
            }

            var result = db.Members.Where(m =>
                m.FullName.Contains(keyword) ||
                m.PhoneNumber.Contains(keyword) ||
                m.Email.Contains(keyword))
                .Select(m => new
                {
                    m.MemberId,
                    m.FullName,
                    m.Email,
                    m.PhoneNumber,
                    m.JoinDate
                }).ToList();

            dgvDanhSach.DataSource = result;
        }

        private void ClearInputs()
        {
            txtMemberId.Clear();
            txtFullName.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            dtpJoinDate.Value = DateTime.Now;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}