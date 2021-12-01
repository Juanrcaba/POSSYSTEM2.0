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
        private int _Id_Usuario;
        private double _Saldo_Final;
        private double _Saldo_Inicial;

        public int Id_Cuadre_Turno { get => _Id_Cuadre_Turno; set => _Id_Cuadre_Turno = value; }
        public int Id_Turno { get => _Id_Turno; set => _Id_Turno = value; }
        public int Id_cuadre_caja { get => _Id_cuadre_caja; set => _Id_cuadre_caja = value; }
        public double Saldo_Final { get => _Saldo_Final; set => _Saldo_Final = value; }
        public int Id_Usuario { get => _Id_Usuario; set => _Id_Usuario = value; }
        public double Saldo_Inicial { get => _Saldo_Inicial; set => _Saldo_Inicial = value; }
    }
}
