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
    public partial class frmAuditoriumDetails : Form
    {
        public APIService AuditoriumService { get; set; } = new APIService("Auditorium");

        private Auditorium _model = null;

        public frmAuditoriumDetails()
        {
            InitializeComponent();
            Text = "New Auditorium";
        }
        public frmAuditoriumDetails(Auditorium model) : this()
        {
            _model = model;
            Text = "Auditorium Details";
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {
                AuditoriumUpsertRequest request = new AuditoriumUpsertRequest()
                {
                    Name = txtName.Text
                };
                Model.Auditorium entity;

                if (_model == null)
                {
                    entity = await AuditoriumService.Post<Auditorium>(request);
                }
                else
                {
                    entity = await AuditoriumService.Put<Auditorium>(_model.AuditoriumId, request);
                }

                if (entity != null)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void frmAuditoriumDetails_Load(object sender, EventArgs e)
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
