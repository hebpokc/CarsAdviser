
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addCarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.preferencesBtn = new Guna.UI2.WinForms.Guna2Button();
            this.personalInformationBtn = new Guna.UI2.WinForms.Guna2Button();
            this.personalAccountLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.accountCirclePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.changePasswordBtn = new Guna.UI2.WinForms.Guna2Button();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountCirclePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.changePasswordBtn);
            this.menuPanel.Controls.Add(this.exitBtn);
            this.menuPanel.Controls.Add(this.addCarBtn);
            this.menuPanel.Controls.Add(this.preferencesBtn);
            this.menuPanel.Controls.Add(this.personalInformationBtn);
            this.menuPanel.Controls.Add(this.personalAccountLabel);
            this.menuPanel.Controls.Add(this.surnameLabel);
            this.menuPanel.Controls.Add(this.nameLabel);
            this.menuPanel.Controls.Add(this.accountCirclePictureBox);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(427, 1024);
            this.menuPanel.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.Animated = true;
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exitBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exitBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(46, 474);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(72, 34);
            this.exitBtn.TabIndex = 25;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.exitBtn.UseTransparentBackground = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCarBtn.Animated = true;
            this.addCarBtn.BackColor = System.Drawing.Color.Transparent;
            this.addCarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addCarBtn.FillColor = System.Drawing.Color.Transparent;
            this.addCarBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarBtn.ForeColor = System.Drawing.Color.Black;
            this.addCarBtn.Location = new System.Drawing.Point(46, 422);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(150, 34);
            this.addCarBtn.TabIndex = 24;
            this.addCarBtn.Text = "Добавить авто";
            this.addCarBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addCarBtn.UseTransparentBackground = true;
            this.addCarBtn.Click += new System.EventHandler(this.addCarBtn_Click);
            // 
            // preferencesBtn
            // 
            this.preferencesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.preferencesBtn.Animated = true;
            this.preferencesBtn.BackColor = System.Drawing.Color.Transparent;
            this.preferencesBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.preferencesBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.preferencesBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.preferencesBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.preferencesBtn.FillColor = System.Drawing.Color.Transparent;
            this.preferencesBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preferencesBtn.ForeColor = System.Drawing.Color.Black;
            this.preferencesBtn.Location = new System.Drawing.Point(46, 368);
            this.preferencesBtn.Name = "preferencesBtn";
            this.preferencesBtn.Size = new System.Drawing.Size(132, 34);
            this.preferencesBtn.TabIndex = 23;
            this.preferencesBtn.Text = "Предпочтения";
            this.preferencesBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.preferencesBtn.UseTransparentBackground = true;
            this.preferencesBtn.Click += new System.EventHandler(this.preferencesBtn_Click);
            // 
            // personalInformationBtn
            // 
            this.personalInformationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.personalInformationBtn.Animated = true;
            this.personalInformationBtn.BackColor = System.Drawing.Color.Transparent;
            this.personalInformationBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.personalInformationBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.personalInformationBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.personalInformationBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.personalInformationBtn.FillColor = System.Drawing.Color.Transparent;
            this.personalInformationBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalInformationBtn.ForeColor = System.Drawing.Color.Black;
            this.personalInformationBtn.Location = new System.Drawing.Point(46, 266);
            this.personalInformationBtn.Name = "personalInformationBtn";
            this.personalInformationBtn.Size = new System.Drawing.Size(187, 34);
            this.personalInformationBtn.TabIndex = 22;
            this.personalInformationBtn.Text = "Личная информация";
            this.personalInformationBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.personalInformationBtn.UseTransparentBackground = true;
            this.personalInformationBtn.Click += new System.EventHandler(this.personalInformationBtn_Click);
            // 
            // personalAccountLabel
            // 
            this.personalAccountLabel.AutoSize = true;
            this.personalAccountLabel.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalAccountLabel.Location = new System.Drawing.Point(46, 208);
            this.personalAccountLabel.Name = "personalAccountLabel";
            this.personalAccountLabel.Size = new System.Drawing.Size(225, 36);
            this.personalAccountLabel.TabIndex = 3;
            this.personalAccountLabel.Text = "Личный кабинет";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameLabel.Location = new System.Drawing.Point(230, 122);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(57, 29);
            this.surnameLabel.TabIndex = 2;
            this.surnameLabel.Text = "Имя";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(230, 73);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 29);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Фамилия";
            // 
            // accountCirclePictureBox
            // 
            this.accountCirclePictureBox.ImageRotate = 0F;
            this.accountCirclePictureBox.Location = new System.Drawing.Point(52, 52);
            this.accountCirclePictureBox.Name = "accountCirclePictureBox";
            this.accountCirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.accountCirclePictureBox.Size = new System.Drawing.Size(122, 122);
            this.accountCirclePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accountCirclePictureBox.TabIndex = 0;
            this.accountCirclePictureBox.TabStop = false;
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(427, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(997, 1024);
            this.mainPanel.TabIndex = 1;
            // 
            // changePasswordBtn
            // 
            this.changePasswordBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordBtn.Animated = true;
            this.changePasswordBtn.BackColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changePasswordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changePasswordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changePasswordBtn.FillColor = System.Drawing.Color.Transparent;
            this.changePasswordBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changePasswordBtn.ForeColor = System.Drawing.Color.Black;
            this.changePasswordBtn.Location = new System.Drawing.Point(46, 318);
            this.changePasswordBtn.Name = "changePasswordBtn";
            this.changePasswordBtn.Size = new System.Drawing.Size(168, 34);
            this.changePasswordBtn.TabIndex = 26;
            this.changePasswordBtn.Text = "Сменить пароль";
            this.changePasswordBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.changePasswordBtn.UseTransparentBackground = true;
            this.changePasswordBtn.Click += new System.EventHandler(this.changePasswordBtn_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 1024);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountCirclePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox accountCirclePictureBox;
        private System.Windows.Forms.Label personalAccountLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private Guna.UI2.WinForms.Guna2Button exitBtn;
        private Guna.UI2.WinForms.Guna2Button addCarBtn;
        private Guna.UI2.WinForms.Guna2Button preferencesBtn;
        private Guna.UI2.WinForms.Guna2Button personalInformationBtn;
        private Guna.UI2.WinForms.Guna2Button changePasswordBtn;
    }
}