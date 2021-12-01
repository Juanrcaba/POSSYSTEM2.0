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
    public class N_CUADRE_TURNO
    {
        D_CUADRE_TURNO objDatos = new D_CUADRE_TURNO();

       

        public void AbrirTurno(E_CUADRE_TURNO cuadre)
        {
            objDatos.AbrirTurno(cuadre);
        }
        public void CerrarTurno(E_CUADRE_TURNO cuadre)
        {
            objDatos.CerrarTurno(cuadre);
        }

       
    }
}
