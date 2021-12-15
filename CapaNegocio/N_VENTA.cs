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
    }
}
