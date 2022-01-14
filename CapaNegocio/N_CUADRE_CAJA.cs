﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;
using System.Data;

namespace CapaNegocio
{
    public class N_CUADRE_CAJA
    {
        D_CUADRE_CAJA objDatos = new D_CUADRE_CAJA();

        public DataTable MostrarCuadreCajas(E_CUADRE_CAJA cuadre)
        {
            return objDatos.MostrarCuadreCajas(cuadre);
        }
        public bool MostrarCuadreCajas()
        {
            return objDatos.MostrarCuadreCajas();
        }

        public bool EstadoCajaDia()
        {
            return objDatos.EstadoCajaDia();
        }
        public int AbrirCajas(E_CUADRE_CAJA cuadre)
        {
            return objDatos.AbrirCajas(cuadre);
        }
        public void CerrarCajas(E_CUADRE_CAJA cuadre)
        {
            objDatos.CerrarCajas(cuadre);
        }
       
        public int Id_CajaAbierta()
        {
            return objDatos.Id_CajaAbierta();
        }

    }
}
