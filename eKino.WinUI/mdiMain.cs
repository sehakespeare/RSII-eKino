using eKino.WinUI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI
{
    public partial class mdiMain : Form
    {
        public mdiMain()
        {
            InitializeComponent();
        }

        private void OpenForm<TForm>() where TForm : Form, new()
        {
            // Close duplicate forms
            foreach (var item in this.MdiChildren)
            {
                if (item is TForm)
                {
                    item.Close();
                }
            }

            TForm childForm = new()
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
            childForm.Show();
        }
        private void listUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmUserList>();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmUserDetails>();
        }

        private void listAuditoriumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmAuditoriumList>();
        }

        private void newAuditoriumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmAuditoriumDetails>();
        }

        private void listGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmGenreList>();
        }

        private void newGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmGenreDetails>();
        }

        private void listDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmDirectorList>();
        }

        private void newDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmDirectorDetails>();
        }

        private void listMoviesStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmMovieList>();
        }

        private void newMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmMovieDetails>();
        }

        private void listProjectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmProjectionList>();
        }

        private void newProjectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmProjectionDetails>();
        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmReservationList>();
        }

        private void ticketSalesPerMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmReport1>();
        }

        private void revenuePerMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmReport2>();
        }

        private void mdiMain_Load(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            toolStripStatusLabel.Text = "Logged in as: " + APIService.Username;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            Hide();

            if (new frmLogin().ShowDialog() == DialogResult.OK)
            {
                foreach (var item in this.MdiChildren)
                {
                    item.Close();
                }
                UpdateStatusBar();
                Show();
            }
            else
                Application.Exit();
        }

    }
}
