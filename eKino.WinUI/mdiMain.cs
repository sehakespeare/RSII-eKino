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

        }

        private void newAuditoriumToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listGenresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenForm<frmGenreList>();
        }

        private void newGenreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listDirectorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newDirectorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listMoviesStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listProjectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newProjectionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ticketSalesPerMovieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yearlySalesByMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
