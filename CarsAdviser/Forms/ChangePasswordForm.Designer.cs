
namespace CarsAdviser.Forms
{
    partial class ChangePasswordForm
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
            this.changePasswordLabel = new System.Windows.Forms.Label();
            this.codeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.changePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mandatoryFillingLabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // changePasswordLabel
            // 
            this.changePasswordLabel.AutoSize = true;
            this.changePasswordLabel.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordLabel.Location = new System.Drawing.Point(282, 63);
            this.changePasswordLabel.Name = "changePasswordLabel";
            this.changePasswordLabel.Size = new System.Drawing.Size(180, 33);
            this.changePasswordLabel.TabIndex = 15;
            this.changePasswordLabel.Text = "Смена пароля";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Animated = true;
            this.codeTextBox.BorderRadius = 10;
            this.codeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.codeTextBox.DefaultText = "";
            this.codeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.codeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.codeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.codeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.codeTextBox.ForeColor = System.Drawing.Color.Black;
            this.codeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.codeTextBox.IconRight = global::CarsAdviser.Properties.Resources.sendcode;
            this.codeTextBox.IconRightSize = new System.Drawing.Size(32, 32);
            this.codeTextBox.Location = new System.Drawing.Point(288, 185);
            this.codeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.PasswordChar = '\0';
            this.codeTextBox.PlaceholderText = "Код подтверждения";
            this.codeTextBox.SelectedText = "";
            this.codeTextBox.Size = new System.Drawing.Size(311, 36);
            this.codeTextBox.TabIndex = 17;
            this.codeTextBox.IconRightClick += new System.EventHandler(this.codeTextBox_IconRightClick);
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Animated = true;
            this.changePasswordBtn.BorderRadius = 15;
            this.changePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.changePasswordBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.White;
            this.changePasswordBtn.Location = new System.Drawing.Point(288, 269);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(311, 45);
            this.changePasswordBtn.TabIndex = 22;
            this.changePasswordBtn.Text = "Сменить пароль";
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Animated = true;
            this.passwordTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordTextBox.BorderRadius = 10;
            this.passwordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTextBox.DefaultText = "";
            this.passwordTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.IconRight = global::CarsAdviser.Properties.Resources.showpass;
            this.passwordTextBox.IconRightSize = new System.Drawing.Size(32, 32);
            this.passwordTextBox.Location = new System.Drawing.Point(288, 116);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Новый пароль";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(311, 38);
            this.passwordTextBox.TabIndex = 28;
            this.passwordTextBox.IconRightClick += new System.EventHandler(this.passwordTextBox_IconRightClick);
            // 
            // mandatoryFillingLabel1
            // 
            this.mandatoryFillingLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel1.AutoSize = true;
            this.mandatoryFillingLabel1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel1.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel1.Location = new System.Drawing.Point(620, 125);
            this.mandatoryFillingLabel1.Name = "mandatoryFillingLabel1";
            this.mandatoryFillingLabel1.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel1.TabIndex = 33;
            this.mandatoryFillingLabel1.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel1.Visible = false;
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 985);
            this.Controls.Add(this.mandatoryFillingLabel1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.changePasswordBtn);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.changePasswordLabel);
            this.Name = "ChangePasswordForm";
            this.Text = "ChangePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label changePasswordLabel;
        private Guna.UI2.WinForms.Guna2TextBox codeTextBox;
        private Guna.UI2.WinForms.Guna2Button changePasswordBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private System.Windows.Forms.Label mandatoryFillingLabel1;
    }
}