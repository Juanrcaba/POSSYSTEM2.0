using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Microsoft.Reporting.WinForms;

namespace CapaPresentacion
{
    public partial class frmReportes : Form
    {
        public frmReportes()
        {
            InitializeComponent();
        }

        private void frmReportes_Load(object sender, EventArgs e)
        {

            this.Report.RefreshReport();
          
        }

        private void getSalesReport(DateTime startDate, DateTime endDate)
        {
            N_REPORTE_VENTAS reportModel = new N_REPORTE_VENTAS();
            reportModel.createSalesOrderReport(startDate, endDate);

            DataTable dt = new DataTable();
            dt.Columns.Add("endDate");
            dt.Columns.Add("reportDate");
            dt.Columns.Add("startDate");
            dt.Columns.Add("totalNetSales");

            DataRow dr = dt.NewRow();
            dr["endDate"] = reportModel.endDate.ToString();
            dr["startDate"] = reportModel.startDate.ToString();
            dr["reportDate"] = reportModel.reportDate.ToString();
            dr["totalNetSales"] = reportModel.totalNetSales.ToString();

            dt.Rows.Add(dr);            

            ReportDataSource SalesReport = new ReportDataSource("ReporteVentas", dt);
            ReportDataSource SalesListing = new ReportDataSource("ListadoVentas", reportModel.salesListing);
            ReportDataSource netReportByPeriod = new ReportDataSource("VentasNetasPorPeriodo", reportModel.netSalesByPeriod);
            Report.LocalReport.DataSources.Clear();
            Report.LocalReport.DataSources.Add(SalesReport);
            Report.LocalReport.DataSources.Add(SalesListing);
            Report.LocalReport.DataSources.Add(netReportByPeriod);

           // Report.LocalReport.ReportEmbeddedResource = "possystem.report.SalesReport.rdlc";
            Report.LocalReport.Refresh();
            Report.Refresh();
            Report.RefreshReport();
            Report.ProcessingMode = ProcessingMode.Local;
        }

        private void btnHoy_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today;
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void btn7Dias_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-7);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void btnL30dias_Click(object sender, EventArgs e)
        {
            var fromDate = DateTime.Today.AddDays(-30);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void btnAnio_Click(object sender, EventArgs e)
        {
            var fromDate = new DateTime(DateTime.Now.Year, 1, 1);
            var toDate = DateTime.Now;
            getSalesReport(fromDate, toDate);
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            var fromDate = DtDesde.Value;
            var toDate = DtHasta.Value;
            getSalesReport(fromDate, new DateTime(toDate.Year, toDate.Month, toDate.Day, 23, 59, 59));
        }
    }
}
