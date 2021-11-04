using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_CATEGORIA
    {
        private int _Idcategoria;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;

        public int Idcategoria { get => _Idcategoria; set => _Idcategoria = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
    }
}
