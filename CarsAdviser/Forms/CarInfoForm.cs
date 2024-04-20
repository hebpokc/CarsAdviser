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
    public partial class CarInfoForm : Form
    {
        private MainForm parentForm;
        private Form currentChildForm;
        public CarInfoForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
        public void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            InfoPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void CarInfoForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new CharacteristicsForm(this));
            descriptionBottomLabel.ForeColor = Color.Silver;
        }

        private void characteristicsBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new CharacteristicsForm(this));
            descriptionBottomLabel.ForeColor = Color.Silver;
            characteristicsBottomLabel.ForeColor = Color.FromArgb(160, 113, 255);
        }

        private void descriptionBtn_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            OpenChildForm(new DescriptionForm(this));
            descriptionBottomLabel.ForeColor = Color.FromArgb(160, 113, 255);
            characteristicsBottomLabel.ForeColor = Color.Silver;
        }
    }
}
