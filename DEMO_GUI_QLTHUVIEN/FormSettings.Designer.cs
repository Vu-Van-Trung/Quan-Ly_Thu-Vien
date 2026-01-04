
namespace DoAnDemoUI
{
    partial class FormSettings
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            grpData = new GroupBox();
            btnRestore = new Button();
            btnBackup = new Button();
            lblTitle = new Label();
            btnThoat = new Button();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            grpData.SuspendLayout();
            SuspendLayout();
            // 
            // grpData
            // 
            grpData.Controls.Add(btnRestore);
            grpData.Controls.Add(btnBackup);
            grpData.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpData.ForeColor = Color.FromArgb(33, 150, 243);
            grpData.Location = new Point(264, 223);
            grpData.Margin = new Padding(3, 4, 3, 4);
            grpData.Name = "grpData";
            grpData.Padding = new Padding(3, 4, 3, 4);
            grpData.Size = new Size(729, 188);
            grpData.TabIndex = 0;
            grpData.TabStop = false;
            grpData.Text = "📁 Quản Lý Dữ Liệu";
            // 
            // btnRestore
            // 
            btnRestore.BackColor = Color.FromArgb(244, 67, 54);
            btnRestore.Cursor = Cursors.Hand;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRestore.ForeColor = Color.White;
            btnRestore.Location = new Point(399, 62);
            btnRestore.Margin = new Padding(3, 4, 3, 4);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(200, 62);
            btnRestore.TabIndex = 1;
            btnRestore.Text = "🔄 Phục hồi dữ liệu";
            btnRestore.UseVisualStyleBackColor = false;
            btnRestore.Click += btnRestore_Click;
            // 
            // btnBackup
            // 
            btnBackup.BackColor = Color.FromArgb(76, 175, 80);
            btnBackup.Cursor = Cursors.Hand;
            btnBackup.FlatStyle = FlatStyle.Flat;
            btnBackup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBackup.ForeColor = Color.White;
            btnBackup.Location = new Point(130, 62);
            btnBackup.Margin = new Padding(3, 4, 3, 4);
            btnBackup.Name = "btnBackup";
            btnBackup.Size = new Size(200, 62);
            btnBackup.TabIndex = 0;
            btnBackup.Text = "💾 Sao lưu dữ liệu";
            btnBackup.UseVisualStyleBackColor = false;
            btnBackup.Click += btnBackup_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(33, 150, 243);
            lblTitle.Location = new Point(551, 28);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(187, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "⚙️ CÀI ĐẶT";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = Color.FromArgb(158, 158, 158);
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.FlatStyle = FlatStyle.Flat;
            btnThoat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(542, 437);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(120, 50);
            btnThoat.TabIndex = 2;
            btnThoat.Text = "Đóng";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = SystemColors.ButtonFace;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            guna2Button1.ImageSize = new Size(40, 40);
            guna2Button1.Location = new Point(1254, 12);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.PressedColor = SystemColors.ButtonFace;
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(44, 36);
            guna2Button1.TabIndex = 13;
            guna2Button1.Click += guna2Button1_Click;
            // 
            // FormSettings
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1310, 743);
            Controls.Add(guna2Button1);
            Controls.Add(btnThoat);
            Controls.Add(lblTitle);
            Controls.Add(grpData);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cài đặt";
            grpData.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpData;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnThoat;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
