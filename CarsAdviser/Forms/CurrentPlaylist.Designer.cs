namespace CarsAdviser.Forms
{
    partial class CurrentPlaylist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CurrentPlaylist));
            this.PlaylisTag = new System.Windows.Forms.Label();
            this.carPanel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.detailsBtn1 = new Guna.UI2.WinForms.Guna2Button();
            this.carPriceInfoLabel1 = new System.Windows.Forms.Label();
            this.carPriceLabel1 = new System.Windows.Forms.Label();
            this.carDriveInfoLabel1 = new System.Windows.Forms.Label();
            this.carDriveLabel1 = new System.Windows.Forms.Label();
            this.carEngineInfoLabel1 = new System.Windows.Forms.Label();
            this.carEngineLabel1 = new System.Windows.Forms.Label();
            this.carFuelInfoLabel1 = new System.Windows.Forms.Label();
            this.carYearLabel1 = new System.Windows.Forms.Label();
            this.carFuelLabel1 = new System.Windows.Forms.Label();
            this.carNameLabel1 = new System.Windows.Forms.Label();
            this.carBrandPictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mileageInfoLabel1 = new System.Windows.Forms.Label();
            this.mileageLabel1 = new System.Windows.Forms.Label();
            this.carPictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.carPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlaylisTag
            // 
            this.PlaylisTag.AutoSize = true;
            this.PlaylisTag.Font = new System.Drawing.Font("Candara", 30F);
            this.PlaylisTag.Location = new System.Drawing.Point(65, 36);
            this.PlaylisTag.Name = "PlaylisTag";
            this.PlaylisTag.Size = new System.Drawing.Size(370, 49);
            this.PlaylisTag.TabIndex = 0;
            this.PlaylisTag.Text = "Название подборки";
            // 
            // carPanel1
            // 
            this.carPanel1.BorderColor = System.Drawing.Color.Black;
            this.carPanel1.BorderRadius = 30;
            this.carPanel1.BorderThickness = 1;
            this.carPanel1.Controls.Add(this.detailsBtn1);
            this.carPanel1.Controls.Add(this.carPriceInfoLabel1);
            this.carPanel1.Controls.Add(this.carPriceLabel1);
            this.carPanel1.Controls.Add(this.carDriveInfoLabel1);
            this.carPanel1.Controls.Add(this.carDriveLabel1);
            this.carPanel1.Controls.Add(this.carEngineInfoLabel1);
            this.carPanel1.Controls.Add(this.carEngineLabel1);
            this.carPanel1.Controls.Add(this.carFuelInfoLabel1);
            this.carPanel1.Controls.Add(this.carYearLabel1);
            this.carPanel1.Controls.Add(this.carFuelLabel1);
            this.carPanel1.Controls.Add(this.carNameLabel1);
            this.carPanel1.Controls.Add(this.carBrandPictureBox1);
            this.carPanel1.Controls.Add(this.mileageInfoLabel1);
            this.carPanel1.Controls.Add(this.mileageLabel1);
            this.carPanel1.Controls.Add(this.carPictureBox1);
            this.carPanel1.Location = new System.Drawing.Point(74, 112);
            this.carPanel1.Name = "carPanel1";
            this.carPanel1.Size = new System.Drawing.Size(265, 479);
            this.carPanel1.TabIndex = 23;
            // 
            // detailsBtn1
            // 
            this.detailsBtn1.Animated = true;
            this.detailsBtn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.detailsBtn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.detailsBtn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.detailsBtn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.detailsBtn1.FillColor = System.Drawing.Color.Transparent;
            this.detailsBtn1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold);
            this.detailsBtn1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.detailsBtn1.Location = new System.Drawing.Point(74, 427);
            this.detailsBtn1.Name = "detailsBtn1";
            this.detailsBtn1.Size = new System.Drawing.Size(126, 34);
            this.detailsBtn1.TabIndex = 11;
            this.detailsBtn1.Tag = "1";
            this.detailsBtn1.Text = "ПОДРОБНЕЕ 🡽";
            // 
            // carPriceInfoLabel1
            // 
            this.carPriceInfoLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.carPriceInfoLabel1.ForeColor = System.Drawing.Color.Black;
            this.carPriceInfoLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carPriceInfoLabel1.Location = new System.Drawing.Point(137, 381);
            this.carPriceInfoLabel1.Name = "carPriceInfoLabel1";
            this.carPriceInfoLabel1.Size = new System.Drawing.Size(117, 20);
            this.carPriceInfoLabel1.TabIndex = 10;
            this.carPriceInfoLabel1.Text = "3.500.000 ₽";
            this.carPriceInfoLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // carPriceLabel1
            // 
            this.carPriceLabel1.AutoSize = true;
            this.carPriceLabel1.Font = new System.Drawing.Font("Candara", 11.25F);
            this.carPriceLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carPriceLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carPriceLabel1.Location = new System.Drawing.Point(15, 383);
            this.carPriceLabel1.Name = "carPriceLabel1";
            this.carPriceLabel1.Size = new System.Drawing.Size(107, 18);
            this.carPriceLabel1.TabIndex = 9;
            this.carPriceLabel1.Text = "Итоговая цена:";
            // 
            // carDriveInfoLabel1
            // 
            this.carDriveInfoLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.carDriveInfoLabel1.ForeColor = System.Drawing.Color.Black;
            this.carDriveInfoLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carDriveInfoLabel1.Location = new System.Drawing.Point(141, 343);
            this.carDriveInfoLabel1.Name = "carDriveInfoLabel1";
            this.carDriveInfoLabel1.Size = new System.Drawing.Size(113, 20);
            this.carDriveInfoLabel1.TabIndex = 8;
            this.carDriveInfoLabel1.Text = "Полный";
            this.carDriveInfoLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // carDriveLabel1
            // 
            this.carDriveLabel1.AutoSize = true;
            this.carDriveLabel1.Font = new System.Drawing.Font("Candara", 11.25F);
            this.carDriveLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carDriveLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carDriveLabel1.Location = new System.Drawing.Point(15, 345);
            this.carDriveLabel1.Name = "carDriveLabel1";
            this.carDriveLabel1.Size = new System.Drawing.Size(60, 18);
            this.carDriveLabel1.TabIndex = 7;
            this.carDriveLabel1.Text = "Привод:";
            // 
            // carEngineInfoLabel1
            // 
            this.carEngineInfoLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.carEngineInfoLabel1.ForeColor = System.Drawing.Color.Black;
            this.carEngineInfoLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carEngineInfoLabel1.Location = new System.Drawing.Point(133, 305);
            this.carEngineInfoLabel1.Name = "carEngineInfoLabel1";
            this.carEngineInfoLabel1.Size = new System.Drawing.Size(121, 20);
            this.carEngineInfoLabel1.TabIndex = 6;
            this.carEngineInfoLabel1.Text = "Электрический";
            this.carEngineInfoLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // carEngineLabel1
            // 
            this.carEngineLabel1.AutoSize = true;
            this.carEngineLabel1.Font = new System.Drawing.Font("Candara", 11.25F);
            this.carEngineLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carEngineLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carEngineLabel1.Location = new System.Drawing.Point(15, 307);
            this.carEngineLabel1.Name = "carEngineLabel1";
            this.carEngineLabel1.Size = new System.Drawing.Size(80, 18);
            this.carEngineLabel1.TabIndex = 5;
            this.carEngineLabel1.Text = "Двигатель:";
            // 
            // carFuelInfoLabel1
            // 
            this.carFuelInfoLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.carFuelInfoLabel1.ForeColor = System.Drawing.Color.Black;
            this.carFuelInfoLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carFuelInfoLabel1.Location = new System.Drawing.Point(137, 268);
            this.carFuelInfoLabel1.Name = "carFuelInfoLabel1";
            this.carFuelInfoLabel1.Size = new System.Drawing.Size(117, 20);
            this.carFuelInfoLabel1.TabIndex = 4;
            this.carFuelInfoLabel1.Text = "Электричество";
            this.carFuelInfoLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // carYearLabel1
            // 
            this.carYearLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.carYearLabel1.ForeColor = System.Drawing.Color.Black;
            this.carYearLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carYearLabel1.Location = new System.Drawing.Point(122, 192);
            this.carYearLabel1.Name = "carYearLabel1";
            this.carYearLabel1.Size = new System.Drawing.Size(36, 17);
            this.carYearLabel1.TabIndex = 25;
            this.carYearLabel1.Text = "2021";
            this.carYearLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // carFuelLabel1
            // 
            this.carFuelLabel1.AutoSize = true;
            this.carFuelLabel1.Font = new System.Drawing.Font("Candara", 11.25F);
            this.carFuelLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.carFuelLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carFuelLabel1.Location = new System.Drawing.Point(15, 270);
            this.carFuelLabel1.Name = "carFuelLabel1";
            this.carFuelLabel1.Size = new System.Drawing.Size(67, 18);
            this.carFuelLabel1.TabIndex = 3;
            this.carFuelLabel1.Text = "Топливо:";
            // 
            // carNameLabel1
            // 
            this.carNameLabel1.Font = new System.Drawing.Font("Candara", 12F);
            this.carNameLabel1.ForeColor = System.Drawing.Color.Black;
            this.carNameLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carNameLabel1.Location = new System.Drawing.Point(73, 173);
            this.carNameLabel1.Name = "carNameLabel1";
            this.carNameLabel1.Size = new System.Drawing.Size(168, 19);
            this.carNameLabel1.TabIndex = 24;
            this.carNameLabel1.Text = "Toyota Highlander XSE";
            this.carNameLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // carBrandPictureBox1
            // 
            this.carBrandPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("carBrandPictureBox1.Image")));
            this.carBrandPictureBox1.ImageRotate = 0F;
            this.carBrandPictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carBrandPictureBox1.Location = new System.Drawing.Point(35, 172);
            this.carBrandPictureBox1.Name = "carBrandPictureBox1";
            this.carBrandPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.carBrandPictureBox1.TabIndex = 23;
            this.carBrandPictureBox1.TabStop = false;
            // 
            // mileageInfoLabel1
            // 
            this.mileageInfoLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.mileageInfoLabel1.ForeColor = System.Drawing.Color.Black;
            this.mileageInfoLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mileageInfoLabel1.Location = new System.Drawing.Point(137, 232);
            this.mileageInfoLabel1.Name = "mileageInfoLabel1";
            this.mileageInfoLabel1.Size = new System.Drawing.Size(119, 20);
            this.mileageInfoLabel1.TabIndex = 2;
            this.mileageInfoLabel1.Text = "10000 км";
            this.mileageInfoLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // mileageLabel1
            // 
            this.mileageLabel1.AutoSize = true;
            this.mileageLabel1.Font = new System.Drawing.Font("Candara", 11.25F);
            this.mileageLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mileageLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mileageLabel1.Location = new System.Drawing.Point(15, 234);
            this.mileageLabel1.Name = "mileageLabel1";
            this.mileageLabel1.Size = new System.Drawing.Size(59, 18);
            this.mileageLabel1.TabIndex = 1;
            this.mileageLabel1.Text = "Пробег:";
            // 
            // carPictureBox1
            // 
            this.carPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.carPictureBox1.BorderRadius = 30;
            this.carPictureBox1.CustomizableEdges.BottomLeft = false;
            this.carPictureBox1.CustomizableEdges.BottomRight = false;
            this.carPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("carPictureBox1.Image")));
            this.carPictureBox1.ImageRotate = 0F;
            this.carPictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.carPictureBox1.Location = new System.Drawing.Point(3, 0);
            this.carPictureBox1.Name = "carPictureBox1";
            this.carPictureBox1.Size = new System.Drawing.Size(262, 153);
            this.carPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carPictureBox1.TabIndex = 0;
            this.carPictureBox1.TabStop = false;
            // 
            // CurrentPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.carPanel1);
            this.Controls.Add(this.PlaylisTag);
            this.Name = "CurrentPlaylist";
            this.Text = "CurrentPlaylist";
            this.carPanel1.ResumeLayout(false);
            this.carPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carBrandPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlaylisTag;
        private Guna.UI2.WinForms.Guna2Panel carPanel1;
        private Guna.UI2.WinForms.Guna2Button detailsBtn1;
        private System.Windows.Forms.Label carPriceInfoLabel1;
        private System.Windows.Forms.Label carPriceLabel1;
        private System.Windows.Forms.Label carDriveInfoLabel1;
        private System.Windows.Forms.Label carDriveLabel1;
        private System.Windows.Forms.Label carEngineInfoLabel1;
        private System.Windows.Forms.Label carEngineLabel1;
        private System.Windows.Forms.Label carFuelInfoLabel1;
        private System.Windows.Forms.Label carYearLabel1;
        private System.Windows.Forms.Label carFuelLabel1;
        private System.Windows.Forms.Label carNameLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox carBrandPictureBox1;
        private System.Windows.Forms.Label mileageInfoLabel1;
        private System.Windows.Forms.Label mileageLabel1;
        private Guna.UI2.WinForms.Guna2PictureBox carPictureBox1;
    }
}