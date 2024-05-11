using NLog;
using System;
using Guna.UI2.WinForms;
using AppContext = CarsAdviser.Database.AppContext;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using System.Linq;
using CarsAdviser.Database;
using System.Drawing;

namespace CarsAdviser.Forms
{
    public partial class MyPlaylistForm : Form
    {
        private MainForm parentForm;
        private Form currentChildForm;
        private static Logger logger = LogManager.GetCurrentClassLogger();
        private int currentUserID;
        public MyPlaylistForm(int currentUserId)
        {
            InitializeComponent();
            currentUserID = currentUserId;
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
        private void detailsBtn1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CurrentPlaylist());
        }


        private void UserPlaylistForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppContext())
            {
                var playlists = context.Playlists.Where(p => p.UserID == currentUserID).ToList();
                foreach (var playlist in playlists)
                {
                    AddPlaylist(playlist);
                }
            }
        }

        private void AddPlaylist(Playlists playlist)
        {
            Label tag = new Label
            {
                Location = new Point(104, 5),
                MaximumSize = new Size(90, 20),
                Font = new Font("Candara", 14, FontStyle.Bold),
                Text = playlist.Name,
                ForeColor = Color.Black,
            };
            Guna2Panel carPanel = new Guna2Panel
            {
                Location = new Point(44, 69),
                Size = new Size(265, 240),
                BackColor = Color.Transparent,
                BorderRadius = 5,
                BorderThickness = 1,
                BorderColor = Color.Black,
            };
            Guna2Panel picture = new Guna2Panel
            {
                Location = new Point(1, 35),
                Size = new Size(261, 153),
                BackColor = Color.White,
            };
            Guna2Button details = new Guna2Button
            {
                Size = new Size(126, 34),
                Location = new Point(3, 194),
                FillColor = Color.Transparent,
                ForeColor = Color.FromArgb(160, 113, 255),
                Font = new Font("Candara", 11, FontStyle.Bold),
                BorderRadius = 5,
                Text = "ПОДРОБНЕЕ",
                Tag = playlist.ID
            };
            Guna2Button add = new Guna2Button
            {
                Size = new Size(126, 34),
                Location = new Point(135, 194),
                FillColor = Color.Transparent,
                ForeColor = Color.FromArgb(160, 113, 255),
                Font = new Font("Candara", 11, FontStyle.Bold),
                BorderRadius = 5,
                Text = "ДОБАВИТЬ",
                Tag = playlist.ID
            };

            carPanel.Controls.Add(tag);
            carPanel.Controls.Add(add);
            carPanel.Controls.Add(details);
            carPanel.Controls.Add(picture);
            PlaylistPanel.Controls.Add(carPanel);
        }
    }
}
