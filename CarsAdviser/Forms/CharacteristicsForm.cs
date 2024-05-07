using CarsAdviser.Database;
using NLog;
using System;
using System.Threading;
using System.Windows.Forms;

namespace CarsAdviser.Forms
{
    public partial class CharacteristicsForm : Form
    {
        private CarInfoForm parentForm;
        private Cars car;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public CharacteristicsForm(CarInfoForm parentForm, Cars car)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.car = car;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            LoadCarDetails();
            logger.Info("Загрузка формы CharacteristicsForm");
        }
        private void LoadCarDetails()
        {
            try
            {
                logger.Info("Загрузка данных автомобиля");
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
                logger.Error($"Ошибка при загрузке данных автомобиля: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
