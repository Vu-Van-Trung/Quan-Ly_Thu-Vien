#nullable disable
using LibraryManagement.Data;
using LibraryManagement.Models;
using LibraryManagement.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DoAnDemoUI
{
    public partial class FormMember : Form
    {
        private LibraryContext db;

        public FormMember()
        {
            InitializeComponent();
            this.Load += FormMember_Load;

            // Đăng ký sự kiện - Đảm bảo các nút này ĐÃ TỒN TẠI trên giao diện
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnTimKiem.Click += BtnTimKiem_Click;
            btnThoat.Click += (s, e) => this.Close();

            // Nếu bạn có nút btnRefresh thì bỏ comment dòng dưới, nếu không hãy xóa nó
            // if (btnRefresh != null) btnRefresh.Click += (s, e) => LoadData();

            dgvDanhSach.SelectionChanged += DgvDanhSach_SelectionChanged;
            txtMemberId.ReadOnly = true;
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
                var rawData = db.Members.ToList();

                var displayData = rawData.Select(m => new
                {
                    m.MemberId,
                    FullName = CryptoHelper.Decrypt(m.FullName),
                    Email = CryptoHelper.Decrypt(m.Email),
                    PhoneNumber = CryptoHelper.Decrypt(m.PhoneNumber),
                    m.JoinDate,
                    m.TrangThai
                }).ToList();

                dgvDanhSach.DataSource = displayData;
                FormatGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private void FormatGrid()
        {
            if (dgvDanhSach.Columns.Count > 0)
            {
                if (dgvDanhSach.Columns["MemberId"] != null) dgvDanhSach.Columns["MemberId"].HeaderText = "Mã Độc Giả";
                if (dgvDanhSach.Columns["FullName"] != null) dgvDanhSach.Columns["FullName"].HeaderText = "Họ Và Tên";
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                var member = new Member
                {
                    MemberId = GenerateMemberId(),
                    FullName = CryptoHelper.Encrypt(txtFullName.Text.Trim()),
                    Email = CryptoHelper.Encrypt(txtEmail.Text.Trim()),
                    PhoneNumber = CryptoHelper.Encrypt(txtPhoneNumber.Text.Trim()),
                    JoinDate = dtpJoinDate.Value,
                    TrangThai = "Hoạt động"
                };

                db.Members.Add(member);
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private string GenerateMemberId()
        {
            if (!db.Members.Any()) return "DG001";
            var lastId = db.Members.OrderByDescending(m => m.MemberId).Select(m => m.MemberId).FirstOrDefault();
            int number = int.Parse(lastId.Substring(2));
            return "DG" + (number + 1).ToString("D3");
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            var member = db.Members.Find(txtMemberId.Text);
            if (member != null)
            {
                member.FullName = CryptoHelper.Encrypt(txtFullName.Text.Trim());
                member.Email = CryptoHelper.Encrypt(txtEmail.Text.Trim());
                member.PhoneNumber = CryptoHelper.Encrypt(txtPhoneNumber.Text.Trim());
                db.SaveChanges();
                LoadData();
                MessageBox.Show("Sửa thành công!");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            var member = db.Members.Find(txtMemberId.Text);
            if (member != null && MessageBox.Show("Xóa?", "Hỏi", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                db.Members.Remove(member);
                db.SaveChanges();
                LoadData();
            }
        }

        private void BtnTimKiem_Click(object? sender, EventArgs e)
        {
            string kw = txtTimKiem.Text.ToLower();
            var data = db.Members.AsEnumerable().Select(m => new {
                m.MemberId,
                FullName = CryptoHelper.Decrypt(m.FullName),
                Email = CryptoHelper.Decrypt(m.Email),
                PhoneNumber = CryptoHelper.Decrypt(m.PhoneNumber),
                m.JoinDate
            }).Where(x => x.FullName.ToLower().Contains(kw)).ToList();
            dgvDanhSach.DataSource = data;
        }

        private void DgvDanhSach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow != null)
            {
                var row = dgvDanhSach.CurrentRow;
                txtMemberId.Text = row.Cells["MemberId"].Value?.ToString();
                txtFullName.Text = row.Cells["FullName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString();
            }
        }

        private void lblTitle_Click(object sender, EventArgs e) { }
        private void dgvDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
    }
}