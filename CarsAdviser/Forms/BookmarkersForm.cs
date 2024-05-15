
using CarsAdviser.Database;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class BookmarkersForm : Form
    {
        private MainForm parentForm;
        private int carId;
        private int userId;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Helper helper = new Helper();
        public BookmarkersForm(MainForm parentForm, int userId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.userId = userId;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadBookmarks();
        }
        private void UpdateForm()
        {
            this.Invalidate();
            this.Update();
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count(p => p.Visible == true)}";
            parentForm.NotificationTextUpdate1(notificationLabel.Text);
            LoadBookmarks();
        }
        private void BookmarkersForm_ControlChanged(object sender, ControlEventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count(p => p.Visible == true)}";
            parentForm.NotificationTextUpdate1(notificationLabel.Text);
        }

        private void BookmarkersForm_Load(object sender, EventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count(p => p.Visible == true)}";
            parentForm.NotificationTextUpdate1(notificationLabel.Text);
            logger.Info("Загрузка формы BookmarksForm");
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
        private void LoadBookmarks()
        {
            var culture = new CultureInfo("de-DE");
            try
            {
                logger.Info("Загрузка машин");
                using (var context = new AppContext())
                {
                    var bookmarks = context.Users_bookmarks
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

                    for (int i = 0; i < bookmarks.Count; i++)
                    {
                        var car = bookmarks[i];
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

                    for (int i = bookmarks.Count; i < 6; i++)
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
        private void RemoveBookmark(int bookmarkId)
        {
            using (var context = new AppContext())
            {
                var bookmark = context.Users_bookmarks.FirstOrDefault(b => b.Cars_id == bookmarkId);
                if (bookmark != null)
                {
                    context.Users_bookmarks.Remove(bookmark);
                    context.SaveChanges();
                    logger.Info($"Удаление закладки с ID: {bookmarkId}");

                    MessageBox.Show(Local.carRemovedFromBookmarks, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateForm();
                }
            }
        }

        private void hideBtn_Click(object sender, EventArgs e)
        {
            Guna2Button hideButton = sender as Guna2Button;
            if (hideButton != null)
            {
                int bookmarkId = Convert.ToInt32(hideButton.Tag);
                RemoveBookmark(bookmarkId);
            }
        }
    }
}
