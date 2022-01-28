using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_MESAS
    {

        D_MESAS objMesa = new D_MESAS();

        public DataTable MostrarMesas()
        {
            return objMesa.MostarMesas();
        }

        public DataTable BalanceMesas(E_MESAS mesa)
        {
            return objMesa.BalanceMesa(mesa);
        }

        public void TraspasoMesa(int _IdDesde, int _IdHasta)
        {
            objMesa.TraspasoMesa(_IdDesde,_IdHasta);
        }
    }
}
