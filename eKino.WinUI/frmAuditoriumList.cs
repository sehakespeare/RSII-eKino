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
    public partial class frmAuditoriumList : Form
    {
        private readonly APIService AuditoriumsService = new("Auditorium");
        private int Page = 0;
        private readonly int PerPage = 5;

        public frmAuditoriumList()
        {
            InitializeComponent();
            dgvAuditoriums.AutoGenerateColumns = false;
        }

        private async void frmAuditorium_Load(object sender, EventArgs e)
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
            var searchObject = new AuditoriumSearchObject
            {
                Name = txtName.Text,
                PageSize = PerPage,
                Page = Page
            };

            var list = await AuditoriumsService.Get<List<Auditorium>>(searchObject);

            dgvAuditoriums.DataSource = list;
            UpdatePagination();
        }

        private async void dgvAuditoriums_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAuditoriums.SelectedRows.Count > 0 && dgvAuditoriums.SelectedRows[0].DataBoundItem is Auditorium item)
            {
                if (new frmAuditoriumDetails(item).ShowDialog() == DialogResult.OK)
                {
                    await LoadDataGrid();
                }
            }
        }

        private async void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (new frmAuditoriumDetails().ShowDialog() == DialogResult.OK)
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

        private void dgvAuditoriums_Enter(object sender, EventArgs e)
        {
            labelHint2.Visible = true;
        }

        private void dgvAuditoriums_Leave(object sender, EventArgs e)
        {
            labelHint2.Visible = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            await LoadDataGrid();
            bool noMoreEntries = dgvAuditoriums.RowCount == 0;
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
            btnNext.Enabled = dgvAuditoriums.RowCount >= PerPage;
            btnPage.Text = $"Page {Page + 1}";
        }

        private async void dgvAuditoriums_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvAuditoriums.ColumnCount - 1)
            {
                if (dgvAuditoriums.Rows[e.RowIndex].DataBoundItem is Auditorium row)
                {
                    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    var result = await AuditoriumsService.Delete<Model.Auditorium>(row.AuditoriumId);
                    if (result != null)
                    {
                        await LoadDataGrid();
                    }
                }
            }
        }
    }
}
