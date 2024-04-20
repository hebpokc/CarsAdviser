using CarsAdviser.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new SignInForm(this));
        }
    }
}
