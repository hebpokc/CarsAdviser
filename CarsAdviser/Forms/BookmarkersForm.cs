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

namespace CarsAdviser.Forms
{
    public partial class BookmarkersForm : Form
    {
        private MainForm parentForm;
        public BookmarkersForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void BookmarkersForm_ControlChanged(object sender, ControlEventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count()}";
            parentForm.NotificationTextUpdate1(notificationLabel.Text);
        }

        private void BookmarkersForm_Load(object sender, EventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count()}";
            parentForm.NotificationTextUpdate1(notificationLabel.Text);
        }
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            parentForm.currentChildForm.Close();
            parentForm.OpenChildForm(new CarInfoForm(parentForm));
        }
    }
}
