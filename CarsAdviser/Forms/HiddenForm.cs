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
    public partial class HiddenForm : Form
    {
        private MainForm parentForm;
        public HiddenForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        private void HiddenForm_ControlChanged(object sender, ControlEventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count()}";
            parentForm.NotificationTextUpdate2(notificationLabel.Text);
        }

        private void HiddenForm_Load(object sender, EventArgs e)
        {
            notificationLabel.Text = $"{this.Controls.OfType<Guna2Panel>().Count()}";
            parentForm.NotificationTextUpdate2(notificationLabel.Text);
        }
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            parentForm.currentChildForm.Close();
            parentForm.OpenChildForm(new CarInfoForm(parentForm));
        }
    }
}
