using eKino.Model;
using eKino.Model.Requests;
using eKino.WinUI.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace eKino.WinUI
{
    public partial class frmUserDetails : Form
    {
        public APIService UserService { get; set; } = new APIService("User");
        public APIService RoleService { get; set; } = new APIService("Role");

        private User _model = null;

        public frmUserDetails()
        {
            InitializeComponent();
            Text = "New User";
        }
        public frmUserDetails(User model) : this()
        {
            _model = model;
            Text = "User Details";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                var roleList = clbRoles.CheckedItems.Cast<Role>().ToList();
                var roleIdList = roleList.Select(x => x.RoleId).ToList();

                if (_model == null)
                {
                    UserInsertRequest insertRequest = new UserInsertRequest()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhoneNumber.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        PasswordConfirm = txtPasswordConfirm.Text,
                        Status = chkActive.Checked,
                        RoleIdList = roleIdList,
                    };

                    var user = await UserService.Post<User>(insertRequest);
                    if (user != null)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    UserUpdateRequest updateRequest = new UserUpdateRequest()
                    {
                        FirstName = txtFirstName.Text,
                        LastName = txtLastName.Text,
                        Email = txtEmail.Text,
                        Phone = txtPhoneNumber.Text,
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        PasswordConfirm = txtPasswordConfirm.Text,
                        Status = chkActive.Checked,
                        RoleIdList = roleIdList
                    };

                    var user = await UserService.Put<User>(_model.UserId, updateRequest);
                    if (user != null)
                    {
                        DialogResult = DialogResult.OK;
                    }
                }
            }
        }

        private async void frmUserDetails_Load(object sender, EventArgs e)
        {
            await LoadRoles();

            if (_model != null)
            {
                txtFirstName.Text = _model.FirstName;
                txtLastName.Text = _model.LastName;
                txtEmail.Text = _model.Email;
                txtPhoneNumber.Text = _model.Phone;
                txtUsername.Text = _model.Username;
                chkActive.Checked = _model.Status.GetValueOrDefault(false);

                foreach (var role in _model.UserRoles)
                {
                    for (int i = 0; i < clbRoles.Items.Count; i++)
                    {
                        if (role.RoleId == (clbRoles.Items[i] as Role).RoleId)
                        {
                            clbRoles.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private async Task LoadRoles()
        {
            var roles = await RoleService.Get<List<Role>>();
            clbRoles.DataSource = roles;
            clbRoles.DisplayMember = "Name";
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e, email: true);
        }

        private void txtPhoneNumber_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e, regex: @"^[+]?[0-9]{1,3}\s?[0-9]{2,3}\s?[0-9]{3}\s?[0-9]{3,4}$", formatHint: "(+)XXX (X)XX XXX XXX(X), spaces are optional");
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e, minLength: 4);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if(_model == null)
                Validator.ValidateControl(sender, errorProvider, e);
        }

        private void txtPasswordConfirm_Validating(object sender, CancelEventArgs e)
        {
            if(_model == null || !string.IsNullOrEmpty(txtPassword.Text))
                Validator.ValidateControl(sender, errorProvider, e, sameAs: txtPassword.Text);
        }

    }
}
