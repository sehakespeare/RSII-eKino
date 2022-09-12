using eKino.Model;
using eKino.Model.SearchObjects;
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
    public partial class frmReservationList : Form
    {
        private readonly APIService ReservationsService = new("Reservation");
        private readonly APIService ProjectionService = new("Projection");
        private readonly APIService UserService = new("User");
        private int Page = 0;
        private readonly int PerPage = 5;

        public frmReservationList()
        {
            InitializeComponent();
            dgvReservations.AutoGenerateColumns = false;
        }

        private async void frmReservation_Load(object sender, EventArgs e)
        {
            await LoadProjections();
            await LoadUsers();
            await LoadDataGrid();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Page = 0;
            await LoadDataGrid();
        }

        private async Task LoadDataGrid()
        {
            if (ValidateChildren())
            {
                var searchObject = new ReservationSearchObject
                {
                    UserId = cmbUser.SelectedIndex > 0 ? (cmbUser.SelectedItem as User).UserId : null,
                    ProjectionId = cmbProjection.SelectedIndex > 0 ? (cmbProjection.SelectedItem as Projection).ProjectionId : null,
                    PageSize = PerPage,
                    Page = Page
                };

                var list = await ReservationsService.Get<List<Reservation>>(searchObject);

                dgvReservations.DataSource = list;
                UpdatePagination();
            }
        }
        private async Task LoadProjections()
        {
            var list = await ProjectionService.Get<List<Projection>>();
            list.Insert(0, new Projection
            {
                MovieId = 0,
                Movie = new Movie
                {
                    Title = "Any"
                }
            });
            cmbProjection.DataSource = list;
        }
        
        private async Task LoadUsers()
        {
            var list = await UserService.Get<List<User>>();
            list.Insert(0, new User
            {
                UserId = 0,
                FirstName = "Any"
            });
            cmbUser.DataSource = list;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            await LoadDataGrid();
            bool noMoreEntries = dgvReservations.RowCount == 0;
            if (noMoreEntries)
            {
                Page--;
                await LoadDataGrid();
            }
            UpdatePagination();
            if (noMoreEntries)
            {
                btnNext.Enabled = false;
            }
        }

        private async void btnPrev_Click(object sender, EventArgs e)
        {
            Page--;
            await LoadDataGrid();
            UpdatePagination();
        }
        private void UpdatePagination()
        {
            btnPrev.Enabled = Page > 0;
            btnNext.Enabled = dgvReservations.RowCount >= PerPage;
            btnPage.Text = $"Page {Page + 1}";
        }

        private async void cmbDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }

        private async void cmbAuditorium_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }

        private async void dtpDate_ValueChanged(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }
    }
}
