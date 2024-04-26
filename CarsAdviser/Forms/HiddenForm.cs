using CarsAdviser.Database;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class HiddenForm : Form
    {
        private MainForm parentForm;
        private int carId;
        private int userId;
        public HiddenForm(MainForm parentForm, int userId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userId = userId;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadHidden();
        }
        private void UpdateForm()
        {
            this.Invalidate();
            this.Update();
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count(p => p.Visible == true)}";
            parentForm.NotificationTextUpdate2(notificationLabel.Text);
            LoadHidden();
        }
        private void HiddenForm_ControlChanged(object sender, ControlEventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count(p => p.Visible == true)}";
            parentForm.NotificationTextUpdate2(notificationLabel.Text);
        }

        private void HiddenForm_Load(object sender, EventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count(p => p.Visible == true)}";
            parentForm.NotificationTextUpdate2(notificationLabel.Text);
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
        private void LoadHidden()
        {
            var culture = new CultureInfo("de-DE");
            try
            {
                using (var context = new AppContext())
                {
                    var hiddens = context.Users_hidden_auto
                                            .Where(u => u.Users_id == userId)
                                            .Include(u => u.Cars.Cars_Model)
                                            .Include(u => u.Cars.Cars_Stamp)
                                            .Include(u => u.Cars.Cars_Body)
                                            .Include(u => u.Cars.Cars_Engine)
                                            .Include(u => u.Cars.Cars_Fuel)
                                            .Include(u => u.Cars.Cars_Drive)
                                            .Include(u => u.Cars.Cars_Checkpoint)
                                            .Include(u => u.Cars.Cars_Wheel)
                                            .Include(u => u.Cars.Cars_Colour)
                                            .Select(u => u.Cars)
                                            .Take(6)
                                            .ToList();

                    for (int i = 0; i < hiddens.Count; i++)
                    {
                        var car = hiddens[i];
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

                            Guna2Button hideBtn = carPanel.Controls.Find($"hideBtn{i + 1}", true).FirstOrDefault() as Guna2Button;
                            if (hideBtn != null)
                            {
                                hideBtn.Tag = car.ID;
                            }

                            Guna2Button detailsBtn = carPanel.Controls.Find($"detailsBtn{i + 1}", true).FirstOrDefault() as Guna2Button;
                            if (detailsBtn != null)
                            {
                                detailsBtn.Tag = car.ID;
                            }
                        }
                    }

                    for (int i = hiddens.Count; i < 6; i++)
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
        private void RemoveHidden(int hiddenId)
        {
            using (var context = new AppContext())
            {
                var hidden = context.Users_hidden_auto.FirstOrDefault(b => b.Cars_id == hiddenId);
                if (hidden != null)
                {
                    context.Users_hidden_auto.Remove(hidden);
                    context.SaveChanges();

                    MessageBox.Show(Local.carRemovedFromHidden, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateForm();
                }
            }
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            Guna2Button hideButton = sender as Guna2Button;
            if (hideButton != null)
            {
                int hiddenId = Convert.ToInt32(hideButton.Tag);
                RemoveHidden(hiddenId);
            }

        }
    }
}
