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

namespace CarsAdviser.Forms
{
    public partial class AccountForm : Form
    {
        private MainForm parentForm;
        private Form currentChildForm;
        private int CurrentUserId;
        public AccountForm(MainForm parentForm, int CurrentUserId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.CurrentUserId = CurrentUserId;
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new DataFillingForm(this));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Bold);
            LoadUserData(CurrentUserId);
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
        private void LoadUserData(int userId)
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
        private void personalInformationBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new DataFillingForm(this));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Bold);
            preferencesBtn.Font = new Font(preferencesBtn.Font.FontFamily, preferencesBtn.Font.Size, FontStyle.Regular);
            addCarBtn.Font = new Font(addCarBtn.Font.FontFamily, addCarBtn.Font.Size, FontStyle.Regular);
        }

        private void preferencesBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new PreferencesForm(this));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Regular);
            preferencesBtn.Font = new Font(preferencesBtn.Font.FontFamily, preferencesBtn.Font.Size, FontStyle.Bold);
            addCarBtn.Font = new Font(addCarBtn.Font.FontFamily, addCarBtn.Font.Size, FontStyle.Regular);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            parentForm.Logout();
        }

        private void addCarBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new AddCarForm(this));
            personalInformationBtn.Font = new Font(personalInformationBtn.Font.FontFamily, personalInformationBtn.Font.Size, FontStyle.Regular);
            preferencesBtn.Font = new Font(preferencesBtn.Font.FontFamily, preferencesBtn.Font.Size, FontStyle.Regular);
            addCarBtn.Font = new Font(addCarBtn.Font.FontFamily, addCarBtn.Font.Size, FontStyle.Bold);
        }
    }
}
