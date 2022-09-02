using eKino.Model;
using eKino.Model.Requests;
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
    public partial class frmUserDetails : Form
    {
        public APIService UserService { get; set; } = new APIService("User");
        public APIService RoleService { get; set; } = new APIService("Role");

        private User _model = null;

        public frmUserDetails(User model = null)
        {
            InitializeComponent();
            _model = model;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                var roleList = clbUloge.CheckedItems.Cast<Role>().ToList();
                var roleIdList = roleList.Select(x => x.RoleId).ToList();

                if (_model == null)
                {
                    UserInsertRequest insertRequest = new UserInsertRequest()
                    {
                        FirstName = txtIme.Text,
                        LastName = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        PasswordConfirm = txtPasswordPotvrda.Text,
                        Status = chkStatus.Checked,
                        RoleIdList = roleIdList,
                    };

                    var user = await UserService.Post<User>(insertRequest);
                }
                else
                {
                    UserUpdateRequest updateRequest = new UserUpdateRequest()
                    {
                        Ime = txtIme.Text,
                        Prezime = txtPrezime.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        PasswordPotvrda = txtPasswordPotvrda.Text,
                        Status = chkStatus.Checked,
                    };

                    _model = await UserService.Put<User>(_model.UserId, updateRequest);

                }
            }




        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            await LoadRoles();

            if (_model != null)
            {
                txtIme.Text = _model.FirstName;
                txtPrezime.Text = _model.LastName;
                txtEmail.Text = _model.Email;
                txtUsername.Text = _model.Username;
                chkStatus.Checked = _model.Status.GetValueOrDefault(false);
            }
        }

        private async Task LoadRoles()
        {
            var roles = await RoleService.Get<List<Role>>();
            clbUloge.DataSource = roles;
            clbUloge.DisplayMember = "Name";
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                e.Cancel = true;
                txtIme.Focus();
                errorProvider.SetError(txtIme, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtIme, "");
            }
        }
    }
}
