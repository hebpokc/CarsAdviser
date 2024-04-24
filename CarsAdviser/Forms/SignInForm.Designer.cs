
using System.Windows.Forms;

namespace CarsAdviser.Forms
{
    partial class SignInForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            this.signInBtn = new Guna.UI2.WinForms.Guna2Button();
            this.loginTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.createAccountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.signInLabel2 = new System.Windows.Forms.Label();
            this.signInLabel1 = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel1 = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel2 = new System.Windows.Forms.Label();
            this.uncorrectDataTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.showPassImageBtn = new Guna.UI2.WinForms.Guna2ImageButton();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            this.signInBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInBtn.Animated = true;
            this.signInBtn.BorderRadius = 10;
            this.signInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.signInBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Location = new System.Drawing.Point(419, 327);
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.Size = new System.Drawing.Size(288, 45);
            this.signInBtn.TabIndex = 19;
            this.signInBtn.Text = "Войти";
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTextBox.Animated = true;
            this.loginTextBox.BackColor = System.Drawing.Color.Transparent;
            this.loginTextBox.BorderRadius = 10;
            this.loginTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginTextBox.DefaultText = "";
            this.loginTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Location = new System.Drawing.Point(419, 195);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "E-mail или телефон";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.Size = new System.Drawing.Size(288, 38);
            this.loginTextBox.TabIndex = 17;
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountBtn.Animated = true;
            this.createAccountBtn.BackColor = System.Drawing.Color.Transparent;
            this.createAccountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAccountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAccountBtn.FillColor = System.Drawing.Color.Transparent;
            this.createAccountBtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.createAccountBtn.Location = new System.Drawing.Point(445, 159);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(136, 19);
            this.createAccountBtn.TabIndex = 16;
            this.createAccountBtn.Text = "создать  аккаунт";
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // signInLabel2
            // 
            this.signInLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInLabel2.AutoSize = true;
            this.signInLabel2.BackColor = System.Drawing.Color.Transparent;
            this.signInLabel2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInLabel2.Location = new System.Drawing.Point(416, 160);
            this.signInLabel2.Name = "signInLabel2";
            this.signInLabel2.Size = new System.Drawing.Size(32, 18);
            this.signInLabel2.TabIndex = 15;
            this.signInLabel2.Text = "или";
            // 
            // signInLabel1
            // 
            this.signInLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInLabel1.AutoSize = true;
            this.signInLabel1.BackColor = System.Drawing.Color.Transparent;
            this.signInLabel1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInLabel1.Location = new System.Drawing.Point(415, 128);
            this.signInLabel1.Name = "signInLabel1";
            this.signInLabel1.Size = new System.Drawing.Size(61, 23);
            this.signInLabel1.TabIndex = 14;
            this.signInLabel1.Text = "Войти";
            // 
            // mandatoryFillingLabel1
            // 
            this.mandatoryFillingLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel1.AutoSize = true;
            this.mandatoryFillingLabel1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel1.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel1.Location = new System.Drawing.Point(730, 205);
            this.mandatoryFillingLabel1.Name = "mandatoryFillingLabel1";
            this.mandatoryFillingLabel1.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel1.TabIndex = 21;
            this.mandatoryFillingLabel1.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel1.Visible = false;
            // 
            // mandatoryFillingLabel2
            // 
            this.mandatoryFillingLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel2.AutoSize = true;
            this.mandatoryFillingLabel2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel2.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel2.Location = new System.Drawing.Point(730, 263);
            this.mandatoryFillingLabel2.Name = "mandatoryFillingLabel2";
            this.mandatoryFillingLabel2.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel2.TabIndex = 22;
            this.mandatoryFillingLabel2.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel2.Visible = false;
            // 
            // uncorrectDataTextBox
            // 
            this.uncorrectDataTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.uncorrectDataTextBox.BackColor = System.Drawing.Color.Transparent;
            this.uncorrectDataTextBox.BorderColor = System.Drawing.Color.Red;
            this.uncorrectDataTextBox.BorderRadius = 5;
            this.uncorrectDataTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uncorrectDataTextBox.DefaultText = "Вход не удался\r\n\r\nНеправильный логин или пароль\r\n\r\n";
            this.uncorrectDataTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.uncorrectDataTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.uncorrectDataTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uncorrectDataTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uncorrectDataTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.uncorrectDataTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uncorrectDataTextBox.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.uncorrectDataTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.uncorrectDataTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uncorrectDataTextBox.Location = new System.Drawing.Point(419, 401);
            this.uncorrectDataTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uncorrectDataTextBox.Multiline = true;
            this.uncorrectDataTextBox.Name = "uncorrectDataTextBox";
            this.uncorrectDataTextBox.PasswordChar = '\0';
            this.uncorrectDataTextBox.PlaceholderText = "";
            this.uncorrectDataTextBox.ReadOnly = true;
            this.uncorrectDataTextBox.SelectedText = "";
            this.uncorrectDataTextBox.Size = new System.Drawing.Size(288, 70);
            this.uncorrectDataTextBox.TabIndex = 23;
            this.uncorrectDataTextBox.Visible = false;
            this.uncorrectDataTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uncorrectDataTextBox_KeyDown);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.passwordTextBox.Location = new System.Drawing.Point(419, 253);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Пароль";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(288, 38);
            this.passwordTextBox.TabIndex = 18;
            this.passwordTextBox.IconRightClick += new System.EventHandler(this.passwordTextBox_IconRightClick);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // showPassImageBtn
            // 
            this.showPassImageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.showPassImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPassImageBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.showPassImageBtn.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.showPassImageBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPassImageBtn.Image")));
            this.showPassImageBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.showPassImageBtn.ImageRotate = 0F;
            this.showPassImageBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.showPassImageBtn.Location = new System.Drawing.Point(713, 259);
            this.showPassImageBtn.Name = "showPassImageBtn";
            this.showPassImageBtn.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.showPassImageBtn.Size = new System.Drawing.Size(32, 32);
            this.showPassImageBtn.TabIndex = 20;
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 643);
            this.Controls.Add(this.uncorrectDataTextBox);
            this.Controls.Add(this.mandatoryFillingLabel2);
            this.Controls.Add(this.mandatoryFillingLabel1);
            this.Controls.Add(this.signInBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.signInLabel2);
            this.Controls.Add(this.signInLabel1);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button signInBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox loginTextBox;
        private Guna.UI2.WinForms.Guna2Button createAccountBtn;
        private System.Windows.Forms.Label signInLabel2;
        private System.Windows.Forms.Label signInLabel1;
        private Guna.UI2.WinForms.Guna2ImageButton showPassImageBtn;
        private System.Windows.Forms.Label mandatoryFillingLabel1;
        private System.Windows.Forms.Label mandatoryFillingLabel2;
        private Guna.UI2.WinForms.Guna2TextBox uncorrectDataTextBox;
    }
}