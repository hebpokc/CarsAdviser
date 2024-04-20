
namespace CarsAdviser.Forms
{
    partial class RegisterForm
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
            this.mandatoryFillingLabel5 = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel1 = new System.Windows.Forms.Label();
            this.createAccountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.passwordTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.signInAccountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.createAccountLabel2 = new System.Windows.Forms.Label();
            this.createAccountLabel1 = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel2 = new System.Windows.Forms.Label();
            this.surnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mandatoryFillingLabel3 = new System.Windows.Forms.Label();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.mandatoryFillingLabel4 = new System.Windows.Forms.Label();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // mandatoryFillingLabel5
            // 
            this.mandatoryFillingLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel5.AutoSize = true;
            this.mandatoryFillingLabel5.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel5.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel5.Location = new System.Drawing.Point(731, 404);
            this.mandatoryFillingLabel5.Name = "mandatoryFillingLabel5";
            this.mandatoryFillingLabel5.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel5.TabIndex = 31;
            this.mandatoryFillingLabel5.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel5.Visible = false;
            // 
            // mandatoryFillingLabel1
            // 
            this.mandatoryFillingLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel1.AutoSize = true;
            this.mandatoryFillingLabel1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel1.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel1.Location = new System.Drawing.Point(731, 151);
            this.mandatoryFillingLabel1.Name = "mandatoryFillingLabel1";
            this.mandatoryFillingLabel1.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel1.TabIndex = 30;
            this.mandatoryFillingLabel1.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel1.Visible = false;
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountBtn.Animated = true;
            this.createAccountBtn.BorderRadius = 10;
            this.createAccountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAccountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAccountBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.createAccountBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Location = new System.Drawing.Point(420, 462);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(288, 45);
            this.createAccountBtn.TabIndex = 28;
            this.createAccountBtn.Text = "Создать аккаунт";
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
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
            this.passwordTextBox.Location = new System.Drawing.Point(420, 395);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Пароль";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.Size = new System.Drawing.Size(288, 38);
            this.passwordTextBox.TabIndex = 27;
            this.passwordTextBox.IconRightClick += new System.EventHandler(this.passwordTextBox_IconRightClick);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameTextBox.Animated = true;
            this.nameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nameTextBox.BorderRadius = 10;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(420, 141);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Имя";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(288, 38);
            this.nameTextBox.TabIndex = 26;
            // 
            // signInAccountBtn
            // 
            this.signInAccountBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInAccountBtn.Animated = true;
            this.signInAccountBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInAccountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInAccountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInAccountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInAccountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInAccountBtn.FillColor = System.Drawing.Color.Transparent;
            this.signInAccountBtn.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.signInAccountBtn.Location = new System.Drawing.Point(446, 106);
            this.signInAccountBtn.Name = "signInAccountBtn";
            this.signInAccountBtn.Size = new System.Drawing.Size(180, 18);
            this.signInAccountBtn.TabIndex = 25;
            this.signInAccountBtn.Text = "войти в существующий";
            this.signInAccountBtn.Click += new System.EventHandler(this.signInAccountBtn_Click);
            // 
            // createAccountLabel2
            // 
            this.createAccountLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountLabel2.AutoSize = true;
            this.createAccountLabel2.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLabel2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountLabel2.Location = new System.Drawing.Point(417, 106);
            this.createAccountLabel2.Name = "createAccountLabel2";
            this.createAccountLabel2.Size = new System.Drawing.Size(32, 18);
            this.createAccountLabel2.TabIndex = 24;
            this.createAccountLabel2.Text = "или";
            // 
            // createAccountLabel1
            // 
            this.createAccountLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountLabel1.AutoSize = true;
            this.createAccountLabel1.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLabel1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createAccountLabel1.Location = new System.Drawing.Point(416, 74);
            this.createAccountLabel1.Name = "createAccountLabel1";
            this.createAccountLabel1.Size = new System.Drawing.Size(147, 23);
            this.createAccountLabel1.TabIndex = 23;
            this.createAccountLabel1.Text = "Создать аккаунт";
            // 
            // mandatoryFillingLabel2
            // 
            this.mandatoryFillingLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel2.AutoSize = true;
            this.mandatoryFillingLabel2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel2.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel2.Location = new System.Drawing.Point(731, 212);
            this.mandatoryFillingLabel2.Name = "mandatoryFillingLabel2";
            this.mandatoryFillingLabel2.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel2.TabIndex = 33;
            this.mandatoryFillingLabel2.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel2.Visible = false;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.surnameTextBox.Animated = true;
            this.surnameTextBox.BackColor = System.Drawing.Color.Transparent;
            this.surnameTextBox.BorderRadius = 10;
            this.surnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTextBox.DefaultText = "";
            this.surnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Location = new System.Drawing.Point(420, 202);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PlaceholderText = "Фамилия";
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(288, 38);
            this.surnameTextBox.TabIndex = 32;
            // 
            // mandatoryFillingLabel3
            // 
            this.mandatoryFillingLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel3.AutoSize = true;
            this.mandatoryFillingLabel3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel3.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel3.Location = new System.Drawing.Point(731, 274);
            this.mandatoryFillingLabel3.Name = "mandatoryFillingLabel3";
            this.mandatoryFillingLabel3.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel3.TabIndex = 35;
            this.mandatoryFillingLabel3.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel3.Visible = false;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailTextBox.Animated = true;
            this.emailTextBox.BackColor = System.Drawing.Color.Transparent;
            this.emailTextBox.BorderRadius = 10;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Location = new System.Drawing.Point(420, 264);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(288, 38);
            this.emailTextBox.TabIndex = 34;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // mandatoryFillingLabel4
            // 
            this.mandatoryFillingLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel4.AutoSize = true;
            this.mandatoryFillingLabel4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel4.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel4.Location = new System.Drawing.Point(731, 340);
            this.mandatoryFillingLabel4.Name = "mandatoryFillingLabel4";
            this.mandatoryFillingLabel4.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel4.TabIndex = 37;
            this.mandatoryFillingLabel4.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel4.Visible = false;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneTextBox.Animated = true;
            this.phoneTextBox.BackColor = System.Drawing.Color.Transparent;
            this.phoneTextBox.BorderRadius = 10;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.DefaultText = "";
            this.phoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.Location = new System.Drawing.Point(420, 330);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "Телефон";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(288, 38);
            this.phoneTextBox.TabIndex = 36;
            this.phoneTextBox.Leave += new System.EventHandler(this.phoneTextBox_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 643);
            this.Controls.Add(this.mandatoryFillingLabel4);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.mandatoryFillingLabel3);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.mandatoryFillingLabel2);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.mandatoryFillingLabel5);
            this.Controls.Add(this.mandatoryFillingLabel1);
            this.Controls.Add(this.createAccountBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.signInAccountBtn);
            this.Controls.Add(this.createAccountLabel2);
            this.Controls.Add(this.createAccountLabel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mandatoryFillingLabel5;
        private System.Windows.Forms.Label mandatoryFillingLabel1;
        private Guna.UI2.WinForms.Guna2Button createAccountBtn;
        private Guna.UI2.WinForms.Guna2TextBox passwordTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2Button signInAccountBtn;
        private System.Windows.Forms.Label createAccountLabel2;
        private System.Windows.Forms.Label createAccountLabel1;
        private System.Windows.Forms.Label mandatoryFillingLabel2;
        private Guna.UI2.WinForms.Guna2TextBox surnameTextBox;
        private System.Windows.Forms.Label mandatoryFillingLabel3;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private System.Windows.Forms.Label mandatoryFillingLabel4;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
    }
}