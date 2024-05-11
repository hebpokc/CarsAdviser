using CarsAdviser.Database;
using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsAdviser.Forms
{
    public partial class PlaylistForm : Form
    {
        private MainForm parentForm;
        private Form currentChildForm;
        private int currentUserID;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        public PlaylistForm(MainForm parentForm, int CurrentUserId)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            Thread.CurrentThread.CurrentUICulture = parentForm.GetCurrentUICulture();
            currentUserID = CurrentUserId;
        }
        public void OpenChildForm(Form childForm)
        {
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            playlistPanelBtw.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            logger.Info($"Открытие дочерней формы: {childForm.GetType().Name}");
        }

        private void myPlaylistLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MyPlaylistForm(currentUserID));
            myPlaylistLine.Visible = true;
            allPlaylistLine.Visible = false;
        }

        private void allPlaylistLabel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AllPlaylistForm(currentUserID));
            allPlaylistLine.Visible = true;
            myPlaylistLine.Visible = false;
        }
    }
}
