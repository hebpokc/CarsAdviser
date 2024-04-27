using CarsAdviser.Database;
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
        public DescriptionForm(CarInfoForm parentForm, Cars car)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.car = car;
            LoadCarDetails();
        }
        private void LoadCarDetails()
        {
            try
            {
                if (car != null)
                {
                    descriptionRichTextBox.Text = car.Description;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
