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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            pantallaOK();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnDashboard.Top;
          
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnProductos.Top;
           
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnVentas.Top;
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnCompras.Top;
        }

        private void btnTrabajadores_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnTrabajadores.Top;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnClientes.Top;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnProveedores.Top;
        }

        private void btnGanancias_Click(object sender, EventArgs e)
        {
            Puntero.Top = btnGanancias.Top;
        }

        Form FormActivo = null;

        void ActivarForm(Form FormHijo)
        {
            if (FormActivo == null)
                FormActivo = FormHijo;

        }

       
    }
}
