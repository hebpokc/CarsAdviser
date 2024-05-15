using CarsAdviser.Database;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class PreferencesForm : Form
    {
        private AccountForm parentForm;
        private int userId;
        public List<Cars> similarToPreferences;
        private List<Cars> selectedPreferences = new List<Cars>();
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Helper helper = new Helper();
        public PreferencesForm(AccountForm parentForm, int userId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userId = userId;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadRandomCars();
            logger.Info("Загрузка формы PreferencesForm");
        }
        private void LoadRandomCars()
        {
            try
            {
                prefPanel.Controls.Clear();
                logger.Info("Загрузка случайных автомобилей");
                var randomCars = new List<Cars>();

                using (var context = new AppContext())
                {
                    var userPreferencesCars = context.Users_preferences.Include(up => up.Cars)
                                                               .ThenInclude(c => c.Cars_Model)
                                                               .ThenInclude(cm => cm.Cars_Stamp)
                                                               .Where(up => up.Users_id == userId)
                                                               .Select(up => up.Cars)
                                                               .Take(10)
                                                               .ToList();

                    randomCars.AddRange(userPreferencesCars);

                    if (randomCars.Count < 10)
                    {

                        var allCars = context.Cars.Include(c => c.Cars_Model)
                                                  .Include(c => c.Cars_Stamp)
                                                  .ToList();

                        randomCars = allCars.OrderBy(x => Guid.NewGuid()).Take(10).ToList();

                        var remainingCount = 10 - randomCars.Count;

                        var remainingCars = randomCars.Skip(10).ToList();

                        randomCars.AddRange(remainingCars);
                    }

                    if (!randomCars.Any())
                    {
                        var allCars = context.Cars.Include(c => c.Cars_Model)
                                                   .Include(c => c.Cars_Stamp)
                                                   .OrderBy(x => Guid.NewGuid())
                                                   .Take(10)
                                                   .ToList();

                        randomCars.AddRange(allCars);
                    }

                    foreach (var car in randomCars)
                    {
                        LoadCurrentCarPreference(car);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при загрузке случайных машин: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCurrentCarPreference(Cars car)
        {
            Guna2Panel carPanel = new Guna2Panel()
            {
                Size = new Size(265, 270),
                Margin = new Padding(3, 3, 50, 75),
                BorderColor = Color.Black,
                BorderRadius = 30,
                BorderThickness = 1
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
            Guna2PictureBox carBrandPictureBox = new Guna2PictureBox()
            {
                Size = new Size(32, 32),
                FillColor = Color.White,
                BackColor = Color.Transparent,
                Location = new Point(35, 172),
                SizeMode = PictureBoxSizeMode.StretchImage,
                Image = Image.FromFile(helper.GetStampImageLocation(car.Cars_Stamp.Stamp)),
            };
            Label carYearLabel = new Label()
            {
                Location = new Point(75, 192),
                Font = new Font("Segoe UI", 10),
                Text = car.Year.ToString(),
            };
            Label carNameLabel = new Label()
            {
                Location = new Point(75, 173),
                Font = new Font("Candara", 12),
                Text = car.Cars_Stamp.Stamp + ' ' + car.Cars_Model.Model,
                Size = new Size(carPanel.Width - 85, 32),
                TextAlign = ContentAlignment.TopLeft
            };
            Guna2CheckBox preferCheckBox = new Guna2CheckBox()
            {
                Size = new Size(90, 23),
                Text = "Выбрано",
                Font = new Font("Candara", 12),
                Location = new Point(92, 231),
                ForeColor = Color.FromArgb(160, 113, 255),
                Checked = GetUserPreferences().Any(p => p.ID == car.ID),
                Tag = car.ID
            };
            preferCheckBox.CheckedChanged += new EventHandler(preferCheckBox_CheckedChanged);

            carPanel.Controls.Add(preferCheckBox);
            carPanel.Controls.Add(carBrandPictureBox);
            carPanel.Controls.Add(carYearLabel);
            carPanel.Controls.Add(carNameLabel);
            carPanel.Controls.Add(carPictureBox);
            prefPanel.Controls.Add(carPanel);
        }
        private void newListBtn_Click(object sender, EventArgs e)
        {
            LoadRandomCars();
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

                checkBox.Checked = selectedPreferences.Contains(car);
            }
        }
        private void SaveUserPreferences(Cars car)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var existingPreference = context.Users_preferences.FirstOrDefault(up => up.Users_id == userId && up.Cars_id == car.ID);

                    if (selectedPreferences.Contains(car))
                    {
                        if (existingPreference == null)
                        {
                            var userPreferences = new Users_preferences()
                            {
                                Users_id = userId,
                                Cars_id = car.ID
                            };
                            context.Users_preferences.Add(userPreferences);
                            logger.Info($"Сохранение предпочтений пользователя для автомобиля с ID: {car.ID}");
                        }
                    }
                    else
                    {
                        if (existingPreference != null)
                        {
                            context.Users_preferences.Remove(existingPreference);
                            logger.Warn($"Удаление записи для автомобиля с ID: {car.ID}, так как он был удален из предпочтений пользователя с ID: {userId}");
                        }
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при сохранении предпочтений пользователя: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemovePreferences()
        {
            try
            {
                using (var context = new AppContext())
                {
                    var userPreferences = context.Users_preferences.Where(up => up.Users_id == userId).ToList();
                    if (userPreferences.Any())
                    {
                        context.Users_preferences.RemoveRange(userPreferences);
                        context.SaveChanges();
                        logger.Info("Удаление всех предпочтений пользователя");
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при удаление всех предпочтений пользователя: {ex.Message}");
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

            UserPreferencesStorage.UpdateUserPreferences(similarToPreferences);
            MessageBox.Show(Local.preferencesTaken, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void clearBtn_Click(object sender, EventArgs e)
        {
            RemovePreferences();
            MessageBox.Show(Local.preferencesDeleted, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}