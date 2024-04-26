using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class DataFillingForm : Form
    {
        private AccountForm parentForm;
        private int currentUserId;
        public DataFillingForm(AccountForm parentForm, int currentUserId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.currentUserId = currentUserId;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            UpdateInterface();
        }
        private void UpdateInterface()
        {
            surnameTextBox.PlaceholderText = Local.surnamePlaceHolder;
            nameTextBox.PlaceholderText = Local.namePlaceHolder;
            patronymicTextBox.PlaceholderText = Local.patronymicPlaceHolder;
            phoneTextBox.PlaceholderText = Local.phonePlaceHolder;
            cityTextBox.PlaceholderText = Local.cityPlaceHolder;
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

                try
                {
                    using (var context = new AppContext())
                    {
                        var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
                        if (user != null)
                        {
                            user.Avatar = destinationPath;
                            context.SaveChanges();
                            MessageBox.Show(Local.ImageUploaded, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(Local.ImageNotLoaded, Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DataFillingForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
                    if (user != null)
                    {
                        surnameTextBox.Text = user.Last_name;
                        nameTextBox.Text = user.First_name;
                        patronymicTextBox.Text = user.Patronymic;
                        emailTextBox.Text = user.Email;
                        phoneTextBox.Text = user.Phone_number;
                        cityTextBox.Text = user.City;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        public bool IsValidPhone(string phone)
        {
            string pattern = @"^\d{11}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }
        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show(Local.EnterValidMail);
                emailTextBox.Focus();
            }
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            string phone = phoneTextBox.Text;
            if (!IsValidPhone(phone))
            {
                MessageBox.Show(Local.EnterValidPhone);
                phoneTextBox.Focus();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new AppContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
                    if (user != null)
                    {
                        if (string.IsNullOrWhiteSpace(nameTextBox.Text))
                        {
                            mandatoryFillingLabel1.Visible = true;
                        }
                        else
                        {
                            mandatoryFillingLabel1.Visible = false;
                            if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
                            {
                                mandatoryFillingLabel2.Visible = true;
                            }
                            else
                            {
                                mandatoryFillingLabel2.Visible = false;
                                if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                                {
                                    mandatoryFillingLabel3.Visible = true;
                                }
                                else
                                {
                                    mandatoryFillingLabel3.Visible = false;
                                    if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
                                    {
                                        mandatoryFillingLabel4.Visible = true;
                                    }
                                    else
                                    {
                                        mandatoryFillingLabel4.Visible = false;

                                        user.First_name = nameTextBox.Text;
                                        user.Last_name = surnameTextBox.Text;
                                        user.Patronymic = patronymicTextBox.Text;
                                        user.Email = emailTextBox.Text;
                                        user.Phone_number = phoneTextBox.Text;
                                        user.City = cityTextBox.Text;

                                        context.Users.Update(user);
                                        MessageBox.Show(Local.DataChanged, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
