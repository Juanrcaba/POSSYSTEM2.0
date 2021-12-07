using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_DETALLE_MESA
    {
        private int _Id_detalle_mesa;
        private int _Id_mesa;
        private int _Cantidad;
        private double _Precio;
        private int _Id_producto;

        public int Id_detalle_mesa { get => _Id_detalle_mesa; set => _Id_detalle_mesa = value; }
        public int Id_mesa { get => _Id_mesa; set => _Id_mesa = value; }
        public int Cantidad { get => _Cantidad; set => _Cantidad = value; }
        public double Precio { get => _Precio; set => _Precio = value; }
        public int Id_producto { get => _Id_producto; set => _Id_producto = value; }
    }
}
