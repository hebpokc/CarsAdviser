﻿using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class ChangePasswordForm : Form
    {
        private AccountForm parentForm;
        private string codeToVerify;
        private int currentUserId;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public ChangePasswordForm(AccountForm parentForm, int currentUserId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.currentUserId = currentUserId;
            passwordTextBox.UseSystemPasswordChar = true;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            UpdateInterface();
            logger.Info("Загрузка формы ChangePasswordForm");
        }
        private void UpdateInterface()
        {
            passwordTextBox.PlaceholderText = Local.newPasswordPlaceHolder;
            codeTextBox.PlaceholderText = Local.codePlaceHolder;
        }
        public string GenerateRandomCode(int length)
        {
            logger.Debug($"Генерация случайного кода длиной {length} символов.");
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void SendCodeByEmail(string emailAddress, string code)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.mail.ru", 2525);

                mail.From = new MailAddress("carpulses@mail.ru");
                mail.To.Add(emailAddress);
                mail.Subject = "Код подтверждения";
                mail.Body = $"Ваш код подтверждения: {code}";

                SmtpServer.Credentials = new NetworkCredential("carpulses@mail.ru", "2zx1Mayx911DeAbE5bdR");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
                logger.Info($"Отправка кода подтверждения на адрес: {emailAddress}");
                MessageBox.Show(Local.codeSended, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                logger.Error($"Не удалось отправить код: {ex.Message}");
                MessageBox.Show($"{Local.codeSendError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void codeTextBox_IconRightClick(object sender, EventArgs e)
        {
            string code = GenerateRandomCode(5);
            try
            {
                using (var context = new AppContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
                    if (user != null)
                    {
                        SendCodeByEmail(user.Email, code);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Не удалось отправить код: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            codeToVerify = code;
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                mandatoryFillingLabel1.Visible = true;
            }
            else
            {
                mandatoryFillingLabel1.Visible = false;
                if (codeTextBox.Text == codeToVerify)
                {
                    try
                    {
                        using (var context = new AppContext())
                        {
                            var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
                            if (user != null)
                            {
                                var hashedPassword = BCrypt.Net.BCrypt.HashPassword(passwordTextBox.Text);
                                user.Password = hashedPassword;
                                context.Users.Update(user);
                                MessageBox.Show(Local.passwordChanged, Local.messageBoxInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                logger.Info($"Пользователь {currentUserId} сменил пароль");
                            }
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error($"Ошибка при смене пароля: {ex.Message}");
                        MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    parentForm.parentForm.Logout();
                }
                else
                {
                    logger.Warn("Пользователь ввел неверный код");
                    MessageBox.Show(Local.codeUncorrect, Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
    }
}
