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
    public partial class HiddenForm : Form
    {
        private MainForm parentForm;
        private int carId;
        private int userId;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private Helper helper = new Helper();
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
            logger.Info("Загрузка формы HiddenForm");
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
        private void LoadCurrentCar(Cars car)
        {
            Guna2Panel carPanel = new Guna2Panel()
            {
                Size = new Size(268, 464),
                Margin = new Padding(3, 3, 50, 75),
                BorderRadius = 30,
                BorderThickness = 1,
                BorderColor = Color.Black,
                Tag = car.ID
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
                Text = Local.mileage,
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carFuelLabel = new Label()
            {
                Location = new Point(15, 270),
                AutoSize = true,
                Text = Local.fuel,
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carEngineLabel = new Label()
            {
                Location = new Point(15, 307),
                AutoSize = true,
                Text = Local.engine,
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carDriveLabel = new Label()
            {
                Location = new Point(15, 345),
                AutoSize = true,
                Text = Local.drive,
                ForeColor = Color.FromArgb(64, 64, 64),
                Font = new Font("Candara", 12),
            };
            Label carPriceLabel = new Label()
            {
                Location = new Point(15, 383),
                AutoSize = true,
                Text = Local.price,
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
                ForeColor = Color.FromArgb(160, 113, 255),
                Location = new Point(74, 424),
                Font = new Font("Candara", 11, FontStyle.Bold),
                Tag = car.ID
            };
            Guna2Button carHideButton = new Guna2Button()
            {
                FillColor = Color.Silver,
                Size = new Size(36, 25),
                BorderRadius = 30,
                BackColor = Color.Transparent,
                CustomizableEdges = { TopLeft = false, TopRight = true, BottomLeft = false, BottomRight = false },
                Text = "X",
                Location = new Point(229, 1),
                Tag = car.ID
            };

            carHideButton.Click += new EventHandler(this.hideBtn_Click);
            detailsBtn.Click += new EventHandler(this.detailsBtn_Click);

            carPanel.Controls.Add(carHideButton);
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
            heddenPanel.Controls.Add(carPanel);
        }
        private void LoadHidden()
        {
            var culture = new CultureInfo("de-DE");
            try
            {
                logger.Info("Загрузка машин");
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
                                            .ToList();

                    foreach (var car in hiddens)
                    {
                        LoadCurrentCar(car);
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
                logger.Error($"Не удалось загрузить машины: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    logger.Info($"Удаление скрытого автомобиля с ID: {hiddenId}");
                    MessageBox.Show(Local.carRemovedFromHidden, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    heddenPanel.Controls.Clear();
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