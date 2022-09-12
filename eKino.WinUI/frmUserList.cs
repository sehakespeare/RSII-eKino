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
    public partial class frmUserList : Form
    {
        private readonly APIService UsersService = new("User");
        private int Page = 0;
        private readonly int PerPage = 5;

        public frmUserList()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private async void frmUser_Load(object sender, EventArgs e)
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
            var searchObject = new UserSearchObject
            {
                Username = txtUsername.Text,
                Name = txtName.Text,
                IncludeRoles = true,
                PageSize = PerPage,
                Page = Page
            };

            var list = await UsersService.Get<List<User>>(searchObject);

            dgvUsers.DataSource = list;
            UpdatePagination();
        }

        private async void dgvUsers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0 && dgvUsers.SelectedRows[0].DataBoundItem is User item)
            {
                if (new frmUserDetails(item).ShowDialog() == DialogResult.OK)
                {
                    await LoadDataGrid();
                }
            }
        }

        private async void btnCreateNew_Click(object sender, EventArgs e)
        {
            if (new frmUserDetails().ShowDialog() == DialogResult.OK)
            {
                await LoadDataGrid();
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            lblHint.Visible = true;
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            lblHint.Visible = false;
        }

        private void txtName_Enter(object sender, EventArgs e)
        {
            lblHint.Visible = true;
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            lblHint.Visible = false;
        }

        private void dgvUsers_Enter(object sender, EventArgs e)
        {
            labelHint2.Visible = true;
        }

        private void dgvUsers_Leave(object sender, EventArgs e)
        {
            labelHint2.Visible = false;
        }

        private async void btnNext_Click(object sender, EventArgs e)
        {
            Page++;
            await LoadDataGrid();
            bool noMoreEntries = dgvUsers.RowCount == 0;
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
            btnNext.Enabled = dgvUsers.RowCount >= PerPage;
            btnPage.Text = $"Page {Page + 1}";
        }

        private async void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.ColumnCount - 1)
            {
                if (dgvUsers.Rows[e.RowIndex].DataBoundItem is User row)
                {
                    if(row.Username == APIService.Username)
                    {
                        MessageBox.Show("You cannot delete your own account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (MessageBox.Show("Are you sure?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    {
                        return;
                    }

                    var result = await UsersService.Delete<Model.User>(row.UserId);
                    if (result != null)
                    {
                        await LoadDataGrid();
                    }
                }
            }
        }
    }
}
