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
    public partial class DescriptionForm : Form
    {
        private CarInfoForm parentForm;
        public DescriptionForm(CarInfoForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }
    }
}
