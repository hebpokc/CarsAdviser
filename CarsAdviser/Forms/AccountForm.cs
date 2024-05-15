using CarsAdviser.Database;
using Guna.UI2.WinForms;
using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser.Forms
{
    public partial class AccountForm : Form
    {
        public MainForm parentForm;
        private Form currentChildForm;
        private int currentUserId;
        public List<Cars> similarToPreferences;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public AccountForm(MainForm parentForm, int CurrentUserId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.currentUserId = CurrentUserId;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new DataFillingForm(this, currentUserId));
            personalInformationBtn.Font = SetBoldFont(personalInformationBtn.Font);
            LoadUserData(currentUserId);
            SetYandexVisibility();
            logger.Info("Загрузка формы AccountForm");
        }

        private void SetYandexVisibility()
        {
            using (var context = new AppContext())
            {
                var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
                if (user != null && user.IsYandex == 1)
                {
                    yandexImg.Visible = true;
                }
            }
        }

        public void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            logger.Info($"Открытие дочерней формы: {childForm.GetType().Name}");
        }

        private void LoadUserData(int userId)
        {
            logger.Info($"Загрузка личных данных для пользователя: {userId}");
            try
            {
                using (var context = new AppContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.ID == userId);
                    if (user != null)
                    {
                        accountCirclePictureBox.Image = !string.IsNullOrEmpty(user.Avatar)
                            ? System.Drawing.Image.FromFile(user.Avatar)
                            : Properties.Resources.noAvatar;

                        nameLabel.Text = user.First_name;
                        surnameLabel.Text = user.Last_name;
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Ошибка при загрузке пользовательских данных: {ex.Message}");
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void personalInformationBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(new DataFillingForm(this, currentUserId), personalInformationBtn);
        }

        private void preferencesBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(new PreferencesForm(this, currentUserId), preferencesBtn);
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(new ChangePasswordForm(this, currentUserId), changePasswordBtn);
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(new AddCarForm(this), addCarBtn);
        }

        private void AllPlaylistBtn_Click(object sender, EventArgs e)
        {
            HandleButtonClick(new AllRecomendation(this, currentUserId), AllPlaylistBtn);
        }

        private void HandleButtonClick(Form form, Guna2Button button)
        {
            currentChildForm.Close();
            OpenChildForm(form);
            SetButtonFontStyle(button);
        }

        private void SetButtonFontStyle(Guna2Button activeButton)
        {
            var buttons = new[] { personalInformationBtn, preferencesBtn, addCarBtn, changePasswordBtn, AllPlaylistBtn };
            foreach (var button in buttons)
            {
                button.Font = button == activeButton ? SetBoldFont(button.Font) : SetRegularFont(button.Font);
            }
        }

        private Font SetBoldFont(Font font) => new Font(font.FontFamily, font.Size, FontStyle.Bold);

        private Font SetRegularFont(Font font) => new Font(font.FontFamily, font.Size, FontStyle.Regular);

        private void exitBtn_Click(object sender, EventArgs e)
        {
            logger.Info($"Пользователь: {currentUserId} вышел из аккаунта");
            parentForm.Logout();
        }

        private void AccountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.similarToPreferences = similarToPreferences;
        }

        public CultureInfo GetCurrentUICulture()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }
    }
}
