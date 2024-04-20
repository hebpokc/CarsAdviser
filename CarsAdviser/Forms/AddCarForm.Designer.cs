
namespace CarsAdviser.Forms
{
    partial class AddCarForm
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
            this.carBrandComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carBrandLabel = new System.Windows.Forms.Label();
            this.carModelLabel = new System.Windows.Forms.Label();
            this.carModelComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carEngineLabel = new System.Windows.Forms.Label();
            this.carEngineComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carBodyLabel = new System.Windows.Forms.Label();
            this.carBodyComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carDriveLabel = new System.Windows.Forms.Label();
            this.carDriveComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carFuelLabel = new System.Windows.Forms.Label();
            this.carFuelComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carWheelLabel = new System.Windows.Forms.Label();
            this.carWheelComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carTransmissionLabel = new System.Windows.Forms.Label();
            this.carTransmissionComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carColorLabel = new System.Windows.Forms.Label();
            this.carColorComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.carTrunkLabel = new System.Windows.Forms.Label();
            this.carTrunkTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carEnginePowerTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carEnginePowerLabel = new System.Windows.Forms.Label();
            this.carQtyPlacesTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carQtyPlacesLabel = new System.Windows.Forms.Label();
            this.carYearTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carYearLabel = new System.Windows.Forms.Label();
            this.carPriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carPriceLabel = new System.Windows.Forms.Label();
            this.carMileageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.carMileageLabel = new System.Windows.Forms.Label();
            this.carDescriptionLabel = new System.Windows.Forms.Label();
            this.carDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addPhotoBtn = new Guna.UI2.WinForms.Guna2Button();
            this.addCarBtn = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // preferencesLabel
            // 
            this.preferencesLabel.AutoSize = true;
            this.preferencesLabel.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.preferencesLabel.Location = new System.Drawing.Point(250, 61);
            this.preferencesLabel.Name = "preferencesLabel";
            this.preferencesLabel.Size = new System.Drawing.Size(190, 33);
            this.preferencesLabel.TabIndex = 16;
            this.preferencesLabel.Text = "Добавить авто";
            // 
            // carBrandComboBox
            // 
            this.carBrandComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carBrandComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carBrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carBrandComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carBrandComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carBrandComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carBrandComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carBrandComboBox.ItemHeight = 30;
            this.carBrandComboBox.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Chevrolet",
            "Ford",
            "Honda",
            "Hyundai",
            "Jeep",
            "Kia",
            "Lexus",
            "Mercedes-Benz",
            "Nissan",
            "Subaru",
            "Tesla",
            "Toyota",
            "Volkswagen"});
            this.carBrandComboBox.Location = new System.Drawing.Point(256, 145);
            this.carBrandComboBox.Name = "carBrandComboBox";
            this.carBrandComboBox.Size = new System.Drawing.Size(210, 36);
            this.carBrandComboBox.Sorted = true;
            this.carBrandComboBox.TabIndex = 17;
            this.carBrandComboBox.SelectedIndexChanged += new System.EventHandler(this.carBrandComboBox_SelectedIndexChanged);
            // 
            // carBrandLabel
            // 
            this.carBrandLabel.AutoSize = true;
            this.carBrandLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carBrandLabel.Location = new System.Drawing.Point(252, 123);
            this.carBrandLabel.Name = "carBrandLabel";
            this.carBrandLabel.Size = new System.Drawing.Size(91, 19);
            this.carBrandLabel.TabIndex = 18;
            this.carBrandLabel.Text = "Марка авто";
            // 
            // carModelLabel
            // 
            this.carModelLabel.AutoSize = true;
            this.carModelLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carModelLabel.Location = new System.Drawing.Point(604, 123);
            this.carModelLabel.Name = "carModelLabel";
            this.carModelLabel.Size = new System.Drawing.Size(99, 19);
            this.carModelLabel.TabIndex = 20;
            this.carModelLabel.Text = "Модель авто";
            // 
            // carModelComboBox
            // 
            this.carModelComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carModelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carModelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carModelComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carModelComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carModelComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carModelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carModelComboBox.ItemHeight = 30;
            this.carModelComboBox.Location = new System.Drawing.Point(608, 145);
            this.carModelComboBox.Name = "carModelComboBox";
            this.carModelComboBox.Size = new System.Drawing.Size(210, 36);
            this.carModelComboBox.Sorted = true;
            this.carModelComboBox.TabIndex = 19;
            // 
            // carEngineLabel
            // 
            this.carEngineLabel.AutoSize = true;
            this.carEngineLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carEngineLabel.Location = new System.Drawing.Point(604, 225);
            this.carEngineLabel.Name = "carEngineLabel";
            this.carEngineLabel.Size = new System.Drawing.Size(106, 19);
            this.carEngineLabel.TabIndex = 24;
            this.carEngineLabel.Text = "Тип двигателя";
            // 
            // carEngineComboBox
            // 
            this.carEngineComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carEngineComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carEngineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carEngineComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carEngineComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carEngineComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carEngineComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carEngineComboBox.ItemHeight = 30;
            this.carEngineComboBox.Items.AddRange(new object[] {
            "Бензиновый",
            "Дизельный",
            "Гибридный",
            "Электрический",
            "Водородный"});
            this.carEngineComboBox.Location = new System.Drawing.Point(608, 247);
            this.carEngineComboBox.Name = "carEngineComboBox";
            this.carEngineComboBox.Size = new System.Drawing.Size(210, 36);
            this.carEngineComboBox.TabIndex = 23;
            // 
            // carBodyLabel
            // 
            this.carBodyLabel.AutoSize = true;
            this.carBodyLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carBodyLabel.Location = new System.Drawing.Point(252, 225);
            this.carBodyLabel.Name = "carBodyLabel";
            this.carBodyLabel.Size = new System.Drawing.Size(83, 19);
            this.carBodyLabel.TabIndex = 22;
            this.carBodyLabel.Text = "Тип кузова";
            // 
            // carBodyComboBox
            // 
            this.carBodyComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carBodyComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carBodyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carBodyComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carBodyComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carBodyComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carBodyComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carBodyComboBox.ItemHeight = 30;
            this.carBodyComboBox.Items.AddRange(new object[] {
            "Седан",
            "Хэтчбек",
            "Универсал",
            "Внедорожник",
            "Кроссовер",
            "Купе",
            "Пикап",
            "Минивэн"});
            this.carBodyComboBox.Location = new System.Drawing.Point(256, 247);
            this.carBodyComboBox.Name = "carBodyComboBox";
            this.carBodyComboBox.Size = new System.Drawing.Size(210, 36);
            this.carBodyComboBox.TabIndex = 21;
            // 
            // carDriveLabel
            // 
            this.carDriveLabel.AutoSize = true;
            this.carDriveLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carDriveLabel.Location = new System.Drawing.Point(604, 326);
            this.carDriveLabel.Name = "carDriveLabel";
            this.carDriveLabel.Size = new System.Drawing.Size(62, 19);
            this.carDriveLabel.TabIndex = 28;
            this.carDriveLabel.Text = "Привод";
            // 
            // carDriveComboBox
            // 
            this.carDriveComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carDriveComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carDriveComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carDriveComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carDriveComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carDriveComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carDriveComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carDriveComboBox.ItemHeight = 30;
            this.carDriveComboBox.Items.AddRange(new object[] {
            "Передний",
            "Задний",
            "Полный"});
            this.carDriveComboBox.Location = new System.Drawing.Point(608, 348);
            this.carDriveComboBox.Name = "carDriveComboBox";
            this.carDriveComboBox.Size = new System.Drawing.Size(210, 36);
            this.carDriveComboBox.TabIndex = 27;
            // 
            // carFuelLabel
            // 
            this.carFuelLabel.AutoSize = true;
            this.carFuelLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carFuelLabel.Location = new System.Drawing.Point(252, 326);
            this.carFuelLabel.Name = "carFuelLabel";
            this.carFuelLabel.Size = new System.Drawing.Size(67, 19);
            this.carFuelLabel.TabIndex = 26;
            this.carFuelLabel.Text = "Топливо";
            // 
            // carFuelComboBox
            // 
            this.carFuelComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carFuelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carFuelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carFuelComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carFuelComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carFuelComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carFuelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carFuelComboBox.ItemHeight = 30;
            this.carFuelComboBox.Items.AddRange(new object[] {
            "Бензин",
            "Дизельное топливо",
            "Электричество",
            "Гибридное топливо",
            "Водород"});
            this.carFuelComboBox.Location = new System.Drawing.Point(256, 348);
            this.carFuelComboBox.Name = "carFuelComboBox";
            this.carFuelComboBox.Size = new System.Drawing.Size(210, 36);
            this.carFuelComboBox.TabIndex = 25;
            // 
            // carWheelLabel
            // 
            this.carWheelLabel.AutoSize = true;
            this.carWheelLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carWheelLabel.Location = new System.Drawing.Point(604, 425);
            this.carWheelLabel.Name = "carWheelLabel";
            this.carWheelLabel.Size = new System.Drawing.Size(40, 19);
            this.carWheelLabel.TabIndex = 32;
            this.carWheelLabel.Text = "Руль";
            // 
            // carWheelComboBox
            // 
            this.carWheelComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carWheelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carWheelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carWheelComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carWheelComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carWheelComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carWheelComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carWheelComboBox.ItemHeight = 30;
            this.carWheelComboBox.Items.AddRange(new object[] {
            "Левый",
            "Правый"});
            this.carWheelComboBox.Location = new System.Drawing.Point(608, 447);
            this.carWheelComboBox.Name = "carWheelComboBox";
            this.carWheelComboBox.Size = new System.Drawing.Size(210, 36);
            this.carWheelComboBox.TabIndex = 31;
            // 
            // carTransmissionLabel
            // 
            this.carTransmissionLabel.AutoSize = true;
            this.carTransmissionLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carTransmissionLabel.Location = new System.Drawing.Point(252, 425);
            this.carTransmissionLabel.Name = "carTransmissionLabel";
            this.carTransmissionLabel.Size = new System.Drawing.Size(39, 19);
            this.carTransmissionLabel.TabIndex = 30;
            this.carTransmissionLabel.Text = "КПП";
            // 
            // carTransmissionComboBox
            // 
            this.carTransmissionComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carTransmissionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carTransmissionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carTransmissionComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carTransmissionComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carTransmissionComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carTransmissionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carTransmissionComboBox.ItemHeight = 30;
            this.carTransmissionComboBox.Items.AddRange(new object[] {
            "Механическая",
            "Автоматическая"});
            this.carTransmissionComboBox.Location = new System.Drawing.Point(256, 447);
            this.carTransmissionComboBox.Name = "carTransmissionComboBox";
            this.carTransmissionComboBox.Size = new System.Drawing.Size(210, 36);
            this.carTransmissionComboBox.TabIndex = 29;
            // 
            // carColorLabel
            // 
            this.carColorLabel.AutoSize = true;
            this.carColorLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carColorLabel.Location = new System.Drawing.Point(252, 524);
            this.carColorLabel.Name = "carColorLabel";
            this.carColorLabel.Size = new System.Drawing.Size(42, 19);
            this.carColorLabel.TabIndex = 34;
            this.carColorLabel.Text = "Цвет";
            // 
            // carColorComboBox
            // 
            this.carColorComboBox.BackColor = System.Drawing.Color.Transparent;
            this.carColorComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.carColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carColorComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carColorComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carColorComboBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.carColorComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.carColorComboBox.ItemHeight = 30;
            this.carColorComboBox.Items.AddRange(new object[] {
            "Черный",
            "Белый",
            "Серебристый",
            "Серый",
            "Синий",
            "Красный",
            "Зеленый",
            "Коричневый",
            "Бежевый",
            "Золотистый",
            "Оранжевый",
            "Желтый"});
            this.carColorComboBox.Location = new System.Drawing.Point(256, 546);
            this.carColorComboBox.Name = "carColorComboBox";
            this.carColorComboBox.Size = new System.Drawing.Size(210, 36);
            this.carColorComboBox.TabIndex = 33;
            // 
            // carTrunkLabel
            // 
            this.carTrunkLabel.AutoSize = true;
            this.carTrunkLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carTrunkLabel.Location = new System.Drawing.Point(252, 613);
            this.carTrunkLabel.Name = "carTrunkLabel";
            this.carTrunkLabel.Size = new System.Drawing.Size(192, 19);
            this.carTrunkLabel.TabIndex = 35;
            this.carTrunkLabel.Text = "Вместимость багажника, л";
            // 
            // carTrunkTextBox
            // 
            this.carTrunkTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carTrunkTextBox.DefaultText = "";
            this.carTrunkTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carTrunkTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carTrunkTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carTrunkTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carTrunkTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carTrunkTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carTrunkTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carTrunkTextBox.Location = new System.Drawing.Point(256, 648);
            this.carTrunkTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carTrunkTextBox.Name = "carTrunkTextBox";
            this.carTrunkTextBox.PasswordChar = '\0';
            this.carTrunkTextBox.PlaceholderText = "";
            this.carTrunkTextBox.SelectedText = "";
            this.carTrunkTextBox.Size = new System.Drawing.Size(210, 36);
            this.carTrunkTextBox.TabIndex = 36;
            // 
            // carEnginePowerTextBox
            // 
            this.carEnginePowerTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carEnginePowerTextBox.DefaultText = "";
            this.carEnginePowerTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carEnginePowerTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carEnginePowerTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carEnginePowerTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carEnginePowerTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carEnginePowerTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carEnginePowerTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carEnginePowerTextBox.Location = new System.Drawing.Point(608, 648);
            this.carEnginePowerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carEnginePowerTextBox.Name = "carEnginePowerTextBox";
            this.carEnginePowerTextBox.PasswordChar = '\0';
            this.carEnginePowerTextBox.PlaceholderText = "";
            this.carEnginePowerTextBox.SelectedText = "";
            this.carEnginePowerTextBox.Size = new System.Drawing.Size(210, 36);
            this.carEnginePowerTextBox.TabIndex = 38;
            // 
            // carEnginePowerLabel
            // 
            this.carEnginePowerLabel.AutoSize = true;
            this.carEnginePowerLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carEnginePowerLabel.Location = new System.Drawing.Point(604, 613);
            this.carEnginePowerLabel.Name = "carEnginePowerLabel";
            this.carEnginePowerLabel.Size = new System.Drawing.Size(182, 19);
            this.carEnginePowerLabel.TabIndex = 37;
            this.carEnginePowerLabel.Text = "Мощность двигателя, л.с";
            // 
            // carQtyPlacesTextBox
            // 
            this.carQtyPlacesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carQtyPlacesTextBox.DefaultText = "";
            this.carQtyPlacesTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carQtyPlacesTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carQtyPlacesTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carQtyPlacesTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carQtyPlacesTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carQtyPlacesTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carQtyPlacesTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carQtyPlacesTextBox.Location = new System.Drawing.Point(608, 748);
            this.carQtyPlacesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carQtyPlacesTextBox.Name = "carQtyPlacesTextBox";
            this.carQtyPlacesTextBox.PasswordChar = '\0';
            this.carQtyPlacesTextBox.PlaceholderText = "";
            this.carQtyPlacesTextBox.SelectedText = "";
            this.carQtyPlacesTextBox.Size = new System.Drawing.Size(210, 36);
            this.carQtyPlacesTextBox.TabIndex = 42;
            // 
            // carQtyPlacesLabel
            // 
            this.carQtyPlacesLabel.AutoSize = true;
            this.carQtyPlacesLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carQtyPlacesLabel.Location = new System.Drawing.Point(604, 713);
            this.carQtyPlacesLabel.Name = "carQtyPlacesLabel";
            this.carQtyPlacesLabel.Size = new System.Drawing.Size(127, 19);
            this.carQtyPlacesLabel.TabIndex = 41;
            this.carQtyPlacesLabel.Text = "Количество мест";
            // 
            // carYearTextBox
            // 
            this.carYearTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carYearTextBox.DefaultText = "";
            this.carYearTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carYearTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carYearTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carYearTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carYearTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carYearTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carYearTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carYearTextBox.Location = new System.Drawing.Point(256, 748);
            this.carYearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carYearTextBox.Name = "carYearTextBox";
            this.carYearTextBox.PasswordChar = '\0';
            this.carYearTextBox.PlaceholderText = "";
            this.carYearTextBox.SelectedText = "";
            this.carYearTextBox.Size = new System.Drawing.Size(210, 36);
            this.carYearTextBox.TabIndex = 40;
            // 
            // carYearLabel
            // 
            this.carYearLabel.AutoSize = true;
            this.carYearLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carYearLabel.Location = new System.Drawing.Point(252, 713);
            this.carYearLabel.Name = "carYearLabel";
            this.carYearLabel.Size = new System.Drawing.Size(35, 19);
            this.carYearLabel.TabIndex = 39;
            this.carYearLabel.Text = "Год";
            // 
            // carPriceTextBox
            // 
            this.carPriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carPriceTextBox.DefaultText = "";
            this.carPriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carPriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carPriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carPriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carPriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carPriceTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carPriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carPriceTextBox.Location = new System.Drawing.Point(608, 847);
            this.carPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carPriceTextBox.Name = "carPriceTextBox";
            this.carPriceTextBox.PasswordChar = '\0';
            this.carPriceTextBox.PlaceholderText = "";
            this.carPriceTextBox.SelectedText = "";
            this.carPriceTextBox.Size = new System.Drawing.Size(210, 36);
            this.carPriceTextBox.TabIndex = 46;
            // 
            // carPriceLabel
            // 
            this.carPriceLabel.AutoSize = true;
            this.carPriceLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carPriceLabel.Location = new System.Drawing.Point(604, 812);
            this.carPriceLabel.Name = "carPriceLabel";
            this.carPriceLabel.Size = new System.Drawing.Size(119, 19);
            this.carPriceLabel.TabIndex = 45;
            this.carPriceLabel.Text = "Стоимость, руб.";
            // 
            // carMileageTextBox
            // 
            this.carMileageTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.carMileageTextBox.DefaultText = "";
            this.carMileageTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.carMileageTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.carMileageTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carMileageTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.carMileageTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carMileageTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carMileageTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.carMileageTextBox.Location = new System.Drawing.Point(256, 847);
            this.carMileageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.carMileageTextBox.Name = "carMileageTextBox";
            this.carMileageTextBox.PasswordChar = '\0';
            this.carMileageTextBox.PlaceholderText = "";
            this.carMileageTextBox.SelectedText = "";
            this.carMileageTextBox.Size = new System.Drawing.Size(210, 36);
            this.carMileageTextBox.TabIndex = 44;
            // 
            // carMileageLabel
            // 
            this.carMileageLabel.AutoSize = true;
            this.carMileageLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carMileageLabel.Location = new System.Drawing.Point(252, 812);
            this.carMileageLabel.Name = "carMileageLabel";
            this.carMileageLabel.Size = new System.Drawing.Size(86, 19);
            this.carMileageLabel.TabIndex = 43;
            this.carMileageLabel.Text = "Пробег, км";
            // 
            // carDescriptionLabel
            // 
            this.carDescriptionLabel.AutoSize = true;
            this.carDescriptionLabel.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carDescriptionLabel.Location = new System.Drawing.Point(257, 927);
            this.carDescriptionLabel.Name = "carDescriptionLabel";
            this.carDescriptionLabel.Size = new System.Drawing.Size(75, 19);
            this.carDescriptionLabel.TabIndex = 47;
            this.carDescriptionLabel.Text = "Описание";
            // 
            // carDescriptionRichTextBox
            // 
            this.carDescriptionRichTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.carDescriptionRichTextBox.Location = new System.Drawing.Point(256, 949);
            this.carDescriptionRichTextBox.Name = "carDescriptionRichTextBox";
            this.carDescriptionRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.carDescriptionRichTextBox.Size = new System.Drawing.Size(562, 37);
            this.carDescriptionRichTextBox.TabIndex = 48;
            this.carDescriptionRichTextBox.Text = "";
            this.carDescriptionRichTextBox.Enter += new System.EventHandler(this.carDescriptionRichTextBox_Enter);
            this.carDescriptionRichTextBox.Leave += new System.EventHandler(this.carDescriptionRichTextBox_Leave);
            // 
            // addPhotoBtn
            // 
            this.addPhotoBtn.BorderRadius = 15;
            this.addPhotoBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addPhotoBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addPhotoBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addPhotoBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addPhotoBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.addPhotoBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPhotoBtn.ForeColor = System.Drawing.Color.White;
            this.addPhotoBtn.Location = new System.Drawing.Point(392, 1050);
            this.addPhotoBtn.Name = "addPhotoBtn";
            this.addPhotoBtn.Size = new System.Drawing.Size(311, 45);
            this.addPhotoBtn.TabIndex = 49;
            this.addPhotoBtn.Text = "Добавить фото";
            this.addPhotoBtn.Click += new System.EventHandler(this.addPhotoBtn_Click);
            // 
            // addCarBtn
            // 
            this.addCarBtn.BorderRadius = 15;
            this.addCarBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addCarBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addCarBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addCarBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.addCarBtn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCarBtn.ForeColor = System.Drawing.Color.White;
            this.addCarBtn.Location = new System.Drawing.Point(392, 1120);
            this.addCarBtn.Name = "addCarBtn";
            this.addCarBtn.Size = new System.Drawing.Size(311, 45);
            this.addCarBtn.TabIndex = 50;
            this.addCarBtn.Text = "Добавить машину";
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(981, 1411);
            this.Controls.Add(this.addCarBtn);
            this.Controls.Add(this.addPhotoBtn);
            this.Controls.Add(this.carDescriptionRichTextBox);
            this.Controls.Add(this.carDescriptionLabel);
            this.Controls.Add(this.carPriceTextBox);
            this.Controls.Add(this.carPriceLabel);
            this.Controls.Add(this.carMileageTextBox);
            this.Controls.Add(this.carMileageLabel);
            this.Controls.Add(this.carQtyPlacesTextBox);
            this.Controls.Add(this.carQtyPlacesLabel);
            this.Controls.Add(this.carYearTextBox);
            this.Controls.Add(this.carYearLabel);
            this.Controls.Add(this.carEnginePowerTextBox);
            this.Controls.Add(this.carEnginePowerLabel);
            this.Controls.Add(this.carTrunkTextBox);
            this.Controls.Add(this.carTrunkLabel);
            this.Controls.Add(this.carColorLabel);
            this.Controls.Add(this.carColorComboBox);
            this.Controls.Add(this.carWheelLabel);
            this.Controls.Add(this.carWheelComboBox);
            this.Controls.Add(this.carTransmissionLabel);
            this.Controls.Add(this.carTransmissionComboBox);
            this.Controls.Add(this.carDriveLabel);
            this.Controls.Add(this.carDriveComboBox);
            this.Controls.Add(this.carFuelLabel);
            this.Controls.Add(this.carFuelComboBox);
            this.Controls.Add(this.carEngineLabel);
            this.Controls.Add(this.carEngineComboBox);
            this.Controls.Add(this.carBodyLabel);
            this.Controls.Add(this.carBodyComboBox);
            this.Controls.Add(this.carModelLabel);
            this.Controls.Add(this.carModelComboBox);
            this.Controls.Add(this.carBrandLabel);
            this.Controls.Add(this.carBrandComboBox);
            this.Controls.Add(this.preferencesLabel);
            this.MaximumSize = new System.Drawing.Size(997, 1450);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label preferencesLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carBrandComboBox;
        private System.Windows.Forms.Label carBrandLabel;
        private System.Windows.Forms.Label carModelLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carModelComboBox;
        private System.Windows.Forms.Label carEngineLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carEngineComboBox;
        private System.Windows.Forms.Label carBodyLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carBodyComboBox;
        private System.Windows.Forms.Label carDriveLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carDriveComboBox;
        private System.Windows.Forms.Label carFuelLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carFuelComboBox;
        private System.Windows.Forms.Label carWheelLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carWheelComboBox;
        private System.Windows.Forms.Label carTransmissionLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carTransmissionComboBox;
        private System.Windows.Forms.Label carColorLabel;
        private Guna.UI2.WinForms.Guna2ComboBox carColorComboBox;
        private System.Windows.Forms.Label carTrunkLabel;
        private Guna.UI2.WinForms.Guna2TextBox carTrunkTextBox;
        private Guna.UI2.WinForms.Guna2TextBox carEnginePowerTextBox;
        private System.Windows.Forms.Label carEnginePowerLabel;
        private Guna.UI2.WinForms.Guna2TextBox carQtyPlacesTextBox;
        private System.Windows.Forms.Label carQtyPlacesLabel;
        private Guna.UI2.WinForms.Guna2TextBox carYearTextBox;
        private System.Windows.Forms.Label carYearLabel;
        private Guna.UI2.WinForms.Guna2TextBox carPriceTextBox;
        private System.Windows.Forms.Label carPriceLabel;
        private Guna.UI2.WinForms.Guna2TextBox carMileageTextBox;
        private System.Windows.Forms.Label carMileageLabel;
        private System.Windows.Forms.Label carDescriptionLabel;
        private System.Windows.Forms.RichTextBox carDescriptionRichTextBox;
        private Guna.UI2.WinForms.Guna2Button addPhotoBtn;
        private Guna.UI2.WinForms.Guna2Button addCarBtn;
    }
}