namespace DoAnDemoUI
{
    partial class FormRegister
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            loginError = new Label();
            Cancel = new Guna.UI2.WinForms.Guna2Button();
            create = new Guna.UI2.WinForms.Guna2Button();
            txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtNewUsername = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold);
            label1.Location = new Point(306, 31);
            label1.Name = "label1";
            label1.Size = new Size(296, 41);
            label1.TabIndex = 0;
            label1.Text = "Đăng Ký Tài Khoản";
            label1.Click += label1_Click;
            // 
            // guna2BorderlessForm1
            // 
            guna2BorderlessForm1.ContainerControl = this;
            guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Gainsboro;
            guna2Panel1.Controls.Add(loginError);
            guna2Panel1.Controls.Add(Cancel);
            guna2Panel1.Controls.Add(create);
            guna2Panel1.Controls.Add(txtConfirmPassword);
            guna2Panel1.Controls.Add(txtNewPassword);
            guna2Panel1.Controls.Add(txtNewUsername);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.CustomizableEdges = customizableEdges11;
            guna2Panel1.Location = new Point(417, 267);
            guna2Panel1.Margin = new Padding(3, 4, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges12;
            guna2Panel1.Size = new Size(906, 700);
            guna2Panel1.TabIndex = 10;
            guna2Panel1.Paint += guna2Panel1_Paint;
            // 
            // loginError
            // 
            loginError.AutoSize = true;
            loginError.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loginError.ForeColor = Color.Red;
            loginError.Location = new Point(332, 435);
            loginError.Name = "loginError";
            loginError.Size = new Size(270, 20);
            loginError.TabIndex = 20;
            loginError.Text = "Tên đăng nhập hoặc mật khẩu sai !";
            loginError.Visible = false;
            // 
            // Cancel
            // 
            Cancel.BorderRadius = 18;
            Cancel.CustomizableEdges = customizableEdges1;
            Cancel.FillColor = Color.Teal;
            Cancel.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            Cancel.ForeColor = Color.White;
            Cancel.Location = new Point(272, 579);
            Cancel.Margin = new Padding(3, 4, 3, 4);
            Cancel.Name = "Cancel";
            Cancel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            Cancel.Size = new Size(380, 70);
            Cancel.TabIndex = 19;
            Cancel.Text = "Trờ Về Đăng Nhập";
            Cancel.Click += Cancel_Click_1;
            // 
            // create
            // 
            create.BorderRadius = 18;
            create.CustomizableEdges = customizableEdges3;
            create.FillColor = Color.Lime;
            create.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            create.ForeColor = Color.White;
            create.Location = new Point(272, 481);
            create.Margin = new Padding(3, 4, 3, 4);
            create.Name = "create";
            create.ShadowDecoration.CustomizableEdges = customizableEdges4;
            create.Size = new Size(380, 70);
            create.TabIndex = 18;
            create.Text = "Đăng Kí Tài Khoản";
            create.Click += create_Click_1;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderRadius = 18;
            txtConfirmPassword.CustomizableEdges = customizableEdges5;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.Font = new Font("Segoe UI", 9F);
            txtConfirmPassword.IconLeft = DEMO_GUI_QLTHUVIEN.Properties.Resources.lock_25px;
            txtConfirmPassword.IconLeftOffset = new Point(15, 0);
            txtConfirmPassword.Location = new Point(252, 332);
            txtConfirmPassword.Margin = new Padding(4, 5, 4, 5);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtConfirmPassword.Size = new Size(415, 84);
            txtConfirmPassword.TabIndex = 17;
            txtConfirmPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtNewPassword
            // 
            txtNewPassword.BorderRadius = 18;
            txtNewPassword.CustomizableEdges = customizableEdges7;
            txtNewPassword.DefaultText = "";
            txtNewPassword.Font = new Font("Segoe UI", 9F);
            txtNewPassword.IconLeft = DEMO_GUI_QLTHUVIEN.Properties.Resources.lock_25px1;
            txtNewPassword.IconLeftOffset = new Point(15, 0);
            txtNewPassword.Location = new Point(252, 216);
            txtNewPassword.Margin = new Padding(4, 5, 4, 5);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PlaceholderText = "Mật khẩu";
            txtNewPassword.SelectedText = "";
            txtNewPassword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtNewPassword.Size = new Size(415, 84);
            txtNewPassword.TabIndex = 16;
            txtNewPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtNewUsername
            // 
            txtNewUsername.BorderRadius = 18;
            txtNewUsername.CustomizableEdges = customizableEdges9;
            txtNewUsername.DefaultText = "";
            txtNewUsername.Font = new Font("Segoe UI", 9F);
            txtNewUsername.IconLeft = DEMO_GUI_QLTHUVIEN.Properties.Resources.user_25px1;
            txtNewUsername.IconLeftOffset = new Point(15, 0);
            txtNewUsername.Location = new Point(252, 101);
            txtNewUsername.Margin = new Padding(4, 5, 4, 5);
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.PlaceholderText = "Tên đăng nhập";
            txtNewUsername.SelectedText = "";
            txtNewUsername.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtNewUsername.Size = new Size(415, 84);
            txtNewUsername.TabIndex = 15;
            txtNewUsername.TextChanged += txtNewUsername_TextChanged;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = DEMO_GUI_QLTHUVIEN.Properties.Resources.background_tet_2_7afa200e8ee54ed7962102f32ffe44aa_1024x10243;
            ClientSize = new Size(1866, 1010);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            WindowState = FormWindowState.Maximized;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtNewUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2Button create;
        private Guna.UI2.WinForms.Guna2Button Cancel;
        private System.Windows.Forms.Label loginError;
    }
}