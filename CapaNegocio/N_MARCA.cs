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
    public class N_MARCA
    {
        D_MARCA objDatos = new D_MARCA();

        public DataTable MostrarMarca(string buscar)
        {
            return objDatos.MostrarMarca(buscar);
        }

        public void InsertarMarca(E_MARCA categoria)
        {
            objDatos.InsertarMarca(categoria);
        }
        public void EditarMarca(E_MARCA categoria)
        {
            objDatos.EditarMarca(categoria);
        }
        public void EliminarMarca(E_MARCA categoria)
        {
            objDatos.EliminarMarca(categoria);
        }
    }
}
