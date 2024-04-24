
namespace CarsAdviser.Forms
{
    partial class DataFillingForm
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
            this.uploadAvatarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.saveBtn = new Guna.UI2.WinForms.Guna2Button();
            this.cityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.phoneTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.emailTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.patronymicTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.nameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.surnameTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.fillDataLabel = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel1 = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel2 = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel3 = new System.Windows.Forms.Label();
            this.mandatoryFillingLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uploadAvatarBtn
            // 
            this.uploadAvatarBtn.Animated = true;
            this.uploadAvatarBtn.BorderRadius = 15;
            this.uploadAvatarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.uploadAvatarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.uploadAvatarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.uploadAvatarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.uploadAvatarBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.uploadAvatarBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uploadAvatarBtn.ForeColor = System.Drawing.Color.White;
            this.uploadAvatarBtn.Location = new System.Drawing.Point(288, 541);
            this.uploadAvatarBtn.Name = "uploadAvatarBtn";
            this.uploadAvatarBtn.Size = new System.Drawing.Size(311, 45);
            this.uploadAvatarBtn.TabIndex = 22;
            this.uploadAvatarBtn.Text = "Загрузить аватар";
            this.uploadAvatarBtn.Click += new System.EventHandler(this.uploadAvatarBtn_Click);
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
            this.saveBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(288, 611);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(311, 45);
            this.saveBtn.TabIndex = 21;
            this.saveBtn.Text = "Готово";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cityTextBox
            // 
            this.cityTextBox.Animated = true;
            this.cityTextBox.BorderRadius = 10;
            this.cityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cityTextBox.DefaultText = "";
            this.cityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.cityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.cityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.cityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cityTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cityTextBox.ForeColor = System.Drawing.Color.Black;
            this.cityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cityTextBox.Location = new System.Drawing.Point(288, 470);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.PasswordChar = '\0';
            this.cityTextBox.PlaceholderText = "Город";
            this.cityTextBox.SelectedText = "";
            this.cityTextBox.Size = new System.Drawing.Size(311, 36);
            this.cityTextBox.TabIndex = 20;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Animated = true;
            this.phoneTextBox.BorderRadius = 10;
            this.phoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTextBox.DefaultText = "";
            this.phoneTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phoneTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phoneTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phoneTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.ForeColor = System.Drawing.Color.Black;
            this.phoneTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phoneTextBox.Location = new System.Drawing.Point(288, 400);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.PasswordChar = '\0';
            this.phoneTextBox.PlaceholderText = "Телефон";
            this.phoneTextBox.SelectedText = "";
            this.phoneTextBox.Size = new System.Drawing.Size(311, 36);
            this.phoneTextBox.TabIndex = 19;
            this.phoneTextBox.Leave += new System.EventHandler(this.phoneTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Animated = true;
            this.emailTextBox.BorderRadius = 10;
            this.emailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.emailTextBox.DefaultText = "";
            this.emailTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.emailTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.emailTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.emailTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.emailTextBox.Location = new System.Drawing.Point(288, 330);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.PasswordChar = '\0';
            this.emailTextBox.PlaceholderText = "Почта";
            this.emailTextBox.SelectedText = "";
            this.emailTextBox.Size = new System.Drawing.Size(311, 36);
            this.emailTextBox.TabIndex = 18;
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.Animated = true;
            this.patronymicTextBox.BorderRadius = 10;
            this.patronymicTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.patronymicTextBox.DefaultText = "";
            this.patronymicTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.patronymicTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.patronymicTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patronymicTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.patronymicTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patronymicTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicTextBox.ForeColor = System.Drawing.Color.Black;
            this.patronymicTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.patronymicTextBox.Location = new System.Drawing.Point(288, 262);
            this.patronymicTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.PasswordChar = '\0';
            this.patronymicTextBox.PlaceholderText = "Отчество";
            this.patronymicTextBox.SelectedText = "";
            this.patronymicTextBox.Size = new System.Drawing.Size(311, 36);
            this.patronymicTextBox.TabIndex = 17;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Animated = true;
            this.nameTextBox.BorderRadius = 10;
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DefaultText = "";
            this.nameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.ForeColor = System.Drawing.Color.Black;
            this.nameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nameTextBox.Location = new System.Drawing.Point(288, 196);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.PlaceholderText = "Имя";
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.Size = new System.Drawing.Size(311, 36);
            this.nameTextBox.TabIndex = 16;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Animated = true;
            this.surnameTextBox.BorderRadius = 10;
            this.surnameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTextBox.DefaultText = "";
            this.surnameTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.surnameTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.surnameTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.surnameTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.Black;
            this.surnameTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.surnameTextBox.Location = new System.Drawing.Point(288, 133);
            this.surnameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.PasswordChar = '\0';
            this.surnameTextBox.PlaceholderText = "Фамилия";
            this.surnameTextBox.SelectedText = "";
            this.surnameTextBox.Size = new System.Drawing.Size(311, 36);
            this.surnameTextBox.TabIndex = 15;
            // 
            // fillDataLabel
            // 
            this.fillDataLabel.AutoSize = true;
            this.fillDataLabel.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fillDataLabel.Location = new System.Drawing.Point(282, 63);
            this.fillDataLabel.Name = "fillDataLabel";
            this.fillDataLabel.Size = new System.Drawing.Size(317, 33);
            this.fillDataLabel.TabIndex = 14;
            this.fillDataLabel.Text = "Заполните данные о себе";
            // 
            // mandatoryFillingLabel1
            // 
            this.mandatoryFillingLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel1.AutoSize = true;
            this.mandatoryFillingLabel1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel1.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel1.Location = new System.Drawing.Point(632, 142);
            this.mandatoryFillingLabel1.Name = "mandatoryFillingLabel1";
            this.mandatoryFillingLabel1.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel1.TabIndex = 32;
            this.mandatoryFillingLabel1.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel1.Visible = false;
            // 
            // mandatoryFillingLabel2
            // 
            this.mandatoryFillingLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel2.AutoSize = true;
            this.mandatoryFillingLabel2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel2.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel2.Location = new System.Drawing.Point(632, 205);
            this.mandatoryFillingLabel2.Name = "mandatoryFillingLabel2";
            this.mandatoryFillingLabel2.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel2.TabIndex = 33;
            this.mandatoryFillingLabel2.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel2.Visible = false;
            // 
            // mandatoryFillingLabel3
            // 
            this.mandatoryFillingLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel3.AutoSize = true;
            this.mandatoryFillingLabel3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel3.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel3.Location = new System.Drawing.Point(632, 339);
            this.mandatoryFillingLabel3.Name = "mandatoryFillingLabel3";
            this.mandatoryFillingLabel3.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel3.TabIndex = 34;
            this.mandatoryFillingLabel3.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel3.Visible = false;
            // 
            // mandatoryFillingLabel4
            // 
            this.mandatoryFillingLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mandatoryFillingLabel4.AutoSize = true;
            this.mandatoryFillingLabel4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mandatoryFillingLabel4.ForeColor = System.Drawing.Color.Red;
            this.mandatoryFillingLabel4.Location = new System.Drawing.Point(632, 409);
            this.mandatoryFillingLabel4.Name = "mandatoryFillingLabel4";
            this.mandatoryFillingLabel4.Size = new System.Drawing.Size(261, 18);
            this.mandatoryFillingLabel4.TabIndex = 35;
            this.mandatoryFillingLabel4.Text = "Это поле обязательно для заполнения";
            this.mandatoryFillingLabel4.Visible = false;
            // 
            // DataFillingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 985);
            this.Controls.Add(this.mandatoryFillingLabel4);
            this.Controls.Add(this.mandatoryFillingLabel3);
            this.Controls.Add(this.mandatoryFillingLabel2);
            this.Controls.Add(this.mandatoryFillingLabel1);
            this.Controls.Add(this.uploadAvatarBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.fillDataLabel);
            this.Name = "DataFillingForm";
            this.Text = "DataFillingForm";
            this.Load += new System.EventHandler(this.DataFillingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button uploadAvatarBtn;
        private Guna.UI2.WinForms.Guna2Button saveBtn;
        private Guna.UI2.WinForms.Guna2TextBox cityTextBox;
        private Guna.UI2.WinForms.Guna2TextBox phoneTextBox;
        private Guna.UI2.WinForms.Guna2TextBox emailTextBox;
        private Guna.UI2.WinForms.Guna2TextBox patronymicTextBox;
        private Guna.UI2.WinForms.Guna2TextBox nameTextBox;
        private Guna.UI2.WinForms.Guna2TextBox surnameTextBox;
        private System.Windows.Forms.Label fillDataLabel;
        private System.Windows.Forms.Label mandatoryFillingLabel1;
        private System.Windows.Forms.Label mandatoryFillingLabel2;
        private System.Windows.Forms.Label mandatoryFillingLabel3;
        private System.Windows.Forms.Label mandatoryFillingLabel4;
    }
}