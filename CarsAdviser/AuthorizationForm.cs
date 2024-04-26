using CarsAdviser.Forms;
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
using System.Resources;

namespace CarsAdviser
{
    public partial class AuthorizationForm : Form
    {
        public Form currentChildForm;
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
        }
        private void UpdateInterface()
        {
            chooseLangLabel.Text = Local.selectLang;
            this.Text = Local.formText;
        }
        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new SignInForm(this));
        }

        private void ruLangBtn_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ru-RU");
            UpdateInterface();
            currentChildForm.Close();
            OpenChildForm(new SignInForm(this));
        }

        private void enLangBtn_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
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
