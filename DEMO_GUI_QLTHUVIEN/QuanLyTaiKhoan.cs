using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DEMO_GUI_QLTHUVIEN
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // TODO: Load data
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Handle cell click
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // TODO: Add new account
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // TODO: Update account
        }

        private void btnKhoa_Click(object sender, EventArgs e)
        {
            // TODO: Lock account
        }

        private void btnMoKhoa_Click(object sender, EventArgs e)
        {
            // TODO: Unlock account
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            // TODO: Change password
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
