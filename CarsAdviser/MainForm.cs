using CarsAdviser.Database;
using CarsAdviser.Forms;
using Guna.UI2.WinForms;
using NLog;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser
{
    public partial class MainForm : Form
    {
        private AuthorizationForm authorizationForm;
        public Form currentChildForm;
        public int currentUserId;
        public List<Cars> similarToPreferences;
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public MainForm(AuthorizationForm authorizationForm, int currentUserId)
        {
            InitializeComponent();
            this.authorizationForm = authorizationForm;
            this.currentUserId = currentUserId;
            Thread.CurrentThread.CurrentUICulture = authorizationForm.GetCurrentUICulture();
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
        public void Logout()
        {
            DialogResult result = MessageBox.Show(Local.AskLogOut, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                authorizationForm.Show();
                Hide();
                logger.Info($"Пользователь {currentUserId} вышел из аккаунта");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildFormAndSetStyle(new AnnouncementForm(this, similarToPreferences, currentUserId), announcementBtn, announcementBottomLabel);
            LoadAvatar();
            logger.Info("Загрузка формы MainForm");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(Local.AskExit, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                authorizationForm.Close();
            }
        }
        private void ResetStyle(Guna2Button btn, Label label)
        {
            btn.Font = new Font(btn.Font.FontFamily, btn.Font.Size, FontStyle.Regular);
            label.Visible = false;
        }
        private void OpenChildFormAndSetStyle(Form childForm, Guna2Button activeButton, Label activeLabel)
        {
            currentChildForm?.Close();
            OpenChildForm(childForm);


            ResetStyle(announcementBtn, announcementBottomLabel);
            ResetStyle(bookmarkersBtn, bookmarkersBottomLabel);
            ResetStyle(hiddenBtn, hiddenBottomLabel);
            ResetStyle(accountBtn, accountBottomLabel);

            activeButton.Font = new Font(activeButton.Font.FontFamily, activeButton.Font.Size, FontStyle.Bold);
            activeLabel.Visible = true;
        }
        public void NotificationTextUpdate1(string text)
        {
            notificationLabel1.Text = text;
        }
        public void NotificationTextUpdate2(string text)
        {
            notificationLabel2.Text = text;
        }
        private void announcementBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormAndSetStyle(new AnnouncementForm(this, similarToPreferences, currentUserId), announcementBtn, announcementBottomLabel);
        }

        private void bookmarkersBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormAndSetStyle(new BookmarkersForm(this, currentUserId), bookmarkersBtn, bookmarkersBottomLabel);
        }
        private void hiddenBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormAndSetStyle(new HiddenForm(this, currentUserId), hiddenBtn, hiddenBottomLabel);
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            OpenChildFormAndSetStyle(new AccountForm(this, currentUserId), accountBtn, accountBottomLabel); 
        }
        private void LoadAvatar()
        {
            try
            {
                using (var context = new AppContext())
                {
                    var user = context.Users.FirstOrDefault(u => u.ID == currentUserId);
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
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{Local.databaseConnectionError}: {ex.Message}", Local.messageBoxError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error($"Ошибка при загрузке аватара для пользователя {currentUserId}: {ex.Message}");
            }
        }
        public CultureInfo GetCurrentUICulture()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }
    }
}
