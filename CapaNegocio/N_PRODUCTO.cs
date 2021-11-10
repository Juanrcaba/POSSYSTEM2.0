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
    public class N_PRODUCTO
    {
        D_PRODUCTO objDatos = new D_PRODUCTO();

        public DataTable MostrarProduto()
        {
            return objDatos.MostrarProducto();
        }

        public DataTable BuscarProduto(string buscar)
        {
            return objDatos.BuscarProducto(buscar);
        }

        public void InsertarProducto(E_PRODUCTO producto)
        {
            objDatos.InsertarProductos(producto);
        }
        public void EditarProducto(E_PRODUCTO producto)
        {
            objDatos.EditarProductos(producto);
        }
        public void EliminarProducto(E_PRODUCTO producto)
        {
            objDatos.EliminarProducto(producto);
        }

        public int ContarMarca()
        {
            return objDatos.ContarMarca();
        }
        public int ContarCategoria()
        {
            return objDatos.ContarCategoria();
        }
        public int ContarProducto()
        {
            return objDatos.ContarProducto();
        }
        public int ContarTotalProducto()
        {
            return objDatos.ContarTotalProducto();
        }
    }
}
