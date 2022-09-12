using eKino.Model;
using eKino.Model.SearchObjects;
using Flurl.Http;
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
    public partial class frmLogin : Form
    {
        private readonly APIService UserService = new APIService("User");

        public frmLogin()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            Enabled = false;

            APIService.Username = txtUsername.Text;
            APIService.Password = txtPassword.Text;

            try
            {
                var request = new UserSearchObject
                {
                    Username = APIService.Username
                };

                var users = await UserService.Get<List<User>>(request);
                foreach (var user in users)
                {
                    if(user.Username.ToLower() == APIService.Username.ToLower())
                    {
                        if(user.Status == false)
                        {
                            throw new Exception("User account is not active");
                        }
                        else if(!user.UserRoles.Any(x=>x.Role.Name == "Administrator"))
                        {
                            throw new Exception("Administrator role is required to access this application.");
                        }

                        APIService.CurrentUser = user;
                        DialogResult = DialogResult.OK;
                        return;
                    }
                }

                throw new Exception("User account is deleted");

            }
            catch (Exception ex)
            {
                if(ex is FlurlHttpException fhe)
                {
                    if(fhe.StatusCode == 401)
                        MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if(fhe.StatusCode == 403)
                        MessageBox.Show("Access forbidden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("FlurlHttpException: " + fhe.Message, "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Enabled = true;
            }
        }
    }
}
