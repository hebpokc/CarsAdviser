namespace CarsAdviser.Forms
{
    partial class AllRecomendation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllRecomendation));
            this.preferencesLabel = new System.Windows.Forms.Label();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.allRecomendationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // preferencesLabel
            // 
            resources.ApplyResources(this.preferencesLabel, "preferencesLabel");
            this.preferencesLabel.Name = "preferencesLabel";
            // 
            // saveBtn
            // 
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.Animated = true;
            this.saveBtn.BorderRadius = 15;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // allRecomendationPanel
            // 
            resources.ApplyResources(this.allRecomendationPanel, "allRecomendationPanel");
            this.allRecomendationPanel.Name = "allRecomendationPanel";
            // 
            // AllRecomendation
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.allRecomendationPanel);
            this.Controls.Add(this.preferencesLabel);
            this.Controls.Add(this.saveBtn);
            this.Name = "AllRecomendation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preferencesLabel;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.FlowLayoutPanel allRecomendationPanel;
    }
}