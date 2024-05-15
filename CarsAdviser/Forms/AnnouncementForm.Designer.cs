
namespace CarsAdviser.Forms
{
    partial class AnnouncementForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnnouncementForm));
            this.priceGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.applyBtn = new Guna.UI2.WinForms.Guna2Button();
            this.MailSendBtn = new Guna.UI2.WinForms.Guna2Button();
            this.priceTrackBar2 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.priceTrackBar1 = new Guna.UI2.WinForms.Guna2TrackBar();
            this.priceToLabel = new System.Windows.Forms.Label();
            this.priceFromLabel = new System.Windows.Forms.Label();
            this.rubleLabel2 = new System.Windows.Forms.Label();
            this.priceToTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.rubleLabel = new System.Windows.Forms.Label();
            this.priceFromTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.announcementLabel = new System.Windows.Forms.Label();
            this.CarsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.priceGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // priceGroupBox
            // 
            resources.ApplyResources(this.priceGroupBox, "priceGroupBox");
            this.priceGroupBox.BorderRadius = 7;
            this.priceGroupBox.Controls.Add(this.applyBtn);
            this.priceGroupBox.Controls.Add(this.MailSendBtn);
            this.priceGroupBox.Controls.Add(this.priceTrackBar2);
            this.priceGroupBox.Controls.Add(this.priceTrackBar1);
            this.priceGroupBox.Controls.Add(this.priceToLabel);
            this.priceGroupBox.Controls.Add(this.priceFromLabel);
            this.priceGroupBox.Controls.Add(this.rubleLabel2);
            this.priceGroupBox.Controls.Add(this.priceToTextBox);
            this.priceGroupBox.Controls.Add(this.rubleLabel);
            this.priceGroupBox.Controls.Add(this.priceFromTextBox);
            this.priceGroupBox.ForeColor = System.Drawing.Color.Black;
            this.priceGroupBox.Name = "priceGroupBox";
            // 
            // applyBtn
            // 
            resources.ApplyResources(this.applyBtn, "applyBtn");
            this.applyBtn.Animated = true;
            this.applyBtn.BackColor = System.Drawing.Color.Transparent;
            this.applyBtn.BorderRadius = 15;
            this.applyBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.applyBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.applyBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.applyBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.applyBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.applyBtn.ForeColor = System.Drawing.Color.White;
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // MailSendBtn
            // 
            resources.ApplyResources(this.MailSendBtn, "MailSendBtn");
            this.MailSendBtn.Animated = true;
            this.MailSendBtn.BackColor = System.Drawing.Color.Transparent;
            this.MailSendBtn.BorderRadius = 15;
            this.MailSendBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.MailSendBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.MailSendBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.MailSendBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.MailSendBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.MailSendBtn.ForeColor = System.Drawing.Color.White;
            this.MailSendBtn.Name = "MailSendBtn";
            this.MailSendBtn.Click += new System.EventHandler(this.MailSendBtn_Click);
            // 
            // priceTrackBar2
            // 
            resources.ApplyResources(this.priceTrackBar2, "priceTrackBar2");
            this.priceTrackBar2.BackColor = System.Drawing.Color.Transparent;
            this.priceTrackBar2.LargeChange = 500000;
            this.priceTrackBar2.Maximum = 10000000;
            this.priceTrackBar2.Minimum = 5000001;
            this.priceTrackBar2.Name = "priceTrackBar2";
            this.priceTrackBar2.SmallChange = 100000;
            this.priceTrackBar2.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.priceTrackBar2.Value = 5000001;
            this.priceTrackBar2.ValueChanged += new System.EventHandler(this.priceTrackBar_ValueChanged);
            // 
            // priceTrackBar1
            // 
            resources.ApplyResources(this.priceTrackBar1, "priceTrackBar1");
            this.priceTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.priceTrackBar1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.priceTrackBar1.LargeChange = 500000;
            this.priceTrackBar1.Maximum = 5000000;
            this.priceTrackBar1.Name = "priceTrackBar1";
            this.priceTrackBar1.SmallChange = 100000;
            this.priceTrackBar1.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.priceTrackBar1.Value = 0;
            this.priceTrackBar1.ValueChanged += new System.EventHandler(this.priceTrackBar_ValueChanged);
            // 
            // priceToLabel
            // 
            resources.ApplyResources(this.priceToLabel, "priceToLabel");
            this.priceToLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceToLabel.Name = "priceToLabel";
            // 
            // priceFromLabel
            // 
            resources.ApplyResources(this.priceFromLabel, "priceFromLabel");
            this.priceFromLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceFromLabel.Name = "priceFromLabel";
            // 
            // rubleLabel2
            // 
            resources.ApplyResources(this.rubleLabel2, "rubleLabel2");
            this.rubleLabel2.BackColor = System.Drawing.Color.Transparent;
            this.rubleLabel2.Name = "rubleLabel2";
            // 
            // priceToTextBox
            // 
            resources.ApplyResources(this.priceToTextBox, "priceToTextBox");
            this.priceToTextBox.Animated = true;
            this.priceToTextBox.AutoRoundedCorners = true;
            this.priceToTextBox.BackColor = System.Drawing.Color.Transparent;
            this.priceToTextBox.BorderRadius = 17;
            this.priceToTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceToTextBox.DefaultText = "";
            this.priceToTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceToTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceToTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceToTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceToTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceToTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceToTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceToTextBox.Name = "priceToTextBox";
            this.priceToTextBox.PasswordChar = '\0';
            this.priceToTextBox.PlaceholderText = "";
            this.priceToTextBox.SelectedText = "";
            this.priceToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // rubleLabel
            // 
            resources.ApplyResources(this.rubleLabel, "rubleLabel");
            this.rubleLabel.BackColor = System.Drawing.Color.Transparent;
            this.rubleLabel.Name = "rubleLabel";
            // 
            // priceFromTextBox
            // 
            resources.ApplyResources(this.priceFromTextBox, "priceFromTextBox");
            this.priceFromTextBox.Animated = true;
            this.priceFromTextBox.AutoRoundedCorners = true;
            this.priceFromTextBox.BackColor = System.Drawing.Color.Transparent;
            this.priceFromTextBox.BorderRadius = 17;
            this.priceFromTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.priceFromTextBox.DefaultText = "";
            this.priceFromTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.priceFromTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.priceFromTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceFromTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.priceFromTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceFromTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.priceFromTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.priceFromTextBox.Name = "priceFromTextBox";
            this.priceFromTextBox.PasswordChar = '\0';
            this.priceFromTextBox.PlaceholderText = "";
            this.priceFromTextBox.SelectedText = "";
            this.priceFromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.priceTextBox_KeyPress);
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.Animated = true;
            this.searchTextBox.BorderColor = System.Drawing.Color.Silver;
            this.searchTextBox.BorderRadius = 7;
            this.searchTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextBox.DefaultText = "";
            this.searchTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.PasswordChar = '\0';
            this.searchTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.searchTextBox.PlaceholderText = "";
            this.searchTextBox.SelectedText = "";
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // announcementLabel
            // 
            resources.ApplyResources(this.announcementLabel, "announcementLabel");
            this.announcementLabel.Name = "announcementLabel";
            // 
            // CarsPanel
            // 
            resources.ApplyResources(this.CarsPanel, "CarsPanel");
            this.CarsPanel.Name = "CarsPanel";
            // 
            // AnnouncementForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CarsPanel);
            this.Controls.Add(this.priceGroupBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.announcementLabel);
            this.Name = "AnnouncementForm";
            this.priceGroupBox.ResumeLayout(false);
            this.priceGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox priceGroupBox;
        private Guna.UI2.WinForms.Guna2Button applyBtn;
        private Guna.UI2.WinForms.Guna2TrackBar priceTrackBar2;
        private Guna.UI2.WinForms.Guna2TrackBar priceTrackBar1;
        private System.Windows.Forms.Label priceToLabel;
        private System.Windows.Forms.Label priceFromLabel;
        private System.Windows.Forms.Label rubleLabel2;
        private Guna.UI2.WinForms.Guna2TextBox priceToTextBox;
        private System.Windows.Forms.Label rubleLabel;
        private Guna.UI2.WinForms.Guna2TextBox priceFromTextBox;
        private Guna.UI2.WinForms.Guna2TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label announcementLabel;
        private Guna.UI2.WinForms.Guna2Button MailSendBtn;
        private System.Windows.Forms.FlowLayoutPanel CarsPanel;
    }
}