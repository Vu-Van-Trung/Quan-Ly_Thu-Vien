using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoAnDemoUI
{
    public partial class FormConditionCheck : Form
    {
        private Guna2CheckBox chkHuHong;
        private Guna2CheckBox chkMat;
        private Guna2Button btnConfirm;
        private Label lblMessage;

        public string SelectedCondition { get; private set; } = "Tốt";

        public FormConditionCheck(string bookName)
        {
            InitializeComponent(bookName);
        }

        private void InitializeComponent(string bookName)
        {
            this.Size = new Size(400, 250);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Text = "Kiểm tra tình trạng sách";
            this.BackColor = Color.White;

            lblMessage = new Label();
            lblMessage.Text = $"Xác nhận trả sách:\n'{bookName}'";
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            lblMessage.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblMessage.Location = new Point(20, 20);
            lblMessage.Size = new Size(340, 50);
            this.Controls.Add(lblMessage);

            chkHuHong = new Guna2CheckBox();
            chkHuHong.Text = "Sách bị hư hỏng";
            chkHuHong.Location = new Point(50, 90);
            chkHuHong.Size = new Size(300, 30);
            chkHuHong.CheckedChanged += ChkCondition_CheckedChanged;
            this.Controls.Add(chkHuHong);

            chkMat = new Guna2CheckBox();
            chkMat.Text = "Sách bị mất";
            chkMat.Location = new Point(50, 130);
            chkMat.Size = new Size(300, 30);
            chkMat.CheckedChanged += ChkCondition_CheckedChanged;
            this.Controls.Add(chkMat);

            btnConfirm = new Guna2Button();
            btnConfirm.Text = "Xác nhận";
            btnConfirm.Location = new Point(125, 170);
            btnConfirm.Size = new Size(130, 40);
            btnConfirm.BorderRadius = 10;
            btnConfirm.Click += BtnConfirm_Click;
            this.Controls.Add(btnConfirm);
        }

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
