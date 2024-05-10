using System;
using System.Windows.Forms;
using CarsAdviser.Database;
using System.Text.RegularExpressions;
using System.Threading;
using NLog;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Newtonsoft.Json;

namespace CarsAdviser.Forms
{
    public partial class RegisterForm : Form
    {
        AuthorizationForm parentForm;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private const string ClientId = "a4eafaed8ce24ccfa608401fdb825ed7";
        private const string RedirectUri = "https://oauth.yandex.ru/verification_code";
        private const string AuthEndpoint = "https://oauth.yandex.ru/authorize";

        private const string CustomUriScheme = "myapp://";
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

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        private void YandexRegBtn_Click(object sender, EventArgs e)
        {
            var authUrl = $"{AuthEndpoint}?response_type=code&client_id={ClientId}&redirect_uri={RedirectUri}";

            webBrowser.Visible = true;
            webBrowser.Navigate(authUrl);
        }

        private async void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            if (e.Url.AbsoluteUri.StartsWith(RedirectUri))
            {
                YandexHelper yandexHelper = new YandexHelper();
                var code = e.Url.Query.Substring(e.Url.Query.IndexOf("code=") + 5).Split('&')[0];
                var accessToken = await yandexHelper.ExchangeCodeForTokenAsync(code);
                webBrowser.Visible = false;

                var userInfo = await yandexHelper.GetUserInfoAsync(accessToken);
                if (userInfo != null)
                {
                    Auth auth = new Auth(Thread.CurrentThread.CurrentUICulture);
                    var isReg = auth.RegisterUser(userInfo.First_name, userInfo.Last_name, userInfo.Email, userInfo.Phone_number, "YandexPass");
                    if (isReg)
                    {
                        MessageBox.Show(Local.RegisterAccountSuccess, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logger.Info($"Пользователь {userInfo.First_name} {userInfo.Last_name} успешно зарегистрирован");
                        parentForm.OpenChildForm(new SignInForm(parentForm));
                        Close();
                    }
                }
            }
        }

    }
}