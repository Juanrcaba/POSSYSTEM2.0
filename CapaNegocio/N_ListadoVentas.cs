using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_ListadoVentas
    {
        public int IDVENTA { get; set; }
        public DateTime FECHA_VENTA { get; set; }
        public string VENDEDOR { get; set; }
        public string PRODUCTOS { get; set; }
        public double MONTOTOTAL { get; set; }
    }
}
