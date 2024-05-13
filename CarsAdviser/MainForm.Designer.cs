
namespace CarsAdviser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.notificationLabel2 = new System.Windows.Forms.Label();
            this.notificationLabel1 = new System.Windows.Forms.Label();
            this.hiddenBottomLabel = new System.Windows.Forms.Label();
            this.bookmarkersBottomLabel = new System.Windows.Forms.Label();
            this.announcementBottomLabel = new System.Windows.Forms.Label();
            this.accountBtn = new Guna.UI2.WinForms.Guna2Button();
            this.accountCirclePictureBox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.hiddenBtn = new Guna.UI2.WinForms.Guna2Button();
            this.bookmarkersBtn = new Guna.UI2.WinForms.Guna2Button();
            this.announcementBtn = new Guna.UI2.WinForms.Guna2Button();
            this.appLogoPictureBox = new Guna.UI2.WinForms.Guna2PictureBox();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountCirclePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.notificationLabel2);
            this.headerPanel.Controls.Add(this.notificationLabel1);
            this.headerPanel.Controls.Add(this.hiddenBottomLabel);
            this.headerPanel.Controls.Add(this.bookmarkersBottomLabel);
            this.headerPanel.Controls.Add(this.announcementBottomLabel);
            this.headerPanel.Controls.Add(this.accountBtn);
            this.headerPanel.Controls.Add(this.accountCirclePictureBox);
            this.headerPanel.Controls.Add(this.hiddenBtn);
            this.headerPanel.Controls.Add(this.bookmarkersBtn);
            this.headerPanel.Controls.Add(this.announcementBtn);
            this.headerPanel.Controls.Add(this.appLogoPictureBox);
            this.headerPanel.Controls.Add(this.appNameLabel);
            resources.ApplyResources(this.headerPanel, "headerPanel");
            this.headerPanel.Name = "headerPanel";
            // 
            // notificationLabel2
            // 
            resources.ApplyResources(this.notificationLabel2, "notificationLabel2");
            this.notificationLabel2.BackColor = System.Drawing.Color.Red;
            this.notificationLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationLabel2.ForeColor = System.Drawing.Color.White;
            this.notificationLabel2.Name = "notificationLabel2";
            // 
            // notificationLabel1
            // 
            resources.ApplyResources(this.notificationLabel1, "notificationLabel1");
            this.notificationLabel1.BackColor = System.Drawing.Color.Red;
            this.notificationLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationLabel1.ForeColor = System.Drawing.Color.White;
            this.notificationLabel1.Name = "notificationLabel1";
            // 
            // hiddenBottomLabel
            // 
            resources.ApplyResources(this.hiddenBottomLabel, "hiddenBottomLabel");
            this.hiddenBottomLabel.BackColor = System.Drawing.Color.Transparent;
            this.hiddenBottomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.hiddenBottomLabel.Name = "hiddenBottomLabel";
            // 
            // bookmarkersBottomLabel
            // 
            resources.ApplyResources(this.bookmarkersBottomLabel, "bookmarkersBottomLabel");
            this.bookmarkersBottomLabel.BackColor = System.Drawing.Color.Transparent;
            this.bookmarkersBottomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.bookmarkersBottomLabel.Name = "bookmarkersBottomLabel";
            // 
            // announcementBottomLabel
            // 
            resources.ApplyResources(this.announcementBottomLabel, "announcementBottomLabel");
            this.announcementBottomLabel.BackColor = System.Drawing.Color.Transparent;
            this.announcementBottomLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.announcementBottomLabel.Name = "announcementBottomLabel";
            // 
            // accountBtn
            // 
            resources.ApplyResources(this.accountBtn, "accountBtn");
            this.accountBtn.Animated = true;
            this.accountBtn.BackColor = System.Drawing.Color.Transparent;
            this.accountBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.accountBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.accountBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.accountBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.accountBtn.FillColor = System.Drawing.Color.Transparent;
            this.accountBtn.ForeColor = System.Drawing.Color.Black;
            this.accountBtn.Name = "accountBtn";
            this.accountBtn.UseTransparentBackground = true;
            this.accountBtn.Click += new System.EventHandler(this.accountBtn_Click);
            // 
            // accountCirclePictureBox
            // 
            resources.ApplyResources(this.accountCirclePictureBox, "accountCirclePictureBox");
            this.accountCirclePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.accountCirclePictureBox.ImageRotate = 0F;
            this.accountCirclePictureBox.Name = "accountCirclePictureBox";
            this.accountCirclePictureBox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.accountCirclePictureBox.TabStop = false;
            // 
            // hiddenBtn
            // 
            resources.ApplyResources(this.hiddenBtn, "hiddenBtn");
            this.hiddenBtn.Animated = true;
            this.hiddenBtn.BackColor = System.Drawing.Color.Transparent;
            this.hiddenBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.hiddenBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.hiddenBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.hiddenBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.hiddenBtn.FillColor = System.Drawing.Color.Transparent;
            this.hiddenBtn.ForeColor = System.Drawing.Color.Black;
            this.hiddenBtn.Name = "hiddenBtn";
            this.hiddenBtn.UseTransparentBackground = true;
            this.hiddenBtn.Click += new System.EventHandler(this.hiddenBtn_Click);
            // 
            // bookmarkersBtn
            // 
            resources.ApplyResources(this.bookmarkersBtn, "bookmarkersBtn");
            this.bookmarkersBtn.Animated = true;
            this.bookmarkersBtn.BackColor = System.Drawing.Color.Transparent;
            this.bookmarkersBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bookmarkersBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bookmarkersBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bookmarkersBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bookmarkersBtn.FillColor = System.Drawing.Color.Transparent;
            this.bookmarkersBtn.ForeColor = System.Drawing.Color.Black;
            this.bookmarkersBtn.Name = "bookmarkersBtn";
            this.bookmarkersBtn.UseTransparentBackground = true;
            this.bookmarkersBtn.Click += new System.EventHandler(this.bookmarkersBtn_Click);
            // 
            // announcementBtn
            // 
            resources.ApplyResources(this.announcementBtn, "announcementBtn");
            this.announcementBtn.Animated = true;
            this.announcementBtn.BackColor = System.Drawing.Color.Transparent;
            this.announcementBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.announcementBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.announcementBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.announcementBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.announcementBtn.FillColor = System.Drawing.Color.Transparent;
            this.announcementBtn.ForeColor = System.Drawing.Color.Black;
            this.announcementBtn.Name = "announcementBtn";
            this.announcementBtn.UseTransparentBackground = true;
            this.announcementBtn.Click += new System.EventHandler(this.announcementBtn_Click);
            // 
            // appLogoPictureBox
            // 
            this.appLogoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.appLogoPictureBox.Image = global::CarsAdviser.Properties.Resources.logo;
            this.appLogoPictureBox.ImageRotate = 0F;
            resources.ApplyResources(this.appLogoPictureBox, "appLogoPictureBox");
            this.appLogoPictureBox.Name = "appLogoPictureBox";
            this.appLogoPictureBox.TabStop = false;
            // 
            // appNameLabel
            // 
            resources.ApplyResources(this.appNameLabel, "appNameLabel");
            this.appNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.appNameLabel.Name = "appNameLabel";
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.Name = "mainPanel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.headerPanel);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountCirclePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2Button announcementBtn;
        private Guna.UI2.WinForms.Guna2PictureBox appLogoPictureBox;
        private System.Windows.Forms.Label appNameLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox accountCirclePictureBox;
        private Guna.UI2.WinForms.Guna2Button hiddenBtn;
        private Guna.UI2.WinForms.Guna2Button bookmarkersBtn;
        private Guna.UI2.WinForms.Guna2Button accountBtn;
        private System.Windows.Forms.Label announcementBottomLabel;
        private System.Windows.Forms.Label bookmarkersBottomLabel;
        private System.Windows.Forms.Label hiddenBottomLabel;
        private System.Windows.Forms.Label notificationLabel2;
        private System.Windows.Forms.Label notificationLabel1;
        public Guna.UI2.WinForms.Guna2Panel mainPanel;
    }
}

