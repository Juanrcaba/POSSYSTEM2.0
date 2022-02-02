using CapaEntidades;
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
    public partial class frmViewProveedores : Form
    {
        public frmViewProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProveedores formProveedores = new frmProveedores();
            formProveedores.ShowDialog();
            MostrarProveedores("");
        }

        private void frmViewProveedores_Load(object sender, EventArgs e)
        {
            MostrarProveedores("");
        }

        private void MostrarProveedores(string buscar)
        {
            N_PROVEEDORES objDatos = new N_PROVEEDORES();
            E_PROVEEDORES eProveedor = new E_PROVEEDORES();

            eProveedor.Buscar = buscar;
            tablaProveedores.DataSource = objDatos.MostrarProveedores(eProveedor);          

            tablaProveedores.Columns[0].DisplayIndex = 8;
            tablaProveedores.Columns[1].Visible = false;
            Alineamiento(); 
            

            //ContarTotalProducto();
        }

        private void Alineamiento()
        {
            tablaProveedores.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProveedores.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProveedores.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProveedores.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProveedores.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProveedores.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProveedores.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProveedores.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tablaProveedores.ClearSelection();
        }

        private void tablaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaProveedores.CurrentRow.Cells["Edit"].Selected)
            {
                frmProveedores form = new frmProveedores();
                form.IsUpdate = true;
                form.IdProveedor = Convert.ToInt32(tablaProveedores.CurrentRow.Cells[1].Value);
                form.txtRazon.Text = tablaProveedores.CurrentRow.Cells[2].Value.ToString();
                form.cmbTipoDoc.Text = tablaProveedores.CurrentRow.Cells[3].Value.ToString();
                form.txtNoDoc.Text = tablaProveedores.CurrentRow.Cells[4].Value.ToString();
                form.txtDireccion.Text = tablaProveedores.CurrentRow.Cells[5].Value.ToString();
                form.txtTelefono.Text = tablaProveedores.CurrentRow.Cells[6].Value.ToString();
                form.txtEmail.Text = tablaProveedores.CurrentRow.Cells[7].Value.ToString();
               

                form.ShowDialog();
                MostrarProveedores("");
            }
            
        }

    }
}
