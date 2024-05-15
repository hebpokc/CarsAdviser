using CarsAdviser.Database;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace CarsAdviser.Forms
{
    public partial class AnnouncementForm : Form
    {
        private MainForm parentForm;
        private int carId;
        private int currentUserId;
        private List<Cars> similarToPreferences = null;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Helper helper = new Helper();
        public AnnouncementForm(MainForm parentFrom, int currentUserId)
        {
            InitializeComponent();
            this.parentForm = parentFrom;
            similarToPreferences = UserPreferencesStorage.GetUserPreferences();
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadCarDetails();
            logger.Info("Загрузка формы AnnouncementForm");
            this.currentUserId = currentUserId;
        }
        public void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void priceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            priceFromTextBox.Text = priceTrackBar1.Value.ToString();
            priceToTextBox.Text = priceTrackBar2.Value.ToString();
        }
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn != null)
            {
                carId = Convert.ToInt32(btn.Tag);
                parentForm.currentChildForm.Close();
                parentForm.OpenChildForm(new CarInfoForm(parentForm, carId));
            }
        }
        private bool IsPreferred()
        {
            try
            {
                using (var context = new AppContext())
                {
                    var hasPreferences = context.Users_preferences.Any(p => p.Users_id == parentForm.currentUserId);
                    return hasPreferences;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private List<Cars> cars = new List<Cars>();
        private void LoadCarDetails()
        {
            try
            {
                logger.Info("Загрузка машин");
                using (var context = new AppContext())
                {
                    bool isPreferred = IsPreferred();

                    var hiddenCars = context.Users_hidden_auto.Where(uha => uha.Users_id == parentForm.currentUserId)
                                                              .Select(uha => uha.Cars_id)
                                                              .ToList() ?? new List<int>();

                    if (isPreferred && similarToPreferences != null && similarToPreferences.Any())
                    {
                        cars = similarToPreferences.Where(c => !hiddenCars.Contains(c.ID)).ToList();
                    }
                    else
                    {
                        cars = context.Cars.Include(c => c.Cars_Model)
                                            .Include(c => c.Cars_Stamp)
                                            .Include(c => c.Cars_Body)
                                            .Include(c => c.Cars_Engine)
                                            .Include(c => c.Cars_Fuel)
                                            .Include(c => c.Cars_Drive)
                                            .Include(c => c.Cars_Checkpoint)
                                            .Include(c => c.Cars_Wheel)
                                            .Include(c => c.Cars_Colour)
                                            .Where(c => !hiddenCars.Contains(c.ID))
                                            .ToList();
                    }

                    foreach (var car in cars)
                    {

                        LoadCurrentCar(car);
                        
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error($"Не удалось загрузить машины: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCurrentCar(Cars car)
        {
            Guna2Panel carPanel = new Guna2Panel()
            {
                Size = new Size(268, 464),
                Margin = new Padding(3, 3, 50, 75),
                BorderRadius = 30,
                BorderThickness = 1, 
                BorderColor = Color.Black,
            };
            Guna2PictureBox carPictureBox = new Guna2PictureBox()
            {
                Size = new Size(265, 153),
                FillColor = Color.White,
                BorderRadius = 30,
                BackColor = Color.Transparent,
                CustomizableEdges = { TopLeft = true, TopRight = true, BottomRight = false, BottomLeft = false },
                Location = new Point(1, 1),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile(car.Photo_1)             
            };
            Label carYearLabel = new Label()
            {
                Location = new Point(75, 192),
                Font = new Font("Segoe UI", 10),
                Text = car.Year.ToString(),
            };
            Guna2PictureBox carStampPictureBox = new Guna2PictureBox()
            {
                Size = new Size(32, 32),
                FillColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(35, 172),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile(helper.GetStampImageLocation(car.Cars_Stamp.Stamp)),
            };
            Label carNameLabel = new Label()
            {
                Location = new Point(75, 173),
                Font = new Font("Candara", 12),
                Text = car.Cars_Stamp.Stamp + ' ' + car.Cars_Model.Model,
                Size = new Size(carPanel.Width - 85, 32),
                TextAlign = ContentAlignment.TopLeft
            };
            Label mileageLabel = new Label()
            {
                Location = new Point(15, 234),
                AutoSize = true,
                Text = "Пробег:",
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carFuelLabel = new Label()
            {
                Location = new Point(15, 270),
                AutoSize = true,
                Text = "Топливо:",
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carEngineLabel = new Label()
            {
                Location = new Point(15, 307),
                AutoSize = true,
                Text = "Двигатель:",
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carDriveLabel = new Label()
            {
                Location = new Point(15, 345),
                AutoSize = true,
                Text = "Привод:",
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carPriceLabel = new Label()
            {
                Location = new Point(15, 383),
                AutoSize = true,
                Text = "Итоговая цена:",
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label mileageInfoLabel = new Label()
            {
                Location = new Point(142, 234),
                Size = new Size(118, 20),
                Text = car.Mileage.ToString() + " км",
                ForeColor = Color.Black,
                Font = new Font("Candara", 12),
                TextAlign = ContentAlignment.TopRight
            };
            Label carFuelInfoLabel = new Label()
            {
                Location = new Point(138, 270),
                Size = new Size(118, 20),
                Text = car.Cars_Fuel.Fuel,
                ForeColor = Color.Black,
                Font = new Font("Candara", 12),
                TextAlign = ContentAlignment.TopRight
            };
            Label carEngineInfoLabel = new Label()
            {
                Location = new Point(138, 307),
                Size = new Size(118, 20),
                Text = car.Cars_Engine.Engine,
                ForeColor = Color.Black,
                Font = new Font("Candara", 12),
                TextAlign = ContentAlignment.TopRight
            };
            Label carDriveInfoLabel = new Label()
            {
                Location = new Point(142, 345),
                Size = new Size(118, 20),
                Text = car.Cars_Drive.Drive,
                ForeColor = Color.Black,
                Font = new Font("Candara", 12),
                TextAlign = ContentAlignment.TopRight
            };
            Label carPriceInfoLabel = new Label()
            {
                Location = new Point(142, 383),
                Size = new Size(118, 20),
                Text = car.Price.ToString() + " ₽",
                ForeColor = Color.Black,
                Font = new Font("Candara", 12),
                TextAlign = ContentAlignment.TopRight
            };
            Guna2Button detailsBtn = new Guna2Button()
            {
                Text = "ПОДРОБНЕЕ 🡽",
                Size = new Size(126, 34),
                FillColor = Color.Transparent,
                ForeColor= Color.FromArgb(160, 113, 255),
                Location = new Point(74, 424),
                Font = new Font("Candara", 11, FontStyle.Bold),
                Tag = car.ID
            };

            detailsBtn.Click += new EventHandler(this.detailsBtn_Click);

            carPanel.Controls.Add(carStampPictureBox);
            carPanel.Controls.Add(mileageLabel);
            carPanel.Controls.Add(carFuelLabel);
            carPanel.Controls.Add(carEngineLabel);
            carPanel.Controls.Add(carDriveLabel);
            carPanel.Controls.Add(carPriceLabel);            
            carPanel.Controls.Add(mileageInfoLabel);
            carPanel.Controls.Add(carFuelInfoLabel);
            carPanel.Controls.Add(carEngineInfoLabel);
            carPanel.Controls.Add(carDriveInfoLabel);
            carPanel.Controls.Add(carPriceInfoLabel);
            carPanel.Controls.Add(carYearLabel);
            carPanel.Controls.Add(carNameLabel);
            carPanel.Controls.Add(carPictureBox);
            carPanel.Controls.Add(detailsBtn);
            CarsPanel.Controls.Add(carPanel);
        }
        private void applyBtn_Click(object sender, EventArgs e)
        {
            var culture = new CultureInfo("de-DE");
            try
            {
                logger.Info("Загрузка машин");
                using (var context = new AppContext())
                {
                    bool isPreferred = IsPreferred();
                    var cars = new List<Cars>();

                    int? priceFrom = string.IsNullOrWhiteSpace(priceFromTextBox.Text) ? (int?)null : int.Parse(priceFromTextBox.Text);
                    int? priceTo = string.IsNullOrWhiteSpace(priceToTextBox.Text) ? (int?)null : int.Parse(priceToTextBox.Text);

                    if (priceFrom > priceTo)
                    {
                        MessageBox.Show(Local.wrongPrices, Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        priceFromTextBox.Clear();
                        return;
                    }

                    if (string.IsNullOrWhiteSpace(searchTextBox.Text))
                    {
                        MessageBox.Show(Local.searchFieldEmpty, Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (isPreferred)
                    {
                        if (similarToPreferences != null)
                        {
                            if (priceFrom != null && priceTo != null)
                            {
                                cars = similarToPreferences.Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                                           .Where(c => c.Price >= priceFrom)
                                                           .Where(c => c.Price <= priceTo)
                                                           .Take(9).ToList();
                            }
                            else if (priceFrom != null && priceTo == null)
                            {
                                cars = similarToPreferences.Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                                           .Where(c => c.Price >= priceFrom)
                                                           .Take(9).ToList();
                            }
                            else if (priceTo != null && priceFrom == null)
                            {
                                cars = similarToPreferences.Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                                           .Where(c => c.Price <= priceTo)
                                                           .Take(9).ToList();
                            }
                            else
                            {
                                cars = similarToPreferences.Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                                           .Take(9).ToList();
                            }
                        }
                        else
                        {
                            if (priceFrom != null && priceTo != null)
                            {
                                cars = context.Cars.Include(c => c.Cars_Model)
                                            .Include(c => c.Cars_Stamp)
                                            .Include(c => c.Cars_Body)
                                            .Include(c => c.Cars_Engine)
                                            .Include(c => c.Cars_Fuel)
                                            .Include(c => c.Cars_Drive)
                                            .Include(c => c.Cars_Checkpoint)
                                            .Include(c => c.Cars_Wheel)
                                            .Include(c => c.Cars_Colour)
                                            .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                            .Where(c => c.Price >= priceFrom)
                                            .Where(c => c.Price <= priceTo)
                                            .Take(9)
                                            .ToList();
                            }
                            else if (priceFrom != null && priceTo == null)
                            {
                                cars = context.Cars.Include(c => c.Cars_Model)
                                            .Include(c => c.Cars_Stamp)
                                            .Include(c => c.Cars_Body)
                                            .Include(c => c.Cars_Engine)
                                            .Include(c => c.Cars_Fuel)
                                            .Include(c => c.Cars_Drive)
                                            .Include(c => c.Cars_Checkpoint)
                                            .Include(c => c.Cars_Wheel)
                                            .Include(c => c.Cars_Colour)
                                            .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                            .Where(c => c.Price >= priceFrom)
                                            .Take(9)
                                            .ToList();
                            }
                            else if (priceTo != null && priceFrom == null)
                            {
                                cars = context.Cars.Include(c => c.Cars_Model)
                                            .Include(c => c.Cars_Stamp)
                                            .Include(c => c.Cars_Body)
                                            .Include(c => c.Cars_Engine)
                                            .Include(c => c.Cars_Fuel)
                                            .Include(c => c.Cars_Drive)
                                            .Include(c => c.Cars_Checkpoint)
                                            .Include(c => c.Cars_Wheel)
                                            .Include(c => c.Cars_Colour)
                                            .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                            .Where(c => c.Price <= priceTo)
                                            .Take(9)
                                            .ToList();
                            }
                            else
                            {
                                cars = context.Cars.Include(c => c.Cars_Model)
                                            .Include(c => c.Cars_Stamp)
                                            .Include(c => c.Cars_Body)
                                            .Include(c => c.Cars_Engine)
                                            .Include(c => c.Cars_Fuel)
                                            .Include(c => c.Cars_Drive)
                                            .Include(c => c.Cars_Checkpoint)
                                            .Include(c => c.Cars_Wheel)
                                            .Include(c => c.Cars_Colour)
                                            .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                            .Take(9)
                                            .ToList();
                            }
                        }
                    }
                    else
                    {
                        if (priceFrom != null && priceTo != null)
                        {
                            cars = context.Cars.Include(c => c.Cars_Model)
                                        .Include(c => c.Cars_Stamp)
                                        .Include(c => c.Cars_Body)
                                        .Include(c => c.Cars_Engine)
                                        .Include(c => c.Cars_Fuel)
                                        .Include(c => c.Cars_Drive)
                                        .Include(c => c.Cars_Checkpoint)
                                        .Include(c => c.Cars_Wheel)
                                        .Include(c => c.Cars_Colour)
                                        .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                        .Where(c => c.Price >= priceFrom)
                                        .Where(c => c.Price <= priceTo)
                                        .Take(9)
                                        .ToList();
                        }
                        else if (priceFrom != null && priceTo == null)
                        {
                            cars = context.Cars.Include(c => c.Cars_Model)
                                        .Include(c => c.Cars_Stamp)
                                        .Include(c => c.Cars_Body)
                                        .Include(c => c.Cars_Engine)
                                        .Include(c => c.Cars_Fuel)
                                        .Include(c => c.Cars_Drive)
                                        .Include(c => c.Cars_Checkpoint)
                                        .Include(c => c.Cars_Wheel)
                                        .Include(c => c.Cars_Colour)
                                        .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                        .Where(c => c.Price >= priceFrom)
                                        .Take(9)
                                        .ToList();
                        }
                        else if (priceTo != null && priceFrom == null)
                        {
                            cars = context.Cars.Include(c => c.Cars_Model)
                                        .Include(c => c.Cars_Stamp)
                                        .Include(c => c.Cars_Body)
                                        .Include(c => c.Cars_Engine)
                                        .Include(c => c.Cars_Fuel)
                                        .Include(c => c.Cars_Drive)
                                        .Include(c => c.Cars_Checkpoint)
                                        .Include(c => c.Cars_Wheel)
                                        .Include(c => c.Cars_Colour)
                                        .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                        .Where(c => c.Price <= priceTo)
                                        .Take(9)
                                        .ToList();
                        }
                        else
                        {
                            cars = context.Cars.Include(c => c.Cars_Model)
                                        .Include(c => c.Cars_Stamp)
                                        .Include(c => c.Cars_Body)
                                        .Include(c => c.Cars_Engine)
                                        .Include(c => c.Cars_Fuel)
                                        .Include(c => c.Cars_Drive)
                                        .Include(c => c.Cars_Checkpoint)
                                        .Include(c => c.Cars_Wheel)
                                        .Include(c => c.Cars_Colour)
                                        .Where(c => c.Cars_Stamp.Stamp.ToLower().Contains(searchTextBox.Text.ToLower()))
                                        .Take(9)
                                        .ToList();
                        }
                    }

                    for (int i = 0; i < cars.Count; i++)
                    {
                        var car = cars[i];
                        Guna2Panel carPanel = this.Controls.Find($"carPanel{i + 1}", true).FirstOrDefault() as Guna2Panel;
                        if (carPanel != null)
                        {
                            carPanel.Visible = true;

                            Guna2PictureBox carPicture = carPanel.Controls.Find($"carPictureBox{i + 1}", true).FirstOrDefault() as Guna2PictureBox;
                            if (carPicture != null)
                            {
                                if (car.Photo_1 != null)
                                {
                                    carPicture.Image = Image.FromFile(car.Photo_1);
                                }
                                else
                                {
                                    carPicture.Image = Properties.Resources.noAuto;
                                }
                            }

                            Guna2PictureBox carBrandPicture = carPanel.Controls.Find($"carBrandPictureBox{i + 1}", true).FirstOrDefault() as Guna2PictureBox;
                            if (carBrandPicture != null)
                            {
                                carBrandPicture.Image = Image.FromFile(helper.GetStampImageLocation(car.Cars_Stamp.Stamp));
                            }

                            Label carName = carPanel.Controls.Find($"carNameLabel{i + 1}", true).FirstOrDefault() as Label;
                            if (carName != null)
                            {
                                carName.Text = $"{car.Cars_Stamp.Stamp} {car.Cars_Model.Model}";
                            }

                            Label carYear = carPanel.Controls.Find($"carYearLabel{i + 1}", true).FirstOrDefault() as Label;
                            if (carYear != null)
                            {
                                carYear.Text = $"{car.Year}";
                            }

                            Label carMileage = carPanel.Controls.Find($"mileageInfoLabel{i + 1}", true).FirstOrDefault() as Label;
                            if (carMileage != null)
                            {
                                carMileage.Text = $"{car.Mileage} км";
                            }

                            Label carFuel = carPanel.Controls.Find($"carFuelInfoLabel{i + 1}", true).FirstOrDefault() as Label;
                            if (carFuel != null)
                            {
                                carFuel.Text = $"{car.Cars_Fuel.Fuel}";
                            }

                            Label carEngine = carPanel.Controls.Find($"carEngineInfoLabel{i + 1}", true).FirstOrDefault() as Label;
                            if (carEngine != null)
                            {
                                carEngine.Text = $"{car.Cars_Engine.Engine}";
                            }

                            Label carDrive = carPanel.Controls.Find($"carDriveInfoLabel{i + 1}", true).FirstOrDefault() as Label;
                            if (carDrive != null)
                            {
                                carDrive.Text = $"{car.Cars_Drive.Drive}";
                            }

                            Label carPrice = carPanel.Controls.Find($"carPriceInfoLabel{i + 1}", true).FirstOrDefault() as Label;
                            if (carPrice != null)
                            {
                                carPrice.Text = $"{car.Price.ToString("#,#", culture)} ₽";
                            }
                        }
                    }

                    for (int i = cars.Count; i < 9; i++)
                    {
                        Panel carPanel = this.Controls.Find($"carPanel{i + 1}", true).FirstOrDefault() as Panel;
                        if (carPanel != null)
                        {
                            carPanel.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Не удалось загрузить машины: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MailSendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
                    if (user != null)
                    {
                        string userEmail = user.Email;
                        if (!string.IsNullOrEmpty(userEmail))
                        {
                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("carpulses@mail.ru");
                            mail.To.Add(userEmail);
                            mail.Subject = "Ваша подборка.";
                            mail.Body = GetAutos();

                            SendEmailWithAttachments(mail);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Не удалось отправить код: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SendEmailWithAttachments(MailMessage mail)
        {
            try
            {
                SmtpClient smtpServer = new SmtpClient("smtp.mail.ru");
                smtpServer.Port = 2525;
                smtpServer.Credentials = new NetworkCredential("carpulses@mail.ru", "2zx1Mayx911DeAbE5bdR");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);

                MessageBox.Show("Письмо успешно отправлено на указанный адрес.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при отправке письма: " + ex.Message);
            }
        }
        private string GetAutos()
        {
            string allCars = null;
            foreach (var someCar in cars)
            {
                string someInfo = $"Марка: {someCar.Cars_Stamp.Stamp} " +
                    $"Модель: {someCar.Cars_Model.Model} " +
                    $"Кузов: {someCar.Cars_Body.Body} " +
                    $"Год: {someCar.Year} " +
                    $"Цена: {someCar.Price} руб.";

                allCars += someInfo + "\n\n";
            }
            return allCars;
        }

    }
}
