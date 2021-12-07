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
    public class N_DETALLE_MESA
    {
        D_DETALLE_MESA objDetalleMesa = new D_DETALLE_MESA();

        public DataTable MostrarDetalleMesa(E_DETALLE_MESA Dmesa)
        {
            return objDetalleMesa.MostrarDetalleMesa(Dmesa);
        }

        public void InsertarDetalleMesa(E_DETALLE_MESA Dmesa)
        {
            objDetalleMesa.InsertarDetalleMesa(Dmesa);
        }

        public void EditarDetalleMesa(E_DETALLE_MESA Dmesa)
        {
            objDetalleMesa.EditarDetalleMesa(Dmesa);
        }
    }
}
