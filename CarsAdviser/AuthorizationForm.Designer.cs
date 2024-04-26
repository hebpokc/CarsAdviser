
namespace CarsAdviser
{
    partial class AuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthorizationForm));
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ruLangBtn = new Guna.UI2.WinForms.Guna2Button();
            this.appLogoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.enLangBtn = new Guna.UI2.WinForms.Guna2Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.enLangBtn);
            this.headerPanel.Controls.Add(this.ruLangBtn);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.appLogoPictureBox);
            this.headerPanel.Controls.Add(this.appNameLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1424, 97);
            this.headerPanel.TabIndex = 0;
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.appNameLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(108, 37);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(128, 26);
            this.appNameLabel.TabIndex = 21;
            this.appNameLabel.Text = "CARPULSE   |";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 97);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1424, 927);
            this.mainPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(1272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "Выберите язык";
            // 
            // ruLangBtn
            // 
            this.ruLangBtn.Animated = true;
            this.ruLangBtn.BorderRadius = 3;
            this.ruLangBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ruLangBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ruLangBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ruLangBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ruLangBtn.FillColor = System.Drawing.Color.Transparent;
            this.ruLangBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ruLangBtn.ForeColor = System.Drawing.Color.White;
            this.ruLangBtn.Image = global::CarsAdviser.Properties.Resources.russia_flag;
            this.ruLangBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.ruLangBtn.Location = new System.Drawing.Point(1285, 46);
            this.ruLangBtn.Name = "ruLangBtn";
            this.ruLangBtn.Size = new System.Drawing.Size(47, 28);
            this.ruLangBtn.TabIndex = 24;
            // 
            // appLogoPictureBox
            // 
            this.appLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.appLogoPictureBox.Image = global::CarsAdviser.Properties.Resources.logo;
            this.appLogoPictureBox.ImageRotate = 0F;
            this.appLogoPictureBox.Location = new System.Drawing.Point(239, 12);
            this.appLogoPictureBox.Name = "appLogoPictureBox";
            this.appLogoPictureBox.Size = new System.Drawing.Size(115, 72);
            this.appLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.appLogoPictureBox.TabIndex = 22;
            this.appLogoPictureBox.TabStop = false;
            // 
            // enLangBtn
            // 
            this.enLangBtn.Animated = true;
            this.enLangBtn.BorderRadius = 3;
            this.enLangBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.enLangBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.enLangBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.enLangBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.enLangBtn.FillColor = System.Drawing.Color.Transparent;
            this.enLangBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.enLangBtn.ForeColor = System.Drawing.Color.White;
            this.enLangBtn.Image = global::CarsAdviser.Properties.Resources.united_states_flag;
            this.enLangBtn.ImageSize = new System.Drawing.Size(32, 32);
            this.enLangBtn.Location = new System.Drawing.Point(1352, 46);
            this.enLangBtn.Name = "enLangBtn";
            this.enLangBtn.Size = new System.Drawing.Size(47, 28);
            this.enLangBtn.TabIndex = 25;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1424, 1024);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1440, 1063);
            this.Name = "AuthorizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2PictureBox appLogoPictureBox;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Button ruLangBtn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button enLangBtn;
    }
}