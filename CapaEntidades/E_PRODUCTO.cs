using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
     public class E_PRODUCTO
    {
        private int _Idproducto;
        private string _Codigo;
        private string _Producto;
        private double _Precio_compra;
        private double _Precio_venta;
        private int _Idcategoria;
        private int _Idmarca;
        private double _Stock;

        public int Idproducto { get => _Idproducto; set => _Idproducto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Producto { get => _Producto; set => _Producto = value; }
        public double Precio_compra { get => _Precio_compra; set => _Precio_compra = value; }
        public double Precio_venta { get => _Precio_venta; set => _Precio_venta = value; }
        public int Idcategoria { get => _Idcategoria; set => _Idcategoria = value; }
        public int Idmarca { get => _Idmarca; set => _Idmarca = value; }
        public double Stock { get => _Stock; set => _Stock = value; }
    }
}
