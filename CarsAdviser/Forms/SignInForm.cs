﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarsAdviser.Database;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using NLog;

namespace CarsAdviser.Forms
{
    public partial class SignInForm : Form
    {
        private AuthorizationForm parentForm;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        private const string ClientId = "a4eafaed8ce24ccfa608401fdb825ed7";
        private const string RedirectUri = "https://oauth.yandex.ru/verification_code";

        public SignInForm() { }
        public SignInForm(AuthorizationForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            passwordTextBox.UseSystemPasswordChar = true;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            UpdateInterface();
            logger.Info("Загрузка формы SignInForm");  
        }

        private void uncorrectDataTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void createAccountBtn_Click(object sender, EventArgs e)
        {
            parentForm.currentChildForm.Close();
            parentForm.OpenChildForm(new RegisterForm(parentForm));
        }

        private void signInBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(loginTextBox.Text))
            {
                mandatoryFillingLabel1.Visible = true;
                logger.Warn("Поле логин пустое");
            }
            else
            {
                mandatoryFillingLabel1.Visible = false;
                if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
                {
                    mandatoryFillingLabel2.Visible = true;
                    logger.Warn("Поле пароль пустое");
                }
                else
                {
                    mandatoryFillingLabel2.Visible = false;
                    var auth = new Auth(Thread.CurrentThread.CurrentUICulture);
                    var isAuth = auth.AuthenticateUser(loginTextBox.Text, passwordTextBox.Text);
                    if (isAuth)
                    {
                        uncorrectDataTextBox.Visible = false;
                        logger.Info($"Пользователь с логином {loginTextBox.Text} успешно авторизован");
                        loginTextBox.Clear();
                        passwordTextBox.Clear();
                        MainForm mainForm = new MainForm(parentForm, auth.CurrentUserId);
                        mainForm.Show();
                        parentForm.Hide();
                    }
                    else
                    {
                        uncorrectDataTextBox.Visible = true;
                    }
                }
            }
        }

        public void passwordTextBox_IconRightClick(object sender, EventArgs e)
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

        private void loginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInBtn.PerformClick();
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                signInBtn.PerformClick();
            }
        }

        private void UpdateInterface()
        {
            loginTextBox.PlaceholderText = Local.loginPlaceHolder;
            passwordTextBox.PlaceholderText = Local.passwordPlaceHolder;
            uncorrectDataTextBox.Text = Local.uncorrectData;
        }

        private void YandexAuthBtn_Click(object sender, EventArgs e)
        {
            var authUrl = "https://passport.yandex.ru/auth/list?retpath=" + Uri.EscapeDataString($"https://oauth.yandex.ru/authorize?response_type=code&client_id={ClientId}&redirect_uri={RedirectUri}&prompt=select_account");

            webBrowser.Visible = true;
            webBrowser.Navigate(authUrl);
            backBtn.Visible = true;
        }
        private async void webBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            webBrowser.ScriptErrorsSuppressed = true;
            if (e.Url.AbsoluteUri.StartsWith(RedirectUri))
            {
                YandexHelper yandexHelper = new YandexHelper();
                var code = e.Url.Query.Substring(e.Url.Query.IndexOf("code=") + 5).Split('&')[0];
                var accessToken = await yandexHelper.ExchangeCodeForTokenAsync(code);
                webBrowser.Visible = false;

                var userInfo = await yandexHelper.GetUserInfoAsync(accessToken);
                if (userInfo != null)
                {
                    var auth = new Auth(Thread.CurrentThread.CurrentUICulture);
                    var isAuth = auth.AuthenticateUser(userInfo.Email, userInfo.IsYandex == 1);
                    if (isAuth)
                    {
                        uncorrectDataTextBox.Visible = false;
                        logger.Info($"Пользователь {userInfo.First_name} успешно авторизован");
                        loginTextBox.Clear();
                        passwordTextBox.Clear();
                        MainForm mainForm = new MainForm(parentForm, auth.CurrentUserId);
                        mainForm.Show();
                        parentForm.Hide();
                    }
                    else
                    {
                        uncorrectDataTextBox.Visible = true;
                    }
                }
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            webBrowser.Visible = false;
            backBtn.Visible = false;
        }
    }
}
