using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_MESAS
    {
        private int _Id_mesa;
        private string _Nombre_mesa;

        public int Id_mesa { get => _Id_mesa; set => _Id_mesa = value; }
        public string Nombre_mesa { get => _Nombre_mesa; set => _Nombre_mesa = value; }

    }
}
