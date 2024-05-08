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
        private List<Attachment> attachments = new List<Attachment>();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AnnouncementForm(MainForm parentFrom, List<Cars> similarToPreferences, int currentUserId)
        {
            InitializeComponent();
            this.parentForm = parentFrom;
            this.similarToPreferences = similarToPreferences;
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
        public string GetStampImageLocation(string stamp)
        {
            switch(stamp)
            {
                case "Audi":
                    return "../../Images/CarsBrands/audi_logo.png";
                case "BMW":
                    return "../../Images/CarsBrands/bmw_logo.png";
                case "Chevrolet":
                    return "../../Images/CarsBrands/chevrolet_logo.png";
                case "Ford":
                    return "../../Images/CarsBrands/ford_logo.png";
                case "Honda":
                    return "../../Images/CarsBrands/honda_logo.png";
                case "Hyundai":
                    return "../../Images/CarsBrands/hyundai_logo.png";
                case "Jeep":
                    return "../../Images/CarsBrands/jeep_logo.png";
                case "Kia":
                    return "../../Images/CarsBrands/kia_logo.png";
                case "Lexus":
                    return "../../Images/CarsBrands/lexus_logo.png";
                case "Mercedes-Benz":
                    return "../../Images/CarsBrands/mercedes_logo.png";
                case "Nissan":
                    return "../../Images/CarsBrands/nissan_logo.png";
                case "Subaru":
                    return "../../Images/CarsBrands/subaru_logo.png";
                case "Tesla":
                    return "../../Images/CarsBrands/tesla_logo.png";
                case "Toyota":
                    return "../../Images/CarsBrands/toyota_logo.png";
                case "Volkswagen":
                    return "../../Images/CarsBrands/volkswagen_logo.png";
                default:
                    return "../../Resources/noAuto.png";
            }
        }
        public bool IsPreferred()
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
            var culture = new CultureInfo("de-DE");
            try
            {
                logger.Info("Загрузка машин");
                using (var context = new AppContext())
                {
                    bool isPreferred = IsPreferred();

                    var hiddenCars = context.Users_hidden_auto.Where(uha => uha.Users_id == parentForm.currentUserId)
                                                              .Select(uha => uha.Cars_id)
                                                              .ToList() ?? new List<int>();

                    if (isPreferred)
                    {
                        if (similarToPreferences != null)
                        {
                            cars = similarToPreferences.Where(c => !hiddenCars.Contains(c.ID)).Take(9).ToList();
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
                                            .Take(9)
                                            .ToList();
                        }
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
                                            .Take(9)
                                            .ToList();
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
                                carBrandPicture.Image = Image.FromFile(GetStampImageLocation(car.Cars_Stamp.Stamp));
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
                                carBrandPicture.Image = Image.FromFile(GetStampImageLocation(car.Cars_Stamp.Stamp));
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

                            //// Добавляем вложения
                            //foreach (var someCar in cars)
                            //{
                            //    if (someCar.Photo_1 != null)
                            //        mail.Attachments.Add(new Attachment(someCar.Photo_1));
                            //}

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
