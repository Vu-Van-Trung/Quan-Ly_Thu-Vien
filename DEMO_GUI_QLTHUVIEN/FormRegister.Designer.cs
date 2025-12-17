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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.label1 = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.loginError = new System.Windows.Forms.Label();
            this.Cancel = new Guna.UI2.WinForms.Guna2Button();
            this.create = new Guna.UI2.WinForms.Guna2Button();
            this.txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNewUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(306, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký Tài Khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.guna2Panel1.Controls.Add(this.loginError);
            this.guna2Panel1.Controls.Add(this.Cancel);
            this.guna2Panel1.Controls.Add(this.create);
            this.guna2Panel1.Controls.Add(this.txtConfirmPassword);
            this.guna2Panel1.Controls.Add(this.txtNewPassword);
            this.guna2Panel1.Controls.Add(this.txtNewUsername);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(546, 154);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(906, 560);
            this.guna2Panel1.TabIndex = 10;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // loginError
            // 
            this.loginError.AutoSize = true;
            this.loginError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginError.ForeColor = System.Drawing.Color.Red;
            this.loginError.Location = new System.Drawing.Point(332, 348);
            this.loginError.Name = "loginError";
            this.loginError.Size = new System.Drawing.Size(270, 20);
            this.loginError.TabIndex = 20;
            this.loginError.Text = "Tên đăng nhập hoặc mật khẩu sai !";
            this.loginError.Visible = false;
            // 
            // Cancel
            // 
            this.Cancel.BorderRadius = 18;
            this.Cancel.FillColor = System.Drawing.Color.Teal;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Location = new System.Drawing.Point(272, 463);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(380, 56);
            this.Cancel.TabIndex = 19;
            this.Cancel.Text = "Trờ Về Đăng Nhập";
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click_1);
            // 
            // create
            // 
            this.create.BorderRadius = 18;
            this.create.FillColor = System.Drawing.Color.Lime;
            this.create.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.create.ForeColor = System.Drawing.Color.White;
            this.create.Location = new System.Drawing.Point(272, 385);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(380, 56);
            this.create.TabIndex = 18;
            this.create.Text = "Đăng Kí Tài Khoản";
            this.create.Click += new System.EventHandler(this.create_Click_1);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderRadius = 18;
            this.txtConfirmPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtConfirmPassword.IconLeft")));
            this.txtConfirmPassword.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtConfirmPassword.Location = new System.Drawing.Point(252, 266);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PlaceholderText = "Nhập lại mật khẩu";
            this.txtConfirmPassword.Size = new System.Drawing.Size(415, 67);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderRadius = 18;
            this.txtNewPassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNewPassword.IconLeft")));
            this.txtNewPassword.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtNewPassword.Location = new System.Drawing.Point(252, 173);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PlaceholderText = "Mật khẩu";
            this.txtNewPassword.Size = new System.Drawing.Size(415, 67);
            this.txtNewPassword.TabIndex = 16;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtNewUsername
            // 
            this.txtNewUsername.BorderRadius = 18;
            this.txtNewUsername.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtNewUsername.IconLeft")));
            this.txtNewUsername.IconLeftOffset = new System.Drawing.Point(15, 0);
            this.txtNewUsername.Location = new System.Drawing.Point(252, 81);
            this.txtNewUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewUsername.Name = "txtNewUsername";
            this.txtNewUsername.PlaceholderText = "Tên đăng nhập";
            this.txtNewUsername.Size = new System.Drawing.Size(415, 67);
            this.txtNewUsername.TabIndex = 15;
            this.txtNewUsername.TextChanged += new System.EventHandler(this.txtNewUsername_TextChanged);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1866, 808);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
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