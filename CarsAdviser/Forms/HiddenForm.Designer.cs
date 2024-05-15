
namespace CarsAdviser.Forms
{
    partial class HiddenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HiddenForm));
            this.notificationLabel = new System.Windows.Forms.Label();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.heddenPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // notificationLabel
            // 
            resources.ApplyResources(this.notificationLabel, "notificationLabel");
            this.notificationLabel.BackColor = System.Drawing.Color.Red;
            this.notificationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.notificationLabel.ForeColor = System.Drawing.Color.White;
            this.notificationLabel.Name = "notificationLabel";
            // 
            // hiddenLabel
            // 
            resources.ApplyResources(this.hiddenLabel, "hiddenLabel");
            this.hiddenLabel.Name = "hiddenLabel";
            // 
            // heddenPanel
            // 
            resources.ApplyResources(this.heddenPanel, "heddenPanel");
            this.heddenPanel.Name = "heddenPanel";
            // 
            // HiddenForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heddenPanel);
            this.Controls.Add(this.notificationLabel);
            this.Controls.Add(this.hiddenLabel);
            this.Name = "HiddenForm";
            this.Load += new System.EventHandler(this.HiddenForm_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.HiddenForm_ControlChanged);
            this.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.HiddenForm_ControlChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificationLabel;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.FlowLayoutPanel heddenPanel;
    }
}