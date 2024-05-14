using CarsAdviser.Database;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class AllRecomendation : Form
    {
        private AccountForm parentForm;
        private int userId;
        public List<Cars> similarToPreferences;
        private List<Cars> selectedPreferences = new List<Cars>();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AllRecomendation(AccountForm parentForm, int userId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userId = userId;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadSortedCars();
            logger.Info("Загрузка формы PreferencesForm");
        }
        private void LoadSortedCars()
        {
            try
            {
                logger.Info("Загрузка автомобилей, отсортированных по предпочтениям всех пользователей");

                using (var context = new AppContext())
                {
                    var allCars = context.Cars.Include(c => c.Cars_Model)
                                              .Include(c => c.Cars_Stamp)
                                              .ToList();
                    var allUsersPreferences = context.Users_preferences.Select(up => up.Cars_id).ToList();
                    var carPreferencesCount = new Dictionary<int, int>();
                    var userPreferences = context.Users_preferences
                                                .Where(up => up.Users_id == userId)
                                                .Select(up => up.Cars_id)
                                                .ToList();

                    foreach (var carId in allUsersPreferences)
                    {
                        if (!carPreferencesCount.ContainsKey(carId))
                        {
                            carPreferencesCount.Add(carId, 1);
                        }
                        else
                        {
                            carPreferencesCount[carId]++;
                        }
                    }

                    var sortedCars = allCars.OrderByDescending(c => carPreferencesCount.ContainsKey(c.ID) ? carPreferencesCount[c.ID] : 0).ToList();

                    for (int i = 0; i < sortedCars.Count; i++)
                    {
                        var car = sortedCars[i];
                        Guna2Panel carPanel = Controls.Find($"carPanel{i + 1}", true).FirstOrDefault() as Guna2Panel;
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

                            Guna2CheckBox check = carPanel.Controls.Find($"preferCheckBox{i + 1}", true).FirstOrDefault() as Guna2CheckBox;
                            if (check != null)
                            {
                                check.Tag = car.ID;

                                if (userPreferences.Any(upc => upc == car.ID))
                                {
                                    check.Checked = true; 
                                }
                                else
                                {
                                    check.Checked = false;
                                }
                            }

                        }
                    }

                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при загрузке автомобилей: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string GetStampImageLocation(string stamp)
        {
            switch (stamp)
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
        private Cars GetCarByID(int id)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var car = context.Cars.FirstOrDefault(c => c.ID == id);
                    logger.Info($"Получена машина с ID: {car.ID}");
                    return car;
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при получении ID машины: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void preferCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Guna2CheckBox checkBox = sender as Guna2CheckBox;
            if (checkBox != null)
            {
                var car = GetCarByID(Convert.ToInt32(checkBox.Tag));

                if (checkBox.Checked)
                {
                    if (!selectedPreferences.Contains(car))
                    {
                        selectedPreferences.Add(car);
                    }
                }
                else
                {
                    selectedPreferences.Remove(car);
                }

                if (!selectedPreferences.Contains(car))
                {
                    checkBox.Checked = false;
                }
            }
        }
        private void SaveUserPreferences(Cars car)
        {
            try
            {
                using (var context = new AppContext())
                {
                    if (selectedPreferences.Count >= GetUserPreferences().Count)
                    {
                        var existingPreference = context.Users_preferences.FirstOrDefault(up => up.Users_id == userId && up.Cars_id == car.ID);
                        if (existingPreference == null)
                        {
                            var userPreferences = new Users_preferences()
                            {
                                Users_id = userId,
                                Cars_id = car.ID
                            };

                            context.Users_preferences.Add(userPreferences);
                            context.SaveChanges();
                            logger.Info($"Сохранение предпочтений пользователя для автомобиля с ID: {car.ID}");
                        }
                        else
                        {
                            logger.Warn($"Запись для автомобиля с ID: {car.ID} уже существует у пользователя с ID: {userId}");
                        }
                    }
                    else if (selectedPreferences.Count < GetUserPreferences().Count)
                    {
                        var existingPreference = context.Users_preferences.FirstOrDefault(up => up.Users_id == userId && up.Cars_id == car.ID);
                        if (existingPreference == null)
                        {
                            var userPreferences = new Users_preferences()
                            {
                                Users_id = userId,
                                Cars_id = car.ID
                            };

                            context.Users_preferences.Add(userPreferences);
                            context.SaveChanges();
                            logger.Info($"Сохранение предпочтений пользователя для автомобиля с ID: {car.ID}");
                        }
                        else
                        {

                            context.Users_preferences.Remove(existingPreference);
                            context.SaveChanges();
                            logger.Warn($"Запись для автомобиля с ID: {car.ID} уже существует у пользователя с ID: {userId}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при сохранение предпочтений пользователя: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Cars> GetUserPreferences()
        {
            List<Cars> userPreferences = new List<Cars>();
            try
            {
                logger.Info("Получение предпочтений пользователя");
                using (var context = new AppContext())
                {
                    var userPreference = context.Users_preferences
                                                 .Where(up => up.Users_id == userId)
                                                 .Select(up => up.Cars_id)
                                                 .ToList();

                    userPreferences = context.Cars.Where(c => userPreference.Contains(c.ID))
                                                  .Include(c => c.Cars_Model)
                                                  .Include(c => c.Cars_Stamp)
                                                  .Include(c => c.Cars_Body)
                                                  .Include(c => c.Cars_Engine)
                                                  .Include(c => c.Cars_Fuel)
                                                  .Include(c => c.Cars_Drive)
                                                  .Include(c => c.Cars_Checkpoint)
                                                  .Include(c => c.Cars_Wheel)
                                                  .Include(c => c.Cars_Colour)
                                                  .ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при получение предпочтений пользователя");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userPreferences;
        }
        private List<Cars> AnalyzeUserPreferences()
        {
            logger.Info("Анализ предпочтений пользователя");
            var userPreferences = GetUserPreferences();
            var similarToPreferences = new List<Cars>();

            foreach (var userPreference in userPreferences)
            {
                var similarCars = FindSimilarCars(userPreference);
                similarToPreferences.AddRange(similarCars);
            }

            var uniqueSimilarToPreferences = similarToPreferences
                                                .GroupBy(car => car.ID)
                                                .Select(group => group.First())
                                                .OrderByDescending(car => similarToPreferences.Count(similarCar => similarCar.ID == car.ID))
                                                .ToList();

            return uniqueSimilarToPreferences;
        }
        private List<Cars> GetAllCars()
        {
            try
            {
                using (var context = new AppContext())
                {
                    return context.Cars
                    .Include(c => c.Cars_Model)
                    .Include(c => c.Cars_Stamp)
                    .Include(c => c.Cars_Body)
                    .Include(c => c.Cars_Engine)
                    .Include(c => c.Cars_Fuel)
                    .Include(c => c.Cars_Drive)
                    .Include(c => c.Cars_Checkpoint)
                    .Include(c => c.Cars_Wheel)
                    .Include(c => c.Cars_Colour)
                    .ToList();
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при получении списка всех автомобилей: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private List<Cars> FindSimilarCars(Cars userPreference)
        {
            try
            {
                logger.Info("Поиск похожих авто");

                List<Cars> similarCars = new List<Cars>();

                using (var context = new AppContext())
                {
                    var allCars = GetAllCars();
                    var selectedCars = GetUserPreferences();

                    foreach (var selectedCar in selectedCars)
                    {
                        int similarityCount = 0;

                        foreach (var property in typeof(Cars).GetProperties())
                        {
                            try
                            {
                                if (property.Name.StartsWith("Cars_"))
                                {
                                    var selectedCarPropertyValue = property.GetValue(selectedCar);

                                    if ((int)property.GetValue(userPreference) == (int)selectedCarPropertyValue)
                                    {
                                        similarityCount++;
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                logger.Error($"Ошибка при сравнении свойств автомобилей: {ex.Message}");
                            }
                        }

                        if (similarityCount > 0)
                        {
                            similarCars.Add(selectedCar);
                        }
                    }

                    foreach (var availableCar in allCars)
                    {
                        if (selectedCars.Contains(availableCar))
                            continue;

                        int similarityCount = 0;

                        foreach (var selectedCar in selectedCars)
                        {
                            foreach (var property in typeof(Cars).GetProperties())
                            {
                                try
                                {
                                    if (property.Name.StartsWith("Cars_"))
                                    {
                                        var selectedCarPropertyValue = property.GetValue(selectedCar);
                                        var availableCarPropertyValue = property.GetValue(availableCar);

                                        if ((int)selectedCarPropertyValue == (int)availableCarPropertyValue)
                                        {
                                            similarityCount++;
                                        }
                                    }
                                }
                                catch (Exception ex)
                                {
                                    logger.Error($"Ошибка при сравнении свойств автомобилей: {ex.Message}");
                                }
                            }
                        }

                        if (similarityCount > 0)
                        {
                            similarCars.Add(availableCar);
                        }
                    }
                }

                similarCars = similarCars.OrderByDescending(car => similarCars.Count(similarCar => similarCar.ID == car.ID)).ToList();

                return similarCars;
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при поиске похожих авто: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var car in selectedPreferences)
            {             
                SaveUserPreferences(car);
            }

            selectedPreferences.Clear();

            similarToPreferences = AnalyzeUserPreferences();

            parentForm.similarToPreferences = similarToPreferences;
            MessageBox.Show(Local.preferencesTaken, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
