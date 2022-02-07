using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_CUADRE_CAJA
    {

        private int _Id_cuadre_caja;
        private int _Id_caja;
        private int _Estado;
        private double _Saldo_apertura;
        private double _Saldo_cierre;
        private double _Ventas_totales;
        private string _Fecha;

        public int Id_cuadre_caja { get => _Id_cuadre_caja; set => _Id_cuadre_caja = value; }
        public int Id_caja { get => _Id_caja; set => _Id_caja = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
        public double Saldo_apertura { get => _Saldo_apertura; set => _Saldo_apertura = value; }
        public double Saldo_cierre { get => _Saldo_cierre; set => _Saldo_cierre = value; }
        public double Ventas_totales { get => _Ventas_totales; set => _Ventas_totales = value; }
        public string Fecha { get => _Fecha; set => _Fecha = value; }

        
    }
}
