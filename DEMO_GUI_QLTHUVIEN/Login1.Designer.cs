#nullable disable
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnDemoUI
{
    partial class Login1
    {
        private IContainer components = null;
        private ErrorProvider errorProvider1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            components = new Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Login1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            errorProvider1 = new ErrorProvider(components);
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            lnkForgot = new LinkLabel();
            dktk = new Label();
            label = new Label();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            loginError = new Label();
            label2 = new Label();
            Login = new Guna.UI2.WinForms.Guna2Panel();
            label4 = new Label();
            label3 = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            ((ISupportInitialize)errorProvider1).BeginInit();
            Login.SuspendLayout();
            ((ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 18;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.CustomizableEdges = customizableEdges4;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.Black;
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            errorProvider1.SetIconAlignment(txtPassword, ErrorIconAlignment.TopRight);
            txtPassword.IconLeft = DEMO_GUI_QLTHUVIEN.Properties.Resources.lock_25px;
            txtPassword.IconLeftOffset = new Point(15, 0);
            txtPassword.IconLeftSize = new Size(30, 30);
            txtPassword.Location = new Point(634, 261);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges5;
            txtPassword.Size = new Size(415, 67);
            txtPassword.TabIndex = 15;
            txtPassword.TextOffset = new Point(30, 0);
            txtPassword.TextChanged += guna2TextBox2_TextChanged;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // txtUsername
            // 
            txtUsername.BorderRadius = 18;
            txtUsername.Cursor = Cursors.WaitCursor;
            txtUsername.CustomizableEdges = customizableEdges6;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 10.8F);
            txtUsername.ForeColor = Color.Black;
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            errorProvider1.SetIconAlignment(txtUsername, ErrorIconAlignment.MiddleLeft);
            txtUsername.IconLeft = DEMO_GUI_QLTHUVIEN.Properties.Resources.user_25px;
            txtUsername.IconLeftOffset = new Point(15, 0);
            txtUsername.IconLeftSize = new Size(30, 30);
            txtUsername.Location = new Point(634, 170);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtUsername.Size = new Size(415, 67);
            txtUsername.TabIndex = 14;
            txtUsername.TextOffset = new Point(30, 0);
            txtUsername.UseWaitCursor = true;
            txtUsername.TextChanged += guna2TextBox1_TextChanged;
            // 
            // lnkForgot
            // 
            lnkForgot.AutoSize = true;
            lnkForgot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkForgot.Location = new Point(630, 445);
            lnkForgot.Name = "lnkForgot";
            lnkForgot.Size = new Size(142, 25);
            lnkForgot.TabIndex = 6;
            lnkForgot.TabStop = true;
            lnkForgot.Text = "Quên mật khẩu?";
            lnkForgot.LinkClicked += lnkForgot_LinkClicked;
            // 
            // dktk
            // 
            dktk.AutoSize = true;
            dktk.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dktk.ForeColor = Color.Blue;
            dktk.Location = new Point(903, 444);
            dktk.Name = "dktk";
            dktk.Size = new Size(158, 25);
            dktk.TabIndex = 9;
            dktk.Text = "Đăng Ký Tài Khoản";
            dktk.Click += dktk_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label.Location = new Point(760, 103);
            label.Name = "label";
            label.Size = new Size(179, 41);
            label.TabIndex = 13;
            label.Text = "Đăng Nhập";
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 18;
            btnLogin.CustomizableEdges = customizableEdges2;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(655, 374);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnLogin.Size = new Size(380, 56);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.Click += btnLogin_Click_1;
            // 
            // loginError
            // 
            loginError.AutoSize = true;
            loginError.ForeColor = Color.Red;
            loginError.Location = new Point(712, 340);
            loginError.Name = "loginError";
            loginError.Size = new Size(238, 20);
            loginError.TabIndex = 17;
            loginError.Text = "Tên đăng nhập hoặc mật khẩu sai !";
            loginError.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri Light", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumTurquoise;
            label2.Location = new Point(374, 607);
            label2.Name = "label2";
            label2.Size = new Size(447, 22);
            label2.TabIndex = 18;
            label2.Text = "*Bạn sẽ chấp nhận các điều khoản và điều kiện của chúng tôi";
            // 
            // Login
            // 
            Login.BackColor = Color.White;
            Login.Controls.Add(label4);
            Login.Controls.Add(label3);
            Login.Controls.Add(label2);
            Login.Controls.Add(loginError);
            Login.Controls.Add(btnLogin);
            Login.Controls.Add(txtPassword);
            Login.Controls.Add(txtUsername);
            Login.Controls.Add(label);
            Login.Controls.Add(guna2PictureBox1);
            Login.Controls.Add(dktk);
            Login.Controls.Add(lnkForgot);
            Login.CustomizableEdges = customizableEdges10;
            Login.Location = new Point(142, 68);
            Login.Name = "Login";
            Login.ShadowDecoration.CustomizableEdges = customizableEdges11;
            Login.Size = new Size(1221, 667);
            Login.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(385, 126);
            label4.Name = "label4";
            label4.Size = new Size(73, 41);
            label4.TabIndex = 20;
            label4.Text = "Tết";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Magenta;
            label3.Location = new Point(266, 126);
            label3.Name = "label3";
            label3.Size = new Size(166, 41);
            label3.TabIndex = 19;
            label3.Text = "Thư Viện ";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges8;
            guna2PictureBox1.ErrorImage = (Image)resources.GetObject("guna2PictureBox1.ErrorImage");
            guna2PictureBox1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources._174951701726937611;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.InitialImage = DEMO_GUI_QLTHUVIEN.Properties.Resources._174951701726937611;
            guna2PictureBox1.Location = new Point(173, 170);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2PictureBox1.Size = new Size(330, 295);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox1.TabIndex = 11;
            guna2PictureBox1.TabStop = false;
            // 
            // btnMinimize
            // 
            btnMinimize.DisabledState.BorderColor = Color.DarkGray;
            btnMinimize.DisabledState.CustomBorderColor = Color.DarkGray;
            btnMinimize.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnMinimize.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnMinimize.FillColor = Color.White;
            btnMinimize.Font = new Font("Segoe UI", 9F);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources._786263;
            btnMinimize.ImageSize = new Size(50, 50);
            btnMinimize.Location = new Point(1396, 14);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMinimize.Size = new Size(55, 52);
            btnMinimize.TabIndex = 21;
            btnMinimize.Click += guna2CircleButton1_Click;
            // 
            // btnCancel
            // 
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.White;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.cancel_50px;
            btnCancel.ImageSize = new Size(60, 60);
            btnCancel.Location = new Point(1468, 14);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCancel.Size = new Size(55, 52);
            btnCancel.TabIndex = 10;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // Login1
            // 
            ClientSize = new Size(1866, 808);
            Controls.Add(btnMinimize);
            Controls.Add(Login);
            Controls.Add(btnCancel);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login1";
            Padding = new Padding(20);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập - Thư Viện Tết";
            WindowState = FormWindowState.Maximized;
            Load += Login_Load;
            ((ISupportInitialize)errorProvider1).EndInit();
            Login.ResumeLayout(false);
            Login.PerformLayout();
            ((ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Login;
        private Label label2;
        private Label loginError;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Label label;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
        private Label dktk;
        private LinkLabel lnkForgot;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
    }
}