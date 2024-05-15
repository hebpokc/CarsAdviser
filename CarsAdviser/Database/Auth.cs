using Microsoft.EntityFrameworkCore;
using NLog;
using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CarsAdviser.Database
{
    public class Auth 
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public Auth(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
        public int CurrentUserId;

        /// <summary>
        /// Автонризация пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool AuthenticateUser(string login, string password)
        {
            return AuthenticateUserInternal(login, password, false);
        }

        /// <summary>
        /// Авторизация пользователя при помощи Yandex ID
        /// </summary>
        /// <param name="login"></param>
        /// <param name="isYandexAccount"></param>
        /// <returns></returns>
        public bool AuthenticateUser(string login, bool isYandexAccount)
        {
            return AuthenticateUserInternal(login, null, isYandexAccount);
        }

        private bool AuthenticateUserInternal(string login, string password, bool isYandexAccount)
        {
            try
            {
                using (var context = new AppContext())
                {
                    context.Database.EnsureCreated();
                    context.Users.Load();
                    var user = context.Users.FirstOrDefault(u => u.Email == login || u.Phone_number == login);
                    if (user != null && (isYandexAccount || BCrypt.Net.BCrypt.Verify(password, user.Password)))
                    {
                        CurrentUserId = user.ID;
                        return true;
                    }
                    else
                    {
                        logger.Warn($"Не удалось выполнить проверку подлинности при входе в систему: {login}");
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при проверке подлинности пользователя: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /// <summary>
        /// Регистрация пользователя
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool RegisterUser(string name, string surname, string email, string phone, string password)
        {
            return RegisterUserInternal(name, surname, email, phone, password, false);
        }

        /// <summary>
        /// Регистрация пользователя через Yandex ID
        /// </summary>
        /// <param name="name"></param>
        /// <param name="surname"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="password"></param>
        /// <param name="isYandexAccount"></param>
        /// <returns></returns>
        public bool RegisterUser(string name, string surname, string email, string phone, string password, bool isYandexAccount)
        {
            return RegisterUserInternal(name, surname, email, phone, password, isYandexAccount);
        }

        private bool RegisterUserInternal(string name, string surname, string email, string phone, string password, bool isYandexAccount)
        {
            try
            {
                using (var context = new AppContext())
                {
                    context.Database.EnsureCreated();
                    context.Users.Load();

                    var existingUser = context.Users.FirstOrDefault(u => u.Email == email || u.Phone_number == phone);
                    if (existingUser != null)
                    {
                        MessageBox.Show("Пользователь с таким email(номером) уже существует.");
                        return false;
                    }
                    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

                    var user = new Users
                    {
                        First_name = name,
                        Last_name = surname,
                        Email = email,
                        Phone_number = phone,
                        Password = hashedPassword,
                        IsYandex = isYandexAccount ? 1 : 0,
                    };
                    context.Users.Add(user);
                    context.SaveChanges();
                }

                return true;
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при регистрации пользователя: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

    }
}
