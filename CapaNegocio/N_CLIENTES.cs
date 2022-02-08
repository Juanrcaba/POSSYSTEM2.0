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
    public class N_CLIENTES
    {
        D_CLIENTES oCliente = new D_CLIENTES();

        public DataTable MostrarClientes(E_CLIENTES oClientes)
        {
            return oCliente.MostrarClientes(oClientes);
        }

        public void InsertarProveedor(E_CLIENTES edcliente)
        {
            oCliente.InsertarClientes(edcliente);
        }
        public void EditarProveedor(E_CLIENTES ecliente)
        {
            oCliente.EditarClientes(ecliente);
        }
    }
}
