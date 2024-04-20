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
    public partial class DataFillingForm : Form
    {
        private AccountForm parentForm;
        public DataFillingForm(AccountForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void uploadAvatarBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.png)|*.jpg; *.jpeg; *.gif; *.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                string destinationFolderPath = Path.Combine("../../", "Images", "AccountAvatars");
                string destinationPath = Path.Combine(destinationFolderPath, Path.GetFileName(imagePath));

                if (!Directory.Exists(destinationFolderPath))
                {
                    Directory.CreateDirectory(destinationFolderPath);
                }

                File.Copy(imagePath, destinationPath, true);

                MessageBox.Show("Изображение загружено", "Инфомарция", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
