using eKino.Model;
using eKino.Model.Requests;
using eKino.WinUI.Helper;
using Flurl.Util;
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
    public partial class frmDirectorDetails : Form
    {
        public APIService DirectorService { get; set; } = new APIService("Director");

        private Director _model = null;

        public frmDirectorDetails()
        {
            InitializeComponent();
            Text = "New Director";
        }
        public frmDirectorDetails(Director model) : this()
        {
            _model = model;
            Text = "Director Details";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                DirectorUpsertRequest request = new DirectorUpsertRequest()
                {
                    FullName = txtName.Text,
                    Biography = txtBiography.Text,
                    Photo = new byte[0]
                };
                if(pbPhoto.Image != null)
                {
                    request.Photo = ImageHelper.FromImageToByte(pbPhoto.Image);
                }

                Model.Director entity;

                if (_model == null)
                {
                    entity = await DirectorService.Post<Director>(request);
                }
                else
                {
                    entity = await DirectorService.Put<Director>(_model.DirectorId, request);
                }

                if (entity != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void frmDirectorDetails_Load(object sender, EventArgs e)
        {
            if (_model != null)
            {
                txtName.Text = _model.FullName;
                txtBiography.Text = _model.Biography;
                if(_model.Photo?.Length > 0)
                {
                    pbPhoto.Image = ImageHelper.FromByteToImage(_model.Photo);
                }
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pbPhoto.Image = Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
