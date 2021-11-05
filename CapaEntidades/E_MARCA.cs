using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
   public class E_MARCA
    {
        private int _Idmarca;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;

        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
