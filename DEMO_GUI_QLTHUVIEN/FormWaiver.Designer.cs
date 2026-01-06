namespace DoAnDemoUI
{
    partial class FormWaiver
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.radPercent = new Guna.UI2.WinForms.Guna2RadioButton();
            this.radAmount = new Guna.UI2.WinForms.Guna2RadioButton();
            this.numValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtReason = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblReason = new System.Windows.Forms.Label();
            this.btnOk = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            // dragControl handled in constructor code-behind or here
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).BeginInit();
            this.SuspendLayout();

            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this;

            // 
            // radPercent
            // 
            this.radPercent.AutoSize = true;
            this.radPercent.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radPercent.CheckedState.BorderThickness = 0;
            this.radPercent.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radPercent.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radPercent.CheckedState.InnerOffset = -4;
            this.radPercent.Location = new System.Drawing.Point(30, 30);
            this.radPercent.Name = "radPercent";
            this.radPercent.Size = new System.Drawing.Size(147, 24);
            this.radPercent.TabIndex = 0;
            this.radPercent.TabStop = true;
            this.radPercent.Text = "Theo phần trăm (%)";
            this.radPercent.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radPercent.UncheckedState.BorderThickness = 2;
            this.radPercent.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radPercent.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radPercent.CheckedChanged += new System.EventHandler(this.radPercent_CheckedChanged);

            // 
            // radAmount
            // 
            this.radAmount.AutoSize = true;
            this.radAmount.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radAmount.CheckedState.BorderThickness = 0;
            this.radAmount.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radAmount.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radAmount.CheckedState.InnerOffset = -4;
            this.radAmount.Location = new System.Drawing.Point(200, 30);
            this.radAmount.Name = "radAmount";
            this.radAmount.Size = new System.Drawing.Size(161, 24);
            this.radAmount.TabIndex = 1;
            this.radAmount.TabStop = true;
            this.radAmount.Text = "Theo số tiền (VNĐ)";
            this.radAmount.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radAmount.UncheckedState.BorderThickness = 2;
            this.radAmount.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radAmount.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radAmount.CheckedChanged += new System.EventHandler(this.radAmount_CheckedChanged);

            // 
            // numValue
            // 
            this.numValue.BackColor = System.Drawing.Color.Transparent;
            this.numValue.BorderRadius = 10;
            this.numValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numValue.Location = new System.Drawing.Point(30, 70);
            this.numValue.Name = "numValue";
            this.numValue.Size = new System.Drawing.Size(200, 36);
            this.numValue.TabIndex = 2;
            this.numValue.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(224)))), ((int)(((byte)(200)))));

            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblUnit.Location = new System.Drawing.Point(240, 75);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(29, 28);
            this.lblUnit.TabIndex = 3;
            this.lblUnit.Text = "%";

            // 
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Location = new System.Drawing.Point(30, 115);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(117, 20);
            this.lblReason.TabIndex = 5;
            this.lblReason.Text = "Lý do miễn giảm:";

            // 
            // txtReason
            // 
            this.txtReason.BorderRadius = 10;
            this.txtReason.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReason.DefaultText = "";
            this.txtReason.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReason.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReason.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReason.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtReason.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReason.Location = new System.Drawing.Point(30, 140);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.PasswordChar = '\0';
            this.txtReason.PlaceholderText = "Nhập lý do...";
            this.txtReason.SelectedText = "";
            this.txtReason.Size = new System.Drawing.Size(340, 60);
            this.txtReason.TabIndex = 4;

            // 
            // btnOk
            // 
            this.btnOk.BorderRadius = 18;
            this.btnOk.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOk.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnOk.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(170, 220);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 36);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "XÁC NHẬN";
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 18;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(280, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "HỦY";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // FormWaiver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.numValue);
            this.Controls.Add(this.radAmount);
            this.Controls.Add(this.radPercent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormWaiver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Miễn giảm tiền phạt";
            ((System.ComponentModel.ISupportInitialize)(this.numValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Guna.UI2.WinForms.Guna2RadioButton radPercent;
        private Guna.UI2.WinForms.Guna2RadioButton radAmount;
        private Guna.UI2.WinForms.Guna2NumericUpDown numValue;
        private System.Windows.Forms.Label lblUnit;
        private Guna.UI2.WinForms.Guna2TextBox txtReason;
        private System.Windows.Forms.Label lblReason;
        private Guna.UI2.WinForms.Guna2GradientButton btnOk;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
    }
}
