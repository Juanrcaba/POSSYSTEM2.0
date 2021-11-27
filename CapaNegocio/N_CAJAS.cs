using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data;

namespace CapaNegocio
{
    public class N_CAJAS
    {

        D_CAJA objDatos = new D_CAJA();

        public DataTable MostrarCajas()
        {
            return objDatos.MostrarCajas();
        }

        public void InsertarCajas(E_CAJA cajas)
        {
            objDatos.InsertarCajas(cajas);
        }
        public void EditarCajas(E_CAJA cajas)
        {
            objDatos.EditarCajas(cajas);
        }
       

    }
}
