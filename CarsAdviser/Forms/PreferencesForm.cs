using CarsAdviser.Database;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public PreferencesForm(AccountForm parentForm, int userId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userId = userId;
            LoadRandomCars();
        }
        private void LoadRandomCars()
        {
            try
            {
                List<Cars> randomCars = new List<Cars>();

                using (var context = new AppContext())
                {
                    var userPreferencesCars = context.Users_preferences.Include(up => up.Cars)
                                                               .ThenInclude(c => c.Cars_Model)
                                                               .ThenInclude(cm => cm.Cars_Stamp)
                                                               .Where(up => up.Users_id == userId)
                                                               .Select(up => up.Cars)
                                                               .Take(4)
                                                               .ToList();

                    randomCars.AddRange(userPreferencesCars);

                    if (randomCars.Count < 4)
                    {

                        var allCars = context.Cars.Include(c => c.Cars_Model)
                                                  .Include(c => c.Cars_Stamp)
                                                  .ToList();

                        randomCars = allCars.OrderBy(x => Guid.NewGuid()).Take(4).ToList();

                        var remainingCount = 4 - randomCars.Count;

                        var remainingCars = randomCars.Skip(4).ToList();

                        randomCars.AddRange(remainingCars);
                    }

                    if (randomCars.Count == 0)
                    {
                        var allCars = context.Cars.Include(c => c.Cars_Model)
                                                   .Include(c => c.Cars_Stamp)
                                                   .OrderBy(x => Guid.NewGuid())
                                                   .Take(4)
                                                   .ToList();

                        randomCars.AddRange(allCars);
                    }

                    for (int i = 0; i < randomCars.Count; i++)
                    {
                        var car = randomCars[i];
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

                            Guna2CheckBox check = carPanel.Controls.Find($"preferCheckBox{i + 1}", true).FirstOrDefault() as Guna2CheckBox;
                            if (check != null)
                            {
                                check.Tag = car.ID;
                                if (userPreferencesCars.Any(upc => upc.ID == car.ID))
                                {
                                    check.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    return car;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            }
        }
        private void SaveUserPreferences(Cars car)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var userPreferences = new Users_preferences()
                    {
                        Users_id = userId,
                        Cars_id = car.ID
                    };

                    context.Users_preferences.Add(userPreferences);
                    context.SaveChanges();
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private List<Cars> GetUserPreferences()
        {
            List<Cars> userPreferences = new List<Cars>();
            try
            {
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
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return userPreferences;
        }
        private List<Cars> AnalyzeUserPreferences()
        {
            List<Cars> userPreferences = GetUserPreferences();
            List<Cars> similarToPreferences = new List<Cars>();

            foreach (var userPreference in userPreferences)
            {
                var similarCars = FindSimilarCars(userPreference);
                similarToPreferences.AddRange(similarCars);
            }
            List<Cars> uniqueSimilarToPreferences = similarToPreferences
                                                    .GroupBy(car => car.ID)
                                                    .Select(group => group.First())
                                                    .ToList();

            return uniqueSimilarToPreferences;
        }
        private List<Cars> FindSimilarCars(Cars userPreference)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var allCars = context.Cars.Include(c => c.Cars_Model)
                                            .Include(c => c.Cars_Stamp)
                                            .Include(c => c.Cars_Body)
                                            .Include(c => c.Cars_Engine)
                                            .Include(c => c.Cars_Fuel)
                                            .Include(c => c.Cars_Drive)
                                            .Include(c => c.Cars_Checkpoint)
                                            .Include(c => c.Cars_Wheel)
                                            .Include(c => c.Cars_Colour)
                                            .ToList();

                    List<Cars> similarCars = new List<Cars>();
                    var groupedCars = allCars.GroupBy(c => c.Mark);

                    foreach (var group in groupedCars.OrderByDescending(g => g.Key))
                    {
                        foreach (var car in group)
                        {
                            if (car.Cars_Stamp.Stamp == userPreference.Cars_Stamp.Stamp || car.Cars_Model.Model == userPreference.Cars_Model.Model || car.Cars_Body.Body == userPreference.Cars_Body.Body
                                || car.Cars_Engine.Engine == userPreference.Cars_Engine.Engine || car.Cars_Fuel.Fuel == userPreference.Cars_Fuel.Fuel || car.Cars_Drive.Drive == userPreference.Cars_Drive.Drive
                                || car.Cars_Checkpoint.Checkpoint == userPreference.Cars_Checkpoint.Checkpoint || car.Cars_Wheel.Wheel == userPreference.Cars_Wheel.Wheel || car.Cars_Colour.Colour == userPreference.Cars_Colour.Colour
                                || car.Year == userPreference.Year)
                            {
                                similarCars.Add(car);
                            }
                        }
                    }
                    return similarCars;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("Предпочтения учтены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            RemovePreferences();
            MessageBox.Show("Все предпочтения удалены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
