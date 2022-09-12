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
    public partial class frmMovieDetails : Form
    {
        public APIService MovieService { get; set; } = new APIService("Movie");
        public APIService GenreService { get; set; } = new APIService("Genre");
        public APIService DirectorsService { get; set; } = new APIService("Director");

        private Movie _model = null;

        public frmMovieDetails()
        {
            InitializeComponent();
            Text = "New Movie";

            numYear.Maximum = DateTime.Now.Year + 1;
        }
        public frmMovieDetails(Movie model) : this()
        {
            _model = model;
            Text = "Movie Details";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var genreList = clbGenres.CheckedItems.Cast<Genre>().ToList();
                var genreIdList = genreList.Select(x => x.GenreId).ToList();

                MovieUpsertRequest request = new MovieUpsertRequest()
                {
                    Title = txtTitle.Text,
                    Description = txtDescription.Text,
                    DirectorId = (cmbDirector.SelectedItem as Director).DirectorId,
                    RunningTime = dtpRunningTime.Value.TimeOfDay.Hours * 60 + dtpRunningTime.Value.TimeOfDay.Minutes,
                    Year = int.Parse(numYear.Value.ToString()),
                    Photo = new byte[0],
                    MovieGenreIdList = genreIdList
                };
                if(pbPhoto.Image != null)
                {
                    request.Photo = ImageHelper.FromImageToByte(pbPhoto.Image);
                }

                Model.Movie entity;

                if (_model == null)
                {
                    entity = await MovieService.Post<Movie>(request);
                }
                else
                {
                    entity = await MovieService.Put<Movie>(_model.MovieId, request);
                }

                if (entity != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private async void frmMovieDetails_Load(object sender, EventArgs e)
        {
            var task1 = LoadGenres();
            var task2 = LoadDirectors();

            if (_model != null)
            {
                txtTitle.Text = _model.Title;
                txtDescription.Text = _model.Description;
                numYear.Value = _model.Year;
                dtpRunningTime.Value = new DateTime(2022, 1, 1, _model.RunningTime / 60, _model.RunningTime % 60, 0);
                if(_model.Photo?.Length > 0)
                {
                    pbPhoto.Image = ImageHelper.FromByteToImage(_model.Photo);
                }
                await task2;
                cmbDirector.SelectedValue = _model.DirectorId;
                await task1;
                foreach(var genre in _model.MovieGenres)
                {
                    for (int i = 0; i < clbGenres.Items.Count; i++)
                    {
                        if (genre.GenreId == (clbGenres.Items[i] as Genre).GenreId)
                        {
                            clbGenres.SetItemChecked(i, true);
                        }
                    }
                }
            }
        }

        private async Task LoadDirectors()
        {
            var list = await DirectorsService.Get<List<Director>>();
            cmbDirector.DataSource = list;
            cmbDirector.ValueMember = "DirectorId";
            cmbDirector.DisplayMember = "FullName";
        }

        private async Task LoadGenres()
        {
            var list = await GenreService.Get<List<Genre>>();
            clbGenres.DataSource = list;
        }

        private void txtTitle_Validating(object sender, CancelEventArgs e)
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

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }

        private void cmbDirector_Validating(object sender, CancelEventArgs e)
        {
            Validator.ValidateControl(sender, errorProvider, e);
        }

    }
}
