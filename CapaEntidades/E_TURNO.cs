using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_TURNO
    {
        private int _Id_turno;
        private int _Nombre;
        private string _Codigo;
        private int _Estado;

        public int Id_turno { get => _Id_turno; set => _Id_turno = value; }
        public int Nombre { get => _Nombre; set => _Nombre = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public int Estado { get => _Estado; set => _Estado = value; }
    }
}
