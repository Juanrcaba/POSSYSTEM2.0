using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_PROVEEDORES
    {
        D_PROVEEDORES oProveedores = new D_PROVEEDORES();

        public DataTable MostrarProveedores(E_PROVEEDORES eProveedores)
        {
            return oProveedores.MostrarProveedores(eProveedores);
        }

        public void InsertarProveedor(E_PROVEEDORES eProveedores)
        {
            oProveedores.InsertarProveedor(eProveedores);
        }
        public void EditarProveedor(E_PROVEEDORES eProveedores)
        {
            oProveedores.EditarProveedor(eProveedores);
        }

    }
}
