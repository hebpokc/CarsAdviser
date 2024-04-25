using CarsAdviser.Database;
using CarsAdviser.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppContext = CarsAdviser.Database.AppContext;

namespace CarsAdviser
{
    public partial class MainForm : Form
    {
        private AuthorizationForm authorizationForm;
        public Form currentChildForm;
        public int currentUserId;
        public bool isPreferred = false;
        public List<Cars> similarToPreferences;

        public MainForm(AuthorizationForm authorizationForm, int currentUserId)
        {
            InitializeComponent();
            this.authorizationForm = authorizationForm;
            this.currentUserId = currentUserId;
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
        }
        public void Logout()
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите выйти из аккаунта?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                authorizationForm.Show();
                Hide();
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new AnnouncementForm(this, isPreferred, similarToPreferences));
            announcementBtn.Font = new Font(announcementBtn.Font.FontFamily, announcementBtn.Font.Size, FontStyle.Bold);
            announcementBottomLabel.Visible = true;
            ResetStyle(bookmarkersBtn, bookmarkersBottomLabel);
            ResetStyle(hiddenBtn, hiddenBottomLabel);
            LoadAvatar();
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены что хотите закрыть приложение?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            currentChildForm.Close();
            OpenChildForm(new AnnouncementForm(this, isPreferred, similarToPreferences));
            announcementBtn.Font = new Font(announcementBtn.Font.FontFamily, announcementBtn.Font.Size, FontStyle.Bold);
            announcementBottomLabel.Visible = true;
            accountBtn.Font = new Font(accountBtn.Font.FontFamily, accountBtn.Font.Size, FontStyle.Regular);
            ResetStyle(bookmarkersBtn, bookmarkersBottomLabel);
            ResetStyle(hiddenBtn, hiddenBottomLabel);
        }

        private void bookmarkersBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new BookmarkersForm(this, currentUserId));
            bookmarkersBtn.Font = new Font(bookmarkersBtn.Font.FontFamily, bookmarkersBtn.Font.Size, FontStyle.Bold);
            bookmarkersBottomLabel.Visible = true;
            accountBtn.Font = new Font(accountBtn.Font.FontFamily, accountBtn.Font.Size, FontStyle.Regular);
            ResetStyle(announcementBtn, announcementBottomLabel);
            ResetStyle(hiddenBtn, hiddenBottomLabel);
        }
        private void hiddenBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new HiddenForm(this, currentUserId));
            hiddenBtn.Font = new Font(hiddenBtn.Font.FontFamily, hiddenBtn.Font.Size, FontStyle.Bold);
            hiddenBottomLabel.Visible = true;
            accountBtn.Font = new Font(accountBtn.Font.FontFamily, accountBtn.Font.Size, FontStyle.Regular);
            ResetStyle(announcementBtn, announcementBottomLabel);
            ResetStyle(bookmarkersBtn, bookmarkersBottomLabel);
        }

        private void accountBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new AccountForm(this, currentUserId));
            accountBtn.Font = new Font(accountBtn.Font.FontFamily, accountBtn.Font.Size, FontStyle.Bold);
            ResetStyle(announcementBtn, announcementBottomLabel);
            ResetStyle(bookmarkersBtn, bookmarkersBottomLabel);
            ResetStyle(hiddenBtn, hiddenBottomLabel);
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
                MessageBox.Show($"Ошибка подключения к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
