
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
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
            this.YandexAuthBtn = new Guna.UI2.WinForms.Guna2Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // mandatoryFillingLabel5
            // 
            resources.ApplyResources(this.mandatoryFillingLabel5, "mandatoryFillingLabel5");
            this.mandatoryFillingLabel5.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel5.Name = "mandatoryFillingLabel5";
            // 
            // mandatoryFillingLabel1
            // 
            resources.ApplyResources(this.mandatoryFillingLabel1, "mandatoryFillingLabel1");
            this.mandatoryFillingLabel1.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel1.Name = "mandatoryFillingLabel1";
            // 
            // createAccountBtn
            // 
            resources.ApplyResources(this.createAccountBtn, "createAccountBtn");
            this.createAccountBtn.Animated = true;
            this.createAccountBtn.BorderRadius = 10;
            this.createAccountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAccountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAccountBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.createAccountBtn.ForeColor = System.Drawing.Color.White;
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.TabStop = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // passwordTextBox
            // 
            resources.ApplyResources(this.passwordTextBox, "passwordTextBox");
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
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTextBox.IconRight = global::CarsAdviser.Properties.Resources.showpass;
            this.passwordTextBox.IconRightSize = new System.Drawing.Size(32, 32);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '\0';
            this.passwordTextBox.PlaceholderText = "Пароль";
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.IconRightClick += new System.EventHandler(this.passwordTextBox_IconRightClick);
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this.nameTextBox, "nameTextBox");
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
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Имя";
            this.nameTextBox.SelectedText = "";
            // 
            // signInAccountBtn
            // 
            resources.ApplyResources(this.signInAccountBtn, "signInAccountBtn");
            this.signInAccountBtn.Animated = true;
            this.signInAccountBtn.BackColor = System.Drawing.Color.Transparent;
            this.signInAccountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInAccountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInAccountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInAccountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInAccountBtn.FillColor = System.Drawing.Color.Transparent;
            this.signInAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.signInAccountBtn.Name = "signInAccountBtn";
            this.signInAccountBtn.TabStop = false;
            this.signInAccountBtn.Click += new System.EventHandler(this.signInAccountBtn_Click);
            // 
            // createAccountLabel2
            // 
            resources.ApplyResources(this.createAccountLabel2, "createAccountLabel2");
            this.createAccountLabel2.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLabel2.Name = "createAccountLabel2";
            // 
            // createAccountLabel1
            // 
            resources.ApplyResources(this.createAccountLabel1, "createAccountLabel1");
            this.createAccountLabel1.BackColor = System.Drawing.Color.Transparent;
            this.createAccountLabel1.Name = "createAccountLabel1";
            // 
            // mandatoryFillingLabel2
            // 
            resources.ApplyResources(this.mandatoryFillingLabel2, "mandatoryFillingLabel2");
            this.mandatoryFillingLabel2.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel2.Name = "mandatoryFillingLabel2";
            // 
            // surnameTextBox
            // 
            resources.ApplyResources(this.surnameTextBox, "surnameTextBox");
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
            this.surnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PlaceholderText = "Фамилия";
            this.surnameTextBox.SelectedText = "";
            // 
            // mandatoryFillingLabel3
            // 
            resources.ApplyResources(this.mandatoryFillingLabel3, "mandatoryFillingLabel3");
            this.mandatoryFillingLabel3.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel3.Name = "mandatoryFillingLabel3";
            // 
            // emailTextBox
            // 
            resources.ApplyResources(this.emailTextBox, "emailTextBox");
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
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Email";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // mandatoryFillingLabel4
            // 
            resources.ApplyResources(this.mandatoryFillingLabel4, "mandatoryFillingLabel4");
            this.mandatoryFillingLabel4.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel4.Name = "mandatoryFillingLabel4";
            // 
            // phoneTextBox
            // 
            resources.ApplyResources(this.phoneTextBox, "phoneTextBox");
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
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "Телефон";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Leave += new System.EventHandler(this.phoneTextBox_Leave);
            // 
            // YandexAuthBtn
            // 
            resources.ApplyResources(this.YandexAuthBtn, "YandexAuthBtn");
            this.YandexAuthBtn.Animated = true;
            this.YandexAuthBtn.BorderRadius = 10;
            this.YandexAuthBtn.BorderThickness = 1;
            this.YandexAuthBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.YandexAuthBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.YandexAuthBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.YandexAuthBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.YandexAuthBtn.FillColor = System.Drawing.Color.White;
            this.YandexAuthBtn.ForeColor = System.Drawing.Color.Black;
            this.YandexAuthBtn.Image = global::CarsAdviser.Properties.Resources.yandex;
            this.YandexAuthBtn.ImageOffset = new System.Drawing.Point(-4, 0);
            this.YandexAuthBtn.ImageSize = new System.Drawing.Size(25, 25);
            this.YandexAuthBtn.Name = "YandexAuthBtn";
            this.YandexAuthBtn.TabStop = false;
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // RegisterForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.YandexAuthBtn);
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
            this.Load += new System.EventHandler(this.RegisterForm_Load);
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
        private Guna.UI2.WinForms.Guna2Button YandexAuthBtn;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}