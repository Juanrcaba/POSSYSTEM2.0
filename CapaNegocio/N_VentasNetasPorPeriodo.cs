using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class N_VentasNetasPorPeriodo
    {
        private string _Periodo;
        private double _VentasNetas;

        public string Periodo { get => _Periodo; set => _Periodo = value; }
        public double VentasNetas { get => _VentasNetas; set => _VentasNetas = value; }
    }
}
