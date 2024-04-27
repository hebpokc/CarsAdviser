using CarsAdviser.Database;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Bold);
            LoadUserData(currentUserId);
            logger.Info("Загрузка формы AccountForm");
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
                        if (!string.IsNullOrEmpty(user.Avatar))
                        {
                            accountCirclePictureBox.Image = Image.FromFile(user.Avatar);
                        }
                        else
                        {
                            accountCirclePictureBox.Image = Properties.Resources.noAvatar;
                        }

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
            currentChildForm.Close();
            OpenChildForm(new DataFillingForm(this, currentUserId));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Bold);
            preferencesBtn.Font = new Font(preferencesBtn.Font.FontFamily, preferencesBtn.Font.Size, FontStyle.Regular);
            addCarBtn.Font = new Font(addCarBtn.Font.FontFamily, addCarBtn.Font.Size, FontStyle.Regular);
            changePasswordBtn.Font = new Font(changePasswordBtn.Font.FontFamily, changePasswordBtn.Font.Size, FontStyle.Regular);
        }


        private void preferencesBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new PreferencesForm(this, currentUserId));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Regular);
            preferencesBtn.Font = new Font(preferencesBtn.Font.FontFamily, preferencesBtn.Font.Size, FontStyle.Bold);
            addCarBtn.Font = new Font(addCarBtn.Font.FontFamily, addCarBtn.Font.Size, FontStyle.Regular);
            changePasswordBtn.Font = new Font(changePasswordBtn.Font.FontFamily, changePasswordBtn.Font.Size, FontStyle.Regular);
        }

        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new ChangePasswordForm(this, currentUserId));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Regular);
            preferencesBtn.Font = new Font(preferencesBtn.Font.FontFamily, preferencesBtn.Font.Size, FontStyle.Regular);
            addCarBtn.Font = new Font(addCarBtn.Font.FontFamily, addCarBtn.Font.Size, FontStyle.Regular);
            changePasswordBtn.Font = new Font(changePasswordBtn.Font.FontFamily, changePasswordBtn.Font.Size, FontStyle.Bold);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            logger.Info($"Пользователь: {currentUserId} вышел из аккаунта");
            parentForm.Logout();
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new AddCarForm(this));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Regular);
            preferencesBtn.Font = new Font(preferencesBtn.Font.FontFamily, preferencesBtn.Font.Size, FontStyle.Regular);
            addCarBtn.Font = new Font(addCarBtn.Font.FontFamily, addCarBtn.Font.Size, FontStyle.Bold);
            changePasswordBtn.Font = new Font(changePasswordBtn.Font.FontFamily, changePasswordBtn.Font.Size, FontStyle.Regular);
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
