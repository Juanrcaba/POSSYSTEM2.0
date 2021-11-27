using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_CAJA
    {
        private int _Id_caja;
        private string _Codigo;
        private string _Nombre;

        public int Id_caja { get => _Id_caja; set => _Id_caja = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
    }
}
