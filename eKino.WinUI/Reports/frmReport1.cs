using eKino.Model;
using eKino.Model.SearchObjects;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eKino.WinUI.Reports
{
    public partial class frmReport1 : Form
    {
        private readonly APIService ReservationService = new("Reservation");
        public frmReport1()
        {
            InitializeComponent();
            dtpFrom.Value = DateTime.Today.AddMonths(-4);
            dtpTo.Value = DateTime.Today;
        }

        private async void frmReport1_Load(object sender, EventArgs e)
        {
            await RefreshReport();
        }

        private async Task RefreshReport()
        {
            var request = new ReservationSearchObject
            {
                MovieTitle = txtMovieNameTitle.Text,
                From = dtpFrom.Value.Date,
                To = dtpTo.Value.Date
            };
            var list = await ReservationService.Get<List<Reservation>>(request);

            var rds = new ReportDataSource();

            var table = new dsTicketSalesPoint.dtTicketSalesPointDataTable();

            foreach (var item in list)
            {
                var row = table.NewdtTicketSalesPointRow();
                row.Movie = item.Projection.Movie.Title;
                row.NumTicketsSold = item.NumTickets;
                row.Date = item.DateOfReservation.Date;

                table.AdddtTicketSalesPointRow(row);
            }

            rds.Name = "TicketSales";
            rds.Value = table;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

        private async void btnFilter_Click(object sender, EventArgs e)
        {
            await RefreshReport();
        }
    }
}
