using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class N_TURNO
    {
        D_TURNO objDatos = new D_TURNO();

        public DataTable MostrarTurnos()
        {
            return objDatos.MostrarTurnos();
        }

        public DataTable MostrarTurnosAbiertos()
        {
            return objDatos.MostrarTurnosAbiertos();
        }
    }
}
