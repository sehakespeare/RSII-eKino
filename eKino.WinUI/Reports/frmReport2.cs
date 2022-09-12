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
    public partial class frmReport2 : Form
    {
        private readonly APIService ReservationService = new("Reservation");
        public frmReport2()
        {
            InitializeComponent();
        }

        private async void frmReport2_Load(object sender, EventArgs e)
        {
            await RefreshReport();
        }

        private async Task RefreshReport()
        {
            var request = new ReservationSearchObject
            {
                From = DateTime.Today.AddYears(-1),
                To = DateTime.Today
            };
            var list = await ReservationService.Get<List<Reservation>>(request);

            var rds = new ReportDataSource();

            var table = new dsRevenuePerMonth.dtRevenuePerMonthDataTable();

            foreach (var item in list)
            {
                var row = table.NewdtRevenuePerMonthRow();
                row.Revenue = item.Projection.TicketPrice * item.NumTickets;
                row.Date = new DateTime(item.DateOfReservation.Year, item.DateOfReservation.Month, 1);

                table.AdddtRevenuePerMonthRow(row);
            }

            rds.Name = "RevenuePerMonth";
            rds.Value = table;

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }

    }
}
