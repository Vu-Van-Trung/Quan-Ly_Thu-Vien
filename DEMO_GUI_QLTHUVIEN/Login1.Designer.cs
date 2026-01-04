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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(Login1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            pictureBox2 = new PictureBox();
            guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            btnMinimize = new Guna.UI2.WinForms.Guna2CircleButton();
            btnCancel = new Guna.UI2.WinForms.Guna2CircleButton();
            ((ISupportInitialize)errorProvider1).BeginInit();
            Login.SuspendLayout();
            ((ISupportInitialize)pictureBox2).BeginInit();
            ((ISupportInitialize)guna2PictureBox2).BeginInit();
            ((ISupportInitialize)pictureBox1).BeginInit();
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
            txtPassword.CustomizableEdges = customizableEdges18;
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
            txtPassword.Location = new Point(623, 293);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Mật khẩu";
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges19;
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
            txtUsername.CustomizableEdges = customizableEdges20;
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
            txtUsername.Location = new Point(623, 202);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Tên đăng nhập";
            txtUsername.RightToLeft = RightToLeft.No;
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges21;
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
            lnkForgot.Location = new Point(619, 477);
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
            dktk.Location = new Point(892, 476);
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
            label.ForeColor = Color.Red;
            label.Location = new Point(749, 135);
            label.Name = "label";
            label.Size = new Size(179, 41);
            label.TabIndex = 13;
            label.Text = "Đăng Nhập";
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 18;
            btnLogin.CustomizableEdges = customizableEdges16;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(644, 406);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges17;
            btnLogin.Size = new Size(380, 56);
            btnLogin.TabIndex = 16;
            btnLogin.Text = "Đăng Nhập";
            btnLogin.Click += btnLogin_Click_1;
            // 
            // loginError
            // 
            loginError.AutoSize = true;
            loginError.ForeColor = Color.Red;
            loginError.Location = new Point(701, 372);
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
            label2.Location = new Point(411, 610);
            label2.Name = "label2";
            label2.Size = new Size(447, 22);
            label2.TabIndex = 18;
            label2.Text = "*Bạn sẽ chấp nhận các điều khoản và điều kiện của chúng tôi";
            label2.Click += label2_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.White;
            Login.Controls.Add(pictureBox2);
            Login.Controls.Add(guna2PictureBox2);
            Login.Controls.Add(pictureBox1);
            Login.Controls.Add(label4);
            Login.Controls.Add(label3);
            Login.Controls.Add(label2);
            Login.Controls.Add(loginError);
            Login.Controls.Add(btnLogin);
            Login.Controls.Add(txtPassword);
            Login.Controls.Add(txtUsername);
            Login.Controls.Add(label);
            Login.Controls.Add(dktk);
            Login.Controls.Add(lnkForgot);
            Login.CustomizableEdges = customizableEdges22;
            Login.Location = new Point(141, 103);
            Login.Name = "Login";
            Login.ShadowDecoration.CustomizableEdges = customizableEdges23;
            Login.Size = new Size(1222, 632);
            Login.TabIndex = 11;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.pngegg1;
            pictureBox2.Location = new Point(1043, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(164, 159);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 23;
            pictureBox2.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            guna2PictureBox2.CustomizableEdges = customizableEdges14;
            guna2PictureBox2.ErrorImage = (Image)resources.GetObject("guna2PictureBox2.ErrorImage");
            guna2PictureBox2.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources._174951701726937611;
            guna2PictureBox2.ImageRotate = 0F;
            guna2PictureBox2.InitialImage = DEMO_GUI_QLTHUVIEN.Properties.Resources._174951701726937611;
            guna2PictureBox2.Location = new Point(277, 264);
            guna2PictureBox2.Name = "guna2PictureBox2";
            guna2PictureBox2.ShadowDecoration.CustomizableEdges = customizableEdges15;
            guna2PictureBox2.Size = new Size(226, 198);
            guna2PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            guna2PictureBox2.TabIndex = 22;
            guna2PictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = DEMO_GUI_QLTHUVIEN.Properties.Resources.newyear2;
            pictureBox1.Location = new Point(200, 182);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(387, 340);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(430, 135);
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
            label3.Location = new Point(301, 135);
            label3.Name = "label3";
            label3.Size = new Size(166, 41);
            label3.TabIndex = 19;
            label3.Text = "Thư Viện ";
            // 
            // btnMinimize
            // 
            btnMinimize.BackColor = Color.Transparent;
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
            btnMinimize.ShadowDecoration.CustomizableEdges = customizableEdges13;
            btnMinimize.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnMinimize.Size = new Size(55, 52);
            btnMinimize.TabIndex = 21;
            btnMinimize.Click += guna2CircleButton1_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
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
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnCancel.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            btnCancel.Size = new Size(55, 52);
            btnCancel.TabIndex = 10;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // Login1
            // 
            BackgroundImage = DEMO_GUI_QLTHUVIEN.Properties.Resources.background_tet_2_7afa200e8ee54ed7962102f32ffe44aa_1024x1024;
            ClientSize = new Size(1866, 808);
            Controls.Add(btnMinimize);
            Controls.Add(Login);
            Controls.Add(btnCancel);
            DoubleBuffered = true;
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
            ((ISupportInitialize)pictureBox2).EndInit();
            ((ISupportInitialize)guna2PictureBox2).EndInit();
            ((ISupportInitialize)pictureBox1).EndInit();
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
        private Guna.UI2.WinForms.Guna2CircleButton btnCancel;
        private Label dktk;
        private LinkLabel lnkForgot;
        private Label label4;
        private Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton btnMinimize;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private PictureBox pictureBox2;
    }
}