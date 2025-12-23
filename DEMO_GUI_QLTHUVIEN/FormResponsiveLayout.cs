#nullable disable
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    public partial class FormStaff
    {
        private bool _responsiveConfigured;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (_responsiveConfigured) return;
            ConfigureResponsiveLayout();
            _responsiveConfigured = true;
        }

        private void ConfigureResponsiveLayout()
        {
            MinimumSize = new Size(1100, 700);
            WindowState = FormWindowState.Maximized;

            if (dgvStaff != null)
            {
                dgvStaff.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }

            if (grpPersonal != null)
            {
                grpPersonal.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            if (grpWork != null)
            {
                grpWork.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            }

            if (btnAdd != null)
            {
                foreach (var button in new[] { btnAdd, btnEdit, btnDelete, btnSave, btnCancel, btnRefresh })
                {
                    if (button != null)
                    {
                        button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                    }
                }
            }
        }
    }

    public partial class FormReport
    {
        private bool _reportLayoutConfigured;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (_reportLayoutConfigured) return;
            ApplyReportLayout();
            _reportLayoutConfigured = true;
        }

        private void ApplyReportLayout()
        {
            MinimumSize = new Size(900, 600);
            WindowState = FormWindowState.Maximized;

            if (tabControl != null)
            {
                tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }

            if (dgvReport != null)
            {
                dgvReport.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            }

            if (btnGenerate != null)
            {
                btnGenerate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            }

            if (btnExport != null)
            {
                btnExport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            }

            if (dtpFrom != null)
            {
                dtpFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            if (dtpTo != null)
            {
                dtpTo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            if (lblFrom != null)
            {
                lblFrom.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            if (lblTo != null)
            {
                lblTo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            }

            if (lblTotal != null)
            {
                lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            }
        }
    }

    public partial class FormFine
    {
        private bool _fineLayoutConfigured;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (_fineLayoutConfigured) return;
            ApplyFineLayout();
            _fineLayoutConfigured = true;
        }

        private void ApplyFineLayout()
        {
            MinimumSize = new Size(1100, 720);
            WindowState = FormWindowState.Maximized;

            if (grpSearch != null)
            {
                grpSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }

            if (grpDetails != null)
            {
                grpDetails.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                foreach (var button in new[] { btnReturn, btnCalculateFine })
                {
                    if (button != null)
                    {
                        button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                    }
                }

                if (dgvBooks != null)
                {
                    dgvBooks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }
            }

            if (grpFines != null)
            {
                grpFines.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                if (dgvFines != null)
                {
                    dgvFines.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                }

                if (lblTotalFine != null)
                {
                    lblTotalFine.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                }

                foreach (var button in new[] { btnPay, btnWaiver })
                {
                    if (button != null)
                    {
                        button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
                    }
                }
            }

            if (btnReset != null)
            {
                btnReset.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            }

            if (btnPrint != null)
            {
                btnPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            }
        }
    }

    public partial class FormPublisher
    {
        private bool _publisherLayoutConfigured;

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (_publisherLayoutConfigured) return;
            ApplyPublisherLayout();
            _publisherLayoutConfigured = true;
        }

        private void ApplyPublisherLayout()
        {
            MinimumSize = new Size(1100, 720);
            WindowState = FormWindowState.Maximized;

            if (dgvPublishers != null)
            {
                dgvPublishers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }

            if (grpInfo != null)
            {
                grpInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }

            if (btnAdd != null)
            {
                foreach (var button in new[] { btnAdd, btnEdit, btnDelete, btnSave, btnCancel, btnRefresh })
                {
                    if (button != null)
                    {
                        button.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                    }
                }
            }
        }
    }
}
