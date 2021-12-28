using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class E_USUARIO
    {
        private int _ID_USUARIO;
        private string _CODIGO;
        private string _NOMBRE;
        private string _USUARIO;
        private string _CONTRASEÑA;
        private int _PERFIL;
        private int _SEXO;
        private string _BUSCAR;

        public int ID_USUARIO { get => _ID_USUARIO; set => _ID_USUARIO = value; }
        public string CODIGO { get => _CODIGO; set => _CODIGO = value; }
        public string NOMBRE { get => _NOMBRE; set => _NOMBRE = value; }
        public string USUARIO { get => _USUARIO; set => _USUARIO = value; }
        public string CONTRASEÑA { get => _CONTRASEÑA; set => _CONTRASEÑA = value; }
        public int PERFIL { get => _PERFIL; set => _PERFIL = value; }
        public int SEXO { get => _SEXO; set => _SEXO = value; }
        public string BUSCAR { get => _BUSCAR; set => _BUSCAR = value; }
    }
}
