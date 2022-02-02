using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;
        }
        E_USUARIO eUsuario = new E_USUARIO();
        N_USUARIO nUsuario = new N_USUARIO();
        frmAlerta formAlerta;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string Cpassword = "";
            string salt = "";
            int Estado = 0;
           
            eUsuario.USUARIO = txtUsuario.Text.Trim();
            DataTable Dt = nUsuario.Login(eUsuario);
            
                

            if (Dt.Rows.Count <= 0)
            {                
                using (formAlerta = new frmAlerta("Nombre Usuario incorrecto", frmAlerta.Alerta.Error))
                {
                    formAlerta.ShowDialog();
                }
            }
            else
            {
                foreach (DataRow row in Dt.Rows)
                {

                    Cpassword = row["CONTRASEÑA"].ToString();
                    salt = row["SALT"].ToString();
                    DatosUsuario.Id_usuario = Convert.ToInt32(row["ID_USUARIO"]);
                    DatosUsuario.Nombre = row["NOMBRE"].ToString();
                    DatosUsuario.perfil = Convert.ToInt32(row["iDPERFIL"].ToString());
                    Estado = Convert.ToInt32(row["ESTADO"].ToString());
                }

                if (Cpassword == EncodePassword(txtPassword.Text, salt))
                {
                    if (Estado == 1)
                    {
                        if (DatosUsuario.perfil == 1)
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
                    else
                    {
                        using (formAlerta = new frmAlerta("Usuario Bloqueado por el Administrador, favor ponerse en contacto", frmAlerta.Alerta.Error))
                        {
                            formAlerta.ShowDialog();
                        }
                        
                    }

                   

                }
                else
                {                    
                    using (formAlerta = new frmAlerta("Contraseña incorrecta", frmAlerta.Alerta.Error))
                    {
                        formAlerta.ShowDialog();
                    }
                }

            }
        }

            private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";

            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                txtUsuario.Text = "USUARIO";

            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {

            if (txtPassword.Text == "CONTRASEÑA")
            {
                txtPassword.Text = "";
                txtPassword.UseSystemPasswordChar = true;

            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                txtPassword.Text = "CONTRASEÑA";
                txtPassword.UseSystemPasswordChar = false;

            }
        }

        //Encriptar contraseñas
        public static string EncodePassword(string pass, string salt) //encrypt password    
        {
            byte[] bytes = Encoding.Unicode.GetBytes(pass);
            byte[] src = Encoding.Unicode.GetBytes(salt);
            byte[] dst = new byte[src.Length + bytes.Length];
            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);
            HashAlgorithm algorithm = SHA512.Create();
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
    }
}
