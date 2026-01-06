using System;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace DoAnDemoUI
{
    public partial class FormWaiver : Form
    {
        public bool IsPercentage { get; private set; }
        public decimal WaiverValue { get; private set; }
        public string Reason { get; private set; }

        // Drag Control
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;

        public FormWaiver()
        {
            InitializeComponent();
            IsPercentage = true;
            radPercent.Checked = true;

            // Initialize Guna Components here for form behavior if not in designer
            borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            borderlessForm.ContainerControl = this;
            borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            borderlessForm.TransparentWhileDrag = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReason.Text))
            {
                MessageBox.Show("Vui lòng nhập lý do miễn giảm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            IsPercentage = radPercent.Checked;
            WaiverValue = numValue.Value;
            Reason = txtReason.Text;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void radPercent_CheckedChanged(object sender, EventArgs e)
        {
            if (radPercent.Checked)
            {
                numValue.Maximum = 100;
                lblUnit.Text = "%";
            }
        }

        private void radAmount_CheckedChanged(object sender, EventArgs e)
        {
            if (radAmount.Checked)
            {
                numValue.Maximum = 1000000000;
                lblUnit.Text = "VNĐ";
            }
        }
    }
}
