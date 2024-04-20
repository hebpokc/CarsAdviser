using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsAdviser.Database;
using System.Text.RegularExpressions;

namespace CarsAdviser.Forms
{
    public partial class RegisterForm : Form
    {
        AuthorizationForm parentForm;
        public RegisterForm(AuthorizationForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            passwordTextBox.UseSystemPasswordChar = true;
        }

        private void signInAccountBtn_Click(object sender, EventArgs e)
        {
            parentForm.currentChildForm.Close();
            parentForm.OpenChildForm(new SignInForm(parentForm));
        }

        private void passwordTextBox_IconRightClick(object sender, EventArgs e)
        {
            if (passwordTextBox.UseSystemPasswordChar)
            {
                passwordTextBox.UseSystemPasswordChar = false;
                passwordTextBox.IconRight = Properties.Resources.hidepass;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
                passwordTextBox.IconRight = Properties.Resources.showpass;
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
        private void createAccountBtn_Click(object sender, EventArgs e)
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
                            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                            {
                                mandatoryFillingLabel5.Visible = true;
                            }
                            else
                            {
                                mandatoryFillingLabel5.Visible = false;
                                Auth auth = new Auth();
                                var isReg = auth.RegisterUser(nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text);
                                if (isReg)
                                {
                                    MessageBox.Show("Аккаунт успешно создан", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    parentForm.OpenChildForm(new SignInForm(parentForm));
                                    Close();
                                }
                            }
                        }
                    }
                }
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Введите корректный адрес электронной почты!");
                emailTextBox.Focus();
            }
        }

        private void phoneTextBox_Leave(object sender, EventArgs e)
        {
            string phone = phoneTextBox.Text;
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Введите корректный номер телефона!");
                phoneTextBox.Focus();
            }
        }
    }
}
