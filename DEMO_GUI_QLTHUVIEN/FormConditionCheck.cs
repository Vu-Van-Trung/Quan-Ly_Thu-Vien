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
            chkNormal.Checked = true;
        }

        public FormConditionCheck(string bookName) : this()
        {
            lblMessage.Text = $"Xác nhận trả sách:\n'{bookName}'";
        }

        private void ChkCondition_CheckedChanged(object sender, EventArgs e)
        {
            // Improved algorithm: Mutually exclusive selection (Radio button behavior)
            if (sender is Guna.UI2.WinForms.Guna2CheckBox chk && chk.Checked)
            {
                if (chk == chkNormal)
                {
                    chkHuHong.Checked = false;
                    chkMat.Checked = false;
                }
                else if (chk == chkHuHong)
                {
                    chkNormal.Checked = false;
                    chkMat.Checked = false;
                }
                else if (chk == chkMat)
                {
                    chkNormal.Checked = false;
                    chkHuHong.Checked = false;
                }
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (chkMat.Checked) SelectedCondition = "Mất";
            else if (chkHuHong.Checked) SelectedCondition = "Hư hỏng";
            else if (chkNormal.Checked) SelectedCondition = "Tốt";
            else SelectedCondition = "Tốt"; // Default fallback

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
