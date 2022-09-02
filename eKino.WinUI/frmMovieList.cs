using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eKino.Model;
using Flurl;
using Flurl.Http;

namespace eKino.WinUI
{
    public partial class frmMovieList : Form
    {
        public APIService MovieService { get; set; } = new APIService("Movie");
        public frmMovieList()
        {
            InitializeComponent();
        }

        private async void btnShow_Click(object sender, EventArgs e)
        {
        }
    }
}
