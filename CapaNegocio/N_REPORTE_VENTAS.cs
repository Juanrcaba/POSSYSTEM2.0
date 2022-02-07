using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class N_REPORTE_VENTAS
    {
        public DateTime reportDate { get; private set; }
        public DateTime startDate { get; private set; }
        public DateTime endDate { get; private set; }
        public List<N_ListadoVentas> salesListing { get; private set; }
        public List<N_VentasNetasPorPeriodo> netSalesByPeriod { get; private set; }
        public double totalNetSales { get; private set; }
        //Methods
        public void createSalesOrderReport(DateTime fromDate, DateTime toDate)
        {
            //implement dates
            reportDate = DateTime.Now;
            startDate = fromDate;
            endDate = toDate;
            //create sales listing
            var oReporte = new D_REPORTES();
            var result = oReporte.getSalesOrder(fromDate, toDate);
            salesListing = new List<N_ListadoVentas>();
            foreach (System.Data.DataRow rows in result.Rows)
            {
                var salesModel = new N_ListadoVentas()
                {
                    IDVENTA = Convert.ToInt32(rows[0]),
                    FECHA_VENTA = Convert.ToDateTime(rows[1]),
                    VENDEDOR = Convert.ToString(rows[2]),
                    PRODUCTOS = Convert.ToString(rows[3]),
                    MONTOTOTAL = Convert.ToDouble(rows[4])
                };
                salesListing.Add(salesModel);
                //calculate total net sales
                totalNetSales += Convert.ToDouble(rows[4]);
            }
            //create net sales by period
            ////create temp list net sales by date
            var listSalesByDate = (from sales in salesListing
                                   group sales by sales.FECHA_VENTA
                       into listSales
                                   select new
                                   {
                                       date = listSales.Key,
                                       amount = listSales.Sum(item => item.MONTOTOTAL)
                                   }).AsEnumerable();
            ////get number of days
            int totalDays = Convert.ToInt32((toDate - fromDate).Days);
            ////group period by days
            if (totalDays <= 7)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("dd-MMM-yyyy")
                           into listSales
                                    select new N_VentasNetasPorPeriodo
                                    {
                                        Periodo = listSales.Key,
                                        VentasNetas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
            ////group period by weeks
            else if (totalDays <= 30)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by
                                    System.Globalization.CultureInfo.CurrentCulture.Calendar.GetWeekOfYear(
                                      sales.date, System.Globalization.CalendarWeekRule.FirstDay, DayOfWeek.Monday)
                        into listSales
                                    select new N_VentasNetasPorPeriodo
                                    {
                                        Periodo = "Week " + listSales.Key.ToString(),
                                        VentasNetas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
            ////group period by months
            else if (totalDays <= 365)
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("MMM-yyyy")
                        into listSales
                                    select new N_VentasNetasPorPeriodo
                                    {
                                        Periodo = listSales.Key,
                                        VentasNetas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
            ////group period by years
            else
            {
                netSalesByPeriod = (from sales in listSalesByDate
                                    group sales by sales.date.ToString("yyyy")
                        into listSales
                                    select new N_VentasNetasPorPeriodo
                                    {
                                        Periodo = listSales.Key,
                                        VentasNetas = listSales.Sum(item => item.amount)
                                    }).ToList();
            }
        }
    }
}
