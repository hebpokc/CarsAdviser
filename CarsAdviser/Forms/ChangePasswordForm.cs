using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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
        public ChangePasswordForm(AccountForm parentForm, int currentUserId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.currentUserId = currentUserId;
            passwordTextBox.UseSystemPasswordChar = true;
        }
        private string GenerateRandomCode(int length)
        {
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
                MessageBox.Show("Код подтверждения отправлен на вашу электронную почту.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при отправке кода подтверждения: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                MessageBox.Show("Пароль изменен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            context.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    parentForm.parentForm.Logout();
                }
                else
                {
                    MessageBox.Show("Неверный или не сгенерированный код. Нажмите на кнопку генерации еще раз или проверьте правильность введенного кода", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
