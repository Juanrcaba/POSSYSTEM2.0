using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaEntidades
{
    public class E_VENTA
    {
        private int _Id_venta;
        private int _Id_Turno;
        private double _Venta_total;
        private int _Id_mesa;

        private int _Id_producto;
        private double _Cantidad_producto;
        private double _Precio_producto;
        private int _Id_usuario;

        private string _Hora_venta;
        private string _Fecha_ini;
        private string _Fecha_fin;
        private string _Comentario;

        public int Id_venta { get => _Id_venta; set => _Id_venta = value; }
        public int Id_Turno { get => _Id_Turno; set => _Id_Turno = value; }
        public double Venta_total { get => _Venta_total; set => _Venta_total = value; }
        public int Id_producto { get => _Id_producto; set => _Id_producto = value; }
        public double Cantidad_producto { get => _Cantidad_producto; set => _Cantidad_producto = value; }
        public double Precio_producto { get => _Precio_producto; set => _Precio_producto = value; }
        public int Id_mesa { get => _Id_mesa; set => _Id_mesa = value; }
        public int Id_usuario { get => _Id_usuario; set => _Id_usuario = value; }
        public string Fecha_ini { get => _Fecha_ini; set => _Fecha_ini = value; }
        public string Fecha_fin { get => _Fecha_fin; set => _Fecha_fin = value; }
        public string Comentario { get => _Comentario; set => _Comentario = value; }
        public string Hora_venta { get => _Hora_venta; set => _Hora_venta = value; }
    }
}
