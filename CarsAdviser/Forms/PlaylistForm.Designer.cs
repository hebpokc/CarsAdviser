namespace CarsAdviser.Forms
{
    partial class PlaylistForm
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
            this.palylistHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.allPlaylistLine = new System.Windows.Forms.Label();
            this.myPlaylistLine = new System.Windows.Forms.Label();
            this.palylistLabel = new System.Windows.Forms.Label();
            this.allPlaylistLabel = new System.Windows.Forms.Label();
            this.myPlaylistLabel = new System.Windows.Forms.Label();
            this.playlistPanelBtw = new Guna.UI2.WinForms.Guna2Panel();
            this.palylistHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // palylistHeader
            // 
            this.palylistHeader.Controls.Add(this.allPlaylistLine);
            this.palylistHeader.Controls.Add(this.myPlaylistLine);
            this.palylistHeader.Controls.Add(this.palylistLabel);
            this.palylistHeader.Controls.Add(this.allPlaylistLabel);
            this.palylistHeader.Controls.Add(this.myPlaylistLabel);
            this.palylistHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.palylistHeader.Location = new System.Drawing.Point(0, 0);
            this.palylistHeader.Name = "palylistHeader";
            this.palylistHeader.Size = new System.Drawing.Size(1904, 162);
            this.palylistHeader.TabIndex = 0;
            // 
            // allPlaylistLine
            // 
            this.allPlaylistLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allPlaylistLine.AutoSize = true;
            this.allPlaylistLine.BackColor = System.Drawing.Color.Transparent;
            this.allPlaylistLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.allPlaylistLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.allPlaylistLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.allPlaylistLine.Location = new System.Drawing.Point(291, 139);
            this.allPlaylistLine.Name = "allPlaylistLine";
            this.allPlaylistLine.Size = new System.Drawing.Size(153, 20);
            this.allPlaylistLine.TabIndex = 0;
            this.allPlaylistLine.Text = "‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾";
            this.allPlaylistLine.Visible = false;
            // 
            // myPlaylistLine
            // 
            this.myPlaylistLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.myPlaylistLine.AutoSize = true;
            this.myPlaylistLine.BackColor = System.Drawing.Color.Transparent;
            this.myPlaylistLine.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.myPlaylistLine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.myPlaylistLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.myPlaylistLine.Location = new System.Drawing.Point(70, 139);
            this.myPlaylistLine.Name = "myPlaylistLine";
            this.myPlaylistLine.Size = new System.Drawing.Size(153, 20);
            this.myPlaylistLine.TabIndex = 0;
            this.myPlaylistLine.Text = "‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾‾";
            // 
            // palylistLabel
            // 
            this.palylistLabel.AutoSize = true;
            this.palylistLabel.Font = new System.Drawing.Font("Candara", 30F);
            this.palylistLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.palylistLabel.Location = new System.Drawing.Point(65, 36);
            this.palylistLabel.Name = "palylistLabel";
            this.palylistLabel.Size = new System.Drawing.Size(327, 49);
            this.palylistLabel.TabIndex = 56;
            this.palylistLabel.Text = "Общие подборки";
            // 
            // allPlaylistLabel
            // 
            this.allPlaylistLabel.AutoSize = true;
            this.allPlaylistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allPlaylistLabel.Location = new System.Drawing.Point(290, 103);
            this.allPlaylistLabel.Name = "allPlaylistLabel";
            this.allPlaylistLabel.Size = new System.Drawing.Size(150, 25);
            this.allPlaylistLabel.TabIndex = 59;
            this.allPlaylistLabel.Text = "Все подборки";
            this.allPlaylistLabel.Click += new System.EventHandler(this.allPlaylistLabel_Click);
            // 
            // myPlaylistLabel
            // 
            this.myPlaylistLabel.AutoSize = true;
            this.myPlaylistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.myPlaylistLabel.Location = new System.Drawing.Point(69, 103);
            this.myPlaylistLabel.Name = "myPlaylistLabel";
            this.myPlaylistLabel.Size = new System.Drawing.Size(155, 25);
            this.myPlaylistLabel.TabIndex = 58;
            this.myPlaylistLabel.Text = "Мои подборки";
            this.myPlaylistLabel.Click += new System.EventHandler(this.myPlaylistLabel_Click);
            // 
            // playlistPanelBtw
            // 
            this.playlistPanelBtw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playlistPanelBtw.Location = new System.Drawing.Point(0, 162);
            this.playlistPanelBtw.Name = "playlistPanelBtw";
            this.playlistPanelBtw.Size = new System.Drawing.Size(1904, 879);
            this.playlistPanelBtw.TabIndex = 1;
            // 
            // PlaylistForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.playlistPanelBtw);
            this.Controls.Add(this.palylistHeader);
            this.Name = "PlaylistForm";
            this.Text = "PlaylistForm";
            this.palylistHeader.ResumeLayout(false);
            this.palylistHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel palylistHeader;
        private System.Windows.Forms.Label allPlaylistLine;
        private System.Windows.Forms.Label myPlaylistLine;
        private System.Windows.Forms.Label palylistLabel;
        private System.Windows.Forms.Label allPlaylistLabel;
        private System.Windows.Forms.Label myPlaylistLabel;
        private Guna.UI2.WinForms.Guna2Panel playlistPanelBtw;
    }
}