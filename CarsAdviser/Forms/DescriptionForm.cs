using CarsAdviser.Database;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            try
            {
                if (car != null)
                {
                    logger.Debug($"Описание автомобиля загружено: {car.Description}");
                    descriptionRichTextBox.Text = car.Description;
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при загрузке описания автомобиля: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
