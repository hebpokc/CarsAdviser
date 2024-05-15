
namespace CarsAdviser.Forms
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.preferencesLabel = new System.Windows.Forms.Label();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.newListBtn = new Guna.UI2.WinForms.Guna2Button();
            this.clearBtn = new Guna.UI2.WinForms.Guna2Button();
            this.prefPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // preferencesLabel
            // 
            resources.ApplyResources(this.preferencesLabel, "preferencesLabel");
            this.preferencesLabel.Name = "preferencesLabel";
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
            resources.ApplyResources(this.saveBtn, "saveBtn");
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // newListBtn
            // 
            this.newListBtn.Animated = true;
            this.newListBtn.BorderRadius = 15;
            this.newListBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.newListBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.newListBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.newListBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.newListBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.newListBtn, "newListBtn");
            this.newListBtn.ForeColor = System.Drawing.Color.White;
            this.newListBtn.Name = "newListBtn";
            this.newListBtn.Click += new System.EventHandler(this.newListBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Animated = true;
            this.clearBtn.BorderRadius = 15;
            this.clearBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.clearBtn, "clearBtn");
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // prefPanel
            // 
            resources.ApplyResources(this.prefPanel, "prefPanel");
            this.prefPanel.Name = "prefPanel";
            // 
            // PreferencesForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prefPanel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.newListBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.preferencesLabel);
            this.Name = "PreferencesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preferencesLabel;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2Button newListBtn;
        private Guna.UI2.WinForms.Guna2Button clearBtn;
        private System.Windows.Forms.FlowLayoutPanel prefPanel;
    }
}