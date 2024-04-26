using CarsAdviser.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class AddCarForm : Form
    {
        private AccountForm parentForm;
        private List<string> carPhotos = new List<string>();
        public AddCarForm(AccountForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    carBrandComboBox.DataSource = context.Cars_stamp.ToList();
                    carBrandComboBox.DisplayMember = "Stamp";
                    carBrandComboBox.ValueMember = "ID";

                    carBodyComboBox.DataSource = context.Cars_body.ToList();
                    carBodyComboBox.DisplayMember = "Body";
                    carBodyComboBox.ValueMember = "ID";

                    carEngineComboBox.DataSource = context.Cars_engine.ToList();
                    carEngineComboBox.DisplayMember = "Engine";
                    carEngineComboBox.ValueMember = "ID";

                    carFuelComboBox.DataSource = context.Cars_fuel.ToList();
                    carFuelComboBox.DisplayMember = "Fuel";
                    carFuelComboBox.ValueMember = "ID";

                    carDriveComboBox.DataSource = context.Cars_drive.ToList();
                    carDriveComboBox.DisplayMember = "Drive";
                    carDriveComboBox.ValueMember = "ID";

                    carTransmissionComboBox.DataSource = context.Cars_checkpoint.ToList();
                    carTransmissionComboBox.DisplayMember = "Checkpoint";
                    carTransmissionComboBox.ValueMember = "ID";

                    carWheelComboBox.DataSource = context.Cars_wheel.ToList();
                    carWheelComboBox.DisplayMember = "Wheel";
                    carWheelComboBox.ValueMember = "ID";

                    carColorComboBox.DataSource = context.Cars_colour.ToList();
                    carColorComboBox.DisplayMember = "Colour";
                    carColorComboBox.ValueMember = "ID";

                    carBodyComboBox.SelectedItem = null;
                    carEngineComboBox.SelectedItem = null;
                    carFuelComboBox.SelectedItem = null;
                    carDriveComboBox.SelectedItem = null;
                    carTransmissionComboBox.SelectedItem = null;
                    carWheelComboBox.SelectedItem = null;
                    carColorComboBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";
            openFileDialog.Multiselect = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    string destinationFolderPath = Path.Combine("../../", "Images", "CarsImages");
                    string destinationPath = Path.Combine(destinationFolderPath, Path.GetFileName(file));

                    if (!Directory.Exists(destinationFolderPath))
                    {
                        Directory.CreateDirectory(destinationFolderPath);
                    }

                    File.Copy(file, destinationPath, true);
                    carPhotos.Add(destinationPath);
                }

                MessageBox.Show(Local.carImageUploaded, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void carBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    if (carBrandComboBox.SelectedItem != null)
                    {
                        var selectedBrand = carBrandComboBox.SelectedItem as Cars_stamp;
                        var modelsForSelectedBrand = context.Cars_model
                                                            .Where(s => s.Cars_stamp == selectedBrand.ID)
                                                            .Select(s => s.Model)
                                                            .ToList();

                        carModelComboBox.DataSource = modelsForSelectedBrand;
                    }
                    else
                    {
                        carModelComboBox.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    Cars_model model = context.Cars_model.FirstOrDefault(cs => cs.Model == (string)carModelComboBox.SelectedItem);
                    var car = new Cars
                    {
                        Cars_model = model.ID,
                        Cars_stamp = (carBrandComboBox.SelectedItem as Cars_stamp).ID,
                        Cars_body = (carBodyComboBox.SelectedItem as Cars_body).ID,
                        Cars_engine = (carEngineComboBox.SelectedItem as Cars_engine).ID,
                        Cars_fuel = (carFuelComboBox.SelectedItem as Cars_fuel).ID,
                        Cars_drive = (carDriveComboBox.SelectedItem as Cars_drive).ID,
                        Cars_checkpoint = (carTransmissionComboBox.SelectedItem as Cars_checkpoint).ID,
                        Cars_wheel = (carWheelComboBox.SelectedItem as Cars_wheel).ID,
                        Cars_colour = (carColorComboBox.SelectedItem as Cars_colour).ID,
                        TrunkCapacity = int.Parse(carTrunkTextBox.Text),
                        Engine_power = int.Parse(carEnginePowerTextBox.Text),
                        Year = int.Parse(carYearTextBox.Text),
                        Qty_places = int.Parse(carQtyPlacesTextBox.Text),
                        Mileage = int.Parse(carMileageTextBox.Text),
                        Price = long.Parse(carPriceTextBox.Text),
                        Description = carDescriptionRichTextBox.Text,
                        Photo_1 = carPhotos.Count > 0 ? carPhotos[5] : null,
                        Photo_2 = carPhotos.Count > 1 ? carPhotos[4] : null,
                        Photo_3 = carPhotos.Count > 2 ? carPhotos[3] : null,
                        Photo_4 = carPhotos.Count > 3 ? carPhotos[2] : null,
                        Photo_5 = carPhotos.Count > 4 ? carPhotos[1] : null,
                    };
                    context.Cars.Add(car);
                    context.SaveChanges();

                    MessageBox.Show(Local.carAdded, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void carTrunkTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void carEnginePowerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void carYearTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void carQtyPlacesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void carMileageTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void carPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
