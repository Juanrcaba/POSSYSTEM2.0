using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class N_VENTA
    {
        D_VENTA objVenta = new D_VENTA();
        public void InsertarVenta(E_VENTA venta, DataTable Dtable)
        {
            objVenta.InsertarVenta(venta,Dtable);
        }

        public DataTable MostrarVentas(E_VENTA venta)
        {
            return objVenta.MostrarVentas(venta);
        }

        public DataTable MostrarTickets()
        {
            return objVenta.MostrarTickets();
        }

        public void CancelarTicket(E_VENTA venta)
        {
            objVenta.CancelarTicket(venta);
        }
    }
}
