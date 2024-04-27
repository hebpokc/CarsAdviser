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
using System.Threading;
using NLog;

namespace CarsAdviser.Forms
{
    public partial class RegisterForm : Form
    {
        AuthorizationForm parentForm;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public RegisterForm(AuthorizationForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            passwordTextBox.UseSystemPasswordChar = true;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            UpdateInterface();
            logger.Info("Загрузка формы RegisterForm");
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
            string pattern = @"^(\+7\d{10}|[8]\d{10})$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(phone);
        }
        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                mandatoryFillingLabel1.Visible = true;
                logger.Warn("Поле имя пустое");
            }
            else
            {
                mandatoryFillingLabel1.Visible = false;
                if (string.IsNullOrWhiteSpace(surnameTextBox.Text))
                {
                    mandatoryFillingLabel2.Visible = true;
                    logger.Warn("Поле фамилия пустое");
                }
                else
                {
                    mandatoryFillingLabel2.Visible = false;
                    if (string.IsNullOrWhiteSpace(emailTextBox.Text))
                    {
                        mandatoryFillingLabel3.Visible = true;
                        logger.Warn("Поле email пустое");
                    }
                    else
                    {
                        mandatoryFillingLabel3.Visible = false;
                        if (string.IsNullOrWhiteSpace(phoneTextBox.Text))
                        {
                            mandatoryFillingLabel4.Visible = true;
                            logger.Warn("Поле телефон пустое");
                        }
                        else
                        {
                            mandatoryFillingLabel4.Visible = false;
                            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                            {
                                mandatoryFillingLabel5.Visible = true;
                                logger.Warn("Поле пароль пустое");
                            }
                            else
                            {
                                mandatoryFillingLabel5.Visible = false;
                                Auth auth = new Auth(Thread.CurrentThread.CurrentUICulture);
                                var isReg = auth.RegisterUser(nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text);
                                if (isReg)
                                {
                                    MessageBox.Show(Local.RegisterAccountSuccess, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    logger.Info($"Пользователь {nameTextBox.Text} {surnameTextBox.Text} успешно зарегистрирован");
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
        private void UpdateInterface()
        {
            nameTextBox.PlaceholderText = Local.namePlaceHolder;
            surnameTextBox.PlaceholderText = Local.surnamePlaceHolder;
            phoneTextBox.PlaceholderText = Local.phonePlaceHolder;
            passwordTextBox.PlaceholderText = Local.passwordPlaceHolder;
        }
    }
}
