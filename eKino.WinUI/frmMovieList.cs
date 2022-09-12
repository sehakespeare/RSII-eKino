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
    public partial class frmMovieList : Form
    {
        private readonly APIService MoviesService = new("Movie");
        private readonly APIService DirectorsService = new("Director");
        private int Page = 0;
        private readonly int PerPage = 5;

        public frmMovieList()
        {
            InitializeComponent();
            dgvMovies.AutoGenerateColumns = false;
        }

        private async void frmMovie_Load(object sender, EventArgs e)
        {
            await LoadDirectors();
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
                var searchObject = new MovieSearchObject
                {
                    Title = txtTitle.Text,
                    DirectorId = cmbDirector.SelectedIndex > 0 ? (cmbDirector.SelectedItem as Director).DirectorId : null,
                    Year = int.TryParse(txtYear.Text, out int Year) ? Year : null,
                    PageSize = PerPage,
                    Page = Page
                };

                var list = await MoviesService.Get<List<Movie>>(searchObject);

                dgvMovies.DataSource = list;
                UpdatePagination();
            }
        }
        private async Task LoadDirectors()
        {
            var list = await DirectorsService.Get<List<Director>>();
            list.Insert(0, new Director
            {
                DirectorId = 0,
                FullName = "Any"
            });
            cmbDirector.DataSource = list;
        }


        private async void dgvMovies_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMovies.SelectedRows.Count > 0 && dgvMovies.SelectedRows[0].DataBoundItem is Movie item)
            {
                if (new frmMovieDetails(item).ShowDialog() == DialogResult.OK)
                {
                    await LoadDataGrid();
                }
            }
        }

        private async void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (new frmMovieDetails().ShowDialog() == DialogResult.OK)
            {
                await LoadDataGrid();
            }
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            lblHint.Visible = true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            lblHint.Visible = false;
        }

        private void dgvMovies_Enter(object sender, EventArgs e)
        {
            labelHint2.Visible = true;
        }

        private void dgvMovies_Leave(object sender, EventArgs e)
        {
            labelHint2.Visible = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            await LoadDataGrid();
            bool noMoreEntries = dgvMovies.RowCount == 0;
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
            btnNext.Enabled = dgvMovies.RowCount >= PerPage;
            btnPage.Text = $"Page {Page + 1}";
        }

        private async void dgvMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvMovies.ColumnCount - 1)
            {
                if (dgvMovies.Rows[e.RowIndex].DataBoundItem is Movie row)
                {
                    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    var result = await MoviesService.Delete<Model.Movie>(row.MovieId);
                    if (result != null)
                    {
                        await LoadDataGrid();
                    }
                }
            }
        }

        private void txtYear_Validating(object sender, CancelEventArgs e)
        {
            ValidateYear(sender);
        }

        private void ValidateYear(object sender)
        {
            var textbox = sender as TextBox;
            if (!string.IsNullOrEmpty(textbox.Text))
            {
                int Maximum = DateTime.Now.Year + 1;
                if (!int.TryParse(textbox.Text, out int value) || value < 1900 || value > Maximum)
                {
                    errorProvider1.SetError(textbox, "A numeric value between 1900 and " + Maximum + "  is required");
                    return;
                }
            }
            errorProvider1.SetError(textbox, null);
        }

        private void txtYear_TextChanged(object sender, EventArgs e)
        {
            ValidateYear(sender);
        }

        private async void cmbDirector_SelectedIndexChanged(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }
    }
}
