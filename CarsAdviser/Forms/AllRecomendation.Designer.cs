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
            this.preferencesLabel = new System.Windows.Forms.Label();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.allRecomendationPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // preferencesLabel
            // 
            this.preferencesLabel.AutoSize = true;
            this.preferencesLabel.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold);
            this.preferencesLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.preferencesLabel.Location = new System.Drawing.Point(95, 61);
            this.preferencesLabel.Name = "preferencesLabel";
            this.preferencesLabel.Size = new System.Drawing.Size(275, 33);
            this.preferencesLabel.TabIndex = 55;
            this.preferencesLabel.Text = "Общие предпочтения";
            // 
            // saveBtn
            // 
            this.saveBtn.Animated = true;
            this.saveBtn.BorderRadius = 15;
            this.saveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saveBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.saveBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold);
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(101, 545);
            this.saveBtn.MinimumSize = new System.Drawing.Size(265, 45);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(265, 45);
            this.saveBtn.TabIndex = 57;
            this.saveBtn.Text = "Выбрать предпочтения";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // allRecomendationPanel
            // 
            this.allRecomendationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.allRecomendationPanel.AutoScroll = true;
            this.allRecomendationPanel.Location = new System.Drawing.Point(101, 142);
            this.allRecomendationPanel.Name = "allRecomendationPanel";
            this.allRecomendationPanel.Size = new System.Drawing.Size(832, 397);
            this.allRecomendationPanel.TabIndex = 58;
            // 
            // AllRecomendation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1028, 749);
            this.Controls.Add(this.allRecomendationPanel);
            this.Controls.Add(this.preferencesLabel);
            this.Controls.Add(this.saveBtn);
            this.Name = "AllRecomendation";
            this.Text = "AllRecomendation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preferencesLabel;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private System.Windows.Forms.FlowLayoutPanel allRecomendationPanel;
    }
}