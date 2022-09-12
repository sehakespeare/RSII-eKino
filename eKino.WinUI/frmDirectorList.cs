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
    public partial class frmDirectorList : Form
    {
        private readonly APIService DirectorsService = new("Director");
        private int Page = 0;
        private readonly int PerPage = 5;

        public frmDirectorList()
        {
            InitializeComponent();
            dgvDirectors.AutoGenerateColumns = false;
        }

        private async void frmDirector_Load(object sender, EventArgs e)
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
            var searchObject = new DirectorSearchObject
            {
                FullName = txtName.Text,
                PageSize = PerPage,
                Page = Page
            };

            var list = await DirectorsService.Get<List<Director>>(searchObject);

            dgvDirectors.DataSource = list;
            UpdatePagination();
        }

        private async void dgvDirectors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDirectors.SelectedRows.Count > 0 && dgvDirectors.SelectedRows[0].DataBoundItem is Director item)
            {
                if (new frmDirectorDetails(item).ShowDialog() == DialogResult.OK)
                {
                    await LoadDataGrid();
                }
            }
        }

        private async void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (new frmDirectorDetails().ShowDialog() == DialogResult.OK)
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

        private void dgvDirectors_Enter(object sender, EventArgs e)
        {
            labelHint2.Visible = true;
        }

        private void dgvDirectors_Leave(object sender, EventArgs e)
        {
            labelHint2.Visible = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            await LoadDataGrid();
            bool noMoreEntries = dgvDirectors.RowCount == 0;
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
            btnNext.Enabled = dgvDirectors.RowCount >= PerPage;
            btnPage.Text = $"Page {Page + 1}";
        }

        private async void dgvDirectors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvDirectors.ColumnCount - 1)
            {
                if (dgvDirectors.Rows[e.RowIndex].DataBoundItem is Director row)
                {
                    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    var result = await DirectorsService.Delete<Model.Director>(row.DirectorId);
                    if (result != null)
                    {
                        await LoadDataGrid();
                    }
                }
            }
        }
    }
}
