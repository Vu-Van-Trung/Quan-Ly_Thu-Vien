namespace DoAnDemoUI
{
    partial class FormConditionCheck
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.chkHuHong = new Guna.UI2.WinForms.Guna2CheckBox();
            this.chkMat = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(20, 20);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(340, 50);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Xác nhận trả sách";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkHuHong
            // 
            this.chkHuHong.Location = new System.Drawing.Point(50, 90);
            this.chkHuHong.Name = "chkHuHong";
            this.chkHuHong.Size = new System.Drawing.Size(300, 30);
            this.chkHuHong.TabIndex = 1;
            this.chkHuHong.Text = "Sách bị hư hỏng";
            this.chkHuHong.CheckedChanged += new System.EventHandler(this.ChkCondition_CheckedChanged);
            // 
            // chkMat
            // 
            this.chkMat.Location = new System.Drawing.Point(50, 130);
            this.chkMat.Name = "chkMat";
            this.chkMat.Size = new System.Drawing.Size(300, 30);
            this.chkMat.TabIndex = 2;
            this.chkMat.Text = "Sách bị mất";
            this.chkMat.CheckedChanged += new System.EventHandler(this.ChkCondition_CheckedChanged);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderRadius = 10;
            this.btnConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(125, 170);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(130, 40);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "Xác nhận";
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FormConditionCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.chkMat);
            this.Controls.Add(this.chkHuHong);
            this.Controls.Add(this.lblMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConditionCheck";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kiểm tra tình trạng sách";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2CheckBox chkHuHong;
        private Guna.UI2.WinForms.Guna2CheckBox chkMat;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
    }
}
