
namespace CarsAdviser.Forms
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.menuPanel = new System.Windows.Forms.Panel();
            this.AllPlaylistBtn = new Guna.UI2.WinForms.Guna2Button();
            this.yandexImg = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.changePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addCarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.preferencesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.personalInformationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.personalAccountLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.accountCirclePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yandexImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountCirclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            resources.ApplyResources(this.menuPanel, "menuPanel");
            this.menuPanel.Controls.Add(this.AllPlaylistBtn);
            this.menuPanel.Controls.Add(this.yandexImg);
            this.menuPanel.Controls.Add(this.changePasswordBtn);
            this.menuPanel.Controls.Add(this.exitBtn);
            this.menuPanel.Controls.Add(this.addCarBtn);
            this.menuPanel.Controls.Add(this.preferencesBtn);
            this.menuPanel.Controls.Add(this.personalInformationBtn);
            this.menuPanel.Controls.Add(this.personalAccountLabel);
            this.menuPanel.Controls.Add(this.surnameLabel);
            this.menuPanel.Controls.Add(this.nameLabel);
            this.menuPanel.Controls.Add(this.accountCirclePictureBox);
            this.menuPanel.Name = "menuPanel";
            // 
            // AllPlaylistBtn
            // 
            resources.ApplyResources(this.AllPlaylistBtn, "AllPlaylistBtn");
            this.AllPlaylistBtn.Animated = true;
            this.AllPlaylistBtn.BackColor = System.Drawing.Color.Transparent;
            this.AllPlaylistBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllPlaylistBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllPlaylistBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllPlaylistBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllPlaylistBtn.FillColor = System.Drawing.Color.Transparent;
            this.AllPlaylistBtn.ForeColor = System.Drawing.Color.Black;
            this.AllPlaylistBtn.Name = "AllPlaylistBtn";
            this.AllPlaylistBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AllPlaylistBtn.UseTransparentBackground = true;
            this.AllPlaylistBtn.Click += new System.EventHandler(this.AllPlaylistBtn_Click);
            // 
            // yandexImg
            // 
            resources.ApplyResources(this.yandexImg, "yandexImg");
            this.yandexImg.BackColor = System.Drawing.SystemColors.Control;
            this.yandexImg.Image = global::CarsAdviser.Properties.Resources.yandex;
            this.yandexImg.ImageRotate = 0F;
            this.yandexImg.InitialImage = global::CarsAdviser.Properties.Resources.yandex;
            this.yandexImg.Name = "yandexImg";
            this.yandexImg.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.yandexImg.TabStop = false;
            // 
            // changePasswordBtn
            // 
            resources.ApplyResources(this.changePasswordBtn, "changePasswordBtn");
            this.changePasswordBtn.Animated = true;
            this.changePasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordBtn.FillColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.changePasswordBtn.UseTransparentBackground = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // exitBtn
            // 
            resources.ApplyResources(this.exitBtn, "exitBtn");
            this.exitBtn.Animated = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitBtn.UseTransparentBackground = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addCarBtn
            // 
            resources.ApplyResources(this.addCarBtn, "addCarBtn");
            this.addCarBtn.Animated = true;
            this.addCarBtn.BackColor = System.Drawing.Color.Transparent;
            this.addCarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addCarBtn.FillColor = System.Drawing.Color.Transparent;
            this.addCarBtn.ForeColor = System.Drawing.Color.Black;
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addCarBtn.UseTransparentBackground = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // preferencesBtn
            // 
            resources.ApplyResources(this.preferencesBtn, "preferencesBtn");
            this.preferencesBtn.Animated = true;
            this.preferencesBtn.BackColor = System.Drawing.Color.Transparent;
            this.preferencesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.preferencesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.preferencesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.preferencesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.preferencesBtn.FillColor = System.Drawing.Color.Transparent;
            this.preferencesBtn.ForeColor = System.Drawing.Color.Black;
            this.preferencesBtn.Name = "preferencesBtn";
            this.preferencesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.preferencesBtn.UseTransparentBackground = true;
            this.preferencesBtn.Click += new System.EventHandler(this.preferencesBtn_Click);
            // 
            // personalInformationBtn
            // 
            resources.ApplyResources(this.personalInformationBtn, "personalInformationBtn");
            this.personalInformationBtn.Animated = true;
            this.personalInformationBtn.BackColor = System.Drawing.Color.Transparent;
            this.personalInformationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.personalInformationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.personalInformationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.personalInformationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.personalInformationBtn.FillColor = System.Drawing.Color.Transparent;
            this.personalInformationBtn.ForeColor = System.Drawing.Color.Black;
            this.personalInformationBtn.Name = "personalInformationBtn";
            this.personalInformationBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.personalInformationBtn.UseTransparentBackground = true;
            this.personalInformationBtn.Click += new System.EventHandler(this.personalInformationBtn_Click);
            // 
            // personalAccountLabel
            // 
            resources.ApplyResources(this.personalAccountLabel, "personalAccountLabel");
            this.personalAccountLabel.Name = "personalAccountLabel";
            // 
            // surnameLabel
            // 
            resources.ApplyResources(this.surnameLabel, "surnameLabel");
            this.surnameLabel.Name = "surnameLabel";
            // 
            // nameLabel
            // 
            resources.ApplyResources(this.nameLabel, "nameLabel");
            this.nameLabel.Name = "nameLabel";
            // 
            // accountCirclePictureBox
            // 
            resources.ApplyResources(this.accountCirclePictureBox, "accountCirclePictureBox");
            this.accountCirclePictureBox.ImageRotate = 0F;
            this.accountCirclePictureBox.Name = "accountCirclePictureBox";
            this.accountCirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.accountCirclePictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // AccountForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "AccountForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountForm_FormClosed);
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yandexImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountCirclePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox accountCirclePictureBox;
        private System.Windows.Forms.Label personalAccountLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button addCarBtn;
        private Guna.UI2.WinForms.Guna2Button preferencesBtn;
        private Guna.UI2.WinForms.Guna2Button personalInformationBtn;
        private Guna.UI2.WinForms.Guna2Button changePasswordBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox yandexImg;
        private Guna.UI2.WinForms.Guna2Button AllPlaylistBtn;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
    }
}