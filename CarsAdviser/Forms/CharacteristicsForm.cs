using CarsAdviser.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsAdviser.Forms
{
    public partial class CharacteristicsForm : Form
    {
        private CarInfoForm parentForm;
        private Cars car;
        public CharacteristicsForm(CarInfoForm parentForm, Cars car)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.car = car;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadCarDetails();
        }
        private void LoadCarDetails()
        {
            try
            {
                if (car != null)
                {
                    brandInfoLabel.Text = $"{car.Cars_Stamp.Stamp}";
                    modelInfoLabel.Text = $"{car.Cars_Model.Model}";
                    yearInfoLabel.Text = $"{car.Year}";
                    colorInfoLabel.Text = $"{car.Cars_Colour.Colour}";
                    driveTypeInfoLabel.Text = $"{car.Cars_Drive.Drive}";
                    enginePowerInfoLabel.Text = $"{car.Engine_power}";
                    qtyPlacesInfoLabel.Text = $"{car.Qty_places}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
