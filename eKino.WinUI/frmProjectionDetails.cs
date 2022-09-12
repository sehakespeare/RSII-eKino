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
    public partial class frmProjectionDetails : Form
    {
        public APIService ProjectionService { get; set; } = new APIService("Projection");
        public APIService MovieService { get; set; } = new APIService("Movie");
        public APIService AuditoriumService { get; set; } = new APIService("Auditorium");

        private Projection _model = null;

        public frmProjectionDetails()
        {
            InitializeComponent();
            Text = "New Projection";
        }
        public frmProjectionDetails(Projection model) : this()
        {
            _model = model;
            Text = "Projection Details";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var date = dtpDate.Value;

                ProjectionUpsertRequest request = new ProjectionUpsertRequest()
                {
                    AuditoriumId = (cmbAuditorium.SelectedItem as Auditorium).AuditoriumId,
                    DateOfProjection = new DateTime(date.Year, date.Month, date.Day, date.Hour, date.Minute, 0),
                    MovieId = (cmbMovie.SelectedItem as Movie).MovieId,
                    TicketPrice = numTicketPrice.Value
                };
                
                Model.Projection entity;

                if (_model == null)
                {
                    entity = await ProjectionService.Post<Projection>(request);
                }
                else
                {
                    entity = await ProjectionService.Put<Projection>(_model.ProjectionId, request);
                }

                if (entity != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmProjectionDetails_Load(object sender, EventArgs e)
        {
            var task1 = LoadAuditoriums();
            var task2 = LoadMovies();

            if (_model != null)
            {
                numTicketPrice.Value = _model.TicketPrice;
                dtpDate.Value = _model.DateOfProjection;
                await task2;
                cmbAuditorium.SelectedValue = _model.AuditoriumId;
                await task1;
                cmbMovie.SelectedValue = _model.MovieId;
            }
        }

        private async Task LoadMovies()
        {
            var list = await MovieService.Get<List<Movie>>();
            cmbMovie.DataSource = list;
            cmbMovie.ValueMember = "MovieId";
            cmbMovie.DisplayMember = "Title";
        }

        private async Task LoadAuditoriums()
        {
            var list = await AuditoriumService.Get<List<Auditorium>>();
            cmbAuditorium.DataSource = list;
            cmbAuditorium.ValueMember = "AuditoriumId";
            cmbAuditorium.DisplayMember = "Name";
        }

        private void cmbMovie_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }

        private void cmbAuditorium_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }
    }
}
