
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
            this.YandexAuthBtn = new Guna.UI2.WinForms.Guna2Button();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // signInBtn
            // 
            resources.ApplyResources(this.signInBtn, "signInBtn");
            this.signInBtn.Animated = true;
            this.signInBtn.BorderRadius = 10;
            this.signInBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.signInBtn.ForeColor = System.Drawing.Color.White;
            this.signInBtn.Name = "signInBtn";
            this.signInBtn.TabStop = false;
            this.signInBtn.Click += new System.EventHandler(this.signInBtn_Click);
            // 
            // loginTextBox
            // 
            resources.ApplyResources(this.loginTextBox, "loginTextBox");
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
            this.loginTextBox.ForeColor = System.Drawing.Color.Black;
            this.loginTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.PasswordChar = '\0';
            this.loginTextBox.PlaceholderText = "E-mail или телефон";
            this.loginTextBox.SelectedText = "";
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTextBox_KeyDown);
            // 
            // createAccountBtn
            // 
            resources.ApplyResources(this.createAccountBtn, "createAccountBtn");
            this.createAccountBtn.Animated = true;
            this.createAccountBtn.BackColor = System.Drawing.Color.Transparent;
            this.createAccountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.createAccountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.createAccountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.createAccountBtn.FillColor = System.Drawing.Color.Transparent;
            this.createAccountBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.TabStop = false;
            this.createAccountBtn.Click += new System.EventHandler(this.createAccountBtn_Click);
            // 
            // signInLabel2
            // 
            resources.ApplyResources(this.signInLabel2, "signInLabel2");
            this.signInLabel2.BackColor = System.Drawing.Color.Transparent;
            this.signInLabel2.Name = "signInLabel2";
            // 
            // signInLabel1
            // 
            resources.ApplyResources(this.signInLabel1, "signInLabel1");
            this.signInLabel1.BackColor = System.Drawing.Color.Transparent;
            this.signInLabel1.Name = "signInLabel1";
            // 
            // mandatoryFillingLabel1
            // 
            resources.ApplyResources(this.mandatoryFillingLabel1, "mandatoryFillingLabel1");
            this.mandatoryFillingLabel1.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel1.Name = "mandatoryFillingLabel1";
            // 
            // mandatoryFillingLabel2
            // 
            resources.ApplyResources(this.mandatoryFillingLabel2, "mandatoryFillingLabel2");
            this.mandatoryFillingLabel2.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel2.Name = "mandatoryFillingLabel2";
            // 
            // uncorrectDataTextBox
            // 
            resources.ApplyResources(this.uncorrectDataTextBox, "uncorrectDataTextBox");
            this.uncorrectDataTextBox.BackColor = System.Drawing.Color.Transparent;
            this.uncorrectDataTextBox.BorderColor = System.Drawing.Color.Red;
            this.uncorrectDataTextBox.BorderRadius = 5;
            this.uncorrectDataTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uncorrectDataTextBox.DefaultText = "Вход не удался\r\n\r\nНеправильный логин или пароль\r\n\r\n\r\n\r\n\r\n";
            this.uncorrectDataTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.uncorrectDataTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.uncorrectDataTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uncorrectDataTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.uncorrectDataTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.uncorrectDataTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uncorrectDataTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.uncorrectDataTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.uncorrectDataTextBox.Multiline = true;
            this.uncorrectDataTextBox.Name = "uncorrectDataTextBox";
            this.uncorrectDataTextBox.PasswordChar = '\0';
            this.uncorrectDataTextBox.PlaceholderText = "";
            this.uncorrectDataTextBox.ReadOnly = true;
            this.uncorrectDataTextBox.SelectedText = "";
            this.uncorrectDataTextBox.TabStop = false;
            this.uncorrectDataTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.uncorrectDataTextBox_KeyDown);
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
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextBox_KeyDown);
            // 
            // showPassImageBtn
            // 
            resources.ApplyResources(this.showPassImageBtn, "showPassImageBtn");
            this.showPassImageBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPassImageBtn.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.showPassImageBtn.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.showPassImageBtn.Image = ((System.Drawing.Image)(resources.GetObject("showPassImageBtn.Image")));
            this.showPassImageBtn.ImageOffset = new System.Drawing.Point(0, 0);
            this.showPassImageBtn.ImageRotate = 0F;
            this.showPassImageBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.showPassImageBtn.Name = "showPassImageBtn";
            this.showPassImageBtn.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            // 
            // YandexAuthBtn
            // 
            resources.ApplyResources(this.YandexAuthBtn, "YandexAuthBtn");
            this.YandexAuthBtn.Animated = true;
            this.YandexAuthBtn.BorderRadius = 10;
            this.YandexAuthBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.YandexAuthBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.YandexAuthBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.YandexAuthBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.YandexAuthBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.YandexAuthBtn.ForeColor = System.Drawing.Color.White;
            this.YandexAuthBtn.Name = "YandexAuthBtn";
            this.YandexAuthBtn.TabStop = false;
            this.YandexAuthBtn.Click += new System.EventHandler(this.YandexAuthBtn_Click);
            // 
            // webBrowser
            // 
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser_Navigated);
            // 
            // SignInForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.YandexAuthBtn);
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
        private Guna.UI2.WinForms.Guna2Button YandexAuthBtn;
        private WebBrowser webBrowser;
    }
}