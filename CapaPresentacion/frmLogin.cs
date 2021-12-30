using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string user;
        string password;
        int perfil;
        int sexo;
        string nombre;

        N_USUARIO objUsuario = new N_USUARIO();
        E_USUARIO E_objUsuario = new E_USUARIO();

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            user = txtUsuario.Text.Trim();
            password = txtCon.Text.Trim();

            if (user != string.Empty && password != string.Empty)
            {
                E_objUsuario.USUARIO = user;
                E_objUsuario.CONTRASEÑA = password;

                DataTable Dt = objUsuario.Login(E_objUsuario);

                if (Dt.Rows.Count > 0)
                {
                    DatosUsuario.Id_usuario = Convert.ToInt32(Dt.Rows[0][0]);
                    DatosUsuario.perfil = Convert.ToInt32(Dt.Rows[0][5]);
                    DatosUsuario.sexo = Convert.ToInt32(Dt.Rows[0][7]);
                    DatosUsuario.Nombre = Dt.Rows[0][2].ToString();

                    if(DatosUsuario.perfil == 1)
                    {
                        PagePrincipal form = new PagePrincipal();
                        form.Show();
                    }
                    else
                    {
                        frmMesas form = new frmMesas();
                        form.Show();
                    }
                                     
                   
                    this.Hide();

                }
            }
                
                
        }
    }
}
