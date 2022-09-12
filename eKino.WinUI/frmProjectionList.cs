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
    public partial class frmProjectionList : Form
    {
        private readonly APIService ProjectionsService = new("Projection");
        private readonly APIService MovieService = new("Movie");
        private readonly APIService AuditoriumService = new("Auditorium");
        private int Page = 0;
        private readonly int PerPage = 5;

        public frmProjectionList()
        {
            InitializeComponent();
            dgvProjections.AutoGenerateColumns = false;
        }

        private async void frmProjection_Load(object sender, EventArgs e)
        {
            await LoadMovies();
            await LoadAuditoriums();
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
                var searchObject = new ProjectionSearchObject
                {
                    AuditoriumId = cmbAuditorium.SelectedIndex > 0 ? (cmbAuditorium.SelectedItem as Auditorium).AuditoriumId : null,
                    MovieId = cmbMovie.SelectedIndex > 0 ? (cmbMovie.SelectedItem as Movie).MovieId : null,
                    DateOfProjection = dtpDate.Value.Date,
                    PageSize = PerPage,
                    Page = Page
                };

                var list = await ProjectionsService.Get<List<Projection>>(searchObject);

                dgvProjections.DataSource = list;
                UpdatePagination();
            }
        }
        private async Task LoadMovies()
        {
            var list = await MovieService.Get<List<Movie>>();
            list.Insert(0, new Movie
            {
                MovieId = 0,
                Title = "Any"
            });
            cmbMovie.DataSource = list;
        }
        
        private async Task LoadAuditoriums()
        {
            var list = await AuditoriumService.Get<List<Auditorium>>();
            list.Insert(0, new Auditorium
            {
                AuditoriumId = 0,
                Name = "Any"
            });
            cmbAuditorium.DataSource = list;
        }


        private async void dgvProjections_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProjections.SelectedRows.Count > 0 && dgvProjections.SelectedRows[0].DataBoundItem is Projection item)
            {
                if (new frmProjectionDetails(item).ShowDialog() == DialogResult.OK)
                {
                    await LoadDataGrid();
                }
            }
        }

        private async void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (new frmProjectionDetails().ShowDialog() == DialogResult.OK)
            {
                await LoadDataGrid();
            }
        }

        private void dgvProjections_Enter(object sender, EventArgs e)
        {
            labelHint2.Visible = true;
        }

        private void dgvProjections_Leave(object sender, EventArgs e)
        {
            labelHint2.Visible = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            await LoadDataGrid();
            bool noMoreEntries = dgvProjections.RowCount == 0;
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
            btnNext.Enabled = dgvProjections.RowCount >= PerPage;
            btnPage.Text = $"Page {Page + 1}";
        }

        private async void dgvProjections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvProjections.ColumnCount - 1)
            {
                if (dgvProjections.Rows[e.RowIndex].DataBoundItem is Projection row)
                {
                    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    var result = await ProjectionsService.Delete<Model.Projection>(row.ProjectionId);
                    if (result != null)
                    {
                        await LoadDataGrid();
                    }
                }
            }
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
