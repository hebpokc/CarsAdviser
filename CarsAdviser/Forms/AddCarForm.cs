using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsAdviser.Forms
{
    public partial class AddCarForm : Form
    {
        private AccountForm parentForm;
        public AddCarForm(AccountForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void carDescriptionRichTextBox_Enter(object sender, EventArgs e)
        {
            carDescriptionRichTextBox.Height = 190;
            addPhotoBtn.Location = new Point(392, 1200);
            addCarBtn.Location = new Point(392, 1270);
        }

        private void carDescriptionRichTextBox_Leave(object sender, EventArgs e)
        {
            carDescriptionRichTextBox.Height = 36;
            addPhotoBtn.Location = new Point(392, 1050);
            addCarBtn.Location = new Point(392, 1120);
        }

        private void addPhotoBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string destinationFolderPath = Path.Combine("../../", "Images", "CarImages");
                string destinationPath = Path.Combine(destinationFolderPath, Path.GetFileName(imagePath));

                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                File.Copy(imagePath, destinationPath, true);

                MessageBox.Show("Изображение загружено", "Инфомарция", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void carBrandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            carModelComboBox.Items.Clear();

            switch (carBrandComboBox.SelectedItem.ToString())
            {
                case "Audi":
                    carModelComboBox.Items.Add("A4");
                    carModelComboBox.Items.Add("Q5");
                    carModelComboBox.Items.Add("A3");
                    break;
                case "BMW":
                    carModelComboBox.Items.Add("3 Series");
                    carModelComboBox.Items.Add("5 Series");
                    carModelComboBox.Items.Add("X5");
                    break;
                case "Toyota":
                    carModelComboBox.Items.Add("Corolla");
                    carModelComboBox.Items.Add("Camry");
                    carModelComboBox.Items.Add("RAV4");
                    break;
                case "Ford":
                    carModelComboBox.Items.Add("F-150");
                    carModelComboBox.Items.Add("Escape");
                    carModelComboBox.Items.Add("Explorer");
                    break;
                case "Chevrolet":
                    carModelComboBox.Items.Add("Silverado");
                    carModelComboBox.Items.Add("Equinox");
                    carModelComboBox.Items.Add("Malibu");
                    break;
                case "Honda":
                    carModelComboBox.Items.Add("Civic");
                    carModelComboBox.Items.Add("Accord");
                    carModelComboBox.Items.Add("CR-V");
                    break;
                case "Volkswagen":
                    carModelComboBox.Items.Add("Golf");
                    carModelComboBox.Items.Add("Jetta");
                    carModelComboBox.Items.Add("Tiguan");
                    break;
                case "Nissan":
                    carModelComboBox.Items.Add("Altima");
                    carModelComboBox.Items.Add("Rogue");
                    carModelComboBox.Items.Add("Sentra");
                    break;
                case "Mercedes-Benz":
                    carModelComboBox.Items.Add("C-Class");
                    carModelComboBox.Items.Add("E-Class");
                    carModelComboBox.Items.Add("GLC-Class");
                    break;
                case "Hyundai":
                    carModelComboBox.Items.Add("Elantra");
                    carModelComboBox.Items.Add("Tucson");
                    carModelComboBox.Items.Add("Sonata");
                    break;
                case "Kia":
                    carModelComboBox.Items.Add("Forte");
                    carModelComboBox.Items.Add("Optima");
                    carModelComboBox.Items.Add("Sportage");
                    break;
                case "Subaru":
                    carModelComboBox.Items.Add("Outback");
                    carModelComboBox.Items.Add("Forester");
                    carModelComboBox.Items.Add("Crosstrek");
                    break;
                case "Jeep":
                    carModelComboBox.Items.Add("Wrangler");
                    carModelComboBox.Items.Add("Cherokee");
                    carModelComboBox.Items.Add("Grand Cherokee");
                    break;
                case "Tesla":
                    carModelComboBox.Items.Add("Model 3");
                    carModelComboBox.Items.Add("Model S");
                    carModelComboBox.Items.Add("Model X");
                    break;
                case "Lexus":
                    carModelComboBox.Items.Add("RX");
                    carModelComboBox.Items.Add("ES");
                    carModelComboBox.Items.Add("NX");
                    break;
            }
        }
    }
}
