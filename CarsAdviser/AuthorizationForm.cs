using CarsAdviser.Forms;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using NLog;

namespace CarsAdviser
{
    public partial class AuthorizationForm : Form
    {
        public Form currentChildForm;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public AuthorizationForm()
        {
            InitializeComponent();
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
        private void UpdateInterface()
        {
            chooseLangLabel.Text = Local.selectLang;
            this.Text = Local.formText;
            logger.Info($"Обновление интерфейса на {Thread.CurrentThread.CurrentUICulture.Name} язык");
        }
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new SignInForm(this));
            logger.Info("Загрузка формы AuthorizationForm");
        }

        private void ruLangBtn_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            logger.Info("Выбран русский язык");
            UpdateInterface();
            currentChildForm.Close();
            OpenChildForm(new SignInForm(this));
        }

        private void enLangBtn_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            logger.Info("Выбран английский язык");
            UpdateInterface();
            currentChildForm.Close();
            OpenChildForm(new SignInForm(this));
        }
        public CultureInfo GetCurrentUICulture()
        {
            return Thread.CurrentThread.CurrentUICulture;
        }
    }
}
