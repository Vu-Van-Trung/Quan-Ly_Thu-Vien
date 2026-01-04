using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoAnDemoUI
{
    public partial class FormConditionCheck : Form
    {
        public string SelectedCondition { get; private set; } = "Tốt";

        public FormConditionCheck()
        {
            InitializeComponent();
        }

        public FormConditionCheck(string bookName) : this()
        {
            lblMessage.Text = $"Xác nhận trả sách:\n'{bookName}'";        }

        private void ChkCondition_CheckedChanged(object sender, EventArgs e)
        {
            // Ensure mutually exclusive if needed, or prioritization
            // For now, allow simple toggle. If both checked, priority logic in Confirm.
            if (sender == chkMat && chkMat.Checked) chkHuHong.Checked = false;
            if (sender == chkHuHong && chkHuHong.Checked) chkMat.Checked = false;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (chkMat.Checked) SelectedCondition = "Mất";
            else if (chkHuHong.Checked) SelectedCondition = "Hư hỏng";
            else SelectedCondition = "Tốt";

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
