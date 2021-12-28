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
    public class N_USUARIO
    {
        D_USUARIO objDatos = new D_USUARIO();

        public DataTable MostrarUsuario(E_USUARIO objUsuario)
        {
            return objDatos.MostrarUsuarios(objUsuario);
        }

        public DataTable MostrarPerfiles()
        {
            return objDatos.MostrarPerfiles();
        }

        public void InsertarDatos(E_USUARIO usuario)
        {
            objDatos.InsertarDatos(usuario);
        }

        public void EditarDatos(E_USUARIO usuario)
        {
            objDatos.EditarDatos(usuario);
        }

        public DataTable Login(E_USUARIO e_objUsuario)
        {
            return objDatos.Login(e_objUsuario);
        }
    }
}
