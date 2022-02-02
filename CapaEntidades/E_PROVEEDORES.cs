using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_PROVEEDORES
    {
        private int _Idproveedor;
        private string _RazonSocial;
        private string _TipoDocumento;
        private string _NoDocumento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Buscar;

        public int Idproveedor { get => _Idproveedor; set => _Idproveedor = value; }
        public string RazonSocial { get => _RazonSocial; set => _RazonSocial = value; }
        public string TipoDocumento { get => _TipoDocumento; set => _TipoDocumento = value; }
        public string NoDocumento { get => _NoDocumento; set => _NoDocumento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }

        
    }
}
