using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmAlerta : Form
    {
        public frmAlerta(string mensaje, Alerta type)
        {
            InitializeComponent();
            icon.Image = lstImage.Images[0];
            lblmensaje.Text = mensaje;
            switch (type)
            {
                case Alerta.Exitoso:
                    icon.Image = lstImage.Images[0];
                    lblmensaje.Text = mensaje;
                    lbltitulo.Text = type.ToString();
                    pnlFranja.BackColor = Color.SeaGreen;
                    break;
                case Alerta.Error:
                    icon.Image = lstImage.Images[1];
                    lblmensaje.Text = mensaje;
                    lbltitulo.Text = type.ToString();
                    pnlFranja.BackColor = Color.FromArgb(244, 67, 54);
                    break;
                case Alerta.Información:
                    icon.Image = lstImage.Images[2];
                    lblmensaje.Text = mensaje;
                    lbltitulo.Text = type.ToString();
                    pnlFranja.BackColor = Color.FromArgb(255, 202, 40);
                    break;
                default:
                    break;
            }
        }

        private void frmAlerta_Load(object sender, EventArgs e)
        {
            
        }

        public enum Alerta
        {
            Exitoso, Error, Información
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
