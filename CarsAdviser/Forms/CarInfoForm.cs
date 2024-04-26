using CarsAdviser.Database;
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
    public partial class CarInfoForm : Form
    {
        private MainForm parentForm;
        private Form currentChildForm;
        private int carId;
        private Cars car;
        public CarInfoForm(MainForm parentForm, int carId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.carId = carId;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadCarDetails();
        }
        public void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            InfoPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void CarInfoForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new CharacteristicsForm(this, car));
            descriptionBottomLabel.ForeColor = Color.Silver;
        }

        private void characteristicsBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new CharacteristicsForm(this, car));
            descriptionBottomLabel.ForeColor = Color.Silver;
            characteristicsBottomLabel.ForeColor = Color.FromArgb(160, 113, 255);
        }

        private void descriptionBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new DescriptionForm(this, car));
            descriptionBottomLabel.ForeColor = Color.FromArgb(160, 113, 255);
            characteristicsBottomLabel.ForeColor = Color.Silver;
        }
        private void LoadCarDetails()
        {
            var culture = new CultureInfo("de-DE");
            try
            {
                using (var context = new AppContext())
                {
                    var car = context.Cars.Include(c => c.Cars_Model)
                                       .Include(c => c.Cars_Stamp)
                                       .Include(c => c.Cars_Body)
                                       .Include(c => c.Cars_Engine)
                                       .Include(c => c.Cars_Fuel)
                                       .Include(c => c.Cars_Drive)
                                       .Include(c => c.Cars_Checkpoint)
                                       .Include(c => c.Cars_Wheel)
                                       .Include(c => c.Cars_Colour)
                                       .FirstOrDefault(c => c.ID == carId);

                    if (car != null)
                    {
                        this.car = car;
                        carNameLabel.Text = $"{car.Year} {car.Cars_Stamp.Stamp} {car.Cars_Model.Model}";
                        mileageInfoLabel.Text = $"{car.Mileage} км";
                        bodyInfoLabel.Text = $"{car.Cars_Body.Body}";
                        engineInfoLabel.Text = $"{car.Cars_Engine.Engine}";
                        fuelInfoLabel.Text = $"{car.Cars_Fuel.Fuel}";
                        driveInfoLabel.Text = $"{car.Cars_Drive.Drive}";
                        transmissionInfoLabel.Text = $"{car.Cars_Checkpoint.Checkpoint}";
                        trunkInfoLabel.Text = $"{car.TrunkCapacity} л";
                        wheelInfoLabel.Text = $"{car.Cars_Wheel.Wheel}";
                        colorInfoLabel.Text = $"{car.Cars_Colour.Colour}";
                        priceLabel2.Text = $"{car.Price.ToString("#,#", culture)} ₽";
                        if (car.Mark != null)
                        {
                            carRatingStar.Value = (float)car.Mark / 2;
                        }
                        else
                        {
                            carRatingStar.Value = 0;
                        }

                        if (car.Photo_2 != null)
                        {
                            carPictureBox1.Image = Image.FromFile(car.Photo_2);
                        }
                        else
                        {
                            carPictureBox1.Image = Properties.Resources.noAuto;
                        }
                        if (car.Photo_3 != null)
                        {
                            carPictureBox2.Image = Image.FromFile(car.Photo_3);
                        }
                        else
                        {
                            carPictureBox2.Image = Properties.Resources.noAuto;
                        }
                        if (car.Photo_4 != null)
                        {
                            carPictureBox3.Image = Image.FromFile(car.Photo_4);
                        }
                        else
                        {
                            carPictureBox3.Image = Properties.Resources.noAuto;
                        }
                        if (car.Photo_5 != null)
                        {
                            carPictureBox4.Image = Image.FromFile(car.Photo_5);
                        }
                        else
                        {
                            carPictureBox4.Image = Properties.Resources.noAuto;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateCarRating(int carId, int rating)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var car = context.Cars.FirstOrDefault(c => c.ID == carId);
                    if (car != null)
                    {
                        car.Mark = rating;
                        context.SaveChanges();
                        MessageBox.Show(Local.ratingSaved, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void saveMarkBtn_Click(object sender, EventArgs e)
        {
            var rating = (int)(carRatingStar.Value * 2);
            UpdateCarRating(carId, rating);
        }
        private void toBookmarksBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var hiddenAuto = context.Users_hidden_auto.FirstOrDefault(b => b.Users_id == parentForm.currentUserId && b.Cars_id == carId);
                    if (hiddenAuto != null)
                    {
                        context.Users_hidden_auto.Remove(hiddenAuto);
                        context.SaveChanges();
                    }

                    var bookmark = context.Users_bookmarks.FirstOrDefault(b => b.Users_id == parentForm.currentUserId && b.Cars_id == carId);
                    if (bookmark != null)
                    {
                        MessageBox.Show(Local.carAlreadyBookmarks, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        bookmark = new Users_bookmarks
                        {
                            Users_id = parentForm.currentUserId,
                            Cars_id = carId
                        };

                        context.Users_bookmarks.Add(bookmark);
                        context.SaveChanges();

                        MessageBox.Show(Local.carAddedBookmarks, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void hideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var bookmark = context.Users_bookmarks.FirstOrDefault(b => b.Users_id == parentForm.currentUserId && b.Cars_id == carId);
                    if (bookmark != null)
                    {
                        context.Users_bookmarks.Remove(bookmark);
                        context.SaveChanges();
                    }

                    var hiddenAuto = context.Users_hidden_auto.FirstOrDefault(b => b.Users_id == parentForm.currentUserId && b.Cars_id == carId);
                    if (hiddenAuto != null)
                    {
                        MessageBox.Show(Local.carAlreadyHidden, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        hiddenAuto = new Users_hidden_auto
                        {
                            Users_id = parentForm.currentUserId,
                            Cars_id = carId
                        };

                        context.Users_hidden_auto.Add(hiddenAuto);
                        context.SaveChanges();

                        MessageBox.Show(Local.carAddedHidden, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public CultureInfo GetCurrentUICulture()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }
    }
}
