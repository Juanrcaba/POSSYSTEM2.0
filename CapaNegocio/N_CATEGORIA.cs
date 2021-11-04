using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class N_CATEGORIA
    {
        D_CATEGORIA objDatos = new D_CATEGORIA();

        public DataTable MostrarCategoria(string buscar)
        {
            return objDatos.MostrarCategoria(buscar);
        }

        public void InsertarCategoria(E_CATEGORIA categoria)
        {
            objDatos.InsertarCategoria(categoria);
        }
        public void EditarCategoria(E_CATEGORIA categoria)
        {
            objDatos.EditarCategoria(categoria);
        }
        public void EliminarCategoria(E_CATEGORIA categoria)
        {
            objDatos.EliminarCategoria(categoria);
        }

    }
}
