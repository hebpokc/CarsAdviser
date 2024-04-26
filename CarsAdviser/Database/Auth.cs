using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsAdviser.Database
{
    public class Auth 
    {
        public Auth(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }
        public int CurrentUserId;
        public bool AuthenticateUser(string login, string password)
        {
            try
            {
                using (var context = new AppContext())
                {
                    context.Database.EnsureCreated();
                    context.Users.Load();
                    var user = context.Users.FirstOrDefault(u => u.Email == login || u.Phone_number == login);
                    if (user != null && BCrypt.Net.BCrypt.Verify(password, user.Password))
                    {
                        CurrentUserId = user.ID;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public bool RegisterUser(string name, string surname, string email, string phone, string password)
        {
            try
            {
                using (var context = new AppContext())
                {
                    context.Database.EnsureCreated();
                    context.Users.Load();
                    var hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
                    var user = new Users { First_name = name, Last_name = surname, Email = email, Phone_number = phone, Password = hashedPassword };
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
