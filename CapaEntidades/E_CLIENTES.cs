using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_CLIENTES
    {
        private int _Idcliente;
        private string _Nombrecliente;
        private string _TipoDocumento;
        private string _NoDocumento;
        private string _Direccion;
        private string _Telefono;
        private string _Email;
        private string _Buscar;

        public int Idcliente { get => _Idcliente; set => _Idcliente = value; }
        public string Nombrecliente { get => _Nombrecliente; set => _Nombrecliente = value; }
        public string TipoDocumento { get => _TipoDocumento; set => _TipoDocumento = value; }
        public string NoDocumento { get => _NoDocumento; set => _NoDocumento = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
