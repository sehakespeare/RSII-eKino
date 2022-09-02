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
        public APIService KorisinciService { get; set; } = new APIService("User");

        public frmUserList()
        {
            InitializeComponent();
            dgvKorisinici.AutoGenerateColumns = false;
        }

        private void frmUser_Load(object sender, EventArgs e)
        {

        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
            var searchObject = new UserSearchObject();
            searchObject.Username = txtUsername.Text;
            searchObject.IncludeRoles = true;

            var list = await KorisinciService.Get<List<User>>(searchObject);

            dgvKorisinici.DataSource = list;
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void dgvKorisinici_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var item = dgvKorisinici.SelectedRows[0].DataBoundItem as User;

            frmUserDetails frm = new frmUserDetails(item);
            frm.ShowDialog();
        }
    }
}
