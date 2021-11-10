using CapaNegocio;
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
    public partial class frmPrueba : Form
    {
        public frmPrueba()
        {
            InitializeComponent();
        }


        private void MostrarProductos()
        {
            N_PRODUCTO objDatos = new N_PRODUCTO();
            tablaProductos.DataSource = objDatos.MostrarProduto();
            tablaProductos.Columns[2].Visible = false;
            tablaProductos.Columns[5].Visible = false;
            tablaProductos.Columns[7].Visible = false;
            tablaProductos.Columns[0].DisplayIndex = 11;
            tablaProductos.Columns[1].DisplayIndex = 11;
        }

        private void RedimencionCeldas()
        {
            tablaProductos.Columns[3].Width = 70;
            tablaProductos.Columns[4].Width = 100;
            tablaProductos.ClearSelection();
        }

        private void frmPrueba_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            RedimencionCeldas();
        }
    }
}
