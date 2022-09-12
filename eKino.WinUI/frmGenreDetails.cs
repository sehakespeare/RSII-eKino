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
    public partial class frmGenreDetails : Form
    {
        public APIService GenreService { get; set; } = new APIService("Genre");

        private Genre _model = null;

        public frmGenreDetails()
        {
            InitializeComponent();
            Text = "New Genre";
        }
        public frmGenreDetails(Genre model) : this()
        {
            _model = model;
            Text = "Genre Details";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                GenreUpsertRequest request = new GenreUpsertRequest()
                {
                    Name = txtName.Text
                };
                Model.Genre entity;

                if (_model == null)
                {
                    entity = await GenreService.Post<Genre>(request);
                }
                else
                {
                    entity = await GenreService.Put<Genre>(_model.GenreId, request);
                }

                if (entity != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void frmGenreDetails_Load(object sender, EventArgs e)
        {
            if (_model != null)
            {
                txtName.Text = _model.Name;
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }

    }
}
