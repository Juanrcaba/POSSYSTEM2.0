using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_CUADRE_TURNO
    {
        private int _Id_Cuadre_Turno;
        private int _Id_Turno;
        private int _Id_cuadre_caja;
        private double _Saldo_Final;

        public int Id_Cuadre_Turno { get => _Id_Cuadre_Turno; set => _Id_Cuadre_Turno = value; }
        public int Id_Turno { get => _Id_Turno; set => _Id_Turno = value; }
        public int Id_cuadre_caja { get => _Id_cuadre_caja; set => _Id_cuadre_caja = value; }
        public double Saldo_Final { get => _Saldo_Final; set => _Saldo_Final = value; }
    }
}
