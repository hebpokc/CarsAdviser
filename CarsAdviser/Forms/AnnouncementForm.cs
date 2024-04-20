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
    public partial class AnnouncementForm : Form
    {
        private MainForm parentForm;
        public AnnouncementForm(MainForm parentFrom)
        {
            InitializeComponent();
            this.parentForm = parentFrom;
        }
        private void priceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void priceTrackBar_ValueChanged(object sender, EventArgs e)
        {
            priceFromTextBox.Text = priceTrackBar1.Value.ToString();
            priceToTextBox.Text = priceTrackBar2.Value.ToString();
        }
        private void detailsBtn_Click(object sender, EventArgs e)
        {
            parentForm.currentChildForm.Close();
            parentForm.OpenChildForm(new CarInfoForm(parentForm));
        }
    }
}
