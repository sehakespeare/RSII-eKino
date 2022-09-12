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
    public partial class frmGenreList : Form
    {
        private readonly APIService GenresService = new("Genre");
        private int Page = 0;
        private readonly int PerPage = 5;

        public frmGenreList()
        {
            InitializeComponent();
            dgvGenres.AutoGenerateColumns = false;
        }

        private async void frmGenre_Load(object sender, EventArgs e)
        {
            await LoadDataGrid();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            Page = 0;
            await LoadDataGrid();
        }

        private async Task LoadDataGrid()
        {
            var searchObject = new GenreSearchObject
            {
                Name = txtName.Text,
                PageSize = PerPage,
                Page = Page
            };

            var list = await GenresService.Get<List<Genre>>(searchObject);

            dgvGenres.DataSource = list;
            UpdatePagination();
        }

        private async void dgvGenres_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGenres.SelectedRows.Count > 0 && dgvGenres.SelectedRows[0].DataBoundItem is Genre item)
            {
                if (new frmGenreDetails(item).ShowDialog() == DialogResult.OK)
                {
                    await LoadDataGrid();
                }
            }
        }

        private async void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (new frmGenreDetails().ShowDialog() == DialogResult.OK)
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

        private void dgvGenres_Enter(object sender, EventArgs e)
        {
            labelHint2.Visible = true;
        }

        private void dgvGenres_Leave(object sender, EventArgs e)
        {
            labelHint2.Visible = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            await LoadDataGrid();
            bool noMoreEntries = dgvGenres.RowCount == 0;
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
            btnNext.Enabled = dgvGenres.RowCount >= PerPage;
            btnPage.Text = $"Page {Page + 1}";
        }

        private async void dgvGenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvGenres.ColumnCount - 1)
            {
                if (dgvGenres.Rows[e.RowIndex].DataBoundItem is Genre row)
                {
                    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    var result = await GenresService.Delete<Model.Genre>(row.GenreId);
                    if (result != null)
                    {
                        await LoadDataGrid();
                    }
                }
            }
        }
    }
}
