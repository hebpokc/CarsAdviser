using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using CarsAdviser.Database;
using NLog;

namespace CarsAdviser.Forms
{
    public partial class SignInForm : Form
    {
        private AuthorizationForm parentForm;
        private static Logger logger = LogManager.GetCurrentClassLogger();
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
    }
}
