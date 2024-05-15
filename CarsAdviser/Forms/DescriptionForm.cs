using CarsAdviser.Database;
using NLog;
using System;
using System.Windows.Forms;

namespace CarsAdviser.Forms
{
    public partial class DescriptionForm : Form
    {
        private CarInfoForm parentForm;
        private Cars car;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public DescriptionForm(CarInfoForm parentForm, Cars car)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.car = car;
            LoadCarDetails();
            logger.Info("Загрузка формы DescriptionForm");
        }
        private void LoadCarDetails()
        {

                if (car != null)
                {
                    logger.Debug($"Описание автомобиля загружено: {car.Description}");
                    descriptionRichTextBox.Text = car.Description;
                }
                else
                {
                    logger.Error($"Ошибка при загрузке описания автомобиля.");
                }

        }
    }
}
