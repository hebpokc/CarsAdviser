
namespace CarsAdviser.Forms
{
    partial class BookmarkersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookmarkersForm));
            this.bookmarkersLabel = new System.Windows.Forms.Label();
            this.notificationLabel = new System.Windows.Forms.Label();
            this.heddenPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // bookmarkersLabel
            // 
            resources.ApplyResources(this.bookmarkersLabel, "bookmarkersLabel");
            this.bookmarkersLabel.Name = "bookmarkersLabel";
            // 
            // notificationLabel
            // 
            resources.ApplyResources(this.notificationLabel, "notificationLabel");
            this.notificationLabel.BackColor = System.Drawing.Color.Red;
            this.notificationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationLabel.ForeColor = System.Drawing.Color.White;
            this.notificationLabel.Name = "notificationLabel";
            // 
            // heddenPanel
            // 
            resources.ApplyResources(this.heddenPanel, "heddenPanel");
            this.heddenPanel.Name = "heddenPanel";
            // 
            // BookmarkersForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heddenPanel);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.bookmarkersLabel);
            this.Name = "BookmarkersForm";
            this.Load += new System.EventHandler(this.BookmarkersForm_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.BookmarkersForm_ControlChanged);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.BookmarkersForm_ControlChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label bookmarkersLabel;
        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.FlowLayoutPanel heddenPanel;
    }
}