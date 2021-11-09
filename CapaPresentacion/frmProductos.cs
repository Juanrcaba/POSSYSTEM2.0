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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria form = new frmCategoria();
            form.ShowDialog();

        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarca form = new frmMarca();
            form.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
